using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Novacode;

namespace DocParser
{
    public partial class frmMain : Form
    {
        #region Fields
        public DocX Document { get; set; }
        public bool DebugMode { get; set; }
        private Dictionary<int, string> map;
        private Dictionary<int, DocFieldDataType> mapTypes;
        private frmViewMap view;

        public Dictionary<int, string> Map { get { return map; } }
        public Dictionary<int, DocFieldDataType> MapTypes { get { return mapTypes; } }

        private string mapName = "<unsaved map>";
        public string MapName { get { return mapName; } }
        #endregion

        public frmMain()
        {
            InitializeComponent();
            map = new Dictionary<int, string>();
            mapTypes = new Dictionary<int, DocFieldDataType>();
            view = new frmViewMap(this);
        }

        #region Expose Map
        public bool Overwrite(string name)
        {
            if (map.ContainsValue(name))
            {
                return (MessageBox.Show(string.Format("You already have a field named '{0}' in the current map.\nOverwrite?", name), "Error: Field Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);
            }
            return true;
        }
        public bool AddMap(string name, int paragraph, DocFieldDataType type)
        {
            if (!map.ContainsValue(name))
            {
                map.Add(paragraph, name);
                mapTypes.Add(paragraph, type);
                UpdateMapInfo();
                return true;
            }
            else
            {
                if (Overwrite(name))
                {
                    //remove old mapping
                    var removeIndex = map.First(x => x.Value == name).Key;
                    map.Remove(removeIndex);
                    mapTypes.Remove(removeIndex);

                    map.Add(paragraph, name);
                    mapTypes.Add(paragraph, type);
                    UpdateMapInfo();
                    return true;
                }
                return false;
            }

        }
        public bool EditMap(string name, int index, DocFieldDataType type)
        {
            if (map[index] != name && map.ContainsValue(name))
            {
                if (Overwrite(name))
                {
                    var removeIndex = map.First(x => x.Value == name).Key;
                    map.Remove(removeIndex);
                    mapTypes.Remove(removeIndex);

                    map[index] = name;
                    mapTypes[index] = type;
                    UpdateMapInfo();
                    return true;
                }
                return false;
            }
            else
            {
                map[index] = name;
                mapTypes[index] = type;
                UpdateMapInfo();
                return true;
            }
        }
        public bool RemoveMap(int index)
        {
            if (!map.ContainsKey(index))
                return false;

            map.Remove(index);
            mapTypes.Remove(index);

            UpdateMapInfo();
            return true;
        }

        private void UpdateMapInfo()
        {
            lblMapName.Text = mapName + " (" + map.Count.ToString() + " keys)";
            view.LoadList();
        }
        #endregion

        #region UI

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Document = DocX.Load(openFileDialog1.FileName);
            lblLoading.Text = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
            GetParagraphs(Document);
            UpdateMapInfo();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileMap.ShowDialog();
        }
        private void saveFileMap_FileOk(object sender, CancelEventArgs e)
        {
            var s = Path.GetFileNameWithoutExtension(saveFileMap.FileName);
            mapName = (s.Length <= 24) ? s : s.Substring(0, 21) + "...";
            SaveMap(map, mapTypes, saveFileMap.FileName);
            UpdateMapInfo();
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileMap.ShowDialog();
        }
        private void openFileMap_FileOk(object sender, CancelEventArgs e)
        {
            LoadMap(openFileMap.FileName);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void listP_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var mapForm = new frmAddEditMap(listP.SelectedIndex, this);
            mapForm.EditMode = map.ContainsKey(listP.SelectedIndex);
            mapForm.Show(); 
            mapForm.Focus();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Discard current map? Unsaved changes will be lost.", "New Map", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                map.Clear();
                mapName = "<unsaved map>";
                UpdateMapInfo();
            }
        }
        private void btnEnablebreak_Click(object sender, EventArgs e)
        {
            DebugMode = !DebugMode;
            btnDebug.Checked = DebugMode;
        }
        private void btnViewMap_Click(object sender, EventArgs e)
        {
            view.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.jwarnes.net/sp/apps/dp/doc/");
        }


        #endregion

        public void GetParagraphs(DocX doc)
        {
            listP.Items.Clear();
            int i = 0;
            foreach (var p in doc.Paragraphs)
            {
                listP.Items.Add(string.Format("[{0}]: {1}\r\n", i, p.Text));
                i++;
            }
            listP.Enabled = (i > 0);

        }

        #region Serialization

        public void SaveMap(Dictionary<int, string> map, Dictionary<int, DocFieldDataType> types, string path)
        {
            var settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("   ");

            using( var w = XmlWriter.Create(path, settings))
            {
                w.WriteStartDocument();
                w.WriteStartElement("Map");
                w.WriteAttributeString("name", mapName);
                foreach (var field in map)
                {
                    w.WriteStartElement("Field");
                        w.WriteAttributeString("name", field.Value);
                        w.WriteAttributeString("paragraph", field.Key.ToString());
                        w.WriteAttributeString("type", types[field.Key].ToString());
                    w.WriteEndElement();
                }
                w.WriteEndElement();
                w.WriteEndDocument();
            }
        }

        public void LoadMap(string path)
        {
            var xml = XElement.Load(path);

            map.Clear();
            mapName = (string)xml.Attribute("name");

            map = xml.Elements("Field")
                .Select(x => new { paragraph = (int)x.Attribute("paragraph"), name = (string)x.Attribute("name") })
                .ToDictionary(x => x.paragraph, x => x.name );

            mapTypes = xml.Elements("Field")
               .Select(x => new { paragraph = (int)x.Attribute("paragraph"), type = (DocFieldDataType)Enum.Parse(typeof(DocFieldDataType), (string)x.Attribute("type")) })
               .ToDictionary(x => x.paragraph, x => x.type);

            UpdateMapInfo();
        }

        #endregion
    }
}

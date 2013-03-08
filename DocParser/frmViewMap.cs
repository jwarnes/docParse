using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocParser
{
    public partial class frmViewMap : Form
    {
        private frmMain parent;
        private List<int> indexList; 
        public frmViewMap(frmMain parent)
        {
            InitializeComponent();
            indexList = new List<int>();
            this.parent = parent;
        }

        private void frmViewMap_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        public void LoadList()
        {
            listFields.Items.Clear();
            indexList.Clear();
            lblMapName.Text = parent.MapName;
            foreach (var f in parent.Map)
            {
                string s = (parent.Document != null && parent.Document.Paragraphs.Count > f.Key)
                    ? string.Format("{0}\t{1}\t({2})", f.Key.ToString().PadLeft(5), f.Value.PadRight(20), shortText(parent.Document.Paragraphs[f.Key].Text, 50))
                    : string.Format("{0}\t{1}", f.Key.ToString().PadLeft(5), f.Value.PadRight(20));
                    
                listFields.Items.Add(s);
                indexList.Add(f.Key);

                
            }
            listFields.Enabled = (listFields.Items.Count > 0);
        }

        private string shortText(string s, int l)
        {
            return (s.Length <= l) ? s : s.Substring(0, l - 3) + "...";
        }

        private void listFields_DoubleClick(object sender, EventArgs e)
        {
            new frmAddEditMap(indexList[listFields.SelectedIndex], parent) { EditMode = true }.Show();
        }

        private void frmViewMap_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}

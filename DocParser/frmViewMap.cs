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
        private Form1 parent;
        private List<int> indexList; 
        public frmViewMap(Form1 parent)
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
                listFields.Items.Add(string.Format("[{0}]\t{1}", f.Key, f.Value));
                indexList.Add(f.Key);
            }
            listFields.Enabled = (listFields.Items.Count > 0);
        }

        private void listFields_DoubleClick(object sender, EventArgs e)
        {
            new frmAddEditMap(indexList[listFields.SelectedIndex], parent) { EditMode = true }.ShowDialog();
        }

        private void frmViewMap_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}

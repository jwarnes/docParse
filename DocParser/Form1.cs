using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Novacode;

namespace DocParser
{
    public partial class Form1 : Form
    {
        public DocX document;

        public bool breakp = false;

        public Form1()
        {
            InitializeComponent();
        }

        #region UI

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            document = DocX.Load(openFileDialog1.FileName);
            lblLoading.Text = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
            PrintDoc(document);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblLoading.Text = "";
        }
        private void listP_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new frmMapField(listP.SelectedIndex, this).Show();
        }

        private void btnEnablebreak_Click(object sender, EventArgs e)
        {
            breakp = !breakp;
            btnDebug.Checked = breakp;
        }
        #endregion

        public void ParseDoc(DocX doc)
        {
            if (breakp) System.Diagnostics.Debugger.Break();
            int estimatedBudget = Convert.ToInt32(doc.Paragraphs[92].Text.Replace("USD $", string.Empty).Replace(",", string.Empty));
            string country = doc.Paragraphs[4].Text;
            DateTime date = DateTime.Parse(doc.Tables[0].Paragraphs[1].Text);
        }

        public void PrintDoc(DocX doc)
        {
            listP.Items.Clear();
            int i = 0;
            foreach (var p in doc.Paragraphs)
            {
                listP.Items.Add(string.Format("[{0}]: {1}\r\n", i, p.Text));
                i++;
            }
        }

        public Dictionary<string, string> MapATP(DocX doc)
        {
            var map = new Dictionary<string, string>();
            map.Add("date", doc.Tables[0].Paragraphs[1].Text);
            return map;
        }



    }
}

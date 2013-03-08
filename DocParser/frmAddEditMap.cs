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
    public partial class frmAddEditMap : Form
    {
        #region Fields
        public bool EditMode { get; set; }
        private Form1 parent;
        private int index;
        #endregion

        public frmAddEditMap(int index, Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.index = index;

            txtParagraph.Text = parent.Document.Paragraphs[index].Text;
            lblParagraphNumber.Text += " [" + index.ToString() + "]";
        }

        private void frmAddEditMap_Load(object sender, EventArgs e)
        {
            this.Text = (EditMode) ? "Edit Field" : "Add New Field";
            if (EditMode)
                txtFieldName.Text = parent.Map[index];
            else
                btnSave.Enabled = false;


            txtFieldName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                if (parent.AddMap(txtFieldName.Text, index))
                    Close();
                else
                    txtFieldName.Focus();
            }
            else
            {
                if (parent.EditMap(txtFieldName.Text, index))
                    Close();
                else
                    txtFieldName.Focus();
            }
        }

        private void txtFieldName_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtFieldName.Text != "" && txtFieldName.Text != "<Enter field name>");
        }
    }
}

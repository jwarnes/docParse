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
        private frmMain parent;
        private int index;
        #endregion

        #region UI

        private void frmAddEditMap_Load(object sender, EventArgs e)
        {
            this.Text = (EditMode) ? "Edit Field" : "Add New Field";
            if (EditMode)
            {
                txtFieldName.Text = parent.Map[index];
                btnUnmap.Enabled = true;
            }
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

        private void btnUnmap_Click(object sender, EventArgs e)
        {
            parent.RemoveMap(index);
            Close();
        }
        #endregion

        public frmAddEditMap(int index, frmMain parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.index = index;

            if (parent.Document != null && parent.Document.Paragraphs.Count > index)
                txtParagraph.Text = parent.Document.Paragraphs[index].Text;
            else
                txtParagraph.Text = "<No data found>";
            lblParagraphNumber.Text += " " + index.ToString();
        }

        private void txtFieldName_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtFieldName.Text != "" && txtFieldName.Text != "<Enter field name>");
        }
    }
}

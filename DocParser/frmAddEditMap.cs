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

        private DocFieldDataType type = DocFieldDataType.Text;
        private List<string> enumValues;
        #endregion

        #region UI

        private void frmAddEditMap_Load(object sender, EventArgs e)
        {
            this.Text = (EditMode) ? "Edit Field" : "Add New Field";
            if (EditMode)
            {
                txtFieldName.Text = parent.Map[index];
                loadType(parent.MapTypes[index]);
                btnUnmap.Enabled = true;
            }
            else
                btnSave.Enabled = false;

            enumValues = new List<string>();
            txtFieldName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                if (parent.AddMap(txtFieldName.Text, index, type))
                    Close();
                else
                    txtFieldName.Focus();
            }
            else
            {
                if (parent.EditMap(txtFieldName.Text, index, type))
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

        private void rb_Click(object sender, EventArgs e)
        {
            this.type = (DocFieldDataType)Enum.Parse(typeof(DocFieldDataType), ((RadioButton)sender).Tag.ToString());
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

        private void loadType(DocFieldDataType type)
        {
            var buttons = new RadioButton[6] { rbCurrency, rbDate, rbList, rbNum, rbText, rbYesNo };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Checked = (buttons[i].Tag.ToString() == type.ToString());
            }
        }


    }
}

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
    public partial class frmMapField : Form
    {
        public int Index { get; set; }
        private Form1 parent;
        public frmMapField(int paragraphIndex)
        {
            InitializeComponent();
            parent = (Form1)ParentForm;

            this.Index = paragraphIndex;
            lblParagraphNumber.Text = "[" + Index.ToString() + "]";

            textBox1.Text = parent.document.Paragraphs[Index].Text;
            
        }
    }
}

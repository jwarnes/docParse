namespace DocParser
{
    partial class frmAddEditMap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbYesNo = new System.Windows.Forms.RadioButton();
            this.rbList = new System.Windows.Forms.RadioButton();
            this.rbCurrency = new System.Windows.Forms.RadioButton();
            this.rbNum = new System.Windows.Forms.RadioButton();
            this.rbDate = new System.Windows.Forms.RadioButton();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.btnUnmap = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblParagraphNumber = new System.Windows.Forms.Label();
            this.txtParagraph = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbYesNo);
            this.panel1.Controls.Add(this.rbList);
            this.panel1.Controls.Add(this.rbCurrency);
            this.panel1.Controls.Add(this.rbNum);
            this.panel1.Controls.Add(this.rbDate);
            this.panel1.Controls.Add(this.rbText);
            this.panel1.Controls.Add(this.txtFieldName);
            this.panel1.Controls.Add(this.btnUnmap);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblParagraphNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 57);
            this.panel1.TabIndex = 0;
            // 
            // rbYesNo
            // 
            this.rbYesNo.AutoSize = true;
            this.rbYesNo.Location = new System.Drawing.Point(315, 34);
            this.rbYesNo.Name = "rbYesNo";
            this.rbYesNo.Size = new System.Drawing.Size(62, 17);
            this.rbYesNo.TabIndex = 7;
            this.rbYesNo.TabStop = true;
            this.rbYesNo.Tag = "Boolean";
            this.rbYesNo.Text = "Yes/No";
            this.rbYesNo.UseVisualStyleBackColor = true;
            this.rbYesNo.Click += new System.EventHandler(this.rb_Click);
            // 
            // rbList
            // 
            this.rbList.AutoSize = true;
            this.rbList.Enabled = false;
            this.rbList.Location = new System.Drawing.Point(265, 34);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(41, 17);
            this.rbList.TabIndex = 6;
            this.rbList.Tag = "List";
            this.rbList.Text = "List";
            this.rbList.UseVisualStyleBackColor = true;
            this.rbList.Click += new System.EventHandler(this.rb_Click);
            // 
            // rbCurrency
            // 
            this.rbCurrency.AutoSize = true;
            this.rbCurrency.Location = new System.Drawing.Point(189, 34);
            this.rbCurrency.Name = "rbCurrency";
            this.rbCurrency.Size = new System.Drawing.Size(67, 17);
            this.rbCurrency.TabIndex = 5;
            this.rbCurrency.Tag = "Decimal";
            this.rbCurrency.Text = "Currency";
            this.rbCurrency.UseVisualStyleBackColor = true;
            this.rbCurrency.Click += new System.EventHandler(this.rb_Click);
            // 
            // rbNum
            // 
            this.rbNum.AutoSize = true;
            this.rbNum.Location = new System.Drawing.Point(118, 34);
            this.rbNum.Name = "rbNum";
            this.rbNum.Size = new System.Drawing.Size(62, 17);
            this.rbNum.TabIndex = 4;
            this.rbNum.Tag = "Integer";
            this.rbNum.Text = "Number";
            this.rbNum.UseVisualStyleBackColor = true;
            this.rbNum.Click += new System.EventHandler(this.rb_Click);
            // 
            // rbDate
            // 
            this.rbDate.AutoSize = true;
            this.rbDate.Location = new System.Drawing.Point(61, 34);
            this.rbDate.Name = "rbDate";
            this.rbDate.Size = new System.Drawing.Size(48, 17);
            this.rbDate.TabIndex = 3;
            this.rbDate.Tag = "Date";
            this.rbDate.Text = "Date";
            this.rbDate.UseVisualStyleBackColor = true;
            this.rbDate.Click += new System.EventHandler(this.rb_Click);
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Checked = true;
            this.rbText.Location = new System.Drawing.Point(6, 34);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(46, 17);
            this.rbText.TabIndex = 2;
            this.rbText.TabStop = true;
            this.rbText.Tag = "Text";
            this.rbText.Text = "Text";
            this.rbText.UseVisualStyleBackColor = true;
            this.rbText.Click += new System.EventHandler(this.rb_Click);
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(90, 7);
            this.txtFieldName.MaxLength = 20;
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(141, 20);
            this.txtFieldName.TabIndex = 0;
            this.txtFieldName.Text = "<Enter field name>";
            this.txtFieldName.TextChanged += new System.EventHandler(this.txtFieldName_TextChanged);
            // 
            // btnUnmap
            // 
            this.btnUnmap.Enabled = false;
            this.btnUnmap.Location = new System.Drawing.Point(318, 6);
            this.btnUnmap.Name = "btnUnmap";
            this.btnUnmap.Size = new System.Drawing.Size(58, 23);
            this.btnUnmap.TabIndex = 1;
            this.btnUnmap.Text = "&Unmap";
            this.btnUnmap.UseVisualStyleBackColor = true;
            this.btnUnmap.Click += new System.EventHandler(this.btnUnmap_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(237, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblParagraphNumber
            // 
            this.lblParagraphNumber.AutoSize = true;
            this.lblParagraphNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParagraphNumber.Location = new System.Drawing.Point(3, 10);
            this.lblParagraphNumber.Name = "lblParagraphNumber";
            this.lblParagraphNumber.Size = new System.Drawing.Size(69, 13);
            this.lblParagraphNumber.TabIndex = 0;
            this.lblParagraphNumber.Text = "Paragraph #:";
            // 
            // txtParagraph
            // 
            this.txtParagraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtParagraph.Location = new System.Drawing.Point(0, 0);
            this.txtParagraph.Multiline = true;
            this.txtParagraph.Name = "txtParagraph";
            this.txtParagraph.ReadOnly = true;
            this.txtParagraph.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtParagraph.Size = new System.Drawing.Size(385, 51);
            this.txtParagraph.TabIndex = 1;
            // 
            // frmAddEditMap
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 108);
            this.Controls.Add(this.txtParagraph);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddEditMap";
            this.Text = "Add/Edit Field";
            this.Load += new System.EventHandler(this.frmAddEditMap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblParagraphNumber;
        private System.Windows.Forms.TextBox txtParagraph;
        private System.Windows.Forms.Button btnUnmap;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.RadioButton rbList;
        private System.Windows.Forms.RadioButton rbCurrency;
        private System.Windows.Forms.RadioButton rbNum;
        private System.Windows.Forms.RadioButton rbDate;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.RadioButton rbYesNo;
    }
}
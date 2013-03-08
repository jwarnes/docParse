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
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblParagraphNumber = new System.Windows.Forms.Label();
            this.txtParagraph = new System.Windows.Forms.TextBox();
            this.btnUnmap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFieldName);
            this.panel1.Controls.Add(this.btnUnmap);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblParagraphNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 32);
            this.panel1.TabIndex = 0;
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(90, 7);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(108, 20);
            this.txtFieldName.TabIndex = 0;
            this.txtFieldName.Text = "<Enter field name>";
            this.txtFieldName.TextChanged += new System.EventHandler(this.txtFieldName_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(204, 6);
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
            this.txtParagraph.Size = new System.Drawing.Size(349, 81);
            this.txtParagraph.TabIndex = 1;
            // 
            // btnUnmap
            // 
            this.btnUnmap.Enabled = false;
            this.btnUnmap.Location = new System.Drawing.Point(285, 6);
            this.btnUnmap.Name = "btnUnmap";
            this.btnUnmap.Size = new System.Drawing.Size(58, 23);
            this.btnUnmap.TabIndex = 1;
            this.btnUnmap.Text = "&Unmap";
            this.btnUnmap.UseVisualStyleBackColor = true;
            this.btnUnmap.Click += new System.EventHandler(this.btnUnmap_Click);
            // 
            // frmAddEditMap
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 113);
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
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblParagraphNumber;
        private System.Windows.Forms.TextBox txtParagraph;
        private System.Windows.Forms.Button btnUnmap;
    }
}
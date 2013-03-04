namespace DocParser
{
    partial class frmMapField
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblParagraphNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSep = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtFieldName = new DocParser.ToolStripText();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStripButton1 = new DocParser.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblParagraphNumber,
            this.tsSep,
            this.txtFieldName,
            this.toolStripButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 82);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(324, 27);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblParagraphNumber
            // 
            this.lblParagraphNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParagraphNumber.Name = "lblParagraphNumber";
            this.lblParagraphNumber.Size = new System.Drawing.Size(32, 22);
            this.lblParagraphNumber.Text = "[P]";
            // 
            // tsSep
            // 
            this.tsSep.Name = "tsSep";
            this.tsSep.Size = new System.Drawing.Size(10, 22);
            this.tsSep.Text = "|";
            // 
            // txtFieldName
            // 
            this.txtFieldName.AutoSize = false;
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(100, 25);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(324, 82);
            this.textBox1.TabIndex = 2;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(104, 25);
            this.toolStripButton1.Text = "Add &Mapping";
            // 
            // frmMapField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 109);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMapField";
            this.Text = "frmMapField";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripStatusLabel lblParagraphNumber;
        private System.Windows.Forms.ToolStripStatusLabel tsSep;
        private ToolStripText txtFieldName;
        private ToolStripButton toolStripButton1;
    }
}
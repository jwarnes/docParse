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
            this.txtParagraph = new System.Windows.Forms.TextBox();
            this.lblParagraphNumber = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblParagraphNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 38);
            this.panel1.TabIndex = 0;
            // 
            // txtParagraph
            // 
            this.txtParagraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtParagraph.Location = new System.Drawing.Point(0, 0);
            this.txtParagraph.Multiline = true;
            this.txtParagraph.Name = "txtParagraph";
            this.txtParagraph.ReadOnly = true;
            this.txtParagraph.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtParagraph.Size = new System.Drawing.Size(284, 223);
            this.txtParagraph.TabIndex = 1;
            // 
            // lblParagraphNumber
            // 
            this.lblParagraphNumber.AutoSize = true;
            this.lblParagraphNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParagraphNumber.Location = new System.Drawing.Point(3, 13);
            this.lblParagraphNumber.Name = "lblParagraphNumber";
            this.lblParagraphNumber.Size = new System.Drawing.Size(28, 16);
            this.lblParagraphNumber.TabIndex = 0;
            this.lblParagraphNumber.Text = "[P]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // frmAddEditMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtParagraph);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddEditMap";
            this.Text = "frmAddEditMap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblParagraphNumber;
        private System.Windows.Forms.TextBox txtParagraph;
    }
}
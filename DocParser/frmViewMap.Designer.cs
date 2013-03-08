namespace DocParser
{
    partial class frmViewMap
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
            this.lblMapName = new System.Windows.Forms.ToolStripStatusLabel();
            this.listFields = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMapName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 116);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMapName
            // 
            this.lblMapName.Name = "lblMapName";
            this.lblMapName.Size = new System.Drawing.Size(103, 17);
            this.lblMapName.Text = "<no map loaded>";
            // 
            // listFields
            // 
            this.listFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFields.FormattingEnabled = true;
            this.listFields.Location = new System.Drawing.Point(0, 0);
            this.listFields.Name = "listFields";
            this.listFields.Size = new System.Drawing.Size(284, 116);
            this.listFields.TabIndex = 1;
            this.listFields.DoubleClick += new System.EventHandler(this.listFields_DoubleClick);
            // 
            // frmViewMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 138);
            this.Controls.Add(this.listFields);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmViewMap";
            this.Text = "Mapped Fields";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewMap_FormClosing);
            this.Load += new System.EventHandler(this.frmViewMap_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblMapName;
        private System.Windows.Forms.ListBox listFields;
    }
}
﻿namespace DocParser
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblLoading = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnImportDoc = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnViewMap = new System.Windows.Forms.ToolStripButton();
            this.btnDebug = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblMapName = new System.Windows.Forms.ToolStripLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listP = new System.Windows.Forms.ListBox();
            this.saveFileMap = new System.Windows.Forms.SaveFileDialog();
            this.openFileMap = new System.Windows.Forms.OpenFileDialog();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLoading});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(349, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblLoading
            // 
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(107, 17);
            this.lblLoading.Text = "<no docx loaded>";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImportDoc,
            this.toolStripSeparator,
            this.btnNew,
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator1,
            this.btnViewMap,
            this.btnDebug,
            this.btnHelp,
            this.toolStripSeparator2,
            this.lblMapName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(349, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnImportDoc
            // 
            this.btnImportDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImportDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnImportDoc.Image")));
            this.btnImportDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportDoc.Name = "btnImportDoc";
            this.btnImportDoc.Size = new System.Drawing.Size(23, 22);
            this.btnImportDoc.Text = "toolStripButton1";
            this.btnImportDoc.ToolTipText = "Import Word Document";
            this.btnImportDoc.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(23, 22);
            this.btnNew.Text = "&New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 22);
            this.btnOpen.Text = "&Open";
            this.btnOpen.ToolTipText = "Open Map";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "&Save";
            this.btnSave.ToolTipText = "Save Map";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnViewMap
            // 
            this.btnViewMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnViewMap.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMap.Image")));
            this.btnViewMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewMap.Name = "btnViewMap";
            this.btnViewMap.Size = new System.Drawing.Size(23, 22);
            this.btnViewMap.Text = "toolStripButton1";
            this.btnViewMap.ToolTipText = "View Field Mappings";
            this.btnViewMap.Click += new System.EventHandler(this.btnViewMap_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDebug.Image = ((System.Drawing.Image)(resources.GetObject("btnDebug.Image")));
            this.btnDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(23, 22);
            this.btnDebug.Text = "toolStripButton1";
            this.btnDebug.ToolTipText = "Debug Mode";
            this.btnDebug.Visible = false;
            this.btnDebug.Click += new System.EventHandler(this.btnEnablebreak_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblMapName
            // 
            this.lblMapName.Name = "lblMapName";
            this.lblMapName.Size = new System.Drawing.Size(94, 22);
            this.lblMapName.Text = "<unsaved map>";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Word 2007/2010 files|*.docx|All Files|*.*\"";
            this.openFileDialog1.Title = "Import Word Document";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // listP
            // 
            this.listP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listP.Enabled = false;
            this.listP.FormattingEnabled = true;
            this.listP.Location = new System.Drawing.Point(0, 25);
            this.listP.Name = "listP";
            this.listP.Size = new System.Drawing.Size(349, 214);
            this.listP.TabIndex = 4;
            this.listP.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listP_MouseDoubleClick);
            // 
            // saveFileMap
            // 
            this.saveFileMap.Filter = "XML Files|*.xml";
            this.saveFileMap.Title = "Save Map";
            this.saveFileMap.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileMap_FileOk);
            // 
            // openFileMap
            // 
            this.openFileMap.Filter = "XML Files|*.xml";
            this.openFileMap.Title = "Load Map";
            this.openFileMap.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileMap_FileOk);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 22);
            this.btnHelp.Text = "He&lp";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 261);
            this.Controls.Add(this.listP);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Docx Field Mapper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblLoading;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton btnDebug;
        private System.Windows.Forms.ListBox listP;
        private System.Windows.Forms.ToolStripButton btnImportDoc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnViewMap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblMapName;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.SaveFileDialog saveFileMap;
        private System.Windows.Forms.OpenFileDialog openFileMap;
        private System.Windows.Forms.ToolStripButton btnHelp;
    }
}


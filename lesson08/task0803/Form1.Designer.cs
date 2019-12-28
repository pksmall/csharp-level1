namespace task0803
{
    partial class Form1
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
            this.txtCsvBox = new System.Windows.Forms.TextBox();
            this.txtXmlBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCsv = new System.Windows.Forms.Label();
            this.lblXml = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCsvBox
            // 
            this.txtCsvBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCsvBox.Location = new System.Drawing.Point(12, 82);
            this.txtCsvBox.Multiline = true;
            this.txtCsvBox.Name = "txtCsvBox";
            this.txtCsvBox.ReadOnly = true;
            this.txtCsvBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCsvBox.Size = new System.Drawing.Size(903, 279);
            this.txtCsvBox.TabIndex = 0;
            // 
            // txtXmlBox
            // 
            this.txtXmlBox.BackColor = System.Drawing.SystemColors.Menu;
            this.txtXmlBox.Location = new System.Drawing.Point(12, 395);
            this.txtXmlBox.Multiline = true;
            this.txtXmlBox.Name = "txtXmlBox";
            this.txtXmlBox.ReadOnly = true;
            this.txtXmlBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXmlBox.Size = new System.Drawing.Size(903, 332);
            this.txtXmlBox.TabIndex = 1;
            this.txtXmlBox.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.convertToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 42);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpen,
            this.miSave,
            this.miSaveAs,
            this.toolStripSeparator1,
            this.miExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(203, 40);
            this.miOpen.Text = "Open";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(203, 40);
            this.miSave.Text = "Save";
            // 
            // miSaveAs
            // 
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.Size = new System.Drawing.Size(203, 40);
            this.miSaveAs.Text = "Save As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(203, 40);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csvXMLToolStripMenuItem,
            this.xMLCSVToolStripMenuItem});
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(103, 34);
            this.convertToolStripMenuItem.Text = "Convert";
            // 
            // csvXMLToolStripMenuItem
            // 
            this.csvXMLToolStripMenuItem.Name = "csvXMLToolStripMenuItem";
            this.csvXMLToolStripMenuItem.Size = new System.Drawing.Size(243, 40);
            this.csvXMLToolStripMenuItem.Text = "CSV -> XML";
            // 
            // xMLCSVToolStripMenuItem
            // 
            this.xMLCSVToolStripMenuItem.Name = "xMLCSVToolStripMenuItem";
            this.xMLCSVToolStripMenuItem.Size = new System.Drawing.Size(243, 40);
            this.xMLCSVToolStripMenuItem.Text = "XML -> CSV";
            // 
            // lblCsv
            // 
            this.lblCsv.AutoSize = true;
            this.lblCsv.Location = new System.Drawing.Point(7, 54);
            this.lblCsv.Name = "lblCsv";
            this.lblCsv.Size = new System.Drawing.Size(55, 25);
            this.lblCsv.TabIndex = 3;
            this.lblCsv.Text = "CSV";
            // 
            // lblXml
            // 
            this.lblXml.AutoSize = true;
            this.lblXml.Location = new System.Drawing.Point(13, 364);
            this.lblXml.Name = "lblXml";
            this.lblXml.Size = new System.Drawing.Size(54, 25);
            this.lblXml.TabIndex = 4;
            this.lblXml.Text = "XML";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 740);
            this.Controls.Add(this.lblXml);
            this.Controls.Add(this.lblCsv);
            this.Controls.Add(this.txtXmlBox);
            this.Controls.Add(this.txtCsvBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CSV - XML";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCsvBox;
        private System.Windows.Forms.TextBox txtXmlBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem miSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csvXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLCSVToolStripMenuItem;
        private System.Windows.Forms.Label lblCsv;
        private System.Windows.Forms.Label lblXml;
    }
}


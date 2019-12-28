namespace task0802
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTrue = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.txtQText = new System.Windows.Forms.TextBox();
            this.lblNumQLbl = new System.Windows.Forms.Label();
            this.lblScoreLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumQTxt = new System.Windows.Forms.Label();
            this.lblScoreTxt = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.miAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.miOpen,
            this.toolStripSeparator1,
            this.miExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(182, 40);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(182, 40);
            this.miOpen.Text = "Open";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(182, 40);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(161, 34);
            this.miAbout.Text = "О программе";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // btnTrue
            // 
            this.btnTrue.Location = new System.Drawing.Point(12, 357);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(170, 62);
            this.btnTrue.TabIndex = 1;
            this.btnTrue.Text = "Верю";
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // btnFalse
            // 
            this.btnFalse.Location = new System.Drawing.Point(584, 357);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(170, 62);
            this.btnFalse.TabIndex = 2;
            this.btnFalse.Text = "Не Верю";
            this.btnFalse.UseVisualStyleBackColor = true;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // txtQText
            // 
            this.txtQText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtQText.Enabled = false;
            this.txtQText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQText.HideSelection = false;
            this.txtQText.Location = new System.Drawing.Point(12, 46);
            this.txtQText.Multiline = true;
            this.txtQText.Name = "txtQText";
            this.txtQText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQText.Size = new System.Drawing.Size(741, 296);
            this.txtQText.TabIndex = 3;
            // 
            // lblNumQLbl
            // 
            this.lblNumQLbl.AutoSize = true;
            this.lblNumQLbl.Location = new System.Drawing.Point(208, 357);
            this.lblNumQLbl.Name = "lblNumQLbl";
            this.lblNumQLbl.Size = new System.Drawing.Size(102, 25);
            this.lblNumQLbl.TabIndex = 4;
            this.lblNumQLbl.Text = "Вопрос №";
            // 
            // lblScoreLbl
            // 
            this.lblScoreLbl.AutoSize = true;
            this.lblScoreLbl.Location = new System.Drawing.Point(470, 357);
            this.lblScoreLbl.Name = "lblScoreLbl";
            this.lblScoreLbl.Size = new System.Drawing.Size(59, 25);
            this.lblScoreLbl.TabIndex = 5;
            this.lblScoreLbl.Text = "Очки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 6;
            // 
            // lblNumQTxt
            // 
            this.lblNumQTxt.AutoSize = true;
            this.lblNumQTxt.Location = new System.Drawing.Point(316, 357);
            this.lblNumQTxt.Name = "lblNumQTxt";
            this.lblNumQTxt.Size = new System.Drawing.Size(19, 25);
            this.lblNumQTxt.TabIndex = 7;
            this.lblNumQTxt.Text = "-";
            // 
            // lblScoreTxt
            // 
            this.lblScoreTxt.AutoSize = true;
            this.lblScoreTxt.Location = new System.Drawing.Point(535, 357);
            this.lblScoreTxt.Name = "lblScoreTxt";
            this.lblScoreTxt.Size = new System.Drawing.Size(19, 25);
            this.lblScoreTxt.TabIndex = 8;
            this.lblScoreTxt.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 447);
            this.Controls.Add(this.lblScoreTxt);
            this.Controls.Add(this.lblNumQTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScoreLbl);
            this.Controls.Add(this.lblNumQLbl);
            this.Controls.Add(this.txtQText);
            this.Controls.Add(this.btnFalse);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Верю-Не-Верю";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.TextBox txtQText;
        private System.Windows.Forms.Label lblNumQLbl;
        private System.Windows.Forms.Label lblScoreLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumQTxt;
        private System.Windows.Forms.Label lblScoreTxt;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}


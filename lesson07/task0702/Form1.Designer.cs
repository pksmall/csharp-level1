namespace task0702
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
            this.txtEnterNum = new System.Windows.Forms.TextBox();
            this.btnRunGame = new System.Windows.Forms.Button();
            this.lblCountTurn = new System.Windows.Forms.Label();
            this.lstViewTurn = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtEnterNum
            // 
            this.txtEnterNum.Location = new System.Drawing.Point(213, 87);
            this.txtEnterNum.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtEnterNum.Name = "txtEnterNum";
            this.txtEnterNum.Size = new System.Drawing.Size(351, 30);
            this.txtEnterNum.TabIndex = 0;
            this.txtEnterNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRunGame
            // 
            this.btnRunGame.Location = new System.Drawing.Point(17, 12);
            this.btnRunGame.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRunGame.Name = "btnRunGame";
            this.btnRunGame.Size = new System.Drawing.Size(122, 39);
            this.btnRunGame.TabIndex = 1;
            this.btnRunGame.Text = "Играть!";
            this.btnRunGame.UseVisualStyleBackColor = true;
            this.btnRunGame.Click += new System.EventHandler(this.btnRunGame_Click);
            // 
            // lblCountTurn
            // 
            this.lblCountTurn.AutoSize = true;
            this.lblCountTurn.Location = new System.Drawing.Point(213, 12);
            this.lblCountTurn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountTurn.Name = "lblCountTurn";
            this.lblCountTurn.Size = new System.Drawing.Size(0, 24);
            this.lblCountTurn.TabIndex = 3;
            // 
            // lstViewTurn
            // 
            this.lstViewTurn.HideSelection = false;
            this.lstViewTurn.Location = new System.Drawing.Point(17, 162);
            this.lstViewTurn.Name = "lstViewTurn";
            this.lstViewTurn.Size = new System.Drawing.Size(766, 164);
            this.lstViewTurn.TabIndex = 4;
            this.lstViewTurn.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 338);
            this.Controls.Add(this.lstViewTurn);
            this.Controls.Add(this.lblCountTurn);
            this.Controls.Add(this.btnRunGame);
            this.Controls.Add(this.txtEnterNum);
            this.Font = new System.Drawing.Font("Lucida Console", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnterNum;
        private System.Windows.Forms.Button btnRunGame;
        private System.Windows.Forms.Label lblCountTurn;
        private System.Windows.Forms.ListView lstViewTurn;
    }
}


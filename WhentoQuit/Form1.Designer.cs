namespace WhentoQuit
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMid = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLoss = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLivesLeft = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtStreak = new System.Windows.Forms.TextBox();
            this.lblNullStart = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(94, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(182, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Win Streak to Gain Life";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(182, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Starting Lives";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMid);
            this.panel1.Controls.Add(this.lblLosses);
            this.panel1.Controls.Add(this.lblWins);
            this.panel1.Controls.Add(this.lblLoss);
            this.panel1.Controls.Add(this.lblWin);
            this.panel1.Controls.Add(this.lblLivesLeft);
            this.panel1.Location = new System.Drawing.Point(33, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 263);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // lblMid
            // 
            this.lblMid.AutoSize = true;
            this.lblMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMid.ForeColor = System.Drawing.Color.White;
            this.lblMid.Location = new System.Drawing.Point(198, 229);
            this.lblMid.Name = "lblMid";
            this.lblMid.Size = new System.Drawing.Size(19, 25);
            this.lblMid.TabIndex = 5;
            this.lblMid.Text = ":";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.ForeColor = System.Drawing.Color.White;
            this.lblLosses.Location = new System.Drawing.Point(239, 235);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(13, 13);
            this.lblLosses.TabIndex = 4;
            this.lblLosses.Text = "0";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.ForeColor = System.Drawing.Color.White;
            this.lblWins.Location = new System.Drawing.Point(163, 235);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(13, 13);
            this.lblWins.TabIndex = 3;
            this.lblWins.Text = "0";
            // 
            // lblLoss
            // 
            this.lblLoss.AutoSize = true;
            this.lblLoss.BackColor = System.Drawing.Color.Red;
            this.lblLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoss.ForeColor = System.Drawing.Color.Black;
            this.lblLoss.Location = new System.Drawing.Point(274, 230);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(48, 22);
            this.lblLoss.TabIndex = 2;
            this.lblLoss.Text = "Loss";
            this.lblLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoss.Click += new System.EventHandler(this.LblLossClick);
            this.lblLoss.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblLossMouseDown);
            this.lblLoss.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LblLossMouseUp);
            // 
            // lblWin
            // 
            this.lblWin.BackColor = System.Drawing.Color.Lime;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.Black;
            this.lblWin.Location = new System.Drawing.Point(93, 230);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(48, 22);
            this.lblWin.TabIndex = 1;
            this.lblWin.Text = "Win";
            this.lblWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWin.Click += new System.EventHandler(this.LblWinClick);
            this.lblWin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblWinMouseDown);
            this.lblWin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LblWinMouseUp);
            // 
            // lblLivesLeft
            // 
            this.lblLivesLeft.AutoSize = true;
            this.lblLivesLeft.ForeColor = System.Drawing.Color.White;
            this.lblLivesLeft.Location = new System.Drawing.Point(179, 62);
            this.lblLivesLeft.Name = "lblLivesLeft";
            this.lblLivesLeft.Size = new System.Drawing.Size(0, 13);
            this.lblLivesLeft.TabIndex = 0;
            this.lblLivesLeft.Text = this.txtStart.Text;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(76, 50);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 20);
            this.txtStart.TabIndex = 0;
            // 
            // txtStreak
            // 
            this.txtStreak.Location = new System.Drawing.Point(76, 135);
            this.txtStreak.Name = "txtStreak";
            this.txtStreak.Size = new System.Drawing.Size(100, 20);
            this.txtStreak.TabIndex = 1;
            // 
            // lblNullStart
            // 
            this.lblNullStart.AutoSize = true;
            this.lblNullStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNullStart.ForeColor = System.Drawing.Color.Red;
            this.lblNullStart.Location = new System.Drawing.Point(74, 73);
            this.lblNullStart.Name = "lblNullStart";
            this.lblNullStart.Size = new System.Drawing.Size(84, 9);
            this.lblNullStart.TabIndex = 6;
            this.lblNullStart.Tag = "";
            this.lblNullStart.Text = "Please Enter a Number";
            this.lblNullStart.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(469, 310);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStreak);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.lblNullStart);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLivesLeft; // CHEWY: Change to lbllivesLeft: More declarative. 
        private System.Windows.Forms.Label lblLoss;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblMid;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.TextBox txtStreak;
        public System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lblNullStart;
    }
}


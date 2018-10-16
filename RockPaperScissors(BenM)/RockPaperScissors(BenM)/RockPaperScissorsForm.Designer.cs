namespace RockPaperScissors_BenM_
{
    partial class frmRockPaperScissors
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
            this.grbplayercheck = new System.Windows.Forms.GroupBox();
            this.grbcomputercheck = new System.Windows.Forms.GroupBox();
            this.radUserRock = new System.Windows.Forms.RadioButton();
            this.radUserPaper = new System.Windows.Forms.RadioButton();
            this.radUserScissors = new System.Windows.Forms.RadioButton();
            this.radComputerRock = new System.Windows.Forms.RadioButton();
            this.radComputerPaper = new System.Windows.Forms.RadioButton();
            this.radComputerScissors = new System.Windows.Forms.RadioButton();
            this.lblUsersChoice = new System.Windows.Forms.Label();
            this.lblCpuPick = new System.Windows.Forms.Label();
            this.btnCheckAns = new System.Windows.Forms.Button();
            this.lblWhoWins = new System.Windows.Forms.Label();
            this.grbplayercheck.SuspendLayout();
            this.grbcomputercheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbplayercheck
            // 
            this.grbplayercheck.Controls.Add(this.radUserScissors);
            this.grbplayercheck.Controls.Add(this.radUserPaper);
            this.grbplayercheck.Controls.Add(this.radUserRock);
            this.grbplayercheck.Location = new System.Drawing.Point(27, 38);
            this.grbplayercheck.Name = "grbplayercheck";
            this.grbplayercheck.Size = new System.Drawing.Size(120, 123);
            this.grbplayercheck.TabIndex = 0;
            this.grbplayercheck.TabStop = false;
            // 
            // grbcomputercheck
            // 
            this.grbcomputercheck.Controls.Add(this.radComputerScissors);
            this.grbcomputercheck.Controls.Add(this.radComputerPaper);
            this.grbcomputercheck.Controls.Add(this.radComputerRock);
            this.grbcomputercheck.Enabled = false;
            this.grbcomputercheck.Location = new System.Drawing.Point(27, 209);
            this.grbcomputercheck.Name = "grbcomputercheck";
            this.grbcomputercheck.Size = new System.Drawing.Size(120, 115);
            this.grbcomputercheck.TabIndex = 1;
            this.grbcomputercheck.TabStop = false;
            // 
            // radUserRock
            // 
            this.radUserRock.AutoSize = true;
            this.radUserRock.Location = new System.Drawing.Point(6, 19);
            this.radUserRock.Name = "radUserRock";
            this.radUserRock.Size = new System.Drawing.Size(51, 17);
            this.radUserRock.TabIndex = 0;
            this.radUserRock.TabStop = true;
            this.radUserRock.Text = "Rock";
            this.radUserRock.UseVisualStyleBackColor = true;
            // 
            // radUserPaper
            // 
            this.radUserPaper.AutoSize = true;
            this.radUserPaper.Location = new System.Drawing.Point(6, 42);
            this.radUserPaper.Name = "radUserPaper";
            this.radUserPaper.Size = new System.Drawing.Size(53, 17);
            this.radUserPaper.TabIndex = 1;
            this.radUserPaper.TabStop = true;
            this.radUserPaper.Text = "Paper";
            this.radUserPaper.UseVisualStyleBackColor = true;
            // 
            // radUserScissors
            // 
            this.radUserScissors.AutoSize = true;
            this.radUserScissors.Location = new System.Drawing.Point(6, 65);
            this.radUserScissors.Name = "radUserScissors";
            this.radUserScissors.Size = new System.Drawing.Size(64, 17);
            this.radUserScissors.TabIndex = 2;
            this.radUserScissors.TabStop = true;
            this.radUserScissors.Text = "Scissors";
            this.radUserScissors.UseVisualStyleBackColor = true;
            this.radUserScissors.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radComputerRock
            // 
            this.radComputerRock.AutoSize = true;
            this.radComputerRock.Location = new System.Drawing.Point(6, 19);
            this.radComputerRock.Name = "radComputerRock";
            this.radComputerRock.Size = new System.Drawing.Size(51, 17);
            this.radComputerRock.TabIndex = 3;
            this.radComputerRock.TabStop = true;
            this.radComputerRock.Text = "Rock";
            this.radComputerRock.UseVisualStyleBackColor = true;
            // 
            // radComputerPaper
            // 
            this.radComputerPaper.AutoSize = true;
            this.radComputerPaper.Location = new System.Drawing.Point(6, 42);
            this.radComputerPaper.Name = "radComputerPaper";
            this.radComputerPaper.Size = new System.Drawing.Size(53, 17);
            this.radComputerPaper.TabIndex = 4;
            this.radComputerPaper.TabStop = true;
            this.radComputerPaper.Text = "Paper";
            this.radComputerPaper.UseVisualStyleBackColor = true;
            // 
            // radComputerScissors
            // 
            this.radComputerScissors.AutoSize = true;
            this.radComputerScissors.Location = new System.Drawing.Point(6, 65);
            this.radComputerScissors.Name = "radComputerScissors";
            this.radComputerScissors.Size = new System.Drawing.Size(64, 17);
            this.radComputerScissors.TabIndex = 5;
            this.radComputerScissors.TabStop = true;
            this.radComputerScissors.Text = "Scissors";
            this.radComputerScissors.UseVisualStyleBackColor = true;
            // 
            // lblUsersChoice
            // 
            this.lblUsersChoice.AutoSize = true;
            this.lblUsersChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersChoice.Location = new System.Drawing.Point(24, 19);
            this.lblUsersChoice.Name = "lblUsersChoice";
            this.lblUsersChoice.Size = new System.Drawing.Size(83, 16);
            this.lblUsersChoice.TabIndex = 6;
            this.lblUsersChoice.Text = "Choose One";
            // 
            // lblCpuPick
            // 
            this.lblCpuPick.AutoSize = true;
            this.lblCpuPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuPick.Location = new System.Drawing.Point(24, 190);
            this.lblCpuPick.Name = "lblCpuPick";
            this.lblCpuPick.Size = new System.Drawing.Size(105, 16);
            this.lblCpuPick.TabIndex = 7;
            this.lblCpuPick.Text = "Computer\'s Pick";
            // 
            // btnCheckAns
            // 
            this.btnCheckAns.Location = new System.Drawing.Point(171, 159);
            this.btnCheckAns.Name = "btnCheckAns";
            this.btnCheckAns.Size = new System.Drawing.Size(108, 31);
            this.btnCheckAns.TabIndex = 8;
            this.btnCheckAns.Text = "Click Me to Play!";
            this.btnCheckAns.UseVisualStyleBackColor = true;
            this.btnCheckAns.Click += new System.EventHandler(this.btnCheckAns_Click);
            // 
            // lblWhoWins
            // 
            this.lblWhoWins.AutoSize = true;
            this.lblWhoWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhoWins.Location = new System.Drawing.Point(168, 252);
            this.lblWhoWins.Name = "lblWhoWins";
            this.lblWhoWins.Size = new System.Drawing.Size(32, 16);
            this.lblWhoWins.TabIndex = 9;
            this.lblWhoWins.Text = "XXX";
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 371);
            this.Controls.Add(this.lblWhoWins);
            this.Controls.Add(this.btnCheckAns);
            this.Controls.Add(this.lblCpuPick);
            this.Controls.Add(this.lblUsersChoice);
            this.Controls.Add(this.grbcomputercheck);
            this.Controls.Add(this.grbplayercheck);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.frmRockPaperScissors_Load);
            this.grbplayercheck.ResumeLayout(false);
            this.grbplayercheck.PerformLayout();
            this.grbcomputercheck.ResumeLayout(false);
            this.grbcomputercheck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbplayercheck;
        private System.Windows.Forms.RadioButton radUserScissors;
        private System.Windows.Forms.RadioButton radUserPaper;
        private System.Windows.Forms.RadioButton radUserRock;
        private System.Windows.Forms.GroupBox grbcomputercheck;
        private System.Windows.Forms.RadioButton radComputerScissors;
        private System.Windows.Forms.RadioButton radComputerPaper;
        private System.Windows.Forms.RadioButton radComputerRock;
        private System.Windows.Forms.Label lblUsersChoice;
        private System.Windows.Forms.Label lblCpuPick;
        private System.Windows.Forms.Button btnCheckAns;
        private System.Windows.Forms.Label lblWhoWins;
    }
}


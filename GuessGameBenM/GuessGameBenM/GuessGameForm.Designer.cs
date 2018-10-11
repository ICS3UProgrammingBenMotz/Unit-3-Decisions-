namespace GuessGameBenM
{
    partial class frmGuessGame
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
            this.lblGuessN = new System.Windows.Forms.Label();
            this.nudGuessN = new System.Windows.Forms.NumericUpDown();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblRightWrong = new System.Windows.Forms.Label();
            this.picRightWrong = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuessN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuessN
            // 
            this.lblGuessN.AutoSize = true;
            this.lblGuessN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessN.Location = new System.Drawing.Point(65, 91);
            this.lblGuessN.Name = "lblGuessN";
            this.lblGuessN.Size = new System.Drawing.Size(273, 24);
            this.lblGuessN.TabIndex = 0;
            this.lblGuessN.Text = "Guess a Number Between 1-10";
            // 
            // nudGuessN
            // 
            this.nudGuessN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGuessN.Location = new System.Drawing.Point(344, 92);
            this.nudGuessN.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGuessN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGuessN.Name = "nudGuessN";
            this.nudGuessN.Size = new System.Drawing.Size(120, 26);
            this.nudGuessN.TabIndex = 1;
            this.nudGuessN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(59, 189);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(130, 60);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check Your Answer";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblRightWrong
            // 
            this.lblRightWrong.AutoSize = true;
            this.lblRightWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightWrong.Location = new System.Drawing.Point(65, 322);
            this.lblRightWrong.Name = "lblRightWrong";
            this.lblRightWrong.Size = new System.Drawing.Size(80, 24);
            this.lblRightWrong.TabIndex = 3;
            this.lblRightWrong.Text = "XXXXX";
            // 
            // picRightWrong
            // 
            this.picRightWrong.Image = global::GuessGameBenM.Properties.Resources.checkmark;
            this.picRightWrong.Location = new System.Drawing.Point(387, 298);
            this.picRightWrong.Name = "picRightWrong";
            this.picRightWrong.Size = new System.Drawing.Size(133, 91);
            this.picRightWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRightWrong.TabIndex = 4;
            this.picRightWrong.TabStop = false;
            // 
            // frmGuessGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 456);
            this.Controls.Add(this.picRightWrong);
            this.Controls.Add(this.lblRightWrong);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.nudGuessN);
            this.Controls.Add(this.lblGuessN);
            this.Name = "frmGuessGame";
            this.Text = "Guess Game";
            this.Load += new System.EventHandler(this.frmGuessGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGuessN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuessN;
        private System.Windows.Forms.NumericUpDown nudGuessN;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblRightWrong;
        private System.Windows.Forms.PictureBox picRightWrong;
    }
}


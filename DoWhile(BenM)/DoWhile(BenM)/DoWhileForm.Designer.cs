namespace DoWhile_BenM_
{
    partial class frmDoWhile
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
            this.prbBar = new System.Windows.Forms.ProgressBar();
            this.btnPressMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prbBar
            // 
            this.prbBar.Location = new System.Drawing.Point(90, 191);
            this.prbBar.Name = "prbBar";
            this.prbBar.Size = new System.Drawing.Size(213, 67);
            this.prbBar.TabIndex = 0;
            // 
            // btnPressMe
            // 
            this.btnPressMe.Location = new System.Drawing.Point(132, 115);
            this.btnPressMe.Name = "btnPressMe";
            this.btnPressMe.Size = new System.Drawing.Size(128, 37);
            this.btnPressMe.TabIndex = 1;
            this.btnPressMe.Text = "Press Me";
            this.btnPressMe.UseVisualStyleBackColor = true;
            this.btnPressMe.Click += new System.EventHandler(this.btnPressMe_Click);
            // 
            // frmDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 335);
            this.Controls.Add(this.btnPressMe);
            this.Controls.Add(this.prbBar);
            this.Name = "frmDoWhile";
            this.Text = "Do While";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prbBar;
        private System.Windows.Forms.Button btnPressMe;
    }
}


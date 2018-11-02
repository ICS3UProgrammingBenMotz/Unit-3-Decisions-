namespace ChangingColour_BenM_
{
    partial class frmChangingCol
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
            this.lblChange = new System.Windows.Forms.Label();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(200, 217);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(95, 20);
            this.lblChange.TabIndex = 0;
            this.lblChange.Text = "Change Me!";
            this.lblChange.Click += new System.EventHandler(this.lblChange_Click);
            // 
            // btnClickMe
            // 
            this.btnClickMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickMe.Location = new System.Drawing.Point(152, 68);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(195, 88);
            this.btnClickMe.TabIndex = 1;
            this.btnClickMe.Text = "CLICK ME!";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // frmChangingCol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 359);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.lblChange);
            this.Name = "frmChangingCol";
            this.Text = "Chanigng Colour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Button btnClickMe;
    }
}


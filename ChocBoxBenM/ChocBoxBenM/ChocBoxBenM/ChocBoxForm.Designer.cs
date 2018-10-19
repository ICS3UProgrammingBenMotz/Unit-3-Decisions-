namespace ChocBoxBenM
{
    partial class frmChocBox
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
            this.lblNumbOfBoxesSold = new System.Windows.Forms.Label();
            this.nudNumbOfBox = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblReward = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumbOfBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumbOfBoxesSold
            // 
            this.lblNumbOfBoxesSold.AutoSize = true;
            this.lblNumbOfBoxesSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbOfBoxesSold.Location = new System.Drawing.Point(68, 69);
            this.lblNumbOfBoxesSold.Name = "lblNumbOfBoxesSold";
            this.lblNumbOfBoxesSold.Size = new System.Drawing.Size(295, 24);
            this.lblNumbOfBoxesSold.TabIndex = 0;
            this.lblNumbOfBoxesSold.Text = "How many boxes did you deliver?";
            // 
            // nudNumbOfBox
            // 
            this.nudNumbOfBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumbOfBox.Location = new System.Drawing.Point(376, 67);
            this.nudNumbOfBox.Name = "nudNumbOfBox";
            this.nudNumbOfBox.Size = new System.Drawing.Size(120, 29);
            this.nudNumbOfBox.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(153, 145);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(157, 64);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReward.Location = new System.Drawing.Point(68, 296);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(150, 24);
            this.lblReward.TabIndex = 3;
            this.lblReward.Text = "XXXXXXXXXX";
            this.lblReward.Click += new System.EventHandler(this.lblReward_Click);
            // 
            // frmChocBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 427);
            this.Controls.Add(this.lblReward);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudNumbOfBox);
            this.Controls.Add(this.lblNumbOfBoxesSold);
            this.Name = "frmChocBox";
            this.Text = "Choc Box";
            this.Load += new System.EventHandler(this.frmChocBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumbOfBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumbOfBoxesSold;
        private System.Windows.Forms.NumericUpDown nudNumbOfBox;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblReward;
    }
}


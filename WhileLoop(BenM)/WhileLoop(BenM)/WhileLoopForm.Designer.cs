namespace WhileLoop_BenM_
{
    partial class frmWhileLoop
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
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.lblEnterPerfectSquare = new System.Windows.Forms.Label();
            this.lstPerfectSquares = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(183, 96);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(120, 20);
            this.nudNumber.TabIndex = 0;
            // 
            // lblEnterPerfectSquare
            // 
            this.lblEnterPerfectSquare.AutoSize = true;
            this.lblEnterPerfectSquare.Location = new System.Drawing.Point(199, 54);
            this.lblEnterPerfectSquare.Name = "lblEnterPerfectSquare";
            this.lblEnterPerfectSquare.Size = new System.Drawing.Size(82, 13);
            this.lblEnterPerfectSquare.TabIndex = 1;
            this.lblEnterPerfectSquare.Text = "Enter a number!";
            // 
            // lstPerfectSquares
            // 
            this.lstPerfectSquares.FormattingEnabled = true;
            this.lstPerfectSquares.Location = new System.Drawing.Point(183, 182);
            this.lstPerfectSquares.Name = "lstPerfectSquares";
            this.lstPerfectSquares.Size = new System.Drawing.Size(132, 147);
            this.lstPerfectSquares.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(183, 134);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 29);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmWhileLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 451);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lstPerfectSquares);
            this.Controls.Add(this.lblEnterPerfectSquare);
            this.Controls.Add(this.nudNumber);
            this.Name = "frmWhileLoop";
            this.Text = "Perfect Squares";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Label lblEnterPerfectSquare;
        private System.Windows.Forms.ListBox lstPerfectSquares;
        private System.Windows.Forms.Button btnCalculate;
    }
}


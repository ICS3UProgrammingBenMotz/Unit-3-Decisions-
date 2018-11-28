namespace FactorialCounter_BenM_
{
    partial class frmFactorial
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
            this.lstFactorials = new System.Windows.Forms.ListBox();
            this.lblQ = new System.Windows.Forms.Label();
            this.txtNumb = new System.Windows.Forms.TextBox();
            this.lblFactorialAns = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFactorials
            // 
            this.lstFactorials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFactorials.FormattingEnabled = true;
            this.lstFactorials.ItemHeight = 20;
            this.lstFactorials.Location = new System.Drawing.Point(60, 204);
            this.lstFactorials.Name = "lstFactorials";
            this.lstFactorials.Size = new System.Drawing.Size(239, 244);
            this.lstFactorials.TabIndex = 0;
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.Location = new System.Drawing.Point(12, 67);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(454, 20);
            this.lblQ.TabIndex = 1;
            this.lblQ.Text = "Enter the number that you would like to be put into a factorial (!)";
            // 
            // txtNumb
            // 
            this.txtNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumb.Location = new System.Drawing.Point(79, 112);
            this.txtNumb.Name = "txtNumb";
            this.txtNumb.Size = new System.Drawing.Size(100, 26);
            this.txtNumb.TabIndex = 2;
            // 
            // lblFactorialAns
            // 
            this.lblFactorialAns.AutoSize = true;
            this.lblFactorialAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactorialAns.Location = new System.Drawing.Point(75, 470);
            this.lblFactorialAns.Name = "lblFactorialAns";
            this.lblFactorialAns.Size = new System.Drawing.Size(56, 20);
            this.lblFactorialAns.TabIndex = 3;
            this.lblFactorialAns.Text = "Lblasd";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(90, 159);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(116, 28);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmFactorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 509);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblFactorialAns);
            this.Controls.Add(this.txtNumb);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lstFactorials);
            this.Name = "frmFactorial";
            this.Text = "Factorial Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFactorials;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.TextBox txtNumb;
        private System.Windows.Forms.Label lblFactorialAns;
        private System.Windows.Forms.Button btnCalculate;
    }
}


namespace RunningAverageBenM
{
    partial class frmRunningAverage
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
            this.lblEnterMark = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblFinalMark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterMark
            // 
            this.lblEnterMark.AutoSize = true;
            this.lblEnterMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterMark.Location = new System.Drawing.Point(62, 69);
            this.lblEnterMark.Name = "lblEnterMark";
            this.lblEnterMark.Size = new System.Drawing.Size(101, 24);
            this.lblEnterMark.TabIndex = 0;
            this.lblEnterMark.Text = "Enter Mark";
            // 
            // txtAverage
            // 
            this.txtAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAverage.Location = new System.Drawing.Point(183, 69);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(100, 29);
            this.txtAverage.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(134, 164);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(117, 44);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(87, 113);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(207, 24);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "(Finalize by entering -1)";
            // 
            // lblFinalMark
            // 
            this.lblFinalMark.AutoSize = true;
            this.lblFinalMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalMark.Location = new System.Drawing.Point(162, 248);
            this.lblFinalMark.Name = "lblFinalMark";
            this.lblFinalMark.Size = new System.Drawing.Size(0, 24);
            this.lblFinalMark.TabIndex = 4;
            this.lblFinalMark.Click += new System.EventHandler(this.lblFinalMark_Click);
            // 
            // frmRunningAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 356);
            this.Controls.Add(this.lblFinalMark);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.lblEnterMark);
            this.Name = "frmRunningAverage";
            this.Text = "Running Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterMark;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblFinalMark;
    }
}


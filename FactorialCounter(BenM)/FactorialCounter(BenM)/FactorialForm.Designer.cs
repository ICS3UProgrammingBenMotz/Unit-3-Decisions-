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
            this.SuspendLayout();
            // 
            // lstFactorials
            // 
            this.lstFactorials.FormattingEnabled = true;
            this.lstFactorials.Location = new System.Drawing.Point(64, 211);
            this.lstFactorials.Name = "lstFactorials";
            this.lstFactorials.Size = new System.Drawing.Size(149, 173);
            this.lstFactorials.TabIndex = 0;
            // 
            // frmFactorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 433);
            this.Controls.Add(this.lstFactorials);
            this.Name = "frmFactorial";
            this.Text = "Factorial Counter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFactorials;
    }
}


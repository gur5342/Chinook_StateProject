namespace Chinook.CompositionControls
{
    partial class CheckableNumericUpDown
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nupValue = new System.Windows.Forms.NumericUpDown();
            this.chbCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupValue)).BeginInit();
            this.SuspendLayout();
            // 
            // nupValue
            // 
            this.nupValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nupValue.Location = new System.Drawing.Point(28, 1);
            this.nupValue.Name = "nupValue";
            this.nupValue.Size = new System.Drawing.Size(121, 25);
            this.nupValue.TabIndex = 19;
            // 
            // chbCheck
            // 
            this.chbCheck.AutoSize = true;
            this.chbCheck.Checked = true;
            this.chbCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCheck.Location = new System.Drawing.Point(3, 3);
            this.chbCheck.Name = "chbCheck";
            this.chbCheck.Size = new System.Drawing.Size(18, 17);
            this.chbCheck.TabIndex = 18;
            this.chbCheck.UseVisualStyleBackColor = true;
            this.chbCheck.CheckedChanged += new System.EventHandler(this.ChbCheck_CheckedChanged);
            // 
            // CheckableNumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nupValue);
            this.Controls.Add(this.chbCheck);
            this.Name = "CheckableNumericUpDown";
            this.Size = new System.Drawing.Size(150, 27);
            ((System.ComponentModel.ISupportInitialize)(this.nupValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nupValue;
        private System.Windows.Forms.CheckBox chbCheck;
    }
}

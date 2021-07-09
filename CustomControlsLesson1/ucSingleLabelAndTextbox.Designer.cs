namespace CustomControlsLesson1
{
    partial class ucSingleLabelAndTextbox
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
            this.lblLabel = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLabel
            // 
            this.lblLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLabel.AutoSize = true;
            this.lblLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLabel.Location = new System.Drawing.Point(16, 16);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(48, 19);
            this.lblLabel.TabIndex = 0;
            this.lblLabel.Text = "label1";
            this.lblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtText
            // 
            this.txtText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtText.Location = new System.Drawing.Point(140, 13);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(309, 22);
            this.txtText.TabIndex = 1;
            // 
            // ucSingleLabelAndTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblLabel);
            this.Name = "ucSingleLabelAndTextbox";
            this.Size = new System.Drawing.Size(452, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.TextBox txtText;
    }
}

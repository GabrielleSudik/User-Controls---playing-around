namespace CustomControlsTestGroup
{
    partial class LabelAndTextboxUcTestingForm
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
            this.ucLabelAndTextbox1 = new CustomControlsLesson1.ucLabelAndTextbox();
            this.SuspendLayout();
            // 
            // ucLabelAndTextbox1
            // 
            this.ucLabelAndTextbox1.Location = new System.Drawing.Point(34, 32);
            this.ucLabelAndTextbox1.Name = "ucLabelAndTextbox1";
            this.ucLabelAndTextbox1.Size = new System.Drawing.Size(470, 463);
            this.ucLabelAndTextbox1.TabIndex = 0;
            // 
            // LabelAndTextboxUcTestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.ucLabelAndTextbox1);
            this.Name = "LabelAndTextboxUcTestingForm";
            this.Text = "LabelAndTextboxUcTestingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControlsLesson1.ucLabelAndTextbox ucLabelAndTextbox1;
    }
}
namespace CustomControlsLesson1
{
    partial class ucSelectColor
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
            this.lblRed = new System.Windows.Forms.Label();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.pnlColor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(29, 34);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(34, 17);
            this.lblRed.TabIndex = 0;
            this.lblRed.Text = "Red";
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(85, 34);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(304, 56);
            this.tbRed.TabIndex = 1;
            this.tbRed.TickFrequency = 5;
            this.tbRed.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(29, 105);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(48, 17);
            this.lblGreen.TabIndex = 2;
            this.lblGreen.Text = "Green";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(29, 164);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(36, 17);
            this.lblBlue.TabIndex = 3;
            this.lblBlue.Text = "Blue";
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(85, 96);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(304, 56);
            this.tbGreen.TabIndex = 4;
            this.tbGreen.TickFrequency = 5;
            this.tbGreen.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(85, 164);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(304, 56);
            this.tbBlue.TabIndex = 5;
            this.tbBlue.TickFrequency = 5;
            this.tbBlue.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // pnlColor
            // 
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColor.Location = new System.Drawing.Point(32, 226);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(200, 100);
            this.pnlColor.TabIndex = 6;
            // 
            // ucSelectColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.lblRed);
            this.Name = "ucSelectColor";
            this.Size = new System.Drawing.Size(587, 447);
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.Panel pnlColor;
    }
}

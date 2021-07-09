namespace CustomControlsTestGroup
{
    partial class ColorPickerUcTestingForm
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
            this.ucSelectControl1 = new CustomControlsLesson1.ucSelectColor();
            this.lblRedValue = new System.Windows.Forms.Label();
            this.lblGreenValue = new System.Windows.Forms.Label();
            this.lblBlueValue = new System.Windows.Forms.Label();
            this.txtRedValue = new System.Windows.Forms.TextBox();
            this.txtBlueValue = new System.Windows.Forms.TextBox();
            this.txtGreenValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ucSelectControl1
            // 
            this.ucSelectControl1.ControlColor = System.Drawing.Color.Empty;
            this.ucSelectControl1.Location = new System.Drawing.Point(32, 12);
            this.ucSelectControl1.Name = "ucSelectControl1";
            this.ucSelectControl1.Size = new System.Drawing.Size(451, 428);
            this.ucSelectControl1.TabIndex = 0;
            this.ucSelectControl1.ColorChanged += new System.EventHandler(this.ucSelectControl1_ColorChanged);
            // 
            // lblRedValue
            // 
            this.lblRedValue.AutoSize = true;
            this.lblRedValue.Location = new System.Drawing.Point(673, 46);
            this.lblRedValue.Name = "lblRedValue";
            this.lblRedValue.Size = new System.Drawing.Size(74, 17);
            this.lblRedValue.TabIndex = 1;
            this.lblRedValue.Text = "Red Value";
            // 
            // lblGreenValue
            // 
            this.lblGreenValue.AutoSize = true;
            this.lblGreenValue.Location = new System.Drawing.Point(673, 108);
            this.lblGreenValue.Name = "lblGreenValue";
            this.lblGreenValue.Size = new System.Drawing.Size(88, 17);
            this.lblGreenValue.TabIndex = 2;
            this.lblGreenValue.Text = "Green Value";
            // 
            // lblBlueValue
            // 
            this.lblBlueValue.AutoSize = true;
            this.lblBlueValue.Location = new System.Drawing.Point(673, 172);
            this.lblBlueValue.Name = "lblBlueValue";
            this.lblBlueValue.Size = new System.Drawing.Size(76, 17);
            this.lblBlueValue.TabIndex = 3;
            this.lblBlueValue.Text = "Blue Value";
            // 
            // txtRedValue
            // 
            this.txtRedValue.Location = new System.Drawing.Point(806, 46);
            this.txtRedValue.Name = "txtRedValue";
            this.txtRedValue.Size = new System.Drawing.Size(100, 22);
            this.txtRedValue.TabIndex = 4;
            // 
            // txtBlueValue
            // 
            this.txtBlueValue.Location = new System.Drawing.Point(806, 172);
            this.txtBlueValue.Name = "txtBlueValue";
            this.txtBlueValue.Size = new System.Drawing.Size(100, 22);
            this.txtBlueValue.TabIndex = 5;
            // 
            // txtGreenValue
            // 
            this.txtGreenValue.Location = new System.Drawing.Point(806, 108);
            this.txtGreenValue.Name = "txtGreenValue";
            this.txtGreenValue.Size = new System.Drawing.Size(100, 22);
            this.txtGreenValue.TabIndex = 6;
            // 
            // ColorPickerUcTestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 524);
            this.Controls.Add(this.txtGreenValue);
            this.Controls.Add(this.txtBlueValue);
            this.Controls.Add(this.txtRedValue);
            this.Controls.Add(this.lblBlueValue);
            this.Controls.Add(this.lblGreenValue);
            this.Controls.Add(this.lblRedValue);
            this.Controls.Add(this.ucSelectControl1);
            this.Name = "ColorPickerUcTestingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControlsLesson1.ucSelectColor ucSelectControl1;
        private System.Windows.Forms.Label lblRedValue;
        private System.Windows.Forms.Label lblGreenValue;
        private System.Windows.Forms.Label lblBlueValue;
        private System.Windows.Forms.TextBox txtRedValue;
        private System.Windows.Forms.TextBox txtBlueValue;
        private System.Windows.Forms.TextBox txtGreenValue;
    }
}


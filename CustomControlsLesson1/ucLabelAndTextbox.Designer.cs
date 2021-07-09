namespace CustomControlsLesson1
{
    partial class ucLabelAndTextbox
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
            this.lblText = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblPanelInsert = new System.Windows.Forms.Label();
            this.txtTextInPanel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(17, 16);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(83, 17);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Some Label";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(148, 16);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(293, 22);
            this.txtText.TabIndex = 1;
            this.txtText.Text = "Some Text";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(20, 68);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblPanelInsert);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtTextInPanel);
            this.splitContainer1.Size = new System.Drawing.Size(399, 137);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(91, 220);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Size = new System.Drawing.Size(150, 228);
            this.splitContainer2.SplitterDistance = 40;
            this.splitContainer2.TabIndex = 3;
            // 
            // lblPanelInsert
            // 
            this.lblPanelInsert.AutoSize = true;
            this.lblPanelInsert.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPanelInsert.Location = new System.Drawing.Point(43, 0);
            this.lblPanelInsert.Name = "lblPanelInsert";
            this.lblPanelInsert.Size = new System.Drawing.Size(110, 17);
            this.lblPanelInsert.TabIndex = 0;
            this.lblPanelInsert.Text = "Label in a Panel";
            // 
            // txtTextInPanel
            // 
            this.txtTextInPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTextInPanel.Location = new System.Drawing.Point(0, 0);
            this.txtTextInPanel.Name = "txtTextInPanel";
            this.txtTextInPanel.Size = new System.Drawing.Size(242, 22);
            this.txtTextInPanel.TabIndex = 0;
            this.txtTextInPanel.Text = "Textbox in a Panel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Label in a Panel";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 99);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Textbox in a Panel";
            // 
            // ucLabelAndTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblText);
            this.Name = "ucLabelAndTextbox";
            this.Size = new System.Drawing.Size(470, 475);
            this.Load += new System.EventHandler(this.ucLabelAndTextbox_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblPanelInsert;
        private System.Windows.Forms.TextBox txtTextInPanel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

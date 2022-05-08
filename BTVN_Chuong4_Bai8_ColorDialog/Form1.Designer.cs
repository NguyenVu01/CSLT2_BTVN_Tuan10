namespace BTVN_Chuong4_Bai8_ColorDialog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bar1 = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bar2 = new System.Windows.Forms.HScrollBar();
            this.bar3 = new System.Windows.Forms.HScrollBar();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(21, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // bar1
            // 
            this.bar1.LargeChange = 0;
            this.bar1.Location = new System.Drawing.Point(108, 211);
            this.bar1.Maximum = 255;
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(285, 20);
            this.bar1.SmallChange = 0;
            this.bar1.TabIndex = 0;
            this.bar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.bar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(21, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(21, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Blue";
            // 
            // bar2
            // 
            this.bar2.LargeChange = 0;
            this.bar2.Location = new System.Drawing.Point(108, 247);
            this.bar2.Maximum = 255;
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(285, 20);
            this.bar2.SmallChange = 0;
            this.bar2.TabIndex = 4;
            this.bar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.bar2_Scroll);
            // 
            // bar3
            // 
            this.bar3.LargeChange = 0;
            this.bar3.Location = new System.Drawing.Point(108, 287);
            this.bar3.Maximum = 255;
            this.bar3.Name = "bar3";
            this.bar3.Size = new System.Drawing.Size(285, 20);
            this.bar3.SmallChange = 0;
            this.bar3.TabIndex = 5;
            this.bar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.bar3_Scroll);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRed.Location = new System.Drawing.Point(425, 210);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(19, 21);
            this.lblRed.TabIndex = 6;
            this.lblRed.Text = "0";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGreen.Location = new System.Drawing.Point(425, 247);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(19, 21);
            this.lblGreen.TabIndex = 7;
            this.lblGreen.Text = "0";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBlue.Location = new System.Drawing.Point(425, 286);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(19, 21);
            this.lblBlue.TabIndex = 8;
            this.lblBlue.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(475, 341);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.bar3);
            this.Controls.Add(this.bar2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorRGB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private HScrollBar bar1;
        private Label label2;
        private Label label3;
        private HScrollBar bar2;
        private HScrollBar bar3;
        private Label lblRed;
        private Label lblGreen;
        private Label lblBlue;
    }
}
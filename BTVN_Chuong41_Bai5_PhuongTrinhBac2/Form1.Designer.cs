namespace BTVN_Chuong41_Bai5_PhuongTrinhBac2
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
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.txbKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbX2 = new System.Windows.Forms.TextBox();
            this.txbX1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGiaiPTBH = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.nudC = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).BeginInit();
            this.SuspendLayout();
            // 
            // nudA
            // 
            this.nudA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudA.Location = new System.Drawing.Point(59, 23);
            this.nudA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(60, 29);
            this.nudA.TabIndex = 0;
            // 
            // txbKetQua
            // 
            this.txbKetQua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbKetQua.Location = new System.Drawing.Point(13, 63);
            this.txbKetQua.Multiline = true;
            this.txbKetQua.Name = "txbKetQua";
            this.txbKetQua.ReadOnly = true;
            this.txbKetQua.Size = new System.Drawing.Size(193, 126);
            this.txbKetQua.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbX2);
            this.groupBox1.Controls.Add(this.txbX1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(264, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 126);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nghiệm";
            // 
            // txbX2
            // 
            this.txbX2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbX2.Location = new System.Drawing.Point(58, 76);
            this.txbX2.Name = "txbX2";
            this.txbX2.ReadOnly = true;
            this.txbX2.Size = new System.Drawing.Size(134, 25);
            this.txbX2.TabIndex = 6;
            // 
            // txbX1
            // 
            this.txbX1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbX1.Location = new System.Drawing.Point(58, 35);
            this.txbX1.Name = "txbX1";
            this.txbX1.ReadOnly = true;
            this.txbX1.Size = new System.Drawing.Size(134, 25);
            this.txbX1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "x2 =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "x1 =";
            // 
            // btnGiaiPTBH
            // 
            this.btnGiaiPTBH.Location = new System.Drawing.Point(105, 209);
            this.btnGiaiPTBH.Name = "btnGiaiPTBH";
            this.btnGiaiPTBH.Size = new System.Drawing.Size(101, 44);
            this.btnGiaiPTBH.TabIndex = 7;
            this.btnGiaiPTBH.Text = "Giải PTBH";
            this.btnGiaiPTBH.UseVisualStyleBackColor = true;
            this.btnGiaiPTBH.Click += new System.EventHandler(this.btnGiaiPTBH_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(265, 209);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 44);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "a =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(172, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "b =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(322, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "c =";
            // 
            // nudB
            // 
            this.nudB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudB.Location = new System.Drawing.Point(212, 23);
            this.nudB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(60, 29);
            this.nudB.TabIndex = 1;
            // 
            // nudC
            // 
            this.nudC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudC.Location = new System.Drawing.Point(364, 23);
            this.nudC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudC.Name = "nudC";
            this.nudC.Size = new System.Drawing.Size(60, 29);
            this.nudC.TabIndex = 2;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGiaiPTBH;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 268);
            this.Controls.Add(this.nudC);
            this.Controls.Add(this.nudB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiaiPTBH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbKetQua);
            this.Controls.Add(this.nudA);
            this.Name = "Form1";
            this.Text = "Giải phương trình bậc 2";
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nudA;
        private TextBox txbKetQua;
        private GroupBox groupBox1;
        private TextBox txbX2;
        private TextBox txbX1;
        private Label label2;
        private Label label1;
        private Button btnGiaiPTBH;
        private Button btnThoat;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown nudB;
        private NumericUpDown nudC;
    }
}
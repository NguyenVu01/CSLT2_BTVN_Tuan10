namespace TestWMP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxODia = new System.Windows.Forms.ComboBox();
            this.cbxThuMuc = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbTapTin = new System.Windows.Forms.TextBox();
            this.txbLyrics = new System.Windows.Forms.TextBox();
            this.btnLyrics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(440, 320);
            this.axWindowsMediaPlayer2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ổ đĩa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tập tin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thư mục";
            // 
            // cbxODia
            // 
            this.cbxODia.DisplayMember = "E:/";
            this.cbxODia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxODia.FormattingEnabled = true;
            this.cbxODia.Items.AddRange(new object[] {
            "D:/"});
            this.cbxODia.Location = new System.Drawing.Point(79, 356);
            this.cbxODia.Name = "cbxODia";
            this.cbxODia.Size = new System.Drawing.Size(247, 21);
            this.cbxODia.TabIndex = 4;
            // 
            // cbxThuMuc
            // 
            this.cbxThuMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxThuMuc.FormattingEnabled = true;
            this.cbxThuMuc.Location = new System.Drawing.Point(79, 387);
            this.cbxThuMuc.Name = "cbxThuMuc";
            this.cbxThuMuc.Size = new System.Drawing.Size(247, 21);
            this.cbxThuMuc.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbTapTin
            // 
            this.txbTapTin.Location = new System.Drawing.Point(79, 426);
            this.txbTapTin.Name = "txbTapTin";
            this.txbTapTin.ReadOnly = true;
            this.txbTapTin.Size = new System.Drawing.Size(247, 20);
            this.txbTapTin.TabIndex = 7;
            // 
            // txbLyrics
            // 
            this.txbLyrics.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbLyrics.Location = new System.Drawing.Point(470, 12);
            this.txbLyrics.Multiline = true;
            this.txbLyrics.Name = "txbLyrics";
            this.txbLyrics.ReadOnly = true;
            this.txbLyrics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbLyrics.Size = new System.Drawing.Size(278, 411);
            this.txbLyrics.TabIndex = 8;
            // 
            // btnLyrics
            // 
            this.btnLyrics.Location = new System.Drawing.Point(588, 429);
            this.btnLyrics.Name = "btnLyrics";
            this.btnLyrics.Size = new System.Drawing.Size(57, 23);
            this.btnLyrics.TabIndex = 9;
            this.btnLyrics.Text = "file lời";
            this.btnLyrics.UseVisualStyleBackColor = true;
            this.btnLyrics.Click += new System.EventHandler(this.btnLyrics_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(760, 462);
            this.Controls.Add(this.btnLyrics);
            this.Controls.Add(this.txbLyrics);
            this.Controls.Add(this.txbTapTin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxThuMuc);
            this.Controls.Add(this.cbxODia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Trình phát nhạc Window Media Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxODia;
        private System.Windows.Forms.ComboBox cbxThuMuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbTapTin;
        private System.Windows.Forms.TextBox txbLyrics;
        private System.Windows.Forms.Button btnLyrics;
    }
}


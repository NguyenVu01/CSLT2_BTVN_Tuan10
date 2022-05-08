using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestWMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo obj = new DirectoryInfo(@"D:\");
            DirectoryInfo[] folders = obj.GetDirectories();
            cbxThuMuc.DataSource = folders;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"D:\";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "All Media Files|*.wav;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.mp2;*.mp3;*.m3u;*.mp4;*.mov";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txbTapTin.Text = openFileDialog.FileName;
                    axWindowsMediaPlayer2.URL = openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
     
        }

        private void btnLyrics_Click(object sender, EventArgs e)
        {
             OpenFileDialog openFileDialog1 = new OpenFileDialog()
             {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
             };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                    txbLyrics.Text = streamReader.ReadToEnd();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát?", "Hỏi chấm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

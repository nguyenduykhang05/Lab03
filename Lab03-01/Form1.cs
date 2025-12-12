// Form1.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi động Timer khi Form load
            timer1.Start();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tạo OpenFileDialog để chọn file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Media Files (*.mp3;*.mp4;*.avi;*.wmv;*.wav;*.mpeg)|*.mp3;*.mp4;*.avi;*.wmv;*.wav;*.mpeg|All files (*.*)|*.*";
            openFileDialog.Title = "Chọn file media để mở";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Gán đường dẫn file đã chọn cho Windows Media Player
                wmpPlayer.URL = openFileDialog.FileName;
                wmpPlayer.Ctlcontrols.play(); // Bắt đầu phát ngay
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Đóng ứng dụng
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Cập nhật thông tin ngày giờ lên StatusStrip mỗi giây
            string currentTime = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
            toolStripStatusLabel1.Text = $"Hôm nay là ngày {DateTime.Now:dd/MM/yyyy} - Bây giờ là {currentTime}";
        }
    }
}
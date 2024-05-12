using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TradingManagementSystem
{
    
    public partial class GiaoDien : Form
    {
        public static GiaoDien instance = new GiaoDien();
        public GiaoDien()
        {
            InitializeComponent();
            CenterToScreen();
            instance = this;
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        bool sidebarExpand;
        private UserControl currentControl;
        private void CloseProductInfo()
        {
            foreach (Control control in panel6.Controls)
            {
                // Kiểm tra xem control có phải là ProductInfo không
                if (control is ProductInfo)
                {
                    // Đóng ProductInfo
                    control.Dispose();
                    return; // Kết thúc vòng lặp ngay sau khi tìm thấy ProductInfo
                }
            }
        }
        private void ShowUserControlInMainContent(UserControl userControl)
        {
            CloseProductInfo();

            // Kiểm tra xem có đang hiển thị ProductInfo không
            if (currentControl is ProductInfo)
            {
                // Đóng ProductInfo trước khi hiển thị UserControl mới
                currentControl.Dispose();
            }

            // Xóa tất cả các control hiện tại trong pnlMainContent
            panel6.Controls.Clear();

            // Thêm UserControl mới vào pnlMainContent
            panel6.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;

            // Lưu UserControl hiện tại
            currentControl = userControl;
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        private void SetFormPosition(Point location)
        {
            // Đặt vị trí của form
            this.Location = location;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuyerUser z = new BuyerUser();
            ShowUserControlInMainContent(z);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SellerUser x = new SellerUser();
            ShowUserControlInMainContent(x);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutUser y = new AboutUser();
            ShowUserControlInMainContent(y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeUser k = new HomeUser();
            ShowUserControlInMainContent(k);
        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserUser t = new UserUser();
            ShowUserControlInMainContent(t);
        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

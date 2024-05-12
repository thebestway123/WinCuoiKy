using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingManagementSystem
{
    public partial class UserUser : UserControl
    { 
        public static  UserUser instance ;
        public UserUser()
        {
            InitializeComponent();
            instance= this;
        }
        private UserControl currentControl;
        private void CloseProductInfo()
        {
            foreach (Control control in panel1.Controls)
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
            panel1.Controls.Clear();

            // Thêm UserControl mới vào pnlMainContent
            panel1.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;

            // Lưu UserControl hiện tại
            currentControl = userControl;
        }
        private void UserUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuyedUC z = new BuyedUC();
            ShowUserControlInMainContent(z);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PostedUC d = new PostedUC();
            ShowUserControlInMainContent(d);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DanhGiaUC z = new DanhGiaUC();
            ShowUserControlInMainContent(z);
        }
    }
}

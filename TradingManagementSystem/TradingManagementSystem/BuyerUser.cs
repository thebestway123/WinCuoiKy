﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TradingManagementSystem
{
    public partial class BuyerUser : UserControl
    {
        public static BuyerUser instance = new BuyerUser();
        private FlowLayoutPanel flowLayoutPanel;
        public BuyerUser()
        {
            InitializeComponent();
            instance = this;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
        }
        private void BuyerUser_Load(object sender, EventArgs e)
        {
            string column = "TenSP, GiabanSP, HinhanhSP, GiagocSP";
            string table = "Product";
            Connection db = new Connection();
            DataTable productsData = db.GetData(table, column);

            foreach (DataRow productRow in productsData.Rows)
            {
                // Tạo một thể hiện mới của UCListing
                UCListing x = new UCListing();

                // Thiết lập dữ liệu cho UCListing từ dữ liệu trong DataRow
                x.giaBanLabel.Text = productRow["GiabanSP"].ToString();
                x.khaibao(productRow["TenSP"].ToString());
                x.giaMuaMoiLabel.Text = productRow["GiagocSP"].ToString(); // Đặt giá trị của label1
                string imagePath = productRow["HinhanhSP"].ToString();
                // Kiểm tra xem đường dẫn ảnh có tồn tại không trước khi gán
                if (File.Exists(imagePath))
                {
                    x.pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Nếu đường dẫn không tồn tại, có thể gán một hình ảnh mặc định hoặc thông báo lỗi
                    MessageBox.Show("Không tìm thấy hình ảnh cho sản phẩm " + productRow["TenSP"].ToString());
                    // Ví dụ gán hình ảnh mặc định:
                    // x.pictureBox1.Image = Properties.Resources.defaultImage;
                }

                // Thêm UCListing mới vào FlowLayoutPanel
                this.flowLayoutPanel1.Controls.Add(x);
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                string searchKeyword = txtSearch.Text.Trim().ToLower();

                // Lặp qua từng UserControl trong FlowLayoutPanel
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is UCListing)
                    {
                        UCListing ucListing = (UCListing)control;

                        // Lấy tên sản phẩm từ UserControl và chuyển đổi thành chữ thường để so sánh không phân biệt hoa thường
                        string productName = ucListing.ProductName.Text.ToLower();

                        // So sánh tên sản phẩm với từ khóa tìm kiếm
                        if (productName.Contains(searchKeyword))
                        {
                            // Nếu tên sản phẩm chứa từ khóa tìm kiếm, hiển thị UserControl
                            ucListing.Visible = true;
                        }
                        else
                        {
                            // Nếu không, ẩn UserControl đi
                            ucListing.Visible = false;
                        }
                    }
                }

        }
    }
}
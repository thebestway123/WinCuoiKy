using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TradingManagementSystem
{
    public partial class ProductInfo : UserControl
    {

        public void Init(string ten, string date, string giamua, string giaban, string imagePath , string tinhtrang, string motatinhtrang, string xuatxu)
        {
            labelName.Text = ten;
            label14.Text = date;
            label13.Text = giamua;
            label11.Text = giaban; 
            label10.Text = tinhtrang;
            label9.Text = motatinhtrang;
            label12.Text = xuatxu;
            pictureBox1.Image = Image.FromFile(imagePath);
        }
        public ProductInfo()
        {
            InitializeComponent();
        }

        private void ProductInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenSPCanMua = labelName.Text;
            FDanhGiaSeller x = new FDanhGiaSeller();
            x.tensp = tenSPCanMua;
            x.ShowDialog();
            // Thực hiện xóa sản phẩm từ cơ sở dữ liệu
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();

                string query = "DELETE FROM Product WHERE TenSP = @TenSP";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenSP", tenSPCanMua);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Mua sản phẩm thành công.");
                        // Thực hiện các hành động khác nếu cần sau khi mua thành công.
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm cần mua hoặc mua không thành công.");
                    }
             
                }
            }
            Connection c = new Connection();
            c.deleteROw("Favourites", $" tenSP = '{tenSPCanMua}'");

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string name = labelName.Text;
            Connection c = new Connection();
            string tableName = "Favourites(tenSP, tenTaiKhoan)";
            string values = $"(N'{name} ', '{Form1.instance.tentk}')";
            c.Insert(tableName, values);
            MessageBox.Show("Thêm sản phâm vào danh sách yêu thích thành công !");
            string tableNameMF = "MyProduct(tenSP, tenTaiKhoan)";
            string valuesMF = $"(N'{name} ', '{Form1.instance.tentk}')";
            c.Insert(tableNameMF, values);

        }
    }
}

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

namespace TradingManagementSystem
{
    public partial class SellerUser : UserControl
    {
        public SellerUser()
        {
            InitializeComponent();
        }

        private void SellerUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenSP = textBox1.Text;
            DateTime dateSP = dateTimePicker1.Value.Date;
            int giaGocSP, giaBanSP, tinhTrangSP;
            if (!int.TryParse(textBox3.Text, out giaGocSP) || !int.TryParse(textBox7.Text, out giaBanSP) || !int.TryParse(textBox4.Text, out tinhTrangSP))
            {
                MessageBox.Show("Giá trị không hợp lệ.");
                return;
            }
            string moTaSP = textBox5.Text;
            string xuatXuSP = textBox2.Text;
            string hinhAnhSP = textBox6.Text;

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();

                string query = "INSERT INTO Product (TenSP, DateSP, GiagocSP, GiabanSP, TinhtranSP, MotaSP, XuatxuSP, HinhanhSP) " +
                               "VALUES (@TenSP, @DateSP, @GiagocSP, @GiabanSP, @TinhtranSP, @MotaSP, @XuatxuSP, @HinhanhSP)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenSP", tenSP);
                command.Parameters.AddWithValue("@DateSP", dateSP);
                command.Parameters.AddWithValue("@GiagocSP", giaGocSP);
                command.Parameters.AddWithValue("@GiabanSP", giaBanSP);
                command.Parameters.AddWithValue("@TinhtranSP", tinhTrangSP);
                command.Parameters.AddWithValue("@MotaSP", moTaSP);
                command.Parameters.AddWithValue("@XuatxuSP", xuatXuSP);
                command.Parameters.AddWithValue("@HinhanhSP", hinhAnhSP);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm sản phẩm thành công.");
                    // Clear textboxes or do any other necessary actions after successful insertion.
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công.");
                }
            }
        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
            textBox3.Clear();
            textBox7.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox2.Clear();
            textBox6.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Tạo một OpenFileDialog mới
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các thuộc tính cho OpenFileDialog
            openFileDialog.Title = "Chọn hình ảnh"; // Tiêu đề của hộp thoại
            openFileDialog.Filter = "Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif"; // Loại tập tin được chấp nhận
            openFileDialog.Multiselect = false; // Không cho phép lựa chọn nhiều tập tin

            // Hiển thị hộp thoại để chọn tập tin hình ảnh
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn đến tập tin đã chọn
                string selectedImagePath = openFileDialog.FileName;
                // Hiển thị đường dẫn đến tập tin đã chọn vào TextBox
                textBox6.Text = selectedImagePath;
                // Hiển thị hình ảnh đã chọn lên PictureBox hoặc nơi hiển thị khác
                pictureBox1.Image = Image.FromFile(selectedImagePath);
            }
        }
    }
}

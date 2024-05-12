using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingManagementSystem
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public bool CheckAccount(string ac)//check mat khau va ten tai khoan
        {
            return Regex.IsMatch(ac, "^[a-zA-z0-9]{6,24}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;
            string xnmatkhau = textBox_XNMatKhau.Text;
            string email = textBox_Email.Text;
            if (!CheckAccount(tentk)) { MessageBox.Show("Vui lòng nhập tài khoản dài 6-24 kí tự, với các ký tự chữ và số, chữ hoa và chữ thường"); return; }
            if (!CheckAccount(matkhau)) { MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 kí tự, với các ký tự chữ và số, chữ hoa và chữ thường"); return; }
            if (xnmatkhau != matkhau)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng với mật khẩu đã nhập");
                return;
            }
            if (!CheckEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email"); return; }
            if (modify.TaiKhoans("Select * from TaiKhoan where Email = '" + email + "'").Count != 0) { MessageBox.Show("Email này đã được đăng kí vui lòng nhập email khác"); return; }
            try
            {
                string query = "Insert into TaiKhoan values ('"+tentk+"','"+matkhau+"','"+email+"')";
                modify.Command(query);  
                if (MessageBox.Show("Đăng ký thành công! bạn có muốn đăng nhập không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng kí");
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            label2.Text = "";
            CenterToScreen();
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            if (email.Trim() == ""){ MessageBox.Show("Vui lòng nhập email đăng ký:"); }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if(modify.TaiKhoans(query).Count()!=0 )
                {
                    label2.ForeColor = Color.Blue;
                    label2.Text = "Mật Khẩu: " + modify.TaiKhoans(query)[0].MatKhau;
                }
                else
                {
                    label2.ForeColor= Color.Red;
                    label2.Text = "Email này chưa được đăng kí";
                }    
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

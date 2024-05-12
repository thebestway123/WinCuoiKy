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
    public partial class FDanhGiaSeller : Form
    {
        public FDanhGiaSeller()
        {
            InitializeComponent();
        }
        public string tensp;
        private void button1_Click(object sender, EventArgs e)
        {
            Connection c = new Connection();
            c.Insert("NhanXet(tenTaiKhoan, nhanXet, tenSP)", $"('{Form1.instance.tentk}', N'{textBox1.Text}', N'{tensp}' )");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FDanhGiaSeller_Load(object sender, EventArgs e)
        {

        }
    }
}

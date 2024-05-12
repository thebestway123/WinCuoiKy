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
    public partial class DanhGiaUC : UserControl
    {
        public DanhGiaUC()
        {
            InitializeComponent();
        }

        private void DanhGiaUC_Load(object sender, EventArgs e)
        {
            Connection c = new Connection();
            DataTable dt = c.GetData_Condition("MyProduct", "TenSP", $" TenTaiKhoan = '{Form1.instance.tentk}'");
            foreach (DataRow r in dt.Rows)
            {
                string tensp = r[0].ToString();
                DataTable x = c.GetData_Condition("NhanXet", "*", $" tenSP = '{tensp}'");
                foreach (DataRow dr in x.Rows)
                {
                    string tentk = dr["tenTaiKhoan"].ToString();
                    string nhanxet = dr["nhanXet"].ToString();
                    danhGiaListing k = new danhGiaListing();
                    k.Init(tentk, nhanxet);
                    flowLayoutPanel1.Controls.Add(k);
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class HomeUser : UserControl
    {
        public static HomeUser instance;
        public HomeUser()
        {
            InitializeComponent();
            instance = this;
        }

        private void HomeUser_Load(object sender, EventArgs e)
        {

            Connection c = new Connection();
            DataTable dt = c.GetData_Condition("Favourites", "tenSP", $" tenTaiKhoan = '{Form1.instance.tentk}'");
            foreach (DataRow r in dt.Rows)
            {
                string tensp = r["tenSP"].ToString();
                UCListing3 x = new UCListing3();
                x.Init(tensp);
                flowLayoutPanel1.Controls.Add(x);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
    
}

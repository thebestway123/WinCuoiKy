using Microsoft.VisualBasic.Devices;
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
    public partial class UCListing3 : UserControl
    {
        public UCListing3()
        {
            InitializeComponent();
            this.Click += new EventHandler(czlick);
        }
        private void czlick(object sender, EventArgs e)
        {
            FavSP cf = new FavSP();
            string columnName = " TenSP, DateSP, GiagocSP, GiabanSP, TinhtranSP, MotaSP, XuatxuSP, HinhanhSP ";
            string tableName = " Product ";
            string pdn = ProductName3.Text;
            Connection db = new Connection();

            DataTable c = db.GetDataByName(tableName, columnName, pdn);
            if (c.Rows.Count > 0)
            {
                // Lấy dòng đầu tiên từ DataTable
                DataRow productRow = c.Rows[0];

                // Trích xuất dữ liệu từ DataRow
                string ten = productRow["TenSP"].ToString();
                string date = productRow["DateSP"].ToString();
                string giamua = productRow["GiagocSP"].ToString();
                string giaban = productRow["GiabanSP"].ToString();
                string tinhtrang = productRow["TinhtranSP"].ToString();
                string motatinhtrang = productRow["MotaSP"].ToString();
                string xuatxu = productRow["XuatxuSP"].ToString();
                string imagePath = productRow["HinhanhSP"].ToString();

                // Gọi phương thức Init để gán dữ liệu vào ProductInfo
                cf.Init(ten, date, giamua, giaban, imagePath, tinhtrang, motatinhtrang, xuatxu);
            }



            HomeUser.instance.Dispose();

            GiaoDien.instance.panel6.Controls.Add(cf);
            cf.Dock = DockStyle.Fill;

        }
        public void Init(string name)
        {
            ProductName3.Text = name;
        }
        private void UCListing3_Load(object sender, EventArgs e)
        {
            Connection c = new Connection();
            DataTable dt = c.GetData_Condition("Product", "*", $" TenSP = N'{ProductName3.Text}'");

            DataRow r = dt.Rows[0];
            giaBanLabel2.Text = r["GiabanSP"].ToString();
            giaMuaMoiLabel2.Text = r["GiagocSP"].ToString();
            pictureBox1.Image = Image.FromFile(r["HinhanhSP"].ToString());
        }
    }
}

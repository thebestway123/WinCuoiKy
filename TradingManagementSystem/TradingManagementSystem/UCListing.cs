using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace TradingManagementSystem
{
    public partial class UCListing : UserControl
    {
        public UCListing()
        {
            InitializeComponent();
            this.Click += new EventHandler(cxlick);
        }
        private void cxlick(object sender, EventArgs e)
        {
            ProductInfo pf = new ProductInfo();
            string columnName = " * ";
            string tableName = " Product ";
            string pdn = ProductName.Text;
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
                pf.Init(ten, date, giamua, giaban, imagePath, tinhtrang, motatinhtrang, xuatxu);
            }



            BuyerUser.instance.Dispose();

            GiaoDien.instance.panel6.Controls.Add(pf);
            pf.Dock = DockStyle.Fill; // Đảm bảo ProductInfo lấp đầy panel

        }
        private void UCListing_Load(object sender, EventArgs e)
        {        
            

        }

        public void khaibao(string name)
        {
            this.ProductName.Text = name;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cxlick(sender, e);
        }

        private void ProductName_Click(object sender, EventArgs e)
        {
            cxlick(sender, e);
        }

        private void giaBanLabel_Click(object sender, EventArgs e)
        {
            cxlick(sender, e);
        }

        private void giaMuaMoiLabel_Click(object sender, EventArgs e)
        {
            cxlick(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            cxlick(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            cxlick(sender, e);
        }
        
    }
}

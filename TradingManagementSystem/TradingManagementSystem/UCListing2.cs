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
    public partial class UCListing2 : UserControl
    {
        public UCListing2()
        {
            InitializeComponent();
            this.Click += new EventHandler(cllick);
        }
        private void cllick(object sender, EventArgs e)
        {


            ModifySP ms = new ModifySP();
            string columnName = " TenSP, DateSP, GiagocSP, GiabanSP, TinhtranSP, MotaSP, XuatxuSP, HinhanhSP ";
            string tableName = " Product ";
            string pdn = ProductName2.Text;
            Connection db = new Connection();

            DataTable c = db.GetDataByName(tableName, columnName, pdn);
            
            if (c.Rows.Count > 0)
            {
                DataRow productRow = c.Rows[0];
                string ten = productRow["TenSP"].ToString();
                string date = productRow["DateSP"].ToString();
                string giamua = productRow["GiagocSP"].ToString();
                string giaban = productRow["GiabanSP"].ToString();
                string tinhtrang = productRow["TinhtranSP"].ToString();
                string motatinhtrang = productRow["MotaSP"].ToString();
                string xuatxu = productRow["XuatxuSP"].ToString();
                string imagePath = productRow["HinhanhSP"].ToString();

                ms.Init(ten, date, giamua, giaban, imagePath, tinhtrang, motatinhtrang, xuatxu);
            }
            
            UserUser.instance.Dispose();

            // Thêm UserControl mới vào GiaoDien.instance.panel6

            GiaoDien.instance.panel6.Controls.Add(ms);
            ms.Dock= DockStyle.Fill;
        }
        public void khaibao(string name)
        {
            this.ProductName2.Text = name;
        }

        private void UCListing2_Load(object sender, EventArgs e)
        {

        }

        private void giaBanLabel2_Click(object sender, EventArgs e)
        {
            cllick(sender, e);
        }

        private void giaMuaMoiLabel2_Click(object sender, EventArgs e)
        {
            cllick(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            cllick(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            cllick(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cllick(sender, e);
        }

        private void ProductName2_Click(object sender, EventArgs e)
        {
            cllick(sender, e);
        }
    }
}

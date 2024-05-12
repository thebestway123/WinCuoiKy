using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingManagementSystem
{
    public partial class ModifySP : UserControl
    {
        public void Init(string ten, string date, string giamua, string giaban, string imagePath, string tinhtrang, string motatinhtrang, string xuatxu)
        {
            ModifyName.Text = ten;
            modifyDate.Text = date;
            textBox3.Text = giamua;
            textBox7.Text = giaban;
            textBox4.Text = tinhtrang;
            textBox5.Text = motatinhtrang;
            textBox2.Text = xuatxu;
            modifyProductImage.Image = Image.FromFile(imagePath);
        }
        public ModifySP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
  
            Connection sua = new Connection();
            string tableName = "MyProduct";
            string DK = $"N'{ModifyName.Text}'";
            string set = $"DateSP = '{modifyDate.Text}', GiagocSP = '{textBox3.Text}', GiabanSP = '{textBox7.Text}', XuatxuSP = N'{textBox2.Text}', TinhtranSP = N'{textBox4.Text}', MotaSP = N'{textBox5.Text}'";
            sua.SuaSanPham(tableName, set, DK);

        }


        private void ModifySP_Load(object sender, EventArgs e)
        {
        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            Connection xoa = new Connection();
            string tableName = "MyProduct";
            string DK = $"N'{ModifyName.Text}'";
            xoa.XoaSanPham(tableName, DK);
        }
    }
}

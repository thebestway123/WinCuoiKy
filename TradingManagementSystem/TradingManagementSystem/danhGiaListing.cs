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
    public partial class danhGiaListing : UserControl
    {
        public danhGiaListing()
        {
            InitializeComponent();
        }
        public void Init(string tentako, string nhanxet)
        {
            TkDanhGia.Text = tentako;
            NhanXetLabel.Text = nhanxet;
        }

        private void danhGiaListing_Load(object sender, EventArgs e)
        {

        }
    }
}

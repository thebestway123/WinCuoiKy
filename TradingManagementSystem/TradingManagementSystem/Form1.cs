namespace TradingManagementSystem
{
    public partial class Form1 : Form
    {
        public static Form1 instance; 
        public Form1()
        {
            InitializeComponent();
            CenterForm();
            CenterToScreen();
            instance = this;
        }
        private void CenterForm()
        {
            // Lấy kích thước của màn hình làm việc chính
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            // Tính toán vị trí cho form để nó hiển thị ở giữa màn hình
            int x = (workingArea.Width - this.Width) / 2;
            int y = (workingArea.Height - this.Height) / 2;

            // Đặt vị trí của form
            this.Location = new Point(x, y);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        public string tentk;
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            this.tentk = textBox_TaiKhoan.Text;
            string tentk = textBox_TaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;
            if (tentk.Trim() == "") { MessageBox.Show("Vui long nhap ten tai khoan"); return; }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui long nhap mat khau"); return; }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GiaoDien newForm = new GiaoDien();
                    newForm.ShowDialog();
                    
                }

                else
                {
                    MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Không Chính Xác", "Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void textBox_MatKhau_TextChanged(object sender, EventArgs e)
        {
            this.textBox_MatKhau.PasswordChar = '*';
        }

        private void textBox_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
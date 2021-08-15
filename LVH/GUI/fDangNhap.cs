using LVH.GUI;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LVH
{
    public partial class FormDangNhap : Form
    {
        QuanLyThuVienDataContext dataContext = new QuanLyThuVienDataContext();
        string accountType;

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (dataContext.TAIKHOANs.Where(p => p.TenDangNhap == txtUsername.Text && p.MatKhau == txtPassword.Text).Count() > 0)
            {
                var s = from p in dataContext.TAIKHOANs
                        where p.TenDangNhap == txtUsername.Text && p.MatKhau == txtPassword.Text
                        select new { p.LoaiTaiKhoan };
                foreach (var i in s)
                {
                    accountType = i.LoaiTaiKhoan.ToString(); ;
                }
                if (accountType == "0")
                {
                    // mở form admin
                }
                else
                {
                    fTrangChu f = new fTrangChu(txtUsername.Text);
                    this.Hide();
                    f.ShowDialog();
                    // mở form user
                }  
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Lỗi đăng nhập");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}

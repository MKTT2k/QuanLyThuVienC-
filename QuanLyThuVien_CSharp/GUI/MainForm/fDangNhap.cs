using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_CSharp.GUI.MainForm
{
    public partial class fDangNhap : Form
    {
        QuanLyThuVien_CSharpDataContext dataContext = new QuanLyThuVien_CSharpDataContext();
        string accountType;

        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
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
                        this.Hide();
                        //f.ShowDialog();
                    }
                    else
                    {
                        // mở form user                        
                        this.Hide();
                        //f.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Lỗi đăng nhập");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Có lỗi xảy ra");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}

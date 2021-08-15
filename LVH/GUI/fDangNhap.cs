using LVH.GUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LVH
{
    public partial class FormDangNhap : Form
    {
        QuanLyThuVienDataContext dataContext = new QuanLyThuVienDataContext();
        string loaiTaiKhoan;

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if (dataContext.TAIKHOANs.Where(p => p.TenDangNhap == txtTenDangNhap.Text && p.MatKhau == txtMatKhau.Text).Count() > 0)
            {
                var s = from p in dataContext.TAIKHOANs
                        where p.TenDangNhap == txtTenDangNhap.Text && p.MatKhau == txtMatKhau.Text
                        select new { p.LoaiTaiKhoan };
                foreach (var i in s)
                {
                    loaiTaiKhoan = i.LoaiTaiKhoan.ToString(); ;
                }
                if (loaiTaiKhoan == "0")
                {
                    // mở form admin
                }
                else
                {
                    fTrangChu f = new fTrangChu(txtTenDangNhap.Text);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}

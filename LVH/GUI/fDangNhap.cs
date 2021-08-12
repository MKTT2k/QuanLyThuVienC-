using LVH.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVH
{
    public partial class FormDangNhap : Form
    {
        
        QLThuVienCSharpDataContext dataContext = new QLThuVienCSharpDataContext();
        public FormDangNhap()
        {

            InitializeComponent();
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {            
            if((dataContext.TAIKHOANs.Select(p => p).Where(p => p.TenDangNhap == txtTenDangNhap.Text && p.MatKhau == txtMatKhau.Text)) == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Lỗi đăng nhập");
            }
            else
            {
                fTrangChu f = new fTrangChu();
                this.Hide();
                f.ShowDialog();
            }

            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?","Xác nhận",MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }    
        }
    }
}

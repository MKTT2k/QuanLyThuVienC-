using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVH.GUI
{
    public partial class fTrangChu : Form
    {
        String Username;
        public fTrangChu(string Username)
        {
            InitializeComponent();
            this.Username = Username;
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            fQuanLyTaiKhoan f = new fQuanLyTaiKhoan();
            this.Hide();
            f.Show();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            fDoiMatKhau fdoimatkhau = new fDoiMatKhau(Username);
            this.Hide();
            fdoimatkhau.Show();
        }
    }
}

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
    public partial class fTrangChuAdmin : Form
    {
        private Form currentChildForm;
        bool userMenu = false;
        string userName, tenND;
        int accountType;
        public fTrangChuAdmin()
        {
            InitializeComponent();
            LoadData();
        }
        public fTrangChuAdmin(string userName, string tenND, int accountType)
        {
            InitializeComponent();
            this.userName = userName;
            this.tenND = tenND;
            this.accountType = accountType;
            LoadData();
            
        }
        public void LoadData()
        {
            btnDoiMatKhau.Visible = false;
            btnDangXuat.Visible = false;
            if(accountType == 0)
            {
                btnQuanLySach.Visible = true;
                btnQuanLyTaiKhoan.Visible = true;
                btnThongKe.Visible = true;
                btnXemSach.Visible = false;
            }
            else
            {
                btnQuanLySach.Visible = false;
                btnQuanLyTaiKhoan.Visible = false;
                btnThongKe.Visible = false;
                btnXemSach.Visible = true;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlHienThi.Controls.Clear();
            pnlHienThi.Controls.Add(childForm);
            pnlHienThi.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lbl_currentChildForm.Text = childForm.Text;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 255, 255);
            public static Color color2 = Color.FromArgb(0, 48, 96);
            public static Color color3 = Color.FromArgb(24, 154, 180);
            public static Color color4 = Color.FromArgb(0, 0, 0);
            public static Color color5 = Color.FromArgb(0, 0, 0);
            public static Color color6 = Color.FromArgb(0, 0, 0);
        }
        
        private void btnUser_Click(object sender, EventArgs e)
        {
            if (!userMenu)
            {
                btnDoiMatKhau.Visible = true;
                btnDangXuat.Visible = true;
                userMenu = true;
            }
            else
            {
                btnDoiMatKhau.Visible = false;
                btnDangXuat.Visible = false;
                userMenu = false;
            }
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForm.fQuanLySach());
            lblTieuDe.Text = "Quản lý sách";
        }

        private void btnXemSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManagerForm.XemSach.fXemSach());
            lblTieuDe.Text = "Xem sách";
        }

        private void btnQuanLyMuonTra_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManagerForm.QLPhieuMuon.fQLPhieuMuon());
            lblTieuDe.Text = "Quản lý mượn trả";
        }

        private void btnQuanLyDocGia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManagerForm.QLDocGia.fQLDocGia());
            lblTieuDe.Text = "Quản lý độc giả";
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            //lblIcon.Image = QuanLyThuVien_CSharp.Properties.Resources;
            OpenChildForm(new AdminForm.QuanLyTaiKhoan.fQuanLyTaiKhoan());
            lblTieuDe.Text = "Quản lý tài khoản";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            lblIcon.Image = QuanLyThuVien_CSharp.Properties.Resources.statistic;
            OpenChildForm(new AdminForm.ThongKe.fThongKe());
            lblTieuDe.Text = "Thống kê";
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyTaiKhoan.fDoiMatKhau(btnUser.Text));
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            fDangNhap f = new fDangNhap();
            this.Close();
            f.Show();
        }
    }
}

using QuanLyThuVien_CSharp.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_CSharp.GUI.AdminForm.QuanLyTaiKhoan
{
    public partial class fThemTaiKhoan : Form
    {
        QuanLyThuVien_CSharpDataContext dataContext = new QuanLyThuVien_CSharpDataContext();
        fQuanLyTaiKhoan QuanLyTaiKhoan;
        private bool hasPicture = false;

        public fThemTaiKhoan(fQuanLyTaiKhoan f)
        {
            InitializeComponent();
            openImg.FileName = null;
            rdbEnabled.Checked = true;
            QuanLyTaiKhoan = f;
        }

        private void btnChooseImg_Click(object sender, EventArgs e)
        {
            openImg.Title = "chọn ảnh";
            openImg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openImg.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    lbl_image.Image = Image.FromFile(openImg.FileName);
                    hasPicture = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Có lỗi xảy ra");
                }
            }
        }

        private void addTaiKhoan()
        {
            try
            {
                if (txtUsername.Text == "") throw new Exception("Tên đăng nhập không được để trống");
                if (txtName.Text == "") throw new Exception("Tên người không được để trống");
                if (!hasPicture) throw new Exception("Chưa chọn ảnh đại diện");

                TAIKHOAN themTaiKhoan = new TAIKHOAN();
                themTaiKhoan.AnhDaiDien = new ConvertImages().ConvertImageToBytes(lbl_image.Image);
                themTaiKhoan.MatKhau = "123";
                themTaiKhoan.TenDangNhap = txtUsername.Text;
                themTaiKhoan.TenNguoiDung = txtName.Text;
                themTaiKhoan.LoaiTaiKhoan = 1;
                themTaiKhoan.TinhTrang = rdbEnabled.Checked ? true : false;

                dataContext.TAIKHOANs.InsertOnSubmit(themTaiKhoan);
                dataContext.SubmitChanges();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Có lỗi xảy ra");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addTaiKhoan();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void fThemTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi giao diện thêm tài khoản?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}

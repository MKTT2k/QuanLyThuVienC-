using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LVH.BUS;
using LVH.DTO;

namespace LVH.GUI
{
    public partial class fThemTaiKhoan : Form
    {

        QLThuVienCSharpDataContext dataContext = new QLThuVienCSharpDataContext();
        fQuanLyTaiKhoan QLTaiKhoan;
        bool coAnh = false;
        public fThemTaiKhoan(fQuanLyTaiKhoan f)
        {
            InitializeComponent();
            openFileDialog1.FileName = null;
            rdbEnabled.Checked = true;
            QLTaiKhoan = f;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "chọn ảnh";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            Image img;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    img = Image.FromFile(openFileDialog1.FileName);
                    lbl_image.Image = img;
                    coAnh = true;
                }
                catch (FileNotFoundException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {               
                TAIKHOAN themTaiKhoan = new TAIKHOAN();
                themTaiKhoan.AnhDaiDien = new BUS.ConvertImage().ConvertImageToBytes(lbl_image.Image);
                themTaiKhoan.MatKhau = "123";
                themTaiKhoan.TenDangNhap = txtUserName.Text;
                themTaiKhoan.TenNguoiDung = txtName.Text;
                themTaiKhoan.LoaiTaiKhoan = 1;
                themTaiKhoan.TinhTrang = rdbEnabled.Checked ? true : false;

                dataContext.TAIKHOANs.InsertOnSubmit(themTaiKhoan);
                dataContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Có lỗi xảy ra");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

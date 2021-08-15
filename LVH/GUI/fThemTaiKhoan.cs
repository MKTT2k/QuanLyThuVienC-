﻿using System;
using System.Drawing;
using System.Windows.Forms;
using LVH.BUS;

namespace LVH.GUI
{
    public partial class fThemTaiKhoan : Form
    {

        QuanLyThuVienDataContext dataContext = new QuanLyThuVienDataContext();
        fQuanLyTaiKhoan QuanLyTaiKhoan;
        private bool hasPicture = false;

        public fThemTaiKhoan(fQuanLyTaiKhoan f)
        {
            InitializeComponent();
            openFileDialog1.FileName = null;
            rdbEnabled.Checked = true;
            QuanLyTaiKhoan = f;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "chọn ảnh";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    lbl_image.Image = Image.FromFile(openFileDialog1.FileName);
                    hasPicture = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Có lỗi xảy ra");
                }
            }
        }

        private void AddTaiKhoan()
        {
            try
            {
                if (txtUsername.Text == "") throw new Exception("Tên đăng nhập không được để trống");
                if (txtName.Text == "") throw new Exception("Tên người không được để trống");
                if (!hasPicture) throw new Exception("Chưa chọn ảnh đại diện");

                TAIKHOAN themTaiKhoan = new TAIKHOAN();
                themTaiKhoan.AnhDaiDien = new ConvertImage().ConvertImageToBytes(lbl_image.Image);
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddTaiKhoan();
            this.Dispose();          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {        
            this.Dispose();
        }
    }
}

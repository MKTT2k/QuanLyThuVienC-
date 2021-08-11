using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        fQuanLyTaiKhoan QLTaiKhoan;
        bool coAnh = false;
        public fThemTaiKhoan(fQuanLyTaiKhoan f)
        {
            InitializeComponent();
            QLTaiKhoan = f;
            prepare();
        }

        public void prepare()
        {
            rd_KichHoat.Checked = true;
            openFileDialog1.FileName = null;
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
                if (txtUserName.Text.Equals(""))
                {
                    txtUserName.Focus();
                    throw new Exception("Tên đăng nhập không được bỏ trống");
                }
                if (txt_TenNguoiDung.Text.Equals(""))
                {
                    txt_TenNguoiDung.Focus();
                    throw new Exception("Tên người dùng không được bỏ trống");
                }
                if (!coAnh)
                {
                    throw new Exception("Chưa có ảnh đại diện");
                }
                else
                {
                    new BUS_TaiKhoan().ThemTaiKhoan(new ConvertImage().ConvertImageToBytes(lbl_image.Image),
                        txt_TenTaiKhoan.Text,
                        "123",
                        txt_TenNguoiDung.Text,
                        1,
                        rd_KichHoat.Checked ? true : false);
                    QLTaiKhoan.prepare();
                    MessageBox.Show("Thêm tài khoản thành công!");
                    this.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Có lỗi xảy ra");
            }
        }
    }
}

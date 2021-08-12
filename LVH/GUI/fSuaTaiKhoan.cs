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

namespace LVH.GUI
{
    public partial class fSuaTaiKhoan : Form
    {
        QLThuVienCSharpDataContext dataContext = new QLThuVienCSharpDataContext();
        private byte[] AnhDaiDien;
        private string TenDangNhap, TenNguoiDung;
        private bool TinhTrang;
        public fSuaTaiKhoan()
        {
            InitializeComponent();
        }
        public fSuaTaiKhoan(byte[] AnhDaiDien, string TenDangNhap, string TenNguoiDung, bool TinhTrang)
        {
            InitializeComponent();
            this.AnhDaiDien = AnhDaiDien;
            this.TenDangNhap = TenDangNhap;
            this.TenNguoiDung = TenNguoiDung;
            this.TinhTrang = TinhTrang;

        }

        
        private void btnChooseImg_Click(object sender, EventArgs e)
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
                }
                catch (FileNotFoundException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TAIKHOAN suaTaiKhoan = new TAIKHOAN();
            suaTaiKhoan.AnhDaiDien = new BUS.ConvertImage().ConvertImageToBytes(lbl_image.Image);
            suaTaiKhoan.TenNguoiDung = txtName.Text;           
        }

        private void fSuaTaiKhoan_Load(object sender, EventArgs e)
        {
            lbl_image.Image = new BUS.ConvertImage().ConvertBytesToImage(AnhDaiDien);
            txtUserName.Text = TenDangNhap;
            txtName.Text = TenNguoiDung;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

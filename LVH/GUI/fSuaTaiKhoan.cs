using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace LVH.GUI
{
    public partial class fSuaTaiKhoan : Form
    {
        QuanLyThuVienDataContext dataContext = new QuanLyThuVienDataContext();
        fQuanLyTaiKhoan QuanLyTaiKhoan;
        String userName;
        int IDAccount;

        public fSuaTaiKhoan(fQuanLyTaiKhoan f, string username)
        {
            InitializeComponent();
            QuanLyTaiKhoan = f;
            userName = username;
            prepare();           
        }

        private void prepare()
        {
            try
            {
                var s = from p in dataContext.TAIKHOANs
                        where p.TenDangNhap == userName
                        select new {p.IDTaiKhoan, AnhDaiDien = p.AnhDaiDien.ToArray(), p.TenDangNhap, p.MatKhau, p.TenNguoiDung, p.LoaiTaiKhoan, p.TinhTrang };
                foreach (var i in s.ToList())
                {
                    IDAccount = i.IDTaiKhoan ;
                    lbl_image.Image = new BUS.ConvertImage().ConvertBytesToImage(i.AnhDaiDien);
                    txtUsername.Text = i.TenDangNhap;
                    txtName.Text = i.TenNguoiDung;
                    if (i.TinhTrang == true) rdbEnabled.Checked = true;
                    else rdDisabled.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Có lỗi xảy ra");
            }
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Có lỗi xảy ra");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var querry = (from p in dataContext.TAIKHOANs
                              where p.IDTaiKhoan == IDAccount
                              select p).FirstOrDefault<TAIKHOAN>();
                querry.AnhDaiDien = new BUS.ConvertImage().ConvertImageToBytes(lbl_image.Image);
                querry.TenNguoiDung = txtName.Text;
                dataContext.SubmitChanges();
                MessageBox.Show("Sửa thành công");
                this.Dispose();
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

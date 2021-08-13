using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using QuanLyThuVien_CSharp.BLL;

namespace QuanLyThuVien_CSharp.GUI.AdminForm.QuanLySach
{
    public partial class fThemSach : Form
    {
        QuanLyThuVien_CSharpDataContext dataContext = new QuanLyThuVien_CSharpDataContext();
        fQuanLySach QuanLySach;
        bool textChange;
        bool hasImage = false;
        
        public fThemSach()
        {
            InitializeComponent();
        }
        public fThemSach(fQuanLySach f)
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            cbbTenDanhMuc.DataSource = dataContext.DANHMUCs.Select(p => p);
            cbbTenDanhMuc.DisplayMember = "TenDanhMuc";
            cbbTenDanhMuc.ValueMember = "MaDanhMuc";
            openFileDialog1.FileName = null;

            cbbTenDanhMuc.SelectedIndex = 0;
            txtTenSach.Clear();
            ActiveControl = txtTenSach;
            txtTacGia.Clear();
            txtNhaXuatBan.Clear();
            txtGiaMuon.Clear();
            nudLanXuatBan.Value = 1;
            nudSoLuong.Value = 1;
            dtpNamXuatBan.Value.ToString("2000-12-17");

            btnLuu.Enabled = false;
            btnXoaNDNhap.Enabled = false;
            textChange = false;
            
        }

        private void txtTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGiaMuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbbTenDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            textChange = true;
            btnLuu.Enabled = true;
            btnXoaNDNhap.Enabled = true;
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {
            textChange = true;
            btnLuu.Enabled = true;
            btnXoaNDNhap.Enabled = true;
        }

        private void txtTacGia_TextChanged(object sender, EventArgs e)
        {
            textChange = true;
            btnLuu.Enabled = true;
            btnXoaNDNhap.Enabled = true;
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            textChange = true;
            btnLuu.Enabled = true;
            btnXoaNDNhap.Enabled = true;
        }

        private void txtGiaMuon_TextChanged(object sender, EventArgs e)
        {
            textChange = true;
            btnLuu.Enabled = true;
            btnXoaNDNhap.Enabled = true;
        }

        private void txtNhaXuatBan_TextChanged(object sender, EventArgs e)
        {
            textChange = true;
            btnLuu.Enabled = true;
            btnXoaNDNhap.Enabled = true;
        }

        private void dtpNamXuatBan_ValueChanged(object sender, EventArgs e)
        {
            textChange = true;
            btnLuu.Enabled = true;
            btnXoaNDNhap.Enabled = true;
        }

        private void nudLanXuatBan_ValueChanged(object sender, EventArgs e)
        {
            textChange = true;
            btnLuu.Enabled = true;
            btnXoaNDNhap.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenSach.Text.Equals(""))
                {
                    MessageBox.Show("Tên sách không được để trống!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtTacGia.Text.Equals(""))
                {
                    MessageBox.Show("Tên tác giả không được để trống!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!UInt32.TryParse(txtGiaMuon.Text, out UInt32 o))
                {
                    MessageBox.Show("Giá mượn phải là số nguyên dương!", "Format error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtNhaXuatBan.Text.Equals(""))
                {
                    MessageBox.Show("Tên nhà xuất bản không được để trống!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!hasImage)
                {
                    MessageBox.Show("Chưa có ảnh!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SACH sach = new SACH();
                sach.TenSach = txtTenSach.Text;
                sach.TacGia = txtTacGia.Text;
                sach.SoLuong = Int32.Parse(nudSoLuong.Text);
                sach.GiaMuon = Int32.Parse(txtGiaMuon.Text);
                sach.NhaXuatBan = txtNhaXuatBan.Text;
                sach.NamXuatBan = dtpNamXuatBan.Value;
                sach.LanXuatBan = Int32.Parse(nudLanXuatBan.Text);
                sach.MaDanhMuc = Int32.Parse(cbbTenDanhMuc.SelectedValue.ToString());
                sach.AnhSach = new ConvertImages().ConvertImageToBytes(ptbAnhSach.Image);
                dataContext.SACHes.InsertOnSubmit(sach);
                dataContext.SubmitChanges();
                MessageBox.Show("Lưu thành công!", "Successfully", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThayAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Chọn ảnh";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.gif";
            Image img;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    img = Image.FromFile(openFileDialog1.FileName);
                    ptbAnhSach.Image = img;
                    hasImage = true;
                }
                catch (FileNotFoundException fileEx)
                {
                    MessageBox.Show(fileEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXoaNDNhap_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

using QuanLyThuVien_CSharp.GUI.AdminForm.QuanLySach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_CSharp.GUI.AdminForm
{
    public partial class fQuanLySach : Form
    {
        QuanLyThuVien_CSharpDataContext dataContext = new QuanLyThuVien_CSharpDataContext();
        int index = -1;
        public fQuanLySach()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            cbbTimKiem.Items.Clear();
            cbbTimKiem.Items.Add("Tên sách");
            cbbTimKiem.Items.Add("Tác giả");
            cbbTimKiem.Items.Add("Nhà xuất bản");
            cbbTimKiem.Items.Add("Năm xuất bản");
            cbbTimKiem.Items.Add("Tên danh mục");
            cbbTimKiem.SelectedIndex = 0;
            txtNoiDungTim.Clear();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnIn.Enabled = false;

            try
            {
                var s = from p in dataContext.SACHes
                        join k in dataContext.DANHMUCs
                        on p.MaDanhMuc equals k.MaDanhMuc
                        select new { AnhSach = p.AnhSach.ToArray(), p.MaSach, p.TenSach, p.TacGia, p.NhaXuatBan, k.TenDanhMuc, p.NamXuatBan, p.LanXuatBan, p.SoLuong, p.GiaMuon };
                dgvSach.DataSource = s.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemSach themSach = new fThemSach(this);
            themSach.ShowDialog();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnIn.Enabled = true;
            }
            else
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnIn.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fSuaThongTinSach suaThongTinSach = new fSuaThongTinSach(this,Int32.Parse(dgvSach.Rows[index].Cells[1].Value.ToString()));
            suaThongTinSach.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá sách này không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    var xoa = dataContext.SACHes.Where(p => p.MaSach == Int32.Parse(dgvSach.Rows[index].Cells[1].Value.ToString()));

                    foreach (var i in xoa)
                    {
                        dataContext.SACHes.DeleteOnSubmit(i);
                        dataContext.SubmitChanges();
                    }
                    LoadData();
                    MessageBox.Show("Xóa thành công", "Successfully", MessageBoxButtons.OK);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNoiDungTim.Text.Equals(""))
                {
                    MessageBox.Show("Nếu muốn tìm kiếm thì nhập nội dung nhé!", "Empty", MessageBoxButtons.OK);
                    LoadData();
                }
                else
                {
                    switch (cbbTimKiem.SelectedIndex)
                    {
                        case 0:
                            var s = from p in dataContext.SACHes
                                    join k in dataContext.DANHMUCs
                                    on p.MaDanhMuc equals k.MaDanhMuc
                                    where SqlMethods.Like(p.TenSach, "%" + txtNoiDungTim.Text + "%")
                                    select new { AnhSach = p.AnhSach.ToArray(), p.MaSach, p.TenSach, p.TacGia, p.NhaXuatBan, k.TenDanhMuc, p.NamXuatBan, p.LanXuatBan, p.SoLuong, p.GiaMuon };
                            dgvSach.DataSource = s.ToList();
                            break;
                        case 1:
                            s = from p in dataContext.SACHes
                                    join k in dataContext.DANHMUCs
                                    on p.MaDanhMuc equals k.MaDanhMuc
                                    where SqlMethods.Like(p.TacGia, "%" + txtNoiDungTim.Text + "%")
                                    select new { AnhSach = p.AnhSach.ToArray(), p.MaSach, p.TenSach, p.TacGia, p.NhaXuatBan, k.TenDanhMuc, p.NamXuatBan, p.LanXuatBan, p.SoLuong, p.GiaMuon };
                            dgvSach.DataSource = s.ToList();
                            break;
                        case 2:
                            s = from p in dataContext.SACHes
                                    join k in dataContext.DANHMUCs
                                    on p.MaDanhMuc equals k.MaDanhMuc
                                    where SqlMethods.Like(p.NhaXuatBan, "%" + txtNoiDungTim.Text + "%")
                                    select new { AnhSach = p.AnhSach.ToArray(), p.MaSach, p.TenSach, p.TacGia, p.NhaXuatBan, k.TenDanhMuc, p.NamXuatBan, p.LanXuatBan, p.SoLuong, p.GiaMuon };
                            dgvSach.DataSource = s.ToList();
                            break;
                        case 3:
                            s = from p in dataContext.SACHes
                                join k in dataContext.DANHMUCs
                                on p.MaDanhMuc equals k.MaDanhMuc
                                where (p.NamXuatBan).Value.ToString("yyyy") == txtNoiDungTim.Text
                                select new { AnhSach = p.AnhSach.ToArray(), p.MaSach, p.TenSach, p.TacGia, p.NhaXuatBan, k.TenDanhMuc, p.NamXuatBan, p.LanXuatBan, p.SoLuong, p.GiaMuon };
                            dgvSach.DataSource = s.ToList();
                            break;
                        case 4:
                            s = from p in dataContext.SACHes
                                    join k in dataContext.DANHMUCs
                                    on p.MaDanhMuc equals k.MaDanhMuc
                                    where SqlMethods.Like(p.TenSach, "%" + txtNoiDungTim.Text + "%")
                                    select new { AnhSach = p.AnhSach.ToArray(), p.MaSach, p.TenSach, p.TacGia, p.NhaXuatBan, k.TenDanhMuc, p.NamXuatBan, p.LanXuatBan, p.SoLuong, p.GiaMuon };
                            dgvSach.DataSource = s.ToList();
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void cbbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTimKiem.SelectedIndex == 3) label2.Text = "Năm sản xuất";
        }
    }
}

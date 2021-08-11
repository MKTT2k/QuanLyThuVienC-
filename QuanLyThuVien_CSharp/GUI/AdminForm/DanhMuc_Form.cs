﻿using QuanLyThuVien_CSharp.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_CSharp
{
    public partial class DanhMuc_Form : Form
    {
        QuanLyThuVien_CSharpDataContext dataContext = new QuanLyThuVien_CSharpDataContext();
        int index = -1;
        public DanhMuc_Form()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            dgvDanhMuc.DataSource = dataContext.DANHMUCs.Select(p => p);

            txtTenDanhMuc.Clear();
            ActiveControl = txtTenDanhMuc;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = false;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDanhMuc.Text.Equals(""))
                {
                    ActiveControl = txtTenDanhMuc;
                    MessageBox.Show("Tên danh mục không được để trống", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var danhMuc = dataContext.DANHMUCs.Where(p => p.TenDanhMuc == txtTenDanhMuc.Text);
                if (danhMuc.Count() > 0)
                {
                    MessageBox.Show("Tên danh mục đã trùng trong hệ thống", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var suaDanhMuc = dataContext.DANHMUCs.Single(p => p.MaDanhMuc == Int32.Parse(dgvDanhMuc.Rows[index].Cells[0].Value.ToString()));
                suaDanhMuc.TenDanhMuc = txtTenDanhMuc.Text;
                dataContext.SubmitChanges();
                txtTenDanhMuc.Clear();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá danh mục này không ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    var xoa = dataContext.DANHMUCs.Where(p => p.MaDanhMuc == Int32.Parse(dgvDanhMuc.Rows[index].Cells[0].Value.ToString())); 
                              
                    foreach (var i in xoa)
                    {
                        dataContext.DANHMUCs.DeleteOnSubmit(i);
                        dataContext.SubmitChanges();
                    }
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDanhMuc.Text.Equals(""))
                {
                    ActiveControl = txtTenDanhMuc;
                    MessageBox.Show("Tên danh mục không được để trống", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var danhMuc = dataContext.DANHMUCs.Where(p => p.TenDanhMuc == txtTenDanhMuc.Text);
                if (danhMuc.Count() > 0)
                {
                    MessageBox.Show("Tên danh mục đã trùng trong hệ thống", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DANHMUC themDanhMuc = new DANHMUC();
                themDanhMuc.TenDanhMuc = txtTenDanhMuc.Text;

                dataContext.DANHMUCs.InsertOnSubmit(themDanhMuc);
                dataContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void txtTenDanhMuc_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                if (index >= 0)
                {
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnBoQua.Enabled = true;
                    txtTenDanhMuc.Text = dgvDanhMuc.Rows[index].Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

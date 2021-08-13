﻿
namespace QuanLyThuVien_CSharp.GUI.AdminForm.QuanLySach
{
    partial class fSuaThongTinSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ptbAnhSach = new System.Windows.Forms.PictureBox();
            this.btnThayAnh = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoaNDNhap = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbTenDanhMuc = new System.Windows.Forms.ComboBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtGiaMuon = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtNhaXuatBan = new System.Windows.Forms.TextBox();
            this.nudLanXuatBan = new System.Windows.Forms.NumericUpDown();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dtpNamXuatBan = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLanXuatBan)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbAnhSach
            // 
            this.ptbAnhSach.Image = global::QuanLyThuVien_CSharp.Properties.Resources.book;
            this.ptbAnhSach.Location = new System.Drawing.Point(30, 65);
            this.ptbAnhSach.Name = "ptbAnhSach";
            this.ptbAnhSach.Size = new System.Drawing.Size(206, 233);
            this.ptbAnhSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAnhSach.TabIndex = 14;
            this.ptbAnhSach.TabStop = false;
            // 
            // btnThayAnh
            // 
            this.btnThayAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayAnh.Image = global::QuanLyThuVien_CSharp.Properties.Resources.replace;
            this.btnThayAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThayAnh.Location = new System.Drawing.Point(14, 313);
            this.btnThayAnh.Name = "btnThayAnh";
            this.btnThayAnh.Size = new System.Drawing.Size(238, 54);
            this.btnThayAnh.TabIndex = 24;
            this.btnThayAnh.Text = "Thay ảnh sách";
            this.btnThayAnh.UseVisualStyleBackColor = true;
            this.btnThayAnh.Click += new System.EventHandler(this.btnThayAnh_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QuanLyThuVien_CSharp.Properties.Resources.save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(389, 468);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(160, 54);
            this.btnLuu.TabIndex = 33;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoaNDNhap
            // 
            this.btnXoaNDNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNDNhap.Image = global::QuanLyThuVien_CSharp.Properties.Resources.clear;
            this.btnXoaNDNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaNDNhap.Location = new System.Drawing.Point(582, 468);
            this.btnXoaNDNhap.Name = "btnXoaNDNhap";
            this.btnXoaNDNhap.Size = new System.Drawing.Size(256, 54);
            this.btnXoaNDNhap.TabIndex = 34;
            this.btnXoaNDNhap.Text = "Xóa nội dung nhập";
            this.btnXoaNDNhap.UseVisualStyleBackColor = true;
            this.btnXoaNDNhap.Click += new System.EventHandler(this.btnXoaNDNhap_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Image = global::QuanLyThuVien_CSharp.Properties.Resources._return;
            this.btnQuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayLai.Location = new System.Drawing.Point(868, 468);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(182, 54);
            this.btnQuayLai.TabIndex = 35;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "VNĐ";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(320, 37);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(115, 20);
            this.lbl.TabIndex = 16;
            this.lbl.Text = "Tên danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tác giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Giá mượn";
            // 
            // cbbTenDanhMuc
            // 
            this.cbbTenDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenDanhMuc.FormattingEnabled = true;
            this.cbbTenDanhMuc.Location = new System.Drawing.Point(323, 60);
            this.cbbTenDanhMuc.Name = "cbbTenDanhMuc";
            this.cbbTenDanhMuc.Size = new System.Drawing.Size(199, 28);
            this.cbbTenDanhMuc.TabIndex = 25;
            this.cbbTenDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbbTenDanhMuc_SelectedIndexChanged);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(323, 131);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(306, 27);
            this.txtTenSach.TabIndex = 26;
            this.txtTenSach.TextChanged += new System.EventHandler(this.txtTenSach_TextChanged);
            // 
            // txtGiaMuon
            // 
            this.txtGiaMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaMuon.Location = new System.Drawing.Point(323, 341);
            this.txtGiaMuon.Name = "txtGiaMuon";
            this.txtGiaMuon.Size = new System.Drawing.Size(172, 27);
            this.txtGiaMuon.TabIndex = 29;
            this.txtGiaMuon.TextChanged += new System.EventHandler(this.txtGiaMuon_TextChanged);
            this.txtGiaMuon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaMuon_KeyPress);
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacGia.Location = new System.Drawing.Point(323, 201);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(306, 27);
            this.txtTacGia.TabIndex = 27;
            this.txtTacGia.TextChanged += new System.EventHandler(this.txtTacGia_TextChanged);
            this.txtTacGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTacGia_KeyPress);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(323, 271);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(172, 27);
            this.nudSoLuong.TabIndex = 28;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.ValueChanged += new System.EventHandler(this.nudSoLuong_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(729, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nhà xuất bản";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(729, 319);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(105, 20);
            this.lbl2.TabIndex = 20;
            this.lbl2.Text = "Lần xuất bản";
            // 
            // txtNhaXuatBan
            // 
            this.txtNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaXuatBan.Location = new System.Drawing.Point(732, 201);
            this.txtNhaXuatBan.Name = "txtNhaXuatBan";
            this.txtNhaXuatBan.Size = new System.Drawing.Size(306, 27);
            this.txtNhaXuatBan.TabIndex = 30;
            this.txtNhaXuatBan.TextChanged += new System.EventHandler(this.txtNhaXuatBan_TextChanged);
            // 
            // nudLanXuatBan
            // 
            this.nudLanXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLanXuatBan.Location = new System.Drawing.Point(732, 340);
            this.nudLanXuatBan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLanXuatBan.Name = "nudLanXuatBan";
            this.nudLanXuatBan.Size = new System.Drawing.Size(136, 27);
            this.nudLanXuatBan.TabIndex = 32;
            this.nudLanXuatBan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLanXuatBan.ValueChanged += new System.EventHandler(this.nudLanXuatBan_ValueChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(729, 249);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(112, 20);
            this.lbl1.TabIndex = 17;
            this.lbl1.Text = "Năm xuất bản";
            // 
            // dtpNamXuatBan
            // 
            this.dtpNamXuatBan.CustomFormat = "yyyy-MM-dd";
            this.dtpNamXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNamXuatBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNamXuatBan.Location = new System.Drawing.Point(732, 271);
            this.dtpNamXuatBan.Name = "dtpNamXuatBan";
            this.dtpNamXuatBan.Size = new System.Drawing.Size(200, 27);
            this.dtpNamXuatBan.TabIndex = 31;
            this.dtpNamXuatBan.Value = new System.DateTime(2000, 12, 17, 10, 42, 0, 0);
            this.dtpNamXuatBan.ValueChanged += new System.EventHandler(this.dtpNamXuatBan_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fSuaThongTinSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1064, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNamXuatBan);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.nudLanXuatBan);
            this.Controls.Add(this.txtNhaXuatBan);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.txtGiaMuon);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.cbbTenDanhMuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXoaNDNhap);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThayAnh);
            this.Controls.Add(this.ptbAnhSach);
            this.Name = "fSuaThongTinSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa thông tin sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fSuaThongTinSach_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLanXuatBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbAnhSach;
        private System.Windows.Forms.Button btnThayAnh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaNDNhap;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTenDanhMuc;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtGiaMuon;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtNhaXuatBan;
        private System.Windows.Forms.NumericUpDown nudLanXuatBan;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DateTimePicker dtpNamXuatBan;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
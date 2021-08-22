﻿
namespace QuanLyThuVien_CSharp.GUI.MainForm
{
    partial class fTrangChu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.btnQuanLyDocGia = new System.Windows.Forms.Button();
            this.btnQuanLyMuonTra = new System.Windows.Forms.Button();
            this.btnQuanLySach = new System.Windows.Forms.Button();
            this.btnXemSach = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlHienThi = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 814);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSalmon;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(298, 814);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.pictureBox1.Image = global::QuanLyThuVien_CSharp.Properties.Resources.logoHaui;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSalmon;
            this.panel3.Controls.Add(this.btnThongKe);
            this.panel3.Controls.Add(this.btnQuanLyTaiKhoan);
            this.panel3.Controls.Add(this.btnQuanLyDocGia);
            this.panel3.Controls.Add(this.btnQuanLyMuonTra);
            this.panel3.Controls.Add(this.btnQuanLySach);
            this.panel3.Controls.Add(this.btnXemSach);
            this.panel3.Location = new System.Drawing.Point(3, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 471);
            this.panel3.TabIndex = 1;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Beige;
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(0, 365);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(10);
            this.btnThongKe.Size = new System.Drawing.Size(292, 73);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.BackColor = System.Drawing.Color.Beige;
            this.btnQuanLyTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(0, 292);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Padding = new System.Windows.Forms.Padding(10);
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(292, 73);
            this.btnQuanLyTaiKhoan.TabIndex = 4;
            this.btnQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = false;
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // btnQuanLyDocGia
            // 
            this.btnQuanLyDocGia.BackColor = System.Drawing.Color.Beige;
            this.btnQuanLyDocGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDocGia.Location = new System.Drawing.Point(0, 219);
            this.btnQuanLyDocGia.Name = "btnQuanLyDocGia";
            this.btnQuanLyDocGia.Padding = new System.Windows.Forms.Padding(10);
            this.btnQuanLyDocGia.Size = new System.Drawing.Size(292, 73);
            this.btnQuanLyDocGia.TabIndex = 3;
            this.btnQuanLyDocGia.Text = "Quản lý độc giả";
            this.btnQuanLyDocGia.UseVisualStyleBackColor = false;
            this.btnQuanLyDocGia.Click += new System.EventHandler(this.btnQuanLyDocGia_Click);
            // 
            // btnQuanLyMuonTra
            // 
            this.btnQuanLyMuonTra.BackColor = System.Drawing.Color.Beige;
            this.btnQuanLyMuonTra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyMuonTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyMuonTra.Location = new System.Drawing.Point(0, 146);
            this.btnQuanLyMuonTra.Name = "btnQuanLyMuonTra";
            this.btnQuanLyMuonTra.Padding = new System.Windows.Forms.Padding(10);
            this.btnQuanLyMuonTra.Size = new System.Drawing.Size(292, 73);
            this.btnQuanLyMuonTra.TabIndex = 2;
            this.btnQuanLyMuonTra.Text = "Quản lý mượn trả";
            this.btnQuanLyMuonTra.UseVisualStyleBackColor = false;
            this.btnQuanLyMuonTra.Click += new System.EventHandler(this.btnQuanLyMuonTra_Click);
            // 
            // btnQuanLySach
            // 
            this.btnQuanLySach.BackColor = System.Drawing.Color.Beige;
            this.btnQuanLySach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLySach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLySach.Location = new System.Drawing.Point(0, 73);
            this.btnQuanLySach.Name = "btnQuanLySach";
            this.btnQuanLySach.Padding = new System.Windows.Forms.Padding(10);
            this.btnQuanLySach.Size = new System.Drawing.Size(292, 73);
            this.btnQuanLySach.TabIndex = 1;
            this.btnQuanLySach.Text = "Quản lý sách";
            this.btnQuanLySach.UseVisualStyleBackColor = false;
            this.btnQuanLySach.Click += new System.EventHandler(this.btnQuanLySach_Click);
            // 
            // btnXemSach
            // 
            this.btnXemSach.BackColor = System.Drawing.Color.Beige;
            this.btnXemSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemSach.Location = new System.Drawing.Point(0, 0);
            this.btnXemSach.Name = "btnXemSach";
            this.btnXemSach.Padding = new System.Windows.Forms.Padding(10);
            this.btnXemSach.Size = new System.Drawing.Size(292, 73);
            this.btnXemSach.TabIndex = 0;
            this.btnXemSach.Text = "Xem sách";
            this.btnXemSach.UseVisualStyleBackColor = false;
            this.btnXemSach.Click += new System.EventHandler(this.btnXemSach_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LimeGreen;
            this.panel4.Controls.Add(this.btnDoiMatKhau);
            this.panel4.Controls.Add(this.btnUser);
            this.panel4.Controls.Add(this.btnDangXuat);
            this.panel4.Controls.Add(this.lblIcon);
            this.panel4.Controls.Add(this.lblTieuDe);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(298, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1542, 143);
            this.panel4.TabIndex = 1;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDoiMatKhau.Image = global::QuanLyThuVien_CSharp.Properties.Resources.replace;
            this.btnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(1317, 4);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(215, 54);
            this.btnDoiMatKhau.TabIndex = 2;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUser.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUser.Location = new System.Drawing.Point(1134, 3);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(185, 54);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Hà Thanh Hoàng";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDangXuat.Image = global::QuanLyThuVien_CSharp.Properties.Resources.logout;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(1317, 56);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(215, 54);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.Image = global::QuanLyThuVien_CSharp.Properties.Resources.home;
            this.lblIcon.Location = new System.Drawing.Point(33, 81);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(57, 32);
            this.lblIcon.TabIndex = 3;
            this.lblIcon.Text = "      ";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTieuDe.Location = new System.Drawing.Point(96, 81);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(142, 32);
            this.lblTieuDe.TabIndex = 2;
            this.lblTieuDe.Text = "Trang chủ";
            // 
            // pnlHienThi
            // 
            this.pnlHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHienThi.Location = new System.Drawing.Point(298, 143);
            this.pnlHienThi.Name = "pnlHienThi";
            this.pnlHienThi.Size = new System.Drawing.Size(1542, 671);
            this.pnlHienThi.TabIndex = 2;
            // 
            // fTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 814);
            this.Controls.Add(this.pnlHienThi);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "fTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTrangChuAdmin";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnQuanLyTaiKhoan;
        private System.Windows.Forms.Button btnQuanLyDocGia;
        private System.Windows.Forms.Button btnQuanLyMuonTra;
        private System.Windows.Forms.Button btnQuanLySach;
        private System.Windows.Forms.Button btnXemSach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel pnlHienThi;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
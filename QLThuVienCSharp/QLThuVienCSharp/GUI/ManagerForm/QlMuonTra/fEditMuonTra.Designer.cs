﻿
namespace QLThuVienCSharp.GUI.ManagerForm.QlMuonTra
{
    partial class fEditMuonTra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_soPhieuMuon = new System.Windows.Forms.Label();
            this.lb_stt = new System.Windows.Forms.Label();
            this.txt_ngaymuon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSachMuon = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nguoimuon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_soPhieuMuon
            // 
            this.lbl_soPhieuMuon.AutoSize = true;
            this.lbl_soPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soPhieuMuon.Location = new System.Drawing.Point(540, 99);
            this.lbl_soPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_soPhieuMuon.Name = "lbl_soPhieuMuon";
            this.lbl_soPhieuMuon.Size = new System.Drawing.Size(139, 20);
            this.lbl_soPhieuMuon.TabIndex = 43;
            this.lbl_soPhieuMuon.Text = "Số phiếu mượn:";
            this.lbl_soPhieuMuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_stt
            // 
            this.lb_stt.AutoSize = true;
            this.lb_stt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stt.Location = new System.Drawing.Point(540, 141);
            this.lb_stt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_stt.Name = "lb_stt";
            this.lb_stt.Size = new System.Drawing.Size(100, 20);
            this.lb_stt.TabIndex = 42;
            this.lb_stt.Text = "Tình trạng:";
            this.lb_stt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ngaymuon
            // 
            this.txt_ngaymuon.Enabled = false;
            this.txt_ngaymuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaymuon.Location = new System.Drawing.Point(43, 211);
            this.txt_ngaymuon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ngaymuon.Name = "txt_ngaymuon";
            this.txt_ngaymuon.ReadOnly = true;
            this.txt_ngaymuon.Size = new System.Drawing.Size(441, 30);
            this.txt_ngaymuon.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Ngày mượn";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSachMuon
            // 
            this.dgvSachMuon.AllowUserToAddRows = false;
            this.dgvSachMuon.AllowUserToDeleteRows = false;
            this.dgvSachMuon.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvSachMuon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSachMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSachMuon.BackgroundColor = System.Drawing.Color.White;
            this.dgvSachMuon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSachMuon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvSachMuon.ColumnHeadersHeight = 40;
            this.dgvSachMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MaSach,
            this.TenSach,
            this.TinhTrang,
            this.NgayTra});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSachMuon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSachMuon.GridColor = System.Drawing.Color.White;
            this.dgvSachMuon.Location = new System.Drawing.Point(43, 268);
            this.dgvSachMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSachMuon.MultiSelect = false;
            this.dgvSachMuon.Name = "dgvSachMuon";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSachMuon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSachMuon.RowHeadersVisible = false;
            this.dgvSachMuon.RowHeadersWidth = 40;
            this.dgvSachMuon.Size = new System.Drawing.Size(895, 294);
            this.dgvSachMuon.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Mã sinh viên người mượn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nguoimuon
            // 
            this.txt_nguoimuon.Enabled = false;
            this.txt_nguoimuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nguoimuon.Location = new System.Drawing.Point(43, 134);
            this.txt_nguoimuon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nguoimuon.Name = "txt_nguoimuon";
            this.txt_nguoimuon.ReadOnly = true;
            this.txt_nguoimuon.Size = new System.Drawing.Size(441, 30);
            this.txt_nguoimuon.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Thông tin chi tiết phiếu mượn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cập nhập phiếu mượn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 40);
            this.button1.TabIndex = 44;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 40);
            this.button2.TabIndex = 45;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // MaSach
            // 
            this.MaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 75;
            // 
            // TenSach
            // 
            this.TenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 300;
            // 
            // TinhTrang
            // 
            this.TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 120;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            // 
            // fEditMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 656);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_soPhieuMuon);
            this.Controls.Add(this.lb_stt);
            this.Controls.Add(this.txt_ngaymuon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvSachMuon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nguoimuon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fEditMuonTra";
            this.Text = "fEditMuonTra";
            this.Load += new System.EventHandler(this.fEditMuonTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_soPhieuMuon;
        private System.Windows.Forms.Label lb_stt;
        private System.Windows.Forms.TextBox txt_ngaymuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSachMuon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nguoimuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
    }
}
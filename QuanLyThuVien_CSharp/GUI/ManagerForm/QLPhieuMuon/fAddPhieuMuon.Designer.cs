
namespace QuanLyThuVien_CSharp.GUI.ManagerForm.QLPhieuMuon
{
    partial class fAddPhieuMuon
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblChiTietPhieu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsl = new System.Windows.Forms.Label();
            this.txtNguoiMuon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbSach = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvCTPHieu = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPHieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lập phiếu mượn";
            // 
            // lblChiTietPhieu
            // 
            this.lblChiTietPhieu.AutoSize = true;
            this.lblChiTietPhieu.Location = new System.Drawing.Point(58, 50);
            this.lblChiTietPhieu.Name = "lblChiTietPhieu";
            this.lblChiTietPhieu.Size = new System.Drawing.Size(152, 17);
            this.lblChiTietPhieu.TabIndex = 1;
            this.lblChiTietPhieu.Text = "Thông tin chi tiết phiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sinh viên người mượn";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(445, 126);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(100, 22);
            this.txtTongTien.TabIndex = 4;
            this.txtTongTien.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tổng tiền";
            // 
            // lblsl
            // 
            this.lblsl.AutoSize = true;
            this.lblsl.Location = new System.Drawing.Point(58, 176);
            this.lblsl.Name = "lblsl";
            this.lblsl.Size = new System.Drawing.Size(64, 17);
            this.lblsl.TabIndex = 6;
            this.lblsl.Text = "Số lượng";
            // 
            // txtNguoiMuon
            // 
            this.txtNguoiMuon.Location = new System.Drawing.Point(58, 126);
            this.txtNguoiMuon.Name = "txtNguoiMuon";
            this.txtNguoiMuon.Size = new System.Drawing.Size(100, 22);
            this.txtNguoiMuon.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã - Tên sách";
            // 
            // cbbSach
            // 
            this.cbbSach.FormattingEnabled = true;
            this.cbbSach.Location = new System.Drawing.Point(261, 207);
            this.cbbSach.Name = "cbbSach";
            this.cbbSach.Size = new System.Drawing.Size(121, 24);
            this.cbbSach.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(445, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(618, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvCTPHieu
            // 
            this.dgvCTPHieu.AllowUserToAddRows = false;
            this.dgvCTPHieu.AllowUserToDeleteRows = false;
            this.dgvCTPHieu.AllowUserToResizeColumns = false;
            this.dgvCTPHieu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvCTPHieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTPHieu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTPHieu.ColumnHeadersHeight = 29;
            this.dgvCTPHieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.GiaMuon});
            this.dgvCTPHieu.Location = new System.Drawing.Point(61, 279);
            this.dgvCTPHieu.Name = "dgvCTPHieu";
            this.dgvCTPHieu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvCTPHieu.RowHeadersVisible = false;
            this.dgvCTPHieu.RowHeadersWidth = 51;
            this.dgvCTPHieu.RowTemplate.Height = 24;
            this.dgvCTPHieu.Size = new System.Drawing.Size(848, 199);
            this.dgvCTPHieu.TabIndex = 10;
            this.dgvCTPHieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPHieu_CellClick);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 125;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 125;
            // 
            // GiaMuon
            // 
            this.GiaMuon.DataPropertyName = "GiaMuon";
            this.GiaMuon.HeaderText = "Giá Mượn";
            this.GiaMuon.MinimumWidth = 6;
            this.GiaMuon.Name = "GiaMuon";
            this.GiaMuon.Width = 125;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(142, 527);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "in";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(354, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(573, 527);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(61, 210);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(120, 22);
            this.nudSoLuong.TabIndex = 11;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fAddPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 629);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.dgvCTPHieu);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbbSach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblsl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtNguoiMuon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblChiTietPhieu);
            this.Controls.Add(this.label1);
            this.Name = "fAddPhieuMuon";
            this.Text = "fAddPhieuMuon";
            this.Load += new System.EventHandler(this.fAddPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPHieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChiTietPhieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsl;
        private System.Windows.Forms.TextBox txtNguoiMuon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbSach;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCTPHieu;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaMuon;
    }
}
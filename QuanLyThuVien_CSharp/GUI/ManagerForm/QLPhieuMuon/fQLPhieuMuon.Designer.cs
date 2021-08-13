
namespace QuanLyThuVien_CSharp.GUI.ManagerForm.QLPhieuMuon
{
    partial class fQLPhieuMuon
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.SoPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.cbbSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 117);
            this.panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(798, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // cbbSearch
            // 
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Location = new System.Drawing.Point(603, 37);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(121, 24);
            this.cbbSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(918, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(51, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.AllowUserToAddRows = false;
            this.dgvPhieuMuon.AllowUserToDeleteRows = false;
            this.dgvPhieuMuon.AllowUserToResizeColumns = false;
            this.dgvPhieuMuon.AllowUserToResizeRows = false;
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuMuon,
            this.TenDangNhap,
            this.MaSinhVien});
            this.dgvPhieuMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(0, 117);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.RowHeadersVisible = false;
            this.dgvPhieuMuon.RowHeadersWidth = 51;
            this.dgvPhieuMuon.RowTemplate.Height = 24;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(1063, 485);
            this.dgvPhieuMuon.TabIndex = 1;
            this.dgvPhieuMuon.DoubleClick += new System.EventHandler(this.dgvPheuMuon_DoubleClick);
            // 
            // SoPhieuMuon
            // 
            this.SoPhieuMuon.DataPropertyName = "SoPhieuMuon";
            this.SoPhieuMuon.HeaderText = "Số phiếu mượn";
            this.SoPhieuMuon.MinimumWidth = 6;
            this.SoPhieuMuon.Name = "SoPhieuMuon";
            this.SoPhieuMuon.Width = 125;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tài khoản lập phiếu";
            this.TenDangNhap.MinimumWidth = 6;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Width = 125;
            // 
            // MaSinhVien
            // 
            this.MaSinhVien.DataPropertyName = "MaSinhVien";
            this.MaSinhVien.HeaderText = "Mã sinh viên mượn";
            this.MaSinhVien.MinimumWidth = 6;
            this.MaSinhVien.Name = "MaSinhVien";
            this.MaSinhVien.Width = 125;
            // 
            // fQLPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 602);
            this.Controls.Add(this.dgvPhieuMuon);
            this.Controls.Add(this.panel1);
            this.Name = "fQLPhieuMuon";
            this.Text = "fQLPhieuMuon";
            this.Load += new System.EventHandler(this.fQLPhieuMuon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSinhVien;
    }
}
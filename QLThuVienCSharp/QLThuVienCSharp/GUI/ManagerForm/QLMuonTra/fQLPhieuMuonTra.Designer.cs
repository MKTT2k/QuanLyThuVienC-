
namespace QLThuVienCSharp.GUI.ManagerForm.QLMuonTra
{
    partial class fQLPhieuMuonTra
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_search = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.SoPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cbb_search);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 69);
            this.panel1.TabIndex = 4;
            // 
            // cbb_search
            // 
            this.cbb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_search.FormattingEnabled = true;
            this.cbb_search.Items.AddRange(new object[] {
            "Số phiếu mượn",
            "Tài khoản lập",
            "Mã sinh viên"});
            this.cbb_search.Location = new System.Drawing.Point(489, 23);
            this.cbb_search.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_search.Name = "cbb_search";
            this.cbb_search.Size = new System.Drawing.Size(129, 24);
            this.cbb_search.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(642, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.Size = new System.Drawing.Size(305, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.AllowUserToAddRows = false;
            this.dgvPhieu.AllowUserToDeleteRows = false;
            this.dgvPhieu.AllowUserToResizeColumns = false;
            this.dgvPhieu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvPhieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvPhieu.ColumnHeadersHeight = 40;
            this.dgvPhieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuMuon,
            this.TenDangNhap,
            this.MaSinhVien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieu.GridColor = System.Drawing.Color.White;
            this.dgvPhieu.Location = new System.Drawing.Point(0, 0);
            this.dgvPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhieu.MultiSelect = false;
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhieu.RowHeadersVisible = false;
            this.dgvPhieu.RowHeadersWidth = 40;
            this.dgvPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieu.Size = new System.Drawing.Size(1085, 618);
            this.dgvPhieu.TabIndex = 5;
            // 
            // SoPhieuMuon
            // 
            this.SoPhieuMuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoPhieuMuon.DataPropertyName = "SoPhieuMuon";
            this.SoPhieuMuon.HeaderText = "Số phiếu mượn";
            this.SoPhieuMuon.MinimumWidth = 6;
            this.SoPhieuMuon.Name = "SoPhieuMuon";
            this.SoPhieuMuon.ReadOnly = true;
            this.SoPhieuMuon.Width = 150;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tài khoản lập phiếu";
            this.TenDangNhap.MinimumWidth = 6;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.ReadOnly = true;
            // 
            // MaSinhVien
            // 
            this.MaSinhVien.DataPropertyName = "MaSinhVien";
            this.MaSinhVien.HeaderText = "Mã sinh viên mượn";
            this.MaSinhVien.MinimumWidth = 6;
            this.MaSinhVien.Name = "MaSinhVien";
            this.MaSinhVien.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(42, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 43);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm phiếu";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // fQLPhieuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPhieu);
            this.Name = "fQLPhieuMuonTra";
            this.Text = "fQLPhieuMuonTra";
            this.Load += new System.EventHandler(this.fQLPhieuMuonTra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbb_search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSinhVien;
        private System.Windows.Forms.Button btnAdd;
    }
}
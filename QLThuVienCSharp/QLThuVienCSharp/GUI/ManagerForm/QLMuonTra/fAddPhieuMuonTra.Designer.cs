
namespace QLThuVienCSharp.GUI.ManagerForm.QLMuonTra
{
    partial class fAddPhieuMuonTra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_chiTietPhieu = new System.Windows.Forms.Label();
            this.txt_nguoimuon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sl = new System.Windows.Forms.NumericUpDown();
            this.GiaMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSachMuon = new System.Windows.Forms.DataGridView();
            this.cbb_sach = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Lập phiếu mượn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_chiTietPhieu
            // 
            this.lbl_chiTietPhieu.AutoSize = true;
            this.lbl_chiTietPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chiTietPhieu.Location = new System.Drawing.Point(25, 63);
            this.lbl_chiTietPhieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_chiTietPhieu.Name = "lbl_chiTietPhieu";
            this.lbl_chiTietPhieu.Size = new System.Drawing.Size(224, 20);
            this.lbl_chiTietPhieu.TabIndex = 30;
            this.lbl_chiTietPhieu.Text = "Thông tin chi tiết phiếu mượn";
            this.lbl_chiTietPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nguoimuon
            // 
            this.txt_nguoimuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nguoimuon.Location = new System.Drawing.Point(29, 133);
            this.txt_nguoimuon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nguoimuon.Name = "txt_nguoimuon";
            this.txt_nguoimuon.Size = new System.Drawing.Size(441, 30);
            this.txt_nguoimuon.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mã sinh viên người mượn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Số lượng";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_sl
            // 
            this.txt_sl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sl.Location = new System.Drawing.Point(29, 215);
            this.txt_sl.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(77, 30);
            this.txt_sl.TabIndex = 34;
            this.txt_sl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GiaMuon
            // 
            this.GiaMuon.DataPropertyName = "GiaMuon";
            this.GiaMuon.HeaderText = "Giá mượn (VNĐ)";
            this.GiaMuon.MinimumWidth = 6;
            this.GiaMuon.Name = "GiaMuon";
            this.GiaMuon.ReadOnly = true;
            // 
            // TenS
            // 
            this.TenS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenS.DataPropertyName = "TenS";
            this.TenS.HeaderText = "Tên sách";
            this.TenS.MinimumWidth = 6;
            this.TenS.Name = "TenS";
            this.TenS.ReadOnly = true;
            this.TenS.Width = 325;
            // 
            // MaS
            // 
            this.MaS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaS.DataPropertyName = "MaS";
            this.MaS.HeaderText = "Mã sách";
            this.MaS.MinimumWidth = 6;
            this.MaS.Name = "MaS";
            this.MaS.ReadOnly = true;
            this.MaS.Width = 75;
            // 
            // dgvSachMuon
            // 
            this.dgvSachMuon.AllowUserToAddRows = false;
            this.dgvSachMuon.AllowUserToDeleteRows = false;
            this.dgvSachMuon.AllowUserToResizeColumns = false;
            this.dgvSachMuon.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvSachMuon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSachMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSachMuon.BackgroundColor = System.Drawing.Color.White;
            this.dgvSachMuon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSachMuon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvSachMuon.ColumnHeadersHeight = 40;
            this.dgvSachMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaS,
            this.TenS,
            this.GiaMuon});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSachMuon.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSachMuon.GridColor = System.Drawing.Color.White;
            this.dgvSachMuon.Location = new System.Drawing.Point(29, 267);
            this.dgvSachMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSachMuon.MultiSelect = false;
            this.dgvSachMuon.Name = "dgvSachMuon";
            this.dgvSachMuon.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSachMuon.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSachMuon.RowHeadersVisible = false;
            this.dgvSachMuon.RowHeadersWidth = 40;
            this.dgvSachMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachMuon.Size = new System.Drawing.Size(780, 294);
            this.dgvSachMuon.TabIndex = 35;
            // 
            // cbb_sach
            // 
            this.cbb_sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_sach.FormattingEnabled = true;
            this.cbb_sach.Location = new System.Drawing.Point(137, 213);
            this.cbb_sach.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_sach.Name = "cbb_sach";
            this.cbb_sach.Size = new System.Drawing.Size(333, 33);
            this.cbb_sach.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Mã - Tên sách";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.Location = new System.Drawing.Point(523, 133);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.ReadOnly = true;
            this.txt_tongtien.Size = new System.Drawing.Size(284, 30);
            this.txt_tongtien.TabIndex = 38;
            this.txt_tongtien.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Tổng tiền (VNĐ)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 590);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(553, 590);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 34);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(163, 590);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(111, 34);
            this.btnPrint.TabIndex = 40;
            this.btnPrint.Text = "In phiếu";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(359, 590);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 34);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // fAddPhieuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 645);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbb_sach);
            this.Controls.Add(this.dgvSachMuon);
            this.Controls.Add(this.txt_sl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nguoimuon);
            this.Controls.Add(this.lbl_chiTietPhieu);
            this.Controls.Add(this.label1);
            this.Name = "fAddPhieuMuonTra";
            this.Text = "fAddPhieuMuon";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.fAddPhieuMuonTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_sl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_chiTietPhieu;
        private System.Windows.Forms.TextBox txt_nguoimuon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txt_sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaS;
        private System.Windows.Forms.DataGridView dgvSachMuon;
        private System.Windows.Forms.ComboBox cbb_sach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
    }
}
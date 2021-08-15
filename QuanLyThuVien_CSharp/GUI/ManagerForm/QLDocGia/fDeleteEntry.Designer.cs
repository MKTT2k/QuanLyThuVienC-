
namespace QuanLyThuVien_CSharp.GUI.ManagerForm.QLDocGia
{
    partial class fDeleteEntry
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
            this.cbbChooseDate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteAndSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbChooseDate
            // 
            this.cbbChooseDate.FormattingEnabled = true;
            this.cbbChooseDate.Items.AddRange(new object[] {
            "3 hôm ",
            "7 hôm",
            "30 hôm",
            "tất cả trừ hôm nay"});
            this.cbbChooseDate.Location = new System.Drawing.Point(248, 22);
            this.cbbChooseDate.Name = "cbbChooseDate";
            this.cbbChooseDate.Size = new System.Drawing.Size(201, 24);
            this.cbbChooseDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnDeleteAndSave
            // 
            this.btnDeleteAndSave.Location = new System.Drawing.Point(135, 108);
            this.btnDeleteAndSave.Name = "btnDeleteAndSave";
            this.btnDeleteAndSave.Size = new System.Drawing.Size(104, 30);
            this.btnDeleteAndSave.TabIndex = 2;
            this.btnDeleteAndSave.Text = "button1";
            this.btnDeleteAndSave.UseVisualStyleBackColor = true;
            this.btnDeleteAndSave.Click += new System.EventHandler(this.btnDeleteAndSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(291, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "button1";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // fDeleteEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 180);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteAndSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbChooseDate);
            this.Name = "fDeleteEntry";
            this.Text = "fDeleteEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbChooseDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteAndSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
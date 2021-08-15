using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyThuVien_CSharp.GUI.ManagerForm.QLPhieuMuon
{
    public partial class fBillView : Form
    {
        DataSet ds;
        String MaSinhVien;
        String SoPhieuMuon;
        String TongTien;
        String NgayLapPhieu;
        String NguoiLapPhieu;
        public fBillView(DataSet ds, String MaSinhVien, String SoPhieuMuon, String TongTien,
           String NgayLapPhieu, String NguoiLapPhieu)
        {
            this.ds = ds;
            this.MaSinhVien = MaSinhVien;
            this.SoPhieuMuon = SoPhieuMuon;
            this.TongTien = TongTien;
            this.NgayLapPhieu = NgayLapPhieu;
            this.NguoiLapPhieu = NguoiLapPhieu;
            InitializeComponent();
        }

        private void fBillView_Load(object sender, EventArgs e)
        {
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien_CSharp.GUI.ManagerForm.QLPhieuMuon.PhieuMuon.rdlc";

            //ReportParameter rpmMaSinhVien = new ReportParameter("MaSinhVien");
            //rpmMaSinhVien.Values.Add(MaSinhVien);
            //this.reportViewer1.LocalReport.SetParameters(rpmMaSinhVien);

            //ReportParameter rpmSoPhieuMuon = new ReportParameter("SoPhieuMuon");
            //rpmSoPhieuMuon.Values.Add(SoPhieuMuon);
            //this.reportViewer1.LocalReport.SetParameters(rpmSoPhieuMuon);

            //ReportParameter rpmTongTien = new ReportParameter("TongTien");
            //rpmTongTien.Values.Add(TongTien);
            //this.reportViewer1.LocalReport.SetParameters(rpmTongTien);

            //ReportParameter rpmNgayLapPhieu = new ReportParameter("NgayLapPhieu");
            //rpmNgayLapPhieu.Values.Add(NgayLapPhieu);
            //this.reportViewer1.LocalReport.SetParameters(rpmNgayLapPhieu);

            //ReportParameter rpmNguoiLapPhieu = new ReportParameter("NguoiLapPhieu");
            //rpmNguoiLapPhieu.Values.Add(NguoiLapPhieu);
            //this.reportViewer1.LocalReport.SetParameters(rpmNguoiLapPhieu);
            if(ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsSach";
                rds.Value = ds.Tables[0];

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
            }
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }
    }
}

using Microsoft.Reporting.WinForms;
using Nhom2_QuanLiHopDongQuangCao_VietBai.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom2_QuanLiHopDongQuangCao_VietBai.Forms
{
    public partial class frmReportSoLanNGB_NQC : Form
    {
        ProcessDatabase database = new ProcessDatabase();
        public frmReportSoLanNGB_NQC()
        {
            InitializeComponent();
        }

        private void frmReportSoLanNGB_NQC_Load(object sender, EventArgs e)
        {
            rpvSoLanNGB_NQC.LocalReport.DataSources.Clear();
            try
            {
                rpvSoLanNGB_NQC.LocalReport.ReportEmbeddedResource = "Nhom2_QuanLiHopDongQuangCao_VietBai.Reports.reportSoLanNGB_NQC.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "reportSoLanNGB_NQC";
                string sql = $"select * from reportSoLanNGB_NQC()";
                reportDataSource.Value = database.docBang(sql);
                rpvSoLanNGB_NQC.LocalReport.DataSources.Add(reportDataSource);
                this.rpvSoLanNGB_NQC.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

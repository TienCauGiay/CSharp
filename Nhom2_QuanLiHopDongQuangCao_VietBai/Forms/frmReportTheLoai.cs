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
    public partial class frmReportTheLoai : Form
    {

        ProcessDatabase database = new ProcessDatabase();
        public frmReportTheLoai()
        {
            InitializeComponent();
        }

        private void frmReportTheLoai_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn đóng chức năng báo cáo thể loại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (txtTenBao.Text == "")
            {
                MessageBox.Show("Không được để trống tên báo", "Thông báo", MessageBoxButtons.OK);
                txtTenBao.Focus();
                return;
            }
            else
            {
                rpvTheLoai.LocalReport.DataSources.Clear();
                try
                {
                    rpvTheLoai.LocalReport.ReportEmbeddedResource = "Nhom2_QuanLiHopDongQuangCao_VietBai.Reports.reportTheLoai.rdlc";
                    ReportDataSource reportDataSource = new ReportDataSource();
                    reportDataSource.Name = "reportTheLoai";
                    string sql = $"select * from reportTheLoai(N'{txtTenBao.Text}')";
                    reportDataSource.Value = database.docBang(sql);
                    rpvTheLoai.LocalReport.DataSources.Add(reportDataSource);
                    this.rpvTheLoai.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

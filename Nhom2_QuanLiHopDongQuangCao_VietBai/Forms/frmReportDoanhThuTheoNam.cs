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
    public partial class frmReportDoanhThuTheoNam : Form
    {

        ProcessDatabase database = new ProcessDatabase();

        KiemTraDieuKien kt = new KiemTraDieuKien(); 
        public frmReportDoanhThuTheoNam()
        {
            InitializeComponent();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if(txtNam.Text == "")
            {
                MessageBox.Show("Không được để trống năm", "Thông báo", MessageBoxButtons.OK);
                txtNam.Focus();
                return;
            }
            else
            {
                if(kt.isNumber(txtNam.Text) == false)
                {
                    MessageBox.Show("Năm phải là số nguyên", "Thông báo", MessageBoxButtons.OK);
                    txtNam.Text = "";
                    txtNam.Focus();
                    return;
                }
                else
                {
                    rpvDoanhThu.LocalReport.DataSources.Clear();
                    try
                    {
                        rpvDoanhThu.LocalReport.ReportEmbeddedResource = "Nhom2_QuanLiHopDongQuangCao_VietBai.Reports.reportDoanhThuTheoNam.rdlc";
                        ReportDataSource reportDataSource = new ReportDataSource();
                        reportDataSource.Name = "reportDoanhThuTheoNam";
                        string sql = $"select * from reportDoanhThuTheoNam({txtNam.Text})";
                        reportDataSource.Value = database.docBang(sql);
                        rpvDoanhThu.LocalReport.DataSources.Add(reportDataSource);
                        this.rpvDoanhThu.RefreshReport();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}

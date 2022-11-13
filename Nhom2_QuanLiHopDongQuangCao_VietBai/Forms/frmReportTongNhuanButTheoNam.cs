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
    public partial class frmReportTongNhuanButTheoNam : Form
    {

        ProcessDatabase database = new ProcessDatabase();

        KiemTraDieuKien kt = new KiemTraDieuKien();
        public frmReportTongNhuanButTheoNam()
        {
            InitializeComponent();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if(txtNam.Text == "")
            {
                MessageBox.Show("Không được bỏ trống năm", "Thông báo", MessageBoxButtons.OK);
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
                    rpvTongNhuanBut.LocalReport.DataSources.Clear();
                    try
                    {
                        rpvTongNhuanBut.LocalReport.ReportEmbeddedResource = "Nhom2_QuanLiHopDongQuangCao_VietBai.Reports.reportTongNhuanButTheoNam.rdlc";
                        ReportDataSource reportDataSource = new ReportDataSource();
                        reportDataSource.Name = "reportTongNhuanButTheoNam";
                        string sql = $"select * from reportTongNhuanButTheoNam({txtNam.Text})";
                        reportDataSource.Value = database.docBang(sql);
                        rpvTongNhuanBut.LocalReport.DataSources.Add(reportDataSource);
                        this.rpvTongNhuanBut.RefreshReport();
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

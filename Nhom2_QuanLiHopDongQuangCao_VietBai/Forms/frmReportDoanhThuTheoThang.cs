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
    public partial class frmReportDoanhThuTheoThang : Form
    {

        ProcessDatabase database = new ProcessDatabase();

        KiemTraDieuKien kt = new KiemTraDieuKien();
        public frmReportDoanhThuTheoThang()
        {
            InitializeComponent();
        }

        private void frmReportDoanhThu_Load(object sender, EventArgs e)
        {
            
        }

        private bool checkDK()
        {
            if (txtThang.Text == "")
            {
                MessageBox.Show("Không được để trống tháng", "Thông báo", MessageBoxButtons.OK);
                txtThang.Focus();
                return false;
            }
            if (txtNam.Text == "")
            {
                MessageBox.Show("Không được để trống năm", "Thông báo", MessageBoxButtons.OK);
                txtNam.Focus();
                return false;
            }
            if (kt.isNumber(txtThang.Text) == false)
            {
                MessageBox.Show("Tháng phải là số nguyên", "Thông báo", MessageBoxButtons.OK);
                txtThang.Text = "";
                txtThang.Focus();
                return false;
            }
            else
            {
                int t = int.Parse(txtThang.Text);
                if(t < 1 || t > 12)
                {
                    MessageBox.Show("Tháng phải nằm trong đoạn từ 1 đến 12", "Thông báo", MessageBoxButtons.OK);
                    txtThang.Text = "";
                    txtThang.Focus();
                    return false;
                }
            }
            if (kt.isNumber(txtNam.Text) == false)
            {
                MessageBox.Show("Năm phải là số nguyên", "Thông báo", MessageBoxButtons.OK);
                txtNam.Text = "";
                txtNam.Focus();
                return false;
            }
            return true;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (checkDK() == false)
            {
                return;
            }
            else
            {
                rpvDoanhThu.LocalReport.DataSources.Clear();
                try
                {
                    rpvDoanhThu.LocalReport.ReportEmbeddedResource = "Nhom2_QuanLiHopDongQuangCao_VietBai.Reports.reportDoanhThuTheoThang.rdlc";
                    ReportDataSource reportDataSource = new ReportDataSource();
                    reportDataSource.Name = "reportDoanhThuTheoThang";
                    string sql = $"select * from reportDoanhThuTheoThang({txtThang.Text},{txtNam.Text})";
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

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
    public partial class frmReportTongNhuanButTheoQuy : Form
    {

        ProcessDatabase database = new ProcessDatabase();

        KiemTraDieuKien kt = new KiemTraDieuKien();
        public frmReportTongNhuanButTheoQuy()
        {
            InitializeComponent();
        }

        private bool checkDK()
        {
            if (txtQuy.Text == "")
            {
                MessageBox.Show("Không được để trống quý", "Thông báo", MessageBoxButtons.OK);
                txtQuy.Focus();
                return false;
            }
            if (txtNam.Text == "")
            {
                MessageBox.Show("Không được để trống năm", "Thông báo", MessageBoxButtons.OK);
                txtNam.Focus();
                return false;
            }
            if (kt.isNumber(txtQuy.Text) == false)
            {
                MessageBox.Show("Quý phải là số nguyên", "Thông báo", MessageBoxButtons.OK);
                txtQuy.Text = "";
                txtQuy.Focus();
                return false;
            }
            else
            {
                int q = int.Parse(txtQuy.Text);
                if(q < 1 || q > 4)
                {
                    MessageBox.Show("Quý phải nằm trong đoạn 1 đến 4", "Thông báo", MessageBoxButtons.OK);
                    txtQuy.Text = "";
                    txtQuy.Focus();
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
                rpvTongNhuanBut.LocalReport.DataSources.Clear();
                try
                {
                    rpvTongNhuanBut.LocalReport.ReportEmbeddedResource = "Nhom2_QuanLiHopDongQuangCao_VietBai.Reports.reportTongNhuanButTheoQuy.rdlc";
                    ReportDataSource reportDataSource = new ReportDataSource();
                    reportDataSource.Name = "reportTongNhuanButTheoQuy";
                    string sql = $"select * from reportTongNhuanButTheoQuy({txtQuy.Text},{txtNam.Text})";
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

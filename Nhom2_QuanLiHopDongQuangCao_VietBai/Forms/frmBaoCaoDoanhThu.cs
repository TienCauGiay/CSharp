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
    public partial class frmBaoCaoDoanhThu : Form
    {
        ProcessDatabase database = new ProcessDatabase();

        KiemTraDieuKien ktDieuKien = new KiemTraDieuKien();
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            frmReportDoanhThuTheoThang f = new frmReportDoanhThuTheoThang();
            f.Show();
        }

        private void btnQuy_Click(object sender, EventArgs e)
        {
            frmReportDoanhThuTheoQuy f = new frmReportDoanhThuTheoQuy();
            f.Show();
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            frmReportDoanhThuTheoNam f = new frmReportDoanhThuTheoNam();
            f.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn đóng chức năng báo cáo doanh thu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void frmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            string sql = $"select * from Khach_QuangCao";
            dgvBaoCao.DataSource = database.docBang(sql);
            dgvBaoCao.Columns[8].Width = 250;
            dgvBaoCao.Columns[0].HeaderText = "Mã lần quảng cáo";
            dgvBaoCao.Columns[1].HeaderText = "Mã khách hàng";
            dgvBaoCao.Columns[2].HeaderText = "Mã nhân viên";
            dgvBaoCao.Columns[3].HeaderText = "Mã báo";
            dgvBaoCao.Columns[4].HeaderText = "Mã quảng cáo";
            dgvBaoCao.Columns[5].HeaderText = "Nội dung";
            dgvBaoCao.Columns[6].HeaderText = "Ngày bắt đầu";
            dgvBaoCao.Columns[7].HeaderText = "Ngày kết thúc";
            dgvBaoCao.Columns[8].HeaderText = "Tổng tiền";
        }
    }
}

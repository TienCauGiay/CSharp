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
    public partial class frmBaoCaoTongNhuanBut : Form
    {
        ProcessDatabase database = new ProcessDatabase();

        KiemTraDieuKien ktDieuKien = new KiemTraDieuKien();
        public frmBaoCaoTongNhuanBut()
        {
            InitializeComponent();
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            frmReportTongNhuanButTheoThang f = new frmReportTongNhuanButTheoThang();
            f.Show();
        }

        private void btnQuy_Click(object sender, EventArgs e)
        {
            frmReportTongNhuanButTheoQuy f = new frmReportTongNhuanButTheoQuy();
            f.Show();
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            frmReportTongNhuanButTheoNam f = new frmReportTongNhuanButTheoNam();
            f.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn đóng chức năng báo cáo tổng nhuận bút không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void frmBaoCaoTongNhuanBut_Load(object sender, EventArgs e)
        {
            string sql = $"select * from KhachGuiBai";
            dgvBCTNB.DataSource = database.docBang(sql);
            dgvBCTNB.Columns[1].Width = 150;
            dgvBCTNB.Columns[4].Width = 150;
            dgvBCTNB.Columns[8].Width = 250;
            dgvBCTNB.Columns[0].HeaderText = "Mã lần gửi";
            dgvBCTNB.Columns[1].HeaderText = "Mã khách hàng";
            dgvBCTNB.Columns[2].HeaderText = "Mã thể loại";
            dgvBCTNB.Columns[3].HeaderText = "Mã báo";
            dgvBCTNB.Columns[4].HeaderText = "Mã nhân viên";
            dgvBCTNB.Columns[5].HeaderText = "Tiêu đề";
            dgvBCTNB.Columns[6].HeaderText = "Nội dung";
            dgvBCTNB.Columns[7].HeaderText = "Ngày đăng";
            dgvBCTNB.Columns[8].HeaderText = "Nhuận bút";
        }
    }
}

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
    public partial class frmTinhTongTien : Form
    {

        ProcessDatabase database = new ProcessDatabase();   
        public frmTinhTongTien()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string sql = "";
            sql = "update Khach_QuangCao\r\nset TongTien = (select DATEDIFF(day,NgayBD,NgayKT)) * DonGia \r\nfrom BangGia where Khach_QuangCao.MaB = BangGia.MaB and Khach_QuangCao.MaQC = BangGia.MaQC";
            database.CapNhatDuLieu(sql);
            DataTable dt = database.docBang("select * from Khach_QuangCao");
            dgvTinhTT.DataSource = dt;
            dgvTinhTT.Columns[8].Width = 250;
            dgvTinhTT.Columns[0].HeaderText = "Mã lần quảng cáo";
            dgvTinhTT.Columns[1].HeaderText = "Mã khách hàng";
            dgvTinhTT.Columns[2].HeaderText = "Mã nhân viên";
            dgvTinhTT.Columns[3].HeaderText = "Mã báo";
            dgvTinhTT.Columns[4].HeaderText = "Mã quảng cáo";
            dgvTinhTT.Columns[5].HeaderText = "Nội dung";
            dgvTinhTT.Columns[6].HeaderText = "Ngày bắt đầu";
            dgvTinhTT.Columns[7].HeaderText = "Ngày kết thúc";
            dgvTinhTT.Columns[8].HeaderText = "Tổng tiền";
            dt.Dispose();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (txtMaB.Text == "" && txtMaQC.Text == "")
            {
                sql = "select * from Khach_QuangCao";
            }
            if (txtMaB.Text == "" && txtMaQC.Text != "")
            {
                sql = "select * from Khach_QuangCao where MaQC = '" + txtMaQC.Text + "'";
            }
            if (txtMaB.Text != "" && txtMaQC.Text == "")
            {
                sql = "select * from Khach_QuangCao where MaB = '" + txtMaB.Text + "'";
            }
            if (txtMaB.Text != "" && txtMaQC.Text != "")
            {
                sql = "select * from Khach_QuangCao where MaB = '" + txtMaB.Text + "' and MaQC = '" + txtMaQC.Text + "'";
            }
            DataTable dt = database.docBang(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tìm thấy", "Thông báo", MessageBoxButtons.OK);
                dgvTinhTT.DataSource = dt;
                dgvTinhTT.Columns[8].Width = 200;
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK);
                dgvTinhTT.DataSource = dt;
            }
            dt.Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát khỏi chức năng tính tổng tiền không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }
    }
}

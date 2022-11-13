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
    public partial class frmTinhNhuanBut : Form
    {

        ProcessDatabase database = new ProcessDatabase();
        public frmTinhNhuanBut()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string sql = "";
            sql = "update KhachGuiBai\r\nset NhuanBut = Bao_TheLoai.NhuanBut\r\nfrom Bao_TheLoai where Bao_TheLoai.MaB = KhachGuiBai.MaB and Bao_TheLoai.MaTL = KhachGuiBai.MaTL";
            database.CapNhatDuLieu(sql);
            DataTable dt = database.docBang("select * from KhachGuiBai");
            dgvTinhNB.DataSource = dt;
            dgvTinhNB.Columns[8].Width = 200;
            dgvTinhNB.Columns[0].HeaderText = "Mã lần gửi";
            dgvTinhNB.Columns[1].HeaderText = "Mã khách hàng";
            dgvTinhNB.Columns[2].HeaderText = "Mã thể loại";
            dgvTinhNB.Columns[3].HeaderText = "Mã báo";
            dgvTinhNB.Columns[4].HeaderText = "Mã nhân viên";
            dgvTinhNB.Columns[5].HeaderText = "Tiêu đề";
            dgvTinhNB.Columns[6].HeaderText = "Nội dung";
            dgvTinhNB.Columns[7].HeaderText = "Ngày đăng";
            dgvTinhNB.Columns[8].HeaderText = "Nhuận bút";
            dt.Dispose();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (txtMaB.Text == "" && txtMaTL.Text == "")
            {
                sql = "select * from KhachGuiBai";
            }
            if (txtMaB.Text == "" && txtMaTL.Text != "")
            {
                sql = "select * from KhachGuiBai where MaTL = '" + txtMaTL.Text + "'";
            }
            if (txtMaB.Text != "" && txtMaTL.Text == "")
            {
                sql = "select * from KhachGuiBai where MaB = '" + txtMaB.Text + "'";
            }
            if (txtMaB.Text != "" && txtMaTL.Text != "")
            {
                sql = "select * from KhachGuiBai where MaB = '" + txtMaB.Text + "' and MaTL = '" + txtMaTL.Text + "'";
            }
            DataTable dt = database.docBang(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tìm thấy", "Thông báo", MessageBoxButtons.OK);
                dgvTinhNB.DataSource = dt;
                dgvTinhNB.Columns[8].Width = 200;
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK);
                dgvTinhNB.DataSource = dt;
            }
            dt.Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát khỏi chức năng tính nhuận bút không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void frmTinhNhuanBut_Load(object sender, EventArgs e)
        {
            
        }
    }
}

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

namespace Nhom2_QuanLiHopDongQuangCao_VietBai.bin.Debug.Forms
{
    public partial class frmTimKiemNhanVien : Form
    {
        ProcessDatabase database = new ProcessDatabase();
        
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
        }

        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            loadDuLieuNhanVien("select * from NhanVien");
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Mã báo";
            dgvNhanVien.Columns[3].HeaderText = "Mã phòng";
            dgvNhanVien.Columns[4].HeaderText = "Mã chức vụ";
            dgvNhanVien.Columns[5].HeaderText = "Mã trình độ";
            dgvNhanVien.Columns[6].HeaderText = "Mã chuyên môn";
            dgvNhanVien.Columns[7].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[8].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[9].HeaderText = "Giới tính";
            dgvNhanVien.Columns[10].HeaderText = "Điện thoại";
            dgvNhanVien.Columns[11].HeaderText = "Email";
        }

        private void loadDuLieuNhanVien(string sql)
        {
            DataTable dtNhanVien = database.docBang(sql);
            dgvNhanVien.DataSource = dtNhanVien;
            dgvNhanVien.Columns[1].Width = 150;
            dgvNhanVien.Columns[10].Width = 150;
            dgvNhanVien.Columns[11].Width = 250;
            dtNhanVien.Dispose();
            btnSua_NV.Enabled = false;
            btnXoa_NV.Enabled = false;
            HienChiTiet(false);
        }

        private void HienChiTiet(Boolean hien)
        {
            txtMaNV.Enabled = hien;
            txtTenNV.Enabled = hien;
            txtMaB.Enabled = hien;
            txtMaP.Enabled = hien;
            txtMaCV.Enabled = hien;
            txtMaTD.Enabled = hien;
            txtMaCM.Enabled = hien;
            txtDiaChi.Enabled = hien;
            dtpNgaySinh.Enabled = hien;
            txtGioiTinh.Enabled = hien;
            txtDienThoai.Enabled = hien;
            txtEmail.Enabled = hien;
            btnLuu_NV.Enabled = hien;
            btnHuy_NV.Enabled = hien;
        }

        private void XoaChiTiet()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtMaB.Text = "";
            txtMaP.Text = "";
            txtMaCV.Text = "";
            txtMaTD.Text = "";
            txtMaCM.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtGioiTinh.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
        }

        private void btnTimKiem_NV_Click(object sender, EventArgs e)
        {
            string sql = "select * from NhanVien";
            string dk = "";
            if (txtGioiTinhTK.Text.Trim() != "" && txtTenNVTK.Text.Trim() == "" && txtPhongBanTK.Text.Trim() == "" && txtTrinhDoTK.Text.Trim() == "")
            {
                dk += " GioiTinh like N'%" + txtGioiTinhTK.Text + "%'";
            }
            if (txtGioiTinhTK.Text.Trim() == "" && txtTenNVTK.Text.Trim() == "" && txtPhongBanTK.Text.Trim() == "" && txtTrinhDoTK.Text.Trim() != "")
            {
                dk += " MaTD in (select MaTD from TrinhDo where TenTD like N'%" + txtTrinhDoTK.Text + "%')";
            }
            if (txtGioiTinhTK.Text.Trim() == "" && txtTenNVTK.Text.Trim() == "" && txtPhongBanTK.Text.Trim() != "" && txtTrinhDoTK.Text.Trim() == "")
            {
                dk += " MaP in (select MaP from PhongBan where TenP like N'%" + txtPhongBanTK.Text + "%')";
            }
            if (txtTenNVTK.Text.Trim() != "")
            {
                dk += " TenNV like N'%" + txtTenNVTK.Text + "%'";
            }
            if (txtTrinhDoTK.Text.Trim() != "" && dk != "")
            {
                dk += " AND MaTD in (select MaTD from TrinhDo where TenTD like N'%" + txtTrinhDoTK.Text + "%')";
            }
            if (txtPhongBanTK.Text.Trim() != "" && dk != "")
            {
                dk += " AND MaP in (select MaP from PhongBan where TenP like N'%" + txtPhongBanTK.Text + "%')";
            }
            if (txtGioiTinhTK.Text.Trim() != "" && dk != "")
            {
                dk += "AND GioiTinh like N'%" + txtGioiTinhTK.Text + "%'";
            }
            if (dk != "")
            {
                sql += " WHERE" + dk;
            }
            DataTable dt = database.docBang(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tìm thấy", "Thông báo", MessageBoxButtons.OK);
                loadDuLieuNhanVien(sql);
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK);
                loadDuLieuNhanVien(sql);
            }
            btnHuy_NV.Enabled = true;
        }

        private void btnThem_NV_Click(object sender, EventArgs e)
        {
            XoaChiTiet();
            btnSua_NV.Enabled = false;
            btnXoa_NV.Enabled = false;
            HienChiTiet(true);
        }

        private void btnLuu_NV_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn không được để trống mã nhân viên!");
                return;
            }
            if (txtTenNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn không được để trống tên nhân viên!");
                return;
            }
            if (txtMaB.Text.Trim() == "")
            {
                MessageBox.Show("Bạn không được để trống mã báo!");
                return;
            }
            if (txtMaP.Text.Trim() == "")
            {
                MessageBox.Show("Bạn không được để trống mã phòng!");
                return;
            }
            if (txtMaCV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn không được để trống mã chức vụ!");
                return;
            }
            if (txtMaTD.Text.Trim() == "")
            {
                MessageBox.Show("Bạn không được để trống mã trình độ!");
                return;
            }
            if (txtMaCM.Text.Trim() == "")
            {
                MessageBox.Show("Bạn không được để trống mã chuyên môn!");
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn không để trống địa chỉ!");
                return;
            }
            if (dtpNgaySinh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return;
            }
            if (btnThem_NV.Enabled == true)
            {
                sql = "Select * from NhanVien where" + " MaNV = '" + txtMaNV.Text.Trim() + "'";
                DataTable dt = database.docBang(sql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã nhân viên " + txtMaNV.Text + " đã tồn tại, vui lòng nhập lại!");
                    return;
                }
                else
                {
                    sql = "insert into NhanVien values (N'" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'"
                    + txtMaB.Text + "',N'" + txtMaP.Text + "',N'" + txtMaCV.Text + "',N'" + txtMaTD.Text + "',N'"
                    + txtMaCM.Text + "',N'" + txtDiaChi.Text + "','" + dtpNgaySinh.Value.Date + "',N'"
                    + txtGioiTinh.Text + "',N'" + txtDienThoai.Text + "',N'" + txtEmail.Text + "')";
                }
            }
            if (btnSua_NV.Enabled == true)
            {
                sql = "update NhanVien set TenNV = N'" + txtTenNV.Text + "',MaB = N'" + txtMaB.Text +
                    "',MaP = N'" + txtMaP.Text + "',MaCV = N'" + txtMaCV.Text + "',MaTD = N'" + txtMaTD.Text +
                    "',MaCM = N'" + txtMaCM.Text + "',DiaChi = N'" + txtDiaChi.Text + "',NgaySinh = N'" + dtpNgaySinh.Value.Date +
                    "',GioiTinh = N'" + txtGioiTinh.Text + "',DienThoai = N'" + txtDienThoai.Text +
                    "',Email = N'" + txtEmail.Text + "' where MaNV = '" + txtMaNV.Text + "'";
            }
            database.CapNhatDuLieu(sql);
            loadDuLieuNhanVien("select * from NhanVien");
            HienChiTiet(false);
            XoaChiTiet();
            btnSua_NV.Enabled = false;
            btnThem_NV.Enabled = true;
            btnXoa_NV.Enabled = false;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSua_NV.Enabled = true;
                btnXoa_NV.Enabled = true;
                btnLuu_NV.Enabled = true;
                btnHuy_NV.Enabled = true;
                btnThem_NV.Enabled = false;
                txtMaNV.Text = dgvNhanVien[0, e.RowIndex].Value.ToString();
                txtTenNV.Text = dgvNhanVien[1, e.RowIndex].Value.ToString();
                txtMaB.Text = dgvNhanVien[2, e.RowIndex].Value.ToString();
                txtMaP.Text = dgvNhanVien[3, e.RowIndex].Value.ToString();
                txtMaCV.Text = dgvNhanVien[4, e.RowIndex].Value.ToString();
                txtMaTD.Text = dgvNhanVien[5, e.RowIndex].Value.ToString();
                txtMaCM.Text = dgvNhanVien[6, e.RowIndex].Value.ToString();
                txtDiaChi.Text = dgvNhanVien[7, e.RowIndex].Value.ToString();
                txtGioiTinh.Text = dgvNhanVien[9, e.RowIndex].Value.ToString();
                txtDienThoai.Text = dgvNhanVien[10, e.RowIndex].Value.ToString();
                txtEmail.Text = dgvNhanVien[11, e.RowIndex].Value.ToString();
                dtpNgaySinh.Value = (DateTime)dgvNhanVien[8, e.RowIndex].Value;
            }
            catch
            {
                dtpNgaySinh.Value = DateTime.Now;
            }
        }

        private void btnSua_NV_Click(object sender, EventArgs e)
        {
            btnThem_NV.Enabled = false;
            btnXoa_NV.Enabled = false;
            HienChiTiet(true);
        }

        private void btnXoa_NV_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa nhân viên có mã " + txtMaNV.Text + " khỏi danh sách khách hàng không? Hệ thống sẽ xóa cả dữ liệu ở bảng khách quảng cáo và khách gửi bài có mã nhân viên này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                database.CapNhatDuLieu("delete from Khach_QuangCao where MaNV = N'" + txtMaNV.Text + "'");
                database.CapNhatDuLieu("delete from KhachGuiBai where MaNV = N'" + txtMaNV.Text + "'");
                database.CapNhatDuLieu("delete from NhanVien where MaNV = N'" + txtMaNV.Text + "'");
                loadDuLieuNhanVien("select * from NhanVien");
                XoaChiTiet();
                HienChiTiet(false);
                btnXoa_NV.Enabled = false;
                btnThem_NV.Enabled = true;
            }
        }

        private void resetValues()
        {
            txtTenNVTK.Text = "";
            txtTrinhDoTK.Text = "";
            txtPhongBanTK.Text = "";
            txtGioiTinhTK.Text = "";
        }

        private void btnHuy_NV_Click(object sender, EventArgs e)
        {
            btnXoa_NV.Enabled = false;
            btnSua_NV.Enabled = false;
            btnThem_NV.Enabled = true;
            XoaChiTiet();
            HienChiTiet(false);
            resetValues();
            loadDuLieuNhanVien("select * from NhanVien");
        }

        private void btnThoat_NV_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn đóng chức năng tìm kiếm nhân viên không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                this.Close();
            }
        }
    }
}

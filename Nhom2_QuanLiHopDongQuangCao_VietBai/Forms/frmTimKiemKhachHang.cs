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
    public partial class frmTimKiemKhachHang : Form
    {
        ProcessDatabase database = new ProcessDatabase();

        KiemTraDieuKien ktdk = new KiemTraDieuKien();
        public frmTimKiemKhachHang()
        {
            InitializeComponent();
        }

        private void frmTimKiemKhachHang_Load(object sender, EventArgs e)
        {
            loadDuLieuKhachHang("select * from KhachHang");
            dgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns[2].HeaderText = "Mã lĩnh vực";
            dgvKhachHang.Columns[3].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[4].HeaderText = "Điện thoại";
            dgvKhachHang.Columns[5].HeaderText = "Email";
        }

        private void loadDuLieuKhachHang(string sql)
        {
            DataTable dtKhachHang = database.docBang(sql);
            dgvKhachHang.DataSource = dtKhachHang;
            dgvKhachHang.Columns[0].Width = 170;
            dgvKhachHang.Columns[1].Width = 200;
            dgvKhachHang.Columns[2].Width = 150;
            dgvKhachHang.Columns[3].Width = 200;
            dgvKhachHang.Columns[4].Width = 150;
            dgvKhachHang.Columns[5].Width = 250;
            dtKhachHang.Dispose();
            btnSua_KH.Enabled = false;
            btnXoa_KH.Enabled = false;
            HienChiTiet(false);
        }

        private void HienChiTiet(Boolean hien)
        {
            txtMaKH.Enabled = hien;
            txtTenKH.Enabled = hien;
            txtMaLVHD.Enabled = hien;
            txtDiaChi.Enabled = hien;
            txtDienThoai.Enabled = hien;
            txtEmail.Enabled = hien;
        }

        private void XoaChiTiet()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtMaLVHD.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
        }

        private void btnTimKiem_KH_Click(object sender, EventArgs e)
        {
            string sql = "select * from KhachHang";
            string dk = "";
            if (txtCacBaoGuiBai.Text.Trim() != "" && txtTenKH_TK.Text.Trim() == "" && txtCacBaoDangQC.Text.Trim() == "")
            {
                dk += " MaKH in (select MaKH from KhachGuiBai where MaB in (" + ktdk.dkCacBao(txtCacBaoGuiBai.Text.Trim()) + "))";
            }
            if (txtCacBaoGuiBai.Text.Trim() == "" && txtTenKH_TK.Text.Trim() == "" && txtCacBaoDangQC.Text.Trim() != "")
            {
                dk += " MaKH in (select MaKH from Khach_QuangCao where MaB in (" + ktdk.dkCacBao(txtCacBaoDangQC.Text.Trim()) + "))";
            }
            if (txtTenKH_TK.Text.Trim() != "")
            {
                dk += " TenKH like N'%" + txtTenKH_TK.Text + "%'";
            }
            if (txtCacBaoGuiBai.Text.Trim() != "" && dk != "")
            {
                dk += " and MaKH in (select MaKH from KhachGuiBai where MaB in (" + ktdk.dkCacBao(txtCacBaoGuiBai.Text.Trim()) + "))";
            }
            if (txtCacBaoDangQC.Text.Trim() != "" && dk != "")
            {
                dk += " and MaKH in (select MaKH from Khach_QuangCao where MaB in (" + ktdk.dkCacBao(txtCacBaoDangQC.Text.Trim()) + "))";
            }
            if (dk != "")
            {
                sql += " where" + dk;
            }
            DataTable dt = database.docBang(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tìm thấy", "Thông báo", MessageBoxButtons.OK);
                loadDuLieuKhachHang(sql);
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK);
                loadDuLieuKhachHang(sql);
            }
        }

        private void btnThem_KH_Click(object sender, EventArgs e)
        {
            XoaChiTiet();
            btnSua_KH.Enabled = false;
            btnXoa_KH.Enabled = false;
            HienChiTiet(true);
        }

        private void btnSua_KH_Click(object sender, EventArgs e)
        {
            btnThem_KH.Enabled = false;
            btnXoa_KH.Enabled = false;
            HienChiTiet(true);
        }

        private void btnXoa_KH_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa khách hàng có mã " + txtMaKH.Text + " khỏi danh sách khách hàng không? Hệ thống sẽ xóa cả dữ liệu ở bảng khách quảng cáo và khách gửi bài có mã khách hàng này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                database.CapNhatDuLieu("delete from Khach_QuangCao where MaKH = N'" + txtMaKH.Text + "'");
                database.CapNhatDuLieu("delete from KhachGuiBai where MaKH = N'" + txtMaKH.Text + "'");
                database.CapNhatDuLieu("delete from KhachHang where MaKH = N'" + txtMaKH.Text + "'");
                loadDuLieuKhachHang("select * from KhachHang");
                XoaChiTiet();
                HienChiTiet(false);
                btnXoa_KH.Enabled = false;
                btnThem_KH.Enabled = true;
            }
        }

        private void btnThoat_KH_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn đóng chức năng tìm kiếm khách hàng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                this.Close();
            }
        }

        private void btnHuy_KH_Click(object sender, EventArgs e)
        {
            btnXoa_KH.Enabled = false;
            btnSua_KH.Enabled = false;
            btnThem_KH.Enabled = true;
            XoaChiTiet();
            HienChiTiet(false);
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua_KH.Enabled = true;
            btnXoa_KH.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy_KH.Enabled = true;
            btnThem_KH.Enabled = false;
            try
            {
                txtMaKH.Text = dgvKhachHang[0, e.RowIndex].Value.ToString();
                txtTenKH.Text = dgvKhachHang[1, e.RowIndex].Value.ToString();
                txtMaLVHD.Text = dgvKhachHang[2, e.RowIndex].Value.ToString();
                txtDiaChi.Text = dgvKhachHang[3, e.RowIndex].Value.ToString();
                txtDienThoai.Text = dgvKhachHang[4, e.RowIndex].Value.ToString();
                txtEmail.Text = dgvKhachHang[5, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn không được để trống mã khách hàng!");
                return;
            }
            if (txtTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn không được để trống tên khách hàng!");
                return;
            }
            if (txtMaLVHD.Text.Trim() == "")
            {
                MessageBox.Show("Bạn không được để trống mã lĩnh vực hoạt động!");
                return;
            }
            if (btnThem_KH.Enabled == true)
            {
                sql = "Select * from KhachHang where" + " MaKH = '" + txtMaKH.Text.Trim() + "'";
                DataTable dt = database.docBang(sql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã khách hàng " + txtMaKH.Text + " đã tồn tại, vui lòng nhập lại!");
                    return;
                }
                else
                {
                    sql = "insert into KhachHang values ('" + txtMaKH.Text + "',N'" +
                        txtTenKH.Text + "','" + txtMaLVHD.Text + "',N'" + txtDiaChi.Text + "',N'" +
                        txtDienThoai.Text + "','" + txtEmail.Text + "')";
                }
            }
            if (btnSua_KH.Enabled == true)
            {
                sql = "update KhachHang set TenKH = N'" + txtTenKH.Text + "', MaLVHD = '" +
                    txtMaLVHD.Text + "', DiaChi = N'" + txtDiaChi.Text + "', DienThoai = N'" +
                    txtDienThoai.Text + "', Email = '" + txtEmail.Text + "' where MaKH = '" + txtMaKH.Text + "'";
            }
            database.CapNhatDuLieu(sql);
            loadDuLieuKhachHang("select * from KhachHang");
            HienChiTiet(false);
            XoaChiTiet();
            btnSua_KH.Enabled = false;
            btnXoa_KH.Enabled = false;
            btnThem_KH.Enabled = true;
        }
    }
}

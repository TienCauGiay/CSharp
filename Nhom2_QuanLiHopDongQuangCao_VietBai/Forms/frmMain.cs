using Nhom2_QuanLiHopDongQuangCao_VietBai.Class;
using Nhom2_QuanLiHopDongQuangCao_VietBai.Forms;
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
    public partial class frmMain : Form
    {
        ProcessDatabase database = new ProcessDatabase();
        public frmMain()
        {
            InitializeComponent();
        }

        private Form currentChildform;

        private void openChildForm(Form childForm)
        {
            panel_Body.BackgroundImage = null;
            if (currentChildform != null)
            {
                currentChildform.Close();
            }
            currentChildform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = "Chọn danh mục để xem thông tin danh sách các bảng mà chương trình quản lí\r\n" +
                "Chọn một trong các chức năng bên trái để phục vụ cho yêu cầu của bạn\r\n" +
                "Chọn thoát để kết thúc chương trình";
            MessageBox.Show(s, "Trợ giúp", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTinhNhuanBut_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTinhNhuanBut());
            lbTieuDe.Text = btnTinhNhuanBut.Text;
        }

        private void btnTinhTongTien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTinhTongTien());
            lbTieuDe.Text = btnTinhTongTien.Text;
        }

        private void btnTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTimKiemNhanVien());
            lbTieuDe.Text = btnTimKiemNhanVien.Text;
        }

        private void btnTimKiemKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTimKiemKhachHang());
            lbTieuDe.Text = btnTimKiemKhachHang.Text;
        }

        private void btnBaoCaoDTQC_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBaoCaoDoanhThu());
            lbTieuDe.Text = btnBaoCaoDTQC.Text;
        }

        private void btnBaoCaoNhuanBut_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBaoCaoTongNhuanBut());
            lbTieuDe.Text = btnBaoCaoNhuanBut.Text;
        }

        private void btnBaoCaoTheLoai_Click(object sender, EventArgs e)
        {
            openChildForm(new frmReportTheLoai());
            lbTieuDe.Text = btnBaoCaoTheLoai.Text;
        }

        private void btnBaoCaoGB_NQC_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBaoCaoSoLanNGB_NQC());
            lbTieuDe.Text = btnBaoCaoGB_NQC.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildform != null)
            {
                currentChildform.Close();
            }
            lbTieuDe.Text = "Chương Trình Quản Lí Hợp Đồng Quảng Cáo + Viết Bài";

            panel_Body.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Images\\AnhPanelBody.JPG");
        }

        private void tìmKiếmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTimKiemNhanVien_Click(sender, e);
        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTimKiemKhachHang_Click(sender, e);
        }

        private void tínhNhuậnBútToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTinhNhuanBut_Click(sender, e);
        }

        private void tínhTổngTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTinhTongTien_Click(sender, e);
        }

        private void báoCáoDoanhThuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnBaoCaoDTQC_Click(sender, e);
        }

        private void báoCáoTổngNhuậnBútToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnBaoCaoNhuanBut_Click(sender, e);
        }

        private void báoCáoThểLoạiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnBaoCaoTheLoai_Click(sender, e);
        }

        private void báoCáoGửiBàiVàNhậnQuảngCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBaoCaoGB_NQC_Click(sender, e);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgvNhanVien = new DataGridView();
            dgvNhanVien.DataSource = database.docBang("select * from NhanVien");
            frmDanhMuc f = new frmDanhMuc();
            f.Controls.Add(dgvNhanVien);
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.BackgroundColor = Color.LightSkyBlue;
            openChildForm(f);
            lbTieuDe.Text = "Danh sách " + nhânViênToolStripMenuItem.Text.ToLower();
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
            dgvNhanVien.Columns[0].Width = 150;
            dgvNhanVien.Columns[1].Width = 250;
            dgvNhanVien.Columns[2].Width = 100;
            dgvNhanVien.Columns[3].Width = 150;
            dgvNhanVien.Columns[4].Width = 150;
            dgvNhanVien.Columns[5].Width = 150;
            dgvNhanVien.Columns[6].Width = 150;
            dgvNhanVien.Columns[7].Width = 250;
            dgvNhanVien.Columns[8].Width = 150;
            dgvNhanVien.Columns[9].Width = 100;
            dgvNhanVien.Columns[10].Width = 100;
            dgvNhanVien.Columns[11].Width = 250;
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgvKhachHang = new DataGridView();
            dgvKhachHang.DataSource = database.docBang("select * from KhachHang");
            frmDanhMuc f = new frmDanhMuc();
            f.Controls.Add(dgvKhachHang);
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.BackgroundColor = Color.LightSkyBlue;
            openChildForm(f);
            lbTieuDe.Text = "Danh sách " + kháchHàngToolStripMenuItem.Text.ToLower();
            dgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns[2].HeaderText = "Mã lĩnh vực";
            dgvKhachHang.Columns[3].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[4].HeaderText = "Điện thoại";
            dgvKhachHang.Columns[5].HeaderText = "Email";
            dgvKhachHang.Columns[0].Width = 170;
            dgvKhachHang.Columns[1].Width = 250;
            dgvKhachHang.Columns[2].Width = 150;
            dgvKhachHang.Columns[3].Width = 250;
            dgvKhachHang.Columns[4].Width = 150;
            dgvKhachHang.Columns[5].Width = 250;
        }

        private void bảngGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgvBangGia = new DataGridView();
            dgvBangGia.DataSource = database.docBang("select * from BangGia");
            frmDanhMuc f = new frmDanhMuc();
            f.Controls.Add(dgvBangGia);
            dgvBangGia.Dock = DockStyle.Fill;
            dgvBangGia.BackgroundColor = Color.LightSkyBlue;
            openChildForm(f);
            lbTieuDe.Text = "Danh sách " + bảngGiáToolStripMenuItem.Text.ToLower();
            dgvBangGia.Columns[0].HeaderText = "Mã báo";
            dgvBangGia.Columns[1].HeaderText = "Mã quảng cáo";
            dgvBangGia.Columns[2].HeaderText = "Đơn giá";
            dgvBangGia.Columns[0].Width = 150;
            dgvBangGia.Columns[1].Width = 170;
            dgvBangGia.Columns[2].Width = 200;
        }

        private void báoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgvBao = new DataGridView();
            dgvBao.DataSource = database.docBang("select * from Bao");
            frmDanhMuc f = new frmDanhMuc();
            f.Controls.Add(dgvBao);
            dgvBao.Dock = DockStyle.Fill;
            dgvBao.BackgroundColor = Color.LightSkyBlue;
            openChildForm(f);
            lbTieuDe.Text = "Danh sách " + báoToolStripMenuItem.Text.ToLower();
            dgvBao.Columns[0].HeaderText = "Mã báo";
            dgvBao.Columns[1].HeaderText = "Tên báo";
            dgvBao.Columns[2].HeaderText = "Mã chức năng";
            dgvBao.Columns[3].HeaderText = "Địa chỉ";
            dgvBao.Columns[4].HeaderText = "Điện thoại";
            dgvBao.Columns[5].HeaderText = "Email";
            dgvBao.Columns[0].Width = 150;
            dgvBao.Columns[1].Width = 250;
            dgvBao.Columns[2].Width = 150;
            dgvBao.Columns[3].Width = 170;
            dgvBao.Columns[4].Width = 150;
            dgvBao.Columns[5].Width = 250;
        }

        private void báoThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgvBao_TheLoai = new DataGridView();
            dgvBao_TheLoai.DataSource = database.docBang("select * from Bao_TheLoai");
            frmDanhMuc f = new frmDanhMuc();
            f.Controls.Add(dgvBao_TheLoai);
            dgvBao_TheLoai.Dock = DockStyle.Fill;
            dgvBao_TheLoai.BackgroundColor = Color.LightSkyBlue;
            openChildForm(f);
            lbTieuDe.Text = "Danh sách " + báoThểLoạiToolStripMenuItem.Text.ToLower();
            dgvBao_TheLoai.Columns[0].HeaderText = "Mã báo";
            dgvBao_TheLoai.Columns[1].HeaderText = "Mã thể loại";
            dgvBao_TheLoai.Columns[2].HeaderText = "Nhuận bút";
            dgvBao_TheLoai.Columns[0].Width = 100;
            dgvBao_TheLoai.Columns[1].Width = 150;
            dgvBao_TheLoai.Columns[2].Width = 200;
        }

        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgvChucNang = new DataGridView();
            dgvChucNang.DataSource = database.docBang("select * from ChucNang");
            frmDanhMuc f = new frmDanhMuc();
            f.Controls.Add(dgvChucNang);
            dgvChucNang.Dock = DockStyle.Fill;
            dgvChucNang.BackgroundColor = Color.LightSkyBlue;
            openChildForm(f);
            lbTieuDe.Text = "Danh sách " + chứcNăngToolStripMenuItem.Text.ToLower();
            dgvChucNang.Columns[0].HeaderText = "Mã chức năng";
            dgvChucNang.Columns[1].HeaderText = "Tên chức năng";
            dgvChucNang.Columns[0].Width = 200;
            dgvChucNang.Columns[1].Width = 200;
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgvChucVu = new DataGridView();
            dgvChucVu.DataSource = database.docBang("select * from ChucVu");
            frmDanhMuc f = new frmDanhMuc();
            f.Controls.Add(dgvChucVu);
            dgvChucVu.Dock = DockStyle.Fill;
            dgvChucVu.BackgroundColor = Color.LightSkyBlue;
            openChildForm(f);
            lbTieuDe.Text = "Danh sách " + chứcVụToolStripMenuItem.Text.ToLower();
            dgvChucVu.Columns[0].HeaderText = "Mã chức vụ";
            dgvChucVu.Columns[1].HeaderText = "Tên chức vụ";
            dgvChucVu.Columns[0].Width = 200;
            dgvChucVu.Columns[1].Width = 200;
        }

        private void chuyênMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgvChuyenMon= new DataGridView();
            dgvChuyenMon.DataSource = database.docBang("select * from ChuyenMon");
            frmDanhMuc f = new frmDanhMuc();
            f.Controls.Add(dgvChuyenMon);
            dgvChuyenMon.Dock = DockStyle.Fill;
            dgvChuyenMon.BackgroundColor = Color.LightSkyBlue;
            openChildForm(f);
            lbTieuDe.Text = "Danh sách " + chuyênMônToolStripMenuItem.Text.ToLower();
            dgvChuyenMon.Columns[0].HeaderText = "Mã chuyên môn";
            dgvChuyenMon.Columns[1].HeaderText = "Tên chuyên môn";
            dgvChuyenMon.Columns[0].Width = 200;
            dgvChuyenMon.Columns[1].Width = 200;
        }

        private void lĩnhVựcHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgvLVHD = new DataGridView();
            dgvLVHD.DataSource = database.docBang("select * from LinhVucHoatDong");
            frmDanhMuc f = new frmDanhMuc();
            f.Controls.Add(dgvLVHD);
            dgvLVHD.Dock = DockStyle.Fill;
            dgvLVHD.BackgroundColor = Color.LightSkyBlue;
            openChildForm(f);
            lbTieuDe.Text = "Danh sách " + lĩnhVựcHoạtĐộngToolStripMenuItem.Text.ToLower();
            dgvLVHD.Columns[0].HeaderText = "Mã LVHD";
            dgvLVHD.Columns[1].HeaderText = "Tên LVHD";
            dgvLVHD.Columns[0].Width = 200;
            dgvLVHD.Columns[1].Width = 200;
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgvPhongBan = new DataGridView();
            dgvPhongBan.DataSource = database.docBang("select * from PhongBan");
            frmDanhMuc f = new frmDanhMuc();
            f.Controls.Add(dgvPhongBan);
            dgvPhongBan.Dock = DockStyle.Fill;
            dgvPhongBan.BackgroundColor = Color.LightSkyBlue;
            openChildForm(f);
            lbTieuDe.Text = "Danh sách " + phòngBanToolStripMenuItem.Text.ToLower();
            dgvPhongBan.Columns[0].HeaderText = "Mã phòng";
            dgvPhongBan.Columns[1].HeaderText = "Tên phòng";
            dgvPhongBan.Columns[2].HeaderText = "Mã báo";
            dgvPhongBan.Columns[3].HeaderText = "Điện thoại";
            dgvPhongBan.Columns[0].Width = 150;
            dgvPhongBan.Columns[1].Width = 200;
            dgvPhongBan.Columns[2].Width = 150;
            dgvPhongBan.Columns[3].Width = 200;
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgvTheLoai = new DataGridView();
            dgvTheLoai.DataSource = database.docBang("select * from TheLoai");
            frmDanhMuc f = new frmDanhMuc();
            f.Controls.Add(dgvTheLoai);
            dgvTheLoai.Dock = DockStyle.Fill;
            dgvTheLoai.BackgroundColor = Color.LightSkyBlue;
            openChildForm(f);
            lbTieuDe.Text = "Danh sách " + thểLoạiToolStripMenuItem.Text.ToLower();
            dgvTheLoai.Columns[0].HeaderText = "Mã thể loại";
            dgvTheLoai.Columns[1].HeaderText = "Tên thể loại";
            dgvTheLoai.Columns[0].Width = 200;
            dgvTheLoai.Columns[1].Width = 200;
        }

        private void thôngTinQuảngCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgvTTQC = new DataGridView();
            dgvTTQC.DataSource = database.docBang("select * from ThongTinQuangCao");
            frmDanhMuc f = new frmDanhMuc();
            f.Controls.Add(dgvTTQC);
            dgvTTQC.Dock = DockStyle.Fill;
            dgvTTQC.BackgroundColor = Color.LightSkyBlue;
            openChildForm(f);
            lbTieuDe.Text = "Danh sách " + thôngTinQuảngCáoToolStripMenuItem.Text.ToLower();
            dgvTTQC.Columns[0].HeaderText = "Mã quảng cáo";
            dgvTTQC.Columns[1].HeaderText = "Tên quảng cáo";
            dgvTTQC.Columns[0].Width = 200;
            dgvTTQC.Columns[1].Width = 200;
        }

        private void trìnhĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgvTrinhDo = new DataGridView();
            dgvTrinhDo.DataSource = database.docBang("select * from TrinhDo");
            frmDanhMuc f = new frmDanhMuc();
            f.Controls.Add(dgvTrinhDo);
            dgvTrinhDo.Dock = DockStyle.Fill;
            dgvTrinhDo.BackgroundColor = Color.LightSkyBlue;
            openChildForm(f);
            lbTieuDe.Text = "Danh sách " + trìnhĐộToolStripMenuItem.Text.ToLower();
            dgvTrinhDo.Columns[0].HeaderText = "Mã trình độ";
            dgvTrinhDo.Columns[1].HeaderText = "Tên trình độ";
            dgvTrinhDo.Columns[0].Width = 200;
            dgvTrinhDo.Columns[1].Width = 200;
        }

        private void kháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgvKhach_QuangCao = new DataGridView();
            dgvKhach_QuangCao.DataSource = database.docBang("select * from Khach_QuangCao");
            frmDanhMuc f = new frmDanhMuc();
            f.Controls.Add(dgvKhach_QuangCao);
            dgvKhach_QuangCao.Dock = DockStyle.Fill;
            dgvKhach_QuangCao.BackgroundColor = Color.LightSkyBlue;
            openChildForm(f);
            lbTieuDe.Text = "Danh sách " + kháchToolStripMenuItem.Text.ToLower();
            dgvKhach_QuangCao.Columns[0].HeaderText = "Mã lần quảng cáo";
            dgvKhach_QuangCao.Columns[1].HeaderText = "Mã khách hàng";
            dgvKhach_QuangCao.Columns[2].HeaderText = "Mã nhân viên";
            dgvKhach_QuangCao.Columns[3].HeaderText = "Mã báo";
            dgvKhach_QuangCao.Columns[4].HeaderText = "Mã quảng cáo";
            dgvKhach_QuangCao.Columns[5].HeaderText = "Nội dung";
            dgvKhach_QuangCao.Columns[6].HeaderText = "Ngày bắt đầu";
            dgvKhach_QuangCao.Columns[7].HeaderText = "Ngày kết thúc";
            dgvKhach_QuangCao.Columns[8].HeaderText = "Tổng tiền";
            dgvKhach_QuangCao.Columns[0].Width = 200;
            dgvKhach_QuangCao.Columns[1].Width = 150;
            dgvKhach_QuangCao.Columns[2].Width = 150;
            dgvKhach_QuangCao.Columns[3].Width = 100;
            dgvKhach_QuangCao.Columns[4].Width = 150;
            dgvKhach_QuangCao.Columns[5].Width = 200;
            dgvKhach_QuangCao.Columns[6].Width = 150;
            dgvKhach_QuangCao.Columns[7].Width = 150;
            dgvKhach_QuangCao.Columns[8].Width = 200;
        }

        private void kháchGửiBàiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgvKhachGuiBai = new DataGridView();
            dgvKhachGuiBai.DataSource = database.docBang("select * from KhachGuiBai");
            frmDanhMuc f = new frmDanhMuc();
            f.Controls.Add(dgvKhachGuiBai);
            dgvKhachGuiBai.Dock = DockStyle.Fill;
            dgvKhachGuiBai.BackgroundColor = Color.LightSkyBlue;
            openChildForm(f);
            lbTieuDe.Text = "Danh sách " + kháchGửiBàiToolStripMenuItem.Text.ToLower();
            dgvKhachGuiBai.Columns[0].HeaderText = "Mã lần gửi";
            dgvKhachGuiBai.Columns[1].HeaderText = "Mã khách hàng";
            dgvKhachGuiBai.Columns[2].HeaderText = "Mã thể loại";
            dgvKhachGuiBai.Columns[3].HeaderText = "Mã báo";
            dgvKhachGuiBai.Columns[4].HeaderText = "Mã nhân viên";
            dgvKhachGuiBai.Columns[5].HeaderText = "Tiêu đề";
            dgvKhachGuiBai.Columns[6].HeaderText = "Nội dung";
            dgvKhachGuiBai.Columns[7].HeaderText = "Ngày đăng";
            dgvKhachGuiBai.Columns[8].HeaderText = "Nhuận bút";
            dgvKhachGuiBai.Columns[0].Width = 150;
            dgvKhachGuiBai.Columns[1].Width = 170;
            dgvKhachGuiBai.Columns[2].Width = 150;
            dgvKhachGuiBai.Columns[3].Width = 100;
            dgvKhachGuiBai.Columns[4].Width = 150;
            dgvKhachGuiBai.Columns[5].Width = 200;
            dgvKhachGuiBai.Columns[6].Width = 200;
            dgvKhachGuiBai.Columns[7].Width = 150;
            dgvKhachGuiBai.Columns[8].Width = 200;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}

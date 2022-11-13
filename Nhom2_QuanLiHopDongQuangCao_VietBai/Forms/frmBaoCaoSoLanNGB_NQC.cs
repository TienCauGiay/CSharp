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
    public partial class frmBaoCaoSoLanNGB_NQC : Form
    {

        ProcessDatabase database = new ProcessDatabase();
        public frmBaoCaoSoLanNGB_NQC()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            string sql = "";
            sql = "select t.MaNV,t.TenNV, sum(t.SoLanGui) as SoLanGui, sum(t.SoLanQuangCao) as SoLanQuangCao from\r\n\t(select NhanVien.MaNV, NhanVien.TenNV, lg.SoLanGui, 0 as SoLanQuangCao from NhanVien,(select MaNV, count(MaLG) as SoLanGui from KhachGuiBai group by MaNV) lg\r\n\twhere NhanVien.MaNV = lg.MaNV\r\n\tunion\r\n\tselect NhanVien.MaNV, NhanVien.TenNV, 0 as SoLanGui, lqc.SoLanQuangCao from NhanVien,\r\n\t(select MaNV, count(MaLQC) as SoLanQuangCao from Khach_QuangCao group by MaNV) lqc\r\n\twhere NhanVien.MaNV = lqc.MaNV) t\r\n\tgroup by t.MaNV,t.TenNV";
            DataTable dt = database.docBang(sql);
            dgvBaoCaoSoLanNGB_NQC.DataSource = dt;
            dgvBaoCaoSoLanNGB_NQC.Columns[0].Width = 150;
            dgvBaoCaoSoLanNGB_NQC.Columns[1].Width = 230;
            dgvBaoCaoSoLanNGB_NQC.Columns[2].Width = 150;
            dgvBaoCaoSoLanNGB_NQC.Columns[3].Width = 200;
            chartCot.ChartAreas["ChartArea1"].AxisX.Title = "Nhân viên";
            chartCot.ChartAreas["ChartArea1"].AxisY.Title = "Số lần";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chartCot.Series["SoLanGui"].Points.AddXY(dt.Rows[i]["MaNV"], dt.Rows[i]["SoLanGui"]);
                chartCot.Series["SoLanQC"].Points.AddXY(dt.Rows[i]["MaNV"], dt.Rows[i]["SoLanQuangCao"]);
            }
        }

        private void frmBaoCaoSoLanNGB_NQC_Load(object sender, EventArgs e)
        {
            loadData();
            dgvBaoCaoSoLanNGB_NQC.Columns[0].HeaderText = "Mã nhân viên";
            dgvBaoCaoSoLanNGB_NQC.Columns[1].HeaderText = "Tên nhân viên";
            dgvBaoCaoSoLanNGB_NQC.Columns[2].HeaderText = "Số lần gửi";
            dgvBaoCaoSoLanNGB_NQC.Columns[3].HeaderText = "Số lần quảng cáo";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn đóng chức năng báo cáo số lần nhận bài gửi và nhận quảng cáo của nhân viên không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            frmReportSoLanNGB_NQC f = new frmReportSoLanNGB_NQC();
            f.Show();
        }
    }
}

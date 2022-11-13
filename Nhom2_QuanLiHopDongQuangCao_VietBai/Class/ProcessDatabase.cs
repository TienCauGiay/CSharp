using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom2_QuanLiHopDongQuangCao_VietBai.Class
{
    public class ProcessDatabase
    {
        string strConnect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="+System.IO.Directory.GetCurrentDirectory().ToString()+"\\Database\\BTL_LTTQ.mdf;Integrated Security=True";
        SqlConnection sqlConnect = null;
        public void KetNoiCSDL()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }

        public void DongKetNoiCSDL()
        {
            if (sqlConnect.State != ConnectionState.Closed)
                sqlConnect.Close();
            sqlConnect.Dispose();
        }

        public DataTable docBang(string sql)
        {
            DataTable dtBang = new DataTable();
            KetNoiCSDL();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnect);
                adapter.Fill(dtBang);
            }
            catch
            {
                MessageBox.Show("Lỗi đọc bảng, vui lòng thử lại");
            }
            DongKetNoiCSDL();
            return dtBang;
        }

        public void CapNhatDuLieu(string sql)
        {
            KetNoiCSDL();
            try
            {
                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.Connection = sqlConnect;
                sqlcommand.CommandText = sql;
                sqlcommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Lỗi cập nhật dữ liệu, vui lòng thử lại");
            }
            DongKetNoiCSDL();
        }
    }
}

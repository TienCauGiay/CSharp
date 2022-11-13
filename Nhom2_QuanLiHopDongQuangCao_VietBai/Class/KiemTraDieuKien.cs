using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nhom2_QuanLiHopDongQuangCao_VietBai.Class
{
    public class KiemTraDieuKien
    {
        public bool isNumber(string ptext)
        {
            Regex regex = new Regex(@"^[0-9]*$");
            return regex.IsMatch(ptext);
        }

        public string dkCacBao(string txtMaB)
        {
            string[] lCacBao = txtMaB.Trim().Split(',');
            string dk = "";
            foreach (string i in lCacBao)
            {
                dk += "'" + i + "',";
            }
            dk = dk.Substring(0, dk.Length - 1);
            return dk;
        }
    }
}

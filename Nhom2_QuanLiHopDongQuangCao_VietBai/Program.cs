using Nhom2_QuanLiHopDongQuangCao_VietBai.bin.Debug.Forms;
using Nhom2_QuanLiHopDongQuangCao_VietBai.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom2_QuanLiHopDongQuangCao_VietBai
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}

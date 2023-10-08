using QuanLyBaoHiemNhanTho.GUI;
using QuanLyBaoHiemNhanTho.Models;

namespace QuanLyBaoHiemNhanTho
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static Them them = null;
        public static FormKhachHang mainKH = null;
        public static FormDangNhap formDangNhap;
        public static FormMain formMain;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            formDangNhap = new FormDangNhap();
            them = new Them();
            mainKH = new FormKhachHang();
            Application.Run(formDangNhap);
        }

        public static void StartFormMain(NhanVien nv)
        {
            formMain = new FormMain(nv);
            formMain.Show();
            formDangNhap.Hide();
        }

        public static void StartFormDangNhap()
        {
            formDangNhap = new FormDangNhap();
            formDangNhap.Show();
            formMain.Dispose();
        }
    }
}
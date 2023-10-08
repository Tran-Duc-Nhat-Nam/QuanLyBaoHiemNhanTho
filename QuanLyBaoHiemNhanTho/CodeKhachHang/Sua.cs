using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBaoHienNhanTho.CodeKhachHang.Controler;
using QuanLyBaoHienNhanTho.CodeKhachHang.Module;
using QuanLyBaoHienNhanTho.CodeKhachHang.Connect;

namespace QuanLyBaoHiemNhanTho
{
    public partial class Sua : Form
    {
        ControlerKhachHang khDB = new ControlerKhachHang();
        public Sua(KhachHang kh)
        {
            InitializeComponent();
            cbb_gioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });

            if (txt_maKH != null)
            {
                txt_maKH.Text = kh.Id;
                txt_tenKH.Text = kh.HoTen;
                txt_CCCD.Text = kh.CCCD;
                txt_email.Text  =kh.Email;
                txt_SDT.Text = kh.SDT;
                cbb_gioiTinh.SelectedItem = kh.GioiTinh.ToString();
                txt_quocTich.Text = kh.QuocTich;
                txt_ngay.Value = kh.NgaySinh.Value;
                txt_soNha.Text = kh.DiaChi.SoNha;
                txt_soDuong.Text = kh.DiaChi.Duong;
                txt_phuongXa.Text = kh.DiaChi.PhuongXa;
                txt_quanHuyen.Text = kh.DiaChi.QuanHuyen;
                txt_tinhThanh.Text = kh.DiaChi.TinhThanh;
            }
            txt_maKH.Enabled = false;
        }

        private void btn_suaKH_Click(object sender, EventArgs e)
        {
            DiaChi diaChi = new DiaChi(txt_soNha.Text, txt_soDuong.Text, txt_phuongXa.Text, txt_quanHuyen.Text, txt_tinhThanh.Text); ;
            KhachHang kh = new KhachHang(txt_maKH.Text, txt_tenKH.Text, txt_CCCD.Text,txt_SDT.Text, txt_email.Text, cbb_gioiTinh.Text, txt_quocTich.Text, txt_ngay.Value.Date, diaChi);
            List<HopDong> lsHD = khDB.dsHDisKH(txt_maKH.Text);
            if (lsHD != null)
            {
                foreach (HopDong h in lsHD)
                    khDB.updateOneKHinHD(h.Id, kh);
            }
            khDB.updateKhachHang(txt_maKH.Text, kh);
            this.Close();
            Program.mainKH.loadData();
            Program.mainKH.Show();

        }
    }
}

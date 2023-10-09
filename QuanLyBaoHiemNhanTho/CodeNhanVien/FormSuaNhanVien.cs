using QuanLyBaoHiemNhanTho.CodeNhanVien.Controler;
using QuanLyBaoHiemNhanTho.Services;
using QuanLyBaoHienNhanTho.CodeNhanVien.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaoHiemNhanTho.GUI
{
    public partial class FormSuaNhanVien : Form
    {
        public FormSuaNhanVien(NhanVien nv)
        {
            InitializeComponent();
            cbb_gt.Items.AddRange(new string[] { "Nam", "Nữ" });
            comboBox1.Items.AddRange(new string[] { "Con làm", "Đã nghỉ" });

            if (txt_manv != null)
            {
                txt_manv.Text = nv.Id;
                txt_hoten.Text = nv.HoTen;
                txt_cccd.Text = nv.CCCD;
                cbb_gt.SelectedItem = nv.GioiTinh.ToString();
                txt_mk.Text = nv.MatKhau;
                comboBox1.Text = nv.TrangThai;
                txt_sdt.Text = nv.SDT;
                txt_email.Text = nv.Email;
                txt_qt.Text = nv.QuocTich;
                txt_ngay.Value = (DateTime)nv.NgaySinh;
                txt_soNha.Text = nv.DiaChi.SoNha;
                txt_tenDuong.Text = nv.DiaChi.Duong;
                txt_phuongXa.Text = nv.DiaChi.PhuongXa;
                txt_quanHuyen.Text = nv.DiaChi.QuanHuyen;
                txt_tinhThanh.Text = nv.DiaChi.TinhThanh;
            }
            txt_manv.Enabled = false;
        }
        CodeNhanVien.Controler.ServiceNhanVien srNV = new CodeNhanVien.Controler.ServiceNhanVien();
        private void button3_Click(object sender, EventArgs e)
        {

            DiaChi diaChi = new DiaChi(txt_soNha.Text, txt_tenDuong.Text, txt_phuongXa.Text, txt_quanHuyen.Text, txt_tinhThanh.Text);
            NhanVien nv = new NhanVien(txt_manv.Text, txt_hoten.Text, txt_cccd.Text, txt_mk.Text, comboBox1.Text, cbb_gt.Text, txt_qt.Text, txt_sdt.Text, txt_email.Text, txt_ngay.Value.Date, diaChi);
            List<HopDong> lsHD = srNV.dsHDisNV(txt_manv.Text);
            if (lsHD != null)
            {
                foreach (HopDong h in lsHD)
                    srNV.updateOneNVinHD(h.Id, nv);
            }
            srNV.updateNhanVien(txt_manv.Text, nv);
            this.Visible = false;
            FormNhanVien frmThem = new FormNhanVien();
            frmThem.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            FormNhanVien frmThem = new FormNhanVien();
            frmThem.Show();
        }
    }
}

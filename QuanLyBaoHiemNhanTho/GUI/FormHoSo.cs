using QuanLyBaoHiemNhanTho.Models;
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
    public partial class FormHoSo : Form
    {
        NhanVien nv;
        public FormHoSo(NhanVien nv)
        {
            InitializeComponent();

            this.nv = nv;

            txtHoTen.Text = nv.HoTen;
            txtCCCD.Text = nv.CCCD;
            txtGioiTinh.Text = nv.GioiTinh;
            txtQuocTich.Text = nv.QuocTich;
            txtNgaySinh.Text = nv.NgaySinh.ToShortDateString();
            txtDiaChi.Text = nv.DiaChi.ToString();
            txtEmail.Text = nv.Email;
            txtSDT.Text = nv.SDT;
            txttrangThai.Text = nv.TrangThai;
            txtMatKhau.Text = nv.MatKhau;
        }

        private void txtNgayVaoLam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

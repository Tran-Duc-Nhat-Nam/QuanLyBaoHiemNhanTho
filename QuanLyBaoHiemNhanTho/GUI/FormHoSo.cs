using QuanLyBaoHiemNhanTho.Models;
using QuanLyBaoHiemNhanTho.Services;
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
        NhanVien nvht;
        public FormHoSo(NhanVien nv)
        {
            InitializeComponent();

            this.nvht = nv;

            txtHoTen.Text = nv.HoTen;
            txtCCCD.Text = nv.CCCD;
            txtGioiTinh.Text = nv.GioiTinh;
            txtQuocTich.Text = nv.QuocTich;
            dtpNgaySinh.Value = nv.NgaySinh;
            txtSoNha.Text = nv.DiaChi.SoNha;
            txtDuong.Text = nv.DiaChi.Duong;
            txtPhuongXa.Text = nv.DiaChi.PhuongXa;
            txtQuanHuyen.Text = nv.DiaChi.QuanHuyen;
            txtTinhThanh.Text = nv.DiaChi.TinhThanh;
            txtEmail.Text = nv.Email;
            txtSDT.Text = nv.SDT;
            txttrangThai.Text = nv.TrangThai;
            txtMatKhau.Text = nv.MatKhau;

            btnChinhSua.Click += BtnChinhSua_Click;
        }

        private void BtnChinhSua_Click(object? sender, EventArgs e)
        {
            if (btnChinhSua.Text == "Chỉnh sửa")
            {
                txtHoTen.ReadOnly = false;
                txtCCCD.ReadOnly = false;
                txtGioiTinh.ReadOnly = false;
                txtQuocTich.ReadOnly = false;
                dtpNgaySinh.Enabled = true;
                txtSoNha.ReadOnly = false;
                txtDuong.ReadOnly = false;
                txtPhuongXa.ReadOnly = false;
                txtQuanHuyen.ReadOnly = false;
                txtTinhThanh.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtSDT.ReadOnly = false;
                txttrangThai.ReadOnly = false;
                txtMatKhau.ReadOnly = false;

                btnChinhSua.Text = "Lưu";
            }
            else
            {
                NhanVien nv = new NhanVien();

                nv._id = nvht._id;
                nv.HoTen = txtHoTen.Text;
                nv.CCCD = txtCCCD.Text;
                nv.GioiTinh = txtGioiTinh.Text;
                nv.QuocTich = txtQuocTich.Text;
                nv.NgaySinh = dtpNgaySinh.Value;
                nv.DiaChi.SoNha = txtSoNha.Text;
                nv.DiaChi.Duong = txtDuong.Text;
                nv.DiaChi.PhuongXa = txtPhuongXa.Text;
                nv.DiaChi.QuanHuyen = txtQuanHuyen.Text;
                nv.DiaChi.TinhThanh = txtTinhThanh.Text;
                nv.Email = txtEmail.Text;
                nv.SDT = txtSDT.Text;
                nv.MatKhau = txtMatKhau.Text;

                new ServiceNhanVien().CapNhatTaiKhoan(nv);

                txtHoTen.ReadOnly = true;
                txtCCCD.ReadOnly = true;
                txtGioiTinh.ReadOnly = true;
                txtQuocTich.ReadOnly = true;
                dtpNgaySinh.Enabled = false;
                txtSoNha.ReadOnly = true;
                txtDuong.ReadOnly = true;
                txtPhuongXa.ReadOnly = true;
                txtQuanHuyen.ReadOnly = true;
                txtTinhThanh.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txttrangThai.ReadOnly = true;
                txtMatKhau.ReadOnly = true;

                btnChinhSua.Text = "Chỉnh sửa";
            }
        }

        private void txtNgayVaoLam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

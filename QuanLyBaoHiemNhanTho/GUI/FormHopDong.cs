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
    public partial class FormHopDong : Form
    {
        NhanVien nv;
        public FormHopDong(NhanVien nv)
        {
            InitializeComponent();

            this.nv = nv;

            this.cbxGioiTinh.DataSource = new List<string>() { "Nam", "Nữ" };
            this.cbxTinhTrang.DataSource = new List<string>() { "Đã hủy", "Còn hiệu lực", "Đã thanh toán"};

            this.cbxLoaiHD.DataSource = new ServiceLoaiHD().XemLoaiHD();
            this.cbxLoaiHD.DisplayMember = "TenLHD";
            this.cbxLoaiHD.ValueMember = "_id";

            this.cbxNhanVien.DataSource = new ServiceNhanVien().XemNhanVien();
            this.cbxNhanVien.DisplayMember = "_id";
            this.cbxNhanVien.ValueMember = "_id";

            this.cbxKhachHang.DataSource = new ServiceKhachHang().XemKhachHang();
            this.cbxKhachHang.DisplayMember = "_id";
            this.cbxKhachHang.ValueMember = "_id";

            this.dgvHD.SelectionChanged += DgvHD_SelectionChanged;
            this.btnThem.Click += BtnThem_Click;
            this.btnXoa.Click += BtnXoa_Click;
            this.btnCapNhat.Click += BtnCapNhat_ClickAsync;
            this.txtTimKiem.KeyPress += TxtTimKiem_KeyPress;
            this.cbxKhachHang.SelectedIndexChanged += CbxKhachHang_SelectedIndexChanged;

            LoadHD();

            CbxKhachHang_SelectedIndexChanged(this, null);
        }

        private bool validate()
        {
            try
            {
                long phiHD = Convert.ToInt64(txtPhiHD.Text);

                if (phiHD < 0)
                {
                    return false;
                }

                long phiThanhToan = Convert.ToInt64(txtPhiThanhToan.Text);

                if (phiThanhToan < 0)
                {
                    return false;
                }

                double phanTram = Convert.ToDouble(txtPhanTram.Text);

                if (phanTram < 0)
                {
                    return false;
                }

                Convert.ToInt64(txtCCCD.Text);

                if (txtCCCD.Text.Count() != 12)
                {
                    return false;
                }

                Convert.ToInt64(txtSDT.Text);

                return true;
            } 
            catch (Exception)
            {
                return false;
            }
        }

        private void TxtTimKiem_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dgvHD.DataSource = new ServiceHopDong().XemHopDong(txtTimKiem.Text);
            }
        }

        private async void BtnCapNhat_ClickAsync(object? sender, EventArgs e)
        {
            if (dgvHD.CurrentRow != null)
            {
                if (btnCapNhat.Text == "Cập nhật")
                {
                    btnCapNhat.Text = "Lưu";
                    btnThem.Enabled = false;
                    btnXoa.Enabled = false;
                    dgvHD.Enabled = false;
                    txtPhiHD.ReadOnly = false;
                    txtPhiThanhToan.ReadOnly = false;
                    txtPhanTram.ReadOnly = false;
                    dtpNgayHetHan.Enabled = true;
                    cbxLoaiHD.Enabled = true;
                    cbxKhachHang.Enabled = true;

                    txtHoTen.ReadOnly = false;
                    txtEmail.ReadOnly = false;
                    txtQuocTich.ReadOnly = false;
                    txtSDT.ReadOnly = false;
                    txtCCCD.ReadOnly = false;
                    txtSoNha.ReadOnly = false;
                    txtDuong.ReadOnly = false;
                    txtPhuongXa.ReadOnly = false;
                    txtQuanHuyen.ReadOnly = false;
                    txtTinhThanh.ReadOnly = false;
                }
                else
                {
                    if (!validate())
                    {
                        MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ");
                        return;
                    }

                    HopDong hd = new HopDong();

                    hd._id = dgvHD.CurrentRow.Cells["MaHopDong"].Value.ToString();
                    hd.PhiHopDong = Convert.ToInt64(txtPhiHD.Text);
                    hd.PhiThanhToan = Convert.ToInt64(txtPhiThanhToan.Text);
                    hd.PhanTramLoiNhuan = Convert.ToDouble(txtPhanTram.Text);
                    hd.NgayLapHD = DateTime.Now;
                    hd.NgayHetHan = dtpNgayHetHan.Value;
                    hd.LoaiHD = (LoaiHD)cbxLoaiHD.SelectedItem;
                    hd.NhanVien = nv;
                    hd.TinhTrang = cbxTinhTrang.SelectedText;

                    if ((KhachHang)cbxKhachHang.SelectedItem != null)
                    {
                        hd.KhachHang = (KhachHang)cbxKhachHang.SelectedItem;
                    }
                    else
                    {
                        hd.KhachHang.CCCD = txtCCCD.Text;
                        hd.KhachHang.SDT = txtSDT.Text;
                        hd.KhachHang.HoTen = txtHoTen.Text;
                        hd.KhachHang.QuocTich = txtQuocTich.Text;
                        hd.KhachHang.Email = txtEmail.Text;
                        hd.KhachHang.DiaChi.SoNha = txtSoNha.Text;
                        hd.KhachHang.DiaChi.Duong = txtDuong.Text;
                        hd.KhachHang.DiaChi.PhuongXa = txtPhuongXa.Text;
                        hd.KhachHang.DiaChi.QuanHuyen = txtQuanHuyen.Text;
                        hd.KhachHang.DiaChi.TinhThanh = txtTinhThanh.Text;
                        hd.KhachHang.GioiTinh = cbxGioiTinh.SelectedText;

                        hd._id = await new ServiceKhachHang().ThemKhachHang(hd.KhachHang);
                    }

                    await new ServiceHopDong().CapNhatHopDong(hd);

                    btnCapNhat.Text = "Cập nhật";
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    dgvHD.Enabled = true;
                    txtPhiHD.ReadOnly = true;
                    txtPhiThanhToan.ReadOnly = true;
                    txtPhanTram.ReadOnly = true;
                    dtpNgayHetHan.Enabled = false;
                    cbxLoaiHD.Enabled = false;
                    cbxKhachHang.Enabled = false;

                    txtHoTen.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtQuocTich.ReadOnly = true;
                    txtSDT.ReadOnly = true;
                    txtCCCD.ReadOnly = true;
                    txtSoNha.ReadOnly = true;
                    txtDuong.ReadOnly = true;
                    txtPhuongXa.ReadOnly = true;
                    txtQuanHuyen.ReadOnly = true;
                    txtTinhThanh.ReadOnly = true;

                    LoadHD();
                    this.DgvHD_SelectionChanged(this, null);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hợp đồng");
            }

            
        }

        private async void BtnXoa_Click(object? sender, EventArgs e)
        {
            if (dgvHD.CurrentRow != null)
            {
                DialogResult dr = MessageBox.Show("Bạn muốn hủy hợp đồng theo nghiệp vụ thực tế hoặc xóa hợp đồng để demo", "Chọn chức năng", MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes)
                {
                    string MaHD = dgvHD.CurrentRow.Cells["MaHopDong"].Value.ToString();

                    await new ServiceHopDong().HuyHopDong(MaHD);

                    MessageBox.Show("Huỷ hợp đồng thành công");

                    LoadHD();
                }
                else if (dr == DialogResult.No)
                {
                    string MaHD = dgvHD.CurrentRow.Cells["MaHopDong"].Value.ToString();

                    await new ServiceHopDong().XoaHopDong(MaHD);

                    MessageBox.Show("Xóa hợp đồng thành công");

                    LoadHD();
                    this.DgvHD_SelectionChanged(this, null);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hợp đồng");
            }
        }

        private void CbxKhachHang_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cbxKhachHang.SelectedIndex >= 0)
            {
                KhachHang kh = (KhachHang)cbxKhachHang.SelectedItem;

                txtHoTen.Text = kh.HoTen;
                txtEmail.Text = kh.Email;
                txtQuocTich.Text = kh.QuocTich;
                txtSDT.Text = kh.SDT;
                txtCCCD.Text = kh.CCCD;
                txtQuocTich.Text = kh.QuocTich;
                txtSoNha.Text = kh.DiaChi.SoNha;
                txtDuong.Text = kh.DiaChi.Duong;
                txtPhuongXa.Text = kh.DiaChi.PhuongXa;
                txtQuanHuyen.Text = kh.DiaChi.QuanHuyen;
                txtTinhThanh.Text = kh.DiaChi.TinhThanh;
            }
        }

        private async void BtnThem_Click(object? sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Lưu";
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
                dgvHD.Enabled = false;
                txtPhiHD.ReadOnly = false;
                txtPhiThanhToan.ReadOnly = false;
                txtPhanTram.ReadOnly = false;
                dtpNgayHetHan.Enabled = true;
                cbxLoaiHD.Enabled = true;
                cbxKhachHang.Enabled = true;

                txtPhiHD.Clear();
                txtPhiThanhToan.Clear();
                txtPhanTram.Clear();
                txtDuong.Clear();
                txtCCCD.Clear();
                txtHoTen.Clear();
                txtPhuongXa.Clear();
                txtQuanHuyen.Clear();
                txtTinhThanh.Clear();
                txtSDT.Clear();
                txtSoNha.Clear();
                txtEmail.Clear();

                txtHoTen.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtQuocTich.ReadOnly = false;
                txtSDT.ReadOnly = false;
                txtCCCD.ReadOnly = false;
                txtSoNha.ReadOnly = false;
                txtDuong.ReadOnly = false;
                txtPhuongXa.ReadOnly = false;
                txtQuanHuyen.ReadOnly = false;
                txtTinhThanh.ReadOnly = false;
            }
            else
            {
                if (!validate())
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ");
                    return;
                }

                HopDong hd = new HopDong();

                hd.PhiHopDong = Convert.ToInt64(txtPhiHD.Text);
                hd.PhiThanhToan = Convert.ToInt64(txtPhiThanhToan.Text);
                hd.PhanTramLoiNhuan = Convert.ToDouble(txtPhanTram.Text);
                hd.NgayLapHD = DateTime.Now;
                hd.NgayHetHan = dtpNgayHetHan.Value;
                hd.LoaiHD = (LoaiHD)cbxLoaiHD.SelectedItem;
                hd.NhanVien = nv;
                hd.TinhTrang = cbxTinhTrang.SelectedText;

                if ((KhachHang)cbxKhachHang.SelectedItem != null)
                {
                    hd.KhachHang = (KhachHang)cbxKhachHang.SelectedItem;
                }
                else
                {
                    hd.KhachHang.CCCD = txtCCCD.Text;
                    hd.KhachHang.SDT = txtSDT.Text;
                    hd.KhachHang.HoTen = txtHoTen.Text;
                    hd.KhachHang.QuocTich = txtQuocTich.Text;
                    hd.KhachHang.Email = txtEmail.Text;
                    hd.KhachHang.DiaChi.SoNha = txtSoNha.Text;
                    hd.KhachHang.DiaChi.Duong = txtDuong.Text;
                    hd.KhachHang.DiaChi.PhuongXa = txtPhuongXa.Text;
                    hd.KhachHang.DiaChi.QuanHuyen = txtQuanHuyen.Text;
                    hd.KhachHang.DiaChi.TinhThanh = txtTinhThanh.Text;
                    hd.KhachHang.GioiTinh = cbxGioiTinh.SelectedText;

                    hd._id = await new ServiceKhachHang().ThemKhachHang(hd.KhachHang);
                }

                await new ServiceHopDong().ThemHopDong(hd);

                btnThem.Text = "Thêm";
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                dgvHD.Enabled = true;
                txtPhiHD.ReadOnly = true;
                txtPhiThanhToan.ReadOnly = true;
                txtPhanTram.ReadOnly = true;
                dtpNgayHetHan.Enabled = false;
                cbxLoaiHD.Enabled = false;
                cbxKhachHang.Enabled = false;

                txtHoTen.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtQuocTich.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txtCCCD.ReadOnly = true;
                txtSoNha.ReadOnly = true;
                txtDuong.ReadOnly = true;
                txtPhuongXa.ReadOnly = true;
                txtQuanHuyen.ReadOnly = true;
                txtTinhThanh.ReadOnly = true;

                LoadHD();
            }
        }

        private void DgvHD_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvHD.CurrentRow != null)
            {
                string MaHD = dgvHD.CurrentRow.Cells["MaHopDong"].Value.ToString();

                HopDong hd = new ServiceHopDong().XemChiTietHopDong(MaHD);

                txtPhiHD.Text = hd.PhiHopDong.ToString();
                txtPhiThanhToan.Text = hd.PhiThanhToan.ToString();
                txtPhanTram.Text = hd.PhanTramLoiNhuan.ToString();

                cbxGioiTinh.SelectedIndex = cbxGioiTinh.FindStringExact(hd.KhachHang.GioiTinh);
                dtpNgaySinh.Value = hd.KhachHang.NgaySinh;
                dtpNgayLap.Value = hd.NgayLapHD;
                dtpNgayHetHan.Value = hd.NgayHetHan;
                cbxTinhTrang.SelectedIndex = cbxTinhTrang.FindStringExact(hd.TinhTrang);

                cbxLoaiHD.SelectedValue = hd.LoaiHD._id;
                cbxKhachHang.SelectedValue = hd.KhachHang._id;
                cbxNhanVien.SelectedValue = hd.NhanVien._id;
            }
        }

        void LoadHD()
        {
            dgvHD.DataSource = new ServiceHopDong().XemBangHopDong();
        }
    }
}

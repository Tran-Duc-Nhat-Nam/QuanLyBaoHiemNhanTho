using System;
using QuanLyBaoHiemNhanTho.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using QuanLyBaoHiemNhanTho.CodeNhanVien.Controler;
using QuanLyBaoHienNhanTho.CodeNhanVien.Module;

namespace QuanLyBaoHiemNhanTho.GUI
{
    public partial class ThemNhanVien : Form
    {
        public ThemNhanVien()
        {

            InitializeComponent();
            cbb_gt.Items.AddRange(new string[] { "Nam", "Nữ" });
            comboBox1.Items.AddRange(new string[] { "Còn làm việc", "Đã nghỉ" });
            txt_manv.Text = maKhachHang();
            txt_manv.Enabled = false;
        }
        CodeNhanVien.Controler.ServiceNhanVien srNV = new CodeNhanVien.Controler.ServiceNhanVien();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormNhanVien FormNhanVien = new FormNhanVien();
            FormNhanVien.ShowDialog();
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void ThemNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            FormNhanVien FormNhanVien = new FormNhanVien();
            FormNhanVien.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTimengay = txt_ngay.Value.Date;
            DateTime ngay = dateTimengay.Date;
            DiaChi diaChi = new DiaChi(txt_soNha.Text, txt_soDuong.Text, txt_phuongXa.Text, txt_quanHuyen.Text, txt_tinhThanh.Text);
            NhanVien nv = new NhanVien(txt_manv.Text, txt_hoten.Text, txt_cccd.Text, txt_mk.Text, comboBox1.Text, cbb_gt.Text, txt_qt.Text, txt_sdt.Text, txt_email.Text, ngay, diaChi);
            if (!srNV.checkID(txt_manv.Text))
            {
                txt_manv.Clear();
                MessageBox.Show("Mã nhân viên đã tồn tại, xin nhập lại!");
                txt_manv.Focus();
            }
            else
            {
                srNV.themNhanVien(nv);
                this.Visible = false;
                FormNhanVien FormNhanVien = new FormNhanVien();
                FormNhanVien.ShowDialog();

            }
        }
        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

       public string maKhachHang()
        {
            int t = 1;
            string maso = "NV" + t.ToString("000");
            List<NhanVien> lnv = srNV.dsNhanVien();
            foreach (NhanVien k in lnv)
            {
                if (maso != k.Id)
                {
                    return maso;
                }
                t++;
                maso = "NV" + t.ToString("000");
            }
            return maso;
        }
    }
}











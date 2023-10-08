using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBaoHienNhanTho.CodeKhachHang.Controler;
using QuanLyBaoHienNhanTho.CodeKhachHang.Module;
using QuanLyBaoHienNhanTho.CodeKhachHang.Connect;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyBaoHiemNhanTho
{
    public partial class Them : Form
    {
        ControlerKhachHang khDB = new ControlerKhachHang();

        public Them()
        {
            InitializeComponent();
            cbb_gioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });
            txt_maKH.Text = maKhachHang();
            txt_maKH.Enabled = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Them_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainKH.Show();
        }

        private void btn_themKH_Click(object sender, EventArgs e)
        {
            DateTime dateTimengay = txt_ngay.Value.Date;
            DateTime ngay = dateTimengay.Date;

            DiaChi diaChi = new DiaChi(txt_soNha.Text, txt_soDuong.Text, txt_phuongXa.Text, txt_quanHuyen.Text, txt_tinhThanh.Text); ;
            KhachHang kh = new KhachHang(txt_maKH.Text, txt_tenKH.Text, txt_CCCD.Text, txt_SDT.Text, txt_email.Text, cbb_gioiTinh.Text, txt_quocTich.Text, ngay, diaChi);

            if (!khDB.checkID(txt_maKH.Text))
            {
                txt_maKH.Clear();
                MessageBox.Show("Mã nhận viên đã tồn tại, xin nhận lại!");
                txt_maKH.Focus();
            }
            else
            {
                khDB.createKhachHang(kh);
                this.Dispose();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự là số (0-9) hoặc ký tự Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự không hợp lệ
            }
        }

        // Hiện mã khách hàng lên text box
        public string maKhachHang()
        {
            int t = 1;
            string maso = "KH" + t.ToString("000");
            List<KhachHang> lkh = khDB.DsKhachHang();
            foreach(KhachHang k in lkh)
            {
                if(maso != k.Id) {
                    return maso;
                }
                t++;
                maso = "KH" + t.ToString("000");
            }
            return maso;
        }
    }
}

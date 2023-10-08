using Krypton.Toolkit;
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
    public partial class FormMain : Form
    {
        NhanVien nv;
        public FormMain(NhanVien nv)
        {
            InitializeComponent();

            this.nv = nv;
            this.FormClosed += FormMain_FormClosed;

            FormHoSo f = new FormHoSo(nv);
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.ShowInTaskbar = false;
            f.BackColor = Color.White;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();

            smiHoSo.Click += SmiHoSo_Click;
            smiKhachHang.Click += SmiKhachHang_Click;
            smiThongKe.Click += SmiThongKe_Click;
            smiNhanVien.Click += SmiNhanVien_Click;
        }

        private void SmiNhanVien_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
            FormNhanVien f = new FormNhanVien();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.ShowInTaskbar = false;
            f.BackColor = Color.White;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void SmiThongKe_Click(object? sender, EventArgs e)
        {
            // Thêm gọi form thống kê
        }

        private void SmiKhachHang_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
            FormKhachHang f = new FormKhachHang();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.ShowInTaskbar = false;
            f.BackColor = Color.White;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void FormMain_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Environment.Exit(69);
        }

        private void SmiHoSo_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
            FormHoSo f = new FormHoSo(nv);
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.ShowInTaskbar = false;
            f.BackColor = Color.White;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void thốngKệToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using System.ComponentModel;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyBaoHienNhanTho.CodeKhachHang.Connect;
using QuanLyBaoHienNhanTho.CodeKhachHang.Controler;
using QuanLyBaoHienNhanTho.CodeKhachHang.Module;

namespace QuanLyBaoHiemNhanTho
{
    public partial class FormKhachHang : Form
    {

        ControlerKhachHang khDB = new ControlerKhachHang();
        DataTable dataTable = new DataTable();

        public FormKhachHang()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("ID", typeof(string));
            dataTable.Columns.Add("HoTen", typeof(string));
            dataTable.Columns.Add("CCCD", typeof(string));
            dataTable.Columns.Add("SDT", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("GioiTinh", typeof(string));
            dataTable.Columns.Add("QuocTich", typeof(string));
            dataTable.Columns.Add("NgaySinh", typeof(DateTime));
            dataTable.Columns.Add("DiaChi", typeof(string));
            loadData();


        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
            Them f = new Them();
            f.MdiParent = this.MdiParent;
            f.Dock = DockStyle.Fill;
            f.ShowInTaskbar = false;
            f.BackColor = Color.White;
            f.FormBorderStyle = FormBorderStyle.None;

            EventHandler formDisposedHandler = null;
            formDisposedHandler = (sender, e) =>
            {
                // Thực hiện loadData() sau khi form đã bị giải phóng
                loadData();

                // Hủy đăng ký sự kiện FormDisposed để tránh xảy ra nhiều lần
                f.Disposed -= formDisposedHandler;
            };

            f.Disposed += formDisposedHandler;
            f.Show();
        }

        private void dtgv_nhanVien_SelectionChanged(object sender, EventArgs e)
        {

        }

        // Nút xóa
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int rowIndex = dtgv_nhanVien.SelectedCells[0].RowIndex;

            // Lấy dòng chứa ô được chọn
            DataGridViewRow row = dtgv_nhanVien.Rows[rowIndex];

            if (row != null)
            {

                string id = row.Cells["ID"].Value.ToString();
                List<HopDong> dsHD = khDB.dsHDisKH(id);
                if (dsHD.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Khách đã có hợp đồng, bạn muốn xóa các hợp đồng liên quan không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra phản hồi từ người dùng
                    if (result == DialogResult.Yes)
                    {
                        foreach (HopDong d in dsHD)
                        {
                            khDB.deleteHopDong(d.Id);
                            MessageBox.Show("Bạn đã xóa hết những hợp đồng có khách hàng này.");
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                khDB.deleteKhachHang(id);
                loadData();
            }
        }

        // Nút sửa
        private void btn_sua_Click(object sender, EventArgs e)
        {
            int rowIndex = dtgv_nhanVien.SelectedCells[0].RowIndex;

            // Lấy dòng chứa ô được chọn
            DataGridViewRow row = dtgv_nhanVien.Rows[rowIndex];

            if (row != null)
            {
                string id = row.Cells["ID"].Value.ToString();
                KhachHang kh = new KhachHang();
                kh = khDB.findKhachHangID(id);

                LayoutMdi(MdiLayout.Cascade);
                Sua f = new Sua(kh);
                f.MdiParent = this.MdiParent;
                f.Dock = DockStyle.Fill;
                f.ShowInTaskbar = false;
                f.BackColor = Color.White;
                f.FormBorderStyle = FormBorderStyle.None;

                EventHandler formDisposedHandler = null;
                formDisposedHandler = (sender, e) =>
                {
                    // Thực hiện loadData() sau khi form đã bị giải phóng
                    loadData();

                    // Hủy đăng ký sự kiện FormDisposed để tránh xảy ra nhiều lần
                    f.Disposed -= formDisposedHandler;
                };

                f.Disposed += formDisposedHandler;
                f.Show();
            }
        }

        // Load lại data
        public void loadData()
        {
            dataTable.Clear();
            dtgv_nhanVien.DataSource = dataTable;
            List<KhachHang> listNV = khDB.DsKhachHang();

            foreach (KhachHang k in listNV)
            {
                string diachi = "";
                if (k.DiaChi.SoNha != "")
                    diachi = $"{k.DiaChi.SoNha}, {k.DiaChi.Duong}, {k.DiaChi.PhuongXa}, {k.DiaChi.QuanHuyen}, {k.DiaChi.TinhThanh}";
                dataTable.Rows.Add(k.Id, k.HoTen, k.CCCD, k.SDT, k.Email, k.GioiTinh, k.QuocTich, k.NgaySinh, diachi);
            }
            dtgv_nhanVien.DataSource = dataTable;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            List<KhachHang> listNV = khDB.findKhachHang(txt_search.Text);
            dataTable.Clear();
            dtgv_nhanVien.DataSource = dataTable;

            foreach (KhachHang k in listNV)
            {
                string diachi = $"{k.DiaChi.SoNha}, {k.DiaChi.Duong}, {k.DiaChi.PhuongXa}, {k.DiaChi.QuanHuyen}, {k.DiaChi.TinhThanh}";
                dataTable.Rows.Add(k.Id, k.HoTen, k.CCCD, k.GioiTinh, k.QuocTich, k.NgaySinh, diachi);
            }
            dtgv_nhanVien.DataSource = dataTable;
        }
    }
}
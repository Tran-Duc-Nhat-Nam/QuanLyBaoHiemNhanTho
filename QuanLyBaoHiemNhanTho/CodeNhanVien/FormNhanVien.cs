using MongoDB.Bson;
using MongoDB.Driver;
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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }
        DataTable dataTable = new DataTable();
        private async void FormNhanVien_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("_id", typeof(string));
            dataTable.Columns.Add("HoTen", typeof(string));
            dataTable.Columns.Add("CCCD", typeof(string));
            dataTable.Columns.Add("TrangThai", typeof(string));
            dataTable.Columns.Add("MatKhau", typeof(string));
            dataTable.Columns.Add("GioiTinh", typeof(string));
            dataTable.Columns.Add("QuocTich", typeof(string));
            dataTable.Columns.Add("SDT", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Ngaysinh", typeof(DateTime));
            dataTable.Columns.Add("DiaChi", typeof(string));
            loadData();
        }

        public void loadData()
        {
            //var client = new MongoClient("mongodb://localhost:27017");
            //var database = client.GetDatabase("QuanLyBaoHiem");
            //var collection = database.GetCollection<BsonDocument>("NhanVien");

            dataTable.Clear();
            dataGridView1.DataSource = dataTable;
            List<NhanVien> listNV = srNV.dsNhanVien();

            foreach (NhanVien NV in listNV)
            {
                string diachi = "";
                if (NV.DiaChi.SoNha != "")
                    diachi = $"{NV.DiaChi.SoNha}, {NV.DiaChi.Duong}, {NV.DiaChi.PhuongXa}, {NV.DiaChi.QuanHuyen}, {NV.DiaChi.TinhThanh}";
                dataTable.Rows.Add(NV.Id, NV.HoTen, NV.CCCD, NV.TrangThai, NV.MatKhau, NV.GioiTinh, NV.QuocTich, NV.SDT, NV.Email, NV.NgaySinh, diachi);
            }
            dataGridView1.DataSource = dataTable;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemNhanVien f = new ThemNhanVien();
            loadData();
            f.Show();
            this.Visible = false;
        }
        CodeNhanVien.Controler.ServiceNhanVien srNV = new CodeNhanVien.Controler.ServiceNhanVien();
        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            //Xóa nhân viên không cập nhật ở hợp đồng

            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            if (row != null)
            {
                string id = row.Cells["_id"].Value.ToString();
                List<HopDong> dsHD = srNV.dsHDisNV(id);
                if (dsHD.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Nhân viên đang quản lý hợp đồng, bạn không thể xóa ?", "Xác nhận");

                    //// Kiểm tra phản hồi từ người dùng
                    //if (result == DialogResult.Yes)
                    //{

                    //    srNV.xoaNhanVien(id);
                    //    MessageBox.Show("Xóa nhân viên thành công !");
                    //}
                    //else
                    //{
                    //    return;
                    //}
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn muốn xóa nhân viên này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        srNV.xoaNhanVien(id);
                        loadData();
                        MessageBox.Show("Xóa nhân viên thành công !");
                    }
                    else
                    {
                        return;
                    }
                }

            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string id = row.Cells["_id"].Value.ToString();
                NhanVien nv = new NhanVien();
                nv = srNV.findNhanVienID(id);
                FormSuaNhanVien frmSua = new FormSuaNhanVien(nv);
                this.Visible = false;
                frmSua.Show();
                loadData();
            }
            else
            {
                MessageBox.Show("Chưa sửa được", "Thông báo");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void txt_timNV_TextChanged(object sender, EventArgs e)
        {
            List<NhanVien> nv = srNV.findNhanVien(txt_timNV.Text);
            dataTable.Clear();
            dataGridView1.DataSource = dataTable;
            foreach (NhanVien NV in nv)
            {
                string diachi = $"{NV.DiaChi.SoNha}, {NV.DiaChi.Duong}, {NV.DiaChi.PhuongXa}, {NV.DiaChi.QuanHuyen}, {NV.DiaChi.TinhThanh}";
                dataTable.Rows.Add(NV.Id, NV.HoTen, NV.CCCD, NV.TrangThai, NV.MatKhau, NV.GioiTinh, NV.QuocTich, NV.SDT, NV.Email, NV.NgaySinh, diachi);
            }
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Kiểm tra xem có dòng nào được chọn không
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                //Lấy giá trị từ các ô trong dòng được chọn
                string value1 = row.Cells["_id"].Value.ToString();
                string value2 = row.Cells["HoTen"].Value.ToString();
                string value3 = row.Cells["NgaySinh"].Value.ToString();
                string value4 = row.Cells["CCCD"].Value.ToString();
                string value5 = row.Cells["GioiTinh"].Value.ToString();
                string value6 = row.Cells["Email"].Value.ToString();
                string value7 = row.Cells["SDT"].Value.ToString();
                string value8 = row.Cells["TrangThai"].Value.ToString();

                //Hiển thị giá trị lên TextBox
                textBox1.Text = value1;
                textBox2.Text = value2;
                textBox3.Text = value3;
                textBox4.Text = value4;
                textBox5.Text = value5;
                textBox6.Text = value6;
                textBox8.Text = value7;
                textBox7.Text = value8;
            }
        }
    }
}

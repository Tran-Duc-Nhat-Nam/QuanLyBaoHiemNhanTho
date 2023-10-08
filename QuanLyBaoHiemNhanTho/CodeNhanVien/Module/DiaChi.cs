namespace QuanLyBaoHienNhanTho.CodeNhanVien.Module
{
    public class DiaChi
    {
        public DiaChi(string soNha, string duong, string phuongXa, string quanHuyen, string tinhThanh)
        {
            SoNha = soNha;
            Duong = duong;
            PhuongXa = phuongXa;
            QuanHuyen = quanHuyen;
            TinhThanh = tinhThanh;
        }

        public string SoNha { get; set; }
        public string Duong { get; set; }
        public string PhuongXa { get; set; }
        public string QuanHuyen { get; set; }
        public string TinhThanh { get; set; }


    }
}
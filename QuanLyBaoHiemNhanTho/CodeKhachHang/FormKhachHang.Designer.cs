namespace QuanLyBaoHiemNhanTho
{
    partial class FormKhachHang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgv_nhanVien = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            CCCD = new DataGridViewTextBoxColumn();
            SoDT = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            QuocTich = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            btn_them = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            label1 = new Label();
            txt_search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgv_nhanVien).BeginInit();
            SuspendLayout();
            // 
            // dtgv_nhanVien
            // 
            dtgv_nhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_nhanVien.Columns.AddRange(new DataGridViewColumn[] { ID, HoTen, CCCD, SoDT, Email, GioiTinh, QuocTich, NgaySinh, DiaChi });
            dtgv_nhanVien.Location = new Point(87, 127);
            dtgv_nhanVien.Name = "dtgv_nhanVien";
            dtgv_nhanVien.RowHeadersWidth = 51;
            dtgv_nhanVien.RowTemplate.Height = 29;
            dtgv_nhanVien.Size = new Size(1063, 396);
            dtgv_nhanVien.TabIndex = 0;
            dtgv_nhanVien.SelectionChanged += dtgv_nhanVien_SelectionChanged;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "Mã khách hàng";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Tên khách hàng";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.Width = 170;
            // 
            // CCCD
            // 
            CCCD.DataPropertyName = "CCCD";
            CCCD.HeaderText = "CCCD";
            CCCD.MinimumWidth = 6;
            CCCD.Name = "CCCD";
            CCCD.Width = 125;
            // 
            // SoDT
            // 
            SoDT.DataPropertyName = "SDT";
            SoDT.HeaderText = "SDT";
            SoDT.MinimumWidth = 6;
            SoDT.Name = "SoDT";
            SoDT.Width = 125;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Gmail";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Width = 75;
            // 
            // QuocTich
            // 
            QuocTich.DataPropertyName = "QuocTich";
            QuocTich.HeaderText = "Quốc tịch";
            QuocTich.MinimumWidth = 6;
            QuocTich.Name = "QuocTich";
            QuocTich.Width = 120;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Width = 125;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.Width = 230;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(344, 546);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(137, 74);
            btn_them.TabIndex = 1;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(560, 546);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(137, 74);
            btn_xoa.TabIndex = 2;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(800, 546);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(137, 74);
            btn_sua.TabIndex = 3;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(510, 25);
            label1.Name = "label1";
            label1.Size = new Size(187, 41);
            label1.TabIndex = 4;
            label1.Text = "Khách Hàng";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(442, 69);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(323, 27);
            txt_search.TabIndex = 37;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 648);
            Controls.Add(txt_search);
            Controls.Add(label1);
            Controls.Add(btn_sua);
            Controls.Add(btn_xoa);
            Controls.Add(btn_them);
            Controls.Add(dtgv_nhanVien);
            Name = "FormKhachHang";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_nhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgv_nhanVien;
        private Button btn_them;
        private Button btn_xoa;
        private Button btn_sua;
        private Label label1;
        private TextBox txt_search;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn CCCD;
        private DataGridViewTextBoxColumn SoDT;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn QuocTich;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn DiaChi;
    }
}
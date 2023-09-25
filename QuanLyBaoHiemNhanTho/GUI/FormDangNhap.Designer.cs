namespace QuanLyBaoHiemNhanTho.GUI
{
    partial class FormDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTaiKhoan = new Krypton.Toolkit.KryptonTextBox();
            txtMatKhau = new Krypton.Toolkit.KryptonTextBox();
            btnDangNhap = new Krypton.Toolkit.KryptonButton();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            SuspendLayout();
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(584, 71);
            label3.TabIndex = 13;
            label3.Text = " Đăng nhập";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 169);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 11;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 116);
            label1.Name = "label1";
            label1.Padding = new Padding(6);
            label1.Size = new Size(113, 33);
            label1.TabIndex = 10;
            label1.Text = "Tên tài khoản";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(132, 116);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(421, 39);
            txtTaiKhoan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTaiKhoan.StateCommon.Border.Rounding = 25F;
            txtTaiKhoan.TabIndex = 16;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(132, 169);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(421, 39);
            txtMatKhau.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtMatKhau.StateCommon.Border.Rounding = 25F;
            txtMatKhau.TabIndex = 18;
            // 
            // btnDangNhap
            // 
            btnDangNhap.CornerRoundingRadius = 25F;
            btnDangNhap.Location = new Point(175, 271);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.OverrideDefault.Back.Color1 = Color.DodgerBlue;
            btnDangNhap.OverrideDefault.Back.Color2 = Color.DodgerBlue;
            btnDangNhap.OverrideDefault.Content.ShortText.Color1 = Color.White;
            btnDangNhap.OverrideDefault.Content.ShortText.Color2 = Color.White;
            btnDangNhap.OverrideFocus.Back.Color1 = Color.White;
            btnDangNhap.OverrideFocus.Back.Color2 = Color.White;
            btnDangNhap.OverrideFocus.Content.ShortText.Color1 = Color.DodgerBlue;
            btnDangNhap.OverrideFocus.Content.ShortText.Color2 = Color.DodgerBlue;
            btnDangNhap.Size = new Size(250, 39);
            btnDangNhap.StateCommon.Back.Color1 = Color.DodgerBlue;
            btnDangNhap.StateCommon.Back.Color2 = Color.DodgerBlue;
            btnDangNhap.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDangNhap.StateCommon.Border.Rounding = 25F;
            btnDangNhap.StateCommon.Content.ShortText.Color1 = Color.White;
            btnDangNhap.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.StateNormal.Back.Color1 = Color.DodgerBlue;
            btnDangNhap.StatePressed.Back.Color1 = Color.White;
            btnDangNhap.StatePressed.Back.Color2 = Color.White;
            btnDangNhap.StatePressed.Content.ShortText.Color1 = Color.DodgerBlue;
            btnDangNhap.StatePressed.Content.ShortText.Color2 = Color.DodgerBlue;
            btnDangNhap.StateTracking.Back.Color1 = Color.White;
            btnDangNhap.StateTracking.Back.Color2 = Color.White;
            btnDangNhap.StateTracking.Border.Color1 = Color.DodgerBlue;
            btnDangNhap.StateTracking.Border.Color2 = Color.DodgerBlue;
            btnDangNhap.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDangNhap.StateTracking.Content.LongText.Color1 = Color.DodgerBlue;
            btnDangNhap.StateTracking.Content.LongText.Color2 = Color.DodgerBlue;
            btnDangNhap.StateTracking.Content.ShortText.Color1 = Color.DodgerBlue;
            btnDangNhap.StateTracking.Content.ShortText.Color2 = Color.DodgerBlue;
            btnDangNhap.TabIndex = 20;
            btnDangNhap.Values.Text = "Đăng nhập";
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.White;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.White;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 15F;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.White;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.White;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 361);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDangNhap";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShadowValues.Colour = Color.Black;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Krypton.Toolkit.KryptonTextBox txtTaiKhoan;
        private Krypton.Toolkit.KryptonTextBox txtMatKhau;
        private Krypton.Toolkit.KryptonButton btnDangNhap;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}
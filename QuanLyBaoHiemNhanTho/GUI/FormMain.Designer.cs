namespace QuanLyBaoHiemNhanTho.GUI
{
    partial class FormMain
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
            menuStrip1 = new MenuStrip();
            smiHoSo = new ToolStripMenuItem();
            smiKhachHang = new ToolStripMenuItem();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { smiHoSo, smiKhachHang });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1064, 35);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // smiHoSo
            // 
            smiHoSo.BackColor = Color.LightCyan;
            smiHoSo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            smiHoSo.ForeColor = Color.White;
            smiHoSo.Name = "smiHoSo";
            smiHoSo.Size = new Size(55, 31);
            smiHoSo.Text = "Hồ sơ";
            // 
            // smiKhachHang
            // 
            smiKhachHang.Name = "smiKhachHang";
            smiKhachHang.Size = new Size(82, 31);
            smiKhachHang.Text = "Khách hàng";
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.AllowFormChrome = Krypton.Toolkit.InheritBool.True;
            kryptonPalette1.BasePaletteMode = Krypton.Toolkit.PaletteMode.Office365BlackDarkMode;
            kryptonPalette1.BaseRenderMode = Krypton.Toolkit.RendererMode.Office365;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.White;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.White;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12F;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.White;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.White;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = Color.White;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = Color.White;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = Color.Black;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color2 = Color.Black;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(1064, 681);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảo hiểm nhân thọ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem smiHoSo;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ToolStripMenuItem smiKhachHang;
    }
}
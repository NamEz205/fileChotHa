namespace ThucTapChuan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNhanSu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKhoHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSP = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhaCC = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoaDonXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBC_NhanSu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBC_SP = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.báoCáoThốngKêToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1323, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông Tin Tài Khoản";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.thôngTinToolStripMenuItem.Text = "Thông tin ";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNhanSu,
            this.MenuKhoHang,
            this.menuSP,
            this.menuKH,
            this.menuNhaCC});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            this.quảnLýToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.quảnLýToolStripMenuItem_DropDownItemClicked);
            // 
            // MenuNhanSu
            // 
            this.MenuNhanSu.Name = "MenuNhanSu";
            this.MenuNhanSu.Size = new System.Drawing.Size(160, 22);
            this.MenuNhanSu.Text = "Nhân Sự";
            this.MenuNhanSu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.nhânSựToolStripMenuItem_DropDownItemClicked);
            this.MenuNhanSu.Click += new System.EventHandler(this.nhânSựToolStripMenuItem_Click);
            // 
            // MenuKhoHang
            // 
            this.MenuKhoHang.Name = "MenuKhoHang";
            this.MenuKhoHang.Size = new System.Drawing.Size(160, 22);
            this.MenuKhoHang.Text = "Kho Hàng";
            // 
            // menuSP
            // 
            this.menuSP.Name = "menuSP";
            this.menuSP.Size = new System.Drawing.Size(160, 22);
            this.menuSP.Text = "Menu sản phẩm";
            // 
            // menuKH
            // 
            this.menuKH.Name = "menuKH";
            this.menuKH.Size = new System.Drawing.Size(160, 22);
            this.menuKH.Text = "Khách Hàng";
            // 
            // menuNhaCC
            // 
            this.menuNhaCC.Name = "menuNhaCC";
            this.menuNhaCC.Size = new System.Drawing.Size(160, 22);
            this.menuNhaCC.Text = "Nhà cung cấp";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHoaDonXuat,
            this.menuHoaDonNhap});
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            this.hóaĐơnToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.hóaĐơnToolStripMenuItem_DropDownItemClicked);
            // 
            // menuHoaDonXuat
            // 
            this.menuHoaDonXuat.Name = "menuHoaDonXuat";
            this.menuHoaDonXuat.Size = new System.Drawing.Size(180, 22);
            this.menuHoaDonXuat.Text = "Hóa Đơn Xuất";
            this.menuHoaDonXuat.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuHoaDonXuat_DropDownItemClicked);
            // 
            // menuHoaDonNhap
            // 
            this.menuHoaDonNhap.Name = "menuHoaDonNhap";
            this.menuHoaDonNhap.Size = new System.Drawing.Size(180, 22);
            this.menuHoaDonNhap.Text = "Hóa Đơn Nhập";
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBC_NhanSu,
            this.menuBC_SP});
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Báo Cáo- Thống kê";
            this.báoCáoThốngKêToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.báoCáoThốngKêToolStripMenuItem_DropDownItemClicked);
            // 
            // menuBC_NhanSu
            // 
            this.menuBC_NhanSu.Name = "menuBC_NhanSu";
            this.menuBC_NhanSu.Size = new System.Drawing.Size(127, 22);
            this.menuBC_NhanSu.Text = "Nhân Sự";
            // 
            // menuBC_SP
            // 
            this.menuBC_SP.Name = "menuBC_SP";
            this.menuBC_SP.Size = new System.Drawing.Size(127, 22);
            this.menuBC_SP.Text = "Sản phẩm";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Thoat,
            this.menu_DangXuat});
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.thoátToolStripMenuItem_DropDownItemClicked);
            // 
            // menu_Thoat
            // 
            this.menu_Thoat.Name = "menu_Thoat";
            this.menu_Thoat.Size = new System.Drawing.Size(128, 22);
            this.menu_Thoat.Text = "Thoát";
            // 
            // menu_DangXuat
            // 
            this.menu_DangXuat.Name = "menu_DangXuat";
            this.menu_DangXuat.Size = new System.Drawing.Size(128, 22);
            this.menu_DangXuat.Text = "Đăng xuất";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 760);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuNhanSu;
        private System.Windows.Forms.ToolStripMenuItem MenuKhoHang;
        private System.Windows.Forms.ToolStripMenuItem menuSP;
        private System.Windows.Forms.ToolStripMenuItem menuKH;
        private System.Windows.Forms.ToolStripMenuItem menuNhaCC;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBC_NhanSu;
        private System.Windows.Forms.ToolStripMenuItem menuBC_SP;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_Thoat;
        private System.Windows.Forms.ToolStripMenuItem menu_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHoaDonXuat;
        private System.Windows.Forms.ToolStripMenuItem menuHoaDonNhap;
    }
}
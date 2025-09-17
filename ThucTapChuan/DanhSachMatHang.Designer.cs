namespace ThucTapChuan
{
    partial class menuSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuSP));
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.htHangHoa = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grDSHangHoa = new System.Windows.Forms.GroupBox();
            this.txtGiaSP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.htHangHoa)).BeginInit();
            this.grDSHangHoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(264, 138);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(273, 20);
            this.txtMaSP.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(952, 370);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(133, 20);
            this.txtTimKiem.TabIndex = 2;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(264, 189);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(273, 20);
            this.txtTenSP.TabIndex = 4;
            // 
            // htHangHoa
            // 
            this.htHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.htHangHoa.Location = new System.Drawing.Point(-30, 487);
            this.htHangHoa.Name = "htHangHoa";
            this.htHangHoa.Size = new System.Drawing.Size(1247, 352);
            this.htHangHoa.TabIndex = 5;
            this.htHangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.htHangHoa.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.htHangHoa_DataError);
            // 
            // btThem
            // 
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(190, 355);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 36);
            this.btThem.TabIndex = 6;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(614, 354);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 36);
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(397, 354);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 36);
            this.btSua.TabIndex = 8;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimKiem.Image")));
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(859, 354);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(87, 35);
            this.btTimKiem.TabIndex = 9;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Giá sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên sản phẩm";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(457, 284);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(273, 20);
            this.txtGhiChu.TabIndex = 13;
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.Location = new System.Drawing.Point(772, 192);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.Size = new System.Drawing.Size(273, 20);
            this.txtHinhAnh.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(708, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hình Ảnh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ghi chú";
            // 
            // grDSHangHoa
            // 
            this.grDSHangHoa.Controls.Add(this.txtGiaSP);
            this.grDSHangHoa.Controls.Add(this.txtMaSP);
            this.grDSHangHoa.Controls.Add(this.htHangHoa);
            this.grDSHangHoa.Controls.Add(this.btThem);
            this.grDSHangHoa.Controls.Add(this.btSua);
            this.grDSHangHoa.Controls.Add(this.btTimKiem);
            this.grDSHangHoa.Controls.Add(this.btXoa);
            this.grDSHangHoa.Controls.Add(this.label2);
            this.grDSHangHoa.Controls.Add(this.label5);
            this.grDSHangHoa.Controls.Add(this.label1);
            this.grDSHangHoa.Controls.Add(this.txtGhiChu);
            this.grDSHangHoa.Controls.Add(this.label4);
            this.grDSHangHoa.Controls.Add(this.txtTimKiem);
            this.grDSHangHoa.Controls.Add(this.txtTenSP);
            this.grDSHangHoa.Controls.Add(this.txtHinhAnh);
            this.grDSHangHoa.Controls.Add(this.label3);
            this.grDSHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDSHangHoa.Location = new System.Drawing.Point(0, 0);
            this.grDSHangHoa.Name = "grDSHangHoa";
            this.grDSHangHoa.Size = new System.Drawing.Size(1321, 839);
            this.grDSHangHoa.TabIndex = 17;
            this.grDSHangHoa.TabStop = false;
            this.grDSHangHoa.Text = "Danh sách sản phẩm";
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.Location = new System.Drawing.Point(772, 145);
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.Size = new System.Drawing.Size(273, 20);
            this.txtGiaSP.TabIndex = 17;
            // 
            // menuSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 839);
            this.Controls.Add(this.grDSHangHoa);
            this.Name = "menuSP";
            this.Text = "Danh Sách các mặt hàng";
            this.Load += new System.EventHandler(this.menuSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.htHangHoa)).EndInit();
            this.grDSHangHoa.ResumeLayout(false);
            this.grDSHangHoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.DataGridView htHangHoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grDSHangHoa;
        private System.Windows.Forms.TextBox txtGiaSP;
    }
}
namespace ThucTapChuan
{
    partial class formBC_NhanSu
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
            this.txtTongNV = new System.Windows.Forms.TextBox();
            this.txtSoNvNu = new System.Windows.Forms.TextBox();
            this.txtNhanVienConThieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoNvNam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.htNhanSu = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.htCaLamViec = new System.Windows.Forms.DataGridView();
            this.htLuongNV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuongCaDem = new System.Windows.Forms.TextBox();
            this.txtSoLuongCaNgay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongTienLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.htNhanSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.htCaLamViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.htLuongNV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTongNV
            // 
            this.txtTongNV.Location = new System.Drawing.Point(148, 410);
            this.txtTongNV.Name = "txtTongNV";
            this.txtTongNV.Size = new System.Drawing.Size(117, 20);
            this.txtTongNV.TabIndex = 0;
            this.txtTongNV.TextChanged += new System.EventHandler(this.txtTongNV_TextChanged);
            // 
            // txtSoNvNu
            // 
            this.txtSoNvNu.Location = new System.Drawing.Point(349, 460);
            this.txtSoNvNu.Name = "txtSoNvNu";
            this.txtSoNvNu.Size = new System.Drawing.Size(122, 20);
            this.txtSoNvNu.TabIndex = 1;
            // 
            // txtNhanVienConThieu
            // 
            this.txtNhanVienConThieu.Location = new System.Drawing.Point(148, 460);
            this.txtNhanVienConThieu.Name = "txtNhanVienConThieu";
            this.txtNhanVienConThieu.Size = new System.Drawing.Size(117, 20);
            this.txtNhanVienConThieu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng số nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số nhân viên còn thiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số nhân viên nữ";
            // 
            // txtSoNvNam
            // 
            this.txtSoNvNam.Location = new System.Drawing.Point(349, 410);
            this.txtSoNvNam.Name = "txtSoNvNam";
            this.txtSoNvNam.Size = new System.Drawing.Size(122, 20);
            this.txtSoNvNam.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số nhân viên Nam";
            // 
            // htNhanSu
            // 
            this.htNhanSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.htNhanSu.Location = new System.Drawing.Point(23, 521);
            this.htNhanSu.Name = "htNhanSu";
            this.htNhanSu.Size = new System.Drawing.Size(550, 253);
            this.htNhanSu.TabIndex = 8;
            this.htNhanSu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.htNhanSu_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Danh sách nhân sự hiện tại";
            // 
            // htCaLamViec
            // 
            this.htCaLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.htCaLamViec.Location = new System.Drawing.Point(623, 521);
            this.htCaLamViec.Name = "htCaLamViec";
            this.htCaLamViec.Size = new System.Drawing.Size(412, 253);
            this.htCaLamViec.TabIndex = 10;
            this.htCaLamViec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // htLuongNV
            // 
            this.htLuongNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.htLuongNV.Location = new System.Drawing.Point(1090, 521);
            this.htLuongNV.Name = "htLuongNV";
            this.htLuongNV.Size = new System.Drawing.Size(526, 253);
            this.htLuongNV.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(738, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ca làm việc của nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1341, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Lương nhân viên";
            // 
            // txtSoLuongCaDem
            // 
            this.txtSoLuongCaDem.Location = new System.Drawing.Point(1321, 460);
            this.txtSoLuongCaDem.Name = "txtSoLuongCaDem";
            this.txtSoLuongCaDem.Size = new System.Drawing.Size(128, 20);
            this.txtSoLuongCaDem.TabIndex = 14;
            // 
            // txtSoLuongCaNgay
            // 
            this.txtSoLuongCaNgay.Location = new System.Drawing.Point(1476, 460);
            this.txtSoLuongCaNgay.Name = "txtSoLuongCaNgay";
            this.txtSoLuongCaNgay.Size = new System.Drawing.Size(117, 20);
            this.txtSoLuongCaNgay.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1340, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Số lượng ca đêm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1488, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Số Lượng ca ngày";
            // 
            // txtTongTienLuong
            // 
            this.txtTongTienLuong.Location = new System.Drawing.Point(1115, 460);
            this.txtTongTienLuong.Name = "txtTongTienLuong";
            this.txtTongTienLuong.Size = new System.Drawing.Size(150, 20);
            this.txtTongTienLuong.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1141, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tổng tiền lương";
            // 
            // formBC_NhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 842);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTongTienLuong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSoLuongCaNgay);
            this.Controls.Add(this.txtSoLuongCaDem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.htLuongNV);
            this.Controls.Add(this.htCaLamViec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.htNhanSu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoNvNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhanVienConThieu);
            this.Controls.Add(this.txtSoNvNu);
            this.Controls.Add(this.txtTongNV);
            this.Name = "formBC_NhanSu";
            this.Text = "BaoCaoNhanSu";
            this.Load += new System.EventHandler(this.BaoCaoNhanSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.htNhanSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htCaLamViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htLuongNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTongNV;
        private System.Windows.Forms.TextBox txtSoNvNu;
        private System.Windows.Forms.TextBox txtNhanVienConThieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoNvNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView htNhanSu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView htCaLamViec;
        private System.Windows.Forms.DataGridView htLuongNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuongCaDem;
        private System.Windows.Forms.TextBox txtSoLuongCaNgay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTongTienLuong;
        private System.Windows.Forms.Label label10;
    }
}
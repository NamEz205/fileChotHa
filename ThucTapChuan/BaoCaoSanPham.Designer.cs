namespace ThucTapChuan
{
    partial class BaoCaoSanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTienNhapHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.htNhap = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.htBan = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTienBanHang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.htNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.htBan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(195, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tình hình nhập hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(765, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tình hình bán hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTienNhapHang
            // 
            this.txtTienNhapHang.Location = new System.Drawing.Point(321, 761);
            this.txtTienNhapHang.Name = "txtTienNhapHang";
            this.txtTienNhapHang.Size = new System.Drawing.Size(100, 20);
            this.txtTienNhapHang.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 745);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "tổng số tiền nhập hàng";
            // 
            // htNhap
            // 
            this.htNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.htNhap.Location = new System.Drawing.Point(184, 415);
            this.htNhap.Name = "htNhap";
            this.htNhap.Size = new System.Drawing.Size(339, 285);
            this.htNhap.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Danh sách sản phẩm đã nhập";
            // 
            // htBan
            // 
            this.htBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.htBan.Location = new System.Drawing.Point(765, 413);
            this.htBan.Name = "htBan";
            this.htBan.Size = new System.Drawing.Size(339, 285);
            this.htBan.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(860, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Danh sách sản phẩm đã bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(890, 745);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Doanh thu theo sản phẩm";
            // 
            // txtTienBanHang
            // 
            this.txtTienBanHang.Location = new System.Drawing.Point(905, 761);
            this.txtTienBanHang.Name = "txtTienBanHang";
            this.txtTienBanHang.Size = new System.Drawing.Size(100, 20);
            this.txtTienBanHang.TabIndex = 9;
            // 
            // BaoCaoSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 847);
            this.Controls.Add(this.txtTienBanHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.htBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.htNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTienNhapHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BaoCaoSanPham";
            this.Text = "BaoCaoSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.htNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTienNhapHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView htNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView htBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTienBanHang;
    }
}
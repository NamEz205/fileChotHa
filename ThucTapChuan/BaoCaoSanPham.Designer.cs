namespace ThucTapChuan
{
    partial class formBC_SP
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
            // txtTienNhapHang
            // 
            this.txtTienNhapHang.Location = new System.Drawing.Point(439, 347);
            this.txtTienNhapHang.Name = "txtTienNhapHang";
            this.txtTienNhapHang.Size = new System.Drawing.Size(143, 20);
            this.txtTienNhapHang.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "tổng số tiền nhập hàng";
            // 
            // htNhap
            // 
            this.htNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.htNhap.Location = new System.Drawing.Point(123, 415);
            this.htNhap.Name = "htNhap";
            this.htNhap.Size = new System.Drawing.Size(459, 393);
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
            this.htBan.Location = new System.Drawing.Point(765, 415);
            this.htBan.Name = "htBan";
            this.htBan.Size = new System.Drawing.Size(491, 393);
            this.htBan.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(959, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Danh sách sản phẩm đã bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1142, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tổng số tiền bán hàng";
            // 
            // txtTienBanHang
            // 
            this.txtTienBanHang.Location = new System.Drawing.Point(1129, 347);
            this.txtTienBanHang.Name = "txtTienBanHang";
            this.txtTienBanHang.Size = new System.Drawing.Size(127, 20);
            this.txtTienBanHang.TabIndex = 9;
            // 
            // formBC_SP
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
            this.Name = "formBC_SP";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.htNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
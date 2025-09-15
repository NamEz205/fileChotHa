namespace ThucTapChuan
{
    partial class FormLogin
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
            this.btDangNhap = new System.Windows.Forms.Button();
            this.btDangKi = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHienMK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(189, 335);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btDangNhap.TabIndex = 0;
            this.btDangNhap.Text = "Đăng Nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // btDangKi
            // 
            this.btDangKi.Location = new System.Drawing.Point(370, 335);
            this.btDangKi.Name = "btDangKi";
            this.btDangKi.Size = new System.Drawing.Size(75, 23);
            this.btDangKi.TabIndex = 1;
            this.btDangKi.Text = "Đăng kí";
            this.btDangKi.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(208, 138);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(256, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(208, 227);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '.';
            this.txtpassword.Size = new System.Drawing.Size(256, 20);
            this.txtpassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // cbHienMK
            // 
            this.cbHienMK.AutoSize = true;
            this.cbHienMK.Location = new System.Drawing.Point(208, 285);
            this.cbHienMK.Name = "cbHienMK";
            this.cbHienMK.Size = new System.Drawing.Size(95, 17);
            this.cbHienMK.TabIndex = 7;
            this.cbHienMK.Text = "Hiện mật khẩu";
            this.cbHienMK.UseVisualStyleBackColor = true;
            this.cbHienMK.CheckedChanged += new System.EventHandler(this.cbHienMK_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 526);
            this.Controls.Add(this.cbHienMK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btDangKi);
            this.Controls.Add(this.btDangNhap);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Button btDangKi;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbHienMK;
    }
}


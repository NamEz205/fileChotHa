using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapChuan
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        connetcdata c = new connetcdata();
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            c.connect();
            string mk = txtpassword.Text;
            string tk = txtUsername.Text;
            SqlCommand cmd = new SqlCommand("Select * From DangNhap where TaiKhoan = '" + tk + "'" + "and MatKhau = '" + mk +"'", c.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (txtpassword.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("ban can dien tai khoan va mat khau", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (dr.Read() == true) { 
            this.Hide();
                FormMain formMain = new FormMain();
                formMain.ShowDialog();
                formMain = null;
                txtpassword.Text = "";
                this.Show();
            }
        }
    }
}

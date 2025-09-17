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
    public partial class formNhaCungCap : Form
    {
        public formNhaCungCap()
        {
            InitializeComponent();
        }
        connetcdata c = new connetcdata();  
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       public void loadNhaCungCap()
        {
            htNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            c.connect();
            DataSet ds = new DataSet();
            string sql = "select MaNCC as N'mã nhà cung cấp', TenNCC as N'Tên nhà cung cấp', SDT as N'Số điện thoại', DiaChi as N'Địa chỉ', GhiChu N'Ghi chú' from NhaCungCap";
            SqlDataAdapter da = new SqlDataAdapter(sql, c.conn);
            da.Fill(ds);
            htNhaCungCap.DataSource = ds.Tables[0];
        }
        private void formNhaCungCap_Load(object sender, EventArgs e)
        {
    loadNhaCungCap();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            c.connect();
            string sql = "insert into NhaCungCap(MaNCC, TenNCC, SDT, DiaChi, GhiChu) values ('" + txtMaNhaCC.Text + "', '" + txtTenNHacc.Text + "', '" + txtSDT.Text + "', '" + txtDiaChi.Text + "', '" + txtGhiChu + "')";
            bool kq = c.exeSQL(sql);
            if (kq)
            {
                MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK);
            }
            loadNhaCungCap();
            c.disconnect();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            c.connect();
            string sql = "update NhaCungCap set TenNCC = '" + txtTenNHacc.Text + "', SDT = '" + txtSDT.Text + "', DiaChi = '" + txtDiaChi.Text + "', GhiChu = '" + txtGhiChu.Text + "' where MaNCC = '" + txtMaNhaCC.Text + "'";
        bool kq = c.exeSQL(sql);
            if (kq)
            {
                MessageBox.Show("Cập nhật thành công mã nhà cung cấp '" + txtMaNhaCC.Text + "'", "", MessageBoxButtons.OK);
            }
            loadNhaCungCap();
            c.disconnect(); 
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            c.connect();
            string sql = "delete from NhaCungCap where MaNCC = '" + txtMaNhaCC.Text + "' ";
            bool kq = c.exeSQL(sql);
            if (kq) {
                MessageBox.Show("Bạn vừa xóa thành công nhà cung cấp có mã '" + txtMaNhaCC.Text + "'", "", MessageBoxButtons.OK);
            }
            loadNhaCungCap();
            c.disconnect();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            c.connect();
            DataSet ds = new DataSet();
            string sql = "select * from NhaCungCap where MaNCC = '" + txtTimKiem.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, c.conn);
            da.Fill(ds);
            htNhaCungCap.DataSource = ds.Tables[0];

        }
    }
}

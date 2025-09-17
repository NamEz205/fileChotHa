using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapChuan
{
    public partial class menuSP : Form
    {
        public menuSP()
        {
            InitializeComponent();
        }

        connetcdata c = new connetcdata();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        public void loadHangHoa()
        {
            htHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            c.connect();

            DataSet da = new DataSet();
            string sql = "select MaSP as N'Mã sản phẩm', TenSP as N'Tên sản phẩm', Anh as N'Hình ảnh', GiaSP as N'Giá sản phẩm', GhiChu as N'Ghi chú' from HangHoa";
            SqlDataAdapter dt = new SqlDataAdapter(sql, c.conn);
            dt.Fill(da);
            htHangHoa.DataSource = da.Tables[0];
            c.disconnect();

        }

        private void menuSP_Load(object sender, EventArgs e)
        {
            loadHangHoa();
        }

        private void htHangHoa_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;   // tắt thông báo popup
            e.Cancel = true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            c.connect();
            string sql = "insert into HangHoa(MaSP, TenSP, GiaSP, Anh, GhiChu) " +
                "values( '" + txtMaSP.Text + "', N'" + txtTenSP.Text + "', '" + txtGiaSP.Text + "', '" + txtHinhAnh.Text + "', '" + txtGhiChu.Text + "')";

            bool kq = c.exeSQL(sql);
            if (kq) 
            { 
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK); 
            }
            else 
            { 
                MessageBox.Show("thêm thất bại", "thông báo", MessageBoxButtons.OK); 
            }
            loadHangHoa();
            c.disconnect();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            c.connect();
            string sql = "update HangHoa set " + " TenSP = '" + txtTenSP.Text + "', " + " GiaSP = '" + txtGiaSP.Text + "', " + " Anh = '" + txtHinhAnh.Text + "', " + " GhiChu = '" + txtGhiChu.Text + "'" +
                " where " + " MaSP = '" + txtMaSP.Text + "'";

            bool kq = c.exeSQL(sql);
            if (kq)
            {
                MessageBox.Show("Sửa thành công mã sản phẩm '" + txtMaSP.Text + "'", "Thông báo", MessageBoxButtons.OK);
            }
            loadHangHoa() ;
            c.disconnect();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            c.connect();
            string sql = "delete from HangHoa "+" where " + " MaSP ='" + txtMaSP.Text + "'";
            bool kq1 = c.exeSQL(sql);
            if (kq1)
            {
                MessageBox.Show("Xóa thành công mã sản phẩm '" + txtMaSP.Text + "'", "Thông báo", MessageBoxButtons.OK);
            }
            loadHangHoa();
            c.disconnect();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            c.connect();
            DataSet ds = new DataSet();
            string sql = "select * from HangHoa where "+"MaSP = '"+txtTimKiem.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, c.conn);
            da.Fill(ds);
            htHangHoa.DataSource = ds.Tables[0];
            c.disconnect();
        }
    }
}

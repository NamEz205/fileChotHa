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
    public partial class menuKhachHang : Form
    {
        public menuKhachHang()
        {
            InitializeComponent();
        }
        connetcdata c = new connetcdata();
        private void btThem_Click(object sender, EventArgs e)
        {
            c.connect();
            string sql = "insert into KhachHang(MaKh, MaLKH, TenKH, DiaChi, SDT, GioiTinh, GhiChu) values ('" + txtMaKH.Text + "', '" + cbMaLoaiKH.Text + "', N'" + txtTenKH.Text + "', '" + txtDiaChi.Text + "', '" + txtSDT.Text + "', N'" + cbGioiTinh.Text + "', '" + txtGhiChu.Text + "')";
            bool kq = c.exeSQL(sql);
            if (kq)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            }
            c.disconnect();
            loadKhachHang();

        }

        private void htKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadKhachHang()
        {
            htKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            c.connect();
            DataSet ds = new DataSet();
            string sql = "select K.MaKH as N'Mã khách hang', k.MaLKH as N'Mã loại khách hang', k.TenKH as N'Tên khách hàng', k.DiaChi as N'Địa chỉ', k.SDT as N'Số điện thoại', k.GioiTinh as N'Giới tính', k.GhiChu as N'Ghi chú', l.TenLKH as N'Tên loại khách hàng', l.GiamGia as N'GiamGia'" +
                "from KhachHang k inner join LoaiKhachHang l on k.MaLKH = l.MaLKH";
            SqlDataAdapter da = new SqlDataAdapter(sql, c.conn);
            da.Fill(ds);
            c.disconnect();
            htKhachHang.DataSource = ds.Tables[0];

        }

        private void menuKhachHang_Load(object sender, EventArgs e)
        {
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbMaLoaiKH.Items.Add("01");
            cbMaLoaiKH.Items.Add("02");
            loadKhachHang();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            c.connect();
            string sql = "update KhachHang set "+"MaLKH = '"+cbMaLoaiKH.Text+"', "+"TenKH = '"+txtTenKH.Text+"', "+" DiaChi = '"+txtDiaChi.Text+"', "+"SDT = '"+txtSDT.Text+"', "+" GioiTinh = '"+cbGioiTinh.Text+"', "+"GhiChu = '"+txtGhiChu.Text+"' where "+"MaKH = '"+txtMaKH.Text+"' ";
        bool kq = c.exeSQL(sql);
            if (kq) 
            {
                MessageBox.Show("Cập nhật thành công mã khách hàng '" + txtMaKH.Text + "'", "Thông báo", MessageBoxButtons.OK);
            }
            loadKhachHang() ;
            c.disconnect();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            c.connect();
            string sql = "delete from KhachHang where " + "MaKH = '" + txtMaKH.Text + "'";
             bool kq = c.exeSQL(sql);
            if (kq)
            {
                MessageBox.Show("Bạn đã xóa Mã khách hàng '" + txtMaKH.Text + "'", "Thông báo", MessageBoxButtons.OK);
            }
            loadKhachHang() ;
            c.disconnect();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            c.connect();
            DataSet ds = new DataSet();
            string sql = "select K.MaKH as N'Mã khách hang', k.MaLKH as N'Mã loại khách hang', k.TenKH as N'Tên khách hàng', k.DiaChi as N'Địa chỉ', k.SDT as N'Số điện thoại', k.GioiTinh as N'Giới tính', k.GhiChu as N'Ghi chú', l.TenLKH as N'Tên loại khách hàng', l.GiamGia as N'GiamGia'" +
                "from KhachHang k inner join LoaiKhachHang l on k.MaLKH = l.MaLKH where "+"MaKH = '"+txtTimKiem.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, c.conn);
            da.Fill(ds);
            htKhachHang.DataSource = ds.Tables[0];
            c.disconnect();
        }
    }
}

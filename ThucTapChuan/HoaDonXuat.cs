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
    public partial class formHoaDonXuat : Form
    {
        public formHoaDonXuat()
        {
            InitializeComponent();
        }
        connetcdata c = new connetcdata();  

        public void loadHoaDonXuat()
        {
            htHoaDonXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            c.connect();
            DataSet ds = new DataSet();
            string sql = "select h.MaHD_BanHang as N'Mã hóa đơn', h.MaNV as N'Mã nhân viên', h.MaKH as N'mã khách hàng', h.NgayHDBH as N'Ngày bán', h.SoLuong as N'Số lượng', c.MaSP as N'Mã sản phẩm', h.GiamGia as N'Giảm giá', h.TongTien as N'Tổng tiền', h.GhiChu as N'Ghi chú' from HoaDon_BanHang h inner join ChiTietBanHang c on h.MaHD_BanHang = c.MaHD_BanHang ";
            SqlDataAdapter da = new SqlDataAdapter(sql, c.conn);
            da.Fill(ds);
            htHoaDonXuat.DataSource = ds.Tables[0];
            c.disconnect();
        }
        
        private void formHoaDonXuat_Load(object sender, EventArgs e)
        {
            loadHoaDonXuat();

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            c.connect();
            string sqlH = "insert into HoaDon_BanHang(MaHD_BanHang, MaNV, MaKH, NgayHDBH, SoLuong, GiamGia, TongTien, GhiChu) values ('" + txtMaHD.Text + "', '" + txtMaNV.Text + "', '" + txtMaKH.Text + "', '" + DateTime.Parse(dtNgayHD.Text).ToString("yyyy-MM-dd") + "', '" + txtSoLuong.Text + "', '" + txtGiamGia.Text + "', '" + txtTongTien.Text + "', '" + txtGhiChu.Text + "')";
            string sqlC = "insert into ChiTietBanHang(maHD_BanHang, MaSP, SoLuong, GhiChu) values ('" + txtMaHD.Text + "', '" + txtMaSP.Text + "', '" + txtSoLuong.Text + "', '" + txtGhiChu.Text + "')";
            bool kq = c.exeSQL(sqlH);
            if (kq)
            {
                bool kq2 = c.exeSQL(sqlC);
                if (kq2)
                {
                    MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK);
                }
            }
            loadHoaDonXuat();
            c.disconnect();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            c.connect();
            string sqlD = "update HoaDon_BanHang set MaNV = '" + txtMaNV.Text + "', MaKH = '" + txtMaKH.Text + "', NgayHDBH = '" + DateTime.Parse(dtNgayHD.Text).ToString("yyyy-MM-dd") + "', SoLuong = '" + txtSoLuong.Text + "', GiamGia = '" + txtGiamGia.Text + "', TongTien = '" + txtTongTien.Text + "', GhiChu = '" + txtGhiChu.Text + "' where MaHD_BanHang = '"+txtMaHD.Text+"'";
            string sqlC = "update ChiTietBanHang set MaSP = '" + txtMaSP.Text + "', SoLuong = '" + txtSoLuong.Text + "', GhiChu = '" + txtGhiChu.Text + "' where MaHD_BanHang = '" + txtMaHD.Text + "'";
        
        bool kq = c.exeSQL(sqlD);
            if (kq)
            {
                bool kq2 =(c.exeSQL(sqlC));
                if (kq2)
                {
                    MessageBox.Show("Cập nhật thành công", "", MessageBoxButtons.OK);
                }
            }
            loadHoaDonXuat();
            c.disconnect();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            c.connect();
            string sqlH = "delete from HoaDon_BanHang where MaHD_BanHang = '" + txtMaHD.Text + "'";
            string sqlC = "delete from ChiTietBanHang where MaHD_BanHang = '" + txtMaHD.Text + "'";

            bool kq = c.exeSQL(sqlC);
            if (kq)
            {
                bool kq1 =(c.exeSQL(sqlH));
                if (kq1)
                {
                    MessageBox.Show("Xóa thành công", "", MessageBoxButtons.OK );
                }
            }
            loadHoaDonXuat();
            c.disconnect(); 
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            c.connect();
            DataSet ds = new DataSet();
            string sql = "select h.MaHD_BanHang as N'Mã hóa đơn', h.MaNV as N'Mã nhân viên', h.MaKH as N'mã khách hàng', h.NgayHDBH as N'Ngày bán', h.SoLuong as N'Số lượng', c.MaSP as N'Mã sản phẩm', h.GiamGia as N'Giảm giá', h.TongTien as N'Tổng tiền', h.GhiChu as N'Ghi chú' from HoaDon_BanHang h inner join ChiTietBanHang c on h.MaHD_BanHang = c.MaHD_BanHang where h.MaHD_BanHang = '"+txtTimKiem.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, c.conn);
            da.Fill(ds);
            htHoaDonXuat.DataSource = ds.Tables[0];
            c.disconnect();

        }
    }
}

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
    public partial class NhanSu : Form
    {
        public NhanSu()
        {
            InitializeComponent();
        }

        connetcdata c = new connetcdata();
        private void label6_Click(object sender, EventArgs e)
        {

        }


        public void loadhtNhanSu()
        {
            htNhanSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            c.connect();
            DataSet ds = new DataSet();

            string sqlHienThi = "Select n.MaNV as N'Mã nhân viên', n.TenNV as N'Tên nhân viên', n.GioiTinh as N'Giới tính', n.ChucVu as N'Chức vụ', n.NgayVaoLam as N'Ngày vào làm', n.DiaChi as N'Địa chỉ', n.SDT as N'số điện thoại', l.MaCLV as N'mã ca làm', l.SoCaLam as N'Số ca làm', l.TongTien as N'Tổng lương', l.NgayNhanLuong as N'Ngày nhận'from NhanVien n INNER join LuongNhanVien l on n.MaNV = l.MaNV";
            SqlDataAdapter da = new SqlDataAdapter(sqlHienThi, c.conn);
            da.Fill(ds);
            htNhanSu.DataSource = ds.Tables[0];
            c.disconnect();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            c.connect();
            string queryNhanVien = "insert into NhanVien(MaNV, TenNV, GioiTinh, ChucVu, NgayVaoLam, DiaChi, SDT, GhiChu) " +
                " values( '" + txtMaNV.Text + "', N'" + txtTenNV.Text + "', N'" + cbGioitinh.Text + "', N'" + cbChucVu.Text + "', '" + DateTime.Parse(dtNgayBatDau.Text).ToString("yyyy-MM-dd") + "', N'" + txtDiaChi.Text + "', '" + txtSDT.Text + "', '" + txtGhiChu.Text + "')";
            string queryLuong = "insert into LuongNhanVien(MaCLV, MaNV, SoCaLam, TongTien, NgayNhanLuong, GhiChu)" +
                " values( N'" + cbMaCaLam.Text + "', '" + txtMaNV.Text + "', '" + txtSoCalam.Text + "', '" + txtTongTien.Text + "', '" + DateTime.Parse(dtNgayNhanLuong.Text).ToString("yyyy-MM-dd") + "', '" + txtGhiChu.Text + "')";

            bool kqNhanVien = c.exeSQL(queryNhanVien);

            if (kqNhanVien)
            {
                bool kqLuong = c.exeSQL(queryLuong);
                if (kqLuong)
                {
                    MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else {
                    MessageBox.Show("Thêm dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK);
                }
                loadhtNhanSu();
                c.disconnect();
            }
            


        }

        private void NhanSu_Load(object sender, EventArgs e)
        {
            cbChucVu.Items.Add("Quản lý");
            cbChucVu.Items.Add("Nhân viên");
            cbGioitinh.Items.Add("Nam");
            cbGioitinh.Items.Add("Nữ");
            cbMaCaLam.Items.Add("1");
            cbMaCaLam.Items.Add("2");
            loadhtNhanSu();

            groupBox1.Dock = DockStyle.Bottom;
            
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            c.connect();
            string querySuaNV = "update NhanVien " + " set " + " TenNV = N'" + txtTenNV.Text + "', " + " GioiTinh = N'" + cbGioitinh.Text + "', " + " ChucVu = N'" + cbChucVu.Text + "', " + " NgayVaoLam = '" + DateTime.Parse(dtNgayBatDau.Text).ToString("yyyy-MM-dd") + "', " + " DiaChi = '" + txtDiaChi.Text + "', " + " SDT = '" + txtSDT.Text + "', " + " GhiChu = '" + txtGhiChu.Text + "' "+" where "+" MaNV = '"+txtMaNV.Text+"' ";
            string querySuaLuong = "update LuongNhanVien " + " set " + " MaCLV = '" + cbMaCaLam.Text + "', " + " SoCaLam = '" + txtSoCalam.Text + "', " + " TongTien = '" + txtTongTien.Text + "', " + " NgayNhanLuong = '" + DateTime.Parse(dtNgayNhanLuong.Text).ToString("yyyy-MM-dd") + "', " + " GhiChu = '" + txtGhiChu.Text + "' "+" where "+" MaNV = '"+txtMaNV.Text+"'";

            bool SuaNV = c.exeSQL(querySuaNV);
            if (SuaNV)
            {
                bool SuaLuong = c.exeSQL(querySuaLuong);
                if (SuaLuong)
                {
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Sửa dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK);
                 }
                loadhtNhanSu();
                c.disconnect();
            }
           
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            c.connect();
            string sqlXoaNV = "delete from NhanVien " + " where " + " MaNV ='" + txtMaNV.Text + "'";
            string sqlXoaLuong = "delete from LuongNhanVien " + " where " + " MaNV ='" + txtMaNV.Text + "'";

            c.exeSQL(sqlXoaNV);
            c.exeSQL(sqlXoaLuong);

            loadhtNhanSu();
            c.disconnect();

        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            c.connect();
            DataSet ds = new DataSet();
            string sql = "Select n.MaNV as N'Mã nhân viên', n.TenNV as N'Tên nhân viên', n.GioiTinh as N'Giới tính', n.ChucVu as N'Chức vụ', n.NgayVaoLam as N'Ngày vào làm', n.DiaChi as N'Địa chỉ', n.SDT as N'số điện thoại', l.MaCLV as N'mã ca làm', l.SoCaLam as N'Số ca làm', l.TongTien as N'Tổng lương', l.NgayNhanLuong as N'Ngày nhận'from NhanVien n INNER join LuongNhanVien l on n.MaNV = l.MaNV where n.MaNV = '"+txtTimKiem.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, c.conn);
            da.Fill(ds);
            htNhanSu.DataSource = ds.Tables[0];
            c.disconnect();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

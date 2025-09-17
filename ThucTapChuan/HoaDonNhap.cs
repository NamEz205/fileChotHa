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
    public partial class formHoaDonNhap : Form
    {
        public formHoaDonNhap()
        {
            InitializeComponent();
        }

        connetcdata c = new connetcdata();

        private void formHoaDonNhap_Load(object sender, EventArgs e)
        {
            loadNhapHoaDon();

        }

        public void loadNhapHoaDon()
        {
            htNhapHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            c.connect();
            DataSet da = new DataSet();

            string query = @"SELECT hdn.MaHD_NhapHang as N'Mã hóa đơn', hdn.NgayHD_NhapHang as N'Ngày nhập hàng', hdn.MaNV as N'Mã nhân viên', hdn.MaNCC as N'Mã nhà cung cấp', cthn.MaSP as N'Mã sản phẩm', cthn.SoLuong as N'số lượng', cthn.TongTien as N'Tổng tiền'
                             FROM HoaDon_NhapHang hdn INNER JOIN ChiTiet_NhapHang cthn ON hdn.MaHD_NhapHang = cthn.MaHD_NhapHang";
            SqlDataAdapter adt = new SqlDataAdapter(query, c.conn); 
            adt.Fill(da);
            htNhapHoaDon.DataSource = da.Tables[0];
            c.disconnect();
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            c.connect();

            string queryHD = "insert into HoaDon_NhapHang(MaHD_NhapHang, MaNV, NgayHD_NhapHang, MaNCC, GhiChu)" +
                             "values ('" + txtMaHD.Text + "', '" + txtMaNV.Text + "', '" +
                             DateTime.Parse(txtNgayNhap.Text).ToString("yyyy-MM-dd") + "', '" + txtMaNCC.Text + "', '" +txtGhiChu.Text+"')";

            string queryCHD = "insert into ChiTiet_NhapHang(MaSP, MaHD_NhapHang, SoLuong, TongTien, GhiChu) " +
                              "values ('" + txtMaSP.Text + "', '" + txtMaHD.Text + "', '" + txtSoLuong.Text + "', '" + txtTongTien.Text + "',  '" +txtGhiChu.Text+"')";

            bool kq1 = c.exeSQL(queryHD);
            if (kq1)
            {
                bool kq2 = c.exeSQL(queryCHD);
                if (kq2)
                    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Có lỗi khi thêm dữ liệu!", "Thông báo", MessageBoxButtons.OK);

                loadNhapHoaDon();
                c.disconnect();
            }
        
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            c.connect();
            String queryHD = "update HoaDon_NhapHang " + "SET " + " MaNV ='" + txtMaNV.Text + "'," + " NgayHD_NhapHang ='" + DateTime.Parse(txtNgayNhap.Text).ToString("yyyy-MM-dd") + "', " + " MaNCC = '" + txtMaNCC.Text + "'" +
                ""+" Where MaHD_NhapHang = '"+txtMaHD.Text+"'";
;


            string queryCHD = "update ChiTiet_NhapHang " + " set MaSP ='" + txtMaSP.Text + "', SoLuong ='" + txtSoLuong.Text + "', TongTien ='" + txtTongTien.Text + "'" +
                ""+" Where MaHD_NhapHang = '"+txtMaHD.Text+"'";
            bool kq = c.exeSQL(queryHD);
            bool kq1 = c.exeSQL(queryCHD);

            if (kq1 && kq)
                MessageBox.Show("Sửa thành công dữ liệu!!", "Thông báo", MessageBoxButtons.OK);
            else
                MessageBox.Show("Lỗi, Không thêm được dữ liệu!", "Thông báo", MessageBoxButtons.OK);

            loadNhapHoaDon();
            c.disconnect();


        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            c.connect();
            string queryHD = "delete from HoaDon_NhapHang where MaHD_NhapHang ='" + txtMaHD.Text + "'";
            string queryCHD = "delete from ChiTiet_NhapHang where MaHD_NhapHang ='" + txtMaHD.Text + "'";

            bool kq = c.exeSQL(queryCHD);
            bool kq1 = c.exeSQL(queryHD);

            if (kq1 && kq)
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
            else
                MessageBox.Show("Lỗi, Không xóa được!", "Thông báo", MessageBoxButtons.OK);

            loadNhapHoaDon();
            c.disconnect();

        }
    }
    }

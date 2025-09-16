using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapChuan
{
    public partial class formBC_NhanSu : Form
    {
        public formBC_NhanSu()
        {
            InitializeComponent();
        }
        connetcdata c = new connetcdata();

        public void loadData()
        {
            htNhanSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            c.connect();
            DataSet da =  new DataSet();
            string query = "select MaNv as N'Mã Nhân Viên', TenNV as N'Tên nhân viên', GioiTinh as N'Giới tính', ChucVu as N'Chức vụ', NgayVaoLam as N'Ngày vào làm', DiaChi as N'Địa chỉ', SDT as N'Số điện thoại' from NhanVien";
            SqlDataAdapter sqladaper = new SqlDataAdapter(query, c.conn);
            sqladaper.Fill(da);
            htNhanSu.DataSource = da.Tables[0];
           

            htCaLamViec.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.Fill;
            DataSet dt = new DataSet();
            string sql = "select MaCLV as N'Mã ca làm việc', TenCLV as N'Tên Ca làm việc', SoTien as N'Số tiền', GhiChu as N'Ghi chú' from CaLamViec";
            SqlDataAdapter sqlData = new SqlDataAdapter(sql, c.conn);
            sqlData.Fill(dt);
            htCaLamViec.DataSource = dt.Tables[0];

            htLuongNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataSet dt2 = new DataSet();
            string sql2 = "select MaCLV as N'Mã ca làm việc', MaNV as N'Mã nhân viên', SoCaLam as N'số ca làm việc', TongTien as N'Tổng tiền', NgayNhanLuong as N'Ngày nhận lương' from LuongNhanVien";
            SqlDataAdapter sqlData1 = new SqlDataAdapter(sql2, c.conn);
            sqlData1.Fill(dt2);
            htLuongNV.DataSource = dt2.Tables[0];
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BaoCaoNhanSu_Load(object sender, EventArgs e)
        {
            loadData();


            c.connect();

            //tính tổng tiền
            string query = "SELECT SUM(TongTien) AS TongLuong FROM LuongNhanVien";
            SqlCommand cmd = new SqlCommand(query, c.conn);
            object tam = cmd.ExecuteScalar();
            txtTongTienLuong.Text = tam.ToString();


            //đếm số ca ngày
            string query1 = "select COUNT(*) from LuongNhanVien where MaCLV ='1'";
            SqlCommand cmd1 = new SqlCommand( query1, c.conn);
            object tam1 = cmd1.ExecuteScalar();
            txtSoLuongCaNgay.Text = tam1.ToString();


            //đếm số ca đêm
            string query2 = "select count(*) from LuongNhanVien where MaCLV ='2'";
            SqlCommand cmd2 = new SqlCommand(query2, c.conn);
            object tam2 = cmd2.ExecuteScalar();
            txtSoLuongCaDem.Text = tam2.ToString();

            //đếm số lượng nhân viên
            string query3 = "select Count(*) from NhanVien";
            SqlCommand cmd3 = new SqlCommand(query3, c.conn);
            object tam3 = cmd3.ExecuteScalar();
            txtTongNV.Text = tam3.ToString();


            //Nhân viên còn thiếu
            int SoNVCanTuyen = 20;
            int SoLuongHienTai = (int)cmd3.ExecuteScalar();
            int SoNvConThieu = SoNVCanTuyen - SoLuongHienTai;
            if (SoNvConThieu < SoNVCanTuyen)
            {
                txtNhanVienConThieu.Text = SoNvConThieu.ToString();

            }
            else {
                txtNhanVienConThieu.Text = "Đã đủ nhân viên";
            }
            //Đếm số nhân viên nam

            string demnam = "select count(*) from NhanVien where GioiTinh = N'Nam'";
            SqlCommand cmd4 = new SqlCommand(demnam, c.conn);
            object tam4 = cmd4.ExecuteScalar();
            txtSoNvNam.Text = tam4.ToString();


            //đếm số nhân viên nữ
            string demNu = "select count(*) from NhanVien where GioiTinh = N'Nữ'";
            SqlCommand cmd5 = new SqlCommand(demNu, c.conn);
            object tam5 = cmd5.ExecuteScalar();
            txtSoNvNu.Text = tam5.ToString();

        }




        private void txtTongNV_TextChanged(object sender, EventArgs e)
        {
        }

        private void htNhanSu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

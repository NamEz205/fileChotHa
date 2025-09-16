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

        private void formHoaDonXuat_Load(object sender, EventArgs e)
        {
            loadHDXuat();

        }

        public void loadHDXuat()
        {
            htHoaDonXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            c.connect();
            DataSet da = new DataSet();
            string query = @"SELECT hdn.MaHD_NhapHang as N'Mã hóa đơn', hdn.NgayHD_NhapHang as N'Ngày nhập hàng', hdn.MaNV as N'Mã nhân viên', hdn.MaNCC as N'Mã nhà cung cấp',
                            cthn.MaSP as N'Mã sản phẩm', cthn.SoLuong as N'số lượng', cthn.TongTien as N'Tổng tiền'
                     FROM HoaDon_NhapHang hdn
                     INNER JOIN ChiTiet_NhapHang cthn 
                     ON hdn.MaHD_NhapHang = cthn.MaHD_NhapHang";
            SqlDataAdapter adt = new SqlDataAdapter(query, c.conn);
            adt.Fill(da);
            htHoaDonXuat.DataSource = da.Tables[0];
            c.disconnect();
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            if (txtMaHD.Text == "" || txtMaNV.Text == "" || txtMaSP.Text == "" || txtSoLuong.Text == "" || txtTongTien.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else {
                c.connect();
            DataSet da = new DataSet();
                DateTime ngayNhap = DateTime.Parse(txtNgayXuat.Text);
                string queryHD = "insert into HoaDon_NhapHang(MaHD_NhapHang, MaNV, NgayHD_NhapHang, MaNCC) values ('"+ txtMaHD.Text + "','"+txtMaNV.Text+"', '"+ txtNgayXuat.Text + "', '"+txtMaNCC.Text+"')";
 

                string queryCHD = "insert into ChiTiet_NhapHang(MaHD_NhapHang, MaSP, SoLuong, TongTien) values ('"+txt.Text+"','" + txtMaSP.Text +"', '"+ txtSoLuong.Text + "','" + txtTongTien.Text + "')";

       

                try
                {
                    bool kq1 = c.exeSQL(queryHD);
                    bool kq2 = c.exeSQL(queryCHD);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                }


                loadHDXuat();
                c.disconnect();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // formHoaDonXuat
            // 
            this.ClientSize = new System.Drawing.Size(930, 619);
            this.Name = "formHoaDonXuat";
            this.ResumeLayout(false);

        }
    }
}

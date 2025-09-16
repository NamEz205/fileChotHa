using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapChuan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form frm = new Form();
            switch (e.ClickedItem.Name)
            {
                case "MenuNhanSu":
                    NhanSu nhansu = new NhanSu();
                    frm = nhansu;
                    break;
                case "MenuKhoHang":
                    MenuKhoHang khohang = new MenuKhoHang();
                    frm = khohang;
                    break;

                case "menuSP":
                     menuSP menu = new menuSP();
                    frm = menu;
                    break;
                case "menuKH":
                    menuKhachHang khachhang = new menuKhachHang();
                    frm = khachhang;
                    break;
                case 
                "menuNhaCC":
                    formNhaCungCap nhaCungCap = new formNhaCungCap();
                    frm = nhaCungCap;
                    break;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.BringToFront();
        }

        private void toolStripMenuItem3_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void nhânSựToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void báoCáoThốngKêToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form frm = new Form();
            switch (e.ClickedItem.Name)
            {
                case "menuBC_NhanSu":
                    formBC_NhanSu nhanSu = new formBC_NhanSu();
                    frm = nhanSu;
                    break;
                case "menuBC_SP":
                    formBC_SP sP = new formBC_SP();
                    frm = sP;
                    break;
                case "menuBC_DoanhThu":
                    formBC_DoanhThu doanhThu = new formBC_DoanhThu();
                    frm = doanhThu;
                    break;


            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.BringToFront();

        }

        private void thoátToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "menu_Thoat":
                    break;
                case "menu_DangXuat":
                    break;
            }
        }

        private void hóaĐơnToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form frm = new Form();
            switch (e.ClickedItem.Name) {
                case "menuHoaDonNhap":
                    formHoaDonNhap nhap = new formHoaDonNhap();
                    frm = nhap;
                    break;
                case "menuHoaDonXuat":
                    formHoaDonXuat xuat = new formHoaDonXuat();
                    frm = xuat;
                    break;

            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.BringToFront();

        }

        private void menuHoaDonXuat_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

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
    }
}

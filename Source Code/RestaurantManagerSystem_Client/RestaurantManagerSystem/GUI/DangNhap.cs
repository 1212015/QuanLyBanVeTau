using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using RestaurantManagerSystem.RestaurantManagerSystem_BLL_WS;

namespace RestaurantManagerSystem.GUI
{
    public partial class frmDangNhap : Form
    {
        RestaurantManagerSystem_BLL_WS.RestaurantManagerSystem_BLL_WebServiceSoapClient NhanVienBUS = new RestaurantManagerSystem_BLL_WS.RestaurantManagerSystem_BLL_WebServiceSoapClient();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        //Thoát
        private void buttonX2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Nhập lại
        private void buttonX3_Click(object sender, EventArgs e)
        {
            tbTenDN.Text = "";
            tbMatKhau.Text = "";
        }
        //Đăng Nhập
        public void DangNhap()
        {
            if (tbTenDN.Text == "")
            {
                MessageBoxEx.Show("Tên đang nhập không được rỗng!");
            }
            else if (tbMatKhau.Text == "")
            {
                MessageBoxEx.Show("Mật khẩu không được rỗng!");
            }
            else
            {
                if(!NhanVienBUS.CheckConnection())
                {
                    MessageBox.Show("Không tìm thấy cơ sở dữ liệu!!!");
                    return;
                }
                RestaurantManagerSystem_BLL_WS.NhanVienDTO[] _ds = NhanVienBUS.LayDSNhanVienCoMK();
                bool flag = false;
                for (int i = 0; i < _ds.Length ; i++)
                {
                    if (tbTenDN.Text == _ds[i].TenDN.ToString() && tbMatKhau.Text == _ds[i].MatKhau.ToString())
                    {
                        RestaurantManagerSystem_BLL_WS.NhanVienDTO nv = new RestaurantManagerSystem_BLL_WS.NhanVienDTO();
                        nv.MaNV = _ds[i].MaNV;
                        nv.HoTen = _ds[i].HoTen;
                        nv.NgaySinh = _ds[i].NgaySinh;
                        nv.TenDN = _ds[i].TenDN;
                        nv.MatKhau = _ds[i].MatKhau;
                        nv.Quyen = _ds[i].Quyen;
                        frmMain frmM = new frmMain();
                        frmM.Nv = nv;
                        frmM.Show();
                        this.Hide();
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    MessageBoxEx.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                    tbMatKhau.Text = "";
                }
            }
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void tbMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbTenDN.Text != "")
                    DangNhap();
                else
                    tbTenDN.Focus();
            }
        }

        private void tbTenDN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbMatKhau.Text == "")
                    tbMatKhau.Focus();
                else
                    DangNhap();
            }
        }
    }
}
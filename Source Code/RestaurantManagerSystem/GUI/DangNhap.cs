using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DTO;
using DAO;
using BUS;

namespace RestaurantManagerSystem.GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

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
                DataTable _ds = UsersDAO.LayDSNhanVienCoMK();
                int flag = 0;
                for (int i = 0; i < _ds.Rows.Count; i++)
                {
                    if (tbTenDN.Text == _ds.Rows[i]["UserName"].ToString() && tbMatKhau.Text == _ds.Rows[i]["Password"].ToString())
                    {
                        frmMain frmM = new frmMain();
                        frmM.us = new UsersDTO(int.Parse(_ds.Rows[i]["UserId"].ToString()), int.Parse(_ds.Rows[i]["GroupId"].ToString()), _ds.Rows[i]["UserName"].ToString(),  _ds.Rows[i]["Password"].ToString(),  _ds.Rows[i]["Email"].ToString(), DateTime.Parse(_ds.Rows[i]["AddedDate"].ToString()), _ds.Rows[i]["Actived"].ToString(), _ds.Rows[i]["Locked"].ToString());
                        frmM.Show();
                        this.Hide();
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    DataTable _ds2 = UsersDAO.LayDSNhanVienCoMK2();
                    int flag2 = 0;
                    for (int i = 0; i < _ds2.Rows.Count; i++)
                    {
                        if (tbTenDN.Text == _ds2.Rows[i]["UserName"].ToString() && tbMatKhau.Text == _ds2.Rows[i]["Password"].ToString())
                        {
                            frmMain frmM = new frmMain();
                            frmM.us = new UsersDTO(int.Parse(_ds2.Rows[i]["UserId"].ToString()), int.Parse(_ds2.Rows[i]["GroupId"].ToString()), _ds2.Rows[i]["UserName"].ToString(), _ds2.Rows[i]["Password"].ToString(), _ds2.Rows[i]["Email"].ToString(), DateTime.Parse(_ds2.Rows[i]["AddedDate"].ToString()), _ds2.Rows[i]["Actived"].ToString());
                            frmM.Show();
                            this.Hide();
                            flag2 = 1;
                        }
                    }
                    if (flag2 == 0)
                    {
                        MessageBoxEx.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                        tbMatKhau.Text = "";
                    }
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
                DangNhap();
            }
        }

        private void tbTenDN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbMatKhau.Focus();
            }
        }

        public void DangNhapKhachHang()
        {
            tbTenDN.Text = "khachhang1";
            tbMatKhau.Text = "123456" ;

            DataTable _ds = UsersDAO.LayDSNhanVienCoMK();
          
            for (int i = 0; i < _ds.Rows.Count; i++)
            {
                if (tbTenDN.Text == _ds.Rows[i]["UserName"].ToString() && tbMatKhau.Text == _ds.Rows[i]["Password"].ToString())
                {
                    frmMain frmM = new frmMain();
                    frmM.us = new UsersDTO(int.Parse(_ds.Rows[i]["UserId"].ToString()), int.Parse(_ds.Rows[i]["GroupId"].ToString()), _ds.Rows[i]["UserName"].ToString(), _ds.Rows[i]["Password"].ToString(), _ds.Rows[i]["Email"].ToString(), DateTime.Parse(_ds.Rows[i]["AddedDate"].ToString()), _ds.Rows[i]["Actived"].ToString(), _ds.Rows[i]["Locked"].ToString());
                    frmM.Show();
                    this.Hide();
                }
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DangNhapKhachHang();
        }
    }
}
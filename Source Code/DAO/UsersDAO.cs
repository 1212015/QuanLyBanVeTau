using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class UsersDAO
    {
        public static DataTable LayDSNhanVienCoMK()// dskhachhang
        {
            //string sql = "select * from users";
            string sql = "Exec sp_LayDSNhanVienCoMK"; 
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static DataTable LayDSNhanVienCoMK2()
        {
            //string sql = "select * from userNV";
            string sql = "Exec sp_LayDSNhanVienCoMK2"; 
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static bool ThemTaiKhoanNhanVien(int quyen, string tendn, string matkhau, string email)
        {
            //DateTime ngaytao = DateTime.Today;
            //int actived = 1;
            
            bool kq;
            //string sql = string.Format("set dateformat DMY insert into userNV values ({0}, '{1}', '{2}', '{3}', '{4}', {5})", quyen, tendn, matkhau, email, ngaytao, actived );
            string sql = string.Format("Exec sp_ThemTaiKhoanNhanVien '{0}', '{1}', '{2}', '{3}'", quyen, tendn, matkhau, email);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public static bool ThemTaiKhoanKhachHang(string tendn, string matkhau, string email)
        {
            //DateTime ngaytao = DateTime.Today;
            //int actived = 1;
            //int quyen = 6;
            //int locked = 0;
            bool kq;
             
            //string sql = string.Format("set dateformat DMY insert into users values ({0}, '{1}', '{2}', '{3}', '{4}', {5}, {6})", quyen, tendn, matkhau, email, ngaytao, actived, locked);
            string sql = string.Format("Exec sp_ThemTaiKhoanKhachHang '{0}', '{1}', '{2}'", tendn, matkhau, email);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public static bool KiemTraTenDNTonTai(string tenDN)
        {
            bool kq;
            //string sql = "select * from userNV where UserName = '" + tenDN + "'" ;
            string sql = string.Format("Exec sp_KiemTraTenDNTonTai '{0}'", tenDN);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
                kq = true;
            else
                kq = false;
            return kq;
        }

        public static bool KiemTraTenDNTonTaiKhachHang(string tenDN)
        {
            bool kq;
            //string sql = "select * from users where UserName = '" + tenDN + "'";
            string sql = string.Format("Exec sp_KiemTraTenDNTonTaiKhachHang '{0}'", tenDN);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
                kq = true;
            else
                kq = false;
            return kq;
        }
    }
}

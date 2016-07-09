using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class UsersBUS
    {
        public static DataTable LayDSNhanVienCoMK()
        {
            DataTable dt = UsersDAO.LayDSNhanVienCoMK();
            return dt;
        }

        public static DataTable LayDSNhanVienCoMK2()
        {
            DataTable dt = UsersDAO.LayDSNhanVienCoMK2();
            return dt;
        }

        public static bool ThemTaiKhoanNhanVien(int quyen, string tendn, string matkhau, string email)
        {
            bool kq = UsersDAO.ThemTaiKhoanNhanVien(quyen, tendn, matkhau, email);
            return kq;
        }

        public static bool ThemTaiKhoanKhachHang(string tendn, string matkhau, string email)
        {
            bool kq = UsersDAO.ThemTaiKhoanKhachHang(tendn, matkhau, email);
            return kq;
        }

        public static bool KiemTraTenDNTonTai(string tenDN)
        {
            bool kq = UsersDAO.KiemTraTenDNTonTai(tenDN);
            return kq;
        }

        public static bool KiemTraTenDNTonTaiKhachHang(string tenDN)
        {
            bool kq = UsersDAO.KiemTraTenDNTonTaiKhachHang(tenDN);
            return kq;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class KhachHangBUS
    {
        public static DataTable TraCuuKhachHangTheoTen(string tenKH)
        {
            DataTable dt = KhachHangDAO.TraCuuKhachHangTheoTen(tenKH);
            return dt;
        }

        public static DataTable QuanLyTaiKhoanKhachHang()
        {
            DataTable dt = KhachHangDAO.QuanLyTaiKhoanKhachHang();
            return dt;
        }

        public static bool KhoaTaiKhoanKhachHang(int maNV)
        {
            bool kq = KhachHangDAO.KhoaTaiKhoanKhachHang(maNV);
            return kq;
        }

        public static bool ThemKhachHang(KhachHangDTO kh)
        {
            bool kq = KhachHangDAO.ThemKhachHang(kh);
            return kq;
        }
        public static DataTable LayDSKhachHang()
        {
            DataTable dt = KhachHangDAO.LayDSKhachHang();
            return dt;
        }
        public static bool CapNhatThongTinKhachHang(KhachHangDTO kh, UsersDTO us)
        {
            bool kq = KhachHangDAO.CapNhatThongTinKhachHang(kh,us);
            return kq;
        }
    }
}

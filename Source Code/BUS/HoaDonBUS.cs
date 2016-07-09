using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class HoaDonBUS
    {
        public static DataTable TraCuuVeTheoMaKhachHang(int MaKH)
        {
            DataTable dt = HoaDonDAO.TraCuuVeTheoMaKhachHang(MaKH);
            return dt;
        }

        public static DataTable TraCuuVeTheoMaVe(int MaVe)
        {
            DataTable dt = HoaDonDAO.TraCuuVeTheoMaVe(MaVe);
            return dt;
        }
        public static bool HamDoiVe(int MaHD, int MaKH, int MaNV, int MaVe)
        {
            bool kq = HoaDonDAO.HamDoiVe(MaHD, MaKH, MaNV, MaVe);
            return kq;
        }

        public static DataTable TraCuuHoaDonTheoMaHoaDon(int maHD)
        {
            DataTable dt = HoaDonDAO.TraCuuHoaDonTheoMaHoaDon(maHD);
            return dt;
        }
        public static DataTable LayDanhSachHoaDon()
        {
            DataTable dt = HoaDonDAO.LayDanhSachHoaDon();
            return dt;
        }

        public static bool HamSuaHoaDon(int MaHD, int MaKH, int MaVe, int MaNV, float DonGia, int SoLuong, float TongTien)
        {
            bool kq = HoaDonDAO.HamSuaHoaDon(MaHD, MaKH, MaVe, MaNV, DonGia, SoLuong, TongTien);
            return kq;
        }
        public static bool HamThemHoaDon(int MaHD, int MaKH, int MaVe, int MaNV, float DonGia, int SoLuong, float TongTien)
        {
            bool kq = HoaDonDAO.HamThemHoaDon(MaHD, MaKH, MaVe, MaNV, DonGia, SoLuong, TongTien);
            return kq;
        }

        public static bool HamXoaHoaDon(int MaHD)
        {
            bool kq = HoaDonDAO.HamXoaHoaDon(MaHD);
            return kq;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class HoaDonDAO
    {
        public static DataTable TraCuuVeTheoMaKhachHang(int maKH)
        {

            string sql = string.Format("Exec sp_TraCuuVeTheoMaKhachHang N'{0}'", maKH);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static DataTable TraCuuVeTheoMaVe(int maVe)
        {

            string sql = string.Format("Exec sp_TraCuuVeTheoMaVe N'{0}'", maVe);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }
        public static bool HamDoiVe(int MaHD, int MaKH, int MaNV, int MaVe)
        {


            bool kq;

            string sql = string.Format("Exec sp_DoiVe '{0}', '{1}', '{2}', '{3}'", MaHD, MaKH, MaNV, MaVe);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public static DataTable TraCuuHoaDonTheoMaHoaDon(int maHD)
        {

            string sql = string.Format("Exec sp_TraCuuHoaDonTheoMaHoaDon N'{0}'", maHD);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static DataTable LayDanhSachHoaDon()
        {

            string sql = string.Format("Exec sp_LayDanhSachHoaDon");
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static bool HamSuaHoaDon(int MaHD, int MaKH, int MaVe, int MaNV, float DonGia, int SoLuong, float TongTien)
        {


            bool kq;

            string sql = string.Format("Exec sp_HamSuaHoaDon '{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}'", MaHD, MaKH, MaVe, MaNV, DonGia, SoLuong, TongTien);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public static bool HamThemHoaDon(int MaHD, int MaKH, int MaVe, int MaNV, float DonGia, int SoLuong, float TongTien)
        {


            bool kq;

            string sql = string.Format("Exec sp_HamThemHoaDon '{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}'", MaHD, MaKH, MaVe, MaNV, DonGia, SoLuong, TongTien);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public static bool HamXoaHoaDon(int MaHD)
        {


            bool kq;

            string sql = string.Format("Exec sp_HamXoaHoaDon '{0}'", MaHD);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }
    }
}

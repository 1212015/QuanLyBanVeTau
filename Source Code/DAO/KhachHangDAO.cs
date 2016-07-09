using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class KhachHangDAO
    {
        public static DataTable TraCuuKhachHangTheoTen(string tenKH)
        {
            //string sql = string.Format(" select KH.MaKH, KH.HoTen, Kh.CMND, KH.DienThoai, KH.NgaySinh, KH.DiaChi, G.GroupName as TenNhom, U.Email, U.Actived as TinhTrang from khachhang as KH join users as U on KH.MaKH = U.UserId join groups as G on G.GroupId = U.GroupId where KH.HoTen like N'%{0}%'", tenKH);
            string sql = string.Format("Exec sp_TraCuuKhachHangTheoTen N'{0}'", tenKH);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static DataTable QuanLyTaiKhoanKhachHang()
        {
            //string sql = "select KH.MaKH, KH.HoTen, Kh.CMND, KH.DienThoai, KH.NgaySinh, KH.DiaChi, G.GroupName as TenNhom, U.Email, U.Actived as TinhTrang from khachhang as KH join users as U on KH.MaKH = U.UserId join groups as G on G.GroupId = U.GroupId ;";
            string sql = "Exec sp_QuanLyTaiKhoanKhachHang";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static bool KhoaTaiKhoanKhachHang(int maNV)
        {
            bool kq;
            // sql = string.Format("update users set Actived = 0 where UserId = {0}", maNV);
            string sql = string.Format("Exec sp_KhoaTaiKhoanKhachHang '{0}'", maNV);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public static bool ThemKhachHang(KhachHangDTO kh)
        {
            kh.MaKH = MaTuTang();
            bool kq;
            //string sql = string.Format("set dateformat DMY insert into khachhang values ({0}, N'{1}', '{2}', '{3}', '{4}', N'{5}')",kh.MaKH, kh.HoTen, kh.CMND, kh.DienThoai, kh.NgaySinh, kh.DiaChi);
            string sql = string.Format("Exec sp_ThemKhachHang {0}, N'{1}', '{2}', '{3}', '{4}', N'{5}'",kh.MaKH, kh.HoTen, kh.CMND, kh.DienThoai, kh.NgaySinh, kh.DiaChi);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public static int MaTuTang()
        {
            string sql = "SELECT TOP 1 UserId  FROM users ORDER BY UserId DESC";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return int.Parse(dt.Rows[0][0].ToString());
        }
        public static DataTable LayDSKhachHang()
        {
            string sql = string.Format("Exec sp_LayDSKhachHang ");
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }
        public static bool CapNhatThongTinKhachHang(KhachHangDTO kh, UsersDTO us)
        {
            kh.MaKH = MaTuTang();
            bool kq;
            //string sql = string.Format("set dateformat DMY update userNV set Password = '{0}' where UserId = '{1}' ", matkhau, id);
            string sql = string.Format("Exec sp_CapNhatThongTinKH '{0}', '{1}', N'{2}', '{3}', '{4}', '{5}', '{6}', '{7}'", kh.MaKH, kh.HoTen, kh.CMND, kh.DienThoai, kh.DiaChi, us.UserName, us.Password, us.Email);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }
    }
}

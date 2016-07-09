using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class NhanVienBUS
    {
        public static DataTable LayDSAdmin()
        {
            DataTable dt = NhanVienDAO.LayDSAdmin();
            return dt;
        }

        public static DataTable LayDSNhanVien()
        {
            DataTable dt = NhanVienDAO.LayDSNhanVien();
            return dt;
        }

        public static bool CapNhatMatKhauAdmin(int id, string matkhau)
        {
            bool kq = NhanVienDAO.CapNhatMatKhauAdmin(id, matkhau);
            return kq;
        }

        public static DataTable QuanLyTaiKhoanNhanVien()
        {
            DataTable dt = NhanVienDAO.QuanLyTaiKhoanNhanVien();
            return dt;
        }

        public static DataTable TraCuuNhanVienTheoTen(string tenNV)
        {
            DataTable dt = NhanVienDAO.TraCuuNhanVienTheoTen(tenNV);
            return dt;
        }

        public static bool KhoaTaiKhoanNhanVien(int maNV)
        {
            bool kq = NhanVienDAO.KhoaTaiKhoanNhanVien(maNV);
            return kq;
        }

        public static bool ThemNhanVien(NhanVienDTO nd)
        {
            bool kq = NhanVienDAO.ThemNhanVien(nd);
            return kq;
        }
        public static bool CapNhatMatKhauNhanVien(int id, string matkhau)
        {
            bool kq = NhanVienDAO.CapNhatMatKhauNhanVien(id, matkhau);
            return kq;
        }
        public static DataTable LayDSNhanVienCN()
        {
            DataTable dt = NhanVienDAO.LayDSNhanVienCN();
            return dt;
        }
        public static bool CapNhatThongTinNV(NhanVienDTO nv, UsersDTO us)
        {
            bool kq = NhanVienDAO.CapNhatThongTinNhanVien(nv, us);
            return kq;
        }

        public static List<NhanVienDTO> LayTenNhanVien()
        {
            List<NhanVienDTO> _ds = NhanVienDAO.LayTenNhanVien();
            return _ds;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        public static DataTable LayDSAdmin()
        {
            //string sql = "select U.UserID, G.GroupName, U.Username, U.Password, U.Email, U.AddedDate, U.Actived from groups G join userNV as U on G.GroupId = U.GroupId where G.GroupId = 1;";
            string sql = "Exec sp_LayDSAdmin";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static DataTable LayDSNhanVien()
        {
            //string sql = "select * from nhanvien";
            string sql = "Exec sp_LayDSNhanVien ";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static bool CapNhatMatKhauAdmin(int id, string matkhau)
        {
            bool kq;
            //string sql = string.Format("set dateformat DMY update userNV set Password = '{0}' where UserId = '{1}' ", matkhau, id);
            string sql = string.Format("Exec sp_CapNhatMatKhauAdmin '{0}', '{1}'", matkhau, id);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public static DataTable QuanLyTaiKhoanNhanVien()
        {
            //string sql = "select NV.MaNV, NV.HoTen, NV.CMND,U.UserName as TenDangNhap, G.GroupName as Quyen, NV.DiaChi, NV.DienThoai, ql.HoTen as NguoiQuanLy, U.Actived as TinhTrang from nhanvien as NV join userNV as U on NV.MaNV = U.UserId join groups as G on G.GroupId = U.GroupId join nhanvien as ql on nv.MaNV = ql.MaNV;";
            string sql = "Exec sp_QuanLyTaiKhoanNhanVien";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static DataTable TraCuuNhanVienTheoTen(string tenNV)
        {
            //string sql = string.Format("select NV.MaNV, NV.HoTen, NV.CMND,U.UserName as TenDangNhap, G.GroupName as Quyen, NV.DiaChi, NV.DienThoai, ql.HoTen as NguoiQuanLy, U.Actived as TinhTrang from nhanvien as NV join userNV as U on NV.MaNV = U.UserId join groups as G on G.GroupId = U.GroupId join nhanvien as ql on nv.MaNV = ql.MaNV where NV.HoTen like N'%{0}%'", tenNV);
            string sql = string.Format("Exec sp_TraCuuNhanVienTheoTen N'{0}'", tenNV);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static bool KhoaTaiKhoanNhanVien(int maNV)
        {
            bool kq;
            //string sql = string.Format("update userNV set Actived = 0 where UserId = {0}", maNV);
            string sql = string.Format("Exec sp_KhoaTaiKhoanNhanVien '{0}'", maNV);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public static bool ThemNhanVien(NhanVienDTO nv)
        {
            nv.MaNV = MaTuTang();
            bool kq;
            //string sql = string.Format("set dateformat DMY insert into NhanVien values ({0}, {1}, N'{2}', '{3}','{4}', '{5}', N'{6}', '{7}', {8})", nv.MaNV, nv.MaLoaiNV, nv.HoTen, nv.CMND, nv.NgaySinh, nv.GioiTinh, nv.DiaChi, nv.DienThoai, nv.NguoiQuanLy);
            string sql = string.Format("Exec sp_ThemNhanVien '{0}', '{1}', N'{2}', '{3}', '{4}', '{5}', N'{6}', '{7}', {8}", nv.MaNV, nv.MaLoaiNV, nv.HoTen, nv.CMND, nv.NgaySinh, nv.GioiTinh, nv.DiaChi, nv.DienThoai, nv.NguoiQuanLy);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public static int MaTuTang()
        {
            string sql = "SELECT TOP 1 UserId  FROM userNV ORDER BY UserId DESC";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);            
            return int.Parse(dt.Rows[0][0].ToString());            
        }
        public static bool CapNhatMatKhauNhanVien(int id, string matkhau)
        {
            bool kq;
            //string sql = string.Format("set dateformat DMY update userNV set Password = '{0}' where UserId = '{1}' ", matkhau, id);
            string sql = string.Format("Exec sp_CapNhatMatKhauNhanVien '{0}', '{1}'", matkhau, id);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }
        public static DataTable LayDSNhanVienCN()
        {
            string sql =string.Format( "Exec sp_LayDSNhanVien1 ");
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }
        public static bool CapNhatThongTinNhanVien(NhanVienDTO nv, UsersDTO us)
        {
            nv.MaNV = MaTuTang();
            bool kq;
            //string sql = string.Format("set dateformat DMY update userNV set Password = '{0}' where UserId = '{1}' ", matkhau, id);
            string sql =string.Format("Exec sp_CapNhatThongTinNV '{0}', '{1}', N'{2}', '{3}', '{4}', '{5}', '{6}', '{7}'", nv.MaNV, nv.HoTen, nv.CMND, nv.GioiTinh, nv.DiaChi, nv.DienThoai, us.UserName, us.Password);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public static List<NhanVienDTO> LayTenNhanVien()
        {
            List<NhanVienDTO> _ds = new List<NhanVienDTO>();
            string sql = "select * from nhanvien";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.MaNV = int.Parse(dt.Rows[i]["MaNV"].ToString());
                nv.MaLoaiNV = int.Parse(dt.Rows[i]["MaLoaiNV"].ToString());
                nv.HoTen = (dt.Rows[i]["HoTen"].ToString());
                nv.CMND = (dt.Rows[i]["CMND"].ToString());
                nv.NgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                nv.GioiTinh = (dt.Rows[i]["GioiTinh"].ToString());
                nv.DiaChi = (dt.Rows[i]["DiaChi"].ToString());
                nv.DienThoai = (dt.Rows[i]["DienThoai"].ToString());
                // nv.NguoiQuanLy = int.Parse(dt.Rows[i]["NguoiQuanLy"].ToString());     

                _ds.Add(nv);
            }
            return _ds;
        }
    }
}

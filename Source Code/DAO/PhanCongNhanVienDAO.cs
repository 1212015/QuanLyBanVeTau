using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
namespace DAO
{
    public class PhanCongNhanVienDAO
    {
        public static DataTable TraCuuPhanCongNhanVienTheoTen(string tenNV)
        {
            //string sql = string.Format(" select KH.MaKH, KH.HoTen, Kh.CMND, KH.DienThoai, KH.NgaySinh, KH.DiaChi, G.GroupName as TenNhom, U.Email, U.Actived as TinhTrang from khachhang as KH join users as U on KH.MaKH = U.UserId join groups as G on G.GroupId = U.GroupId where KH.HoTen like N'%{0}%'", tenKH);
            string sql = string.Format("Exec sp_TraCuuPhanCongNhanVienTheoTen N'{0}'", tenNV);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static int MaTuTang()
        {
            string sql = "SELECT TOP 1 UserId  FROM users ORDER BY UserId DESC";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return int.Parse(dt.Rows[0][0].ToString());
        }
    }
}

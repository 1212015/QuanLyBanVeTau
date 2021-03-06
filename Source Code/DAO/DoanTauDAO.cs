using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class DoanTauDAO
    {
        //Rút trích dữ liêu: select 
        public static DataTable LayDSĐoanTau()
        {
            string sql = "select dt.MaDoanTau as 'Mã Đoàn Tàu', lt.TenLoaiTau as 'Tên Loại Tàu', dt.TenTau as 'Tên Tàu', dt.HangSanXuat as 'Hãng Sản Xuât', dt.NgayVanHanh as 'Ngày Vận Hành' from doantau as dt, loaitau as lt where dt.MaLoaiTau=lt.MaLoaiTau";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static List<DoanTauDTO> LayDSMaDoanTau()
        {
            List<DoanTauDTO> _ds = new List<DoanTauDTO>();
            string sql = "select * from doantau";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DoanTauDTO d = new DoanTauDTO();
                d.MaDoanTau = int.Parse(dt.Rows[i]["MaDoanTau"].ToString());
                d.TenTau = (dt.Rows[i]["TenTau"].ToString());
                d.MaLoaiTau = int.Parse(dt.Rows[i]["MaLoaiTau"].ToString());
                d.HangSanXuat = (dt.Rows[i]["HangSanXuat"].ToString());
                d.NgayVanHanh = DateTime.Parse(dt.Rows[i]["NgayVanHanh"].ToString());

                _ds.Add(d);
            }
            return _ds;

        }

        public static string LayTenTauTheoMaDoanTau(int madoantau)
        {
            string tentau;
            string sql = string.Format("select dt.TenTau from doantau as dt where dt.MaDoanTau={0}", madoantau);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
            {
                tentau = (dt.Rows[0][0].ToString());
            }
            else
            {
                return "";
            }
            return tentau;
        }

        public static int SoluongGhe(string tentau, int matoa, string tenloaighe)
        {
            int sl;
            string sql = string.Format("EXEC sp_LaySoLuongGhe N'{0}',{1},N'{2}'", tentau, matoa, tenloaighe);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
            {
                sl = int.Parse(dt.Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
            return sl;
        }

        public static bool ThemDoanTau(string tenloaitau, string tentau, string hangsanxuat, string ngayvanhanh)
        {
            bool kq;
            string sql = string.Format("EXEC sp_ThemDoanTau N'{0}',N'{1}',N'{2}','{3}'", tenloaitau, tentau, hangsanxuat, ngayvanhanh);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public static bool SuaDoanTau(int madoantau, string tenloaitau, string tentau, string hangsanxuat, string ngayvanhanh)
        {
            bool kq;
            string sql = string.Format("EXEC sp_SuaDoanTau {0},N'{1}',N'{2}',N'{3}',N'{4}'", madoantau, tenloaitau, tentau, hangsanxuat, ngayvanhanh);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);

            return kq;
        }

        public static bool XoaDoanTau(int madoantau)
        {
            bool kq;
            string sql = string.Format("EXEC sp_XoaDoanTau {0}", madoantau);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);

            return kq;
        }

        public static DataTable TimkiemDoanTau(string key)
        {
            string sql = string.Format("EXEC sp_TimDoanTau N'{0}'", key);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }
    }
}

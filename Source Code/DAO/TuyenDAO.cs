using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class TuyenDAO
    {

        //Rút trích dữ liêu: select 
        public static DataTable LayDSTuyen()
        {
            string sql = "select MaTuyen as 'Mã Tuyến', TenTuyen as 'Tên Tuyến', g.TenGa as 'Ga Khởi Hành',g.DiaChi as 'ĐC GKH', g2.TenGa as 'Ga Kết Thúc', g2.DiaChi as 'ĐC GKT' from tuyen as t, ga as g, ga as g2 where t.GaKhoiHanh=g.MaGa and t.GaKetThuc=g2.MaGa";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static List<TuyenDTO> LayDSTenTuyen()
        {
            List<TuyenDTO> _ds = new List<TuyenDTO>();
            string sql = "select * from tuyen";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TuyenDTO t = new TuyenDTO();
                t.MaTuyen = int.Parse(dt.Rows[i]["MaTuyen"].ToString());
                t.TenTuyen = (dt.Rows[i]["TenTuyen"].ToString());
                t.GaKhoiHanh = int.Parse(dt.Rows[i]["GaKhoiHanh"].ToString());
                t.GaKetThuc = int.Parse(dt.Rows[i]["GaKetThuc"].ToString());

                _ds.Add(t);
            }
            return _ds;
        }

        public static bool ThemTuyen(string tentuyen, string gakhoihanh, string gaketthuc)
        {
            bool kq;
            string sql = string.Format("EXEC sp_ThemTuyen N'{0}',N'{1}',N'{2}'", tentuyen, gakhoihanh, gaketthuc);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);

            return kq;
        }

        public static bool SuaTuyen(int matuyen, string tentuyen, string gakhoihanh, string gaketthuc)
        {
            bool kq;
            string sql = string.Format("EXEC sp_CapNhatTuyen {0},N'{1}',N'{2}',N'{3}'", matuyen, tentuyen, gakhoihanh, gaketthuc);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);

            return kq;
        }

        public static bool XoaTuyen(int matuyen)
        {
            bool kq;
            string sql = string.Format("EXEC sp_XoaTuyen {0}", matuyen);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);

            return kq;
        }

        public static DataTable TimkiemTuyen(string key)
        {
            string sql = string.Format("EXEC sp_TimTuyen N'{0}'", key);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

    }
}

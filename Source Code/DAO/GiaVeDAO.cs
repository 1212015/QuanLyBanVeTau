using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class GiaVeDAO
    {
        public static DataTable LayBangGia()
        {
            //string sql = "select MaGiaVe,GaDi.TenGa as GaDi,GaDen.TenGa as GaDen, SoTien, TenLoaiTau, TenLoaiGhe, SoTien*LoaiTau.TiLeGia*LoaiGhe.TiLeGia as TongTien  from GiaVe,Ga as GaDi,Ga as GaDen, LoaiTau,LoaiGhe where GiaVe.GaDi=GaDi.MaGa and GiaVe.GaDen=GaDen.MaGa";
            string sql = "Exec sp_LayBangGia";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static DataTable LayDSGiaVe()
        {
            string sql = "select gv.MaGiaVe as 'Mã Giá Vé', g.TenGa as 'Ga đi',g.DiaChi as 'Địa chỉ ga đi',g2.TenGa as 'Ga đến',g2.DiaChi as'Địa chỉ ga đến', gv.SoTien as 'Số tiền' from giave as gv, ga as g, ga as g2 where gv.GaDi=g.MaGa  and gv.GaDen=g2.MaGa";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static bool ThemGiaVe(int giave, string gakhoihanh, string gaketthuc)
        {
            bool kq;
            string sql = string.Format("EXEC sp_ThemGiaVe {0},N'{1}',N'{2}'", giave, gakhoihanh, gaketthuc);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);

            return kq;
        }

        public static bool SuaGiaVe(int magiave, int giave, string gakhoihanh, string gaketthuc)
        {
            bool kq;
            string sql = string.Format("EXEC sp_CapNhatGiaVe {0},{1},N'{2}',N'{3}'", magiave, giave, gakhoihanh, gaketthuc);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);

            return kq;
        }

        public static bool XoaGiaVe(int magiave)
        {
            bool kq;
            string sql = string.Format("EXEC sp_XoaGiaVe {0}", magiave);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);

            return kq;
        }

        public static DataTable TimkiemGiaVe(int key1, int key2)
        {
            string sql = string.Format("EXEC sp_TimGiaVe {0},{1}", key1, key2);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }
    }
}

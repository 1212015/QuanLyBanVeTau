using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class GiaVeBUS
    {
        public static DataTable LayBangGia()
        {
            DataTable dt = GiaVeDAO.LayBangGia();
            return dt;
        }

        public static DataTable LayDSGiaVe()
        {
            DataTable _ds = GiaVeDAO.LayDSGiaVe();
            return _ds;
        }

        public static bool ThemGiaVe(int giave, string gakhoihanh, string gaketthuc)
        {
            bool i = GiaVeDAO.ThemGiaVe(giave, gakhoihanh, gaketthuc);
            return i;
        }

        public static bool SuaGiaVe(int magiave, int giave, string gakhoihanh, string gaketthuc)
        {
            bool i = GiaVeDAO.SuaGiaVe(magiave, giave, gakhoihanh, gaketthuc);
            return i;
        }

        public static bool XoaGiaVe(int magiave)
        {
            bool i = GiaVeDAO.XoaGiaVe(magiave);
            return i;
        }

        public static DataTable TimkiemGiaVe(int key1, int key2)
        {
            DataTable _ds = GiaVeDAO.TimkiemGiaVe(key1, key2);
            return _ds;
        }
    }
}

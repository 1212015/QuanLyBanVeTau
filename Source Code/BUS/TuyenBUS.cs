using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
using System.Data;


namespace BUS
{
    public class TuyenBUS
    {
        public static DataTable LayDSTuyen()
        {
            DataTable _ds = TuyenDAO.LayDSTuyen();
            return _ds;
        }

        public static List<TuyenDTO> LayDSTenTuyen()
        {
            List<TuyenDTO> _ds = TuyenDAO.LayDSTenTuyen();
            return _ds;
        }
        public static bool ThemTuyen(string tentuyen, string gakhoihanh, string gaketthuc)
        {
            bool i = TuyenDAO.ThemTuyen(tentuyen, gakhoihanh, gaketthuc);
            return i;
        }

        public static bool SuaTuyen(int matuyen, string tentuyen, string gakhoihanh, string gaketthuc)
        {
            bool i = TuyenDAO.SuaTuyen(matuyen, tentuyen, gakhoihanh, gaketthuc);
            return i;
        }

        public static bool XoaTuyen(int matuyen)
        {
            bool i = TuyenDAO.XoaTuyen(matuyen);
            return i;
        }

        public static DataTable TimkiemTuyen(string key)
        {
            DataTable _ds = TuyenDAO.TimkiemTuyen(key);
            return _ds;
        }

    }
}

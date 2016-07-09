using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class ChuyenBUS
    {
        public static DataTable TraCuuChuyenTau(string gadi, string gaden, string ngaydi)
        {
            DataTable dt = ChuyenDAO.TraCuuChuyenTau(gadi, gaden, ngaydi);
            return dt;
        }

        public static DataTable LayDSChuyen()
        {
            DataTable _ds = ChuyenDAO.LayDSChuyen();
            return _ds;
        }

        public static bool ThemChuyen(int madoantau, string tentuyen, string ngaygioxp, string nvlai, string nvtruong,int matoa1, int matoa2)
        {
            bool i = ChuyenDAO.ThemChuyen(madoantau, tentuyen, ngaygioxp, nvlai, nvtruong,matoa1,matoa2);
            return i;
        }

        public static bool SuaChuyen(int machuyen, int madoantau, string tentuyen, string ngaygioxp, string nvlai, string nvtruong, int matoa1, int matoa2)
        {
            bool i = ChuyenDAO.SuaChuyen(machuyen, madoantau, tentuyen, ngaygioxp, nvlai, nvtruong,matoa1,matoa2);
            return i;
        }

        public static bool XoaChuyen(int machuyen)
        {
            bool i = ChuyenDAO.XoaChuyen(machuyen);
            return i;
        }

        public static DataTable TimkiemNVcuaChuyen(string key)
        {
            DataTable _ds = ChuyenDAO.TimkiemNVcuaChuyen(key);
            return _ds;
        }
    }
}

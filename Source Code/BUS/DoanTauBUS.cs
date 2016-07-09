using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class DoanTauBUS
    {
        public static DataTable LayDSDoanTau()
        {
            DataTable _ds = DoanTauDAO.LayDSĐoanTau();
            return _ds;
        }

        public static List<DoanTauDTO> LayDSMaDoanTau()
        {
            List<DoanTauDTO> _ds = DoanTauDAO.LayDSMaDoanTau();
            return _ds;
        }
        public static string LayTenTauTheoMaDoanTau(int madoantau)
        {
            return DoanTauDAO.LayTenTauTheoMaDoanTau(madoantau);
        }

        public static int SoluongGhe(string tentau, int matoa, string tenloaighe)
        {
            return DoanTauDAO.SoluongGhe(tentau, matoa, tenloaighe);
        }

        public static bool ThemDoanTau(string tenloaitau, string tentau, string hangsanxuat, string ngayvanhanh)
        {
            bool i = DoanTauDAO.ThemDoanTau(tenloaitau, tentau, hangsanxuat, ngayvanhanh);
            return i;
        }

        public static bool SuaDoanTau(int madoantau, string tenloaitau, string tentau, string hangsanxuat, string ngayvanhanh)
        {
            bool i = DoanTauDAO.SuaDoanTau(madoantau, tenloaitau, tentau, hangsanxuat, ngayvanhanh);
            return i;
        }

        public static bool XoaDoanTau(int madoantau)
        {
            bool i = DoanTauDAO.XoaDoanTau(madoantau);
            return i;
        }

        public static DataTable TimkiemDoanTau(string key)
        {
            DataTable _ds = DoanTauDAO.TimkiemDoanTau(key);
            return _ds;
        }
    }
}

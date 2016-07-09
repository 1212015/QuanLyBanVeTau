using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class LoaiTauBUS
    {
        public static DataTable LayDSLoaiTau()
        {
            DataTable dt = LoaiTauDAO.LayDSLoaiTau();
            return dt;
        }

        public static List<LoaiTauDTO> LayTenToaTau()
        {
            List<LoaiTauDTO> _ds = LoaiTauDAO.LayTenLoaiTau();
            return _ds;
        }
    }
}

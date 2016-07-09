using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class LoaiGheBUS
    {
        public static DataTable LayDSGhe()
        {
            DataTable dt = LoaiGheDAO.LayDSGhe();
            return dt;
        }

        public static List<LoaiGheDTO> LayTenLoaiGhe()
        {
            List<LoaiGheDTO> _ds = LoaiGheDAO.LayTenLoaiGhe();
            return _ds;
        }
    }
}

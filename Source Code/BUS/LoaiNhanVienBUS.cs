using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class LoaiNhanVienBUS
    {
        public static DataTable LayDSLoaiNV()
        {
            DataTable dt = LoaiNhanVienDAO.LayDSLoaiNV();
            return dt;
        }
    }
}

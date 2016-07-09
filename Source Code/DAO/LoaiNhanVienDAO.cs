using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;

namespace DAO
{
    public class LoaiNhanVienDAO
    {
        public static DataTable LayDSLoaiNV()
        {
            //string sql = "select * from LoaiNhanVien";
            string sql = "Exec sp_LayDSLoaiNV";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }
    }
}

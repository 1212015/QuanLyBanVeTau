using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class LoaiGheDAO
    {
        public static DataTable LayDSGhe()
        {
            string sql = "Exec sp_LayDSGhe";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static List<LoaiGheDTO> LayTenLoaiGhe()
        {
            List<LoaiGheDTO> _ds = new List<LoaiGheDTO>();
            string sql = "select * from loaighe";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiGheDTO lg = new LoaiGheDTO();
                lg.MaLoaiGhe = int.Parse(dt.Rows[i]["MaLoaiGhe"].ToString());
                lg.TenLoaiGhe = (dt.Rows[i]["TenLoaiGhe"].ToString());
                lg.TiLeGia = float.Parse(dt.Rows[i]["TiLeGia"].ToString());

                _ds.Add(lg);
            }
            return _ds;
        }
    }
}

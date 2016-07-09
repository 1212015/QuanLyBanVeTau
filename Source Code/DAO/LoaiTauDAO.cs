using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class LoaiTauDAO
    {
        public static DataTable LayDSLoaiTau()
        {
            string sql = "Exec sp_LayDSLoaiTau";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static List<LoaiTauDTO> LayTenLoaiTau()
        {
            List<LoaiTauDTO> _ds = new List<LoaiTauDTO>();
            string sql = "select * from loaitau";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiTauDTO lt = new LoaiTauDTO();
                lt.MaLoaiTau = int.Parse(dt.Rows[i]["MaLoaiTau"].ToString());
                lt.TenLoaiTau = (dt.Rows[i]["TenLoaiTau"].ToString());
                lt.TiLeGia = float.Parse(dt.Rows[i]["TiLeGia"].ToString());

                _ds.Add(lt);
            }
            return _ds;
        }
    }
}

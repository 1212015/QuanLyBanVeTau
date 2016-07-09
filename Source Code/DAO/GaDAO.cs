using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class GaDAO
    {
        public static DataTable LayDSGa()
        {
            string sql = "Exec sp_LayDSGa";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static string LayDCGa(string tenGa)
        {
            string dc;
            string sql = string.Format("select g.DiaChi from ga as g where g.TenGa = N'{0}'", tenGa);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
            {
                dc = (dt.Rows[0][0].ToString());
            }
            else
            {
                return "";
            }
            return dc;
        }

        public static List<GaDTO> LayDSGa1()
        {
            List<GaDTO> _ds = new List<GaDTO>();
            string sql = "select * from ga";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                GaDTO g = new GaDTO();
                g.MaGa = int.Parse(dt.Rows[i]["MaGa"].ToString());
                g.TenGa = dt.Rows[i]["TenGa"].ToString();
                g.DiaChi = dt.Rows[i]["DiaChi"].ToString();

                _ds.Add(g);
            }
            return _ds;
        }
    }
}

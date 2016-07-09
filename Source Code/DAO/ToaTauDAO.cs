using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class ToaTauDAO
    {
        public static List<ToaTauDTO> LayMaToaTau()
        {
            List<ToaTauDTO> _ds = new List<ToaTauDTO>();
            string sql = "select * from toatau";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ToaTauDTO t = new ToaTauDTO();
                t.MaToa = int.Parse(dt.Rows[i]["MaToa"].ToString());
                t.MaDoanTau = int.Parse(dt.Rows[i]["MaDoanTau"].ToString());
                t.STT = int.Parse(dt.Rows[i]["STT"].ToString());

                _ds.Add(t);
            }
            return _ds;
        }

        public static List<ToaTauDTO> LayMaToaTauTheoTenTau(string tentau)
        {
            List<ToaTauDTO> _ds = new List<ToaTauDTO>();
            string sql = string.Format("EXEC sp_LayMaToaTauTheoTenTau N'{0}'", tentau);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ToaTauDTO t = new ToaTauDTO();
                t.MaToa = int.Parse(dt.Rows[i]["MaToa"].ToString());
                t.MaDoanTau = int.Parse(dt.Rows[i]["MaDoanTau"].ToString());
                t.STT = int.Parse(dt.Rows[i]["STT"].ToString());

                _ds.Add(t);
            }
            return _ds;
        }
    }
}

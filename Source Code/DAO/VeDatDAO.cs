using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class VeDatDAO
    {
        public static bool DatVe(VeDatDTO vd)
        {
            bool kq;
            string sql = string.Format("Exec sp_Datve '{0}', '{1}', N'{2}', N'{3}', '{4}', '{5}'", vd.MaVe, vd.MaChuyen, vd.GaDi, vd.GaDen, vd.MaGiaVe, vd.MaGhe);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }
        public static int MaTuTang()
        {
            string sql = "SELECT TOP 1 MaVe  FROM vedat ORDER BY MaVe DESC";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return int.Parse(dt.Rows[0][0].ToString());
        }
    }
}

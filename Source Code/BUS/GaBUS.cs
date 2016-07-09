using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class GaBUS
    {
        public static DataTable LayDSGa()
        {
            DataTable dt = GaDAO.LayDSGa();
            return dt;
        }

        public static List<GaDTO> LayDSGa1()
        {
            List<GaDTO> _ds = GaDAO.LayDSGa1();
            return _ds;
        }

        public static string LayDCGa(string tenGa)
        {
            string dc;
            dc = GaDAO.LayDCGa(tenGa);
            return dc;
        }
    }
}

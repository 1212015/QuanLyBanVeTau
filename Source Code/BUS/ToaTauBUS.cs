using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
using System.Data;
namespace BUS
{
    public class ToaTauBUS
    {
        public static List<ToaTauDTO> LayMaToaTau()
        {
            List<ToaTauDTO> _ds = ToaTauDAO.LayMaToaTau();
            return _ds;
        }
        public static List<ToaTauDTO> LayMaToaTauTheoTenTau(string tentau)
        {
            List<ToaTauDTO> _ds = ToaTauDAO.LayMaToaTauTheoTenTau(tentau);
            return _ds;
        }
    }
}

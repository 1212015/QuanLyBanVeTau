using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class BanBUS
    {
        //Rút trích dữ liệu: select 
        public static List<BanDTO> LayDSBan()
        {
            List<BanDTO> _ds;
            _ds = BanDAO.LayDSBan();
            return _ds;
        }
    }
}

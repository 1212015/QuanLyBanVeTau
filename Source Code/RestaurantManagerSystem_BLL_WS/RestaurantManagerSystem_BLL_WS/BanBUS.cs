using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RestaurantManagerSystem_BLL_WS.RestaurantManagerSystem_DAL_WS;

namespace BUS
{
    public class BanBUS
    {
        RestaurantManagerSystem_DAL_WebServiceSoapClient BAN;
        public BanBUS()
        {
            BAN = new RestaurantManagerSystem_DAL_WebServiceSoapClient();
        }
        //Rút trích dữ liệu: select 
        public BanDTO[] LayDSBan()
        {
            return BAN.LayDSBan();
        }
    }
}

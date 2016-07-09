using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RestaurantManagerSystem_BLL_WS.RestaurantManagerSystem_DAL_WS;

namespace BUS
{
    public class LoaiThucDonBUS
    {
        RestaurantManagerSystem_DAL_WebServiceSoapClient LTD;
        public LoaiThucDonBUS()
        {
            LTD = new RestaurantManagerSystem_DAL_WebServiceSoapClient();
        }

        public LoaiThucDonDTO[] LayDSLoaiThucDon()
        {
            return LTD.LayDSLoaiThucDon();
        }

        public int LayMaLoaiTuTenLoai(string tenLoai)
        {
            return LTD.LayMaLoaiTuTenLoai(tenLoai);
        }
    }
}

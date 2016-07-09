using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RestaurantManagerSystem_BLL_WS.RestaurantManagerSystem_DAL_WS;

namespace BUS
{
    public class CT_HoaDonBUS
    {
        RestaurantManagerSystem_DAL_WebServiceSoapClient CT;
        public CT_HoaDonBUS()
        {
            CT = new RestaurantManagerSystem_DAL_WebServiceSoapClient();
        }
        public bool ThemChiTietHoaDon(CT_HoaDonDTO cthd)
        {
            return CT.ThemChiTietHoaDon(cthd);
        }
        public bool XoaCTHDTheoSoHD(int soHD)
        {
            return CT.XoaCTHDTheoSoHD(soHD);
        }
        public bool XoaCTHDTheoSoHDVaMaTD(int soHD, int MaTD)
        {
            return CT.XoaCTHDTheoSoHDVaMaTD(soHD,MaTD);
        }
        public CTHDDTO[] LayDSCTHDTuMaHD(int maHD)
        {
            return CT.LayDSCTHDTuMaHD(maHD);
        }
        public CT_HoaDonDTO[] LayDSCTHD(int SoHD)
        {
            return CT.LayDSCTHD(SoHD);
        }
    }
}

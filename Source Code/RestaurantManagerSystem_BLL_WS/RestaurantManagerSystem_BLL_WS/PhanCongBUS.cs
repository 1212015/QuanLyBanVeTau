using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RestaurantManagerSystem_BLL_WS.RestaurantManagerSystem_DAL_WS;

namespace BUS
{
    public class PhanCongBUS
    {
        RestaurantManagerSystem_DAL_WebServiceSoapClient PC;
        public PhanCongBUS()
        {
            PC = new RestaurantManagerSystem_DAL_WebServiceSoapClient();
        }
        public PCDTO[] LayDSPhanCong()
        {
            return PC.LayDSPhanCong();
        }
        public bool ThemPhanCong(PhanCongDTO pc)
        {
            return PC.ThemPhanCong(pc);
        }
        public bool XoaPhanCong(PhanCongDTO pc)
        {
            return PC.XoaPhanCong(pc);
        }

        public int LayMaNVTheoMaBanVaCa(int maBan, int ca)
        {
            return PC.LayMaNVTheoMaBanVaCa(maBan,ca);
        }

        public int LayCaTheoGio(int gio)
        {
            return PC.LayCaTheoGio(gio);
        }
    }
}

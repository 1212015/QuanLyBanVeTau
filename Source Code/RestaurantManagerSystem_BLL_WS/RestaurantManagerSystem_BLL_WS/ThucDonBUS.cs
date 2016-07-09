using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RestaurantManagerSystem_BLL_WS.RestaurantManagerSystem_DAL_WS;

namespace BUS
{
    public class ThucDonBUS
    {
        RestaurantManagerSystem_DAL_WebServiceSoapClient TD;
        public ThucDonBUS()
        {
            TD = new RestaurantManagerSystem_DAL_WebServiceSoapClient();
        }
        public bool ThemThucDon(ThucDonDTO td)
        {
            return TD.ThemThucDon(td);
        }

        public bool XoaThucDonTheoMaTD(int maTD)
        {
            return TD.XoaThucDonTheoMaTD(maTD);
        }

        public bool CapNhatThucDon(ThucDonDTO td)
        {
            return TD.CapNhatThucDon(td);
        }

        public ThucDonDTO[] LayDSThucDon()
        {
            return TD.LayDSThucDon();
        }

        public ThucDonDTO[] LayDSThucDonTheoMaLoai(int maLoai)
        {
            return TD.LayDSThucDonTheoMaLoai(maLoai);
        }

        public ThucDonDTO[] LayDSMaTDVaTenTDTheoMaLoai(int maLoai)
        {
            return TD.LayDSMaTDVaTenTDTheoMaLoai(maLoai);
        }

        public string LayTenThucDonTuMaThucDon(int maTD)
        {
            return TD.LayTenThucDonTuMaThucDon(maTD);
        }
        public int LayMaThucDonTuTenThucDon(string tenTD)
        {
            return TD.LayMaThucDonTuTenTD(tenTD);
        }

        public TDDTO[] LayDanhSachTDTheoMaLoai(int maLoai)
        {
            return TD.LayDanhSachTDTheoMaLoai(maLoai);
        }

        public string LayDonViTinhTuMaTD(int maTD)
        {
            return TD.LayDonViTinhTheoMaTD(maTD);
        }

        public bool KiemTraThucAnNuocUong(int maTD)
        {
            return TD.KiemTraThucDonNuocUong(maTD);
        }

        public bool KiemTraTrungTenThucDon(string tenTD)
        {
            return TD.KiemTraTrungTenThucDon(tenTD);
        }

        public bool KiemTraTenTDCapNhat(string tenTD, int maTD)
        {
            return TD.KiemTraTenTDCapNhat(tenTD,maTD);
        }

        public TDDTO[] TraCuuThucDonTheoTen(string tenTD)
        {
            return TD.TraCuuThucDonTheoTen(tenTD);
        }

        public int TDMaTuTang()
        {
            return TD.TDMaTuTang();
        }

        public float LayGiaTheoMaTD(int maTD)
        {
            return TD.LayGiaTheoMaTD(maTD);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RestaurantManagerSystem_BLL_WS.RestaurantManagerSystem_DAL_WS;

namespace BUS
{
    public class HoaDonBUS
    {
        RestaurantManagerSystem_DAL_WebServiceSoapClient HD;
        public HoaDonBUS()
        {
            HD = new RestaurantManagerSystem_DAL_WebServiceSoapClient();
        }
        public HDTKDTO[] LayDSHoaDon()
        {
            return HD.LayDSHoaDon();
        }
        public int LaySoHDTuMaBan(int maBan)
        {
            return HD.LaySoHoaDonTuMaBan(maBan);
        }
        public int LaySoKhachTuSoHD(int soHD)
        {
            return HD.LaySoKhachTuSoHD(soHD);
        }
        public List<int> LayDSBanChuaThanhToan()
        {
            return HD.LayDSBanChuaThanhToan();
        }

        public int LayGioLapHDChuaThanhToanTheoMaBan(int maBan)
        {
            return HD.LayGioLapHDChuaThanhToanTheoMaBan(maBan);
        }

        public bool LapHoaDon(HoaDonDTO hd)
        {
            return HD.LapHoaDon(hd);
        }
        public bool CapNhatLapHoaDon(HoaDonDTO hd)
        {
            return HD.CapNhatLapHoaDon(hd);
        }

        public bool CapNhatSoKhach(int SoKhach, int SoHD)
        {
            return HD.CapNhatSoKhach(SoKhach,SoHD);
        }

        public int LayMaHoaDonCanLap()
        {
            return HD.HDMaTuTang();
        }

        public bool XoaHDTheoSoHD(int SoHD)
        {
            return HD.XoaHDTheoSoHD(SoHD);
        }

        public HDTKDTO[] ThongKeHDTheoNgay(DateTime ngay)
        {
            return HD.ThongKeHDTheoNgay(ngay);
        }

        public HDTKDTO[] ThongKeHDTheoThang(int thang, int nam)
        {
            return HD.ThongKeHDTheoThang(thang,nam);
        }

        public HDTKDTO[] ThongKeHDTheoKhoangNgay(DateTime tuNgay, DateTime denNgay)
        {
            return HD.ThongKeHDTheoKhoangNgay(tuNgay,denNgay);
        }
    }
}

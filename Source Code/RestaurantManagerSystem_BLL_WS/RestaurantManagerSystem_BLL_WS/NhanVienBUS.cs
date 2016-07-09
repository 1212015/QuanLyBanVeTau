using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RestaurantManagerSystem_BLL_WS.RestaurantManagerSystem_DAL_WS;

namespace BUS
{
    public class NhanVienBUS
    {
        RestaurantManagerSystem_DAL_WebServiceSoapClient NV;
        public NhanVienBUS()
        {
            NV = new RestaurantManagerSystem_DAL_WebServiceSoapClient();
        }
        public NhanVienDTO[] LayDSNhanVien()
        {
            return NV.LayDSNhanVien();
        }

        public NhanVienDTO[] LayDSNhanVienTiepTan()
        {
            return NV.LayDSNhanVienTiepTan();
        }

        public NhanVienDTO[] LayDSNhanVienCoMK()
        {
            return NV.LayDSNhanVienCoMK();
        }
        public string LayMatKhauTuTenDN(string TenDN)
        {
            return NV.LayMatKhauTuTenDN(TenDN);
        }

        public int LayMaNVTuTenNV(string tenNV)
        {
            return NV.LayMaNVTuTenNV(tenNV);
        }

        public string LayTenNVTheoMaNV(int maNV)
        {
            return NV.LayTenNVTheoMaNV(maNV);
        }

        public string LayQuyenNVTheoMaNV(int maNV)
        {
            return NV.LayQuyenNVTheoMaNV(maNV);
        }

        public bool ThemNhanVien(NhanVienDTO nd)
        {
            return NV.ThemNhanVien(nd);
        }

        //Cập nhật thông tin người dùng
        public bool CapNhatNhanVien(NhanVienDTO nv)
        {
            return NV.CapNhatNhanVien(nv);
        }

        //Xóa người dùng
        public bool XoaNhanVien(int maNV)
        {
            return NV.XoaNhanVien(maNV);
        }

        public bool KiemTraTenDNTonTai(string tenDN, int MaNV)
        {
            return NV.KiemTraTenDNTonTai(tenDN,MaNV);
        }

        public NhanVienDTO[] TraCuuNhanVienTheoTen(string tenNV)
        {
            return NV.TraCuuNhanVienTheoTen(tenNV);
        }

        public bool CheckConnection()
        {
            return NV.CheckConnection();
        }
    }
}

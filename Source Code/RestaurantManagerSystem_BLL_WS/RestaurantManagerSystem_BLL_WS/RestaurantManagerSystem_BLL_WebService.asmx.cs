using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Data;
using RestaurantManagerSystem_BLL_WS.RestaurantManagerSystem_DAL_WS;
using BUS;
namespace RestaurantManagerSystem_BLL_WS
{
    /// <summary>
    /// Summary description for RestaurantManagerSystem_BLL_WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class RestaurantManagerSystem_BLL_WebService : System.Web.Services.WebService
    {
        BanBUS BAN = new BanBUS();
        CT_HoaDonBUS CT = new CT_HoaDonBUS();
        HoaDonBUS HD = new HoaDonBUS();
        LoaiThucDonBUS LTD = new LoaiThucDonBUS();
        NhanVienBUS NV = new NhanVienBUS();
        PhanCongBUS PC = new PhanCongBUS();
        ThucDonBUS TD = new ThucDonBUS();
        [WebMethod]
        public BanDTO[] LayDSBan()
        {
            return BAN.LayDSBan();
        }
        [WebMethod]
        public bool ThemChiTietHoaDon(CT_HoaDonDTO cthd)
        {
            return CT.ThemChiTietHoaDon(cthd);
        }
        [WebMethod]
        public bool XoaCTHDTheoSoHD(int soHD)
        {
            return CT.XoaCTHDTheoSoHD(soHD);
        }
        [WebMethod]
        public bool XoaCTHDTheoSoHDVaMaTD(int soHD, int MaTD)
        {
            return CT.XoaCTHDTheoSoHDVaMaTD(soHD, MaTD);
        }
        [WebMethod]
        public CTHDDTO[] LayDSCTHDTuMaHD(int maHD)
        {
            return CT.LayDSCTHDTuMaHD(maHD);
        }
        [WebMethod]
        public CT_HoaDonDTO[] LayDSCTHD(int SoHD)
        {
            return CT.LayDSCTHD(SoHD);
        }
        [WebMethod]
        public HDTKDTO[] LayDSHoaDon()
        {
            return HD.LayDSHoaDon();
        }
        [WebMethod]
        public int LaySoHDTuMaBan(int maBan)
        {
            return HD.LaySoHDTuMaBan(maBan);
        }
        [WebMethod]
        public int LaySoKhachTuSoHD(int soHD)
        {
            return HD.LaySoKhachTuSoHD(soHD);
        }
        [WebMethod]
        public List<int> LayDSBanChuaThanhToan()
        {
            return HD.LayDSBanChuaThanhToan();
        }
        [WebMethod]
        public int LayGioLapHDChuaThanhToanTheoMaBan(int maBan)
        {
            return HD.LayGioLapHDChuaThanhToanTheoMaBan(maBan);
        }
        [WebMethod]
        public bool LapHoaDon(HoaDonDTO hd)
        {
            return HD.LapHoaDon(hd);
        }
        [WebMethod]
        public bool CapNhatLapHoaDon(HoaDonDTO hd)
        {
            return HD.CapNhatLapHoaDon(hd);
        }
        [WebMethod]
        public bool CapNhatSoKhach(int SoKhach, int SoHD)
        {
            return HD.CapNhatSoKhach(SoKhach, SoHD);
        }
        [WebMethod]
        public int LayMaHoaDonCanLap()
        {
            return HD.LayMaHoaDonCanLap();
        }
        [WebMethod]
        public bool XoaHDTheoSoHD(int SoHD)
        {
            return HD.XoaHDTheoSoHD(SoHD);
        }
        [WebMethod]
        public HDTKDTO[] ThongKeHDTheoNgay(DateTime ngay)
        {
            return HD.ThongKeHDTheoNgay(ngay);
        }
        [WebMethod]
        public HDTKDTO[] ThongKeHDTheoThang(int thang, int nam)
        {
            return HD.ThongKeHDTheoThang(thang, nam);
        }
        [WebMethod]
        public HDTKDTO[] ThongKeHDTheoKhoangNgay(DateTime tuNgay, DateTime denNgay)
        {
            return HD.ThongKeHDTheoKhoangNgay(tuNgay, denNgay);
        }
        [WebMethod]
        public LoaiThucDonDTO[] LayDSLoaiThucDon()
        {
            return LTD.LayDSLoaiThucDon();
        }
        [WebMethod]
        public int LayMaLoaiTuTenLoai(string tenLoai)
        {
            return LTD.LayMaLoaiTuTenLoai(tenLoai);
        }
        [WebMethod]
        public NhanVienDTO[] LayDSNhanVien()
        {
            return NV.LayDSNhanVien();
        }
        [WebMethod]
        public NhanVienDTO[] LayDSNhanVienTiepTan()
        {
            return NV.LayDSNhanVienTiepTan();
        }
        [WebMethod]
        public NhanVienDTO[] LayDSNhanVienCoMK()
        {
            return NV.LayDSNhanVienCoMK();
        }
        [WebMethod]
        public string LayMatKhauTuTenDN(string TenDN)
        {
            return NV.LayMatKhauTuTenDN(TenDN);
        }
        [WebMethod]
        public int LayMaNVTuTenNV(string tenNV)
        {
            return NV.LayMaNVTuTenNV(tenNV);
        }
        [WebMethod]
        public string LayTenNVTheoMaNV(int maNV)
        {
            return NV.LayTenNVTheoMaNV(maNV);
        }
        [WebMethod]
        public string LayQuyenNVTheoMaNV(int maNV)
        {
            return NV.LayQuyenNVTheoMaNV(maNV);
        }
        [WebMethod]
        public bool ThemNhanVien(NhanVienDTO nd)
        {
            return NV.ThemNhanVien(nd);
        }
        [WebMethod]
        public bool CapNhatNhanVien(NhanVienDTO nv)
        {
            return NV.CapNhatNhanVien(nv);
        }
        [WebMethod]
        public bool XoaNhanVien(int maNV)
        {
            return NV.XoaNhanVien(maNV);
        }
        [WebMethod]
        public bool KiemTraTenDNTonTai(string tenDN, int MaNV)
        {
            return NV.KiemTraTenDNTonTai(tenDN, MaNV);
        }
        [WebMethod]
        public NhanVienDTO[] TraCuuNhanVienTheoTen(string tenNV)
        {
            return NV.TraCuuNhanVienTheoTen(tenNV);
        }
        [WebMethod]
        public bool CheckConnection()
        {
            return NV.CheckConnection();
        }
        [WebMethod]
        public PCDTO[] LayDSPhanCong()
        {
            return PC.LayDSPhanCong();
        }
        [WebMethod]
        public bool ThemPhanCong(PhanCongDTO pc)
        {
            return PC.ThemPhanCong(pc);
        }
        [WebMethod]
        public bool XoaPhanCong(PhanCongDTO pc)
        {
            return PC.XoaPhanCong(pc);
        }
        [WebMethod]
        public int LayMaNVTheoMaBanVaCa(int maBan, int ca)
        {
            return PC.LayMaNVTheoMaBanVaCa(maBan, ca);
        }
        [WebMethod]
        public int LayCaTheoGio(int gio)
        {
            return PC.LayCaTheoGio(gio);
        }
        [WebMethod]
        public bool ThemThucDon(ThucDonDTO td)
        {
            return TD.ThemThucDon(td);
        }
        [WebMethod]
        public bool XoaThucDonTheoMaTD(int maTD)
        {
            return TD.XoaThucDonTheoMaTD(maTD);
        }
        [WebMethod]
        public bool CapNhatThucDon(ThucDonDTO td)
        {
            return TD.CapNhatThucDon(td);
        }
        [WebMethod]
        public ThucDonDTO[] LayDSThucDon()
        {
            return TD.LayDSThucDon();
        }
        [WebMethod]
        public ThucDonDTO[] LayDSThucDonTheoMaLoai(int maLoai)
        {
            return TD.LayDSThucDonTheoMaLoai(maLoai);
        }
        [WebMethod]
        public ThucDonDTO[] LayDSMaTDVaTenTDTheoMaLoai(int maLoai)
        {
            return TD.LayDSMaTDVaTenTDTheoMaLoai(maLoai);
        }
        [WebMethod]
        public string LayTenThucDonTuMaThucDon(int maTD)
        {
            return TD.LayTenThucDonTuMaThucDon(maTD);
        }
        [WebMethod]
        public int LayMaThucDonTuTenThucDon(string tenTD)
        {
            return TD.LayMaThucDonTuTenThucDon(tenTD);
        }
        [WebMethod]
        public TDDTO[] LayDanhSachTDTheoMaLoai(int maLoai)
        {
            return TD.LayDanhSachTDTheoMaLoai(maLoai);
        }
        [WebMethod]
        public string LayDonViTinhTuMaTD(int maTD)
        {
            return TD.LayDonViTinhTuMaTD(maTD);
        }
        [WebMethod]
        public bool KiemTraThucAnNuocUong(int maTD)
        {
            return TD.KiemTraThucAnNuocUong(maTD);
        }
        [WebMethod]
        public bool KiemTraTrungTenThucDon(string tenTD)
        {
            return TD.KiemTraTrungTenThucDon(tenTD);
        }
        [WebMethod]
        public bool KiemTraTenTDCapNhat(string tenTD, int maTD)
        {
            return TD.KiemTraTenTDCapNhat(tenTD, maTD);
        }
        [WebMethod]
        public TDDTO[] TraCuuThucDonTheoTen(string tenTD)
        {
            return TD.TraCuuThucDonTheoTen(tenTD);
        }
        [WebMethod]
        public int TDMaTuTang()
        {
            return TD.TDMaTuTang();
        }
        [WebMethod]
        public float LayGiaTheoMaTD(int maTD)
        {
            return TD.LayGiaTheoMaTD(maTD);
        }
    }
}

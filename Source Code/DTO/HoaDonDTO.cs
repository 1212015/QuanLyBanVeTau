using System;
using System.Collections.Generic;

namespace DTO
{
    public class HoaDonDTO
    {
        private int _maHoaDon;
        private int _maKhachHang;        
        private int _maVe;
        private int _maNV;
        private float _donGia;
        private int _soLuong;
        private float _tongTien;

        //Phương thức khởi tạo mặc định
        public HoaDonDTO()
        {
            _maHoaDon = 0;
            _maKhachHang= 0;
            _maVe = 0;
            _maNV = 0;
            _donGia = 0;
            _soLuong = 0;
            _tongTien = 0;
        }

        //Phương thức khởi tạo có tham số
        public HoaDonDTO(int maHoaDon, int maKhachHang, int maVe, int maNV, float donGia, int soLuong, float tongTien)
        {
            _maHoaDon = maHoaDon;
            _maKhachHang = maKhachHang;
            _maVe = maVe;
            _maNV = maNV;
            _donGia = donGia;
            _soLuong = soLuong;
            _tongTien = tongTien;
        }

        //Phương thức khởi tạo sao chép.
        public HoaDonDTO(HoaDonDTO HoaDon)
        {
            _maHoaDon = HoaDon._maHoaDon;
            _maKhachHang = HoaDon._maKhachHang;
            _maVe = HoaDon._maVe;
            _maNV = HoaDon._maNV;
            _donGia = HoaDon._donGia;
            _soLuong = HoaDon._soLuong;
            _tongTien = HoaDon._tongTien;
        }

        //Properties
        public int MaHoaDon
        {
            get { return _maHoaDon; }
            set { _maHoaDon = value; }
        }
        public int MaKhachHang
        {
            get { return _maKhachHang; }
            set { _maKhachHang = value; }
        }

        public int MaVe
        {
            get { return _maVe; }
            set { _maVe = value; }
        }

        public int MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        public float DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        public float TongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }
    }
}

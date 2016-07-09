using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ChuyenDTO
    {
        private int _maChuyen;
        private int _maDoanTau;
        private int _maTuyen;
        private DateTime _ngayGioXuatPhat;
        private int _nhanVienLai;
        private int _nhanVienTruong;
        //Phương thức khởi tạo mặc định
        public ChuyenDTO()
        {
            _maChuyen = 0;
            _maDoanTau = 0;
            _maTuyen = 0;
            _ngayGioXuatPhat = DateTime.Today;
            _nhanVienLai = 0;
            _nhanVienTruong = 0;


        }

        //Phương thức khởi tạo có tham số
        public ChuyenDTO(int maChuyen, int maDoanTau, int maTuyen, DateTime ngayGioXuatPhat, int nhanVienLai, int nhanVienTruong )
        {
            _maChuyen = maChuyen;
            _maDoanTau = maDoanTau;
            _maTuyen = maTuyen;
            _ngayGioXuatPhat = ngayGioXuatPhat;
            _nhanVienLai = nhanVienLai;
            _nhanVienTruong = nhanVienTruong;
        }

        //Phương thức khởi tạo sao chép.
        public ChuyenDTO(ChuyenDTO chuyen)
        {
            _maChuyen = chuyen._maChuyen;
            _maDoanTau = chuyen._maDoanTau;
            _maTuyen = chuyen._maTuyen;
            _ngayGioXuatPhat = chuyen._ngayGioXuatPhat;
            _nhanVienLai = chuyen._nhanVienLai;
            _nhanVienTruong = chuyen._nhanVienTruong;
        }

        //Properties
        public int MaChuyen
        {
            get { return _maChuyen; }
            set { _maChuyen = value; }
        }
        public int MaDoanTau
        {
            get { return _maDoanTau; }
            set { _maDoanTau = value; }
        }
        public int MaTuyen
        {
            get { return _maTuyen; }
            set { _maTuyen = value; }
        }
        public DateTime NgayGioXuatPhat
        {
            get { return _ngayGioXuatPhat; }
            set { _ngayGioXuatPhat = value; }
        }
        public int NhanVienLai
        {
            get { return _nhanVienLai; }
            set { _nhanVienLai = value; }
        }
        public int NhanVienTruong
        {
            get { return _nhanVienTruong; }
            set { _nhanVienTruong = value; }
        }
    }
}

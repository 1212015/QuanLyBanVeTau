using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhanCongNhanVienDTO
    {
        private int _maPhanCong;
        private int _maChuyen;
        private int _maToa;
        private int _maNV;
        private int _trangThai;

        //Phương thức khởi tạo mặc đinh
        public PhanCongNhanVienDTO()
        {
            _maPhanCong=0;
            _maChuyen=0;
            _maToa=0;
            _maNV=0;
            _trangThai=1;
        }

        //Phương thức khởi tạo có tham số
        public PhanCongNhanVienDTO(int maPhanCong, int maChuyen, int maToa, int maNV, int trangThai)
        {
            _maPhanCong = maPhanCong;
            _maChuyen = maChuyen;
            _maToa = maToa;
            _maNV= maNV;
            _trangThai= trangThai;
            

        }

        //Phương thức khỏi tạo sao chép
        public PhanCongNhanVienDTO(PhanCongNhanVienDTO phancongnhanvien )
        {
            _maPhanCong = phancongnhanvien._maPhanCong;
            _maChuyen = phancongnhanvien._maChuyen;
            _maToa = phancongnhanvien._maToa;
            _maNV = phancongnhanvien._maNV;
            _trangThai = phancongnhanvien._trangThai;
        }

        //properties
        public int MaPhanCong
        {
            get { return _maPhanCong; }
            set { _maPhanCong = value; }
        }

        public int MaChuyen
        {
            get { return _maChuyen; }
            set { _maChuyen = value; }
        }
         public int MaToa
        {
            get { return _maToa; }
            set { _maToa = value; }
        }
         public int MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }
         public int TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }
    }
}

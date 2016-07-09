using System;
using System.Collections.Generic;

namespace DTO
{
    public class DonNghiPhepDTO
    {
        private int _maDonNP;        
        private int _maNV;
        private int _maPC;
        private string _lyDo;
        private int _trangThai;

        //Phương thức khởi tạo mặc định
        public DonNghiPhepDTO()
        {
            _maDonNP = 0;
            _maNV = 0;
            _maPC = 0;
            _trangThai = 0;
            _lyDo = "";
        }

        //Phương thức khởi tạo có tham số
        public DonNghiPhepDTO(int maDonNP, int maNV, int maPC, int trangThai, string lyDo)
        {
            _maDonNP = maDonNP;
            _maNV = maNV;
            _maPC = maPC;
            _trangThai = trangThai;
            _lyDo = lyDo;
        }

        //Phương thức khởi tạo sao chép.
        public DonNghiPhepDTO(DonNghiPhepDTO HoaDon)
        {
            _maDonNP = HoaDon._maDonNP;
            _maNV = HoaDon._maNV;
            _maPC = HoaDon._maPC;
            _trangThai = HoaDon._trangThai;
            _lyDo = HoaDon._lyDo;
        }

        //Properties
        public int MaDonNP
        {
            get { return _maDonNP; }
            set { _maDonNP = value; }
        }
        

        public int MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        public int SoKhach
        {
            get { return _maPC; }
            set { _maPC = value; }
        }

        public int TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }

        public string LyDo
        {
            get { return _lyDo; }
            set { _lyDo = value; }
        }

    }
}

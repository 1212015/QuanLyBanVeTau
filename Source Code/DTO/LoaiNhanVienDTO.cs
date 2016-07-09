using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    class LoaiNhanVienDTO
    {
         private int _maLoaiNV;
        private string _tenLoaiNV;
        private float _mucLuongChinh;
        private float _phuCap;

        //Phương thức khởi tạo mặc định
        public LoaiNhanVienDTO()
        {
            _maLoaiNV = 0;
            _tenLoaiNV = "";
            _mucLuongChinh = 0;
            _phuCap = 0;
        }

        //Phương thức khởi tạo có tham số
        public LoaiNhanVienDTO(int maLoaiNV, string tenLoaiNV, float mucLuongChinh, float phuCap)
        {
            _maLoaiNV = maLoaiNV;
            _tenLoaiNV = tenLoaiNV;
            _mucLuongChinh = mucLuongChinh;
            _phuCap = phuCap;

        }

        //Phương thức khởi tạo sao chép.
        public LoaiNhanVienDTO(LoaiNhanVienDTO loainhanvien)
        {
            _maLoaiNV = loainhanvien._maLoaiNV;
            _tenLoaiNV = loainhanvien._tenLoaiNV;
            _mucLuongChinh = loainhanvien._mucLuongChinh;
            _phuCap = loainhanvien._phuCap;
        }

        //Properties
        public int MaLoaiNV
        {
            get { return _maLoaiNV; }
            set { _maLoaiNV = value; }
        }
        public string TenLoaiNV
        {
            get { return _tenLoaiNV; }
            set { _tenLoaiNV = value; }
        }
        public float MucLuongChinh
        {
            get { return _mucLuongChinh; }
            set { _mucLuongChinh = value; }
        }
        public float PhuCap
        {
            get { return _phuCap; }
            set { _phuCap = value; }
        }
    }
}

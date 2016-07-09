using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TuyenDTO
    {
        private int _MaTuyen;
        private string _TenTuyen;
        private int _GaKhoiHanh;
        private int _GaKetThuc;

        //Phương thức khởi tạo mặc định
        public TuyenDTO()
        {
            _MaTuyen=0;
            _TenTuyen="";
            _GaKhoiHanh=0;
            _GaKetThuc=0;
        }

        //Phương thức khởi tạo có tham số
        public TuyenDTO(int MaTuyen, string TenTuyen, int GaKhoiHanh,int GaKetThuc)
        {
            _MaTuyen = MaTuyen;
            _TenTuyen = TenTuyen;
            _GaKhoiHanh = GaKhoiHanh;
            _GaKetThuc = GaKetThuc;
        }

        //Phương thức khởi tạo sao chép.
        public TuyenDTO(TuyenDTO VD)
        {
            _MaTuyen = VD._MaTuyen;
            _TenTuyen = VD._TenTuyen;
            _GaKhoiHanh = VD._GaKhoiHanh;
            _GaKetThuc = VD._GaKetThuc;
        }

        //Properties
        public int MaTuyen
        {
            get { return _MaTuyen; }
            set { _MaTuyen = value; }
        }
        public string TenTuyen 
        {
            get { return _TenTuyen; }
            set { _TenTuyen = value; }
        }

        public int GaKhoiHanh
        {
            get { return _GaKhoiHanh; }
            set { _GaKhoiHanh = value; }
        }

        public int GaKetThuc
        {
            get { return _GaKetThuc; }
            set { _GaKetThuc = value; }
        }
    }
}

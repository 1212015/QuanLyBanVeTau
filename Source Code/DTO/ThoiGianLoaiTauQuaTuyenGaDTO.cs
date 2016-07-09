using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    class ThoiGianLoaiTauQuaTuyenGaDTO
    {
        private int _MaThoiGianLoaiTauQuaTuyenGa;
        private int _MaTuyenGa;
        private int _MaLoaiTau;
        private int _ThoiGianDi;

        //Phương thức khởi tạo mặc định
        public ThoiGianLoaiTauQuaTuyenGaDTO()
        {
            _MaThoiGianLoaiTauQuaTuyenGa=0;
            _MaTuyenGa=0;
            _MaLoaiTau=0;
            _ThoiGianDi=0;
        }

        //Phương thức khởi tạo có tham số
        public ThoiGianLoaiTauQuaTuyenGaDTO (int MaThoiGianLoaiTauQuaTuyenGa, int MaTuyenGa, int MaLoaiTau,int ThoiGianDi)
        {
            _MaThoiGianLoaiTauQuaTuyenGa = MaThoiGianLoaiTauQuaTuyenGa;
            _MaTuyenGa = MaTuyenGa;
            _MaLoaiTau = MaLoaiTau;
            _ThoiGianDi = ThoiGianDi;
        }

        //Phương thức khởi tạo sao chép.
        public ThoiGianLoaiTauQuaTuyenGaDTO (ThoiGianLoaiTauQuaTuyenGaDTO VD)
        {
            _MaThoiGianLoaiTauQuaTuyenGa = VD._MaThoiGianLoaiTauQuaTuyenGa;
            _MaTuyenGa = VD._MaTuyenGa;
            _MaLoaiTau = VD._MaLoaiTau;
            _ThoiGianDi = VD._ThoiGianDi;
        }

        //Properties
        public int MaThoiGianLoaiTauQuaTuyenGa
        {
            get { return _MaThoiGianLoaiTauQuaTuyenGa; }
            set { _MaThoiGianLoaiTauQuaTuyenGa = value; }
        }
        public int MaTuyenGa 
        {
            get { return _MaTuyenGa; }
            set { _MaTuyenGa = value; }
        }

        public int MaLoaiTau
        {
            get { return _MaLoaiTau; }
            set { _MaLoaiTau = value; }
        }

        public int ThoiGianDi
        {
            get { return _ThoiGianDi; }
            set { _ThoiGianDi = value; }
        }
    }
}

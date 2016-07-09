using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    class TuyenGaDTO
    {
        private int _MaTuyenGa;
        private int _MaGa;
        private int _MaTuyen;
        private int _STT;

        //Phương thức khởi tạo mặc định
        public TuyenGaDTO()
        {
            _MaTuyenGa=0;
            _MaGa=0;
            _MaTuyen=0;
            _STT=0;
        }

        //Phương thức khởi tạo có tham số
        public TuyenGaDTO(int MaTuyenGa, int MaGa, int MaTuyen,int STT)
        {
            _MaTuyenGa = MaTuyenGa;
            _MaGa = MaGa;
            _MaTuyen = MaTuyen;
            _STT = STT;
        }

        //Phương thức khởi tạo sao chép.
        public TuyenGaDTO(TuyenGaDTO VD)
        {
            _MaTuyenGa = VD._MaTuyenGa;
            _MaGa = VD._MaGa;
            _MaTuyen = VD._MaTuyen;
            _STT = VD._STT;
        }

        //Properties
        public int MaTuyenGa
        {
            get { return _MaTuyenGa; }
            set { _MaTuyenGa = value; }
        }
        public int MaGa 
        {
            get { return _MaGa; }
            set { _MaGa = value; }
        }

        public int MaTuyen
        {
            get { return _MaTuyen; }
            set { _MaTuyen = value; }
        }

        public int STT
        {
            get { return _STT; }
            set { _STT = value; }
        }
    }
}

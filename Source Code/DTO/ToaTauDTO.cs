using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DTO
{
    public class ToaTauDTO
    {
        private int _MaToa;
        private int _MaDoanTau;
        private int _STT;

        //Phương thức khởi tạo mặc định
        public ToaTauDTO()
        {
            _MaToa=0;
            _MaDoanTau=0;
            _STT=0;
        }

        //Phương thức khởi tạo có tham số
        public ToaTauDTO(int MaToa, int MaDoanTau, int STT)
        {
            _MaToa = MaToa;
            _MaDoanTau = MaDoanTau;
            _STT = STT;
        }

        //Phương thức khởi tạo sao chép.
        public ToaTauDTO(ToaTauDTO VD)
        {
            _MaToa = VD._MaToa;
            _MaDoanTau = VD._MaDoanTau;
            _STT = VD._STT;
        }

        //Properties
        public int MaToa
        {
            get { return _MaToa; }
            set { _MaToa = value; }
        }
        public int MaDoanTau 
        {
            get { return _MaDoanTau; }
            set { _MaDoanTau = value; }
        }

        public int STT
        {
            get { return _STT; }
            set { _STT = value; }
        }
    }
}

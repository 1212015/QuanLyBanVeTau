using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class PhanCongDTO
    {
        private DateTime _ngay;
        private int _msNV;
        private int _msBan;
        private int _ca;

        //Phuong thuc khoi tao mac dinh
        public PhanCongDTO()
        {
            _ngay = DateTime.Today;
            _msNV = 0;
            _msBan = 0;
            _ca = 0;            
        }

        //Phuong thuc khoi tao co tham so
        public PhanCongDTO(DateTime ngay, int msNV, int msBan, int ca)
        {
            _ngay = ngay;
            _msNV = msNV;
            _msBan = msBan;
            _ca = ca;
        }

        //Phuong thuc khoi tao sao chep
        public PhanCongDTO(PhanCongDTO pc)
        {
            _ngay = pc._ngay;
            _msNV = pc._msNV;
            _msBan = pc._msBan;
            _ca = pc._ca;
        }

        //Properties
        public int MsNV
        {
            get { return _msNV; }
            set { _msNV = value; }
        }

        public int Ca
        {
            get { return _ca; }
            set { _ca = value; }
        }

        public int MsBan
        {
            get { return _msBan; }
            set { _msBan = value; }
        }
        public DateTime Ngay
        {
            get { return _ngay; }
            set { _ngay = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Web;

namespace DTO
{
    public class PCDTO
    {
        private DateTime _ngay;
        private string _msNV;
        private int _msBan;
        private int _ca;

        //Phuong thuc khoi tao mac dinh
        public PCDTO()
        {
            _ngay = DateTime.Today;
            _msNV = "";
            _msBan = 0;
            _ca = 0;            
        }

        //Phuong thuc khoi tao co tham so
        public PCDTO(DateTime ngay, string msNV, int msBan, int ca)
        {
            _ngay = ngay;
            _msNV = msNV;
            _msBan = msBan;
            _ca = ca;
        }

        //Phuong thuc khoi tao sao chep
        public PCDTO(PCDTO pc)
        {
            _ngay = pc._ngay;
            _msNV = pc._msNV;
            _msBan = pc._msBan;
            _ca = pc._ca;
        }

        //Properties
        public string MsNV
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
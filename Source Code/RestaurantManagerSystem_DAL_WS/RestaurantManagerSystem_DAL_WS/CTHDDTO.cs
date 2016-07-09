using System;
using System.Collections.Generic;
using System.Web;

namespace DTO
{
    public class CTHDDTO
    {
        private string _tenTD;
        private float _donGia;
        private int _soLuong;

        //Phuong thuc khoi tao mac dinh
        public CTHDDTO()
        {
            _tenTD = "";
            _donGia = 0;
            _soLuong = 0;
        }

        //Phuong thuc khoi tao co tham so
        public CTHDDTO(string tenTD, float dongia, int soLuong)
        {
            _tenTD = tenTD;
            _donGia = dongia;
            _soLuong = soLuong;
        }

        //Phuong thuc khoi tao sao chep
        public CTHDDTO(CTHDDTO cthd)
        {
            _tenTD = cthd._tenTD;
            _donGia = cthd._donGia;
            _soLuong = cthd._soLuong;
        }

        //Properties
        public string TenTD
        {
            get { return _tenTD; }
            set { _tenTD = value; }
        }

        public float DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
    }
}
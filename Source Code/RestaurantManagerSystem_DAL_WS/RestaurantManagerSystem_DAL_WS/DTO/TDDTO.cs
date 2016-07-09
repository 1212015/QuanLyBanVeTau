using System;
using System.Collections.Generic;
using System.Web;

namespace RestaurantManagerSystem_DAL_WS
{
    public class TDDTO
    {
        private int _maTD;
        private string _tenTD;
        private string _donViTinh;
        private float _dongia;
        private string _tenloai;

        //Phương thức khởi tạo mặc định
        public TDDTO()
        {
            _maTD = 0;
            _tenloai = "";
            _tenTD = "";
            _donViTinh = "";
            _dongia = 0;
        }

        //Phương thức khởi tạo có tham số
        public TDDTO(int maNV, string tenTD, string donViTinh, float dongia, string tenLoai)
        {
            _maTD = maNV;
            _tenloai = tenLoai;
            _tenTD = tenTD;
            _donViTinh = donViTinh;
            _dongia = dongia;
        }

        //Phương thức khởi tạo sao chép.
        public TDDTO(TDDTO thucDon)
        {
            _maTD = thucDon._maTD;
            _tenloai = thucDon._tenloai;
            _tenTD = thucDon._tenTD;
            _donViTinh = thucDon._donViTinh;
            _dongia = thucDon._dongia;
        }

        //Properties
        public int MaTD
        {
            get { return _maTD; }
            set { _maTD = value; }
        }
        public string TenLoai
        {
            get { return _tenloai; }
            set { _tenloai = value; }
        }
        public string TenTD
        {
            get { return _tenTD; }
            set { _tenTD = value; }
        }
        public string DonViTinh
        {
            get { return _donViTinh; }
            set { _donViTinh = value; }
        }
        public float DonGia
        {
            get { return _dongia; }
            set { _dongia = value; }
        }
    }
}
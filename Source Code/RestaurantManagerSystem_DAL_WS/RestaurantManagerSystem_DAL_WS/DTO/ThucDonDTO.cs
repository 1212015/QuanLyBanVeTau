using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ThucDonDTO
    {
        private int _maTD;
        private int _maLoai;
        private string _tenTD;
        private string _donViTinh;
        private float _dongia;

        //Phương thức khởi tạo mặc định
        public ThucDonDTO()
        {
            _maTD = 0;
            _maLoai = 0;
            _tenTD = "";
            _donViTinh = "";
            _dongia = 0;
        }

        //Phương thức khởi tạo có tham số
        public ThucDonDTO(int maNV, int maLoai, string tenTD, string donViTinh, float dongia)
        {
            _maTD = maNV;
            _maLoai = maLoai;
            _tenTD = tenTD;
            _donViTinh = donViTinh;
            _dongia = dongia;
        }

        //Phương thức khởi tạo sao chép.
        public ThucDonDTO(ThucDonDTO thucDon)
        {
            _maTD = thucDon._maTD;
            _maLoai = thucDon._maLoai;
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
        public int MaLoai
        {
            get { return _maLoai; }
            set { _maLoai = value; }
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

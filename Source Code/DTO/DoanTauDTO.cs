using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DoanTauDTO
    {
        private int _maDoanTau;
        private int _maLoaiTau;
        private string _tenTau;
        private string _hangSanXuat ;
        private DateTime _ngayVanHanh;


        //Phuong thuc khoi tao mac dinh
        public DoanTauDTO()
        {
            _maDoanTau = 0;
            _maLoaiTau = 0;
            _tenTau = "";
            _hangSanXuat = "";
            _ngayVanHanh = DateTime.Today;
        }

        //Phuong thuc khoi tao co tham so
        public DoanTauDTO(int maDoanTau, int maLoaiTau, string hangSX, string tenTau, DateTime ngayVanHanh)
        {
            _ngayVanHanh = ngayVanHanh;
            _tenTau = tenTau;
            _maLoaiTau = maLoaiTau;
            _maDoanTau = maDoanTau;
            _hangSanXuat = hangSX;
        }

        //Phuong thuc khoi tao sao chep
        public DoanTauDTO(DoanTauDTO doantau)
        {
            _ngayVanHanh = doantau._ngayVanHanh;
            _tenTau = doantau._tenTau;
            _maLoaiTau = doantau._maLoaiTau;
            _maDoanTau = doantau._maDoanTau;
            _hangSanXuat = doantau._hangSanXuat;
        }

        //Properties
        public int MaDoanTau
        {
            get { return _maDoanTau; }
            set { _maDoanTau = value; }
        }

        public int MaLoaiTau
        {
            get { return _maLoaiTau; }
            set { _maLoaiTau = value; }
        }

        public string TenTau
        {
            get { return _tenTau; }
            set { _tenTau = value; }
        }

        public string HangSanXuat
        {
            get { return _hangSanXuat; }
            set { _hangSanXuat = value; }
        }

        public DateTime NgayVanHanh
        {
            get { return _ngayVanHanh; }
            set { _ngayVanHanh = value; }
        }

    }
}

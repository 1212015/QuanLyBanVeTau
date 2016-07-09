using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class GaDTO
    {
        private int _maGa;
        private string _tenGa;
        private string _diaChi;

        //Phương thức khởi tạo mặc định
        public GaDTO()
        {
            _maGa = 0;
            _tenGa = "";
            _diaChi = "";
        }

        //Phương thức khởi tạo có tham số
        public GaDTO(int maGa, string tenGa, string diaChi)
        {
            _maGa = maGa;
            _tenGa = tenGa;
            _diaChi = diaChi;
        }

        //Phương thức khởi tạo sao chép.
        public GaDTO(GaDTO loai)
        {
            _maGa = loai._maGa;
            _tenGa = loai._tenGa;
            _diaChi = loai._diaChi;
        }

        //Properties
        public int MaGa
        {
            get { return _maGa; }
            set { _maGa = value; }
        }
        public string TenGa
        {
            get { return _tenGa; }
            set { _tenGa = value; }
        }
        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
    }
}

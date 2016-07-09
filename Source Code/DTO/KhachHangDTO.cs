using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KhachHangDTO
    {
        private int _maKH;
        private string _hoTen;
        private string _CMND;
        private string _dienThoai;
        private DateTime _ngaySinh;
        private string _diaChi;
        
        //Phương thức khởi tạo mặc định
        public KhachHangDTO()
        {
            _maKH = 0;
            _hoTen = "";
            _CMND = "";
            _dienThoai = "";
            _ngaySinh = DateTime.Today;
            _diaChi = "";
        }

        //Phương thức khởi tạo có tham số
        public KhachHangDTO(int maKH, string hoTen, DateTime ngaySinh, string CMND, string dienThoai, string diaChi)
        {
            _maKH = maKH;
            _hoTen = hoTen;
            _ngaySinh = ngaySinh;
            _CMND = CMND;
            _dienThoai = dienThoai;
            _diaChi = diaChi;

        }

        //Phương thức khởi tạo sao chép.
        public KhachHangDTO(KhachHangDTO nhanvien)
        {
            _maKH = nhanvien._maKH;
            _hoTen = nhanvien._hoTen;
            _ngaySinh = nhanvien._ngaySinh;
            _CMND = nhanvien._CMND;
            _dienThoai = nhanvien._dienThoai;
            _diaChi = nhanvien._diaChi;
        }

        //Properties
        public int MaKH
        {
            get { return _maKH; }
            set { _maKH = value; }
        }

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }

        public string CMND
        {
            get { return _CMND; }
            set { _CMND = value; }
        }
        public string DienThoai
        {
            get { return _dienThoai; }
            set { _dienThoai = value; }
        }
        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
    }
}

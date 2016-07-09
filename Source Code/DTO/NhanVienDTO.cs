using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NhanVienDTO
    {
        private int _maNV;
        private int _maLoaiNV;
        private string _hoTen;
        private string _cMND;
        private DateTime _ngaySinh;
        private string _gioiTinh;
        private string _diaChi;
        private string _dienThoai;
        private int _nguoiQuanLy;
        
        //Phương thức khởi tạo mặc định
        public NhanVienDTO()
        {
            _maNV = 0;
            _maLoaiNV = 0;
            _hoTen = "";
            _cMND = "";
            _ngaySinh = DateTime.Today;
            _gioiTinh = "";
            _dienThoai = "";
            _nguoiQuanLy = 0;

        }

        //Phương thức khởi tạo có tham số
        public NhanVienDTO(int maNV, int maLoaiNV, string hoTen, string cMND, DateTime ngaySinh,string gioiTinh, string diaChi, string dienThoai, int nguoiQuanLy )

        {
            _maNV = maNV;
            _maLoaiNV = maLoaiNV;
            _hoTen = hoTen;
            _cMND = cMND;
            _ngaySinh = ngaySinh;
            _gioiTinh = gioiTinh;
            _diaChi = diaChi;
            _dienThoai = dienThoai;
            _nguoiQuanLy = nguoiQuanLy;

        }

        //Phương thức khởi tạo sao chép.
        public NhanVienDTO(NhanVienDTO nhanVien)
        {
            _maNV = nhanVien._maNV;
            _maLoaiNV = nhanVien._maLoaiNV;
            _hoTen = nhanVien._hoTen;
            _cMND = nhanVien._cMND;
            _ngaySinh = nhanVien._ngaySinh;
            _gioiTinh = nhanVien._gioiTinh;
            _diaChi = nhanVien._diaChi;
            _dienThoai = nhanVien._dienThoai;
            _nguoiQuanLy = nhanVien._nguoiQuanLy;

        }

        //Properties
        public int MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        public int MaLoaiNV
        {
            get { return _maLoaiNV; }
            set { _maLoaiNV = value; }
        }

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        public string CMND
        {
            get { return _cMND; }
            set { _cMND = value; }
        }


        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        public string DienThoai
        {
            get { return _dienThoai; }
            set { _dienThoai = value; }
        }
        public int NguoiQuanLy
        {
            get { return _nguoiQuanLy; }
            set { _nguoiQuanLy = value; }
        }
        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }
      
    }
}

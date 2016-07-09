using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LoaiToaTauDTO
    {
        private int _MaLoaiTau;
        private string _TenLoaiTau;

        //Phương thức khởi tạo mặc đinh
        public LoaiToaTauDTO()
        {
            _MaLoaiTau = 0;
            _TenLoaiTau = "";
        }

        //Phương thức khởi tạo có tham số
        public LoaiToaTauDTO(int MaLoaiTau, string TenLoaiTau)
        {
            _MaLoaiTau = MaLoaiTau;
            _TenLoaiTau = TenLoaiTau;

        }

        //Phương thức khỏi tạo sao chép
        public LoaiToaTauDTO(LoaiToaTauDTO loaitoatau)
        {
            _MaLoaiTau = loaitoatau._MaLoaiTau;
            _TenLoaiTau = loaitoatau._TenLoaiTau;
        }

        //properties
        public int MaLoaiTau
        {
            get { return _MaLoaiTau; }
            set { _MaLoaiTau = value; }
        }

        public string TenLoaiTau
        {
            get { return _TenLoaiTau; }
            set { _TenLoaiTau = value; }
        }
    }
}

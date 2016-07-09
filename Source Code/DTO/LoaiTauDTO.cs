using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LoaiTauDTO
    {
        private int _maLoaiTau;
        private string _tenLoaiTau;
        private float _tiLeGia;

        //Phương thức khởi tạo mặc đinh
        public LoaiTauDTO()
        {
            _maLoaiTau = 0;
            _tenLoaiTau = "";
            _tiLeGia = 0;
        }

        //Phương thức khởi tạo có tham số
        public LoaiTauDTO(int maLoaiTau, string tenLoaiTau, float tiLeGia)
        {
            _maLoaiTau = maLoaiTau;
            _tenLoaiTau = tenLoaiTau;
            _tiLeGia = tiLeGia;

        }

        //Phương thức khỏi tạo sao chép
        public LoaiTauDTO(LoaiTauDTO loaitoatau)
        {
            _maLoaiTau = loaitoatau._maLoaiTau;
            _tenLoaiTau = loaitoatau._tenLoaiTau;
            _tiLeGia = loaitoatau._tiLeGia;
        }

        //properties
        public int MaLoaiTau
        {
            get { return _maLoaiTau; }
            set { _maLoaiTau = value; }
        }

        public string TenLoaiTau
        {
            get { return _tenLoaiTau; }
            set { _tenLoaiTau = value; }
        }

        public float TiLeGia
        {
            get { return _tiLeGia; }
            set { _tiLeGia = value; }

        }


    }
}
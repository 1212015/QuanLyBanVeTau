using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LoaiGheDTO
    {
        private int _maLoaiGhe;
        private string _tenLoaiGhe;
        private float _tiLeGia;

        //Phuong thuc khoi tao mac dinh
        public LoaiGheDTO()
        {
            _maLoaiGhe = 0;
            _tenLoaiGhe = "";
            _tiLeGia = 0;
        }

        //Phuong thuc khoi tao co tham so
        public LoaiGheDTO(int maLoaiGhe, string tenLoaiGhe, float tiLeGia)
        {
            _maLoaiGhe = maLoaiGhe;
            _tenLoaiGhe = tenLoaiGhe;
            _tiLeGia = tiLeGia;
        }

        //Phuong thuc khoi tao sao chep
        public LoaiGheDTO(LoaiGheDTO loaighe)
        {
            _maLoaiGhe = loaighe._maLoaiGhe;
            _tenLoaiGhe = loaighe._tenLoaiGhe;
            _tiLeGia = loaighe._tiLeGia;
        }

        //Properties
        public int MaLoaiGhe
        {
            get { return _maLoaiGhe; }
            set { _maLoaiGhe = value; }
        }

        public string TenLoaiGhe
        {
            get { return _tenLoaiGhe; }
            set { _tenLoaiGhe = value; }
        }

        public float TiLeGia
        {
            get { return _tiLeGia; }
            set { _tiLeGia = value; }
        }
    }
}

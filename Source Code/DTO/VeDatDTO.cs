using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DTO
{
    public class VeDatDTO
    {
        private int _MaVe;
        private int _MaChuyen;
        private int _GaDi;
        private int _GaDen;
        private int _MaGiaVe;
        private int _MaGhe;

        //Phương thức khởi tạo mặc định
        public VeDatDTO()
        {
            _MaVe=0;
            _MaChuyen=0;
            _GaDi=0;
            _GaDen=0;
            _MaGiaVe=0;
            _MaGhe=0;
        }

        //Phương thức khởi tạo có tham số
        public VeDatDTO(int MaVe, int MaChuyen, int GaDi,int GaDen, int MaGiaVe, int MaGhe)
        {
            _MaVe = MaVe;
            _MaChuyen = MaChuyen;
            _GaDi = GaDi;
            _GaDen = GaDen;
            _MaGiaVe = MaGiaVe;
            _MaGhe = MaGhe;
        }

        //Phương thức khởi tạo sao chép.
        public VeDatDTO(VeDatDTO VD)
        {
            _MaVe = VD._MaVe;
            _MaChuyen = VD._MaChuyen;
            _GaDi = VD._GaDi;
            _GaDen = VD._GaDen;
            _MaGiaVe = VD._MaGiaVe;
            _MaGhe = VD._MaGhe;
        }

        //Properties
        public int MaVe
        {
            get { return _MaVe; }
            set { _MaVe = value; }
        }
        public int MaChuyen 
        {
            get { return _MaChuyen; }
            set { _MaChuyen = value; }
        }

        public int GaDi
        {
            get { return _GaDi; }
            set { _GaDi = value; }
        }

        public int GaDen
        {
            get { return _GaDen; }
            set { _GaDen = value; }
        }

        public int MaGiaVe  
        {
            get { return _MaGiaVe; }
            set { _MaGiaVe = value; }
        }

        public int MaGhe
        {
            get { return _MaGhe; }
            set { _MaGhe = value; }
        }

    }
}

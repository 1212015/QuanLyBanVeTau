using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class GiaVeDTO
    {
        private int _maGiaVe;
        private int _gaDi;
        private int _gaDen;
        private int _soTien;
        
        //Phương thức khởi tạo mặc định
        public GiaVeDTO()
        {
            _maGiaVe = 0;
            _gaDi = 0;
            _gaDen = 0;
            _soTien = 0;
        }

        //Phương thức khởi tạo có tham số
        public GiaVeDTO(int maGiaVe, int gaDi, int gaDen, int soTien)
        {
            _maGiaVe = maGiaVe;
            _gaDi = gaDi;
            _gaDen = gaDen;
            _soTien = soTien;

        }

        //Phương thức khởi tạo sao chép.
        public GiaVeDTO(GiaVeDTO nhanVien)
        {
            _maGiaVe = nhanVien._maGiaVe;
            _gaDi = nhanVien._gaDi;
            _gaDen = nhanVien._gaDen;
            _soTien = nhanVien._soTien;
        }

        //Properties
        public int MaGiaVe
        {
            get { return _maGiaVe; }
            set { _maGiaVe = value; }
        }

        public int GaDi
        {
            get { return _gaDi; }
            set { _gaDi = value; }
        }

       
        public int GaDen
        {
            get { return _gaDen; }
            set { _gaDen = value; }
        }

        public int SoTien
        {
            get { return _soTien; }
            set { _soTien = value; }
        }
        
    }
}

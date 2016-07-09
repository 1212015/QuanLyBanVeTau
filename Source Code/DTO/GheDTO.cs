using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class GheDTO
    {
        private int _maGhe;
        private int _maLoaiGhe;
        private int _maToa;

        //Phương thức khởi tạo mặc định
        public GheDTO()
        {
            _maGhe = 0;
            _maLoaiGhe = 0;
            _maToa = 0;
        }

        //Phương thức khởi tạo có tham số
        public GheDTO(int maGhe, int maLoaiGhe, int maToa)
        {
            _maGhe = maGhe;
            _maLoaiGhe = maLoaiGhe;
            _maToa = maToa;
        }

        //Phương thức khởi tạo sao chép.
        public GheDTO(GheDTO thucDon)
        {
            _maGhe = thucDon._maGhe;
            _maLoaiGhe = thucDon._maLoaiGhe;
            _maToa = thucDon._maToa;
        }

        //Properties
        public int MaGhe
        {
            get { return _maGhe; }
            set { _maGhe = value; }
        }
        public int MaLoaiGhe
        {
            get { return _maLoaiGhe; }
            set { _maLoaiGhe = value; }
        }
        
        public int MaToa
        {
            get { return _maToa; }
            set { _maToa = value; }
        }
    }
}

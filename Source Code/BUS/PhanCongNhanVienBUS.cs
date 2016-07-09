using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
using System.Data;



namespace BUS
{

    public class PhanCongNhanVienBUS
    {
        public static DataTable TraCuuPhanCongNhanVienTheoTen(string tenNV)
        {
            DataTable dt = PhanCongNhanVienDAO.TraCuuPhanCongNhanVienTheoTen(tenNV);
            return dt;
        }
    }

}

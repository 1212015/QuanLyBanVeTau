using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class DonNghiPhepBUS
    {
        public static bool KiemTraMaNhanVienTonTaiNghiPhep(int MaNV)
        {
            bool kq = DonNghiPhepDAO.KiemTraMaNhanVienTonTaiNghiPhep(MaNV);
            return kq;
        }

        public static bool KiemTraMaPhanCongTonTaiNghiPhep(int MaNV, int MaPC)
        {
            bool kq = DonNghiPhepDAO.KiemTraMaPhanCongTonTaiNghiPhep(MaNV, MaPC);
            return kq;
        }
        public static bool ThemDonNghiPhep(int MaNV, int MaPC, string LyDo)
        {
            bool kq = DonNghiPhepDAO.ThemDonNghiPhep(MaNV, MaPC, LyDo);
            return kq;
        }

        public static DataTable LayDSDonXinNghiPhep()
        {
            DataTable dt = DonNghiPhepDAO.LayDSDonXinNghiPhep();
            return dt;
        }

        public static bool DuyetDonXinNghiPhep(int madon)
        {
            bool kq;
            string sql = string.Format("EXEC sp_DuyetDonXinNghiPhep {0}", madon);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);

            return kq;
        }

    }

}

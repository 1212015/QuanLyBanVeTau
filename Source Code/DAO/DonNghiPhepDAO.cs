using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{

    public class DonNghiPhepDAO
    {
        public static bool KiemTraMaNhanVienTonTaiNghiPhep(int MaNV)
        {
            bool kq;
            //string sql = "select * from nhanvien where nhanvien.manv = '" + tenDN + "'" ;
            string sql = string.Format("Exec sp_KiemTraMaNhanVienTonTaiNghiPhep '{0}'", MaNV);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
                kq = true;
            else
                kq = false;
            return kq;
        }

        public static bool KiemTraMaPhanCongTonTaiNghiPhep(int MaNV, int MaPC)
        {
            bool kq;

            string sql = string.Format("Exec sp_KiemTraMaPhanCongTonTaiNghiPhep '{0}', '{1}'", MaNV, MaPC);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
                kq = true;
            else
                kq = false;
            return kq;
        }

        public static bool ThemDonNghiPhep(int MaNV, int MaPC, string LyDo)
        {


            bool kq;

            string sql = string.Format("Exec sp_ThemDonNghiPhep '{0}', '{1}', '{2}'", MaNV, MaPC, LyDo);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public static int MaTuTang()
        {
            string sql = "select * from HoaDon";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            int maTuTang = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (int.Parse(dt.Rows[i][0].ToString()) != maTuTang)
                {
                    return maTuTang;
                }
                maTuTang++;
            }
            return maTuTang;
        }

        public static DataTable LayDSDonXinNghiPhep()
        {
            string sql = "select d.MaDonNghiPhep as 'Mã Đơn', n.HoTen as 'Họ tên', d.LyDo as 'Lý do', d.TrangThai as 'Trạng Thái' from donnghiphep as d, nhanvien as n where d.MaNV=n.MaNV";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }
    }

}

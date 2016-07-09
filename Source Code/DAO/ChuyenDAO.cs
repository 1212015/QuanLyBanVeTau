using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class ChuyenDAO
    {
        public static DataTable TraCuuChuyenTau(string gadi, string gaden, string ngaydi)
        {
            //string sql = string.Format("select MaChuyen,DoanTau.MaDoanTau,DoanTau.TenTau,TDi.TenTuyen,GaDen.TenGa as TenGaDen,GaDi.TenGa as TenGaDi,  Chuyen.NgayXuatPhat as NgayDi, CONVERT(varchar, Chuyen.NgayGioXuatPhat, 114) as GioDi from TuyenGa as TuyenGaDi inner join TuyenGa as TuyenGaDen on TuyenGaDi.MaTuyen = TuyenGaDen.MaTuyen join Chuyen on Chuyen.MaTuyen = TuyenGaDi.MaTuyen join DoanTau  on DoanTau.MaDoanTau = Chuyen.MaDoanTau join Ga as GaDi on GaDi.MaGa = TuyenGaDi.MaGa join Ga as GaDen on GaDen.MaGa = TuyenGaDen.MaGa  join Tuyen as TDen on TDen.MaTuyen = TuyenGaDen.MaTuyen join Tuyen as TDi on TDi.MaTuyen = TuyenGaDi.MaTuyen where TuyenGaDi.MaGa = {0} and TuyenGaDen.MaGa = {1} and CONVERT(varchar, Chuyen.NgayGioXuatPhat, 103) = '{2}'", gadi, gaden, ngaydi);
            string sql = string.Format("Exec sp_TraCuuChuyenTau '{0}','{1}','{2}'", gadi, gaden, ngaydi);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static DataTable LayDSChuyen()
        {
            string sql = "select c.MaChuyen as 'Mã chuyến',c.MaDoanTau as 'Mã đoàn tàu', dt.TenTau as 'Tên tàu', t.TenTuyen as 'Tên tuyến',c.NgayGioXuatPhat as'Ngày giờ xuất phát', nv.HoTen as 'Nhân viên lái', nv2.HoTen as 'Nhân viên trưởng' from chuyen as c, doantau as dt, tuyen as t, nhanvien as nv, nhanvien as nv2 where c.MaDoanTau=dt.MaDoanTau and c.MaTuyen=t.MaTuyen and c.NhanVienLai=nv.MaNV and c.NhanVienTruong=nv2.MaNV";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static bool ThemChuyen(int madoantau, string tentuyen, string ngaygioxp, string nvlai, string nvtruong,int matoa1, int matoa2)
        {
            bool kq;
            string sql = string.Format("EXEC sp_ThemChuyen {0},N'{1}',N'{2}',N'{3}',N'{4}',{5},{6}", madoantau, tentuyen, ngaygioxp, nvlai, nvtruong,matoa1,matoa2);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);

            return kq;
        }

        public static bool SuaChuyen(int machuyen, int madoantau, string tentuyen, string ngaygioxp, string nvlai, string nvtruong, int matoa1, int matoa2)
        {
            bool kq;
            string sql = string.Format("EXEC sp_CapNhatChuyen {0},{1},N'{2}',N'{3}',N'{4}',N'{5}',{6},{7}", machuyen, madoantau, tentuyen, ngaygioxp, nvlai, nvtruong,matoa1,matoa2);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);

            return kq;
        }

        public static bool XoaChuyen(int machuyen)
        {
            bool kq;
            string sql = string.Format("EXEC sp_XoaChuyen {0}", machuyen);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);

            return kq;
        }

        public static DataTable TimkiemNVcuaChuyen(string key)
        {
            string sql = string.Format("EXEC sp_TimNVChuyen N'{0}'", key);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }
    }
}

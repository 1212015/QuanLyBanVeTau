using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class CT_HoaDonDAO
    {
        //Rút trích dữ liêu: select 
        public CTHDDTO[] LayDSCTHDTuMaHD(int maHD)
        {
            string sql = "select td.TenThucDon as 'Tên TĐ', td.DonGia as 'Đơn Giá', ct.SoLuong as 'Số Lượng' from ChiTietHD ct, ThucDon td where ct.MaThucDon = td.MaThucDon and ct.SoHD = " + maHD;
            DataTable db = SqlDataAccessHelper.ExecuteQuery(sql);
            CTHDDTO[] pt = new CTHDDTO[db.Rows.Count];
            if (db != null)
            {
                int i = 0;
                foreach (DataRow row in db.Rows)
                {
                    pt[i] = new CTHDDTO();
                    pt[i].TenTD = row.ItemArray[0].ToString();
                    pt[i].DonGia = float.Parse(db.Rows[i].ItemArray[1].ToString());
                    pt[i].SoLuong = int.Parse(db.Rows[i].ItemArray[2].ToString());
                    i++;
                }
            }
            return pt;
        }
        public CT_HoaDonDTO[] LayDSCTHD(int SoHD)
        {
            string sql = string.Format("select * from ChiTietHD where SoHD = {0}", SoHD);
            DataTable db = SqlDataAccessHelper.ExecuteQuery(sql);
            CT_HoaDonDTO[] pt = new CT_HoaDonDTO[db.Rows.Count];
            if (db != null)
            {
                int i = 0;
                foreach (DataRow row in db.Rows)
                {
                    pt[i] = new CT_HoaDonDTO();
                    pt[i].SoHD = int.Parse(row.ItemArray[0].ToString());
                    pt[i].MaTD = int.Parse(db.Rows[i].ItemArray[1].ToString());
                    pt[i].SoLuong = int.Parse(db.Rows[i].ItemArray[2].ToString());
                    i++;
                }
            }
            return pt;
        }
        public bool ThemChiTietHoaDon(CT_HoaDonDTO cthd)
        {
            bool kq;
            string sql = string.Format("insert into ChiTietHD values ({0}, {1}, {2})", cthd.SoHD, cthd.MaTD, cthd.SoLuong);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }
        public bool XoaCTHDTheoSoHD(int soHD)
        {
            bool kq;
            string sql = string.Format("delete ChiTietHD where SoHD = {0}", soHD);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }
        public bool XoaCTHDTheoSoHDVaMaTD(int soHD, int maTD)
        {
            bool kq;
            string sql = string.Format("delete ChiTietHD where SoHD = {0} and MaThucDon = {1}", soHD, maTD);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }
        public int CTHDMaTuTang()
        {
            string sql = "select * from ChiTietHD";
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
    }
}

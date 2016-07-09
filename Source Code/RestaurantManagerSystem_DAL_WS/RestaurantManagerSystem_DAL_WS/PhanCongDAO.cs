using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class PhanCongDAO
    {
        public PCDTO[] LayDSPhanCong()
        {
            string sql = "select Ngay as 'Ngày', Ca as 'Ca', HoTen as 'Tên Nhân Viên', MaSoBan as 'Mã Số Bàn' from PhanCong, NhanVien where PhanCong.MaNV = NhanVien.MaNV";
            DataTable db = SqlDataAccessHelper.ExecuteQuery(sql);
            PCDTO[] pt = new PCDTO[db.Rows.Count];
            if (db != null)
            {
                int i = 0;
                foreach (DataRow row in db.Rows)
                {
                    pt[i] = new PCDTO();
                    pt[i].Ngay = DateTime.Parse(row.ItemArray[0].ToString());
                    pt[i].Ca = int.Parse(db.Rows[i].ItemArray[1].ToString());
                    pt[i].MsNV = db.Rows[i].ItemArray[2].ToString();
                    pt[i].MsBan = int.Parse(db.Rows[i].ItemArray[3].ToString());
                    i++;
                }
            }
            return pt;
        }

        public bool ThemPhanCong(PhanCongDTO pc)
        {
            bool kq;
            string sql = string.Format("insert into PhanCong values('{0}', {1}, {2}, {3})", pc.Ngay, pc.Ca, pc.MsNV, pc.MsBan);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public bool XoaPhanCong(PhanCongDTO pc)
        {
            bool kq;
            string sql = string.Format("delete PhanCong where Ngay = '{0}' and Ca = {1} and MaNV = {2} and MaSoBan = {3}", pc.Ngay, pc.Ca, pc.MsNV, pc.MsBan);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public int LayMaNVTheoMaBanVaCa(int maBan, int ca)
        {
            string sql = string.Format("select MaNV from PhanCong where MaSoBan = {0} and Ca = {1}", maBan, ca);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            int maNV = int.Parse(dt.Rows[0]["MaNV"].ToString());
            return maNV;
        }

        public int LayCaTheoGio(int gio)
        { 
            int ca;
            if (gio >= 7 && gio < 12)
                ca = 1;
            else
            {
                ca = 2;
            }
            return ca;
        }
    }
}


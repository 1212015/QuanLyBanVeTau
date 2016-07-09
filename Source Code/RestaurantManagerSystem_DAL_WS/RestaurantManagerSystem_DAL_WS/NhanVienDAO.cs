using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        //Rút trích dữ liêu: select 
        public NhanVienDTO[] LayDSNhanVien()
        {
            string sql = "select MaNV as 'Mã NV', HoTen as 'Họ Tên', NgaySinh as 'Ngày Sinh', TenDN as 'Tên ĐN', Quyen as 'Quyền' from NhanVien";
            DataTable db = SqlDataAccessHelper.ExecuteQuery(sql);
            NhanVienDTO[] pt = new NhanVienDTO[db.Rows.Count];
            if (db != null)
            {
                int i = 0;
                foreach (DataRow row in db.Rows)
                {
                    pt[i] = new NhanVienDTO();
                    pt[i].MaNV = int.Parse(row.ItemArray[0].ToString());
                    pt[i].HoTen = db.Rows[i].ItemArray[1].ToString();
                    pt[i].NgaySinh = DateTime.Parse(db.Rows[i].ItemArray[2].ToString());
                    pt[i].TenDN = db.Rows[i].ItemArray[3].ToString();
                    pt[i].Quyen = db.Rows[i].ItemArray[4].ToString();
                    i++;
                }
            }
            return pt;
        }

        public NhanVienDTO[] LayDSNhanVienTiepTan()
        {
            string sql = "select MaNV as 'Mã NV', HoTen as 'Họ Tên', NgaySinh as 'Ngày Sinh', TenDN as 'Tên ĐN', Quyen as 'Quyền' from NhanVien where Quyen = N'Tiếp Tân'";
            DataTable db = SqlDataAccessHelper.ExecuteQuery(sql);
            NhanVienDTO[] pt = new NhanVienDTO[db.Rows.Count];
            if (db != null)
            {
                int i = 0;
                foreach (DataRow row in db.Rows)
                {
                    pt[i] = new NhanVienDTO();
                    pt[i].MaNV = int.Parse(row.ItemArray[0].ToString());
                    pt[i].HoTen = db.Rows[i].ItemArray[1].ToString();
                    pt[i].NgaySinh = DateTime.Parse(db.Rows[i].ItemArray[2].ToString());
                    pt[i].TenDN = db.Rows[i].ItemArray[3].ToString();
                    pt[i].Quyen = db.Rows[i].ItemArray[4].ToString();
                    i++;
                }
            }
            return pt;
        }

        public NhanVienDTO[] LayDSNhanVienCoMK()
        {
            string sql = "select * from NhanVien";
            DataTable db = SqlDataAccessHelper.ExecuteQuery(sql);
            NhanVienDTO[] pt = new NhanVienDTO[db.Rows.Count];
            if (db != null)
            {
                int i = 0;
                foreach (DataRow row in db.Rows)
                {
                    pt[i] = new NhanVienDTO();
                    pt[i].MaNV = int.Parse(row.ItemArray[0].ToString());
                    pt[i].HoTen = db.Rows[i].ItemArray[1].ToString();
                    pt[i].NgaySinh = DateTime.Parse(db.Rows[i].ItemArray[2].ToString());
                    pt[i].TenDN = db.Rows[i].ItemArray[3].ToString();
                    pt[i].MatKhau = db.Rows[i].ItemArray[4].ToString();
                    pt[i].Quyen = db.Rows[i].ItemArray[5].ToString();
                    i++;
                }
            }
            return pt;
        }

        public string LayMatKhauTuTenDN(string TenDN)
        {
            string sql = "select * from NhanVien where TenDN = N'"+ TenDN + "'";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            string MK = dt.Rows[0][4].ToString();
            return MK;
        }

        public int LayMaNVTuTenNV(string tenNV)
        {
            int maNV;
            string sql = string.Format("select MaNV from NhanVien where HoTen = N'{0}'", tenNV);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
            {
                maNV = int.Parse(dt.Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
            return maNV;
        }

        public string LayTenNVTheoMaNV(int maNV)
        {
            string sql = string.Format("select HoTen from NhanVien where MaNV = {0}", maNV);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            string tenNV = dt.Rows[0]["HoTen"].ToString();
            return tenNV;
        }

        public string LayQuyenNVTheoMaNV(int maNV)
        {
            string sql = "select Quyen from NhanVien where MaNV = " + maNV;
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            string quyen = dt.Rows[0]["Quyen"].ToString();
            return quyen;
        }

        public bool KiemTraTenDNTonTai(string tenDN, int MaNV)
        {
            bool kq;
            string sql = "select * from NhanVien where TenDN = '" + tenDN + "'" + "and TenDN <> '' and MaNV <> " + MaNV;
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
                kq = true;
            else
                kq = false;
            return kq;
        }

        public bool ThemNhanVien(NhanVienDTO nv)
        {
            nv.MaNV = NVMaTuTang();
            bool kq;
            string sql = string.Format("set dateformat DMY insert into NhanVien values ({0}, N'{1}', convert(varchar(10),'{2}',103), N'{3}', N'{4}', N'{5}')", nv.MaNV, nv.HoTen, nv.NgaySinh, nv.TenDN, nv.MatKhau, nv.Quyen);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public bool CapNhatNhanVien(NhanVienDTO nv)
        {
            bool kq;
            string sql = string.Format("set dateformat DMY update NhanVien set HoTen = N'{0}', NgaySinh = convert(varchar(10),'{1}',103), TenDN = '{2}', MatKhau = '{3}', Quyen = N'{4}' where MaNV = {5}", nv.HoTen, nv.NgaySinh, nv.TenDN, nv.MatKhau, nv.Quyen, nv.MaNV);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public bool XoaNhanVien(int maNV)
        {
            bool kq;
            string sql = string.Format("delete from NhanVien where MaNV = {0}", maNV);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public NhanVienDTO[] TraCuuNhanVienTheoTen(string tenNV)
        {
            string sql = string.Format("select MaNV as 'Mã NV', HoTen as 'Họ Tên', NgaySinh as 'Ngày Sinh', TenDN as 'Tên ĐN', Quyen as 'Quyền' from NhanVien where HoTen like N'%{0}%'", tenNV);
            DataTable db = SqlDataAccessHelper.ExecuteQuery(sql);
            NhanVienDTO[] pt = new NhanVienDTO[db.Rows.Count];
            if (db != null)
            {
                int i = 0;
                foreach (DataRow row in db.Rows)
                {
                    pt[i] = new NhanVienDTO();
                    pt[i].MaNV = int.Parse(row.ItemArray[0].ToString());
                    pt[i].HoTen = db.Rows[i].ItemArray[1].ToString();
                    pt[i].NgaySinh = DateTime.Parse(db.Rows[i].ItemArray[2].ToString());
                    pt[i].TenDN = db.Rows[i].ItemArray[3].ToString();
                    pt[i].MatKhau = db.Rows[i].ItemArray[4].ToString();
                    pt[i].Quyen = db.Rows[i].ItemArray[5].ToString();
                    i++;
                }
            }
            return pt;
        }

        public int NVMaTuTang()
        {
            string sql = "select * from NhanVien";
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

        public bool CheckConnection()
        {
            string sql = "select * from NhanVien";
            return SqlDataAccessHelper.CheckConnect(sql);
        }
    }
}

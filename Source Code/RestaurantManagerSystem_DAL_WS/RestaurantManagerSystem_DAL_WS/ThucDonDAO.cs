using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class ThucDonDAO
    {
        public bool ThemThucDon(ThucDonDTO td)
        {
            string sql = string.Format("insert into ThucDon values ({0}, {1}, N'{2}', '{3}',{4})", td.MaTD, td.MaLoai, td.TenTD, td.DonViTinh, td.DonGia);
            bool kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public bool XoaThucDonTheoMaTD(int maTD)
        {
            string sql = "delete ThucDon where MaThucDon = " + maTD;
            bool kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public bool CapNhatThucDon(ThucDonDTO td)
        {
            string sql = string.Format("update ThucDon set MaLoai = {0}, TenThucDon = N'{1}', DonViTinh = N'{2}', DonGia = {3} where MaThucDon = {4}", td.MaLoai, td.TenTD, td.DonViTinh, td.DonGia, td.MaTD);
            bool kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public List<ThucDonDTO> LayDSThucDon()
        {
            List<ThucDonDTO> _ds = new List<ThucDonDTO>();
            string sql = "select * from ThucDon";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThucDonDTO td = new ThucDonDTO();
                td.MaTD = int.Parse(dt.Rows[i]["MaThucDon"].ToString());
                td.MaLoai = int.Parse(dt.Rows[i]["MaLoai"].ToString());
                td.TenTD = dt.Rows[i]["TenThucDon"].ToString();
                td.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                td.DonGia = float.Parse(dt.Rows[i]["DonGia"].ToString());
                _ds.Add(td);
            }
            return _ds;
        }

        public List<ThucDonDTO> LayDSThucDonTheoMaLoai(int maLoai)
        {
            List<ThucDonDTO> _ds = new List<ThucDonDTO>();
            string sql = "select * from ThucDon where MaLoai = " + maLoai;
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThucDonDTO td = new ThucDonDTO();
                td.MaTD = int.Parse(dt.Rows[i]["MaThucDon"].ToString());
                td.MaLoai = int.Parse(dt.Rows[i]["MaLoai"].ToString());
                td.TenTD = dt.Rows[i]["TenThucDon"].ToString();
                td.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                td.DonGia = float.Parse(dt.Rows[i]["DonGia"].ToString());
                _ds.Add(td);
            }
            return _ds;
        }

        public List<ThucDonDTO> LayDSMaTDVaTenTDTheoMaLoai(int maLoai)
        {
            List<ThucDonDTO> ds = new List<ThucDonDTO>();
            string sql = "select * from ThucDon where MaLoai = " + maLoai;
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThucDonDTO td = new ThucDonDTO();
                td.MaTD = int.Parse(dt.Rows[i]["MaThucDon"].ToString());
                td.TenTD = dt.Rows[i]["TenThucDon"].ToString();
                ds.Add(td);
            }
            return ds;
        }

        public List<TDDTO> LayDanhSachTDTheoMaLoai(int maLoai)
        {
            List<TDDTO> _ds = new List<TDDTO>();
            string sql = "select td.MaThucDon as 'Mã TĐ', td.TenThucDon as 'Tên Thực Đơn', td.DonGia as 'Đơn Giá', td.DonViTinh as 'Đơn Vị Tính', l.TenLoai as 'Loại TĐ' from ThucDon td, LoaiThucDon l where td.MaLoai = l.MaLoai and td.MaLoai =" + maLoai;
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TDDTO td = new TDDTO();
                td.MaTD = int.Parse(dt.Rows[i]["MaThucDon"].ToString());
                td.TenLoai = dt.Rows[i]["TenLoai"].ToString();
                td.TenTD = dt.Rows[i]["TenThucDon"].ToString();
                td.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                td.DonGia = float.Parse(dt.Rows[i]["DonGia"].ToString());
                _ds.Add(td);
            }
            return _ds;
        }

        public string LayTenThucDonTuMaThucDon(int maTD)
        {
            string tenTD;
            string sql = "select TenThucDon from ThucDon where MaThucDon = " + maTD;
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
                tenTD = dt.Rows[0]["TenThucDon"].ToString();
            else
                return "";
            return tenTD;
        }

        public int LayMaThucDonTuTenTD(string tenTD)
        {
            int maTD;
            string sql = "select MaThucDon from ThucDon where TenThucDon = N'" + tenTD +"'";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
                maTD = int.Parse(dt.Rows[0]["MaThucDon"].ToString());
            else
                return 0;
            return maTD;
        }

        public string LayDonViTinhTheoMaTD(int maTD)
        {
            string dvt;
            string sql = "select DonViTinh from ThucDon where MaThucDon = " + maTD;
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            dvt = dt.Rows[0][0].ToString();
            return dvt;
        }

        public float LayGiaTheoMaTD(int maTD)
        {
            float gia;
            string sql = "select DONGIA from ThucDon where MaThucDon = " + maTD;
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            gia = float.Parse(dt.Rows[0][0].ToString());
            return gia;
        }

        public bool KiemTraThucDonNuocUong(int maTD)
        {
            bool kq;
            string sql = string.Format("select l.Nhom from LoaiThucDon l, ThucDon td where l.MaLoai = td.MaLoai and td.MaThucDon = {0}", maTD);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            if (dt.Rows[0][0].ToString() == "Thức Ăn")
                kq = true;
            else
                kq = false;
            return kq;
        }

        public bool KiemTraTrungTenThucDon(string tenTD)
        {
            bool kq;
            string sql = "select * from ThucDon where TenThucDon = N'" + tenTD + "'";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
                kq = false;
            else
                kq = true;
            return kq;
        }

        public bool KiemTraTenTDCapNhat(string tenTD, int maTD)
        {
            bool kq;
            string sql = string.Format("select * from ThucDon where TenThucDon = N'{0}' and MaThucDon = {1}", tenTD, maTD);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
                kq = false;
            else
                kq = true;
            return kq;
        }

        public List<TDDTO> TraCuuThucDonTheoTen(string tenTD)
        {
            List<TDDTO> _ds = new List<TDDTO>();
            string sql = string.Format("select td.MaThucDon as 'Mã TĐ', td.TenThucDon as 'Tên Thực Đơn', td.DonGia as 'Đơn Giá', td.DonViTinh as 'Đơn Vị Tính', l.TenLoai as 'Loại TĐ' from ThucDon td, LoaiThucDon l where td.TenThucDon like N'%{0}%' and td.MaLoai = l.MaLoai", tenTD);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TDDTO td = new TDDTO();
                td.MaTD = int.Parse(dt.Rows[i]["MaThucDon"].ToString());
                td.TenLoai = dt.Rows[i]["TenLoai"].ToString();
                td.TenTD = dt.Rows[i]["TenThucDon"].ToString();
                td.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                td.DonGia = float.Parse(dt.Rows[i]["DonGia"].ToString());
                _ds.Add(td);
            }
            return _ds;
        }

        public int TDMaTuTang()
        {
            string sql = "select * from ThucDon";
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

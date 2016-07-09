using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using RestaurantManagerSystem.GUI;
using RestaurantManagerSystem.RestaurantManagerSystem_BLL_WS;

namespace RestaurantManagerSystem
{
    public partial class frmMain : Form
    {
        RestaurantManagerSystem_BLL_WS.RestaurantManagerSystem_BLL_WebServiceSoapClient a = new RestaurantManagerSystem_BLL_WS.RestaurantManagerSystem_BLL_WebServiceSoapClient();
        public frmMain()
        {
            InitializeComponent();
        }
        private NhanVienDTO _nv = new NhanVienDTO();
        public NhanVienDTO Nv
        {
            get { return _nv; }
            set { _nv = value; }
        }
        int flag;

        #region FORM_LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Nv.Quyen.ToString() == "Admin")
            {
                DuaDSHoaDonLenDataGridView();
                DuaDSNhanVienLenDataGridView();
                DuaDSHoaDonLenDataGridView();
                DuaDanhSachPhanCongLenDataGridView();
                LoadThongTinNguoiDung();
                DuaLoaiTDLenCombobox();
                diNgaySinh.MaxDate = DateTime.Today;
            }
            if (Nv.Quyen.ToString() == "Thu Ngân")
            {
                DuaLoaiThucDonLenCombobox();
                DuaDSHoaDonLenDataGridView();
                DuaBanLenCombobox();
                DuaDSNhanVienLenCombobox();
                DuaDSBanDaGoiLenCombobox();
                LoadNhanVienPhanCongLenCombobox();
                LoadThongTinNguoiDung();
                DuaBanPhanCongLenCombobox();
                diNgaySinh.MaxDate = DateTime.Today;
            }
            
        }

        public void DuaBanLenCombobox()
        {
            BanDTO[] _dsban = a.LayDSBan();
            List<int> _dsBanDaDat = a.LayDSBanChuaThanhToan();
            List<int> _dsTam = new List<int>();
            for (int i = 0; i < _dsban.Length; i++)
            {
                bool flag = false;
                for (int j = 0; j < _dsBanDaDat.Count; j++)
                {
                    if (_dsban[i].MaBan == _dsBanDaDat[j])
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    _dsTam.Add(int.Parse(_dsban[i].MaBan.ToString()));
                }
            }
            cmbBan.DataSource = _dsTam;
        }

        public void DuaDSBanDaGoiLenCombobox()
        {
            cmbDSBanCanLapHD.Items.Clear();
            cmbDSBanCapNhat.Items.Clear();
            cmbDSBanCanLapHD.Text = "";
            cmbDSBanCapNhat.Text = "";
            List<int> _dsMaBan = a.LayDSBanChuaThanhToan();
            for (int i = 0; i < _dsMaBan.Count; i++)
            {
                cmbDSBanCanLapHD.Items.Add(_dsMaBan[i].ToString());
                cmbDSBanCapNhat.Items.Add(_dsMaBan[i].ToString());
            }
        }

        private void LoadThongTinNguoiDung()
        {
            lbTenDN.Text = Nv.TenDN.ToString();
            lbHoTen.Text = Nv.HoTen.ToString();
            lbQuyen.Text = Nv.Quyen.ToString();
            if (Nv.Quyen.ToString() == "Admin")
            {
                tiGoiMon.Visible = false;
                tiCapNhatGoiMon.Visible = false;
                tiLapHD.Visible = false;
            }
            if (Nv.Quyen.ToString() == "Thu Ngân")
            {
                tiPhanCong.Visible = false;
                tiNhanVien.Visible = false;
                tiTKDT.Visible = false;
                tiThucDon.Visible = false;
            }
        }

        public void DuaLoaiThucDonLenCombobox()
        {
            LoaiThucDonDTO[] _dsltd = a.LayDSLoaiThucDon();
            cmbLoaiTD.DataSource = _dsltd;
            cmbLoaiTD.DisplayMember = "TenLoai";
            cmbLoaiTD.ValueMember = "MaLoai";

            cbLoaiTD.DataSource = _dsltd;
            cbLoaiTD.DisplayMember = "TenLoai";
            cbLoaiTD.ValueMember = "MaLoai";

            cmbLoaiTDCN.DataSource = _dsltd;
            cmbLoaiTDCN.DisplayMember = "TenLoai";
            cmbLoaiTDCN.ValueMember = "MaLoai";
        }

        public void DuaLoaiTDLenCombobox()
        {
            LoaiThucDonDTO[] _dsltd = a.LayDSLoaiThucDon();
            cmbLoaiThucDon.DataSource = _dsltd;
            cmbLoaiThucDon.DisplayMember = "TenLoai";
            cmbLoaiThucDon.ValueMember = "MaLoai";

        }

        public void DuaDSNhanVienLenCombobox()
        {
            NhanVienDTO[] _dsNV = a.LayDSNhanVienTiepTan();
            cmbDSNhanVien.DataSource = _dsNV;
            cmbDSNhanVien.DisplayMember = "Họ Tên";
            cmbDSNhanVien.ValueMember = "Mã NV";
        }

        public void DuaDSHoaDonLenDataGridView()
        {
            HDTKDTO[] _dshd = a.LayDSHoaDon();
            dtgDSHD.DataSource = _dshd;
        }

        public void DuaDSNhanVienLenDataGridView()
        {
            NhanVienDTO[] _dsnd = a.LayDSNhanVien();
            dtgDSNV.DataSource = _dsnd;
        }

        public void DuaDanhSachPhanCongLenDataGridView()
        {
            PCDTO[] dt = a.LayDSPhanCong();
            dgvDSPhanCong.DataSource = dt;
        }

        public void LoadNhanVienPhanCongLenCombobox()
        {
            NhanVienDTO[] dt = a.LayDSNhanVienTiepTan();
            cmbNhanVienPC.DataSource = dt;
            cmbNhanVienPC.DisplayMember = "Họ Tên";
            cmbNhanVienPC.ValueMember = "Mã NV";
        }

        public void DuaBanPhanCongLenCombobox()
        {
            BanDTO[] dt = a.LayDSBan();
            cmbBanPC.DataSource = dt;
            cmbBanPC.DisplayMember = "MaBan";
            cmbBanPC.ValueMember = "MaBan";
        }

        #endregion

        #region GOI_MON_AN
        private void cmbLoaiTD_SelectedValueChanged(object sender, EventArgs e)
        {
            string tenLoai = cmbLoaiTD.Text;
            int maLoaiTD = a.LayMaLoaiTuTenLoai(tenLoai);
            ThucDonDTO[] _dstd = a.LayDSThucDonTheoMaLoai(maLoaiTD);
            lbDSTD.DataSource = _dstd;
            lbDSTD.DisplayMember = "TenTD";
            lbDSTD.ValueMember = "MaTD";
            tbDonGia.Text = "";
            lbGiaTK.Text = "0";
        }

        private void btThemTDVaoList_Click(object sender, EventArgs e)
        {
            if (tbDonGia.Text != "")
            {
                int maTD = int.Parse(lbDSTD.SelectedValue.ToString());
                string tenTD = a.LayTenThucDonTuMaThucDon(maTD);
                bool tonTai = false;
                int dong = 0;
                for (int i = 0; i < lvChiTietGoiMon.Items.Count; i++)
                {
                    if (int.Parse(lvChiTietGoiMon.Items[i].SubItems[0].Text) == maTD)
                    {
                        tonTai = true;
                        dong = i;
                    }
                }
                string soLuong = "1";
                if (tbSL.Text != "")
                {
                    soLuong = tbSL.Text;
                }
                if (tonTai == false)
                {
                    string donGia = tbDonGia.Text;
                    ListViewItem item = new ListViewItem();
                    item.Text = maTD.ToString();
                    item.SubItems.Add(tenTD);
                    item.SubItems.Add(donGia);
                    item.SubItems.Add(soLuong);
                    this.lvChiTietGoiMon.Items.Add(item);
                    tbSL.Text = "1";
                }
                else
                {
                    int sl = int.Parse(lvChiTietGoiMon.Items[dong].SubItems[3].Text) + int.Parse(soLuong);
                    lvChiTietGoiMon.Items[dong].SubItems[3].Text = sl.ToString();
                }
            }
            else
            {
                MessageBoxEx.Show("Bạn nhập giá không chính xác!");
            }
        }

        private void tbSL_Click(object sender, EventArgs e)
        {
            tbSL.Text = "";
        }

        private void btXoaTDDuocChon_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa thực đơn này không?", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                if (result == DialogResult.Yes)
                {
                    lvChiTietGoiMon.FocusedItem.Remove();
                }
            }
            catch
            {
                MessageBoxEx.Show("Vui lòng chọn ĐT cần xóa!");
            }
        }

        private void btXoaDSTD_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa hết danh sách không?", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            if (result == DialogResult.Yes)
            {
                lvChiTietGoiMon.Items.Clear();
            }
        }

        private void btTinhTien_Click(object sender, EventArgs e)
        {
            if (cmbDSBanCanLapHD.Text == "")
                MessageBox.Show("Chưa chọn bàn cần tính!");
            else
            {
                double tongTien = 0;
                for (int i = 0; i < lvDSCTGMCanLapHD.Items.Count; i++)
                {
                    double donGia = double.Parse(lvDSCTGMCanLapHD.Items[i].SubItems[1].Text);
                    int soLuong = int.Parse(lvDSCTGMCanLapHD.Items[i].SubItems[2].Text);
                    tongTien += donGia * soLuong;
                }
                lbTongTien.Text = tongTien.ToString();
            }
        }

        private void btXoaTDDuocChonCN_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa thực đơn này không?", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                if (result == DialogResult.Yes)
                {
                    lvChiTietGoiMonCN.FocusedItem.Remove();
                }
            }
            catch
            {
                MessageBoxEx.Show("Vui lòng chọn ĐT cần xóa!");
            }
        }

        private void btXoaDSTDCN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa hết danh sách không?", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            if (result == DialogResult.Yes)
            {
                lvChiTietGoiMonCN.Items.Clear();
            }

        }

        private void btLuuGoiMon_Click(object sender, EventArgs e)
        {
            if (lvChiTietGoiMon.Items.Count > 0)
            {
                if (tbSoKhach.Text != "")
                {
                    HoaDonDTO hd = new HoaDonDTO();
                    CT_HoaDonDTO cthd = new CT_HoaDonDTO();
                    hd.MsBan = int.Parse(cmbBan.Text);
                    int maHD = a.LayMaHoaDonCanLap();
                    hd.TongTien = 0;
                    hd.MsNVLap = _nv.MaNV;

                    hd.MsNVTT = _nv.MaNV;
                    try
                    {
                        int soKhach = int.Parse(tbSoKhach.Text);
                        if (soKhach > 0)
                        {
                            hd.SoKhach = soKhach;

                            bool kq = a.LapHoaDon(hd);
                            if (kq == true)
                            {
                                for (int i = 0; i < lvChiTietGoiMon.Items.Count; i++)
                                {
                                    cthd.SoHD = hd.SoHD;
                                    cthd.MaTD = int.Parse(lvChiTietGoiMon.Items[i].SubItems[0].Text);
                                    cthd.SoLuong = int.Parse(lvChiTietGoiMon.Items[i].SubItems[3].Text);
                                    a.ThemChiTietHoaDon(cthd);
                                }
                                MessageBoxEx.Show("Lưu gọi món thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DuaDSBanDaGoiLenCombobox();
                                DuaBanLenCombobox();
                                lvChiTietGoiMon.Items.Clear();
                                tbDonGia.Text = "";
                                tbSoKhach.Text = "";
                            }
                        }
                        else
                        {
                            MessageBoxEx.Show("Số khách phải lớn hơn 0!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbSoKhach.Text = "";
                            tbSoKhach.Focus();
                        }
                    }
                    catch
                    {
                        MessageBoxEx.Show("Kiểu dữ liệu số khách không đúng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbSoKhach.Text = "";
                        tbSoKhach.Focus();
                    }
                }
                else
                {
                    MessageBoxEx.Show("Chưa nhập số lượng khách!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSoKhach.Text = "";
                    tbSoKhach.Focus();
                }
            }
            else
            {
                MessageBoxEx.Show("Chưa chọn thực đơn!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbLoaiTDCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenLoai = cmbLoaiTDCN.Text.ToString();
            int maLoaiTD = a.LayMaLoaiTuTenLoai(tenLoai);
            ThucDonDTO[] _dstd = a.LayDSThucDonTheoMaLoai(maLoaiTD);
            lbDSTDCN.DataSource = _dstd;
            lbDSTDCN.DisplayMember = "TenTD";
            lbDSTDCN.ValueMember = "MaTD";
            tbDonGiaCN.Text = "";
            lbGiaTKCN.Text = "0";
        }

        private void btThemTDVaoListCN_Click(object sender, EventArgs e)
        {
            if (cmbDSBanCapNhat.Text != "")
            {
                if (tbDonGiaCN.Text != "")
                {
                    int maTD = int.Parse(lbDSTDCN.SelectedValue.ToString());
                    string tenTD = a.LayTenThucDonTuMaThucDon(maTD);
                    bool tonTai = false;
                    int dong = 0;
                    for (int i = 0; i < lvChiTietGoiMonCN.Items.Count; i++)
                    {
                        if (lvChiTietGoiMonCN.Items[i].SubItems[0].Text == tenTD)
                        {
                            tonTai = true;
                            dong = i;
                        }
                    }
                    string soLuong = "1";
                    if (tbSL.Text != "")
                    {
                        soLuong = tbSL.Text;
                    }
                    if (tonTai == false)
                    {
                        string donGia = tbDonGiaCN.Text;
                        ListViewItem item = new ListViewItem();
                        item.Text = tenTD;
                        item.SubItems.Add(donGia);
                        item.SubItems.Add(soLuong);
                        this.lvChiTietGoiMonCN.Items.Add(item);
                        tbSL.Text = "1";
                    }
                    else
                    {
                        int sl = int.Parse(lvChiTietGoiMonCN.Items[dong].SubItems[2].Text) + int.Parse(soLuong);
                        lvChiTietGoiMonCN.Items[dong].SubItems[2].Text = sl.ToString();
                    }
                }
                else
                {
                    MessageBoxEx.Show("Bạn nhập giá không chính xác!");
                }
            }
            else
            {
                MessageBoxEx.Show("Chưa chọn bàn cần cập nhật!");
            }

        }

        private void cmbBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbDSBanCapNhat_TextChanged(object sender, EventArgs e)
        {
            if (cmbDSBanCapNhat.Text == "")
                tbSoKhachCN.Text = "";
        }
        #endregion

        #region THOAT
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region NHAN_VIEN
        private void btTraCuuNV_Click(object sender, EventArgs e)
        {
            if (tbTenNVTraCuu.Text == "")
                MessageBoxEx.Show("Chưa nhập tên nhân viên cần tra cứu!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                tbHoTen.Text = "";
                tbTenDN.Text = "";
                tbMatKhau.Text = "";
                tbMatKhau2.Text = "";
                diNgaySinh.Text = "";
                cmbQuyen.Text = "Tiếp Tân";
                NhanVienDTO[] dt = a.TraCuuNhanVienTheoTen(tbTenNVTraCuu.Text);
                dtgDSNV.DataSource = dt;
            }
        }

        private void tbTenNVTraCuu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btTraCuuNV_Click(sender, e);
        }

        private void tbTenTDTraCuu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btTim_Click(sender, e);
        }

        private void btDSNV_Click(object sender, EventArgs e)
        {
            tbHoTen.Text = "";
            tbTenDN.Text = "";
            tbMatKhau.Text = "";
            tbMatKhau2.Text = "";
            diNgaySinh.Text = "";
            cmbQuyen.Text = "Tiếp Tân";
            tbTenNVTraCuu.Text = "";
            DuaDSNhanVienLenDataGridView();
        }

        private void dtgDSNV_Click(object sender, EventArgs e)
        {
            int idx = dtgDSNV.CurrentRow.Index;
            tbHoTen.Text = dtgDSNV.Rows[idx].Cells[1].Value.ToString();
            diNgaySinh.Text = dtgDSNV.Rows[idx].Cells[2].Value.ToString();
            tbTenDN.Text = dtgDSNV.Rows[idx].Cells[3].Value.ToString();
            cmbQuyen.Text = dtgDSNV.Rows[idx].Cells[4].Value.ToString();
            if (cmbQuyen.Text == "Admin")
            {
                tbTenDN.ReadOnly = false;
                tbMatKhau.ReadOnly = false;
                tbMatKhau2.ReadOnly = false;
                cmbQuyen.Enabled = false;
            }
            else
                cmbQuyen.Enabled = true;
            string MatKhau = a.LayMatKhauTuTenDN(dtgDSNV.Rows[idx].Cells[3].Value.ToString());
            tbMatKhau.Text = MatKhau;
            tbMatKhau2.Text = tbMatKhau.Text;
        }

        public void ThemNhanVien()
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.HoTen = tbHoTen.Text;
            nv.NgaySinh = DateTime.Parse(diNgaySinh.Text);
            nv.TenDN = tbTenDN.Text;
            nv.MatKhau = tbMatKhau.Text;
            nv.Quyen = cmbQuyen.Text;
            if (!a.KiemTraTenDNTonTai(nv.TenDN, nv.MaNV))
            {
                bool kq = a.ThemNhanVien(nv);
                if (kq == true)
                {
                    MessageBoxEx.Show("Thêm người dùng thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DuaDSNhanVienLenDataGridView();
                    tbTenDN.Text = "";
                    tbMatKhau.Text = "";
                    tbMatKhau2.Text = "";
                    tbHoTen.Text = "";
                    cmbQuyen.Text = "Tiếp Tân";
                }
                else
                {
                    MessageBoxEx.Show("Thêm thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBoxEx.Show("Tên đăng nhập này đã tồn tại!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btThemND_Click(object sender, EventArgs e)
        {
            if (_nv.Quyen == "Admin")
            {
                if (cmbQuyen.Text != "Tiếp Tân")
                {
                    if (tbTenDN.Text.Length >= 6 && tbTenDN.Text.Length <= 20)
                    {
                        if (tbHoTen.Text != "")
                        {
                            if (tbMatKhau.Text.Length >= 6 && tbMatKhau.Text.Length <= 20)
                            {
                                if (tbMatKhau.Text == tbMatKhau2.Text)
                                {
                                    if (diNgaySinh.Text != "")
                                    {
                                        ThemNhanVien();
                                    }
                                    else
                                    {
                                        MessageBoxEx.Show("Ngày sinh không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBoxEx.Show("Mật khẩu không trùng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    tbMatKhau2.Text = "";
                                    tbMatKhau2.Focus();
                                }
                            }
                            else
                            {
                                MessageBoxEx.Show("Mật khẩu phải lớn hơn 5 và nhỏ hơn 21 ký tự!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tbMatKhau.Text = "";
                                tbMatKhau.Focus();
                            }
                        }
                        else
                        {
                            MessageBoxEx.Show("Họ tên không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbHoTen.Focus();
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Tên Đăng nhập phải lớn hơn 5 và nhỏ hơn 21 ký tự!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbTenDN.Text = "";
                        tbTenDN.Focus();
                    }
                }
                else
                {
                    if (tbHoTen.Text != "")
                    {
                        if (diNgaySinh.Text != "")
                        {
                            ThemNhanVien();
                        }
                        else
                        {
                            MessageBoxEx.Show("Ngày sinh không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Họ tên nhân viên không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbHoTen.Focus();
                    }
                }
            }
            else
            {
                MessageBoxEx.Show("Chỉ có Admin mới có thể sử dụng chức năng này!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SuaNhanVien()
        {
            NhanVienDTO nv = new NhanVienDTO();
            int idx = dtgDSNV.CurrentRow.Index;
            nv.MaNV = int.Parse(dtgDSNV.Rows[idx].Cells[0].Value.ToString());
            nv.HoTen = tbHoTen.Text;
            nv.NgaySinh = DateTime.Parse(diNgaySinh.Text);
            nv.TenDN = tbTenDN.Text;
            nv.MatKhau = tbMatKhau.Text;
            nv.Quyen = cmbQuyen.Text;
            if (!a.KiemTraTenDNTonTai(nv.TenDN, nv.MaNV))
            {
                bool kq = a.CapNhatNhanVien(nv);
                if (kq == true)
                {
                    MessageBoxEx.Show("Cập nhật thông tin người dùng thành công!");
                    DuaDSNhanVienLenDataGridView();
                    tbTenDN.Text = "";
                    tbMatKhau.Text = "";
                    tbMatKhau2.Text = "";
                    tbHoTen.Text = "";
                    cmbQuyen.Text = "Tiếp Tân";
                }
                else
                {
                    MessageBoxEx.Show("Cập nhật thất bại!");
                }
            }
            else
                MessageBoxEx.Show("Tên đăng nhập này đã tồn tại!");
        }

        private void btSuaND_Click(object sender, EventArgs e)
        {
            if (_nv.Quyen == "Admin")
            {
                if (cmbQuyen.Text != "Tiếp Tân")
                {
                    if (tbTenDN.Text.Length >= 6 && tbTenDN.Text.Length <= 20)
                    {
                        if (tbHoTen.Text != "")
                        {
                            if (tbMatKhau.Text.Length >= 6 && tbMatKhau.Text.Length <= 20)
                            {
                                if (tbMatKhau.Text == tbMatKhau2.Text)
                                {
                                    if (diNgaySinh.Text != "")
                                    {
                                        SuaNhanVien();
                                    }
                                    else
                                    {
                                        MessageBoxEx.Show("Ngày sinh không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBoxEx.Show("Mật khẩu không trùng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    tbMatKhau2.Text = "";
                                    tbMatKhau2.Focus();
                                }
                            }
                            else
                            {
                                MessageBoxEx.Show("Mật khẩu phải lớn hơn 5 và nhỏ hơn 21 ký tự!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tbMatKhau.Text = "";
                                tbMatKhau.Focus();
                            }
                        }
                        else
                        {
                            MessageBoxEx.Show("Họ tên nhân viên không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbHoTen.Focus();
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Tên Đăng nhập phải lớn hơn 5 và nhỏ hơn 21 ký tự!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbTenDN.Text = "";
                        tbTenDN.Focus();
                    }
                }
                else
                {
                    if (tbHoTen.Text != "")
                    {
                        if (diNgaySinh.Text != "")
                        {
                            SuaNhanVien();
                        }
                        else
                        {
                            MessageBoxEx.Show("Ngày sinh không được rỗng!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Họ tên nhân viên không được rỗng!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBoxEx.Show("Chỉ có Admin mới có thể sử dụng chức năng này!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btXoaND_Click(object sender, EventArgs e)
        {
            if (_nv.Quyen == "Admin")
            {
                int idx = dtgDSNV.CurrentRow.Index;
                int maNV = int.Parse(dtgDSNV.Rows[idx].Cells[0].Value.ToString());

                DialogResult result = MessageBox.Show("Chắn chắn xóa?!!!", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                if (result == DialogResult.Yes)
                {
                    string quyen = a.LayQuyenNVTheoMaNV(maNV);
                    if (quyen != "Admin")
                    {
                        bool kq;
                        try
                        {
                            kq = a.XoaNhanVien(maNV);
                            if (kq == true)
                            {
                                MessageBoxEx.Show("Đã xóa nhân viên!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DuaDSNhanVienLenDataGridView();
                                tbTenDN.Text = "";
                                tbMatKhau.Text = "";
                                tbMatKhau2.Text = "";
                                tbHoTen.Text = "";
                            }
                            else
                                MessageBoxEx.Show("Xóa nhân viên thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch
                        {
                            MessageBoxEx.Show("Nhân viên đang được phân công không thể xóa!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBoxEx.Show("Không thể xóa tài khoản Admin!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBoxEx.Show("Chỉ có Admin mới có thể sử dụng chức năng này!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbQuyen.Text == "Tiếp Tân")
            {
                tbTenDN.Text = "";
                tbMatKhau.Text = "";
                tbMatKhau2.Text = "";
                tbTenDN.ReadOnly = true;
                tbMatKhau.ReadOnly = true;
                tbMatKhau2.ReadOnly = true;
            }
            else
            {
                tbTenDN.ReadOnly = false;
                tbMatKhau.ReadOnly = false;
                tbMatKhau2.ReadOnly = false;
            }
        }
        #endregion

        #region LAP_HOA_DON
        private void cmbDSBanCanLapHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDSNhanVien.Text = "";
            lvDSCTGMCanLapHD.Items.Clear();
            int maBan = int.Parse(cmbDSBanCanLapHD.Text);
            int maHD = a.LaySoHDTuMaBan(maBan);
            CTHDDTO[] _ds = a.LayDSCTHDTuMaHD(maHD);
            for (int i = 0; i < _ds.Length; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = _ds[i].TenTD;
                item.SubItems.Add(_ds[i].DonGia.ToString());
                item.SubItems.Add(_ds[i].SoLuong.ToString());
                lvDSCTGMCanLapHD.Items.Add(item);
            }

            int gioLap = a.LayGioLapHDChuaThanhToanTheoMaBan(maBan);
            int ca = a.LayCaTheoGio(gioLap);
            int maNV = a.LayMaNVTheoMaBanVaCa(maBan, ca);

            string tenNV = a.LayTenNVTheoMaNV(maNV);
            cmbDSNhanVien.Text = tenNV;
        }

        private void btLapHD_Click(object sender, EventArgs e)
        {
            if (lvDSCTGMCanLapHD.Items.Count > 0)
            {
                if (cmbDSNhanVien.Text == "")
                    MessageBoxEx.Show("Chưa chọn nhân viên tiếp tân!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (lbTongTien.Text == "0")
                        MessageBoxEx.Show("Chưa tính tổng tiền!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        HoaDonDTO hd = new HoaDonDTO();
                        hd.MsNVTT = int.Parse(cmbDSNhanVien.SelectedValue.ToString());
                        hd.MsBan = int.Parse(cmbDSBanCanLapHD.Text);
                        hd.SoHD = a.LaySoHDTuMaBan(hd.MsBan);
                        hd.TongTien = float.Parse(lbTongTien.Text);
                        bool kq = a.CapNhatLapHoaDon(hd);
                        if (kq == true)
                        {
                            MessageBoxEx.Show("Lập hóa đơn thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DuaDSHoaDonLenDataGridView();
                            DuaBanLenCombobox();
                            lvDSCTGMCanLapHD.Items.Clear();
                            DuaDSBanDaGoiLenCombobox();
                            lbTongTien.Text = "0";
                            DialogResult result = MessageBox.Show("Bạn có muốn in hóa đơn này ra không!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            if (result == DialogResult.Yes)
                            {

                                ViewHoaDon frm = new ViewHoaDon();
                                frm.SoHD = hd.SoHD;
                                frm.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBoxEx.Show("Lập hóa đơn thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBoxEx.Show("Chưa chọn bàn!");
            }

        }

        private void lbDSTD_Click(object sender, EventArgs e)
        {
            int maTD = int.Parse(lbDSTD.SelectedValue.ToString());
            float gia = a.LayGiaTheoMaTD(maTD);
            lbGiaTK.Text = gia.ToString();
            tbDonGia.Text = Convert.ToString(float.Parse(lbGiaTK.Text) - (float.Parse(cmbKhuyenMai.Text) / 100) * float.Parse(lbGiaTK.Text));
        }

        private void cmbDSBanCapNhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SoHD = a.LaySoHDTuMaBan(int.Parse(cmbDSBanCapNhat.SelectedItem.ToString()));
            CTHDDTO[] _ds = a.LayDSCTHDTuMaHD(SoHD);
            lvChiTietGoiMonCN.Items.Clear();
            int soKhach = a.LaySoKhachTuSoHD(SoHD);
            tbSoKhachCN.Text = soKhach.ToString();
            for (int i = 0; i < +_ds.Length; i++)
            {
                ListViewItem li = new ListViewItem();
                li.Text = _ds[i].TenTD.ToString();
                li.SubItems.Add(_ds[i].DonGia.ToString());
                li.SubItems.Add(_ds[i].SoLuong.ToString());
                lvChiTietGoiMonCN.Items.Add(li);
            }
        }

        private void btCapNhatGoiMon_Click(object sender, EventArgs e)
        {
            if (lvChiTietGoiMonCN.Items.Count > 0)
            {
                if (tbSoKhachCN.Text != "")
                {
                    HoaDonDTO hd = new HoaDonDTO();
                    CT_HoaDonDTO cthd = new CT_HoaDonDTO();
                    hd.MsBan = int.Parse(cmbDSBanCapNhat.Text);
                    hd.SoKhach = int.Parse(tbSoKhachCN.Text);
                    hd.SoHD = a.LaySoHDTuMaBan(int.Parse(cmbDSBanCapNhat.Text));
                    a.CapNhatSoKhach(hd.SoKhach, hd.SoHD);
                    bool kq = a.XoaCTHDTheoSoHD(hd.SoHD);

                    for (int i = 0; i < lvChiTietGoiMonCN.Items.Count; i++)
                    {
                        cthd.SoHD = hd.SoHD;
                        cthd.MaTD = a.LayMaThucDonTuTenThucDon(lvChiTietGoiMonCN.Items[i].SubItems[0].Text);
                        cthd.SoLuong = int.Parse(lvChiTietGoiMonCN.Items[i].SubItems[2].Text);
                        a.ThemChiTietHoaDon(cthd);
                    }
                    if (kq == true)
                    {
                        MessageBoxEx.Show("Cập nhật gọi món thành công!");
                        DuaDSBanDaGoiLenCombobox();
                        DuaBanLenCombobox();
                        lvChiTietGoiMonCN.Items.Clear();
                        tbDonGia.Text = "";
                    }
                }
                else
                {
                    MessageBoxEx.Show("Nhập số lượng khách!");
                }
            }
            else
            {
                MessageBoxEx.Show("Chưa chọn thực đơn!");
            }
        }

        private void lbDSTDCN_Click(object sender, EventArgs e)
        {
            int maTD = int.Parse(lbDSTDCN.SelectedValue.ToString());
            float gia = a.LayGiaTheoMaTD(maTD);
            lbGiaTKCN.Text = gia.ToString();
            tbDonGiaCN.Text = Convert.ToString(float.Parse(lbGiaTKCN.Text) - (float.Parse(cmbKhuyenMaiCN.Text) / 100) * float.Parse(lbGiaTKCN.Text));
        }

        private void cmbKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbDonGia.Text != "")
                    tbDonGia.Text = Convert.ToString(float.Parse(lbGiaTK.Text) - (float.Parse(cmbKhuyenMai.Text) / 100) * float.Parse(lbGiaTK.Text));
            }
            catch { }
        }

        private void cmbKhuyenMaiCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDonGiaCN.Text = Convert.ToString(float.Parse(lbGiaTKCN.Text) - (float.Parse(cmbKhuyenMaiCN.Text) / 100) * float.Parse(lbGiaTKCN.Text));
        }
        #endregion

        #region THONG_KE
        private void btTKTheoNgay_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime ngay = dtNgayPC.Value;
                HDTKDTO[] kq = a.ThongKeHDTheoNgay(ngay);
                dgvThongKe.DataSource = kq;
                ThongKe(kq);
                if (kq.Length > 0)
                    flag = 1;
                else
                    flag = 0;
            }
            catch
            {
                MessageBoxEx.Show("Mời chọn ngày cần thống kê!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btTKTheoThang_Click(object sender, EventArgs e)
        {
            if (cbThangTK.Text != "")
            {
                if (tbNamTK.Text != "")
                {
                    int thang = int.Parse(cbThangTK.Text);
                    int nam = int.Parse(tbNamTK.Text);
                    HDTKDTO[] dt = a.ThongKeHDTheoThang(thang, nam);
                    dgvThongKe.DataSource = dt;
                    ThongKe(dt);
                    if (dt.Length > 0)
                    {
                        flag = 2;
                        return;
                    }
                    else
                    {
                        flag = 0;
                        return;
                    }
                }
                else
                {
                    MessageBoxEx.Show("Mời chọn năm cần thống kê!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBoxEx.Show("Mời chọn tháng cần thống kê!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ThongKe(HDTKDTO[] kq)
        {
            if (kq.Length > 0)
            {
                float tongDoanhThu = 0;
                int tongKhachDen = 0;
                for (int i = 0; i < dgvThongKe.Rows.Count - 1; i++)
                {
                    tongDoanhThu += float.Parse(dgvThongKe.Rows[i].Cells[6].Value.ToString());
                    tongKhachDen += int.Parse(dgvThongKe.Rows[i].Cells[3].Value.ToString());
                }
                lbTongDoanhThu.Text = tongDoanhThu.ToString() + " VNÐ";
                lbSoLuongKhachDen.Text = tongKhachDen.ToString() + " Khách";

                DataTable _ds = new DataTable();
                _ds.Columns.Add("SoHD", typeof(int));
                _ds.Columns.Add("MaThucDon", typeof(int));
                _ds.Columns.Add("SoLuong", typeof(int));
                _ds.PrimaryKey = new DataColumn[] { _ds.Columns["SoHD"], _ds.Columns["MaThucDon"] };
                for (int i = 0; i < kq.Length; i++)
                {
                    int SoHD = kq[i].SoHD;
                    if (_ds.Rows.Count == 0)
                    {
                        CT_HoaDonDTO[] dtct = a.LayDSCTHD(SoHD);
                        for (int j = 0; j < dtct.Length; j++)
                        {
                            DataRow ct = _ds.NewRow();
                            ct[0] = dtct[j].SoHD;
                            ct[1] = dtct[j].MaTD;
                            ct[2] = dtct[j].SoLuong;
                            _ds.Rows.Add(ct);
                        }
                    }
                    else
                    {
                        CT_HoaDonDTO[] dtct = a.LayDSCTHD(SoHD);
                        for (int j = 0; j < dtct.Length; j++)
                        {
                            bool kt = false;
                            int dong = 0;
                            for (int k = 0; k < _ds.Rows.Count; k++)
                            {
                                if (dtct[j].MaTD.ToString() == _ds.Rows[k][1].ToString())
                                {
                                    dong = k;
                                    kt = true;
                                }
                            }
                            if (kt == true)
                            {
                                _ds.Rows[dong][2] = int.Parse(_ds.Rows[dong][2].ToString()) + dtct[j].MaTD;
                            }
                            else
                            {
                                DataRow ct = _ds.NewRow();
                                ct[0] = dtct[j].SoHD;
                                ct[1] = dtct[j].MaTD;
                                ct[2] = dtct[j].SoLuong;
                                _ds.Rows.Add(ct);
                            }
                        }
                    }
                }

                DataTable _dstd = new DataTable();
                _dstd.Columns.Add("SoHD", typeof(int));
                _dstd.Columns.Add("MaThucDon", typeof(int));
                _dstd.Columns.Add("SoLuong", typeof(int));
                _dstd.PrimaryKey = new DataColumn[] { _dstd.Columns["SoHD"], _dstd.Columns["MaThucDon"] };

                DataTable _dstu = new DataTable();
                _dstu.Columns.Add("SoHD", typeof(int));
                _dstu.Columns.Add("MaThucDon", typeof(int));
                _dstu.Columns.Add("SoLuong", typeof(int));
                _dstu.PrimaryKey = new DataColumn[] { _dstu.Columns["SoHD"], _dstu.Columns["MaThucDon"] };

                for (int i = 0; i < _ds.Rows.Count; i++)
                {
                    if (a.KiemTraThucAnNuocUong(int.Parse(_ds.Rows[i][1].ToString())))
                    {
                        DataRow ct = _dstd.NewRow();
                        ct[0] = int.Parse(_ds.Rows[i][0].ToString());
                        ct[1] = int.Parse(_ds.Rows[i][1].ToString());
                        ct[2] = int.Parse(_ds.Rows[i][2].ToString());
                        _dstd.Rows.Add(ct);
                    }
                    else
                    {
                        DataRow ct = _dstu.NewRow();
                        ct[0] = int.Parse(_ds.Rows[i][0].ToString());
                        ct[1] = int.Parse(_ds.Rows[i][1].ToString());
                        ct[2] = int.Parse(_ds.Rows[i][2].ToString());
                        _dstu.Rows.Add(ct);
                    }
                }

                if (_dstd.Rows.Count > 0)
                {
                    int MaxTD = int.Parse(_dstd.Rows[0][2].ToString());
                    for (int i = 0; i < _dstd.Rows.Count; i++)
                    {
                        int sl = int.Parse(_dstd.Rows[i][2].ToString());
                        if (MaxTD < sl)
                            MaxTD = int.Parse(_dstd.Rows[i][2].ToString());
                    }
                    int y = 0;
                    for (int i = 0; i < _dstd.Rows.Count; i++)
                    {
                        if (MaxTD == int.Parse(_dstd.Rows[i][2].ToString()))
                            y = i;
                    }

                    int MaTD = int.Parse(_dstd.Rows[y][1].ToString());
                    lbSLTDBanNhieuNhat.Text = MaxTD.ToString();
                    lbTDBanNhieuNhat.Text = a.LayTenThucDonTuMaThucDon(MaTD);
                    lbDVTDBanNhieuNhat.Text = a.LayDonViTinhTuMaTD(MaTD);
                }

                if (_dstu.Rows.Count > 0)
                {
                    int MaxTU = 0;
                    for (int i = 0; i < _dstu.Rows.Count; i++)
                    {
                        if (MaxTU < int.Parse(_dstu.Rows[i][2].ToString()))
                            MaxTU = int.Parse(_dstu.Rows[i][2].ToString());
                    }
                    int z = 0;
                    for (int i = 0; i < _dstu.Rows.Count; i++)
                    {
                        if (MaxTU == int.Parse(_dstu.Rows[i][2].ToString()))
                            z = i;
                    }

                    int MaTU = int.Parse(_dstu.Rows[z][1].ToString());
                    lbSLTUBanNhieuNhat.Text = MaxTU.ToString();
                    lbTUBanNhieuNhat.Text = a.LayTenThucDonTuMaThucDon(MaTU);
                    lbDVTUBanNhieuNhat.Text = a.LayDonViTinhTuMaTD(MaTU);
                }

            }
            else
            {
                lbTDBanNhieuNhat.Text = "Null";
                lbTUBanNhieuNhat.Text = "Null";
                lbDVTDBanNhieuNhat.Text = "Null";
                lbDVTUBanNhieuNhat.Text = "Null";
                lbSLTDBanNhieuNhat.Text = "0";
                lbSLTUBanNhieuNhat.Text = "0";
            }

        }

        private void btTKTheoKhoangNgay_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tuNgay = dtiTuNgay.Value;
                DateTime denNgay = dtiDenNgay.Value;

                HDTKDTO[] dt = a.ThongKeHDTheoKhoangNgay(tuNgay, denNgay);
                dgvThongKe.DataSource = dt;
                ThongKe(dt);
                if (dt.Length > 0)
                    flag = 3;
                else
                    flag = 0;
            }
            catch
            {
                MessageBoxEx.Show("Chưa chọn mốc ngày thống kê!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btTCHDTheoNgay_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngay = dtiNgayTCHD.Value;
                HDTKDTO[] kq = a.ThongKeHDTheoNgay(ngay);
                dtgDSHD.DataSource = kq;
            }
            catch
            {
                MessageBoxEx.Show("Mời chọn ngày cần tra cứu!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btTCHDTheoThangNam_Click(object sender, EventArgs e)
        {
            try
            {
                int thang = int.Parse(cmbThangTCHD.Text);
                int nam = int.Parse(tbNamTCHD.Text);
                HDTKDTO[] dt = a.ThongKeHDTheoThang(thang, nam);
                dtgDSHD.DataSource = dt;
            }
            catch
            {
                if (cmbThangTCHD.Text == "")
                    MessageBoxEx.Show("Mời chọn tháng cần tra cứu!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBoxEx.Show("Mời chọn năm cần tra cứu!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btTCHDTheoKhoangNgay_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tuNgay = dtiTuNgayTCHD.Value;
                DateTime denNgay = dtiDenNgayTCHD.Value;

                HDTKDTO[] dt = a.ThongKeHDTheoKhoangNgay(tuNgay, denNgay);
                dtgDSHD.DataSource = dt;
            }
            catch
            {
                MessageBoxEx.Show("Chưa chọn mốc ngày tra cứu!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btInHD_Click(object sender, EventArgs e)
        {
            try
            {
                ViewHoaDon frm = new ViewHoaDon();
                int idx = dtgDSHD.CurrentRow.Index;
                frm.SoHD = int.Parse(dtgDSHD.Rows[idx].Cells[0].Value.ToString());
                frm.ShowDialog();
            }
            catch
            {
                MessageBoxEx.Show("Chưa chọn hóa đơn cần in!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoaHD_Click(object sender, EventArgs e)
        {
            if (_nv.Quyen == "Admin")
            {
                DialogResult result = MessageBox.Show("Chắn chắn xóa?!!!", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int idx = dtgDSHD.CurrentRow.Index;
                        int SoHD = int.Parse(dtgDSHD.Rows[idx].Cells[0].Value.ToString());
                        a.XoaCTHDTheoSoHD(SoHD);
                        a.XoaHDTheoSoHD(SoHD);
                        MessageBoxEx.Show("Xóa Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DuaDSHoaDonLenDataGridView();
                        dtgDSCTHD.DataSource = null;
                        try
                        {
                            int idx2 = dtgDSHD.CurrentRow.Index;
                            int maHD = int.Parse(dtgDSHD.Rows[idx2].Cells[0].Value.ToString());
                            CTHDDTO[] _ds = a.LayDSCTHDTuMaHD(maHD);
                            dtgDSCTHD.DataSource = _ds;
                        }
                        catch { }
                    }
                    catch
                    {
                        MessageBoxEx.Show("Không có hóa đơn thanh toán nào trong hệ thống!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBoxEx.Show("Chỉ có Admin mới có thể sử dụng chức năng này!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btInDSHD_Click(object sender, EventArgs e)
        {
            if (dgvThongKe.Rows.Count < 1 || flag == 0)
            {
                MessageBoxEx.Show("Danh sách rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (flag == 1)
                {
                    ViewThongKeTheoNgay frm = new ViewThongKeTheoNgay();
                    frm.TongDoanhThu = lbTongDoanhThu.Text;
                    frm.Ngay = dtNgayPC.Value;
                    frm.ShowDialog();
                }
                if (flag == 2)
                {
                    ViewThongKeTheoThangNam frm = new ViewThongKeTheoThangNam();
                    frm.ThangNam = cbThangTK.Text + "/" + tbNamTK.Text;
                    frm.TongDoanhThu = lbTongDoanhThu.Text;
                    frm.ShowDialog();
                }
                if (flag == 3)
                {
                    ViewThongKeTheoKhoangNgay frm = new ViewThongKeTheoKhoangNgay();
                    frm.TongDoanhThu = lbTongDoanhThu.Text;
                    frm.TuNgay = dtiTuNgay.Value;
                    frm.DenNgay = dtiDenNgay.Value;
                    frm.ShowDialog();
                }
            }

        }

        private void btXoaHDTheoNgay_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngay = dtiNgayTCHD.Value;
                HDTKDTO[] dt = a.ThongKeHDTheoNgay(ngay);
                XoaDSHD(dt);
            }
            catch
            {
                MessageBoxEx.Show("Xóa hóa đơn không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void XoaDSHD(HDTKDTO[] dt)
        {
            if (_nv.Quyen == "Admin")
            {
                DialogResult result = MessageBox.Show("Chắn chắn xóa?!!!", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                if (result == DialogResult.Yes)
                {
                    for (int i = 0; i < dt.Length; i++)
                    {
                        int soHD = dt[i].SoHD;
                        a.XoaCTHDTheoSoHD(soHD);
                        a.XoaHDTheoSoHD(soHD);
                    }
                    MessageBoxEx.Show("Xóa hóa đơn thành công!");
                    DuaDSHoaDonLenDataGridView();

                    dtgDSCTHD.DataSource = null;
                    try
                    {
                        int idx2 = dtgDSHD.CurrentRow.Index;
                        int maHD = int.Parse(dtgDSHD.Rows[idx2].Cells[0].Value.ToString());
                        CTHDDTO[] _ds = a.LayDSCTHDTuMaHD(maHD);
                        dtgDSCTHD.DataSource = _ds;
                    }
                    catch { }
                }
            }
            else
            {
                MessageBoxEx.Show("Chỉ có Admin mới có thể sử dụng chức năng này!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btXoaHDTheoThangNam_Click(object sender, EventArgs e)
        {
            try
            {
                int thang = int.Parse(cmbThangTCHD.Text);
                int nam = int.Parse(tbNamTCHD.Text);
                HDTKDTO[] dt = a.ThongKeHDTheoThang(thang, nam);
                dtgDSHD.DataSource = dt;
                XoaDSHD(dt);
            }
            catch
            {
                MessageBoxEx.Show("Xóa hóa đơn không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoaHDTheoKhoangNgay_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tuNgay = dtiTuNgayTCHD.Value;
                DateTime denNgay = dtiDenNgayTCHD.Value;

                HDTKDTO[] dt = a.ThongKeHDTheoKhoangNgay(tuNgay, denNgay);
                dtgDSHD.DataSource = dt;
                XoaDSHD(dt);
            }
            catch
            {
                MessageBoxEx.Show("Xóa hóa đơn không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgDSHD_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = dtgDSHD.CurrentRow.Index;
                int maHD = int.Parse(dtgDSHD.Rows[idx].Cells[0].Value.ToString());
                CTHDDTO[] _ds = a.LayDSCTHDTuMaHD(maHD);
                dtgDSCTHD.DataSource = _ds;
            }
            catch { }

        }

        private void dtgDSHD_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                int idx = dtgDSHD.CurrentRow.Index;
                int maHD = int.Parse(dtgDSHD.Rows[idx].Cells[0].Value.ToString());
                CTHDDTO[] _ds = a.LayDSCTHDTuMaHD(maHD);
                dtgDSCTHD.DataSource = _ds;
            }
            catch
            {
                dtgDSCTHD.DataSource = null;
            }
        }
        #endregion

        #region PHAN_CONG_NV

        private void btThem_Click(object sender, EventArgs e)
        {
            if (_nv.Quyen == "Admin")
            {
                try
                {
                    if (cmbNhanVienPC.Text != "")
                    {
                        if (cmbCa.Text != "")
                        {
                            if (cmbBanPC.Text != "")
                            {
                                if (dtNgayPCNV.Text != "")
                                {
                                    PhanCongDTO pc = new PhanCongDTO();
                                    pc.Ngay = DateTime.Parse(dtNgayPCNV.Value.ToShortDateString());
                                    pc.Ngay.Date.ToString("dd/MM/yyyy");
                                    pc.Ca = int.Parse(cmbCa.Text);
                                    pc.MsNV = int.Parse(cmbNhanVienPC.SelectedValue.ToString());
                                    pc.MsBan = int.Parse(cmbBanPC.Text);

                                    bool kq = a.ThemPhanCong(pc);
                                    if (kq == true)
                                    {
                                        MessageBoxEx.Show("Phân công nhân viên thành công!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        DuaDanhSachPhanCongLenDataGridView();
                                    }
                                    else
                                    {
                                        MessageBoxEx.Show("Phân công thất bại!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                    MessageBoxEx.Show("Chưa chọn ngày!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBoxEx.Show("Chưa chọn bàn!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBoxEx.Show("Chưa chọn ca!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBoxEx.Show("Chưa chọn nhân viên!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBoxEx.Show("Phân công này đã có rồi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBoxEx.Show("Chỉ có Admin mới có thể sử dụng chức năng này!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btXoaPC_Click(object sender, EventArgs e)
        {
            if (_nv.Quyen == "Admin")
            {
                PhanCongDTO pc = new PhanCongDTO();
                int idx = dgvDSPhanCong.CurrentRow.Index;
                pc.Ngay = DateTime.Parse(dgvDSPhanCong.Rows[idx].Cells[0].Value.ToString());
                pc.Ngay.Date.ToShortDateString();
                pc.Ngay.Date.ToString("dd/MM/yyyy");
                pc.Ca = int.Parse(dgvDSPhanCong.Rows[idx].Cells[1].Value.ToString());
                pc.MsNV = a.LayMaNVTuTenNV(dgvDSPhanCong.Rows[idx].Cells[2].Value.ToString());
                pc.MsBan = int.Parse(dgvDSPhanCong.Rows[idx].Cells[3].Value.ToString());

                DialogResult result = MessageBox.Show("Chắn chắn xóa?!!!", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                if (result == DialogResult.Yes)
                {
                    bool kq = a.XoaPhanCong(pc);
                    if (kq == true)
                    {
                        MessageBoxEx.Show("Xóa phân công thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DuaDanhSachPhanCongLenDataGridView();
                    }
                    else
                    {
                        MessageBoxEx.Show("Xóa phân công thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBoxEx.Show("Chỉ có Admin mới có thể sử dụng chức năng này!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region THUC_DON

        private void cbLoaiTD_SelectedValueChanged(object sender, EventArgs e)
        {
            int maLoai = a.LayMaLoaiTuTenLoai(cbLoaiTD.Text);
            TDDTO[] dsTD = a.LayDanhSachTDTheoMaLoai(maLoai);
            dgvDSThucDon.DataSource = dsTD;
            int idx = 0;
            tbTenTD.Text = dgvDSThucDon.Rows[idx].Cells[1].Value.ToString();
            tbDonGiaTD.Text = dgvDSThucDon.Rows[idx].Cells[2].Value.ToString();
            tbDVT.Text = dgvDSThucDon.Rows[idx].Cells[3].Value.ToString();
            cmbLoaiThucDon.Text = dgvDSThucDon.Rows[idx].Cells[4].Value.ToString();
            tbTenTDTraCuu.Text = "";
        }

        private void btThemTD_Click(object sender, EventArgs e)
        {
            if (_nv.Quyen == "Admin")
            {
                if (tbTenTD.Text != "")
                {
                    if (tbDonGiaTD.Text != "")
                    {
                        if (tbDVT.Text != "")
                        {
                            ThemThucDon();
                        }
                        else
                            MessageBoxEx.Show("Chưa nhập đơn vị tính!");
                    }
                    else
                        MessageBoxEx.Show("Chưa nhập đơn giá!");
                }
                else
                    MessageBoxEx.Show("Chưa nhập tên thực đơn!");
            }
            else
            {
                MessageBoxEx.Show("Chỉ có Admin mới có thể sử dụng chức năng này!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btSuaTD_Click(object sender, EventArgs e)
        {
            if (_nv.Quyen == "Admin")
            {
                ThucDonDTO td = new ThucDonDTO();

                int idx = dgvDSThucDon.CurrentRow.Index;
                if (tbTenTD.Text != "")
                {

                    if (tbDVT.Text != "")
                    {
                        if (tbDonGiaTD.Text != "")
                        {
                            td.MaTD = int.Parse(dgvDSThucDon.Rows[idx].Cells[0].Value.ToString());
                            td.MaLoai = a.LayMaLoaiTuTenLoai(cmbLoaiThucDon.Text);
                            td.TenTD = tbTenTD.Text;
                            string TenTDCN = tbTenTD.Text;
                            td.DonViTinh = tbDVT.Text;
                            td.DonGia = float.Parse(tbDonGiaTD.Text);
                            bool kt;
                            kt = a.KiemTraTenTDCapNhat(tbTenTD.Text, td.MaTD);
                            if (true)
                            {
                                try
                                {
                                    if (td.DonGia > 0)
                                    {
                                        bool kq = a.CapNhatThucDon(td);
                                        if (kq == true)
                                        {
                                            MessageBoxEx.Show("Cập nhật thực đơn thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            TDDTO[] k = a.TraCuuThucDonTheoTen(TenTDCN);
                                            dgvDSThucDon.DataSource = k;
                                        }
                                        else
                                            MessageBoxEx.Show("Cập nhật thực đơn thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBoxEx.Show("Đơn giá phải lớn hơn 0!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        tbDonGiaTD.Text = "";
                                        tbDonGiaTD.Focus();
                                    }
                                }
                                catch
                                {
                                    MessageBoxEx.Show("Chưa nhập đơn giá hoặc kiểu dữ liệu đơn giá không đúng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    tbDonGiaTD.Text = "";
                                    tbDonGiaTD.Focus();
                                }
                            }

                        }
                        else
                        {
                            MessageBoxEx.Show("Chưa nhập đơn giá!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbDonGiaTD.Text = "";
                            tbDonGiaTD.Focus();
                        }

                    }
                    else
                    {
                        MessageBoxEx.Show("Chưa nhập đơn vị tính!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbDVT.Text = "";
                        tbDVT.Focus();
                    }
                }
                else
                {
                    MessageBoxEx.Show("Chưa nhập tên thực đơn!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbTenTD.Text = "";
                    tbTenTD.Focus();
                }
            }
            else
            {
                MessageBoxEx.Show("Chỉ có Admin mới có thể sử dụng chức năng này!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btXoaTD_Click(object sender, EventArgs e)
        {
            if (_nv.Quyen == "Admin")
            {
                try
                {
                    int idx = dgvDSThucDon.CurrentRow.Index;
                    int maTD = int.Parse(dgvDSThucDon.Rows[idx].Cells[0].Value.ToString());
                    DialogResult result = MessageBox.Show("Chắn chắn xóa?!!!", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    if (result == DialogResult.Yes)
                    {
                        bool kq2;
                        try
                        {
                            kq2 = a.XoaThucDonTheoMaTD(maTD);

                            if (kq2 == true)
                            {
                                MessageBoxEx.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tbTenTD.Text = "";
                                tbDonGiaTD.Text = "";
                                tbDVT.Text = "";

                                if (tbTenTDTraCuu.Text != "")
                                    btTim_Click(sender, e);
                                if (cbLoaiTD.Text != "")
                                    cbLoaiTD_SelectedValueChanged(sender, e);
                            }
                            else
                                MessageBoxEx.Show("Xóa thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch
                        {
                            MessageBoxEx.Show("Thực đơn đã được gọi món hoặc có trong hóa đơn. Không thể xóa!!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch
                {
                    MessageBoxEx.Show("Chưa chọn thực đơn cần xóa!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBoxEx.Show("Chỉ có Admin mới có thể sử dụng chức năng này!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ThemThucDon()
        {
            ThucDonDTO td = new ThucDonDTO();
            td.MaTD = a.TDMaTuTang();
            td.MaLoai = a.LayMaLoaiTuTenLoai(cbLoaiTD.Text);
            td.TenTD = tbTenTD.Text;
            td.DonViTinh = tbDVT.Text;
            td.DonGia = float.Parse(tbDonGiaTD.Text);
            try
            {
                bool kt = a.KiemTraTrungTenThucDon(td.TenTD);
                if (kt == true)
                {
                    bool kq1 = a.ThemThucDon(td);
                    if (kq1 == true)
                    {
                        MessageBoxEx.Show("Thêm thực đơn thành công!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TDDTO[] kq = a.TraCuuThucDonTheoTen(tbTenTD.Text);
                        dgvDSThucDon.DataSource = kq;

                    }
                }
                else
                    MessageBoxEx.Show("Thực đơn này đã có!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBoxEx.Show("Kiểu dữ liệu nhập đơn giá không chính xác! Vui lòng nhập lại đơn giá!");
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            tbTenTD.Text = "";
            cbLoaiTD.Text = "";
            tbDonGiaTD.Text = "";
            tbDVT.Text = "";
            if (tbTenTDTraCuu.Text == "")
                MessageBoxEx.Show("Chưa nhập tên thực đơn cần tra cứu!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                TDDTO[] kq = a.TraCuuThucDonTheoTen(tbTenTDTraCuu.Text);
                dgvDSThucDon.DataSource = kq;
                if(dgvDSThucDon.Rows.Count > 1)
                {
                    int idx = 0;
                    tbTenTD.Text = dgvDSThucDon.Rows[idx].Cells[1].Value.ToString();
                    tbDonGiaTD.Text = dgvDSThucDon.Rows[idx].Cells[2].Value.ToString();
                    tbDVT.Text = dgvDSThucDon.Rows[idx].Cells[3].Value.ToString();
                    cmbLoaiThucDon.Text = dgvDSThucDon.Rows[idx].Cells[4].Value.ToString();
                }
            }
        }

        private void dgvDSThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dgvDSThucDon.CurrentRow.Index;
            tbTenTD.Text = dgvDSThucDon.Rows[idx].Cells[1].Value.ToString();
            tbDonGiaTD.Text = dgvDSThucDon.Rows[idx].Cells[2].Value.ToString();
            tbDVT.Text = dgvDSThucDon.Rows[idx].Cells[3].Value.ToString();
            cmbLoaiThucDon.Text = dgvDSThucDon.Rows[idx].Cells[4].Value.ToString();
        }

        #endregion
    }
}
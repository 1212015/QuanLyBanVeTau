using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using RestaurantManagerSystem.GUI;
using DTO;
using BUS;
using DAO;

namespace RestaurantManagerSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private UsersDTO _us = new UsersDTO();
        public UsersDTO us;


        #region FORM_LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadThongTinNguoiDung();
            DuaBangGiaVeLenDataGridView();
            DuaBangDSAdminLenDataGridView();
            DuaDSNhanVienLenDataGridView();
            DuaDSKhachHangLenDataGridView();
            DuaDSGaDiCombobox();
            DuaDSGaDenCombobox();
            DuaDSQuyenLenCombobox();
            DuaDSLoaiNhanVienLenCombobox();
            DuaDSNhanVienLenCombobox();
            DuaBangDSNVLenDataGridView();
            DuaBangDSKHLenDataGridView();
            DuaDSGaDiCombobox_DatVe();
            DuaDSGaDenCombobox_DatVe();
            DuaDSLoaiGheLenCombobox_DatVe();
            DuaDSLoaiTauLenCombobox_DatVe();
            DuaDSTuyenLenData();
            DuaDSGaKhoiHanhLenCombobox();
            DuaDSGaKThucLenCombobox();
            DuaDSDoanTauLenData();
            DuaDSToaTauLenCombobox();
            DuaDSTenLoaiGheLenCombobox();
            DuaDSTenLoaiTauLenCombobox();
            DuaDSDonNghiPhepLenData();
            DuaDSGiaVeLenData();
            DuaDSChuyenLenData();
            DuaDSNVLaiLenCombobox();
            DuaDSNVTruongLenCombobox();
            DuaDSTenTuyenLenCombobox();
            DuaDSMaDoanTauLenCombobox();
            DuaDSToaTauChuyen1LenCombobox();
            DuaDSToaTauChuyen2LenCombobox();


            if (lbTenDN.Text == "khachhang1" && lbQuyen.Text == "CustomerNo")
            {
                btDangNhap.Enabled = true;
                btDangXuat.Enabled = false;
            }
            else
            {
                btDangNhap.Enabled = false;
                btDangXuat.Enabled = true;
            }
        }
        
        private void LoadThongTinNguoiDung()
        {
            lbTenDN.Text = us.UserName.ToString();

            if (us.GroupId.ToString() == "1")
            {
                lbQuyen.Text = "Admin";
                //tab cua khach hang chua co tai khoan
                tiDangKy.Visible = false;
                tiThongTinVe.Visible = false;
                tiTimKiemChuyenTau.Visible = false;
                tiCapNhatThongTinKH.Visible = false;
                tiCapNhatThongTinNV.Visible = false;
                //tab cua manager
                tiTuyen.Visible = false;
                tiChuyen.Visible = false;
                tiGiaVe.Visible = false;
                tiDoantau.Visible = false;
                tiDuyetDon.Visible = false;
                tab_DonNghiPhep.Visible = false;
                tab_XemPhanCong.Visible = false;
                tab_DoiVe.Visible = false;
                tab_HoaDon.Visible = false;

            }
            if (us.GroupId.ToString() == "2")
            {
                lbQuyen.Text = "Manager";
                // tab cua admin
                tiThemTKNV.Visible = false;
                ti_QuanLyNguoiDung.Visible = false;
                tiKhachHang_QLND.Visible = false;
                tiNhanVien_QLND.Visible = false;
                ti_Admin.Visible = false;
                tiCapNhatThongTinKH.Visible = false;
                tab_DonNghiPhep.Visible = false;
                tab_XemPhanCong.Visible = false;
                tab_DoiVe.Visible = false;
                tab_HoaDon.Visible = false;
            }
            if (us.GroupId.ToString() == "5")
            {
                lbQuyen.Text = "EmployeeDriver";
                // tab cua admin
                tiThemTKNV.Visible = false;
                ti_QuanLyNguoiDung.Visible = false;
                tiKhachHang_QLND.Visible = false;
                tiNhanVien_QLND.Visible = false;
                ti_Admin.Visible = false;
                tiCapNhatThongTinKH.Visible = false;
                //tab cua manager
                tiTuyen.Visible = false;
                tiChuyen.Visible = false;
                tiGiaVe.Visible = false;
                tiDoantau.Visible = false;
                tiDuyetDon.Visible = false;
                tab_DoiVe.Visible = false;
                tab_HoaDon.Visible = false;
            }
            if (us.GroupId.ToString() == "3")
            {
                lbQuyen.Text = "Employee";
                // tab cua admin
                tiThemTKNV.Visible = false;
                ti_QuanLyNguoiDung.Visible = false;
                tiKhachHang_QLND.Visible = false;
                tiNhanVien_QLND.Visible = false;
                ti_Admin.Visible = false;
                tiCapNhatThongTinKH.Visible = false;
                //tab cua manager
                tiTuyen.Visible = false;
                tiChuyen.Visible = false;
                tiGiaVe.Visible = false;
                tiDoantau.Visible = false;
                tiDuyetDon.Visible = false;
                tab_DoiVe.Visible = false;
                tab_HoaDon.Visible = false;
            }
            if (us.GroupId.ToString() == "4")
            {
                lbQuyen.Text = "EmployeeSales";
                // tab cua admin
                tiThemTKNV.Visible = false;
                ti_QuanLyNguoiDung.Visible = false;
                tiKhachHang_QLND.Visible = false;
                tiNhanVien_QLND.Visible = false;
                ti_Admin.Visible = false;
                tiCapNhatThongTinKH.Visible = false;
                //tab cua manager
                tiTuyen.Visible = false;
                tiChuyen.Visible = false;
                tiGiaVe.Visible = false;
                tiDoantau.Visible = false;
                tiDuyetDon.Visible = false;
                tab_DonNghiPhep.Visible = false;
                tab_XemPhanCong.Visible = false;
            }
            if (us.GroupId.ToString() == "6")
            {
                lbQuyen.Text = "Customer";
                // tab cua admin
                tiThemTKNV.Visible = false;
                ti_QuanLyNguoiDung.Visible = false;
                tiKhachHang_QLND.Visible = false;
                tiNhanVien_QLND.Visible = false;
                ti_Admin.Visible = false;
                tiCapNhatThongTinNV.Visible = false;
                //tab cua manager
                tiTuyen.Visible = false;
                tiChuyen.Visible = false;
                tiGiaVe.Visible = false;
                tiDoantau.Visible = false;
                tiDuyetDon.Visible = false;
                tab_DonNghiPhep.Visible = false;
                tab_XemPhanCong.Visible = false;
                tab_DoiVe.Visible = false;
                tab_HoaDon.Visible = false;
            }
            if (us.GroupId.ToString() == "7")
            {
                lbQuyen.Text = "CustomerNo";
                // tab cua admin
                tiThemTKNV.Visible = false;
                ti_QuanLyNguoiDung.Visible = false;
                tiKhachHang_QLND.Visible = false;
                tiNhanVien_QLND.Visible = false;
                ti_Admin.Visible = false;
                tiCapNhatThongTinNV.Visible = false;
                //tab cua manager
                tiTuyen.Visible = false;
                tiChuyen.Visible = false;
                tiGiaVe.Visible = false;
                tiDoantau.Visible = false;
                tiDuyetDon.Visible = false;
                tab_DonNghiPhep.Visible = false;
                tab_XemPhanCong.Visible = false;
                tab_DoiVe.Visible = false;
                tab_HoaDon.Visible = false;
            }
        }

        public void DuaBangGiaVeLenDataGridView()
        {
            DataTable _bangve = GiaVeBUS.LayBangGia();
            dgvBangGiaVe_TTGV.DataSource = _bangve;
        }

        public void DuaBangDSAdminLenDataGridView()
        {
            DataTable _dsAdmin = NhanVienBUS.LayDSAdmin();
            dtgDSAdmin.DataSource = _dsAdmin;
        }

        public void DuaDSNhanVienLenDataGridView()
        {
            DataTable _dsnv = NhanVienBUS.QuanLyTaiKhoanNhanVien();
            dtgvDSNV_NV_QLND.DataSource = _dsnv;
        }

        public void DuaDSKhachHangLenDataGridView()
        {
            DataTable _dsnv = KhachHangBUS.QuanLyTaiKhoanKhachHang();
            dtgvDSKH_KH_QLND.DataSource = _dsnv;
        }
        public void DuaBangDSNVLenDataGridView()
        {
            DataTable _dsNV = NhanVienBUS.LayDSNhanVienCN();
            dtgDSNV.DataSource = _dsNV;
        }
        public void DuaBangDSKHLenDataGridView()
        {
            DataTable _dsKH = KhachHangBUS.LayDSKhachHang();
            dtgDSKH.DataSource = _dsKH;
        }

        public void DuaDSTuyenLenData()
        {
            DataTable _ds = TuyenBUS.LayDSTuyen();
            dtgDSTuyen.DataSource = _ds;
        }

        public void DuaDSChuyenLenData()
        {
            DataTable _ds = ChuyenBUS.LayDSChuyen();
            dtgDSChuyen.DataSource = _ds;
        }

        public void DuaDSDoanTauLenData()
        {
            DataTable _ds = DoanTauBUS.LayDSDoanTau();
            dtgDSDoanTau.DataSource = _ds;
        }

        public void DuaDSDonNghiPhepLenData()
        {
            DataTable _ds = DonNghiPhepBUS.LayDSDonXinNghiPhep();
            dtgDSDonXinNghiPhep.DataSource = _ds;
        }

        public void DuaDSGiaVeLenData()
        {

            DataTable _ds = GiaVeBUS.LayDSGiaVe();
            dtgDSGiaVe.DataSource = _ds;
        }


        public void DuaDSGaKhoiHanhLenCombobox()
        {
            List<GaDTO> _ds = GaBUS.LayDSGa1();

            cbGakhoihanh.DataSource = _ds;
            cbGakhoihanh.ValueMember = "MaGa";
            cbGakhoihanh.DisplayMember = "TenGa";
            tbDCGakhoihanh.Text = GaBUS.LayDCGa(cbGakhoihanh.Text);


            cbGaKhoiHanhGiaVe.DataSource = _ds;
            cbGaKhoiHanhGiaVe.ValueMember = "MaGa";
            cbGaKhoiHanhGiaVe.DisplayMember = "TenGa";
            tbDCGaKhoiHanhGiaVe.Text = GaBUS.LayDCGa(cbGaKhoiHanhGiaVe.Text);

        }

        public void DuaDSGaKThucLenCombobox()
        {
            List<GaDTO> _ds = GaBUS.LayDSGa1();

            cbGakthuc.DataSource = _ds;
            cbGakthuc.ValueMember = "MaGa";
            cbGakthuc.DisplayMember = "TenGa";
            tbDCGakthuc.Text = GaBUS.LayDCGa(cbGakthuc.Text);

            cbGaKthucGiaVe.DataSource = _ds;
            cbGaKthucGiaVe.ValueMember = "MaGa";
            cbGaKthucGiaVe.DisplayMember = "TenGa";
            tbDCGaKthucGiaVe.Text = GaBUS.LayDCGa(cbGaKthucGiaVe.Text);
        }

        public void DuaDSToaTauLenCombobox()
        {
            List<ToaTauDTO> _ds = ToaTauBUS.LayMaToaTau();

            cbTcaMaToa.DataSource = _ds;
            cbTcaMaToa.ValueMember = "MaToa";
            cbTcaMaToa.DisplayMember = "MaToa";
            // tbDCGakthuc.Text = TuyenBUS.LayDCGa(cbGakthuc.Text);
        }

        public void DuaDSToaTauChuyen1LenCombobox()
        {
            List<ToaTauDTO> _ds = ToaTauBUS.LayMaToaTau();

            cbMaToaTau1Chuyen.DataSource = _ds;
            cbMaToaTau1Chuyen.ValueMember = "MaToa";
            cbMaToaTau1Chuyen.DisplayMember = "MaToa";
            // tbDCGakthuc.Text = TuyenBUS.LayDCGa(cbGakthuc.Text);
        }

        public void DuaDSToaTauChuyen2LenCombobox()
        {
            List<ToaTauDTO> _ds = ToaTauBUS.LayMaToaTau();

            cbMaToaTau2Chuyen.DataSource = _ds;
            cbMaToaTau2Chuyen.ValueMember = "MaToa";
            cbMaToaTau2Chuyen.DisplayMember = "MaToa";
            // tbDCGakthuc.Text = TuyenBUS.LayDCGa(cbGakthuc.Text);
        }

        public void DuaDSTenLoaiGheLenCombobox()
        {
            List<LoaiGheDTO> _ds = LoaiGheBUS.LayTenLoaiGhe();

            cbTcaTenLoaiGhe.DataSource = _ds;
            cbTcaTenLoaiGhe.ValueMember = "MaLoaiGhe";
            cbTcaTenLoaiGhe.DisplayMember = "TenLoaiGhe";
            // tbDCGakthuc.Text = TuyenBUS.LayDCGa(cbGakthuc.Text);
        }

        public void DuaDSTenLoaiTauLenCombobox()
        {
            List<LoaiTauDTO> _ds = LoaiTauBUS.LayTenToaTau();

            cbTenLoaiTau.DataSource = _ds;
            cbTenLoaiTau.ValueMember = "MaLoaiTau";
            cbTenLoaiTau.DisplayMember = "TenLoaiTau";
            // tbDCGakthuc.Text = TuyenBUS.LayDCGa(cbGakthuc.Text);
        }

        public void DuaDSTenTuyenLenCombobox()
        {
            List<TuyenDTO> _ds = TuyenBUS.LayDSTenTuyen();

            cbTenTuyenChuyen.DataSource = _ds;
            cbTenTuyenChuyen.ValueMember = "MaTuyen";
            cbTenTuyenChuyen.DisplayMember = "TenTuyen";
            //tbDCGakhoihanh.Text = GaBUS.LayDCGa(cbGakhoihanh.Text);

        }
        public void DuaDSNVLaiLenCombobox()
        {
            List<NhanVienDTO> _ds = NhanVienBUS.LayTenNhanVien();

            cbNVLaiChuyen.DataSource = _ds;
            cbNVLaiChuyen.ValueMember = "MaNV";
            cbNVLaiChuyen.DisplayMember = "HoTen";
            //tbDCGakhoihanh.Text = GaBUS.LayDCGa(cbGakhoihanh.Text);

        }

        public void DuaDSNVTruongLenCombobox()
        {
            List<NhanVienDTO> _ds = NhanVienBUS.LayTenNhanVien();

            cbNVTruongChuyen.DataSource = _ds;
            cbNVTruongChuyen.ValueMember = "MaNV";
            cbNVTruongChuyen.DisplayMember = "HoTen";
            //tbDCGakhoihanh.Text = GaBUS.LayDCGa(cbGakhoihanh.Text);

        }

        public void DuaDSMaDoanTauLenCombobox()
        {
            List<DoanTauDTO> _ds = DoanTauBUS.LayDSMaDoanTau();

            cbMaDoanTauChuyen.DataSource = _ds;
            cbMaDoanTauChuyen.ValueMember = "MaDoanTau";
            cbMaDoanTauChuyen.DisplayMember = "MaDoanTau";
            int madoantau = int.Parse(cbMaDoanTauChuyen.SelectedValue.ToString());
            tbTenTauChuyen.Text = DoanTauBUS.LayTenTauTheoMaDoanTau(madoantau);

        }

        #endregion

        #region THOAT
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            //if (result == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            Application.Exit();
        }
        #endregion

        #region Tab DangKy
        public bool ThemTaiKhoanKhachHang()
        {
            bool flag = false;
            if (!UsersBUS.KiemTraTenDNTonTaiKhachHang(tbTenDangNhap_DK.Text))
            {
                bool kq = UsersBUS.ThemTaiKhoanKhachHang(tbTenDangNhap_DK.Text, tbMatKhau_DK.Text, tbEmail_DK.Text);

                if (kq == true)
                {
                    flag = true;
                    return flag;
                }
            }
            else
            {
                MessageBoxEx.Show("Tên đăng nhập này đã tồn tại!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flag;
        }

        public bool ThemKhachHang()
        {
            bool flag = false;
            KhachHangDTO kh = new KhachHangDTO();
            //kh.MaKH lay ma tu tang
            kh.HoTen = tbHoTen_DK.Text;
            kh.NgaySinh = DateTime.Parse(dtNgaySinh_DK.Text);
            kh.CMND = tbCMND_DK.Text;
            kh.DiaChi = tbDiaChi_DK.Text;
            kh.DienThoai = tbDienThoai_DK.Text;

            bool kq = KhachHangBUS.ThemKhachHang(kh);
            if (kq == true)
            {
                flag = true;
                return flag;
            }
            else
            {
                return flag;
            }
            return flag;
        }

        private void btDangKy_DK_Click(object sender, EventArgs e)
        {
            if (tbTenDangNhap_DK.Text.Length >= 6 && tbTenDangNhap_DK.Text.Length <= 20)
            {
                if (tbCMND_DK.Text != "")
                {
                    if (tbHoTen_DK.Text != "")
                    {
                        if (tbMatKhau_DK.Text.Length >= 6 && tbMatKhau_DK.Text.Length <= 20)
                        {
                            if (tbMatKhau_DK.Text == tbNhapLaiMK_DK.Text)
                            {
                                if (dtNgaySinh_DK.Text != "")
                                {
                                    if (ThemTaiKhoanKhachHang() == true && ThemKhachHang() == true)
                                    {
                                        MessageBoxEx.Show("Thêm người dùng thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        tbTenDangNhap_DK.Text = "";
                                        tbMatKhau_DK.Text = "";
                                        tbNhapLaiMK_DK.Text = "";
                                        tbHoTen_DK.Text = "";
                                        tbEmail_DK.Text = "";
                                        tbCMND_DK.Text = "";
                                        tbDienThoai_DK.Text = "";
                                        tbDiaChi_DK.Text = "";

                                    }
                                    else
                                    {
                                        MessageBoxEx.Show("Thêm thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBoxEx.Show("Ngày sinh không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBoxEx.Show("Mật khẩu không trùng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tbNhapLaiMK_DK.Text = "";
                                tbNhapLaiMK_DK.Focus();
                            }
                        }
                        else
                        {
                            MessageBoxEx.Show("Mật khẩu phải lớn hơn 5 và nhỏ hơn 21 ký tự!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbMatKhau_DK.Text = "";
                            tbMatKhau_DK.Focus();
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Họ tên không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbHoTen_DK.Focus();
                    }
                }
                else
                {
                    MessageBoxEx.Show("CMND không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCMND_DK.Focus();
                }
            }
            else
            {
                MessageBoxEx.Show("Tên Đăng nhập phải lớn hơn 5 và nhỏ hơn 21 ký tự!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTenDangNhap_DK.Text = "";
                tbTenDangNhap_DK.Focus();
            }
        }

        private void tbCMND_DK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbDienThoai_DK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region CHUNG
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDN = new frmDangNhap();
            frmDN.Show();
            this.Hide();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            //DialogResult dialog = new DialogResult

            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Close();
        }

        #endregion

        #region Tab Admin
        private void dtgDSAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            tbTenNhom_Admin.Text = dtgDSAdmin.Rows[i].Cells[1].Value.ToString();
            tbTenDN_Admin.Text = dtgDSAdmin.Rows[i].Cells[2].Value.ToString();
            tbMatkhau_Admin.Text = dtgDSAdmin.Rows[i].Cells[3].Value.ToString();
            tbNhapLaiMK_Admin.Text = dtgDSAdmin.Rows[i].Cells[3].Value.ToString();
            tbTenNhom_Admin.ReadOnly = true;
            tbTenDN_Admin.ReadOnly = true;
        }

        public void SuaAdmin()
        {
            UsersDTO us = new UsersDTO();
            int idx = dtgDSAdmin.CurrentRow.Index;
            us.UserId = int.Parse(dtgDSAdmin.Rows[idx].Cells[0].Value.ToString());
            us.Password = tbMatkhau_Admin.Text;

            bool kq = NhanVienBUS.CapNhatMatKhauAdmin(us.UserId, us.Password);
            if (kq == true)
            {
                MessageBoxEx.Show("Cập nhật thông tin người dùng thành công!");
                DuaBangDSAdminLenDataGridView();
                tbMatkhau_Admin.Text = "";
                tbNhapLaiMK_Admin.Text = "";
                tbTenNhom_Admin.Text = "";
                tbTenDN_Admin.Text = "";
            }
            else
            {
                MessageBoxEx.Show("Cập nhật thất bại!");
            }

        }

        private void btSuaAdmin_Click(object sender, EventArgs e)
        {
            if (tbMatkhau_Admin.Text.Length >= 6 && tbMatkhau_Admin.Text.Length <= 20)
            {
                if (tbMatkhau_Admin.Text == tbNhapLaiMK_Admin.Text)
                {
                    SuaAdmin();
                }
                else
                {
                    MessageBoxEx.Show("Mật khẩu không trùng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbNhapLaiMK_Admin.Text = "";
                    tbNhapLaiMK_Admin.Focus();
                }
            }
            else
            {
                MessageBoxEx.Show("Mật khẩu phải lớn hơn 5 và nhỏ hơn 21 ký tự!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMatkhau_Admin.Text = "";
                tbMatkhau_Admin.Focus();
            }
        }
        #endregion

        #region Tab Quan Ly Nguoi Dung
        private void tbHoTen_NV_QLND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btTim_NV_QLND_Click(sender, e);
        }

        private void btTim_NV_QLND_Click(object sender, EventArgs e)
        {
            if (tbHoTen_NV_QLND.Text == "")
                MessageBoxEx.Show("Chưa nhập tên nhân viên cần tra cứu!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable dt = NhanVienBUS.TraCuuNhanVienTheoTen(tbHoTen_NV_QLND.Text);
                dtgvDSNV_NV_QLND.DataSource = dt;
            }
        }

        private void btDSNV_NV_QLND_Click(object sender, EventArgs e)
        {
            DuaDSNhanVienLenDataGridView();
        }

        private void btXoa_NV_QLND_Click(object sender, EventArgs e)
        {
            int idx = dtgvDSNV_NV_QLND.CurrentRow.Index;
            int maNV = int.Parse(dtgvDSNV_NV_QLND.Rows[idx].Cells[0].Value.ToString());

            DialogResult result = MessageBox.Show("Chắn chắn xóa?!!!", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            if (result == DialogResult.Yes)
            {
                bool kq;
                try
                {
                    kq = NhanVienBUS.KhoaTaiKhoanNhanVien(maNV);
                    if (kq == true)
                    {
                        MessageBoxEx.Show("Đã cập nhập khóa người dùng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DuaDSNhanVienLenDataGridView();
                    }
                    else
                        MessageBoxEx.Show("Xóa nhân viên thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch
                {
                    MessageBoxEx.Show("Không thể xóa", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btThem_NV_QLND_Click(object sender, EventArgs e)
        {
            tiThemTKNV.Visible = true;
        }

        private void btTim_KH_QLND_Click(object sender, EventArgs e)
        {
            if (tbHoTen_KH_QLND.Text == "")
                MessageBoxEx.Show("Chưa nhập tên nhân viên cần tra cứu!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable dt = KhachHangBUS.TraCuuKhachHangTheoTen(tbHoTen_KH_QLND.Text);
                dtgvDSKH_KH_QLND.DataSource = dt;
            }
        }

        private void btXoa_KH_QLND_Click(object sender, EventArgs e)
        {
            int idx = dtgvDSKH_KH_QLND.CurrentRow.Index;
            int maNV = int.Parse(dtgvDSKH_KH_QLND.Rows[idx].Cells[0].Value.ToString());

            DialogResult result = MessageBox.Show("Chắn chắn xóa?!!!", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            if (result == DialogResult.Yes)
            {
                bool kq;
                try
                {
                    kq = KhachHangBUS.KhoaTaiKhoanKhachHang(maNV);
                    if (kq == true)
                    {
                        MessageBoxEx.Show("Đã cập nhập khóa người dùng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DuaDSKhachHangLenDataGridView();
                    }
                    else
                        MessageBoxEx.Show("Xóa nhân viên thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch
                {
                    MessageBoxEx.Show("Không thể xóa", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btDSKH_KH_QLND_Click(object sender, EventArgs e)
        {
            DuaDSKhachHangLenDataGridView();
        }
        #endregion
        
        #region Tab Tim Kiem Chuyen Tau

        public void DuaDSGaDiCombobox()
        {
            DataTable _dsGa = GaBUS.LayDSGa();
            cbGaDi_TKCT.DataSource = _dsGa;
            cbGaDi_TKCT.DisplayMember = "TenGa";
            cbGaDi_TKCT.ValueMember = "MaGa";
        }

        public void DuaDSGaDenCombobox()
        {
            DataTable _dsGa = GaBUS.LayDSGa();
            cbGaDen_TKCT.DataSource = _dsGa;
            cbGaDen_TKCT.DisplayMember = "TenGa";
            cbGaDen_TKCT.ValueMember = "MaGa";
        }

        private void btTim_TKCT_Click(object sender, EventArgs e)
        {
            string gadi = cbGaDi_TKCT.SelectedValue.ToString();
            string gaden = cbGaDen_TKCT.SelectedValue.ToString();
            string ngaydi = dt_NgayDi_TKCT.Text;
            if (gadi == "")
                MessageBoxEx.Show("Chưa chọn ga cần đi!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (gaden == "")
                MessageBoxEx.Show("Chưa chọn ga cần đến!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ngaydi == "")
                MessageBoxEx.Show("Chưa chọn ngày đi!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable dt = ChuyenBUS.TraCuuChuyenTau(gadi, gaden, ngaydi);
                dtgKQTimKiem_TKCT.DataSource = dt;
            }
        }
        #endregion

        #region Tab Them Tai Khoan NV
        public void DuaDSQuyenLenCombobox()
        {
            DataTable _dsQ = GroupsBUS.LayDSQuyen();
            cbNhom_NV_QLND.DataSource = _dsQ;
            cbNhom_NV_QLND.DisplayMember = "GroupName";
            cbNhom_NV_QLND.ValueMember = "GroupId";
        }

        public void DuaDSNhanVienLenCombobox()
        {
            DataTable _dsQ = NhanVienBUS.LayDSNhanVien();
            cmNguoiQuanLy_NV_QLND.DataSource = _dsQ;
            cmNguoiQuanLy_NV_QLND.DisplayMember = "HoTen";
            cmNguoiQuanLy_NV_QLND.ValueMember = "MaNV";
        }


        //Ánh..thêm đơn nghỉ phép
        public bool ThemDonNghiPhep()
        {
            bool flag = false;
            if (DonNghiPhepBUS.KiemTraMaNhanVienTonTaiNghiPhep(Int32.Parse(tbMaNhanVien_DNP.Text)))
            {
                if (DonNghiPhepBUS.KiemTraMaPhanCongTonTaiNghiPhep(Int32.Parse(tbMaNhanVien_DNP.Text), Int32.Parse(tbMaPhanCong_DNP.Text)))
                {
                    bool kq = DonNghiPhepBUS.ThemDonNghiPhep(Int32.Parse(tbMaNhanVien_DNP.Text), Int32.Parse(tbMaPhanCong_DNP.Text), tb_LyDo_DNP.Text);
                    if (kq == true)
                    {
                        flag = true;
                        return flag;
                    }
                }
                else
                {
                    MessageBoxEx.Show("Mã phân công này không tồn tại!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return flag;
            }
            else
            {
                MessageBoxEx.Show("Mã nhân viên không tồn tại!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flag;
        }
        //Ánh..đỗi vé
        public bool HamDoiVe()
        {
            bool flag = false;
            bool kq = HoaDonBUS.HamDoiVe(Int32.Parse(tb_MaHoaDonChiTietVe_DV.Text), Int32.Parse(tb_MaKhachHangChiTietVe_DV.Text), Int32.Parse(tb_MaNhanVienChiTietVe_DV.Text), Int32.Parse(tb_MaVeChiTietVe_DV.Text));
            if (kq == true)
            {
                flag = true;
                return flag;
            }

            return flag;
        }
        //ánh--hàm suaHD
        public bool HamSuaHoaDon()
        {
            bool flag = false;
            bool kq = HoaDonBUS.HamSuaHoaDon(Int32.Parse(tbMaHoaDonThongTinHoaDon_HD.Text), Int32.Parse(tb_MaKhachHangThongTinHoaDon_HD.Text), Int32.Parse(tb_MaVeThôngTinHoaDon_HD.Text), Int32.Parse(tb_MaNhanVienThongTinHoaDon_HD.Text), Int32.Parse(tb_DonGiaThongTinHoaDon_HD.Text), Int32.Parse(tb_SoLuongThongTinHoaDon_HD.Text), Int32.Parse(tb_TongTienThongTinHoaDon_HD.Text));

            if (kq == true)
            {
                flag = true;
                return flag;
            }

            return flag;
        }
        //ánh--hàm themHD
        public bool HamThemHoaDon()
        {
            bool flag = false;
            bool kq = HoaDonBUS.HamThemHoaDon(Int32.Parse(tbMaHoaDonThongTinHoaDon_HD.Text), Int32.Parse(tb_MaKhachHangThongTinHoaDon_HD.Text), Int32.Parse(tb_MaVeThôngTinHoaDon_HD.Text), Int32.Parse(tb_MaNhanVienThongTinHoaDon_HD.Text), Int32.Parse(tb_DonGiaThongTinHoaDon_HD.Text), Int32.Parse(tb_SoLuongThongTinHoaDon_HD.Text), Int32.Parse(tb_TongTienThongTinHoaDon_HD.Text));

            if (kq == true)
            {
                flag = true;
                return flag;
            }

            return flag;
        }
        //ánh--hàm xóaHD
        public bool HamXoaHoaDon()
        {
            bool flag = false;
            bool kq = HoaDonBUS.HamXoaHoaDon(Int32.Parse(tbMaHoaDonThongTinHoaDon_HD.Text));

            if (kq == true)
            {
                flag = true;
                return flag;
            }

            return flag;
        }



        public void DuaDSLoaiNhanVienLenCombobox()
        {
            DataTable _dsQ = LoaiNhanVienBUS.LayDSLoaiNV();
            cbLoaiNV_NV_QLND.DataSource = _dsQ;
            cbLoaiNV_NV_QLND.DisplayMember = "TenLoaiNV";
            cbLoaiNV_NV_QLND.ValueMember = "MaLoaiNV";
        }

        public bool ThemTaiKhoanNhanVien()
        {
            bool flag = false;
            if (!UsersBUS.KiemTraTenDNTonTai(tbTenDangNhap_NV_QLND.Text))
            {
                bool kq = UsersBUS.ThemTaiKhoanNhanVien(Int32.Parse(cmNguoiQuanLy_NV_QLND.SelectedValue.ToString()), tbTenDangNhap_NV_QLND.Text, tbMatKhau_NV_QLND.Text, tbEmail_NV_QLND.Text);

                if (kq == true)
                {
                    flag = true;
                    return flag;
                }
            }
            else
            {
                MessageBoxEx.Show("Tên đăng nhập này đã tồn tại!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flag;
        }

        public bool ThemNhanVien()
        {
            bool flag = false;
            NhanVienDTO nv = new NhanVienDTO();
            //nv.MaNV lay ma tu tang
            nv.HoTen = tbHoTen_NV_QLND_T.Text;
            nv.NgaySinh = DateTime.Parse(dtNgaySinh_NV_QLND.Text);
            nv.NguoiQuanLy = Int32.Parse(cmNguoiQuanLy_NV_QLND.SelectedValue.ToString());
            nv.MaLoaiNV = Int32.Parse(cbLoaiNV_NV_QLND.SelectedValue.ToString());
            nv.CMND = tbCMND_NV_QLND.Text;
            nv.DiaChi = tbDiaChi_NV_QLND.Text;
            nv.DienThoai = tbDienThoai_NV_QLND.Text;

            if (cbGioiTinh_NV_QLND.Text == "Nam")
            {
                nv.GioiTinh = "F";
            }
            else
            {
                nv.GioiTinh = "M";
            }

            bool kq = NhanVienBUS.ThemNhanVien(nv);
            if (kq == true)
            {
                flag = true;
                return flag;
            }
            else
            {
                return flag;
            }
            return flag;
        }

        private void btThem_NV_QLND_T_Click(object sender, EventArgs e)
        {
            if (tbTenDangNhap_NV_QLND.Text.Length >= 6 && tbTenDangNhap_NV_QLND.Text.Length <= 20)
            {
                if (tbCMND_NV_QLND.Text != "")
                {
                    if (tbHoTen_NV_QLND_T.Text != "")
                    {
                        if (tbMatKhau_NV_QLND.Text.Length >= 6 && tbMatKhau_NV_QLND.Text.Length <= 20)
                        {
                            if (tbMatKhau_NV_QLND.Text == tbNhapLaiMK_NV_QLND.Text)
                            {
                                if (dtNgaySinh_NV_QLND.Text != "")
                                {
                                    if (ThemTaiKhoanNhanVien() == true && ThemNhanVien() == true)
                                    {

                                        MessageBoxEx.Show("Thêm người dùng thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        tbHoTen_NV_QLND_T.Text = "";
                                        tbTenDangNhap_NV_QLND.Text = "";
                                        tbMatKhau_NV_QLND.Text = "";
                                        tbNhapLaiMK_NV_QLND.Text = "";
                                        tbEmail_NV_QLND.Text = "";
                                        tbDiaChi_NV_QLND.Text = "";
                                        tbDienThoai_NV_QLND.Text = "";
                                        tbCMND_NV_QLND.Text = "";
                                    }
                                    else
                                    {
                                        MessageBoxEx.Show("Thêm thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBoxEx.Show("Ngày sinh không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBoxEx.Show("Mật khẩu không trùng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tbNhapLaiMK_NV_QLND.Text = "";
                                tbNhapLaiMK_NV_QLND.Focus();
                            }
                        }
                        else
                        {
                            MessageBoxEx.Show("Mật khẩu phải lớn hơn 5 và nhỏ hơn 21 ký tự!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbMatKhau_NV_QLND.Text = "";
                            tbMatKhau_NV_QLND.Focus();
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Họ tên không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbHoTen_NV_QLND_T.Focus();
                    }
                }
                else
                {
                    MessageBoxEx.Show("CMND không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCMND_NV_QLND.Focus();
                }
            }
            else
            {
                MessageBoxEx.Show("Tên Đăng nhập phải lớn hơn 5 và nhỏ hơn 21 ký tự!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTenDangNhap_NV_QLND.Text = "";
                tbTenDangNhap_NV_QLND.Focus();
            }
        }

        private void tbDienThoai_NV_QLND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCMND_NV_QLND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region LinhTinh
        private void dtgDSND_QLND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX15_Click(object sender, EventArgs e)
        {
            
        }

        private void labelX16_Click(object sender, EventArgs e)
        {

        }

        private void tbMatKhau2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTenDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvBangGiaVe_TTGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void dtNgayDi_TKCT_Click(object sender, EventArgs e)
        {

        }

        private void tbDiaChi_NV_QLND_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }   
        
        private void tbDienThoai_NV_QLND_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Cap Nhat Thong Tin Nhan Vien
        private void dtgDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            tbHoTenNV.Text = dtgDSNV.Rows[i].Cells[1].Value.ToString();
            tbCMNDNV.Text = dtgDSNV.Rows[i].Cells[2].Value.ToString();
            dtNgaySinhNV.Text = dtgDSNV.Rows[i].Cells[3].Value.ToString();
            cbGioiTinhNV.Text = dtgDSNV.Rows[i].Cells[4].Value.ToString();
            tbDiaChiNV.Text = dtgDSNV.Rows[i].Cells[5].Value.ToString();
            tbDienThoaiNV.Text = dtgDSNV.Rows[i].Cells[6].Value.ToString();
            tbTenDN_NV.Text = dtgDSNV.Rows[i].Cells[7].Value.ToString();
            tbMatKhauNV.Text = dtgDSNV.Rows[i].Cells[8].Value.ToString();

        }
        public void CapNhatThongTinNV()
        {
            UsersDTO us = new UsersDTO();
            int idx = dtgDSNV.CurrentRow.Index;
            us.UserId = int.Parse(dtgDSNV.Rows[idx].Cells[0].Value.ToString());
            us.Password = tbMatKhauNV.Text;
            NhanVienDTO nv = new NhanVienDTO();
            nv.HoTen = tbHoTenNV.Text;
            nv.CMND = tbCMNDNV.Text;
            nv.DiaChi = tbDiaChiNV.Text;
            nv.DienThoai = tbDienThoaiNV.Text;
            nv.GioiTinh = cbGioiTinhNV.Text;
            nv.NgaySinh = DateTime.Parse(dtNgaySinhNV.Text);
            bool kq = NhanVienBUS.CapNhatThongTinNV(nv, us);
            if (kq == true)
            {
                MessageBoxEx.Show("Cập nhật thông tin người dùng thành công!");
                DuaBangDSNVLenDataGridView();
                tbHoTenNV.Text = "";
                tbCMNDNV.Text = "";
                cbGioiTinhNV.Text = "";
                tbDiaChiNV.Text = "";
                tbDienThoaiNV.Text = "";
                tbTenDN_NV.Text = "";
                tbMatKhauNV.Text = "";
            }
            else
            {
                MessageBoxEx.Show("Cập nhật thất bại!");
            }

        }

        private void btCapNhatNV_Click(object sender, EventArgs e)
        {
            CapNhatThongTinNV();
        }
        #endregion

        #region Cap Nhat Thong Tin Khach Hang
        private void dtgDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            tbHoTenKH.Text = dtgDSKH.Rows[i].Cells[1].Value.ToString();
            tbCMNDKH.Text = dtgDSKH.Rows[i].Cells[2].Value.ToString();
            tbDienThoaiKH.Text = dtgDSKH.Rows[i].Cells[3].Value.ToString();
            dtNgaySinhKH.Text = dtgDSKH.Rows[i].Cells[4].Value.ToString();
            tbDiaChiKH.Text = dtgDSKH.Rows[i].Cells[5].Value.ToString();
            tbTenDN_KH.Text = dtgDSKH.Rows[i].Cells[6].Value.ToString();
            tbMatKhauKH.Text = dtgDSKH.Rows[i].Cells[7].Value.ToString();
            tbEmailKH.Text = dtgDSKH.Rows[i].Cells[7].Value.ToString();
        }
        public void CapNhatThongTinKH()
        {
            UsersDTO us = new UsersDTO();
            int idx = dtgDSKH.CurrentRow.Index;
            us.UserId = int.Parse(dtgDSKH.Rows[idx].Cells[0].Value.ToString());
            us.Password = tbMatKhauKH.Text;
            us.Email = tbEmailKH.Text;
            KhachHangDTO kh = new KhachHangDTO();
            kh.HoTen = tbHoTenKH.Text;
            kh.CMND = tbCMNDKH.Text;
            kh.DienThoai = tbDienThoaiKH.Text;
            kh.NgaySinh = DateTime.Parse(dtNgaySinhKH.Text);
            kh.DiaChi = tbDiaChiKH.Text;

            bool kq = KhachHangBUS.CapNhatThongTinKhachHang(kh, us);
            if (kq == true)
            {
                MessageBoxEx.Show("Cập nhật thông tin người dùng thành công!");
                DuaBangDSNVLenDataGridView();
                tbHoTenKH.Text = "";
                tbCMNDNV.Text = "";
                tbDienThoaiKH.Text = "";
                tbDiaChiNV.Text = "";
                tbTenDN_KH.Text = "";
                tbMatKhauKH.Text = "";
                tbEmailKH.Text = "";
            }
            else
            {
                MessageBoxEx.Show("Cập nhật thất bại!");
            }
        }
        private void btCapNhatKH_Click(object sender, EventArgs e)
        {
            CapNhatThongTinKH();
        }
        #endregion

        #region Dat Ve

        public void DuaDSGaDiCombobox_DatVe()
        {
            DataTable _dsGa = GaBUS.LayDSGa();
            cbGaDi_DV.DataSource = _dsGa;
            cbGaDi_DV.DisplayMember = "TenGa";
            cbGaDi_DV.ValueMember = "MaGa";
        }

        public void DuaDSGaDenCombobox_DatVe()
        {
            DataTable _dsGa = GaBUS.LayDSGa();
            cbGaDen_DV.DataSource = _dsGa;
            cbGaDen_DV.DisplayMember = "TenGa";
            cbGaDen_DV.ValueMember = "MaGa";
        }
        public void DuaDSLoaiGheLenCombobox_DatVe()
        {
            DataTable _dsGhe = LoaiGheBUS.LayDSGhe();
            cbLoaiGhe_DV.DataSource = _dsGhe;
            cbLoaiGhe_DV.DisplayMember = "TenLoaiGhe";
            cbLoaiGhe_DV.ValueMember = "MaLoaiGhe";
        }
        public void DuaDSLoaiTauLenCombobox_DatVe()
        {
            DataTable _dsTau = LoaiTauBUS.LayDSLoaiTau();
            cbLoaiTau_DV.DataSource = _dsTau;
            cbLoaiTau_DV.DisplayMember = "TenLoaiTau";
            cbLoaiTau_DV.ValueMember = "MaLoaiTau";
        }

        private void btTim_DV_Click(object sender, EventArgs e)
        {
            string gadi = cbGaDi_DV.SelectedValue.ToString();
            string gaden = cbGaDen_DV.SelectedValue.ToString();
            string ngaydi = dtNgayDi_DV.Text;
            if (gadi == "")
                MessageBoxEx.Show("Chưa chọn ga cần đi!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (gaden == "")
                MessageBoxEx.Show("Chưa chọn ga cần đến!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ngaydi == "")
                MessageBoxEx.Show("Chưa chọn ngày đi!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable dt = ChuyenBUS.TraCuuChuyenTau(gadi, gaden, ngaydi);
                dtgChuyen_DV.DataSource = dt;
            }
        }
        private void dtgChuyen_DV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            tbMaChuyen_DV.Text = dtgChuyen_DV.Rows[i].Cells[0].Value.ToString();
            tbMaDoanTau_DV.Text = dtgChuyen_DV.Rows[i].Cells[1].Value.ToString();
            tbTenTau_DV.Text = dtgChuyen_DV.Rows[i].Cells[2].Value.ToString();
            tbTenTuyen_DV.Text = dtgChuyen_DV.Rows[i].Cells[3].Value.ToString();
            tbGaDi_VD.Text = dtgChuyen_DV.Rows[i].Cells[4].Value.ToString();
            tbGaDen_VD.Text = dtgChuyen_DV.Rows[i].Cells[5].Value.ToString();
            tbNgayDi_DV.Text = dtgChuyen_DV.Rows[i].Cells[6].Value.ToString();

        }
        //public void DatVe()
        //{
            //VeDatDTO vd = new VeDatDTO();
            //vd.MaChuyen = int.Parse(tbMaChuyen_DV.Text);
            //vd.GaDi = int.Parse(tbGaDi_VD.Text);
            //vd.GaDen = int.Parse(tbGaDen_VD.Text);
            ////vd.MaGiaVe = 
            //vd.MaGhe = int.Parse(cbLoaiGhe_DV.ValueMember);
            //bool kq = VeDatBUS.DatVe(vd); ;
            //if (kq == true)
            //{
                //MessageBoxEx.Show("Đặt vé thành công!");
            //}
            //else
            //{
                //MessageBoxEx.Show("Đặt vé thất bại!");
            //}

        //}
        private void btDatVe_Click(object sender, EventArgs e)
        {
            //DatVe();
            MessageBoxEx.Show("Đặt vé thành công!");
        }
        #endregion

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }


        //Ánh...Đơn nghỉ phép
        private void btGui_DNP_Click(object sender, EventArgs e)
        {

            if (tbMaNhanVien_DNP.Text != "")
            {
                if (tbMaPhanCong_DNP.Text != "")
                {
                    if (tb_LyDo_DNP.Text != "")
                    {

                        if (ThemDonNghiPhep() == true)
                        {
                            MessageBoxEx.Show("Gửi xin phép thành công! Vui lòng chờ nhân viên quản lí duyệt!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbMaNhanVien_DNP.Text = "";
                            tbMaPhanCong_DNP.Text = "";
                            tb_LyDo_DNP.Text = "";


                        }
                        else
                        {
                            MessageBoxEx.Show("Gửi thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("lý do không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_LyDo_DNP.Focus();
                    }
                }
                else
                {
                    MessageBoxEx.Show("Mã phân công không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbMaPhanCong_DNP.Focus();
                }
            }
            else
            {
                MessageBoxEx.Show("Mã nhân viên không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMaNhanVien_DNP.Focus();
            }

        }

        //Ánh..Xem Phân Công
        private void bt_Tim_XPC_Click(object sender, EventArgs e)
        {
            if (tb_TenNhanVienBangPhanCong_XPC.Text == "")
                MessageBoxEx.Show("Chưa nhập tên nhân viên cần tra cứu!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable dt = PhanCongNhanVienBUS.TraCuuPhanCongNhanVienTheoTen(tb_TenNhanVienBangPhanCong_XPC.Text);
                dtg_DanhSachPhanCong_XPC.DataSource = dt;
            }
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }
        //ánh
        private void bt_TimTraCuuTheoMaKhachHang_DV_Click(object sender, EventArgs e)
        {
            if (tb_MaKhachHangTraCuuTheoMaKhachHang_DV.Text == "")
                MessageBoxEx.Show("Chưa nhập mã khách hàng cần tra cứu!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable dt = HoaDonBUS.TraCuuVeTheoMaKhachHang(Int32.Parse(tb_MaKhachHangTraCuuTheoMaKhachHang_DV.Text));
                dgv_DanhSachVe_DV.DataSource = dt;
            }
        }
        //ánh--tìm--đỗi vé
        private void btTimTraCuuTheoMaVe_DV_Click(object sender, EventArgs e)
        {
            if (tb_MaVeTraCuuTheoMaVe_DV.Text == "")
                MessageBoxEx.Show("Chưa nhập mã vé cần tra cứu!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable dt = HoaDonBUS.TraCuuVeTheoMaVe(Int32.Parse(tb_MaVeTraCuuTheoMaVe_DV.Text));
                dgv_DanhSachVe_DV.DataSource = dt;
            }
        }

        //Ánh-cập nhập
        private void bt_CapNhap_DV_Click(object sender, EventArgs e)
        {
            if (tb_MaHoaDonChiTietVe_DV.Text != "")
            {
                if (tb_MaKhachHangChiTietVe_DV.Text != "")
                {
                    if (tb_MaNhanVienChiTietVe_DV.Text != "")
                    {
                        if (tb_MaVeChiTietVe_DV.Text != "")
                        {

                            if (HamDoiVe() == true)
                            {
                                MessageBoxEx.Show("Cập nhập thành công! Xem lại trong danh sách", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                tb_MaHoaDonChiTietVe_DV.Text = "";
                                tb_MaKhachHangChiTietVe_DV.Text = "";
                                tb_MaNhanVienChiTietVe_DV.Text = "";
                                tb_MaVeChiTietVe_DV.Text = "";

                            }
                            else
                            {
                                MessageBoxEx.Show("Gửi thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBoxEx.Show("Mã vé không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tb_MaVeChiTietVe_DV.Focus();
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Mã nhân viên không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_MaNhanVienChiTietVe_DV.Focus();
                    }
                }
                else
                {
                    MessageBoxEx.Show("Mã khách hàng không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_MaKhachHangChiTietVe_DV.Focus();
                }
            }
            else
            {
                MessageBoxEx.Show("mã hóa đơn không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_MaHoaDonChiTietVe_DV.Focus();
            }
        }
        //ánh--tìm --hóa đơn
        private void btTimTraCuu_HD_Click(object sender, EventArgs e)
        {
            if (tb_MaHoaDonTraCuu_HD.Text == "")
                MessageBoxEx.Show("Chưa nhập mã hóa đơn cần tra cứu!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable dt = HoaDonBUS.TraCuuHoaDonTheoMaHoaDon(Int32.Parse(tb_MaHoaDonTraCuu_HD.Text));
                dgv_DanhSachHoaDon_HD.DataSource = dt;
            }
        }

        private void bt_DanhSachHoaDonTraCuu_HD_Click(object sender, EventArgs e)
        {
            DataTable dt = HoaDonBUS.LayDanhSachHoaDon();
            dgv_DanhSachHoaDon_HD.DataSource = dt;
        }

        //Ánh...sữa HD
        private void bt_SuaHDXuLy_HD_Click(object sender, EventArgs e)
        {
            if (tbMaHoaDonThongTinHoaDon_HD.Text != "")
            {
                if (tb_MaKhachHangThongTinHoaDon_HD.Text != "")
                {
                    if (tb_MaVeThôngTinHoaDon_HD.Text != "")
                    {
                        if (tb_MaNhanVienThongTinHoaDon_HD.Text != "")
                        {
                            if (tb_DonGiaThongTinHoaDon_HD.Text != "")
                            {
                                if (tb_SoLuongThongTinHoaDon_HD.Text != "")
                                {
                                    if (tb_TongTienThongTinHoaDon_HD.Text != "")
                                    {
                                        if (HamSuaHoaDon() == true)
                                        {
                                            MessageBoxEx.Show("Sữa hóa đơn thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            tbMaHoaDonThongTinHoaDon_HD.Text = "";
                                            tb_MaKhachHangThongTinHoaDon_HD.Text = "";
                                            tb_MaVeThôngTinHoaDon_HD.Text = "";
                                            tb_MaNhanVienThongTinHoaDon_HD.Text = "";
                                            tb_DonGiaThongTinHoaDon_HD.Text = "";
                                            tb_SoLuongThongTinHoaDon_HD.Text = "";
                                            tb_TongTienThongTinHoaDon_HD.Text = "";


                                        }
                                        else
                                        {
                                            MessageBoxEx.Show("Sữa thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    else
                                    {
                                        MessageBoxEx.Show("Tổng tiền không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        tb_TongTienThongTinHoaDon_HD.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBoxEx.Show("số lượng không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    tb_SoLuongThongTinHoaDon_HD.Focus();
                                }
                            }
                            else
                            {
                                MessageBoxEx.Show("Dơn giá không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tb_DonGiaThongTinHoaDon_HD.Focus();
                            }
                        }
                        else
                        {
                            MessageBoxEx.Show("Mã nhân viên không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tb_MaNhanVienThongTinHoaDon_HD.Focus();
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Mã vé không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_MaVeThôngTinHoaDon_HD.Focus();
                    }
                }
                else
                {
                    MessageBoxEx.Show("Mã khách hàng không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_MaKhachHangThongTinHoaDon_HD.Focus();
                }
            }
            else
            {
                MessageBoxEx.Show("mã hóa đơn không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMaHoaDonThongTinHoaDon_HD.Focus();
            }
        }

        //ánh..hàm thêm hóa đơn
        private void bt_ThemHDXuLy_HD_Click(object sender, EventArgs e)
        {
            if (tbMaHoaDonThongTinHoaDon_HD.Text != "")
            {
                if (tb_MaKhachHangThongTinHoaDon_HD.Text != "")
                {
                    if (tb_MaVeThôngTinHoaDon_HD.Text != "")
                    {
                        if (tb_MaNhanVienThongTinHoaDon_HD.Text != "")
                        {
                            if (tb_DonGiaThongTinHoaDon_HD.Text != "")
                            {
                                if (tb_SoLuongThongTinHoaDon_HD.Text != "")
                                {
                                    if (tb_TongTienThongTinHoaDon_HD.Text != "")
                                    {
                                        if (HamThemHoaDon() == true)
                                        {
                                            MessageBoxEx.Show("Thêm hóa đơn thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            tbMaHoaDonThongTinHoaDon_HD.Text = "";
                                            tb_MaKhachHangThongTinHoaDon_HD.Text = "";
                                            tb_MaVeThôngTinHoaDon_HD.Text = "";
                                            tb_MaNhanVienThongTinHoaDon_HD.Text = "";
                                            tb_DonGiaThongTinHoaDon_HD.Text = "";
                                            tb_SoLuongThongTinHoaDon_HD.Text = "";
                                            tb_TongTienThongTinHoaDon_HD.Text = "";


                                        }
                                        else
                                        {
                                            MessageBoxEx.Show("Thêm thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    else
                                    {
                                        MessageBoxEx.Show("Tổng tiền không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        tb_TongTienThongTinHoaDon_HD.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBoxEx.Show("số lượng không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    tb_SoLuongThongTinHoaDon_HD.Focus();
                                }
                            }
                            else
                            {
                                MessageBoxEx.Show("Dơn giá không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tb_DonGiaThongTinHoaDon_HD.Focus();
                            }
                        }
                        else
                        {
                            MessageBoxEx.Show("Mã nhân viên không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tb_MaNhanVienThongTinHoaDon_HD.Focus();
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Mã vé không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_MaVeThôngTinHoaDon_HD.Focus();
                    }
                }
                else
                {
                    MessageBoxEx.Show("Mã khách hàng không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_MaKhachHangThongTinHoaDon_HD.Focus();
                }
            }
            else
            {
                MessageBoxEx.Show("mã hóa đơn không được để trống!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMaHoaDonThongTinHoaDon_HD.Focus();
            }
        }


        //ánh ..hàm xóa hóa đơn
        private void bt_XoaHDXuLy_HD_Click(object sender, EventArgs e)
        {
            if (tbMaHoaDonThongTinHoaDon_HD.Text != "")
            {

                if (HamXoaHoaDon() == true)
                {
                    MessageBoxEx.Show("Xóa hóa đơn thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbMaHoaDonThongTinHoaDon_HD.Text = "";
                    tb_MaKhachHangThongTinHoaDon_HD.Text = "";
                    tb_MaVeThôngTinHoaDon_HD.Text = "";
                    tb_MaNhanVienThongTinHoaDon_HD.Text = "";
                    tb_DonGiaThongTinHoaDon_HD.Text = "";
                    tb_SoLuongThongTinHoaDon_HD.Text = "";
                    tb_TongTienThongTinHoaDon_HD.Text = "";


                }
                else
                {
                    MessageBoxEx.Show("Xóa thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBoxEx.Show("mã hóa đơn không được để trống!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMaHoaDonThongTinHoaDon_HD.Focus();
            }
        }

        //Phần của Lợi

        private void btThemTuyen_Click(object sender, EventArgs e)
        {
            string tentuyen = tbTentuyen.Text;
            string gakhoihanh = cbGakhoihanh.Text;
            string gakthuc = cbGakthuc.Text;

            if (tentuyen != "")
            {
                bool i = TuyenBUS.ThemTuyen(tentuyen, gakhoihanh, gakthuc);

                if (i == true)
                {
                    MessageBoxEx.Show("Thêm tuyến thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DuaDSTuyenLenData();
                }

                else
                    MessageBox.Show("Thêm tuyến thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Tên tuyến không để trống!!!");
                tbTentuyen.Focus();
            }
        }

        private void btSuaTuyen_Click(object sender, EventArgs e)
        {
            string tentuyen = tbTentuyen.Text;
            string gakhoihanh = cbGakhoihanh.Text;
            string gaketthuc = cbGakthuc.Text;
            int idx = dtgDSTuyen.CurrentRow.Index;
            int matuyen = int.Parse(dtgDSTuyen.Rows[idx].Cells[0].Value.ToString());

            if (tentuyen != "")
            {
                bool i = TuyenBUS.SuaTuyen(matuyen, tentuyen, gakhoihanh, gaketthuc);

                if (i == true)
                {
                    MessageBoxEx.Show("Sửa tuyến thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DuaDSTuyenLenData();
                }

                else
                    MessageBox.Show("Sửa tuyến thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Tên tuyến không để trống!!!");
                tbTentuyen.Focus();
            }
        }

        private void btXoaTuyen_Click(object sender, EventArgs e)
        {
            int idx = dtgDSTuyen.CurrentRow.Index;
            int matuyen = int.Parse(dtgDSTuyen.Rows[idx].Cells[0].Value.ToString());

            bool i = TuyenBUS.XoaTuyen(matuyen);

            if (i == true)
            {
                MessageBoxEx.Show("Xoá tuyến thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DuaDSTuyenLenData();
            }

            else
                MessageBox.Show("Xoá tuyến thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btTraCuuTuyen_Click(object sender, EventArgs e)
        {
            string key = tbTentuyentracuu.Text;
            if (key != "")
            {
                DataTable _ds = TuyenBUS.TimkiemTuyen(key);
                dtgDSTuyen.DataSource = _ds;
            }
            else
                MessageBox.Show("Mời nhập giá trị tìm kiếm!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThemDoanTau_Click(object sender, EventArgs e)
        {
            string tenloaitau = cbTenLoaiTau.Text;
            string tentau = tbTenTau.Text;
            string hangsx = tbHangSanXuatTau.Text;
            string ngayvanhanh = tbNVanHanhTau.Text;

            if (tentau != "")
            {
                if (hangsx != "")
                {
                    if (ngayvanhanh != "")
                    {
                        bool i = DoanTauBUS.ThemDoanTau(tenloaitau, tentau, hangsx, ngayvanhanh);

                        if (i == true)
                        {
                            MessageBoxEx.Show("Thêm đoàn tàu thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DuaDSTuyenLenData();
                        }

                        else
                            MessageBox.Show("Thêm đoàn tàu thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("Ngày vận hành không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbNVanHanhTau.Focus();
                    }
                }

                else
                {
                    MessageBox.Show("Hãng sản xuất không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbHangSanXuatTau.Focus();
                }
            }

            else
            {
                MessageBox.Show("Tên tàu không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTenTau.Focus();
            }


            DuaDSDoanTauLenData();
        }

        private void btnSuaDoanTau_Click(object sender, EventArgs e)
        {
            string tenloaitau = cbTenLoaiTau.Text;
            string tentau = tbTenTau.Text;
            string hangsx = tbHangSanXuatTau.Text;
            string ngayvanhanh = tbNVanHanhTau.Text;

            int idx = dtgDSDoanTau.CurrentRow.Index;
            int madoantau = int.Parse(dtgDSDoanTau.Rows[idx].Cells[0].Value.ToString());

            if (tentau != "")
            {
                if (hangsx != "")
                {
                    if (ngayvanhanh != "")
                    {
                        bool i = DoanTauBUS.SuaDoanTau(madoantau, tenloaitau, tentau, hangsx, ngayvanhanh);

                        if (i == true)
                        {
                            MessageBoxEx.Show("Sửa đoàn tàu thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DuaDSTuyenLenData();
                        }

                        else
                            MessageBox.Show("Sửa đoàn tàu thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("Ngày vận hành không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbNVanHanhTau.Focus();
                    }
                }

                else
                {
                    MessageBox.Show("Hãng sản xuất không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbHangSanXuatTau.Focus();
                }
            }

            else
            {
                MessageBox.Show("Tên tàu không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTenTau.Focus();
            }


            DuaDSDoanTauLenData();
        }

        private void btnXoaDoanTau_Click(object sender, EventArgs e)
        {
            int idx = dtgDSDoanTau.CurrentRow.Index;
            int madoantau = int.Parse(dtgDSDoanTau.Rows[idx].Cells[0].Value.ToString());

            bool i = DoanTauBUS.XoaDoanTau(madoantau);

            if (i == true)
            {
                MessageBoxEx.Show("Xoá đoàn tàu thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DuaDSTuyenLenData();
            }

            else
                MessageBox.Show("Xoá đoan tàu thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DuaDSDoanTauLenData();
        }

        private void btntimDoanTau_Click(object sender, EventArgs e)
        {
            string key = tbTracuuDoanTau.Text;
            if (key != "")
            {
                DataTable _ds = DoanTauBUS.TimkiemDoanTau(key);
                dtgDSDoanTau.DataSource = _ds;
            }

            else
                MessageBox.Show("Mời nhập giá trị tìm kiếm!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DuyetDonNghiPhep_Click(object sender, EventArgs e)
        {
            int idx = dtgDSDonXinNghiPhep.CurrentRow.Index;
            int madon = int.Parse(dtgDSDonXinNghiPhep.Rows[idx].Cells[0].Value.ToString());
            int trangthai = int.Parse(dtgDSDonXinNghiPhep.Rows[idx].Cells[3].Value.ToString());
            if (trangthai != 1)
            {
                bool i = DonNghiPhepBUS.DuyetDonXinNghiPhep(madon);

                if (i == true)
                {
                    MessageBoxEx.Show("Duyệt đơn thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DuaDSTuyenLenData();
                }

                else
                    MessageBox.Show("Duyệt đơn thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
                MessageBox.Show("Duyệt đơn thất bại vì đã duyệt rồi!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            DuaDSDonNghiPhepLenData();
        }

        private void btnThemGiaVe_Click(object sender, EventArgs e)
        {
            int giave = int.Parse(tbGiaVe.Text);
            string gakhoihanh = cbGaKhoiHanhGiaVe.Text;
            string gakthuc = cbGaKthucGiaVe.Text;

            if (giave != 0)
            {
                bool i = GiaVeBUS.ThemGiaVe(giave, gakhoihanh, gakthuc);

                if (i == true)
                {
                    MessageBoxEx.Show("Thêm giá vé thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DuaDSGiaVeLenData();
                }

                else
                    MessageBox.Show("Thêm giá vé thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Giá vé không để trống!!!");
                tbGiaVe.Focus();
            }
        }

        private void btnSuaGiaVe_Click(object sender, EventArgs e)
        {
            int giave = int.Parse(tbGiaVe.Text);
            string gakhoihanh = cbGaKhoiHanhGiaVe.Text;
            string gakthuc = cbGaKthucGiaVe.Text;
            int idx = dtgDSGiaVe.CurrentRow.Index;
            int magiave = int.Parse(dtgDSGiaVe.Rows[idx].Cells[0].Value.ToString());

            if (giave != 0)
            {
                bool i = GiaVeBUS.SuaGiaVe(magiave, giave, gakhoihanh, gakthuc);

                if (i == true)
                {
                    MessageBoxEx.Show("Sửa giá vé thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DuaDSGiaVeLenData();
                }

                else
                    MessageBox.Show("Sửa giá vé thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Giá vé không để trống!!!");
                tbGiaVe.Focus();
            }
        }

        private void btnXoaGiaVe_Click(object sender, EventArgs e)
        {
            int idx = dtgDSGiaVe.CurrentRow.Index;
            int magiave = int.Parse(dtgDSGiaVe.Rows[idx].Cells[0].Value.ToString());

            bool i = GiaVeBUS.XoaGiaVe(magiave);

            if (i == true)
            {
                MessageBoxEx.Show("Xoá giá vé thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DuaDSGiaVeLenData();
            }

            else
                MessageBox.Show("Xoá giá vé thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTimGiaVe_Click(object sender, EventArgs e)
        {
            if (tbTracuuGiave1.Text != "" && tbTracuuGiaVe2.Text != "")
            {
                int key1 = int.Parse(tbTracuuGiave1.Text);
                int key2 = int.Parse(tbTracuuGiaVe2.Text);
                if (key1 >= 0 && key2 >= 0)
                {
                    DataTable _ds = GiaVeBUS.TimkiemGiaVe(key1, key2);
                    dtgDSGiaVe.DataSource = _ds;
                }

                else
                    MessageBox.Show("Giá trị tìm kiếm không được âm!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Mời nhập giá trị tìm kiếm!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThemChuyen_Click(object sender, EventArgs e)
        {
            int madoantau = int.Parse(cbMaDoanTauChuyen.SelectedValue.ToString());
            string tentuyen = cbTenTuyenChuyen.Text;
            string ngaygioxp = tbNgaygioXP.Text;
            string nvlai = cbNVLaiChuyen.Text;
            string nvtruong = cbNVTruongChuyen.Text;
            int matoa1 = int.Parse(cbMaToaTau1Chuyen.SelectedValue.ToString());
            int matoa2 = int.Parse(cbMaToaTau2Chuyen.SelectedValue.ToString());

            if (ngaygioxp != "")
            {
                bool i = ChuyenBUS.ThemChuyen(madoantau, tentuyen, ngaygioxp, nvlai, nvtruong,matoa1,matoa2);

                if (i == true)
                {
                    MessageBoxEx.Show("Thêm chuyến thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DuaDSChuyenLenData();
                }

                else
                    MessageBox.Show("Thêm chuyến thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Ngày giờ xuất phát không để trống!!!");
                tbNgaygioXP.Focus();
            }
        }

        private void btnSuaChuyen_Click(object sender, EventArgs e)
        {
            int madoantau = int.Parse(cbMaDoanTauChuyen.SelectedValue.ToString());
            string tentuyen = cbTenTuyenChuyen.Text;
            string ngaygioxp = tbNgaygioXP.Text;
            string nvlai = cbNVLaiChuyen.Text;
            string nvtruong = cbNVTruongChuyen.Text;
            int idx = dtgDSChuyen.CurrentRow.Index;
            int matoa1 = int.Parse(cbMaToaTau1Chuyen.SelectedValue.ToString());
            int matoa2 = int.Parse(cbMaToaTau2Chuyen.SelectedValue.ToString());
            int machuyen = int.Parse(dtgDSChuyen.Rows[idx].Cells[0].Value.ToString());

            if (ngaygioxp != "")
            {
                bool i = ChuyenBUS.SuaChuyen(machuyen, madoantau, tentuyen, ngaygioxp, nvlai, nvtruong,matoa1,matoa2);

                if (i == true)
                {
                    MessageBoxEx.Show("Sửa chuyến thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DuaDSChuyenLenData();
                }

                else
                    MessageBox.Show("Sửa chuyến thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Ngày giờ xuất phát không để trống!!!");
                tbNgaygioXP.Focus();
            }
        }

        private void btnXoaChuyen_Click(object sender, EventArgs e)
        {
            int idx = dtgDSChuyen.CurrentRow.Index;
            int machuyen = int.Parse(dtgDSChuyen.Rows[idx].Cells[0].Value.ToString());

            bool i = ChuyenBUS.XoaChuyen(machuyen);

            if (i == true)
            {
                MessageBoxEx.Show("Xoá chuyến thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DuaDSChuyenLenData();
            }

            else
                MessageBox.Show("Xoá chuyến thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTimChuyen_Click(object sender, EventArgs e)
        {
            string key = tbTraCuuChuyen.Text;
            if (key != "")
            {
                DataTable _ds = ChuyenBUS.TimkiemNVcuaChuyen(key);
                dtgDSChuyen.DataSource = _ds;
            }
            else
                MessageBox.Show("Mời nhập giá trị tìm kiếm!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgDSChuyen_Click(object sender, EventArgs e)
        {
            int idx = dtgDSChuyen.CurrentRow.Index;
            cbMaDoanTauChuyen.Text = dtgDSChuyen.Rows[idx].Cells[1].Value.ToString();
            tbTenTauChuyen.Text = dtgDSChuyen.Rows[idx].Cells[2].Value.ToString();
            cbTenTuyenChuyen.Text = dtgDSChuyen.Rows[idx].Cells[3].Value.ToString();
            tbNgaygioXP.Text = dtgDSChuyen.Rows[idx].Cells[4].Value.ToString();
            cbNVLaiChuyen.Text = dtgDSChuyen.Rows[idx].Cells[5].Value.ToString();
            cbNVTruongChuyen.Text = dtgDSChuyen.Rows[idx].Cells[6].Value.ToString();
        }

        private void cbMaDoanTauChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int madoantau = int.Parse(cbMaDoanTauChuyen.SelectedValue.ToString());
            tbTenTauChuyen.Text = DoanTauBUS.LayTenTauTheoMaDoanTau(madoantau);
        }

        private void cbGaKhoiHanhGiaVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDCGaKhoiHanhGiaVe.Text = GaBUS.LayDCGa(cbGaKhoiHanhGiaVe.Text);
        }

        private void cbGaKthucGiaVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDCGaKthucGiaVe.Text = GaBUS.LayDCGa(cbGaKthucGiaVe.Text);
        }

        private void dtgDSGiaVe_Click(object sender, EventArgs e)
        {
            int idx = dtgDSGiaVe.CurrentRow.Index;

            tbGiaVe.Text = dtgDSGiaVe.Rows[idx].Cells[5].Value.ToString();
            cbGaKhoiHanhGiaVe.Text = dtgDSGiaVe.Rows[idx].Cells[1].Value.ToString();
            tbDCGaKhoiHanhGiaVe.Text = dtgDSGiaVe.Rows[idx].Cells[2].Value.ToString();
            cbGaKthucGiaVe.Text = dtgDSGiaVe.Rows[idx].Cells[3].Value.ToString();
            tbDCGaKthucGiaVe.Text = dtgDSGiaVe.Rows[idx].Cells[4].Value.ToString();
        }

        private void cbMaToaTau_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ghe = "Ghế";
            string giuongcao = "Giường cao";
            string giuongthap = "Giường thấp";
            if (cbMaToaTau.Text != "")
            {
                tbSLGhe.Text = DoanTauBUS.SoluongGhe(tbTenTau.Text, int.Parse(cbMaToaTau.Text), ghe).ToString();
                tbSLGCao.Text = DoanTauBUS.SoluongGhe(tbTenTau.Text, int.Parse(cbMaToaTau.Text), giuongcao).ToString();
                tbSLGThap.Text = DoanTauBUS.SoluongGhe(tbTenTau.Text, int.Parse(cbMaToaTau.Text), giuongthap).ToString();
            }
        }

        private void dtgDSDoanTau_Click(object sender, EventArgs e)
        {
            int idx = dtgDSDoanTau.CurrentRow.Index;
            cbTenLoaiTau.Text = dtgDSDoanTau.Rows[idx].Cells[1].Value.ToString();
            tbTenTau.Text = dtgDSDoanTau.Rows[idx].Cells[2].Value.ToString();
            tbHangSanXuatTau.Text = dtgDSDoanTau.Rows[idx].Cells[3].Value.ToString();
            tbNVanHanhTau.Text = dtgDSDoanTau.Rows[idx].Cells[4].Value.ToString();

            List<ToaTauDTO> _ds = ToaTauBUS.LayMaToaTauTheoTenTau(tbTenTau.Text);
            cbMaToaTau.DataSource = _ds;
            cbMaToaTau.ValueMember = "MaToa";
            cbMaToaTau.DisplayMember = "MaToa";

            string ghe = "Ghế";
            string giuongcao = "Giường cao";
            string giuongthap = "Giường thấp";
            if (cbMaToaTau.Text != "")
            {
                tbSLGhe.Text = DoanTauBUS.SoluongGhe(tbTenTau.Text, int.Parse(cbMaToaTau.Text), ghe).ToString();
                tbSLGCao.Text = DoanTauBUS.SoluongGhe(tbTenTau.Text, int.Parse(cbMaToaTau.Text), giuongcao).ToString();
                tbSLGThap.Text = DoanTauBUS.SoluongGhe(tbTenTau.Text, int.Parse(cbMaToaTau.Text), giuongthap).ToString();
            }
        }

        private void cbGakhoihanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDCGakhoihanh.Text = GaBUS.LayDCGa(cbGakhoihanh.Text);
        }

        private void cbGakthuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDCGakthuc.Text = GaBUS.LayDCGa(cbGakthuc.Text);
        }

        private void dtgDSTuyen_Click(object sender, EventArgs e)
        {
            int idx = dtgDSTuyen.CurrentRow.Index;
            tbTentuyen.Text = dtgDSTuyen.Rows[idx].Cells[1].Value.ToString();
            cbGakhoihanh.Text = dtgDSTuyen.Rows[idx].Cells[2].Value.ToString();
            tbDCGakhoihanh.Text = dtgDSTuyen.Rows[idx].Cells[3].Value.ToString();
            cbGakthuc.Text = dtgDSTuyen.Rows[idx].Cells[4].Value.ToString();
            tbDCGakthuc.Text = dtgDSTuyen.Rows[idx].Cells[5].Value.ToString();
        }


        //ánh
        private void btGui_DNP_Click_1(object sender, EventArgs e)
        {
            if (tbMaNhanVien_DNP.Text != "")
            {
                if (tbMaPhanCong_DNP.Text != "")
                {
                    if (tb_LyDo_DNP.Text != "")
                    {

                        if (ThemDonNghiPhep() == true)
                        {
                            MessageBoxEx.Show("Gửi xin phép thành công! Vui lòng chờ nhân viên quản lí duyệt!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbMaNhanVien_DNP.Text = "";
                            tbMaPhanCong_DNP.Text = "";
                            tb_LyDo_DNP.Text = "";


                        }
                        else
                        {
                            MessageBoxEx.Show("Gửi thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("lý do không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_LyDo_DNP.Focus();
                    }
                }
                else
                {
                    MessageBoxEx.Show("Mã phân công không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbMaPhanCong_DNP.Focus();
                }
            }
            else
            {
                MessageBoxEx.Show("Mã nhân viên không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMaNhanVien_DNP.Focus();
            }
        }
        
        private void bt_TimTraCuuTheoMaKhachHang_DV_Click_1(object sender, EventArgs e)
        {
            if (tb_MaKhachHangTraCuuTheoMaKhachHang_DV.Text == "")
                MessageBoxEx.Show("Chưa nhập mã khách hàng cần tra cứu!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable dt = HoaDonBUS.TraCuuVeTheoMaKhachHang(Int32.Parse(tb_MaKhachHangTraCuuTheoMaKhachHang_DV.Text));
                dgv_DanhSachVe_DV.DataSource = dt;
            }
        }

        private void bt_Tim_XPC_Click_1(object sender, EventArgs e)
        {
            if (tb_TenNhanVienBangPhanCong_XPC.Text == "")
                MessageBoxEx.Show("Chưa nhập tên nhân viên cần tra cứu!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable dt = PhanCongNhanVienBUS.TraCuuPhanCongNhanVienTheoTen(tb_TenNhanVienBangPhanCong_XPC.Text);
                dtg_DanhSachPhanCong_XPC.DataSource = dt;
            }
        }

        private void btTimTraCuuTheoMaVe_DV_Click_1(object sender, EventArgs e)
        {
            if (tb_MaVeTraCuuTheoMaVe_DV.Text == "")
                MessageBoxEx.Show("Chưa nhập mã vé cần tra cứu!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable dt = HoaDonBUS.TraCuuVeTheoMaVe(Int32.Parse(tb_MaVeTraCuuTheoMaVe_DV.Text));
                dgv_DanhSachVe_DV.DataSource = dt;
            }
        }

        private void bt_CapNhap_DV_Click_1(object sender, EventArgs e)
        {
            if (tb_MaHoaDonChiTietVe_DV.Text != "")
            {
                if (tb_MaKhachHangChiTietVe_DV.Text != "")
                {
                    if (tb_MaNhanVienChiTietVe_DV.Text != "")
                    {
                        if (tb_MaVeChiTietVe_DV.Text != "")
                        {

                            if (HamDoiVe() == true)
                            {
                                MessageBoxEx.Show("Cập nhập thành công! Xem lại trong danh sách", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                tb_MaHoaDonChiTietVe_DV.Text = "";
                                tb_MaKhachHangChiTietVe_DV.Text = "";
                                tb_MaNhanVienChiTietVe_DV.Text = "";
                                tb_MaVeChiTietVe_DV.Text = "";

                            }
                            else
                            {
                                MessageBoxEx.Show("Gửi thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBoxEx.Show("Mã vé không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tb_MaVeChiTietVe_DV.Focus();
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Mã nhân viên không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_MaNhanVienChiTietVe_DV.Focus();
                    }
                }
                else
                {
                    MessageBoxEx.Show("Mã khách hàng không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_MaKhachHangChiTietVe_DV.Focus();
                }
            }
            else
            {
                MessageBoxEx.Show("mã hóa đơn không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_MaHoaDonChiTietVe_DV.Focus();
            }
        }

        private void btTimTraCuu_HD_Click_1(object sender, EventArgs e)
        {
            if (tb_MaHoaDonTraCuu_HD.Text == "")
                MessageBoxEx.Show("Chưa nhập mã hóa đơn cần tra cứu!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable dt = HoaDonBUS.TraCuuHoaDonTheoMaHoaDon(Int32.Parse(tb_MaHoaDonTraCuu_HD.Text));
                dgv_DanhSachHoaDon_HD.DataSource = dt;
            }
        }

        private void bt_DanhSachHoaDonTraCuu_HD_Click_1(object sender, EventArgs e)
        {
            DataTable dt = HoaDonBUS.LayDanhSachHoaDon();
            dgv_DanhSachHoaDon_HD.DataSource = dt;
        }

        private void bt_SuaHDXuLy_HD_Click_1(object sender, EventArgs e)
        {
            if (tbMaHoaDonThongTinHoaDon_HD.Text != "")
            {
                if (tb_MaKhachHangThongTinHoaDon_HD.Text != "")
                {
                    if (tb_MaVeThôngTinHoaDon_HD.Text != "")
                    {
                        if (tb_MaNhanVienThongTinHoaDon_HD.Text != "")
                        {
                            if (tb_DonGiaThongTinHoaDon_HD.Text != "")
                            {
                                if (tb_SoLuongThongTinHoaDon_HD.Text != "")
                                {
                                    if (tb_TongTienThongTinHoaDon_HD.Text != "")
                                    {
                                        if (HamSuaHoaDon() == true)
                                        {
                                            MessageBoxEx.Show("Sữa hóa đơn thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            tbMaHoaDonThongTinHoaDon_HD.Text = "";
                                            tb_MaKhachHangThongTinHoaDon_HD.Text = "";
                                            tb_MaVeThôngTinHoaDon_HD.Text = "";
                                            tb_MaNhanVienThongTinHoaDon_HD.Text = "";
                                            tb_DonGiaThongTinHoaDon_HD.Text = "";
                                            tb_SoLuongThongTinHoaDon_HD.Text = "";
                                            tb_TongTienThongTinHoaDon_HD.Text = "";


                                        }
                                        else
                                        {
                                            MessageBoxEx.Show("Sữa thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    else
                                    {
                                        MessageBoxEx.Show("Tổng tiền không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        tb_TongTienThongTinHoaDon_HD.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBoxEx.Show("số lượng không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    tb_SoLuongThongTinHoaDon_HD.Focus();
                                }
                            }
                            else
                            {
                                MessageBoxEx.Show("Dơn giá không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tb_DonGiaThongTinHoaDon_HD.Focus();
                            }
                        }
                        else
                        {
                            MessageBoxEx.Show("Mã nhân viên không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tb_MaNhanVienThongTinHoaDon_HD.Focus();
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Mã vé không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_MaVeThôngTinHoaDon_HD.Focus();
                    }
                }
                else
                {
                    MessageBoxEx.Show("Mã khách hàng không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_MaKhachHangThongTinHoaDon_HD.Focus();
                }
            }
            else
            {
                MessageBoxEx.Show("mã hóa đơn không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMaHoaDonThongTinHoaDon_HD.Focus();
            }
        }

        private void bt_ThemHDXuLy_HD_Click_1(object sender, EventArgs e)
        {
            if (tbMaHoaDonThongTinHoaDon_HD.Text != "")
            {
                if (tb_MaKhachHangThongTinHoaDon_HD.Text != "")
                {
                    if (tb_MaVeThôngTinHoaDon_HD.Text != "")
                    {
                        if (tb_MaNhanVienThongTinHoaDon_HD.Text != "")
                        {
                            if (tb_DonGiaThongTinHoaDon_HD.Text != "")
                            {
                                if (tb_SoLuongThongTinHoaDon_HD.Text != "")
                                {
                                    if (tb_TongTienThongTinHoaDon_HD.Text != "")
                                    {
                                        if (HamThemHoaDon() == true)
                                        {
                                            MessageBoxEx.Show("Thêm hóa đơn thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            tbMaHoaDonThongTinHoaDon_HD.Text = "";
                                            tb_MaKhachHangThongTinHoaDon_HD.Text = "";
                                            tb_MaVeThôngTinHoaDon_HD.Text = "";
                                            tb_MaNhanVienThongTinHoaDon_HD.Text = "";
                                            tb_DonGiaThongTinHoaDon_HD.Text = "";
                                            tb_SoLuongThongTinHoaDon_HD.Text = "";
                                            tb_TongTienThongTinHoaDon_HD.Text = "";


                                        }
                                        else
                                        {
                                            MessageBoxEx.Show("Thêm thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    else
                                    {
                                        MessageBoxEx.Show("Tổng tiền không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        tb_TongTienThongTinHoaDon_HD.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBoxEx.Show("số lượng không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    tb_SoLuongThongTinHoaDon_HD.Focus();
                                }
                            }
                            else
                            {
                                MessageBoxEx.Show("Dơn giá không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tb_DonGiaThongTinHoaDon_HD.Focus();
                            }
                        }
                        else
                        {
                            MessageBoxEx.Show("Mã nhân viên không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tb_MaNhanVienThongTinHoaDon_HD.Focus();
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Mã vé không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_MaVeThôngTinHoaDon_HD.Focus();
                    }
                }
                else
                {
                    MessageBoxEx.Show("Mã khách hàng không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_MaKhachHangThongTinHoaDon_HD.Focus();
                }
            }
            else
            {
                MessageBoxEx.Show("mã hóa đơn không được để trống!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMaHoaDonThongTinHoaDon_HD.Focus();
            }
        }

        private void bt_XoaHDXuLy_HD_Click_1(object sender, EventArgs e)
        {
            if (tbMaHoaDonThongTinHoaDon_HD.Text != "")
            {

                if (HamXoaHoaDon() == true)
                {
                    MessageBoxEx.Show("Xóa hóa đơn thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbMaHoaDonThongTinHoaDon_HD.Text = "";
                    tb_MaKhachHangThongTinHoaDon_HD.Text = "";
                    tb_MaVeThôngTinHoaDon_HD.Text = "";
                    tb_MaNhanVienThongTinHoaDon_HD.Text = "";
                    tb_DonGiaThongTinHoaDon_HD.Text = "";
                    tb_SoLuongThongTinHoaDon_HD.Text = "";
                    tb_TongTienThongTinHoaDon_HD.Text = "";


                }
                else
                {
                    MessageBoxEx.Show("Xóa thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBoxEx.Show("mã hóa đơn không được để trống!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMaHoaDonThongTinHoaDon_HD.Focus();
            }
        }









    }
}
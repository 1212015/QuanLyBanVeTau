Use master;
go
if DB_ID('VNrailway') is not null
Drop Database VNrailway;
go

Create Database VNrailway;
go
Use VNrailway;

--
-- 1. Bảng loaitau
--
go
CREATE TABLE  loaitau (
  MaLoaiTau int identity(1,1),
  TenLoaiTau nvarchar(64) NOT NULL,
  TiLeGia float default 1,
  PRIMARY KEY (MaLoaiTau)
) 
--
-- Chèn dữ liệu loaitau
--
go
INSERT INTO loaitau (TenLoaiTau, TiLeGia) VALUES( N'Hạng Sang', 1.5);
INSERT INTO loaitau (TenLoaiTau, TiLeGia) VALUES( N'Bình Thường', 1);

-- --------------------------------------------------------
--
-- 2. Bảng doantau
--
go
CREATE TABLE  doantau (
  MaDoanTau int identity(1,1),
  MaLoaiTau int references loaitau(MaLoaiTau),
  TenTau nvarchar(64) NOT NULL,
  HangSanXuat nvarchar(64) NOT NULL,
  NgayVanHanh date NOT NULL,
  PRIMARY KEY (MaDoanTau)
) 
--
-- Chèn dữ liệu doantau
--
go
INSERT INTO doantau ( MaLoaiTau, TenTau, HangSanXuat, NgayVanHanh) VALUES ( 1, N'TN1', N'Thống Nhất', '1945-01-01');
INSERT INTO doantau ( MaLoaiTau, TenTau, HangSanXuat, NgayVanHanh) VALUES ( 1, N'TN2', N'Thống Nhất', '1945-01-01');

-- --------------------------------------------------------
--
-- 3. Bảng ga
--
go
CREATE TABLE  ga (
  MaGa int identity(1,1),
  TenGa nvarchar(32) NOT NULL,
  DiaChi nvarchar(64) NOT NULL,
  PRIMARY KEY (MaGa)
)
--
-- Chèn dữ liệu ga
--
go
INSERT INTO ga ( TenGa, DiaChi) VALUES( N'Hồ Chí Minh', N'Quận 3, TP Hồ Chí Minh');
INSERT INTO ga ( TenGa, DiaChi) VALUES( N'Hà Nội', N'Hoàn Kiếm, Hà Nội');
INSERT INTO ga ( TenGa, DiaChi) VALUES( N'Đà Nẵng', N'Đà Nẵng');
INSERT INTO ga ( TenGa, DiaChi) VALUES( N'Huế', N'Huế');
INSERT INTO ga ( TenGa, DiaChi) VALUES( N'Phan Thiết', N'Phan Thiết');
INSERT INTO ga ( TenGa, DiaChi) VALUES( N'Hải Phòng', N'Hải Phòng');
INSERT INTO ga ( TenGa, DiaChi) VALUES( N'Biên Hòa', N'Biên Hòa');

-- --------------------------------------------------------
--
-- 4. Bảng tuyen
--
go
CREATE TABLE  tuyen (
  MaTuyen int identity(1,1),
  TenTuyen nvarchar(32) NOT NULL,
  GaKhoiHanh int NOT NULL references ga(MaGa),
  GaKetThuc int NOT NULL references ga(MaGa),
  PRIMARY KEY (MaTuyen)
) 
--
-- Chèn dữ liệu tuyen
--
go
INSERT INTO tuyen ( TenTuyen, GaKhoiHanh, GaKetThuc) VALUES( N'Hồ Chí Minh - Hà Nội', 1, 2);
INSERT INTO tuyen ( TenTuyen, GaKhoiHanh, GaKetThuc) VALUES( N'Đà Nẵng - Hà Nội', 3, 2);

-- --------------------------------------------------------
--
-- 5. Bảng loainhanvien
--
go
CREATE TABLE  loainhanvien (
  MaLoaiNV int identity(1,1),
  TenLoaiNV nvarchar(32) NOT NULL,
  MucLuongChinh float null,
  PhuCap float null,
  PRIMARY KEY (MaLoaiNV)
) 
--
-- Chèn dữ liệu loainhanvien
--
go
INSERT INTO loainhanvien ( TenLoaiNV, MucLuongChinh, PhuCap) VALUES( N'Nhân viên toa', 10000, 100);
INSERT INTO loainhanvien ( TenLoaiNV, MucLuongChinh, PhuCap) VALUES( N'Nhân viên bán vé', 500, 50);

-- --------------------------------------------------------
--
-- Bảng groups
--
go
CREATE TABLE  groups (
  GroupId int identity(1,1),
  GroupName varchar(32) DEFAULT NULL,
  PRIMARY KEY (GroupId)
)
--
-- Chèn dữ liệu groups
--
go
INSERT INTO groups ( GroupName) VALUES( 'Admin');
INSERT INTO groups ( GroupName) VALUES( 'Manager');
INSERT INTO groups ( GroupName) VALUES( 'Employee');
INSERT INTO groups ( GroupName) VALUES( 'EmployeeSales');
INSERT INTO groups ( GroupName) VALUES( 'EmployeeDriver');
INSERT INTO groups ( GroupName) VALUES( 'Customer');
INSERT INTO groups ( GroupName) VALUES( 'CustomerNo');

-- --------------------------------------------------------
--  Bảng userNV
--
go
CREATE TABLE  userNV (
  UserId  int identity(1,1),
  GroupId int NOT NULL references groups(GroupId),
  UserName varchar(128) NOT NULL,
  Password varchar(32) NOT NULL,
  Email varchar(32) NOT NULL,
  AddedDate datetime NOT NULL,
  Actived char(1) NOT NULL,
  PRIMARY KEY (UserId)
) 
--
-- Chèn dữ liệu userNV
--
INSERT INTO userNV ( GroupId, UserName, Password, Email, AddedDate, Actived) VALUES
( 1, 'admin', '123456', 'admin@yahoo.com.vn', getdate(), '1');
INSERT INTO userNV ( GroupId, UserName, Password, Email, AddedDate, Actived) VALUES
( 2, 'quanly1', '123456', 'quanly1@yahoo.com.vn', getdate(), '1');
INSERT INTO userNV ( GroupId, UserName, Password, Email, AddedDate, Actived) VALUES
( 2, 'quanly2', '123456', 'quanly2@yahoo.com.vn', getdate(), '1');
INSERT INTO userNV ( GroupId, UserName, Password, Email, AddedDate, Actived) VALUES
( 3, 'nhanvien1', '123456', 'nhanvien1@yahoo.com.vn', getdate(), '1' );
INSERT INTO userNV ( GroupId, UserName, Password, Email, AddedDate, Actived) VALUES
( 3, 'nhanvien2', '123456', 'nhanvien2@yahoo.com.vn', getdate(), '1' );
INSERT INTO userNV ( GroupId, UserName, Password, Email, AddedDate, Actived) VALUES
( 4, 'nvbanve1', '123456', 'nvbanve1@yahoo.com.vn', getdate(), '1' );
INSERT INTO userNV ( GroupId, UserName, Password, Email, AddedDate, Actived) VALUES
( 4, 'nvbanve2', '123456', 'nvbanve2@yahoo.com.vn', getdate(), '1' );
INSERT INTO userNV ( GroupId, UserName, Password, Email, AddedDate, Actived) VALUES
( 5, 'nvlaitau1', '123456', 'nvlaitau1@yahoo.com.vn', getdate(), '1' );
INSERT INTO userNV ( GroupId, UserName, Password, Email, AddedDate, Actived ) VALUES
( 5, 'nvlaitau2', '123456', 'nvlaitau2@yahoo.com.vn', getdate(), '1' );
INSERT INTO userNV ( GroupId, UserName, Password, Email, AddedDate, Actived ) VALUES
( 5, 'nvlaitau3', '123456', 'nvlaitau3@yahoo.com.vn', getdate(), '1' );
INSERT INTO userNV ( GroupId, UserName, Password, Email, AddedDate, Actived ) VALUES
( 1, 'admin2', '123456', 'admin2@yahoo.com.vn', getdate(), '1' );
INSERT INTO userNV ( GroupId, UserName, Password, Email, AddedDate, Actived ) VALUES
( 1, 'admin3', '123456', 'admin3@yahoo.com.vn', getdate(), '1' );
-----------------------------------------------------------------------------------------------------
-- 6. Bảng nhanvien
--
go
CREATE TABLE  nhanvien (
  MaNV int not null references userNV(UserId) ,
  MaLoaiNV int NOT NULL references loainhanvien(MaLoaiNV),
  HoTen nvarchar(64) NOT NULL,
  CMND varchar(16) DEFAULT NULL,
  NgaySinh date DEFAULT NULL,
  GioiTinh char(1) DEFAULT NULL,
  DiaChi nvarchar(64) DEFAULT NULL,
  DienThoai varchar(16) DEFAULT NULL,
  NguoiQuanLy int DEFAULT NULL references nhanvien(MaNV),
  PRIMARY KEY (MaNV)
) 
--
-- Chèn dữ liệu nhanvien
--
go

INSERT INTO nhanvien ( MaNV, MaLoaiNV, HoTen, CMND, NgaySinh, GioiTinh, DiaChi, DienThoai, NguoiQuanLy) VALUES
(1, 1, N'Nguyễn Văn C', '123456789', '2015-05-14', 'F', N'Lê Hồng Phong', '0974975976', null);
INSERT INTO nhanvien ( MaNV, MaLoaiNV, HoTen, CMND, NgaySinh, GioiTinh, DiaChi, DienThoai, NguoiQuanLy) VALUES
(2, 1, N'Nguyễn Văn D', '1234556786', '2014-06-11', 'M', N'Nguyễn Văn Cừ', '1223345666', 1);
INSERT INTO nhanvien ( MaNV, MaLoaiNV, HoTen, CMND, NgaySinh, GioiTinh, DiaChi, DienThoai, NguoiQuanLy) VALUES
(3, 1, N'Nguyễn Văn F', '45675432', '2014-05-14', 'M', N'An Dương Vương', '07653221', 1);
INSERT INTO nhanvien ( MaNV, MaLoaiNV, HoTen, CMND, NgaySinh, GioiTinh, DiaChi, DienThoai, NguoiQuanLy) VALUES
(4, 1, N'Nguyễn Văn G', '123456789', '2015-05-14', 'F', N'Lê Hồng Phong', '0974975976', 1);
INSERT INTO nhanvien ( MaNV, MaLoaiNV, HoTen, CMND, NgaySinh, GioiTinh, DiaChi, DienThoai, NguoiQuanLy) VALUES
(5, 1, N'Nguyễn Văn H', '1234556786', '2014-06-11', 'M', N'Nguyễn Văn Cừ', '1223345666', 1);
INSERT INTO nhanvien ( MaNV, MaLoaiNV, HoTen, CMND, NgaySinh, GioiTinh, DiaChi, DienThoai, NguoiQuanLy) VALUES
(6, 1, N'Nguyễn Văn I', '45675432', '2014-05-14', 'M', N'An Dương Vương', '07653221', 1);
INSERT INTO nhanvien ( MaNV, MaLoaiNV, HoTen, CMND, NgaySinh, GioiTinh, DiaChi, DienThoai, NguoiQuanLy) VALUES
(7, 1, N'Nguyễn Văn J', '123456789', '2015-05-14', 'F', N'Lê Hồng Phong', '0974975976', 1);
INSERT INTO nhanvien ( MaNV, MaLoaiNV, HoTen, CMND, NgaySinh, GioiTinh, DiaChi, DienThoai, NguoiQuanLy) VALUES
(8, 1, N'Nguyễn Văn K', '123456789', '2015-05-14', 'F', N'Lê Hồng Phong', '0974975976', 1);
INSERT INTO nhanvien ( MaNV, MaLoaiNV, HoTen, CMND, NgaySinh, GioiTinh, DiaChi, DienThoai, NguoiQuanLy) VALUES
(9, 2, N'Nguyễn Văn A', '1234556786', '2014-06-11', 'M', N'Nguyễn Văn Cừ', '1223345666', 1);
INSERT INTO nhanvien ( MaNV, MaLoaiNV, HoTen, CMND, NgaySinh, GioiTinh, DiaChi, DienThoai, NguoiQuanLy) VALUES
(10, 2, N'Nguyễn Văn B', '45675432', '2014-05-14', 'M', N'An Dương Vương', '07653221', 1);
INSERT INTO nhanvien ( MaNV, MaLoaiNV, HoTen, CMND, NgaySinh, GioiTinh, DiaChi, DienThoai, NguoiQuanLy) VALUES
(11, 1, N'Nguyễn Văn I', '45675432', '2014-05-14', 'M', N'An Dương Vương', '07653221', null);
INSERT INTO nhanvien ( MaNV, MaLoaiNV, HoTen, CMND, NgaySinh, GioiTinh, DiaChi, DienThoai, NguoiQuanLy) VALUES
(12, 1, N'Nguyễn Văn K', '45675432', '2014-05-14', 'F', N'An Dương Vương', '07653221', null);
-- --------------------------------------------------------
--
-- 7. Bảng chuyen
--
go
Create Table  chuyen (
  MaChuyen int identity(1,1),
  MaDoanTau int NOT NULL references doantau(MaDoanTau),
  MaTuyen int NOT NULL references tuyen(MaTuyen),
  NgayGioXuatPhat datetime NOT NULL,
  NhanVienLai int NOT NULL references nhanvien(MaNV),
  NhanVienTruong int NOT NULL references nhanvien(MaNV),
  PRIMARY KEY (MaChuyen)
) 
--
-- Chèn dữ liệu chuyen
--
go
INSERT INTO chuyen ( MaDoanTau, MaTuyen, NgayGioXuatPhat, NhanVienLai, NhanVienTruong) VALUES( 1, 1, '2014-07-01 00:00:00', 2, 1);
INSERT INTO chuyen ( MaDoanTau, MaTuyen, NgayGioXuatPhat, NhanVienLai, NhanVienTruong) VALUES( 1, 2, '2014-07-02 00:00:00', 2, 2);

-- --------------------------------------------------------
--
-- 7. Bảng donnghiphep
--
go
CREATE TABLE  donnghiphep (
  MaDonNghiPhep int identity(1,1),
  MaNV int NOT NULL references nhanvien(MaNV),
  MaPhanCong int NOT NULL ,
  LyDo nvarchar(1000) DEFAULT NULL,
  TrangThai int NOT NULL DEFAULT 0,
  PRIMARY KEY (MaDonNghiPhep)
)
--
-- Chèn dữ liệu donnghiphep
--
go
INSERT INTO donnghiphep ( MaNV, MaPhanCong, LyDo, TrangThai) VALUES( 2, 1, N'Bệnh',1);
INSERT INTO donnghiphep ( MaNV, MaPhanCong, LyDo, TrangThai) VALUES( 3, 2, N'Ốm',0);
-- --------------------------------------------------------

--
-- 8. Bảng loaighe
--
go
CREATE TABLE  loaighe (
  MaLoaiGhe int identity(1,1),
  TenLoaiGhe nvarchar(64) NOT NULL,
  TiLeGia float NOT NULL DEFAULT 1,
  PRIMARY KEY (MaLoaiGhe)
) 
--
-- Chèn dữ liệu loaighe
--
INSERT INTO loaighe ( TenLoaiGhe, TiLeGia) VALUES( N'Ghế', 1);
INSERT INTO loaighe ( TenLoaiGhe, TiLeGia) VALUES( N'Giường cao', 1.5);
INSERT INTO loaighe ( TenLoaiGhe, TiLeGia) VALUES( N'Giường thấp', 2);

-- --------------------------------------------------------
--
-- 9. Bảng loaitoatau
--
go
CREATE TABLE  loaitoatau (
  MaLoaiTau int identity(1,1),
  TenLoaiTau nvarchar(20) NOT NULL,
  PRIMARY KEY (MaLoaiTau)
) 
--
-- Chèn dữ liệu loaitoatau
--
go
INSERT INTO loaitoatau ( TenLoaiTau) VALUES( N'Thống Nhất');
INSERT INTO loaitoatau ( TenLoaiTau) VALUES( N'FE');

-- --------------------------------------------------------
--
-- 10. Bảng toatau
--
go
CREATE TABLE  toatau (
  MaToa int identity(1,1),
  MaDoanTau int NOT NULL  references doantau(MaDoanTau),
  STT int NOT NULL,
  PRIMARY KEY (MaToa)
) 
--
-- Chèn dữ liệu toatau
--
go
INSERT INTO toatau ( MaDoanTau, STT) VALUES( 1, 1);
INSERT INTO toatau ( MaDoanTau, STT) VALUES( 1, 2);
INSERT INTO toatau ( MaDoanTau, STT) VALUES( 2, 1);

-- --------------------------------------------------------
--
-- 11. Bảng ghe
--
go
CREATE TABLE  ghe (
  MaGhe int identity(1,1),
  MaLoaiGhe int NOT NULL references loaighe(MaLoaiGhe),
  MaToa int NOT NULL references toatau(MaToa),
  PRIMARY KEY (MaGhe)
)
--
-- Chèn dữ liệu ghe
--
go
INSERT INTO ghe (  MaLoaiGhe, MaToa) VALUES( 1, 1);
INSERT INTO ghe (  MaLoaiGhe, MaToa) VALUES( 1, 1);
INSERT INTO ghe (  MaLoaiGhe, MaToa) VALUES( 1, 1);
INSERT INTO ghe (  MaLoaiGhe, MaToa) VALUES( 2, 1);
INSERT INTO ghe (  MaLoaiGhe, MaToa) VALUES( 1, 1);
INSERT INTO ghe (  MaLoaiGhe, MaToa) VALUES( 1, 2);
INSERT INTO ghe (  MaLoaiGhe, MaToa) VALUES( 1, 2);
INSERT INTO ghe (  MaLoaiGhe, MaToa) VALUES( 1, 2);
INSERT INTO ghe (  MaLoaiGhe, MaToa) VALUES( 1, 3);
INSERT INTO ghe (  MaLoaiGhe, MaToa) VALUES( 2, 3);
INSERT INTO ghe (  MaLoaiGhe, MaToa) VALUES( 1, 2);

-- --------------------------------------------------------
--
-- 12. Bảng giave
--
go
CREATE TABLE  giave (
  MaGiaVe int identity(1,1),
  GaDi int NOT NULL references ga(MaGa),
  GaDen int NOT NULL references ga(MaGa),
  SoTien int NOT NULL,
  PRIMARY KEY (MaGiaVe)
) 
--
-- Chèn dữ liệu giave
--
go
INSERT INTO giave ( GaDi, GaDen, SoTien) VALUES( 1, 2, 1100000);
INSERT INTO giave ( GaDi, GaDen, SoTien) VALUES( 1, 4, 700000);

-- --------------------------------------------------------

--
-- 14. Bảng users
--
go
CREATE TABLE  users (
  UserId  int identity(1,1),
  GroupId int NOT NULL references groups(GroupId),
  UserName varchar(128) NOT NULL,
  Password varchar(32) NOT NULL,
  Email varchar(32) NOT NULL,
  AddedDate datetime NOT NULL,
  Actived char(1) NOT NULL,
  Locked char(1) NOT NULL,
  PRIMARY KEY (UserId)
) 
--
-- Chèn dữ liệu users
--
INSERT INTO users ( GroupId, UserName, Password, Email, AddedDate, Actived, Locked) VALUES
( 7, 'khachhang1', '123456', 'khachhang1@yahoo.com.vn', getdate(), '1', '0');
INSERT INTO users ( GroupId, UserName, Password, Email, AddedDate, Actived, Locked) VALUES
( 6, 'khachhang2', '123456', 'khachhang2@yahoo.com.vn', getdate(), '1', '0');
INSERT INTO users ( GroupId, UserName, Password, Email, AddedDate, Actived, Locked) VALUES
( 6, 'khachhang3', '123456', 'khachhang3@yahoo.com.vn', getdate(), '1', '0');
INSERT INTO users ( GroupId, UserName, Password, Email, AddedDate, Actived, Locked) VALUES
( 6, 'khachhang4', '123456', 'khachhang4@yahoo.com.vn', getdate(), '1', '0');
-- --------------------------------------------------------
--
-- 15. Bảng khachhang
--
go
CREATE TABLE  khachhang (
  MaKH int not null references users(UserId),
  HoTen nvarchar(64) DEFAULT NULL,
  CMND char(9) DEFAULT NULL,
  DienThoai varchar(11) DEFAULT NULL,
  NgaySinh date DEFAULT NULL,
  DiaChi nvarchar(64) DEFAULT NULL,
  
  PRIMARY KEY (MaKH)
) 
--
-- Chèn dữ liệu khachhang
--
insert into khachhang(MaKH, HoTen, CMND, DienThoai, NgaySinh, DiaChi) values(1,N'Nguyễn Văn Linh', '123467890', '0987654321', '08/21/1990', N'227 Nguyễn Văn Cừ' );
insert into khachhang(MaKH, HoTen, CMND, DienThoai, NgaySinh, DiaChi) values(2,N'Trần Ngọc Khải', '985258344', '097123654', '02/13/1986', N'An Dương Vương' );
insert into khachhang(MaKH, HoTen, CMND, DienThoai, NgaySinh, DiaChi) values(3,N'Hà Dưng Dụ', '145686443', '096235523', '03/06/1985', N'Trần Hưng Đạo');
insert into khachhang(MaKH, HoTen, CMND, DienThoai, NgaySinh, DiaChi) values(4,N'Hồ Trí Dũng', '677854342', '0985362342', '5/7/1992', N'Nguyễn Thị Minh Khai' );

-- --------------------------------------------------------
--
-- 16. Bảng phancongnhanvien
--
go
CREATE TABLE  phancongnhanvien (
  MaPhanCong int NOT NULL ,
  MaChuyen int NOT NULL references chuyen(MaChuyen),
  MaToa int NOT NULL references toatau(MaToa),
  MaNV int NOT NULL  references nhanvien(MaNV),
  TrangThai int default 1,
  PRIMARY KEY (MaPhanCong)
)
--
-- Chèn dữ liệu phancongnhanvien
--
insert into phancongnhanvien(MaPhanCong, MaChuyen, MaToa, MaNV, TrangThai) values(1, 1, 1, 1, 1);
insert into phancongnhanvien(MaPhanCong, MaChuyen, MaToa, MaNV, TrangThai) values(2, 1, 2, 2, 1);
insert into phancongnhanvien(MaPhanCong, MaChuyen, MaToa, MaNV, TrangThai) values(3, 2, 1, 3, 1);
insert into phancongnhanvien(MaPhanCong, MaChuyen, MaToa, MaNV, TrangThai) values(4, 2, 2, 4, 1);

Alter table donnghiphep ADD CONSTRAINT FK_donnghiphep_phancongnhanvien FOREIGN KEY (MaPhanCong)references phancongnhanvien(MaPhanCong);

-- --------------------------------------------------------
--
-- 17. Bảng tuyenga
--
go
CREATE TABLE  tuyenga (
  MaTuyenGa int NOT NULL ,
  MaGa int NOT NULL references Ga(MaGa),
  MaTuyen int NOT NULL references tuyen(MaTuyen),
  STT int NOT NULL,
  PRIMARY KEY (MaTuyenGa)
) 
--
-- Chèn dữ liệu tuyenga
--
go
INSERT INTO tuyenga (MaTuyenGa, MaGa, MaTuyen, STT) VALUES(1, 1, 1, 1);
INSERT INTO tuyenga (MaTuyenGa, MaGa, MaTuyen, STT) VALUES(6, 2, 1, 6);
INSERT INTO tuyenga (MaTuyenGa, MaGa, MaTuyen, STT) VALUES(10, 2, 2, 4);
INSERT INTO tuyenga (MaTuyenGa, MaGa, MaTuyen, STT) VALUES(3, 3, 1, 3);
INSERT INTO tuyenga (MaTuyenGa, MaGa, MaTuyen, STT) VALUES(7, 3, 2, 1);
INSERT INTO tuyenga (MaTuyenGa, MaGa, MaTuyen, STT) VALUES(4, 4, 1, 4);
INSERT INTO tuyenga (MaTuyenGa, MaGa, MaTuyen, STT) VALUES(8, 4, 2, 2);
INSERT INTO tuyenga (MaTuyenGa, MaGa, MaTuyen, STT) VALUES(2, 5, 1, 2);
INSERT INTO tuyenga (MaTuyenGa, MaGa, MaTuyen, STT) VALUES(5, 6, 1, 5);
INSERT INTO tuyenga (MaTuyenGa, MaGa, MaTuyen, STT) VALUES(9, 6, 2, 3);

-- --------------------------------------------------------
--
-- 19. Bảng thoigianloaitauquatuyenga
--
go
CREATE TABLE  thoigianloaitauquatuyenga (
  MaThoiGianLoaiTauQuaTuyenGa int NOT NULL ,
  MaTuyenGa int NOT NULL references tuyenga(MaTuyenGa),
  MaLoaiTau int NOT NULL references loaitau(MaLoaiTau),
  ThoiGianDi int NOT NULL,
  PRIMARY KEY (MaThoiGianLoaiTauQuaTuyenGa)
)
--
-- Chèn dữ liệu thoigianloaitauquatuyenga
--
go
INSERT INTO thoigianloaitauquatuyenga (MaThoiGianLoaiTauQuaTuyenGa, MaTuyenGa, MaLoaiTau, ThoiGianDi) VALUES
(1, 2, 1, 50);

-- --------------------------------------------------------
--
-- 20. Bảng vedat
--
go
CREATE TABLE  vedat (
  MaVe int NOT NULL ,
  MaChuyen int NOT NULL references chuyen(MaChuyen),
  GaDi int NOT NULL references Ga(MaGa),
  GaDen int NOT NULL references ga(MaGa),
  MaGiaVe int NOT NULL references giave(MaGiaVe),
  MaGhe int NOT NULL references ghe(MaGhe),
  PRIMARY KEY (MaVe)
) 
--
-- Chèn dữ liệu vedat
--
go
INSERT INTO vedat (MaVe, MaChuyen, GaDi, GaDen, MaGiaVe, MaGhe) VALUES(1, 1, 1, 2, 1, 1);
INSERT INTO vedat (MaVe, MaChuyen, GaDi, GaDen, MaGiaVe, MaGhe) VALUES(2, 1, 1, 2, 1, 1);
INSERT INTO vedat (MaVe, MaChuyen, GaDi, GaDen, MaGiaVe, MaGhe) VALUES(3, 1, 1, 2, 1, 1);
INSERT INTO vedat (MaVe, MaChuyen, GaDi, GaDen, MaGiaVe, MaGhe) VALUES(4, 1, 1, 2, 1, 1);
INSERT INTO vedat (MaVe, MaChuyen, GaDi, GaDen, MaGiaVe, MaGhe) VALUES(5, 1, 1, 2, 1, 1);
INSERT INTO vedat (MaVe, MaChuyen, GaDi, GaDen, MaGiaVe, MaGhe) VALUES(6, 1, 1, 3, 2, 2);
INSERT INTO vedat (MaVe, MaChuyen, GaDi, GaDen, MaGiaVe, MaGhe) VALUES(7, 1, 1, 3, 2, 1);
INSERT INTO vedat (MaVe, MaChuyen, GaDi, GaDen, MaGiaVe, MaGhe) VALUES(8, 1, 1, 2, 1, 2);
INSERT INTO vedat (MaVe, MaChuyen, GaDi, GaDen, MaGiaVe, MaGhe) VALUES(9, 1, 1, 2, 1, 2);
INSERT INTO vedat (MaVe, MaChuyen, GaDi, GaDen, MaGiaVe, MaGhe) VALUES(10, 1, 1, 2, 1, 3);

-- --------------------------------------------------------
--
-- 20. Bảng hoadon
--
go
CREATE TABLE  hoadon (
  MaHoaDon int NOT NULL ,
  MaKhachHang int references khachHang(MaKH),
  MaVe int NOT NULL references vedat(MaVe),
  MaNV int NOT NULL references nhanvien(MaNV),
  DonGia float null,
  SoLuong int null,
  TongTien float null,
  PRIMARY KEY (MaHoaDon)
) 
--
-- Chèn dữ liệu hoadon
--


-- --------------------------------------------------------


use master
go
create database DienDan
go
use DienDan
go
create table tbl_ThanhVien(
	MaTV int IDENTITY(1, 1),
	TenThanhVien VARCHAR(50),
	MatKhau VARCHAR(50),
	Email VARCHAR(255),
	CONSTRAINT PK_TV PRIMARY KEY (MATV),
);
go
create table tbl_TinTuc(
	MaTin int IDENTITY(1,1),
	MaCD int,
	NgayTao Date,
	NguoiTao int,
	CONSTRAINT PK_TT PRIMARY KEY (MaTin)
);
go
create table tbl_ChiTiet(
	MaTin int IDENTITY(1,1),
	ChiTiet TEXT,
	FileDinhKem VARCHAR(255),
	NgayTao Date,
	CONSTRAINT PK_ChiTiet PRIMARY KEY (MaTin, NgayTao),
	CONSTRAINT FK_ChiTiet FOREIGN KEY (MaTin) REFERENCES tbl_TinTuc(MaTin)
);
go
create table tbl_ChuDe(
	MaChuDe int IDENTITY(1,1),
	TenChuDe VARCHAR(255),
	CONSTRAINT PK_ChuDe PRIMARY KEY (MaChuDe)
);

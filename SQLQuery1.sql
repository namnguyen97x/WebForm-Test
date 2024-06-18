CREATE DATABASE QLBH;
GO
USE QLBH;
GO

CREATE TABLE sanpham (
    stt INT IDENTITY,  
    tensp VARCHAR(50),
    masp VARCHAR(50),  
	CONSTRAINT PRM PRIMARY KEY (tensp, masp),
    hinhanh VARCHAR(50),
    gia INT
);

CREATE TABLE dathang (
    stt INT IDENTITY,
    tensp VARCHAR(50),
    masp VARCHAR(50),
    soluong INT,
    tenkhach VARCHAR(50),
    diachi VARCHAR(100),
    sdt VARCHAR(50),
    CONSTRAINT FK FOREIGN KEY (tensp, masp) REFERENCES sanpham (tensp, masp)
);
insert into sanpham(tensp, masp, gia)
values ('kem danh rang', 'sp01', 15000),
		('snack khoai tay', 'sp02', 10000),
		('keo deo', 'sp03', 20000),
		('bot giat aba', 'sp04', 30000),
		('mi tom kokomi', 'sp05', 5000);
		
insert into dathang (tensp, masp, soluong, tenkhach, diachi, sdt)
values ('kem danh rang', 'sp01', 10, 'Trieu Tu Long', 'Thuc', '0123456789'),
		('snack khoai tay', 'sp02', 5, 'Tao Thao', 'Nguy', '001122334455'),
		('keo deo', 'sp03', 3, 'Ton Quyen', 'Ngo', '01234978897'),
		('bot giat aba', 'sp04', 5, 'Ma Sieu', 'Han', '01264878'),
		('mi tom kokomi', 'sp05', 8, 'Luc Ton', 'Ngo', '0187286263');
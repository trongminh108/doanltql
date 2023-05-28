USE master;

CREATE DATABASE qlcafe;
GO
USE qlcafe;
GO

CREATE TABLE Ban(
	id INT IDENTITY PRIMARY KEY,
	tinhtrang BIT DEFAULT 0	
);

CREATE TABLE TaiKhoan(
	tendangnhap VARCHAR(20) PRIMARY KEY,
	matkhau NVARCHAR(1000),
	tenhienthi NVARCHAR(100),
	loai INT
	-- 1 quan ly
	-- 2 nhan vien
);

CREATE TABLE DoUong(
	id INT IDENTITY PRIMARY KEY,
	ten NVARCHAR(100),
	gia INT
);

CREATE TABLE HoaDon(
	id INT IDENTITY PRIMARY KEY,
	idBan INT,
	thoigianlap DATETIME,
	tinhtrang BIT DEFAULT 0
	-- 0 la chua thanh toan
	-- 1 la da thanh toan
);

CREATE TABLE ThongTinHoaDon(
	id INT IDENTITY PRIMARY KEY,
	idHoaDon INT,
	idDoUong INT,
	soLuong INT
);
GO

ALTER TABLE HoaDon ADD CONSTRAINT pk_Ban_HoaDon FOREIGN KEY (idBan) REFERENCES Ban(id);
ALTER TABLE ThongTinHoaDon ADD CONSTRAINT pk_HoaDon_ThongTinHoaDon FOREIGN KEY (idHoaDon) REFERENCES HoaDon(id) ON DELETE CASCADE;
ALTER TABLE ThongTinHoaDon ADD CONSTRAINT pk_DoUong_ThongTinHoaDon FOREIGN KEY (idDoUong) REFERENCES DoUong(id);
GO

-- Dữ liệu
INSERT INTO Ban VALUES
	(0), (0), (0), (0), (0);

INSERT INTO DoUong VALUES 
	(N'Cà phê đen', 18000),
	(N'Capuchino', 25000),
	(N'Lipton đá', 16000),
	(N'Cam ép', 18000),
	(N'Cà phê sữa', 22000),
	(N'Bạc xỉu', 22000),
	(N'Dưa hấu ép', 20000),
	(N'Trà sữa', 25000),
	(N'Trà đào', 23000),
	(N'Trà chanh', 15000);

INSERT INTO TaiKhoan VALUES(N'admin','e99a18c428cb38d5f260853678922e03', N'Lưu Minh Trọng', 1);	/* Mật khẩu abc123 */
INSERT INTO TaiKhoan VALUES(N'nhanvien','a906449d5769fa7361d7ecc6aa3f6d28', N'Trọng Minh', 2);	/* Mật khẩu 123abc */


--Update
UPDATE Ban SET tinhtrang=1 WHERE id = 3;

--insert HoaDon
INSERT INTO HoaDon VALUES (3, NULL, 0);

--insert ThongTinHoaDon
INSERT INTO ThongTinHoaDon VALUES
	(1, 1, 2),
	(1, 2, 2);

--UPDATE HoaDon SET tinhtrang=0 WHERE id=1; 
--UPDATE Ban SET tinhtrang=0 WHERE id=1; 
--DELETE FROM HoaDon WHERE id=2;
--SELECT * FROM HoaDon
--SELECT * FROM ThongTinHoaDon
--SELECT * FROM Ban
--SELECT * FROM DoUong

--SELECT tthd.id, hd.thoigianlap, du.ten, tthd.soLuong, du.gia
--FROM ThongTinHoaDon tthd
--INNER JOIN HoaDon AS hd ON hd.id=tthd.idHoaDon
--INNER JOIN DoUong AS du ON du.id=tthd.idDoUong
--WHERE hd.tinhtrang=0 AND hd.idBan=3;

--SELECT id FROM ThongTinHoaDon
--WHERE idDoUong=1 AND idHoaDon=9

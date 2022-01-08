 CREATE DATABASE QUANLYCUAHANGBANHOA
GO
USE QUANLYCUAHANGBANHOA
GO

CREATE TABLE NHANVIEN(
	MANV VARCHAR(10),
	TEN NVARCHAR(50),
	NGAYSINH DATE,
	GIOITINH nvarchar(10),
	SDT VARCHAR(10),
	LUONG int,
	PHANQUYEN nvarchar(50),
	FLAG_LAM BIT DEFAULT 1,
	PRIMARY KEY(MANV)
)
GO
CREATE TABLE KHACHHANG(
	MAKH VARCHAR(10),
	TENKH NVARCHAR(50),

	PRIMARY KEY(MAKH)
)
GO


CREATE TABLE SANPHAM(
	MASP varchar(10),
	TENSP NVARCHAR(50),
	LOAISP NVARCHAR(50),
	GIABAN int,
	SL INT,

	PRIMARY KEY(MASP)
)
GO


CREATE TABLE HOADONBANHANG(
	MANV VARCHAR(10) FOREIGN KEY REFERENCES NHANVIEN(MANV),
	MAKH VARCHAR(10) FOREIGN KEY REFERENCES KHACHHANG(MAKH),
	MASP varchar(10) FOREIGN KEY REFERENCES SANPHAM(MASP),
	SL INT,

	PRIMARY KEY(MANV,MAKH,MASP)
)
GO


create table LICHLAMVIEC(
	MALLV varchar(5),
	NGAY date,
	MANV varchar(10) FOREIGN KEY REFERENCES NHANVIEN(MANV),
	CA int,
	primary key(MALLV,MANV,CA)
)

create table CHITIETGIOHANG(
	MAKH varchar(10) FOREIGN KEY REFERENCES KHACHHANG(MAKH),
	MASP varchar(10) FOREIGN KEY REFERENCES KHACHHANG(MAKH),
	SL INT,
	PRIMARY KEY(MAKH, MASP)
)


/*
drop table HOADONBANHANG
drop table CHITIETGIOHANG
drop table LICHLAMVIEC
drop table SANPHAM
drop table KHACHHANG
drop table NHANVIEN
*/
insert into NHANVIEN values
('NV001',N'Nguyễn Văn A','1/2/2001','Nam','0943437834',6000000,N'Nhân viên bán hàng',1),
('NV002',N'Nguyễn Văn B','1/5/2001','Nam','0943437834',7000000,N'Nhân viên sản phẩm',1),
('NV003',N'Đào Thị C','1/7/2001',N'Nữ','0943437834',8000000,N'Nhân viên bán hàng',0),
('NV004',N'Lê Văn D','1/9/2001','Nam','0943437834',5000000,N'Nhân viên bán hàng',1),
('NV005',N'Bùi Thị E','1/10/2001',N'Nữ','0943437834',10000000,N'Nhân viên bán hàng',0),
('NV006',N'Nguyễn Văn G','12/1/2001','Nam','0943437834',3000000,N'Nhân viên bán hàng',0),
('NV007',N'Nguyễn Văn F','1/7/2001','Nam','0943437834',11000000,N'Nhân viên sản phẩm',1)

insert into KHACHHANG values
('KH001',N'Nguyễn Văn 1'),
('KH002',N'Lê Văn 2'),
('KH003',N'Đào Thị 3'),
('KH004',N'Lê thu 4'),
('KH005',N'Nguyễn Minh 5')

insert into SANPHAM values
('SP001','Mr.Lincoln','Hoa Hồng',50000,1000),
('SP002','Darkmask rose','Hoa Hồng',50000,1000),
('SP003','China rose','Hoa Hồng',100000,500),
('SP004','Rosa Pease','Hoa Hồng',70000,2000),
('SP005','Common daisy','Hoa Cúc',50000,600),
('SP006','Aster','Hoa Cúc',10000,100),
('SP007','Marigold','Hoa Cúc',60000,1000),
('SP008','Moth orchids','Hoa Lan',65000,300),
('SP009','Cattleya orchids','Hoa Lan',80000,500),
('SP010','Boat orchids','Hoa Lan',90000,1000),
('SP011','Tulipa Kaufmanniana','Hoa Tulip',100000,100),
('SP012','Gaden tulip','Hoa Tulip',40000,800)
 
insert into LICHLAMVIEC values
('L0001','1/4/2022','NV001',1),
('L0001','1/4/2022','NV001',2),
('L0001','1/4/2022','NV002',1),
('L0001','1/4/2022','NV002',2),
('L0001','1/4/2022','NV004',3),
('L0001','1/4/2022','NV007',3),
('L0001','1/4/2022','NV004',2),
('L0001','1/4/2022','NV007',2),
('L0002','2/4/2022','NV001',1),
('L0002','2/4/2022','NV001',3),
('L0002','2/4/2022','NV002',1),
('L0002','2/4/2022','NV002',3),
('L0002','2/4/2022','NV004',1),
('L0002','2/4/2022','NV007',1),
('L0002','2/4/2022','NV004',2),
('L0002','2/4/2022','NV007',2)

Create  PROC GetSanPhamList
AS Select * From SANPHAM
Go

Execute GetSanPhamList

Create  PROC GetChiTietGioHang
AS Select * From CHITIETGIOHANG
Go

Execute GetChiTietGioHang

/* them vao gio hang */
CREATE PROCEDURE Insert_GioHang
(
    @MaKH Varchar(10),
    @Masp Varchar(10),
    @SL int

)
AS
BEGIN
    IF EXISTS (SELECT * FROM CHITIETGIOHANG
        WHERE MAKH=@MaKH
            and MASP=@Masp
          
    )
    BEGIN
        UPDATE CHITIETGIOHANG set SL=SL+@SL
        WHERE MAKH=@MaKH
            and MASP=@Masp
          
    END
ELSE
    BEGIN
        INSERT into CHITIETGIOHANG Values (@MaKH,@Masp,@SL)
    END

END

/*Drop proc Insert_GioHang*/
Exec Insert_GioHang 'KH001','SP001',10

Create  PROC GetSanPhamByID
(
@MASP VARCHAR(10)
)
AS Select * From SANPHAM WHERE  MASP = @MASP
Go



Exec GetSanPhamByID "SP010"

Create  PROC DeleteGioHangByID
(
@MASP VARCHAR(10)
)
AS Delete From CHITIETGIOHANG WHERE  MASP = @MASP
Go



Exec DeleteGioHangByID "SP010"

CREATE PROCEDURE Update_GioHang
(
    @MaKH Varchar(10),
    @Masp Varchar(10),
    @SL int

)
AS
BEGIN
    IF @SL > 0      
    BEGIN
        UPDATE CHITIETGIOHANG set SL=@SL
        WHERE MAKH=@MaKH
            and MASP=@Masp
          
    END
ELSE
    BEGIN
        DELETE FROM  CHITIETGIOHANG 
		WHERE MAKH=@MaKH
            and MASP=@Masp
    END

END

exec Update_GioHang 'KH001','SP010',0

CREATE PROC Tong_Tien
as
SELECT SUM(SANPHAM.GIABAN*CHITIETGIOHANG.SL)  FROM CHITIETGIOHANG,SANPHAM WHERE CHITIETGIOHANG.MASP=SANPHAM.MASP;

EXEC Tong_Tien 




CREATE PROC SearchLike
(@MASP VARCHAR(10),
@TENSP NVARCHAR(50),
@LOAI NVARCHAR(50)
)
as
	BEGIN
	select * from SANPHAM where ( MASP LIKE  '%' +IsNull(@MASP,MASP)+'%'  AND TENSP LIKE '%'+IsNull(@TENSP,TENSP)+'%' AND LOAISP LIKE '%'+IsNull(@LOAI,LOAISP)+'%')
	end
GO


Exec SearchLike 'SP002', null, 'HỒN'
exec SearchLike 'SP002', 'M', 'hồ'
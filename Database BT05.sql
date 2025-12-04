CREATE DATABASE QLSV;
GO USE QLSV; 
GO

CREATE TABLE SinhVien( MSSV NVARCHAR(20) PRIMARY KEY, TenSV NVARCHAR(100), Khoa NVARCHAR(100), DiemTB Float )

INSERT INTO SinhVien(MSSV,TenSV,Khoa,DiemTB) Values ('MS001',N'Mai Phú Tân',N'Công nghệ phần mềm',9);
INSERT INTO SinhVien(MSSV,TenSV,Khoa,DiemTB) Values ('MS002',N'Nguyễn Phước Luân',N'Kỹ thuật máy tính',9);
INSERT INTO SinhVien(MSSV,TenSV,Khoa,DiemTB) Values ('MS003',N'Nguyễn Hữu Tính',N'Khoa học máy tính',8.5);
INSERT INTO SinhVien(MSSV,TenSV,Khoa,DiemTB) Values ('MS004',N'Trần Thị Thuỳ Vân',N'Mạng máy tính và truyền thông dữ liệu',7);


-- Drop the database 'QuanLyThuVienCSharp'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Uncomment the ALTER DATABASE statement below to set the database to SINGLE_USER mode if the drop database command fails because the database is in use.
-- ALTER DATABASE QuanLyThuVien SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
-- Drop the database if it exists
IF EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = N'QuanLyThuVienCSharp'
)
DROP DATABASE QuanLyThuVienCSharp
GO

-- Create a new database called 'QuanLyThuVienCSharp'
-- Connect to the 'master' database to run this snippet
USE master
GO

-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = N'QuanLyThuVienCSharp'
)
CREATE DATABASE QuanLyThuVienCSharp
GO

USE [QuanLyThuVienCSharp]
GO



-- Create a new table called '[SACH]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[SACH]', 'U') IS NOT NULL
DROP TABLE [dbo].[SACH]
GO
-- Create the table in the specified schema
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH]
(
    [MaSach] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, -- Primary Key column
    [AnhSach] IMAGE NULL,
    [TenSach] NVARCHAR(50) NULL,
    [SoLuong] INT NULL,
    [TacGia] NVARCHAR(50) NULL,
    [NhaXuatBan] NVARCHAR(50) NULL,
    [NamXuatBan] DATE NULL,
    [LanXuatBan] INT NULL,
    [GiaMuon] MONEY NULL,
    [MaDanhMuc] INT NOT NULL
    -- Specify more columns here
);
GO

-- Create a new table called '[DANHMUC]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[DANHMUC]', 'U') IS NOT NULL
DROP TABLE [dbo].[DANHMUC]
GO
-- Create the table in the specified schema
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHMUC]
(
    [MaDanhMuc] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, -- Primary Key column
    [TenDanhMuc] NVARCHAR(50) NULL
    -- Specify more columns here
);
GO

-- Create a new table called '[CTPHIEUMUON]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[CTPHIEUMUON]', 'U') IS NOT NULL
DROP TABLE [dbo].[CTPHIEUMUON]
GO
-- Create the table in the specified schema
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPHIEUMUON]
(
    [ID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, -- Primary Key column
    [MaSach] INT NOT NULL,
    [SoPhieuMuon] INT NOT NULL,
    [TinhTrang] BIT NULL,  --0 là đã trả, 1 là chưa trả
    [NgayMuon] DATE NULL,
    [NgayTra] DATE NULL
    -- Specify more columns here
);
GO

-- Create a new table called '[TAIKHOAN]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[TAIKHOAN]', 'U') IS NOT NULL
DROP TABLE [dbo].[TAIKHOAN]
GO
-- Create the table in the specified schema
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN]
(
    [IDTaiKhoan] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, -- Primary Key column
    [AnhDaiDien] IMAGE NULL,
    [TenDangNhap] VARCHAR(20) NOT NULL,
    [MatKhau] CHAR(20) NOT NULL,
    [TenNguoiDung] NVARCHAR(50) NULL,
    [LoaiTaiKhoan] INT NULL,  --0 là admin   1 là user
    [TinhTrang] BIT NULL
    -- Specify more columns here
);
GO

-- Create a new table called '[PHIEUMUON]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[PHIEUMUON]', 'U') IS NOT NULL
DROP TABLE [dbo].[PHIEUMUON]
GO
-- Create the table in the specified schema
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUON]
(
    [SoPhieuMuon] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, -- Primary Key column
    [TenDangNhap] VARCHAR(50) NOT NULL,
    [MaSinhVien] CHAR(10) NULL
    -- Specify more columns here
);
GO


ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_DANHMUC] FOREIGN KEY([MaDanhMuc])
REFERENCES [dbo].[DANHMUC] ([MaDanhMuc])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_DANHMUC]
GO

ALTER TABLE [dbo].[CTPHIEUMUON] ADD  DEFAULT ((0)) FOR [TinhTrang]
GO

ALTER TABLE [dbo].[CTPHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CTPHIEUMUON_PHIEUMUON] FOREIGN KEY([SoPhieuMuon])
REFERENCES [dbo].[PHIEUMUON] ([SoPhieuMuon])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTPHIEUMUON] CHECK CONSTRAINT [FK_CTPHIEUMUON_PHIEUMUON]
GO

ALTER TABLE [dbo].[CTPHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CTPHIEUMUON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTPHIEUMUON] CHECK CONSTRAINT [FK_CTPHIEUMUON_SACH]
GO


-- Insert rows into table 'DANHMUC' in schema '[dbo]'
INSERT INTO [dbo].[DANHMUC]
( -- Columns to insert data into
 [TenDanhMuc]
)
VALUES
( -- First row: values for the columns in the list above
 N'Truyện cổ tích'
),
( -- Second row: values for the columns in the list above
 N'Truyện ngắn'
),
( -- Third row: values for the columns in the list above
 N'Truyện ngụ ngôn'
),
( -- Fourth row: values for the columns in the list above
 N'Tiểu thuyết'
)
-- Add more rows here
GO

-- Insert rows into table 'SACH' in schema '[dbo]'
INSERT INTO [dbo].[SACH]
( -- Columns to insert data into
 [AnhSach], [TenSach], [SoLuong], [TacGia], [NhaXuatBan], [NamXuatBan], [LanXuatBan], [GiaMuon], [MaDanhMuc]
)
VALUES
( -- First row: values for the columns in the list above
 'C:\Users\ADMIN\Documents\GitHub\QuanLyThuVien_CSharp\Image\Book Image\Rua&Soc_TruyenNN.jpg', N'Rùa và Sóc', 30, N'Nguyễn Văn Tùng', N'Nhà xuất bản thế giới', '2016-08-16', 3, 16500, 3
),
( -- Second row: values for the columns in the list above
 'C:\Users\ADMIN\Documents\GitHub\QuanLyThuVien_CSharp\Image\Book Image\tam-cam.gif', N'Tấm Cám', 30, N'Đồng tác giả', N'Nhà xuất bản văn học', '2018-09-26', 2, 18000, 1
)
-- Add more rows here
GO

-- Insert rows into table 'TAIKHOAN' in schema '[dbo]'
INSERT INTO [dbo].[TAIKHOAN]
( -- Columns to insert data into
 [AnhDaiDien], [TenDangNhap], [MatKhau], [TenNguoiDung], [LoaiTaiKhoan], [TinhTrang]
)
VALUES
( -- First row: values for the columns in the list above
 'C:\Users\ADMIN\Documents\GitHub\QuanLyThuVien_CSharp\Image\Avatar\Male.jpg', 'hola', '123456', N'La Văn Hòa', 1, 1
),
( -- Second row: values for the columns in the list above
 'C:\Users\ADMIN\Documents\GitHub\QuanLyThuVien_CSharp\Image\Avatar\Admin.jpg', 'admin01', 'admin', N'Hà Thanh Hoàng', 0, 1
),
( -- Third row: values for the columns in the list above
 'C:\Users\ADMIN\Documents\GitHub\QuanLyThuVien_CSharp\Image\Avatar\Female.jfif', 'thuhuyen', '123456', N'Nguyễn Thu Huyền', 1, 1
),
( -- Fourth row: values for the columns in the list above
 'C:\Users\ADMIN\Documents\GitHub\QuanLyThuVien_CSharp\Image\Avatar\Male.jpg', 'dihoa', '123456', N'Nguyễn Đức Hòa', 1, 1
)
-- Add more rows here
GO

-- Insert rows into table 'PHIEUMUON' in schema '[dbo]'
INSERT INTO [dbo].[PHIEUMUON]
( -- Columns to insert data into
 [TenDangNhap], [MaSinhVien]
)
VALUES
( -- First row: values for the columns in the list above
 'hola', '2018601498'
),
( -- Second row: values for the columns in the list above
 'thuhuyen', '2018601682'
)
-- Add more rows here
GO

-- Insert rows into table 'CTPHIEUMUON' in schema '[dbo]'
INSERT INTO [dbo].[CTPHIEUMUON]
( -- Columns to insert data into
 [MaSach], [SoPhieuMuon], [TinhTrang], [NgayMuon], [NgayTra]
)
VALUES
( -- First row: values for the columns in the list above
 1, 1, 0, '2021-06-10', '2021-06-24'
),
( -- Second row: values for the columns in the list above
 1, 2, 1, '2021-08-09', '2021-08-23'
),
( -- Third row: values for the columns in the list above
 2, 2, 1, '2021-08-09', '2021-08-16'
)
-- Add more rows here
GO


-- Select rows from a Table or View '[DANHMUC]' in schema '[dbo]'
SELECT * FROM [dbo].[DANHMUC]
-- Select rows from a Table or View '[SACH]' in schema '[dbo]'
SELECT * FROM [dbo].[SACH]
-- Select rows from a Table or View '[TAIKHOAN]' in schema '[dbo]'
SELECT * FROM [dbo].[TAIKHOAN]
-- Select rows from a Table or View '[PHIEUMUON]' in schema '[dbo]'
SELECT * FROM [dbo].[PHIEUMUON]
-- Select rows from a Table or View '[CTPHIEUMUON]' in schema '[dbo]'
SELECT * FROM [dbo].[CTPHIEUMUON]


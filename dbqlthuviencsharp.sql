-- Drop the database 'QuanLyThuVien'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Uncomment the ALTER DATABASE statement below to set the database to SINGLE_USER mode if the drop database command fails because the database is in use.
-- ALTER DATABASE QuanLyThuVien SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
-- Drop the database if it exists
IF EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = N'QuanLyThuVien'
)
DROP DATABASE QuanLyThuVien
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
    [TenSach] NVARCHAR(50) NOT NULL,
    [SoTon] INT NULL,
    [TacGia] NVARCHAR(50) NULL,
    [NhaXuatBan] NVARCHAR(50) NULL,
    [NamXuatBan] DATE NULL,
    [GiaMuon] MONEY NOT NULL,
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
    [TenDanhMuc] NVARCHAR(50) NOT NULL
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
    [ID] INT NOT NULL PRIMARY KEY, -- Primary Key column
    [MaSach] INT NOT NULL,
    [SoPhieuMuon] INT NOT NULL,
    [SoLuongMuon] INT NOT NULL,
    [TinhTrang] BIT NOT NULL,
    [NgayMuon] DATE NOT NULL,
    [NgayTra] DATE NOT NULL
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
    [TenDangNhap] CHAR(20) NOT NULL,
    [MatKhau] CHAR(20) NOT NULL,
    [TenNguoiDung] NVARCHAR(50) NULL,
    [LoaiTaiKhoan] INT NOT NULL,  --0 là admin   1 là user
    [TinhTrang] BIT NOT NULL
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
    [TenDangNhap] CHAR(50) NOT NULL,
    [MaSinhVien] CHAR(10) NOT NULL
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




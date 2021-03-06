USE [master]
GO
/****** Object:  Database [CINEMA]    Script Date: 04/19/2015 10:16:11 ******/
CREATE DATABASE [CINEMA] ON  PRIMARY 
( NAME = N'CINEMA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\CINEMA.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CINEMA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\CINEMA_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CINEMA] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CINEMA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CINEMA] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [CINEMA] SET ANSI_NULLS OFF
GO
ALTER DATABASE [CINEMA] SET ANSI_PADDING OFF
GO
ALTER DATABASE [CINEMA] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [CINEMA] SET ARITHABORT OFF
GO
ALTER DATABASE [CINEMA] SET AUTO_CLOSE ON
GO
ALTER DATABASE [CINEMA] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [CINEMA] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [CINEMA] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [CINEMA] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [CINEMA] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [CINEMA] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [CINEMA] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [CINEMA] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [CINEMA] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [CINEMA] SET  DISABLE_BROKER
GO
ALTER DATABASE [CINEMA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [CINEMA] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [CINEMA] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [CINEMA] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [CINEMA] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [CINEMA] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [CINEMA] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [CINEMA] SET  READ_WRITE
GO
ALTER DATABASE [CINEMA] SET RECOVERY SIMPLE
GO
ALTER DATABASE [CINEMA] SET  MULTI_USER
GO
ALTER DATABASE [CINEMA] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [CINEMA] SET DB_CHAINING OFF
GO
USE [CINEMA]
GO
/****** Object:  Table [dbo].[NhaPhatHanhPhim]    Script Date: 04/19/2015 10:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaPhatHanhPhim](
	[MaNPH] [int] IDENTITY(1,1) NOT NULL,
	[TenNPH] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNPH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiPhongChieu]    Script Date: 04/19/2015 10:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhongChieu](
	[MaLoaiPhong] [int] NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NULL,
 CONSTRAINT [PK__LoaiPhon__2302121707F6335A] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 04/19/2015 10:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTheLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenTheLoai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuatChieu]    Script Date: 04/19/2015 10:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuatChieu](
	[MaSuat] [int] IDENTITY(1,1) NOT NULL,
	[MaPhong] [int] NOT NULL,
	[MaPhim] [int] NOT NULL,
	[MaRap] [int] NOT NULL,
	[SuatChieu] [datetime] NULL,
	[NgayChieu] [datetime] NULL,
 CONSTRAINT [PK__SuatChie__A69D02411B0907CE] PRIMARY KEY CLUSTERED 
(
	[MaSuat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RapPhim]    Script Date: 04/19/2015 10:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RapPhim](
	[MaRap] [int] IDENTITY(1,1) NOT NULL,
	[TenRap] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_RapPhim] PRIMARY KEY CLUSTERED 
(
	[MaRap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongChieu]    Script Date: 04/19/2015 10:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongChieu](
	[MaPhong] [int] IDENTITY(1,1) NOT NULL,
	[TenPhong] [nvarchar](200) NULL,
	[MaLoaiPhong] [int] NOT NULL,
	[MaRap] [int] NOT NULL,
 CONSTRAINT [PK__PhongChi__20BD5E5B173876EA] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phim]    Script Date: 04/19/2015 10:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phim](
	[MaPhim] [int] IDENTITY(1,1) NOT NULL,
	[TenPhim] [nvarchar](200) NULL,
	[MaTheLoai] [int] NULL,
	[MaNhaPhatHanh] [int] NULL,
	[ThongTinPhim] [nvarchar](max) NULL,
	[HinhAnh] [varchar](100) NULL,
	[DaoDien] [nvarchar](50) NULL,
	[ThoiLuong] [int] NULL,
	[Trailer] [nchar](100) NULL,
	[DoTuoi] [int] NULL,
	[NgayCongChieu] [datetime] NULL,
 CONSTRAINT [PK__Phim__4AC03DE31367E606] PRIMARY KEY CLUSTERED 
(
	[MaPhim] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ve]    Script Date: 04/19/2015 10:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ve](
	[MaVe] [int] IDENTITY(1,1) NOT NULL,
	[MaSuat] [int] NOT NULL,
	[MaGhe] [nvarchar](10) NULL,
	[GiaTien] [int] NULL,
	[Ngay] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaVe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaVe]    Script Date: 04/19/2015 10:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaVe](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DieuKien] [nvarchar](10) NULL,
	[GiaVe] [int] NULL,
	[MaLoaiPhong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[GETDSRAP]    Script Date: 04/19/2015 10:16:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GETDSRAP] AS 
	SELECT * FROM RapPhim
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 04/19/2015 10:16:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[MaKM] [int] NOT NULL,
	[MaRap] [int] NOT NULL,
	[MaPhong] [int] NULL,
	[MaSuat] [int] NULL,
	[MaPhim] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHangGheVIP]    Script Date: 04/19/2015 10:16:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHangGheVIP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaPhong] [int] NULL,
	[MaHang] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTGhe]    Script Date: 04/19/2015 10:16:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTGhe](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaPhong] [int] NOT NULL,
	[MaHang] [nvarchar](10) NOT NULL,
	[MaGhe] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK__CTGhe__3214EC276B24EA82] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhapPhim]    Script Date: 04/19/2015 10:16:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapPhim](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[MaPhim] [int] NOT NULL,
	[NgayNhap] [datetime] NULL,
	[SoTien] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_PhongChieu_LoaiPhongChieu]    Script Date: 04/19/2015 10:16:12 ******/
ALTER TABLE [dbo].[PhongChieu]  WITH CHECK ADD  CONSTRAINT [FK_PhongChieu_LoaiPhongChieu] FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[LoaiPhongChieu] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[PhongChieu] CHECK CONSTRAINT [FK_PhongChieu_LoaiPhongChieu]
GO
/****** Object:  ForeignKey [FK_PhongChieu_RapPhim]    Script Date: 04/19/2015 10:16:12 ******/
ALTER TABLE [dbo].[PhongChieu]  WITH CHECK ADD  CONSTRAINT [FK_PhongChieu_RapPhim] FOREIGN KEY([MaRap])
REFERENCES [dbo].[RapPhim] ([MaRap])
GO
ALTER TABLE [dbo].[PhongChieu] CHECK CONSTRAINT [FK_PhongChieu_RapPhim]
GO
/****** Object:  ForeignKey [FK_Phim_NhaPhatHanhPhim]    Script Date: 04/19/2015 10:16:12 ******/
ALTER TABLE [dbo].[Phim]  WITH CHECK ADD  CONSTRAINT [FK_Phim_NhaPhatHanhPhim] FOREIGN KEY([MaNhaPhatHanh])
REFERENCES [dbo].[NhaPhatHanhPhim] ([MaNPH])
GO
ALTER TABLE [dbo].[Phim] CHECK CONSTRAINT [FK_Phim_NhaPhatHanhPhim]
GO
/****** Object:  ForeignKey [FK_Phim_TheLoai]    Script Date: 04/19/2015 10:16:12 ******/
ALTER TABLE [dbo].[Phim]  WITH CHECK ADD  CONSTRAINT [FK_Phim_TheLoai] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoai] ([MaTheLoai])
GO
ALTER TABLE [dbo].[Phim] CHECK CONSTRAINT [FK_Phim_TheLoai]
GO
/****** Object:  ForeignKey [FK_Ve_SuatChieu]    Script Date: 04/19/2015 10:16:12 ******/
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_SuatChieu] FOREIGN KEY([MaSuat])
REFERENCES [dbo].[SuatChieu] ([MaSuat])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_SuatChieu]
GO
/****** Object:  ForeignKey [FK_GiaVe_LoaiPhongChieu]    Script Date: 04/19/2015 10:16:12 ******/
ALTER TABLE [dbo].[GiaVe]  WITH CHECK ADD  CONSTRAINT [FK_GiaVe_LoaiPhongChieu] FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[LoaiPhongChieu] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[GiaVe] CHECK CONSTRAINT [FK_GiaVe_LoaiPhongChieu]
GO
/****** Object:  ForeignKey [FK_KhuyenMai_Phim]    Script Date: 04/19/2015 10:16:13 ******/
ALTER TABLE [dbo].[KhuyenMai]  WITH CHECK ADD  CONSTRAINT [FK_KhuyenMai_Phim] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Phim] ([MaPhim])
GO
ALTER TABLE [dbo].[KhuyenMai] CHECK CONSTRAINT [FK_KhuyenMai_Phim]
GO
/****** Object:  ForeignKey [FK_KhuyenMai_PhongChieu]    Script Date: 04/19/2015 10:16:13 ******/
ALTER TABLE [dbo].[KhuyenMai]  WITH CHECK ADD  CONSTRAINT [FK_KhuyenMai_PhongChieu] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PhongChieu] ([MaPhong])
GO
ALTER TABLE [dbo].[KhuyenMai] CHECK CONSTRAINT [FK_KhuyenMai_PhongChieu]
GO
/****** Object:  ForeignKey [FK_KhuyenMai_RapPhim]    Script Date: 04/19/2015 10:16:13 ******/
ALTER TABLE [dbo].[KhuyenMai]  WITH CHECK ADD  CONSTRAINT [FK_KhuyenMai_RapPhim] FOREIGN KEY([MaRap])
REFERENCES [dbo].[RapPhim] ([MaRap])
GO
ALTER TABLE [dbo].[KhuyenMai] CHECK CONSTRAINT [FK_KhuyenMai_RapPhim]
GO
/****** Object:  ForeignKey [FK_KhuyenMai_SuatChieu]    Script Date: 04/19/2015 10:16:13 ******/
ALTER TABLE [dbo].[KhuyenMai]  WITH CHECK ADD  CONSTRAINT [FK_KhuyenMai_SuatChieu] FOREIGN KEY([MaSuat])
REFERENCES [dbo].[SuatChieu] ([MaSuat])
GO
ALTER TABLE [dbo].[KhuyenMai] CHECK CONSTRAINT [FK_KhuyenMai_SuatChieu]
GO
/****** Object:  ForeignKey [FK_CTHangGheVIP_PhongChieu]    Script Date: 04/19/2015 10:16:13 ******/
ALTER TABLE [dbo].[CTHangGheVIP]  WITH CHECK ADD  CONSTRAINT [FK_CTHangGheVIP_PhongChieu] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PhongChieu] ([MaPhong])
GO
ALTER TABLE [dbo].[CTHangGheVIP] CHECK CONSTRAINT [FK_CTHangGheVIP_PhongChieu]
GO
/****** Object:  ForeignKey [FK_CTGhe_PhongChieu]    Script Date: 04/19/2015 10:16:13 ******/
ALTER TABLE [dbo].[CTGhe]  WITH CHECK ADD  CONSTRAINT [FK_CTGhe_PhongChieu] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PhongChieu] ([MaPhong])
GO
ALTER TABLE [dbo].[CTGhe] CHECK CONSTRAINT [FK_CTGhe_PhongChieu]
GO
/****** Object:  ForeignKey [FK_PhieuNhapPhim_Phim]    Script Date: 04/19/2015 10:16:13 ******/
ALTER TABLE [dbo].[PhieuNhapPhim]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapPhim_Phim] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Phim] ([MaPhim])
GO
ALTER TABLE [dbo].[PhieuNhapPhim] CHECK CONSTRAINT [FK_PhieuNhapPhim_Phim]
GO

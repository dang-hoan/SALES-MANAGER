USE [master]
GO
/****** Object:  Database [SalesManagerDB]    Script Date: 15/6/2023 3:33:46 PM ******/
CREATE DATABASE [SalesManagerDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SalesManagerDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.CSDL\MSSQL\DATA\SalesManagerDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SalesManagerDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.CSDL\MSSQL\DATA\SalesManagerDB_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SalesManagerDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SalesManagerDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SalesManagerDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SalesManagerDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SalesManagerDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SalesManagerDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SalesManagerDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SalesManagerDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SalesManagerDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SalesManagerDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SalesManagerDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SalesManagerDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SalesManagerDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SalesManagerDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SalesManagerDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SalesManagerDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SalesManagerDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SalesManagerDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SalesManagerDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SalesManagerDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SalesManagerDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SalesManagerDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SalesManagerDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SalesManagerDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SalesManagerDB] SET RECOVERY FULL 
GO
ALTER DATABASE [SalesManagerDB] SET  MULTI_USER 
GO
ALTER DATABASE [SalesManagerDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SalesManagerDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SalesManagerDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SalesManagerDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SalesManagerDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SalesManagerDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SalesManagerDB', N'ON'
GO
ALTER DATABASE [SalesManagerDB] SET QUERY_STORE = OFF
GO
USE [SalesManagerDB]
GO
/****** Object:  Table [dbo].[PaymentMethod]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentMethod](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PaymentMethodName] [varchar](100) NOT NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](40) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateBy] [varchar](40) NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteBy] [varchar](40) NULL,
	[IsDelete] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](40) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[ShipperId] [bigint] NOT NULL,
	[ShipDate] [datetime] NULL,
	[ShipAddress] [nvarchar](100) NOT NULL,
	[ShipPostalCode] [varchar](10) NULL,
	[ShipPrice] [decimal](8, 2) NOT NULL,
	[StatusId] [int] NOT NULL,
	[PrivateDiscount] [float] NULL,
	[TotalPrice] [decimal](8, 2) NOT NULL,
	[PaymentMethodId] [int] NOT NULL,
	[Note] [nvarchar](255) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](40) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateBy] [varchar](40) NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteBy] [varchar](40) NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK__Order__3214EC07C9B55C6E] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [varchar](30) NOT NULL,
	[TypeStatus] [varchar](30) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](40) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateBy] [varchar](40) NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteBy] [varchar](40) NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK__Status__3214EC07D8DD3CDF] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](40) NULL,
	[LastName] [nvarchar](30) NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[Gender] [bit] NULL,
	[BirthDate] [datetime] NULL,
	[Phone] [varchar](20) NOT NULL,
	[Email] [varchar](40) NULL,
	[Address] [nvarchar](100) NULL,
	[RoleId] [int] NOT NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](40) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateBy] [varchar](40) NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteBy] [varchar](40) NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[SalesOrderView]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SalesOrderView]
AS
SELECT dbo.[Order].Id AS OrderId, dbo.[Order].CustomerName, dbo.[Order].OrderDate, dbo.[Order].ShipDate, dbo.[Order].ShipAddress, dbo.[Order].StatusId, dbo.[Order].ShipPrice, dbo.[Order].TotalPrice, dbo.[Order].PrivateDiscount, dbo.[Order].PaymentMethodId, dbo.[Order].ShipperId, 
             dbo.[Order].Note, dbo.PaymentMethod.PaymentMethodName, dbo.Person.LastName + ' ' + dbo.Person.FirstName AS ShipperName, dbo.Status.StatusName, dbo.[Order].IsDelete
FROM   dbo.[Order] INNER JOIN
             dbo.PaymentMethod ON dbo.[Order].PaymentMethodId = dbo.PaymentMethod.Id INNER JOIN
             dbo.Person ON dbo.[Order].ShipperId = dbo.Person.Id INNER JOIN
             dbo.Status ON dbo.[Order].StatusId = dbo.Status.Id
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[Phone] [varchar](20) NULL,
	[Email] [varchar](20) NULL,
	[Webpage] [varchar](100) NULL,
	[Description] [nvarchar](100) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](40) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateBy] [varchar](40) NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteBy] [varchar](40) NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK__Supplier__3214EC076718601B] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](30) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](40) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateBy] [varchar](40) NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteBy] [varchar](40) NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK__Category__3214EC078A0F1DBD] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[SupplierId] [bigint] NOT NULL,
	[CategoryId] [bigint] NOT NULL,
	[ProductPrice] [decimal](30, 2) NOT NULL,
	[UnitPrice] [nvarchar](10) NOT NULL,
	[ProductStatusId] [int] NOT NULL,
	[DiscountPercent] [float] NULL,
	[Rating] [int] NULL,
	[ImageId] [bigint] NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](40) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateBy] [varchar](40) NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteBy] [varchar](40) NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK__Product__3214EC07FCE901D0] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WareHouse]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WareHouse](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[WareHouseName] [nvarchar](40) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[NumberOfImport] [bigint] NULL,
	[NumberOfExport] [bigint] NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](40) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateBy] [varchar](40) NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteBy] [varchar](40) NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK__WareHous__3214EC078550B6A7] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesDetail]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesDetail](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[WareHouseId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[Total] [bigint] NULL,
	[SellNumber] [bigint] NULL,
	[SalesTotal] [decimal](8, 2) NULL,
 CONSTRAINT [PK__SalesDet__3214EC07580F6F72] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ProductView]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ProductView]
AS
SELECT dbo.Product.Id, dbo.Product.ProductName, dbo.Product.ProductPrice, dbo.Product.UnitPrice, dbo.Product.DiscountPercent, dbo.Product.Rating, dbo.Product.ImageId, dbo.SalesDetail.Total, dbo.SalesDetail.SellNumber, dbo.Supplier.CompanyName, dbo.Category.CategoryName, 
             dbo.Status.StatusName, dbo.WareHouse.WareHouseName, dbo.Product.IsDelete, dbo.Product.SupplierId, dbo.Product.CategoryId, dbo.Product.ProductStatusId, dbo.SalesDetail.WareHouseId
FROM   dbo.Product INNER JOIN
             dbo.Supplier ON dbo.Product.SupplierId = dbo.Supplier.Id INNER JOIN
             dbo.Category ON dbo.Product.CategoryId = dbo.Category.Id INNER JOIN
             dbo.Status ON dbo.Product.ProductStatusId = dbo.Status.Id LEFT OUTER JOIN
             dbo.SalesDetail ON dbo.Product.Id = dbo.SalesDetail.ProductId INNER JOIN
             dbo.WareHouse ON dbo.SalesDetail.WareHouseId = dbo.WareHouse.Id
GO
/****** Object:  Table [dbo].[Account]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [varchar](40) NOT NULL,
	[Password] [varchar](200) NOT NULL,
	[StatusId] [int] NOT NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](40) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateBy] [varchar](40) NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteBy] [varchar](40) NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK__Account__3214EC079E3D7661] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Image]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Image](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Source] [varchar](20) NOT NULL,
	[Description] [varchar](100) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](40) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateBy] [varchar](40) NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteBy] [varchar](40) NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK__Image__3214EC078B54A9EA] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[NumberOfProducts] [int] NOT NULL,
	[TotalPriceOfProducts] [decimal](8, 2) NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PermissionName] [varchar](300) NOT NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](40) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateBy] [varchar](40) NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteBy] [varchar](40) NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK__Permissi__3214EC07FDEF6997] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](25) NOT NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](40) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateBy] [varchar](40) NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteBy] [varchar](40) NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK__Role__3214EC076CC9B693] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolePermission]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolePermission](
	[RoleId] [int] NOT NULL,
	[PermissionId] [int] NOT NULL,
 CONSTRAINT [PK_RolePermission] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC,
	[PermissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[InsertCustomer]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCustomer]
(
	@Username varchar(40),
	@LastName nvarchar(30),
	@FirstName nvarchar(10),
	@Gender bit,
	@BirthDate datetime,
	@Phone varchar(20),
	@Email varchar(40),
	@Address nvarchar(100),
	@CreateDate datetime,
	@CreateBy varchar(40),
	@IsDelete bit
)
AS
	SET NOCOUNT OFF;
INSERT INTO Person
             (Username, LastName, FirstName, Gender, BirthDate, Phone, Email, Address, CreateDate, CreateBy, IsDelete)
VALUES (@Username,@LastName,@FirstName,@Gender,@BirthDate,@Phone,@Email,@Address,@CreateDate,@CreateBy,@IsDelete);
	 
SELECT Username, LastName, FirstName, Gender, BirthDate, Phone, Email, Address, CreateDate, CreateBy, UpdateDate, UpdateBy, DeleteDate, DeleteBy, IsDelete FROM Person WHERE (Username = @Username)
GO
/****** Object:  StoredProcedure [dbo].[InsertQuery]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertQuery]
(
	@ProductName nvarchar(40),
	@SupplierId bigint,
	@CategoryId bigint,
	@ProductPrice decimal(30, 2),
	@UnitPrice nvarchar(10),
	@ProductStatusId int,
	@DiscountPercent float,
	@Rating int,
	@ImageId bigint,
	@CreateDate datetime,
	@CreateBy varchar(40),
	@IsDelete bit
)
AS
	SET NOCOUNT OFF;
INSERT INTO Product
             (ProductName, SupplierId, CategoryId, ProductPrice, UnitPrice, ProductStatusId, DiscountPercent, Rating, ImageId, CreateDate, CreateBy, IsDelete)
OUTPUT Inserted.Id
VALUES (@ProductName,@SupplierId,@CategoryId,@ProductPrice,@UnitPrice,@ProductStatusId,@DiscountPercent,@Rating,@ImageId,@CreateDate,@CreateBy,@IsDelete);
	  
SELECT Id, ProductName, SupplierId, CategoryId, ProductPrice, UnitPrice, ProductStatusId, DiscountPercent, Rating, ImageId, CreateDate, CreateBy, UpdateDate, UpdateBy, DeleteDate, DeleteBy, IsDelete FROM Product WHERE (Id = SCOPE_IDENTITY())
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomer]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCustomer]
(
	@LastName nvarchar(30),
	@FirstName nvarchar(10),
	@Gender bit,
	@BirthDate datetime,
	@Phone varchar(20),
	@Email varchar(40),
	@Address nvarchar(100),
	@UpdateDate datetime,
	@UpdateBy varchar(40),
	@Username varchar(40)
)
AS
	SET NOCOUNT OFF;
UPDATE Person
SET       LastName = @LastName, FirstName = @FirstName, Gender = @Gender, BirthDate = @BirthDate, Phone = @Phone, Email = @Email, Address = @Address, UpdateDate = @UpdateDate, UpdateBy = @UpdateBy
WHERE (Username = @Username);
	 
SELECT Username, LastName, FirstName, Gender, BirthDate, Phone, Email, Address, CreateDate, CreateBy, UpdateDate, UpdateBy, DeleteDate, DeleteBy, IsDelete FROM Person WHERE (Username = @Username)
GO
/****** Object:  StoredProcedure [dbo].[UpdateQuery]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateQuery]
(
	@LastName nvarchar(30),
	@FirstName nvarchar(10),
	@Gender bit,
	@BirthDate datetime,
	@Phone varchar(20),
	@Email varchar(40),
	@Address nvarchar(100),
	@UpdateDate varchar(50),
	@UpdateBy varchar(50),
	@Original_Username varchar(40),
	@Username varchar(40)
)
AS
	SET NOCOUNT OFF;
UPDATE Person
SET       LastName = @LastName, FirstName = @FirstName, Gender = @Gender, BirthDate = @BirthDate, Phone = @Phone, Email = @Email, Address = @Address, UpdateDate = @UpdateDate, UpdateBy = @UpdateBy
WHERE (Username = @Original_Username);
	 
SELECT Username, LastName, FirstName, Gender, BirthDate, Phone, Email, Address, CreateDate, CreateBy, UpdateDate, UpdateBy, DeleteDate, DeleteBy, IsDelete FROM Person WHERE (Username = @Username)
GO
/****** Object:  StoredProcedure [dbo].[UpdateQuery2]    Script Date: 15/6/2023 3:33:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateQuery2]
(
	@LastName nvarchar(30),
	@FirstName nvarchar(10),
	@Gender bit,
	@BirthDate datetime,
	@Phone varchar(20),
	@Email varchar(40),
	@Address nvarchar(100),
	@UpdateDate varchar(50),
	@UpdateBy varchar(50),
	@Username varchar(40)
)
AS
	SET NOCOUNT OFF;
UPDATE Person
SET       LastName = @LastName, FirstName = @FirstName, Gender = @Gender, BirthDate = @BirthDate, Phone = @Phone, Email = @Email, Address = @Address, UpdateDate = @UpdateDate, UpdateBy = @UpdateBy
WHERE (Username = @Username);
	 
SELECT Username, LastName, FirstName, Gender, BirthDate, Phone, Email, Address, CreateDate, CreateBy, UpdateDate, UpdateBy, DeleteDate, DeleteBy, IsDelete FROM Person WHERE (Username = @Username)
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Category"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 280
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Product"
            Begin Extent = 
               Top = 9
               Left = 337
               Bottom = 206
               Right = 569
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "SalesDetail"
            Begin Extent = 
               Top = 9
               Left = 626
               Bottom = 206
               Right = 848
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Status"
            Begin Extent = 
               Top = 9
               Left = 905
               Bottom = 206
               Right = 1127
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "Supplier"
            Begin Extent = 
               Top = 207
               Left = 57
               Bottom = 404
               Right = 285
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "WareHouse"
            Begin Extent = 
               Top = 207
               Left = 342
               Bottom = 404
               Right = 586
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         A' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ProductView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'lias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ProductView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ProductView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Order"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 309
            End
            DisplayFlags = 280
            TopColumn = 16
         End
         Begin Table = "PaymentMethod"
            Begin Extent = 
               Top = 9
               Left = 366
               Bottom = 206
               Right = 649
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Person"
            Begin Extent = 
               Top = 9
               Left = 706
               Bottom = 206
               Right = 928
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Status"
            Begin Extent = 
               Top = 9
               Left = 985
               Bottom = 206
               Right = 1207
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SalesOrderView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SalesOrderView'
GO
USE [master]
GO
ALTER DATABASE [SalesManagerDB] SET  READ_WRITE 
GO

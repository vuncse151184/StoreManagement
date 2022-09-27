USE [master]
GO
CREATE DATABASE [FStore]
GO
USE [FStore]
GO
CREATE TABLE [dbo].[Member](
	[MemberId] [int] NOT NULL  PRIMARY KEY,
	[Email] [varchar](100) NOT NULL,
	[CompanyName] [varchar](40) NOT NULL,
	[City] [varchar](15) NOT NULL,
	[Country] [varchar](15) NOT NULL,
	[Password] [varchar](30) NOT NULL
	)
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] NOT NULL PRIMARY KEY,
	[MemberId] [int] NOT NULL FOREIGN KEY REFERENCES [dbo].[Member]([MemberId]),
	[OrderDate] [datetime] NOT NULL,
	[RequiredDate] [datetime] NULL,
	[ShippedDate] [datetime] NULL,
	[Freight] [money] NULL
	)
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] NOT NULL PRIMARY KEY,
	[CategoryId] [int] NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[Weight] [nvarchar](20) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[UnitInStock] [int] NOT NULL
	)
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderId] [int] NOT NULL FOREIGN KEY REFERENCES [dbo].[Order]([OrderId]),
	[ProductId] [int] NOT NULL FOREIGN KEY REFERENCES [dbo].[Product]([ProductId]),
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [float] NOT NULL,
	PRIMARY KEY([OrderId],[ProductId])
)
GO
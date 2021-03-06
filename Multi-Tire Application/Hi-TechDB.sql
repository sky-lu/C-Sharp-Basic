USE [master]
GO
/****** Object:  Database [Hi-TechDB]    Script Date: 12/14/2020 4:43:11 PM ******/
CREATE DATABASE [Hi-TechDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hi-TechDB', FILENAME = N'd:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Hi-TechDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hi-TechDB_log', FILENAME = N'd:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Hi-TechDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Hi-TechDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hi-TechDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hi-TechDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hi-TechDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hi-TechDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hi-TechDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hi-TechDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hi-TechDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hi-TechDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hi-TechDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hi-TechDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hi-TechDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hi-TechDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hi-TechDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hi-TechDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hi-TechDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hi-TechDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hi-TechDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hi-TechDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hi-TechDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hi-TechDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hi-TechDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hi-TechDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hi-TechDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hi-TechDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Hi-TechDB] SET  MULTI_USER 
GO
ALTER DATABASE [Hi-TechDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hi-TechDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hi-TechDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hi-TechDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hi-TechDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hi-TechDB] SET QUERY_STORE = OFF
GO
USE [Hi-TechDB]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 12/14/2020 4:43:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorId] [int] NOT NULL,
	[FirstName] [nvarchar](15) NOT NULL,
	[LastName] [nvarchar](15) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AuthorsBooks]    Script Date: 12/14/2020 4:43:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthorsBooks](
	[AuthorId] [int] NOT NULL,
	[ISBN] [nvarchar](15) NOT NULL,
	[YearPublished] [date] NOT NULL,
	[Edition] [int] NOT NULL,
 CONSTRAINT [PK_AuthorsBooks] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 12/14/2020 4:43:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[ISBN] [nvarchar](15) NOT NULL,
	[BookTitle] [nvarchar](100) NOT NULL,
	[QOH] [int] NOT NULL,
	[UnitPrice] [float] NOT NULL,
	[CategoryId] [nvarchar](15) NOT NULL,
	[PublisherId] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 12/14/2020 4:43:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [nvarchar](15) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 12/14/2020 4:43:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[Street] [nvarchar](100) NOT NULL,
	[City] [nvarchar](30) NOT NULL,
	[PostalCode] [nvarchar](10) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Fax] [nvarchar](50) NOT NULL,
	[ContactName] [nvarchar](30) NOT NULL,
	[CreditLimit] [int] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 12/14/2020 4:43:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeId] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](30) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[JobId] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jobs]    Script Date: 12/14/2020 4:43:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jobs](
	[JobId] [int] NOT NULL,
	[JobTitle] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](200) NULL,
 CONSTRAINT [PK_Jobs] PRIMARY KEY CLUSTERED 
(
	[JobId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderLines]    Script Date: 12/14/2020 4:43:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderLines](
	[OrderId] [nvarchar](10) NOT NULL,
	[ISBN] [nvarchar](15) NOT NULL,
	[QuantityOrdered] [int] NOT NULL,
 CONSTRAINT [PK_OrderLines] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 12/14/2020 4:43:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [nvarchar](10) NOT NULL,
	[OrderType] [nvarchar](10) NOT NULL,
	[OrderDate] [date] NOT NULL,
	[RequiredDate] [date] NOT NULL,
	[ShippingDate] [date] NOT NULL,
	[OrderStatus] [nvarchar](15) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[EmployeeId] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publishers]    Script Date: 12/14/2020 4:43:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publishers](
	[PublisherId] [nvarchar](15) NOT NULL,
	[PublisherName] [nvarchar](100) NOT NULL,
	[WebAddress] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Publishers] PRIMARY KEY CLUSTERED 
(
	[PublisherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/14/2020 4:43:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[EmployeeId] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName], [Email]) VALUES (1211, N'Jas', N'Chohan', N'jasChohan@gmail.com')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName], [Email]) VALUES (1212, N'Laura', N'Andan', N'lauraAndan@yahoo.com')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName], [Email]) VALUES (1213, N'Honglin', N'Lu', N'honglinLu@yahoo.com')
GO
INSERT [dbo].[AuthorsBooks] ([AuthorId], [ISBN], [YearPublished], [Edition]) VALUES (1211, N'1234567890123', CAST(N'0001-01-01' AS Date), 0)
INSERT [dbo].[AuthorsBooks] ([AuthorId], [ISBN], [YearPublished], [Edition]) VALUES (1211, N'1234567890345', CAST(N'0001-01-01' AS Date), 0)
INSERT [dbo].[AuthorsBooks] ([AuthorId], [ISBN], [YearPublished], [Edition]) VALUES (1212, N'1234567890123', CAST(N'0001-01-01' AS Date), 0)
INSERT [dbo].[AuthorsBooks] ([AuthorId], [ISBN], [YearPublished], [Edition]) VALUES (1212, N'1234567890234', CAST(N'0001-01-01' AS Date), 0)
INSERT [dbo].[AuthorsBooks] ([AuthorId], [ISBN], [YearPublished], [Edition]) VALUES (1213, N'1234567890345', CAST(N'0001-01-01' AS Date), 0)
GO
INSERT [dbo].[Books] ([ISBN], [BookTitle], [QOH], [UnitPrice], [CategoryId], [PublisherId]) VALUES (N'1234567890123', N'Clean Code', 50, 28.89, N'C01', N'P1111')
INSERT [dbo].[Books] ([ISBN], [BookTitle], [QOH], [UnitPrice], [CategoryId], [PublisherId]) VALUES (N'1234567890234', N'Learn Linux Quickly', 100, 32.22, N'C03', N'P2222')
INSERT [dbo].[Books] ([ISBN], [BookTitle], [QOH], [UnitPrice], [CategoryId], [PublisherId]) VALUES (N'1234567890345', N'python', 89, 23.99, N'C05', N'P2222')
GO
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (N'C01', N'Computer programming')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (N'C02', N'Computer Security')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (N'C03', N'Operating Systems')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (N'C04', N'Artificial Intelligence')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (N'C05', N'Algorithm')
GO
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Street], [City], [PostalCode], [Phone], [Email], [Fax], [ContactName], [CreditLimit]) VALUES (6661, N'LasalleCollege', N'Saint-Catherine', N'Montreal', N'H3H2T3', N'(514) 939-2006', N'lasalle@yahoo.com', N'5551234', N'Linda', 5000)
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Street], [City], [PostalCode], [Phone], [Email], [Fax], [ContactName], [CreditLimit]) VALUES (6662, N'McGillUniversity', N'Sherbrooke', N'Montreal', N'H3AOG4', N'(514)938-5080', N'mcgill@yahoo.com', N'5552345', N'Helen', 8000)
GO
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [JobId]) VALUES (1111, N'Henry', N'Brown', N'(514) 111-1111', N'henryBrown@gmail.com', 10001)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [JobId]) VALUES (2222, N'Thomas', N'Moore', N'(514) 222-2222', N'thomasMoore@outlook.com', 10002)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [JobId]) VALUES (3333, N'Peter', N'Wang', N'(514) 333-3333', N'peterWang@yahoo.com', 10003)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [JobId]) VALUES (4444, N'Mary', N'Brown', N'(514) 444-4444', N'maryBrown@gmail.com', 10004)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [JobId]) VALUES (5555, N'Jennifer', N'Bouchard', N'(514)555-5555', N'jenniferBouchard@gmail.com', 10004)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [JobId]) VALUES (6666, N'Honglin', N'Lu', N'(514) 666-6666', N'honglin@yahoo.com', 10005)
GO
INSERT [dbo].[Jobs] ([JobId], [JobTitle], [Description]) VALUES (10001, N'MIS Manager', N'manage user and employee information')
INSERT [dbo].[Jobs] ([JobId], [JobTitle], [Description]) VALUES (10002, N'Sales Manager', N'manage customer information')
INSERT [dbo].[Jobs] ([JobId], [JobTitle], [Description]) VALUES (10003, N'Inventory Controller', N'manage book information')
INSERT [dbo].[Jobs] ([JobId], [JobTitle], [Description]) VALUES (10004, N'Order Clerk', N'manage customers'' information')
INSERT [dbo].[Jobs] ([JobId], [JobTitle], [Description]) VALUES (10005, N'Accountant', N'manage customers'' invoices')
GO
INSERT [dbo].[OrderLines] ([OrderId], [ISBN], [QuantityOrdered]) VALUES (N'ST001', N'1234567890123', 40)
INSERT [dbo].[OrderLines] ([OrderId], [ISBN], [QuantityOrdered]) VALUES (N'ST002', N'1234567890123', 10)
INSERT [dbo].[OrderLines] ([OrderId], [ISBN], [QuantityOrdered]) VALUES (N'ST002', N'1234567890234', 100)
GO
INSERT [dbo].[Orders] ([OrderId], [OrderType], [OrderDate], [RequiredDate], [ShippingDate], [OrderStatus], [CustomerId], [EmployeeId]) VALUES (N'ST001', N'Email', CAST(N'2020-11-20' AS Date), CAST(N'2020-12-01' AS Date), CAST(N'2020-11-25' AS Date), N'Completed', 6661, 4444)
INSERT [dbo].[Orders] ([OrderId], [OrderType], [OrderDate], [RequiredDate], [ShippingDate], [OrderStatus], [CustomerId], [EmployeeId]) VALUES (N'ST002', N'Phone', CAST(N'2020-11-26' AS Date), CAST(N'2020-12-12' AS Date), CAST(N'2020-12-09' AS Date), N'In process', 6662, 5555)
INSERT [dbo].[Orders] ([OrderId], [OrderType], [OrderDate], [RequiredDate], [ShippingDate], [OrderStatus], [CustomerId], [EmployeeId]) VALUES (N'ST003', N'Email', CAST(N'2020-12-10' AS Date), CAST(N'2020-12-20' AS Date), CAST(N'2020-12-15' AS Date), N'In process', 6662, 4444)
GO
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName], [WebAddress]) VALUES (N'P1111', N'Wrox', N'www.wrox.ca')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName], [WebAddress]) VALUES (N'P2222', N'Murach', N'www.murach.ca')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName], [WebAddress]) VALUES (N'P3333', N'Premier Press', N'www.premierpress.ca')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName], [WebAddress]) VALUES (N'P4444', N'Prentice Hall', N'www.prenticehall.ca')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName], [WebAddress]) VALUES (N'P5555', N'Hachette Livre', N'www.hachette.ca')
GO
INSERT [dbo].[Users] ([UserId], [Password], [EmployeeId]) VALUES (331, N'henry331', 1111)
INSERT [dbo].[Users] ([UserId], [Password], [EmployeeId]) VALUES (332, N'thomas332', 2222)
INSERT [dbo].[Users] ([UserId], [Password], [EmployeeId]) VALUES (333, N'peter333', 3333)
INSERT [dbo].[Users] ([UserId], [Password], [EmployeeId]) VALUES (334, N'mary334', 4444)
INSERT [dbo].[Users] ([UserId], [Password], [EmployeeId]) VALUES (335, N'jennifer335', 5555)
INSERT [dbo].[Users] ([UserId], [Password], [EmployeeId]) VALUES (336, N'honglin336', 6666)
GO
ALTER TABLE [dbo].[AuthorsBooks]  WITH CHECK ADD  CONSTRAINT [FK_AuthorsBooks_Authors] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Authors] ([AuthorId])
GO
ALTER TABLE [dbo].[AuthorsBooks] CHECK CONSTRAINT [FK_AuthorsBooks_Authors]
GO
ALTER TABLE [dbo].[AuthorsBooks]  WITH CHECK ADD  CONSTRAINT [FK_AuthorsBooks_Books] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
GO
ALTER TABLE [dbo].[AuthorsBooks] CHECK CONSTRAINT [FK_AuthorsBooks_Books]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Categories]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Publishers] FOREIGN KEY([PublisherId])
REFERENCES [dbo].[Publishers] ([PublisherId])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Publishers]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Jobs] FOREIGN KEY([JobId])
REFERENCES [dbo].[Jobs] ([JobId])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Jobs]
GO
ALTER TABLE [dbo].[OrderLines]  WITH CHECK ADD  CONSTRAINT [FK_OrderLines_Books] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
GO
ALTER TABLE [dbo].[OrderLines] CHECK CONSTRAINT [FK_OrderLines_Books]
GO
ALTER TABLE [dbo].[OrderLines]  WITH CHECK ADD  CONSTRAINT [FK_OrderLines_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[OrderLines] CHECK CONSTRAINT [FK_OrderLines_Orders]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([EmployeeId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([EmployeeId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Employees]
GO
USE [master]
GO
ALTER DATABASE [Hi-TechDB] SET  READ_WRITE 
GO

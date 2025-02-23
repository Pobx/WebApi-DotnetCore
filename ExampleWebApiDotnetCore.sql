USE [master]
GO
/****** Object:  Database [ExampleWebApiDotnetCore]    Script Date: 18/09/2020 14:55:10 ******/
CREATE DATABASE [ExampleWebApiDotnetCore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ExampleWebApiDotnetCore', FILENAME = N'/var/opt/mssql/data/ExampleWebApiDotnetCore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ExampleWebApiDotnetCore_log', FILENAME = N'/var/opt/mssql/data/ExampleWebApiDotnetCore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ExampleWebApiDotnetCore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET ARITHABORT OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET RECOVERY FULL 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET  MULTI_USER 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET QUERY_STORE = OFF
GO
USE [ExampleWebApiDotnetCore]
GO
/****** Object:  Table [dbo].[ExampleDemo]    Script Date: 18/09/2020 14:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExampleDemo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](100) NULL,
	[IsActive] [char](1) NULL,
	[CreatedBy] [nchar](100) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [nchar](100) NULL,
	[UpdatedDate] [datetime] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ExampleDemo] ON 

INSERT [dbo].[ExampleDemo] ([Id], [Name], [IsActive], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate]) VALUES (1, N'Pobx                                                                                                ', N'N', NULL, NULL, N'Pobx                                                                                                ', CAST(N'2020-09-18T07:49:32.600' AS DateTime))
INSERT [dbo].[ExampleDemo] ([Id], [Name], [IsActive], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate]) VALUES (2, N'Geidtiphong Singseewo                                                                               ', N'Y', NULL, NULL, N'Pobx                                                                                                ', CAST(N'2020-09-18T07:49:56.893' AS DateTime))
INSERT [dbo].[ExampleDemo] ([Id], [Name], [IsActive], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate]) VALUES (3, N'Poppy                                                                                               ', N'Y', N'Pobx                                                                                                ', CAST(N'2020-09-18T07:51:03.933' AS DateTime), N'Pobx                                                                                                ', CAST(N'2020-09-18T07:51:03.933' AS DateTime))
SET IDENTITY_INSERT [dbo].[ExampleDemo] OFF
USE [master]
GO
ALTER DATABASE [ExampleWebApiDotnetCore] SET  READ_WRITE 
GO

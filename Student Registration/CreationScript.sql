USE [master]
GO
/****** Object:  Database [StudentRegistration]    Script Date: 26/05/2023 23:16:19 ******/
CREATE DATABASE [StudentRegistration]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentRegistration', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\StudentRegistration.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StudentRegistration_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\StudentRegistration_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [StudentRegistration] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentRegistration].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentRegistration] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentRegistration] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentRegistration] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentRegistration] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentRegistration] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentRegistration] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudentRegistration] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentRegistration] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentRegistration] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentRegistration] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentRegistration] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentRegistration] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentRegistration] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentRegistration] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentRegistration] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StudentRegistration] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentRegistration] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentRegistration] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentRegistration] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentRegistration] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentRegistration] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentRegistration] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentRegistration] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StudentRegistration] SET  MULTI_USER 
GO
ALTER DATABASE [StudentRegistration] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentRegistration] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentRegistration] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentRegistration] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StudentRegistration] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StudentRegistration] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [StudentRegistration] SET QUERY_STORE = OFF
GO
USE [StudentRegistration]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 26/05/2023 23:16:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CourseCode] [varchar](10) NOT NULL,
	[CourseName] [varchar](100) NOT NULL,
	[CourseDescription] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CourseCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 26/05/2023 23:16:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentID] [int] NOT NULL,
	[StudentNumber] [varchar](50) NULL,
	[StudentName] [varchar](100) NOT NULL,
	[StudentSurname] [varchar](100) NOT NULL,
	[StudentImage] [varbinary](max) NULL,
	[DOB] [date] NULL,
	[Gender] [varchar](10) NULL,
	[Phone] [varchar](20) NULL,
	[Address] [varchar](200) NULL,
	[CourseCode] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [StudentRegistration] SET  READ_WRITE 
GO

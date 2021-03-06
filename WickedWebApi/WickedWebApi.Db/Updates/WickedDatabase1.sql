﻿CREATE DATABASE [WickedDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WickedDb', FILENAME = N'D:\Teo Workspace\SQLServer\MSSQL14.SQLEXPRESS\MSSQL\DATA\WickedDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WickedDb_log', FILENAME = N'D:\Teo Workspace\SQLServer\MSSQL14.SQLEXPRESS\MSSQL\DATA\WickedDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [WickedDb] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WickedDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [WickedDb] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [WickedDb] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [WickedDb] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [WickedDb] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [WickedDb] SET ARITHABORT OFF 
GO

ALTER DATABASE [WickedDb] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [WickedDb] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [WickedDb] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [WickedDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [WickedDb] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [WickedDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [WickedDb] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [WickedDb] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [WickedDb] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [WickedDb] SET  DISABLE_BROKER 
GO

ALTER DATABASE [WickedDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [WickedDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [WickedDb] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [WickedDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [WickedDb] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [WickedDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [WickedDb] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [WickedDb] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [WickedDb] SET  MULTI_USER 
GO

ALTER DATABASE [WickedDb] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [WickedDb] SET DB_CHAINING OFF 
GO

ALTER DATABASE [WickedDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [WickedDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [WickedDb] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [WickedDb] SET QUERY_STORE = OFF
GO

USE [WickedDb]
GO

ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [WickedDb] SET  READ_WRITE 
GO


CREATE TABLE [dbo].[Account]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [IsAdmin] BIT NOT NULL
)
GO
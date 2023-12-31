USE [master]
GO
/****** Object:  Database [Flintech_DB]    Script Date: 27-11-2023 17:29:43 ******/
CREATE DATABASE [Flintech_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Flintech_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Flintech_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Flintech_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Flintech_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Flintech_DB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Flintech_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Flintech_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Flintech_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Flintech_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Flintech_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Flintech_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Flintech_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Flintech_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Flintech_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Flintech_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Flintech_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Flintech_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Flintech_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Flintech_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Flintech_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Flintech_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Flintech_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Flintech_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Flintech_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Flintech_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Flintech_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Flintech_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Flintech_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Flintech_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Flintech_DB] SET  MULTI_USER 
GO
ALTER DATABASE [Flintech_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Flintech_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Flintech_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Flintech_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Flintech_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Flintech_DB] SET QUERY_STORE = OFF
GO
USE [Flintech_DB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Flintech_DB]
GO
/****** Object:  Table [dbo].[Task_MST]    Script Date: 27-11-2023 17:29:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task_MST](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TaskDescription] [nvarchar](max) NOT NULL,
	[UserId] [int] NULL,
	[CreatedDateandTime] [datetime] NOT NULL,
	[CreatedUser] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Task_MST] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_MST]    Script Date: 27-11-2023 17:29:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_MST](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[CreatedDateandTime] [datetime] NOT NULL,
	[CreatedUser] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblUser_MST] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkLog_TRN]    Script Date: 27-11-2023 17:29:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkLog_TRN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TaskID] [int] NOT NULL,
	[UserID] [int] NULL,
	[Days] [int] NOT NULL,
	[Hours] [int] NOT NULL,
	[Minutes] [int] NOT NULL,
	[CreatedDateandTime] [datetime] NOT NULL,
	[CreatedUser] [varchar](50) NOT NULL,
 CONSTRAINT [PK_WorkLog_TRN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Task_MST] ADD  CONSTRAINT [DF_Task_MST_CreatedDateandTime]  DEFAULT (getdate()) FOR [CreatedDateandTime]
GO
ALTER TABLE [dbo].[User_MST] ADD  CONSTRAINT [DF_User_MST_CreatedDateandTime]  DEFAULT (getdate()) FOR [CreatedDateandTime]
GO
ALTER TABLE [dbo].[WorkLog_TRN] ADD  CONSTRAINT [DF_WorkLog_TRN_Days]  DEFAULT ((0)) FOR [Days]
GO
ALTER TABLE [dbo].[WorkLog_TRN] ADD  CONSTRAINT [DF_WorkLog_TRN_CreatedDateandTime]  DEFAULT (getdate()) FOR [CreatedDateandTime]
GO
ALTER TABLE [dbo].[Task_MST]  WITH CHECK ADD  CONSTRAINT [FK_Task_MST_Task_MST] FOREIGN KEY([UserId])
REFERENCES [dbo].[User_MST] ([ID])
GO
ALTER TABLE [dbo].[Task_MST] CHECK CONSTRAINT [FK_Task_MST_Task_MST]
GO
ALTER TABLE [dbo].[WorkLog_TRN]  WITH CHECK ADD  CONSTRAINT [FK_WorkLog_TRN_Task_MST] FOREIGN KEY([TaskID])
REFERENCES [dbo].[Task_MST] ([ID])
GO
ALTER TABLE [dbo].[WorkLog_TRN] CHECK CONSTRAINT [FK_WorkLog_TRN_Task_MST]
GO
ALTER TABLE [dbo].[WorkLog_TRN]  WITH CHECK ADD  CONSTRAINT [FK_WorkLog_TRN_User_MST] FOREIGN KEY([UserID])
REFERENCES [dbo].[User_MST] ([ID])
GO
ALTER TABLE [dbo].[WorkLog_TRN] CHECK CONSTRAINT [FK_WorkLog_TRN_User_MST]
GO
/****** Object:  StoredProcedure [dbo].[GetLoggedUserTask]    Script Date: 27-11-2023 17:29:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--GetLoggedUserTask '1'
 CREATE Proc [dbo].[GetLoggedUserTask] 
(
 @UserId varchar(50),
 @FormName varchar(50) =null
)
As
Begin

if (@UserId = '')
Begin
      Raiserror('UserId is Null',16,1)
	  Return
End

Select  ROW_NUMBER() OVER(ORDER BY CreatedDateandTime) AS SLNo,
 TaskDescription,CreatedDateandTime,ID from Task_MST Where ltrim(rtrim(UserId)) = ltrim(rtrim(@UserId))
order by CreatedDateandTime 
End

GO
/****** Object:  StoredProcedure [dbo].[SaveWorkLogDetails]    Script Date: 27-11-2023 17:29:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--SaveWorkLogDetails 2,1,0,1,23
 Create Proc [dbo].[SaveWorkLogDetails] 
(
 @TaskID int,
 @UserID int,
 @Days int=0,
 @Hours int=0,
 @Minutes int=0,
 @FormName varchar(50) =null
)
As
Begin

if (@UserId = '')
Begin
      Raiserror('UserId is Null',16,1)
	  Return
End

if (@TaskID = '')
Begin
      Raiserror('TaskID is Null',16,1)
	  Return
End



INSERT INTO WorkLog_TRN(TaskID,UserID,Days,Hours,Minutes,CreatedDateandTime,CreatedUser)
  VALUES ( @TaskID,@UserID,@Days,@Hours,@Minutes,getdate(),@UserID)


END 

GO
USE [master]
GO
ALTER DATABASE [Flintech_DB] SET  READ_WRITE 
GO

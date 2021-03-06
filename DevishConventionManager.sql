USE [master]
GO
/****** Object:  Database [DevishConventionSystem]    Script Date: 1/15/2019 1:06:05 PM ******/
CREATE DATABASE [DevishConventionSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'database_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\database.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'database_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\database.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DevishConventionSystem] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DevishConventionSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DevishConventionSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DevishConventionSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DevishConventionSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DevishConventionSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DevishConventionSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DevishConventionSystem] SET  MULTI_USER 
GO
ALTER DATABASE [DevishConventionSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DevishConventionSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DevishConventionSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DevishConventionSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DevishConventionSystem] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DevishConventionSystem', N'ON'
GO
ALTER DATABASE [DevishConventionSystem] SET QUERY_STORE = OFF
GO
USE [DevishConventionSystem]
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
USE [DevishConventionSystem]
GO
/****** Object:  Table [dbo].[Attendee]    Script Date: 1/15/2019 1:06:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attendee](
	[AttendeeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](500) NULL,
	[Email] [varchar](500) NULL,
	[Password] [varchar](50) NULL,
	[TypeTicket] [varchar](50) NULL,
	[AttendDays] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Attendee] PRIMARY KEY CLUSTERED 
(
	[AttendeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AttendeePerEvent]    Script Date: 1/15/2019 1:06:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttendeePerEvent](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NOT NULL,
	[AttendeeId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.AttendeePerEvent] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AttendeePerStall]    Script Date: 1/15/2019 1:06:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttendeePerStall](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StallId] [int] NOT NULL,
	[AttendeeId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.AttendeePerStall] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AudiencePerSeminar]    Script Date: 1/15/2019 1:06:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AudiencePerSeminar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SeminarId] [int] NOT NULL,
	[AttendeeId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.AudiencePerSeminar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Event]    Script Date: 1/15/2019 1:06:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Event](
	[EventId] [int] IDENTITY(1,1) NOT NULL,
	[EventTitle] [varchar](50) NULL,
	[EventDate] [datetime] NOT NULL,
	[Duration] [int] NOT NULL,
	[EventDesc] [varchar](500) NULL,
	[RoomId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Event] PRIMARY KEY CLUSTERED 
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PresenterPerSeminar]    Script Date: 1/15/2019 1:06:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PresenterPerSeminar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SeminarId] [int] NOT NULL,
	[AttendeeId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.PresenterPerSeminar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 1/15/2019 1:06:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[RoomId] [int] IDENTITY(1,1) NOT NULL,
	[Location] [varchar](50) NULL,
	[Capacity] [int] NOT NULL,
	[Resources] [varchar](250) NULL,
 CONSTRAINT [PK_dbo.Room] PRIMARY KEY CLUSTERED 
(
	[RoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seminar]    Script Date: 1/15/2019 1:06:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seminar](
	[SeminarId] [int] IDENTITY(1,1) NOT NULL,
	[SeminarTitle] [varchar](50) NULL,
	[SeminarStartTime] [datetime] NOT NULL,
	[RoomSize] [int] NOT NULL,
	[Duration] [decimal](18, 2) NOT NULL,
	[RoomId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Seminar] PRIMARY KEY CLUSTERED 
(
	[SeminarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stall]    Script Date: 1/15/2019 1:06:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stall](
	[StallId] [int] IDENTITY(1,1) NOT NULL,
	[StallCode] [varchar](50) NULL,
	[StartingTime] [datetime] NOT NULL,
	[Duration] [int] NOT NULL,
	[StallType] [varchar](50) NULL,
	[Size] [int] NOT NULL,
	[RoomId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Stall] PRIMARY KEY CLUSTERED 
(
	[StallId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_AttendeeId]    Script Date: 1/15/2019 1:06:07 PM ******/
CREATE NONCLUSTERED INDEX [IX_AttendeeId] ON [dbo].[AttendeePerEvent]
(
	[AttendeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EventId]    Script Date: 1/15/2019 1:06:07 PM ******/
CREATE NONCLUSTERED INDEX [IX_EventId] ON [dbo].[AttendeePerEvent]
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AttendeeId]    Script Date: 1/15/2019 1:06:07 PM ******/
CREATE NONCLUSTERED INDEX [IX_AttendeeId] ON [dbo].[AttendeePerStall]
(
	[AttendeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_StallId]    Script Date: 1/15/2019 1:06:07 PM ******/
CREATE NONCLUSTERED INDEX [IX_StallId] ON [dbo].[AttendeePerStall]
(
	[StallId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AttendeeId]    Script Date: 1/15/2019 1:06:07 PM ******/
CREATE NONCLUSTERED INDEX [IX_AttendeeId] ON [dbo].[AudiencePerSeminar]
(
	[AttendeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SeminarId]    Script Date: 1/15/2019 1:06:07 PM ******/
CREATE NONCLUSTERED INDEX [IX_SeminarId] ON [dbo].[AudiencePerSeminar]
(
	[SeminarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_RoomId]    Script Date: 1/15/2019 1:06:07 PM ******/
CREATE NONCLUSTERED INDEX [IX_RoomId] ON [dbo].[Event]
(
	[RoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AttendeeId]    Script Date: 1/15/2019 1:06:07 PM ******/
CREATE NONCLUSTERED INDEX [IX_AttendeeId] ON [dbo].[PresenterPerSeminar]
(
	[AttendeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SeminarId]    Script Date: 1/15/2019 1:06:07 PM ******/
CREATE NONCLUSTERED INDEX [IX_SeminarId] ON [dbo].[PresenterPerSeminar]
(
	[SeminarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_RoomId]    Script Date: 1/15/2019 1:06:07 PM ******/
CREATE NONCLUSTERED INDEX [IX_RoomId] ON [dbo].[Seminar]
(
	[RoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_RoomId]    Script Date: 1/15/2019 1:06:07 PM ******/
CREATE NONCLUSTERED INDEX [IX_RoomId] ON [dbo].[Stall]
(
	[RoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AttendeePerEvent]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AttendeePerEvent_dbo.Attendee_AttendeeId] FOREIGN KEY([AttendeeId])
REFERENCES [dbo].[Attendee] ([AttendeeId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AttendeePerEvent] CHECK CONSTRAINT [FK_dbo.AttendeePerEvent_dbo.Attendee_AttendeeId]
GO
ALTER TABLE [dbo].[AttendeePerEvent]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AttendeePerEvent_dbo.Event_EventId] FOREIGN KEY([EventId])
REFERENCES [dbo].[Event] ([EventId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AttendeePerEvent] CHECK CONSTRAINT [FK_dbo.AttendeePerEvent_dbo.Event_EventId]
GO
ALTER TABLE [dbo].[AttendeePerStall]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AttendeePerStall_dbo.Attendee_AttendeeId] FOREIGN KEY([AttendeeId])
REFERENCES [dbo].[Attendee] ([AttendeeId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AttendeePerStall] CHECK CONSTRAINT [FK_dbo.AttendeePerStall_dbo.Attendee_AttendeeId]
GO
ALTER TABLE [dbo].[AttendeePerStall]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AttendeePerStall_dbo.Stall_StallId] FOREIGN KEY([StallId])
REFERENCES [dbo].[Stall] ([StallId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AttendeePerStall] CHECK CONSTRAINT [FK_dbo.AttendeePerStall_dbo.Stall_StallId]
GO
ALTER TABLE [dbo].[AudiencePerSeminar]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AudiencePerSeminar_dbo.Attendee_AttendeeId] FOREIGN KEY([AttendeeId])
REFERENCES [dbo].[Attendee] ([AttendeeId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AudiencePerSeminar] CHECK CONSTRAINT [FK_dbo.AudiencePerSeminar_dbo.Attendee_AttendeeId]
GO
ALTER TABLE [dbo].[AudiencePerSeminar]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AudiencePerSeminar_dbo.Seminar_SeminarId] FOREIGN KEY([SeminarId])
REFERENCES [dbo].[Seminar] ([SeminarId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AudiencePerSeminar] CHECK CONSTRAINT [FK_dbo.AudiencePerSeminar_dbo.Seminar_SeminarId]
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Event_dbo.Room_RoomId] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Room] ([RoomId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_dbo.Event_dbo.Room_RoomId]
GO
ALTER TABLE [dbo].[PresenterPerSeminar]  WITH CHECK ADD  CONSTRAINT [FK_dbo.PresenterPerSeminar_dbo.Attendee_AttendeeId] FOREIGN KEY([AttendeeId])
REFERENCES [dbo].[Attendee] ([AttendeeId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PresenterPerSeminar] CHECK CONSTRAINT [FK_dbo.PresenterPerSeminar_dbo.Attendee_AttendeeId]
GO
ALTER TABLE [dbo].[PresenterPerSeminar]  WITH CHECK ADD  CONSTRAINT [FK_dbo.PresenterPerSeminar_dbo.Seminar_SeminarId] FOREIGN KEY([SeminarId])
REFERENCES [dbo].[Seminar] ([SeminarId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PresenterPerSeminar] CHECK CONSTRAINT [FK_dbo.PresenterPerSeminar_dbo.Seminar_SeminarId]
GO
ALTER TABLE [dbo].[Seminar]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Seminar_dbo.Room_RoomId] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Room] ([RoomId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Seminar] CHECK CONSTRAINT [FK_dbo.Seminar_dbo.Room_RoomId]
GO
ALTER TABLE [dbo].[Stall]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Stall_dbo.Room_RoomId] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Room] ([RoomId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Stall] CHECK CONSTRAINT [FK_dbo.Stall_dbo.Room_RoomId]
GO
USE [master]
GO
ALTER DATABASE [DevishConventionSystem] SET  READ_WRITE 
GO
INSERT INTO Attendee VALUES ('Manager','admin@gmail.com','admin','manager',1)
GO
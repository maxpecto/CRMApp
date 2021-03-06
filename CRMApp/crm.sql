USE [musteri]
GO
/****** Object:  Table [dbo].[liste]    Script Date: 18.11.2018 19:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[liste](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Adres] [nvarchar](500) NULL,
	[Telefon] [nvarchar](50) NULL,
	[Rey] [nvarchar](4000) NULL,
	[Sexs] [nvarchar](50) NULL,
 CONSTRAINT [PK_liste] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ToDoList]    Script Date: 18.11.2018 19:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ToDoList](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ToDo] [nvarchar](500) NOT NULL,
	[FirmaId] [int] NOT NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_ToDoList] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ToDoList]  WITH CHECK ADD  CONSTRAINT [FK_ToDoList_liste] FOREIGN KEY([FirmaId])
REFERENCES [dbo].[liste] ([id])
GO
ALTER TABLE [dbo].[ToDoList] CHECK CONSTRAINT [FK_ToDoList_liste]
GO

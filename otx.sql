USE [Othod]
GO
/****** Object:  Table [dbo].[Emission]    Script Date: 08.02.2022 12:28:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emission](
	[ID_Emission] [int] NOT NULL,
	[ID_Sourse] [int] NOT NULL,
	[count] [float] NULL,
	[Text] [nchar](100) NULL,
	[date] [datetime] NULL,
 CONSTRAINT [PK_Emission] PRIMARY KEY CLUSTERED 
(
	[ID_Emission] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Source]    Script Date: 08.02.2022 12:28:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Source](
	[ID_Sourse] [int] NOT NULL,
	[Name] [nchar](50) NULL,
	[Addres] [nchar](100) NULL,
 CONSTRAINT [PK_Source] PRIMARY KEY CLUSTERED 
(
	[ID_Sourse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Emission] ([ID_Emission], [ID_Sourse], [count], [Text], [date]) VALUES (11, 1, 156.8, N'Выхлопы                                                                                             ', CAST(N'2011-06-23T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Source] ([ID_Sourse], [Name], [Addres]) VALUES (1, N'Завод Газ                                         ', N'Школьная, 8                                                                                         ')
GO
ALTER TABLE [dbo].[Emission]  WITH CHECK ADD  CONSTRAINT [FK_Emission_Source] FOREIGN KEY([ID_Sourse])
REFERENCES [dbo].[Source] ([ID_Sourse])
GO
ALTER TABLE [dbo].[Emission] CHECK CONSTRAINT [FK_Emission_Source]
GO

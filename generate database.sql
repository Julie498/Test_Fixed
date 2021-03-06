USE [Employees]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 29/05/2018 11:35:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employees](
	[Id_Employee] [char](5) NOT NULL,
	[Name_Employee] [nvarchar](50) NOT NULL,
	[Id_Office] [char](5) NOT NULL,
	[Position] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Employee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Office]    Script Date: 29/05/2018 11:35:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Office](
	[Id_Office] [char](5) NOT NULL,
	[Name_Office] [nvarchar](20) NOT NULL,
	[Manager] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Office] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Employees] ([Id_Employee], [Name_Employee], [Id_Office], [Position]) VALUES (N'NV01 ', N'Nguyễn Minh Kiên', N'P01  ', N'Trưởng Phòng')
INSERT [dbo].[Employees] ([Id_Employee], [Name_Employee], [Id_Office], [Position]) VALUES (N'NV02 ', N'Trần Thị Mỹ Ngọc', N'P02  ', N'Nhân Viên')
INSERT [dbo].[Employees] ([Id_Employee], [Name_Employee], [Id_Office], [Position]) VALUES (N'NV03 ', N'Đoàn Văn Tuấn', N'P02  ', N'Nhân Viên')
INSERT [dbo].[Employees] ([Id_Employee], [Name_Employee], [Id_Office], [Position]) VALUES (N'NV04 ', N'Lê Thị Thu Thảo', N'P02  ', N'Trưởng Phòng')
INSERT [dbo].[Employees] ([Id_Employee], [Name_Employee], [Id_Office], [Position]) VALUES (N'NV05 ', N'Nguyễn Viết Đạt', N'P01  ', N'Nhân Viên')
INSERT [dbo].[Employees] ([Id_Employee], [Name_Employee], [Id_Office], [Position]) VALUES (N'NV06 ', N'Trần Văn Hải', N'P02  ', N'Nhân Viên')
INSERT [dbo].[Office] ([Id_Office], [Name_Office], [Manager]) VALUES (N'P01  ', N'Nhân Sự', N'Nguyễn Minh Kiên')
INSERT [dbo].[Office] ([Id_Office], [Name_Office], [Manager]) VALUES (N'P02  ', N'Tài Chính', N'Lê Thị Thu Thảo')

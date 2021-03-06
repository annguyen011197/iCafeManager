USE [iCafe]
GO
/****** Object:  Table [dbo].[TableIn]    Script Date: 06/12/2018 19:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableIn](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](50) NULL,
	[TableStatus] [bit] NOT NULL,
	[IDBill] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TableIn] ON
INSERT [dbo].[TableIn] ([ID], [TableName], [TableStatus], [IDBill]) VALUES (1, N'Bàn 1', 0, 3)
INSERT [dbo].[TableIn] ([ID], [TableName], [TableStatus], [IDBill]) VALUES (2, N'Bàn 2', 0, 5)
SET IDENTITY_INSERT [dbo].[TableIn] OFF
/****** Object:  Table [dbo].[Customer]    Script Date: 06/12/2018 19:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](100) NULL,
	[Phone] [nvarchar](12) NULL,
	[CustomerAddress] [nvarchar](200) NULL,
	[Note] [nvarchar](200) NULL,
	[IDNumber] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON
INSERT [dbo].[Customer] ([ID], [CustomerName], [Phone], [CustomerAddress], [Note], [IDNumber]) VALUES (1, N'Nguyễn Trọng Đạt', N'01638197062', N'None', N'None', N'272641027')
SET IDENTITY_INSERT [dbo].[Customer] OFF
/****** Object:  Table [dbo].[Bill]    Script Date: 06/12/2018 19:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date_Check_In] [datetime] NULL,
	[Date_Check_Out] [datetime] NULL,
	[IDTable] [int] NULL,
	[Discount] [int] NULL,
	[Customer] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bill] ON
INSERT [dbo].[Bill] ([ID], [Date_Check_In], [Date_Check_Out], [IDTable], [Discount], [Customer]) VALUES (1, CAST(0x0000A8F00067864B AS DateTime), CAST(0x0000A8F000679716 AS DateTime), 1, 0, N'272641027')
INSERT [dbo].[Bill] ([ID], [Date_Check_In], [Date_Check_Out], [IDTable], [Discount], [Customer]) VALUES (2, CAST(0x0000A8F000680E24 AS DateTime), CAST(0x0000A8F000681779 AS DateTime), 1, 0, N'272641027')
INSERT [dbo].[Bill] ([ID], [Date_Check_In], [Date_Check_Out], [IDTable], [Discount], [Customer]) VALUES (3, CAST(0x0000A8F00068EC75 AS DateTime), CAST(0x0000A8F0006964EC AS DateTime), 1, 0, NULL)
INSERT [dbo].[Bill] ([ID], [Date_Check_In], [Date_Check_Out], [IDTable], [Discount], [Customer]) VALUES (4, CAST(0x0000A8F0006921F2 AS DateTime), CAST(0x0000A8F00069BAA1 AS DateTime), 2, 0, NULL)
INSERT [dbo].[Bill] ([ID], [Date_Check_In], [Date_Check_Out], [IDTable], [Discount], [Customer]) VALUES (5, CAST(0x0000A8F00069CF80 AS DateTime), CAST(0x0000A8F00069DDC0 AS DateTime), 2, 0, N'272641027')
SET IDENTITY_INSERT [dbo].[Bill] OFF
/****** Object:  Table [dbo].[Bill_Voucher]    Script Date: 06/12/2018 19:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill_Voucher](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Bill] [int] NULL,
	[ID_Voucher] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Voucher]    Script Date: 06/12/2018 19:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voucher](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Expired] [datetime] NULL,
	[VCValue] [int] NULL,
	[Type] [bit] NULL,
	[Code] [nvarchar](10) NOT NULL,
	[Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Voucher] ON
INSERT [dbo].[Voucher] ([ID], [Expired], [VCValue], [Type], [Code], [Status]) VALUES (1, CAST(0x0000A97700000000 AS DateTime), 15, 0, N'FREE10', 1)
INSERT [dbo].[Voucher] ([ID], [Expired], [VCValue], [Type], [Code], [Status]) VALUES (2, CAST(0x0000A9AD00000000 AS DateTime), 20, 0, N'FREE5', 0)
INSERT [dbo].[Voucher] ([ID], [Expired], [VCValue], [Type], [Code], [Status]) VALUES (4, CAST(0x0000A8FA00000000 AS DateTime), 55, 0, N'FREE55', 0)
SET IDENTITY_INSERT [dbo].[Voucher] OFF
/****** Object:  Table [dbo].[Account_Type]    Script Date: 06/12/2018 19:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account_Type](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account_Type] ON
INSERT [dbo].[Account_Type] ([ID], [Name]) VALUES (1, N'Nhân viên')
INSERT [dbo].[Account_Type] ([ID], [Name]) VALUES (2, N'Quản lí')
SET IDENTITY_INSERT [dbo].[Account_Type] OFF
/****** Object:  Table [dbo].[Account_Info]    Script Date: 06/12/2018 19:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account_Info](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [nvarchar](50) NULL,
	[Last_Name] [nvarchar](50) NULL,
	[Birthday] [datetime] NULL,
	[Address] [nvarchar](200) NULL,
	[Phone] [nvarchar](12) NULL,
	[Note] [nvarchar](200) NULL,
	[Image] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account_Info] ON
INSERT [dbo].[Account_Info] ([ID], [First_Name], [Last_Name], [Birthday], [Address], [Phone], [Note], [Image]) VALUES (1, N'Tuan Anh', N'Le', CAST(0x0000A8F700173D9C AS DateTime), NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Account_Info] OFF
/****** Object:  Table [dbo].[Category]    Script Date: 06/12/2018 19:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CategoryName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON
INSERT [dbo].[Category] ([ID], [CategoryName]) VALUES (2, N'CAFE')
INSERT [dbo].[Category] ([ID], [CategoryName]) VALUES (1, N'Thức Ăn')
SET IDENTITY_INSERT [dbo].[Category] OFF
/****** Object:  Table [dbo].[Food]    Script Date: 06/12/2018 19:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FoodName] [nvarchar](100) NULL,
	[Price] [bigint] NULL,
	[Category] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Food] ON
INSERT [dbo].[Food] ([ID], [FoodName], [Price], [Category]) VALUES (1, N'Cơm', 10000, 1)
INSERT [dbo].[Food] ([ID], [FoodName], [Price], [Category]) VALUES (2, N'Cafe Ðá', 15000, 2)
SET IDENTITY_INSERT [dbo].[Food] OFF
/****** Object:  Table [dbo].[Bill_Info]    Script Date: 06/12/2018 19:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill_Info](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Bill] [int] NOT NULL,
	[Food] [int] NOT NULL,
	[FoodCount] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bill_Info] ON
INSERT [dbo].[Bill_Info] ([ID], [Bill], [Food], [FoodCount]) VALUES (2, 2, 1, 1)
INSERT [dbo].[Bill_Info] ([ID], [Bill], [Food], [FoodCount]) VALUES (3, 5, 1, 1)
SET IDENTITY_INSERT [dbo].[Bill_Info] OFF
/****** Object:  Table [dbo].[Customer_Voucher]    Script Date: 06/12/2018 19:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Voucher](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Customer] [nvarchar](10) NULL,
	[ID_Voucher] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 06/12/2018 19:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [varchar](30) NOT NULL,
	[Display_Name] [nvarchar](100) NULL,
	[Password] [nvarchar](100) NULL,
	[Type] [int] NULL,
	[Info] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Account] ([Username], [Display_Name], [Password], [Type], [Info]) VALUES (N'admin', N'admin', N'21232f297a57a5a743894a0e4a801fc3', 1, NULL)
INSERT [dbo].[Account] ([Username], [Display_Name], [Password], [Type], [Info]) VALUES (N'nv1', N'TuanAnh', N'e10adc3949ba59abbe56e057f20f883e', 1, 1)
/****** Object:  Check [CK__Bill_Info__FoodC__2E1BDC42]    Script Date: 06/12/2018 19:42:28 ******/
ALTER TABLE [dbo].[Bill_Info]  WITH CHECK ADD CHECK  (([FoodCount]>(0)))
GO
/****** Object:  Check [CK__Voucher__VCValue__2F10007B]    Script Date: 06/12/2018 19:42:28 ******/
ALTER TABLE [dbo].[Voucher]  WITH CHECK ADD CHECK  (([VCValue]>(0)))
GO
/****** Object:  ForeignKey [FK__Account__Info__44FF419A]    Script Date: 06/12/2018 19:42:28 ******/
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK__Account__Info__44FF419A] FOREIGN KEY([Info])
REFERENCES [dbo].[Account_Info] ([ID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK__Account__Info__44FF419A]
GO
/****** Object:  ForeignKey [FK__Account__Type__440B1D61]    Script Date: 06/12/2018 19:42:28 ******/
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK__Account__Type__440B1D61] FOREIGN KEY([Type])
REFERENCES [dbo].[Account_Type] ([ID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK__Account__Type__440B1D61]
GO
/****** Object:  ForeignKey [FK__Bill__Customer__38996AB5]    Script Date: 06/12/2018 19:42:28 ******/
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK__Bill__Customer__38996AB5] FOREIGN KEY([Customer])
REFERENCES [dbo].[Customer] ([IDNumber])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK__Bill__Customer__38996AB5]
GO
/****** Object:  ForeignKey [FK__Bill__Table__37A5467C]    Script Date: 06/12/2018 19:42:28 ******/
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK__Bill__Table__37A5467C] FOREIGN KEY([IDTable])
REFERENCES [dbo].[TableIn] ([ID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK__Bill__Table__37A5467C]
GO
/****** Object:  ForeignKey [FK__Bill_Info__Bill__3D5E1FD2]    Script Date: 06/12/2018 19:42:28 ******/
ALTER TABLE [dbo].[Bill_Info]  WITH CHECK ADD  CONSTRAINT [FK__Bill_Info__Bill__3D5E1FD2] FOREIGN KEY([Bill])
REFERENCES [dbo].[Bill] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bill_Info] CHECK CONSTRAINT [FK__Bill_Info__Bill__3D5E1FD2]
GO
/****** Object:  ForeignKey [FK__Bill_Info__Food__29572725]    Script Date: 06/12/2018 19:42:28 ******/
ALTER TABLE [dbo].[Bill_Info]  WITH CHECK ADD  CONSTRAINT [FK__Bill_Info__Food__29572725] FOREIGN KEY([Food])
REFERENCES [dbo].[Food] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bill_Info] CHECK CONSTRAINT [FK__Bill_Info__Food__29572725]
GO
/****** Object:  ForeignKey [FK__Bill_Vouc__ID_Bi__3B75D760]    Script Date: 06/12/2018 19:42:28 ******/
ALTER TABLE [dbo].[Bill_Voucher]  WITH CHECK ADD  CONSTRAINT [FK__Bill_Vouc__ID_Bi__3B75D760] FOREIGN KEY([ID_Bill])
REFERENCES [dbo].[Bill] ([ID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Bill_Voucher] CHECK CONSTRAINT [FK__Bill_Vouc__ID_Bi__3B75D760]
GO
/****** Object:  ForeignKey [FK__Customer___ID_Cu__33D4B598]    Script Date: 06/12/2018 19:42:28 ******/
ALTER TABLE [dbo].[Customer_Voucher]  WITH CHECK ADD  CONSTRAINT [FK__Customer___ID_Cu__33D4B598] FOREIGN KEY([ID_Customer])
REFERENCES [dbo].[Customer] ([IDNumber])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Customer_Voucher] CHECK CONSTRAINT [FK__Customer___ID_Cu__33D4B598]
GO
/****** Object:  ForeignKey [FK__Customer___ID_Vo__34C8D9D1]    Script Date: 06/12/2018 19:42:28 ******/
ALTER TABLE [dbo].[Customer_Voucher]  WITH CHECK ADD  CONSTRAINT [FK__Customer___ID_Vo__34C8D9D1] FOREIGN KEY([ID_Voucher])
REFERENCES [dbo].[Voucher] ([Code])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Customer_Voucher] CHECK CONSTRAINT [FK__Customer___ID_Vo__34C8D9D1]
GO
/****** Object:  ForeignKey [FK__Food__Category__267ABA7A]    Script Date: 06/12/2018 19:42:28 ******/
ALTER TABLE [dbo].[Food]  WITH CHECK ADD  CONSTRAINT [FK__Food__Category__267ABA7A] FOREIGN KEY([Category])
REFERENCES [dbo].[Category] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Food] CHECK CONSTRAINT [FK__Food__Category__267ABA7A]
GO
/****** Object:  ForeignKey [FK_TableIn_Bill]    Script Date: 06/12/2018 19:42:28 ******/
ALTER TABLE [dbo].[TableIn]  WITH CHECK ADD  CONSTRAINT [FK_TableIn_Bill] FOREIGN KEY([IDBill])
REFERENCES [dbo].[Bill] ([ID])
GO
ALTER TABLE [dbo].[TableIn] CHECK CONSTRAINT [FK_TableIn_Bill]
GO

USE [db_onlinemart]
GO
/****** Object:  Table [dbo].[tbl_categories]    Script Date: 3/2/2024 11:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_categories](
	[cat_id] [int] IDENTITY(1,1) NOT NULL,
	[cat_name] [varchar](max) NULL,
	[cat_status] [varchar](50) NULL,
	[show_menu] [int] NULL,
 CONSTRAINT [PK_tbl_categories] PRIMARY KEY CLUSTERED 
(
	[cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_products]    Script Date: 3/2/2024 11:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_products](
	[p_id] [int] IDENTITY(1,1) NOT NULL,
	[p_name] [varchar](max) NULL,
	[p_desc] [text] NULL,
	[p_price_old] [varchar](max) NOT NULL,
	[p_price] [varchar](max) NULL,
	[p_img_1] [varchar](max) NULL,
	[p_img_2] [varchar](max) NULL,
	[p_img_3] [varchar](max) NULL,
	[sub_cat_id] [int] NULL,
 CONSTRAINT [PK_tbl_products] PRIMARY KEY CLUSTERED 
(
	[p_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_sub_cat]    Script Date: 3/2/2024 11:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_sub_cat](
	[sub_cat_id] [int] IDENTITY(1,1) NOT NULL,
	[sub_cat_name] [varchar](max) NULL,
	[cat_id] [int] NULL,
	[sub_cat_status] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_sub_cat] PRIMARY KEY CLUSTERED 
(
	[sub_cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_users]    Script Date: 3/2/2024 11:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_users](
	[u_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](max) NULL,
	[email] [varchar](max) NULL,
	[pass] [varchar](max) NULL,
 CONSTRAINT [PK_tbl_users] PRIMARY KEY CLUSTERED 
(
	[u_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_categories] ON 

INSERT [dbo].[tbl_categories] ([cat_id], [cat_name], [cat_status], [show_menu]) VALUES (1, N'Kitchen', N'Active', 1)
INSERT [dbo].[tbl_categories] ([cat_id], [cat_name], [cat_status], [show_menu]) VALUES (2, N'Household', N'Active', 0)
INSERT [dbo].[tbl_categories] ([cat_id], [cat_name], [cat_status], [show_menu]) VALUES (3, N'Clothes', N'Active', 1)
INSERT [dbo].[tbl_categories] ([cat_id], [cat_name], [cat_status], [show_menu]) VALUES (4, N'Toys', N'Deactive', 1)
INSERT [dbo].[tbl_categories] ([cat_id], [cat_name], [cat_status], [show_menu]) VALUES (5, N'Sport', N'Active', 1)
SET IDENTITY_INSERT [dbo].[tbl_categories] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_products] ON 

INSERT [dbo].[tbl_products] ([p_id], [p_name], [p_desc], [p_price_old], [p_price], [p_img_1], [p_img_2], [p_img_3], [sub_cat_id]) VALUES (1, N'Glass A', N'Text Here', N'100', N'80', N'images/1.png', N'images/1.png', N'images/1.png', 6)
INSERT [dbo].[tbl_products] ([p_id], [p_name], [p_desc], [p_price_old], [p_price], [p_img_1], [p_img_2], [p_img_3], [sub_cat_id]) VALUES (3, N'Mug Abc', N'Text Here', N'200', N'180', N'images/1.png', N'images/1.png', N'images/1.png', 6)
INSERT [dbo].[tbl_products] ([p_id], [p_name], [p_desc], [p_price_old], [p_price], [p_img_1], [p_img_2], [p_img_3], [sub_cat_id]) VALUES (5, N'Plastic Plat', N'Text Here', N'250', N'200', N'images/1.png', N'images/1.png', N'images/1.png', 6)
INSERT [dbo].[tbl_products] ([p_id], [p_name], [p_desc], [p_price_old], [p_price], [p_img_1], [p_img_2], [p_img_3], [sub_cat_id]) VALUES (7, N'Bat Cricket', N'Text Here', N'500', N'450', N'images/1.png', N'images/1.png', N'images/1.png', 4)
INSERT [dbo].[tbl_products] ([p_id], [p_name], [p_desc], [p_price_old], [p_price], [p_img_1], [p_img_2], [p_img_3], [sub_cat_id]) VALUES (9, N'Tennis A', N'Text here', N'1000', N'800', N'images/1.png', N'images/1.png', N'images/1.png', 6)
INSERT [dbo].[tbl_products] ([p_id], [p_name], [p_desc], [p_price_old], [p_price], [p_img_1], [p_img_2], [p_img_3], [sub_cat_id]) VALUES (10, N'Tennis B', N'Text here', N'1000', N'800', N'images/1.png', N'images/1.png', N'images/1.png', 6)
INSERT [dbo].[tbl_products] ([p_id], [p_name], [p_desc], [p_price_old], [p_price], [p_img_1], [p_img_2], [p_img_3], [sub_cat_id]) VALUES (11, N'Tennis C', N'Text here', N'1000', N'800', N'images/1.png', N'images/1.png', N'images/1.png', 6)
INSERT [dbo].[tbl_products] ([p_id], [p_name], [p_desc], [p_price_old], [p_price], [p_img_1], [p_img_2], [p_img_3], [sub_cat_id]) VALUES (12, N'Bat A', N'Text here', N'1000', N'800', N'images/1.png', N'images/1.png', N'images/1.png', 4)
INSERT [dbo].[tbl_products] ([p_id], [p_name], [p_desc], [p_price_old], [p_price], [p_img_1], [p_img_2], [p_img_3], [sub_cat_id]) VALUES (15, N'Tennis Y', N'Text here', N'1000', N'800', N'images/1.png', N'images/1.png', N'images/1.png', 6)
SET IDENTITY_INSERT [dbo].[tbl_products] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_sub_cat] ON 

INSERT [dbo].[tbl_sub_cat] ([sub_cat_id], [sub_cat_name], [cat_id], [sub_cat_status]) VALUES (1, N'Glasss', 1, N'Active')
INSERT [dbo].[tbl_sub_cat] ([sub_cat_id], [sub_cat_name], [cat_id], [sub_cat_status]) VALUES (2, N'Mug', 1, N'Active')
INSERT [dbo].[tbl_sub_cat] ([sub_cat_id], [sub_cat_name], [cat_id], [sub_cat_status]) VALUES (3, N'Plates', 1, N'Active')
INSERT [dbo].[tbl_sub_cat] ([sub_cat_id], [sub_cat_name], [cat_id], [sub_cat_status]) VALUES (4, N'Bat', 5, N'Active')
INSERT [dbo].[tbl_sub_cat] ([sub_cat_id], [sub_cat_name], [cat_id], [sub_cat_status]) VALUES (5, N'Ball', 5, N'Active')
INSERT [dbo].[tbl_sub_cat] ([sub_cat_id], [sub_cat_name], [cat_id], [sub_cat_status]) VALUES (6, N'Tennis', 5, N'Deactive')
INSERT [dbo].[tbl_sub_cat] ([sub_cat_id], [sub_cat_name], [cat_id], [sub_cat_status]) VALUES (7, N'Doll', 4, N'Active')
INSERT [dbo].[tbl_sub_cat] ([sub_cat_id], [sub_cat_name], [cat_id], [sub_cat_status]) VALUES (8, N'T-Shirt', 3, N'Active')
SET IDENTITY_INSERT [dbo].[tbl_sub_cat] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_users] ON 

INSERT [dbo].[tbl_users] ([u_id], [name], [email], [pass]) VALUES (1, N'Ahmed', N'abcd@yahoo.com', N'123')
INSERT [dbo].[tbl_users] ([u_id], [name], [email], [pass]) VALUES (2, N'Daniyal', N'abcd1@yahoo.com', N'123')
INSERT [dbo].[tbl_users] ([u_id], [name], [email], [pass]) VALUES (3, N'ahmed', N'abcd12343@yahoo.com', N'123')
SET IDENTITY_INSERT [dbo].[tbl_users] OFF
GO
ALTER TABLE [dbo].[tbl_categories] ADD  DEFAULT ((0)) FOR [show_menu]
GO

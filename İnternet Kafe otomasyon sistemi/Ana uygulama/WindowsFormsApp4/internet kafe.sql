USE [InternetKafe]
GO
/****** Object:  Table [dbo].[hasilat_bilgileri]    Script Date: 21.10.2019 00:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hasilat_bilgileri](
	[id] [int] NOT NULL,
	[masa_no] [int] NULL,
	[acildigi_zaman] [datetime] NULL,
	[acik_kaldigi_sure] [int] NULL,
	[masa_borcu] [int] NULL,
 CONSTRAINT [PK_hasilat_bilgileri] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kullanici]    Script Date: 21.10.2019 00:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanici](
	[k_adi] [nvarchar](50) NOT NULL,
	[sifre] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[kullanici] ([k_adi], [sifre]) VALUES (N'Admin', N'Admin')

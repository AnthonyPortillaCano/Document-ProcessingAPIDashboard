USE [DocumentDB]
GO
/****** Object:  Table [dbo].[Documents]    Script Date: 17/3/2025 12:29:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PdfName] [nvarchar](255) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[Age] [int] NOT NULL,
	[Address] [nvarchar](255) NOT NULL,
	[SSN] [nvarchar](50) NOT NULL,
	[UploadedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Documents] ON 

INSERT [dbo].[Documents] ([Id], [PdfName], [FirstName], [LastName], [Age], [Address], [SSN], [UploadedAt]) VALUES (1, N'document1.pdf', N'John', N'Doe', 30, N'123 Main St', N'123-45-6789', CAST(N'2023-10-05T07:34:56.790' AS DateTime))
INSERT [dbo].[Documents] ([Id], [PdfName], [FirstName], [LastName], [Age], [Address], [SSN], [UploadedAt]) VALUES (2, N'document2.pdf', N'Jane', N'Smith', 25, N'456 Elm St', N'987-65-4321', CAST(N'2023-10-05T07:34:56.790' AS DateTime))
INSERT [dbo].[Documents] ([Id], [PdfName], [FirstName], [LastName], [Age], [Address], [SSN], [UploadedAt]) VALUES (3, N'document3.pdf', N'John', N'Doe', 30, N'123 Main St', N'123-45-6789', CAST(N'2023-10-05T07:34:56.790' AS DateTime))
INSERT [dbo].[Documents] ([Id], [PdfName], [FirstName], [LastName], [Age], [Address], [SSN], [UploadedAt]) VALUES (4, N'document2.pdf', N'Jane', N'Smith', 25, N'456 Elm St', N'987-65-4321', CAST(N'2023-10-05T07:34:56.790' AS DateTime))
INSERT [dbo].[Documents] ([Id], [PdfName], [FirstName], [LastName], [Age], [Address], [SSN], [UploadedAt]) VALUES (5, N'document3.pdf', N'John', N'Doe', 30, N'123 Main St', N'123-45-6789', CAST(N'2023-10-05T07:34:56.790' AS DateTime))
INSERT [dbo].[Documents] ([Id], [PdfName], [FirstName], [LastName], [Age], [Address], [SSN], [UploadedAt]) VALUES (6, N'document2.pdf', N'Jane', N'Smith', 25, N'456 Elm St', N'987-65-4321', CAST(N'2023-10-05T07:34:56.790' AS DateTime))
INSERT [dbo].[Documents] ([Id], [PdfName], [FirstName], [LastName], [Age], [Address], [SSN], [UploadedAt]) VALUES (7, N'document3.pdf', N'John', N'Doe', 30, N'123 Main St', N'123-45-6789', CAST(N'2023-10-05T07:34:56.790' AS DateTime))
INSERT [dbo].[Documents] ([Id], [PdfName], [FirstName], [LastName], [Age], [Address], [SSN], [UploadedAt]) VALUES (8, N'document2.pdf', N'Jane', N'Smith', 25, N'456 Elm St', N'987-65-4321', CAST(N'2023-10-05T07:34:56.790' AS DateTime))
INSERT [dbo].[Documents] ([Id], [PdfName], [FirstName], [LastName], [Age], [Address], [SSN], [UploadedAt]) VALUES (9, N'document3.pdf', N'John', N'Doe', 30, N'123 Main St', N'123-45-6789', CAST(N'2023-10-05T07:34:56.790' AS DateTime))
INSERT [dbo].[Documents] ([Id], [PdfName], [FirstName], [LastName], [Age], [Address], [SSN], [UploadedAt]) VALUES (10, N'document2.pdf', N'Jane', N'Smith', 25, N'456 Elm St', N'987-65-4321', CAST(N'2023-10-05T07:34:56.790' AS DateTime))
SET IDENTITY_INSERT [dbo].[Documents] OFF
GO
ALTER TABLE [dbo].[Documents] ADD  DEFAULT (getdate()) FOR [UploadedAt]
GO

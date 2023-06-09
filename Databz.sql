USE [Frolov_GameLauncher]
GO
/****** Object:  Table [dbo].[CartGames]    Script Date: 20.03.2023 22:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CartGames](
	[idCart] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[GameID] [int] NOT NULL,
	[Ganre] [nvarchar](max) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Game_idGame] [int] NULL,
	[User_idUser] [int] NULL,
 CONSTRAINT [PK_dbo.CartGames] PRIMARY KEY CLUSTERED 
(
	[idCart] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Developers]    Script Date: 20.03.2023 22:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Developers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userID] [int] NOT NULL,
	[userName] [nvarchar](max) NULL,
	[User_idUser] [int] NULL,
 CONSTRAINT [PK_dbo.Developers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Games]    Script Date: 20.03.2023 22:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games](
	[idGame] [int] IDENTITY(1,1) NOT NULL,
	[GameName] [nvarchar](max) NULL,
	[idDeveloper] [int] NOT NULL,
	[GameGanreID] [int] NOT NULL,
	[Ganreee] [nvarchar](max) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[countBuy] [int] NOT NULL,
	[DeveloperID_id] [int] NULL,
	[Ganre_idGanre] [int] NULL,
 CONSTRAINT [PK_dbo.Games] PRIMARY KEY CLUSTERED 
(
	[idGame] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ganres]    Script Date: 20.03.2023 22:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ganres](
	[idGanre] [int] IDENTITY(1,1) NOT NULL,
	[NameGanre] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Ganres] PRIMARY KEY CLUSTERED 
(
	[idGanre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 20.03.2023 22:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[idLog] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[userName] [nvarchar](max) NULL,
	[Date] [nvarchar](max) NULL,
	[User_idUser] [int] NULL,
 CONSTRAINT [PK_dbo.Logs] PRIMARY KEY CLUSTERED 
(
	[idLog] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LogsBalances]    Script Date: 20.03.2023 22:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogsBalances](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateE] [nvarchar](max) NULL,
	[Summ] [decimal](18, 2) NOT NULL,
	[Status] [nvarchar](max) NULL,
	[UserID] [int] NOT NULL,
	[User_idUser] [int] NULL,
 CONSTRAINT [PK_dbo.LogsBalances] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LogsGames]    Script Date: 20.03.2023 22:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogsGames](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[GameID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[NameGame] [nvarchar](max) NULL,
	[Date] [nvarchar](max) NULL,
	[Game_idGame] [int] NULL,
	[User_idUser] [int] NULL,
 CONSTRAINT [PK_dbo.LogsGames] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserGames]    Script Date: 20.03.2023 22:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGames](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[GameID] [int] NOT NULL,
	[Game_idGame] [int] NULL,
	[User_idUser] [int] NULL,
 CONSTRAINT [PK_dbo.UserGames] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 20.03.2023 22:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[idUser] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Balance] [decimal](18, 2) NULL,
 CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Developers] ON 

INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (1, 1, N'GameLauncher', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (2, 2, N'KOG games', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (3, 3, N'FromSoftware', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (4, 4, N'NeedsGames', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (5, 5, N'Motion Twin', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (6, 6, N'Hakita', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (7, 7, N'Saber Interactive', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (8, 8, N'BeamNG', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (9, 9, N'Targem Games', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (10, 10, N'Studio 397', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (11, 11, N'Amistech Games', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (12, 12, N'OVERKILL', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (13, 13, N'Bungie', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (14, 14, N'Ghost Games', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (15, 15, N'Krafton', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (16, 16, N'Bohemia Inc', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (17, 17, N'Midway Games', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (18, 18, N'miHoYo', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (19, 19, N'LandFall West', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (20, 20, N'BANDAI NAMCO', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (21, 21, N'Boneloaf', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (22, 22, N'Pine Studio', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (23, 23, N'Lucas Pope', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (24, 24, N'Acureus', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (25, 25, N'Patrick Traynor', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (26, 26, N'Jackbox Games', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (27, 27, N'Creative Assembly', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (28, 28, N'Lukazs Jakowski', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (29, 29, N'Shiro Games', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (30, 30, N'Paradox Studio', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (31, 31, N'Game Source', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (32, 32, N'2Dynamic Games', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (33, 33, N'Hopoo Games', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (34, 34, N'Nolla Games', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (35, 35, N'Mega Games', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (36, 36, N'Supergiant Games', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (37, 37, N'Electronic Arts', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (38, 38, N'RageSquid', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (39, 39, N'Perfuse Games', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (40, 40, N'Fishing Planet LLC', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (41, 41, N'Poolians', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (42, 42, N'SCS Software', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (43, 43, N'Cyanide Studio', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (44, 44, N'Dovetail Games', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (45, 45, N'Aluba Studio', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (46, 46, N'ConcernedApe', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (47, 47, N'Mojang', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (48, 48, N'Ludeon Studio', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (49, 49, N'Valve', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (50, 50, N'Coffee Stain', NULL)
INSERT [dbo].[Developers] ([id], [userID], [userName], [User_idUser]) VALUES (51, 51, N'Endnight Games', NULL)
SET IDENTITY_INSERT [dbo].[Developers] OFF
GO
SET IDENTITY_INSERT [dbo].[Games] ON 

INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (1, N'Dotz', 1, 7, N'Рогалики', CAST(0.00 AS Decimal(18, 2)), 10, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (2, N'Grand Chase', 2, 3, N'Слэшеры', CAST(0.00 AS Decimal(18, 2)), 12, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (3, N'Sekiro', 3, 3, N'Слэшеры', CAST(2000.00 AS Decimal(18, 2)), 51, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (4, N'Undecember', 4, 3, N'Слэшеры', CAST(0.00 AS Decimal(18, 2)), 43, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (5, N'Dead Cells', 5, 3, N'Слэшеры', CAST(500.00 AS Decimal(18, 2)), 29, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (6, N'ULTRAKILL', 6, 3, N'Слэшеры', CAST(465.00 AS Decimal(18, 2)), 32, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (7, N'SnowRunner', 1, 1, N'Гонки', CAST(1200.00 AS Decimal(18, 2)), 9, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (8, N'BeamNG.Drive', 8, 1, N'Гонки', CAST(465.00 AS Decimal(18, 2)), 17, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (9, N'Crossout', 9, 1, N'Гонки', CAST(0.00 AS Decimal(18, 2)), 15, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (10, N'rFactor', 10, 1, N'Гонки', CAST(569.00 AS Decimal(18, 2)), 14, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (11, N'My Summer Car', 11, 1, N'Гонки', CAST(349.00 AS Decimal(18, 2)), 12, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (12, N'Pay Day 2', 12, 2, N'Шутеры', CAST(300.00 AS Decimal(18, 2)), 1, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (13, N'Destiny 2', 13, 2, N'Шутеры', CAST(0.00 AS Decimal(18, 2)), 0, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (14, N'Deep Rock Galactic', 14, 2, N'Шутеры', CAST(799.00 AS Decimal(18, 2)), 3, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (15, N'PUBG', 15, 2, N'Шутеры', CAST(0.00 AS Decimal(18, 2)), 0, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (16, N'DayZ', 16, 2, N'Шутеры', CAST(1199.00 AS Decimal(18, 2)), 6, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (17, N'Mortal Combat X', 17, 4, N'Файтинги', CAST(2199.00 AS Decimal(18, 2)), 50, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (18, N'Honkai Impact', 18, 4, N'Файтинги', CAST(0.00 AS Decimal(18, 2)), 48, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (19, N'StickFight', 19, 4, N'Файтинги', CAST(129.00 AS Decimal(18, 2)), 41, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (20, N'TEKKEN 7', 20, 4, N'Файтинги', CAST(3699.00 AS Decimal(18, 2)), 22, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (21, N'Gang Beasts', 21, 4, N'Файтинги', CAST(419.00 AS Decimal(18, 2)), 24, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (22, N'Escape Simulator', 22, 5, N'Головоломки', CAST(550.00 AS Decimal(18, 2)), 51, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (23, N'Papers, Please', 23, 5, N'Головоломки', CAST(249.00 AS Decimal(18, 2)), 23, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (24, N'Draw & Guess', 24, 5, N'Головоломки', CAST(125.00 AS Decimal(18, 2)), 11, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (25, N'Patrick''s Parabox', 25, 5, N'Головоломки', CAST(435.00 AS Decimal(18, 2)), 18, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (26, N'The Jackbox Party', 26, 5, N'Головоломки', CAST(1100.00 AS Decimal(18, 2)), 51, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (27, N'Total War: ROME II', 27, 6, N'Стратегии', CAST(329.00 AS Decimal(18, 2)), 13, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (28, N'Age of History II', 28, 6, N'Стратегии', CAST(200.00 AS Decimal(18, 2)), 1, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (29, N'Northgard', 29, 6, N'Стратегии', CAST(1100.00 AS Decimal(18, 2)), 0, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (30, N'Stellaris', 30, 6, N'Стратегии', CAST(1300.00 AS Decimal(18, 2)), 9, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (31, N'Mahokenshi', 31, 6, N'Стратегии', CAST(880.00 AS Decimal(18, 2)), 12, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (32, N'Lumencraft', 32, 7, N'Рогалики', CAST(497.00 AS Decimal(18, 2)), 15, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (33, N'Risk of Rain 2', 33, 7, N'Рогалики', CAST(799.00 AS Decimal(18, 2)), 26, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (34, N'Noita', 34, 7, N'Рогалики', CAST(217.00 AS Decimal(18, 2)), 32, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (35, N'Stay the Spire', 35, 7, N'Рогалики', CAST(465.00 AS Decimal(18, 2)), 44, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (36, N'Hades', 36, 7, N'Рогалики', CAST(880.00 AS Decimal(18, 2)), 25, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (37, N'FIFA 23', 37, 8, N'Спортивные', CAST(2499.00 AS Decimal(18, 2)), 14, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (38, N'Descenders', 38, 8, N'Спортивные', CAST(459.00 AS Decimal(18, 2)), 34, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (39, N'Golf It!', 39, 8, N'Спортивные', CAST(199.00 AS Decimal(18, 2)), 40, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (40, N'Fishing Planet', 40, 8, N'Спортивные', CAST(0.00 AS Decimal(18, 2)), 42, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (41, N'Бильярд 2D', 41, 8, N'Спортивные', CAST(0.00 AS Decimal(18, 2)), 4, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (42, N'Euro Track Simulator', 42, 9, N'Симуляторы', CAST(949.00 AS Decimal(18, 2)), 2, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (43, N'Chef Life', 43, 9, N'Симуляторы', CAST(1100.00 AS Decimal(18, 2)), 48, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (44, N'Train Sim World', 44, 9, N'Симуляторы', CAST(725.00 AS Decimal(18, 2)), 28, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (45, N'Cyber Manhunt', 45, 9, N'Симуляторы', CAST(389.00 AS Decimal(18, 2)), 41, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (46, N'Stardew Valley', 46, 9, N'Симуляторы', CAST(299.00 AS Decimal(18, 2)), 40, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (47, N'Minecraft', 47, 10, N'Песочницы', CAST(800.00 AS Decimal(18, 2)), 39, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (48, N'RimWorld', 48, 10, N'Песочницы', CAST(789.00 AS Decimal(18, 2)), 38, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (49, N'Garry''s Mod', 49, 10, N'Песочницы', CAST(750.00 AS Decimal(18, 2)), 49, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (50, N'Dota 2', 49, 6, N'Стратегии', CAST(0.00 AS Decimal(18, 2)), 27, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (51, N'CS:GO', 49, 2, N'Шутеры', CAST(0.00 AS Decimal(18, 2)), 22, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (52, N'Team Fortress 2', 49, 2, N'Шутеры', CAST(149.00 AS Decimal(18, 2)), 23, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (53, N'Satisfactory', 50, 10, N'Песочницы', CAST(599.00 AS Decimal(18, 2)), 20, NULL, NULL)
INSERT [dbo].[Games] ([idGame], [GameName], [idDeveloper], [GameGanreID], [Ganreee], [Price], [countBuy], [DeveloperID_id], [Ganre_idGanre]) VALUES (54, N'The Forest', 51, 10, N'Песочницы', CAST(435.00 AS Decimal(18, 2)), 16, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Games] OFF
GO
SET IDENTITY_INSERT [dbo].[Ganres] ON 

INSERT [dbo].[Ganres] ([idGanre], [NameGanre]) VALUES (1, N'Гонки')
INSERT [dbo].[Ganres] ([idGanre], [NameGanre]) VALUES (2, N'Шутеры')
INSERT [dbo].[Ganres] ([idGanre], [NameGanre]) VALUES (3, N'Слэшеры')
INSERT [dbo].[Ganres] ([idGanre], [NameGanre]) VALUES (4, N'Файтинги')
INSERT [dbo].[Ganres] ([idGanre], [NameGanre]) VALUES (5, N'Головоломки')
INSERT [dbo].[Ganres] ([idGanre], [NameGanre]) VALUES (6, N'Стратегии')
INSERT [dbo].[Ganres] ([idGanre], [NameGanre]) VALUES (7, N'Рогалики')
INSERT [dbo].[Ganres] ([idGanre], [NameGanre]) VALUES (8, N'Спортивные')
INSERT [dbo].[Ganres] ([idGanre], [NameGanre]) VALUES (9, N'Симуляторы')
INSERT [dbo].[Ganres] ([idGanre], [NameGanre]) VALUES (10, N'Песочницы')
SET IDENTITY_INSERT [dbo].[Ganres] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (1, N'GameLauncher', N'gg', N'gg@g.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (2, N'KOG games', N'kog', N'kog@games.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (3, N'FromSoftware', N'fms', N'fms@f.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (4, N'NeedsGames', N'need', N'NG@games.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (5, N'Motion Twin', N'mt', N'motion@tw.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (6, N'Hakita', N'hk', N'hakita@g.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (7, N'Saber Interactive', N'sk', N'saber@intt.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (8, N'BeamNG', N'bmg', N'bmg@ng.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (9, N'Targem Games', N'tg', N'tg@games.ru', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (10, N'Studio 397', N'studio', N'st397@g.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (11, N'Amistech Games', N'amis', N'amis@tech.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (12, N'OVERKILL', N'ok', N'over@kill.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (13, N'Bungie', N'bun', N'bungie@gg.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (14, N'Ghost Games', N'gsg', N'gsg.games@i.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (15, N'Krafton', N'kf', N'kf@g.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (16, N'Bohemia Inc', N'bogem', N'bohemia@inc.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (17, N'Midway Games', N'mid', N'midway@gg.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (18, N'miHoYo', N'mihue', N'mimi@h.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (19, N'LandFall West', N'lfw', N'lfw@gg.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (20, N'BANDAI NAMCO', N'band', N'bandai@gg.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (21, N'Boneloaf', N'bonelf', N'bonelf@gg.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (22, N'Pine Studio', N'ps', N'pine@s.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (23, N'Lucas Pope', N'ls', N'lucas@p.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (24, N'Acureus', N'acc', N'acc@r.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (25, N'Patrick Traynor', N'patr', N'patrick@tr@.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (26, N'Jackbox Games', N'jack', N'jack@box.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (27, N'Creative Assembly', N'create', N'creative@asmb.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (28, N'Lukazs Jakowski', N'lucas', N'luka@z.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (29, N'Shiro Games', N'shiro', N'shiro@z.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (30, N'Paradox Studio', N'pardx', N'pardx@st.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (31, N'Game Source', N'source', N'gss@gg.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (32, N'2Dynamic Games', N'dynamicg', N'dg@games.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (33, N'Hopoo Games', N'hopoo', N'hg@games.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (34, N'Nolla Games', N'nolla', N'nolla@gs.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (35, N'Mega Games', N'mega', N'mega@games.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (36, N'Supergiant Games', N'superg', N'superg@gs.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (37, N'Electronic Arts', N'eag', N'ea@games.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (38, N'RageSquid', N'rage', N'rage@sqd.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (39, N'Perfuse Games', N'perf', N'perf@games.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (40, N'Fishing Planet LLC', N'fish', N'fish@planet.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (41, N'Poolians', N'pool', N'pool@games.ru', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (42, N'SCS Software', N'scs', N'scs@soft.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (43, N'Cyanide Studio', N'cyan', N'cyan@st.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (44, N'Dovetail Games', N'dove', N'dovtail@gg.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (45, N'Aluba Studio', N'aluba', N'aluba@gg.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (46, N'ConcernedApe', N'ape', N'conc@ape.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (47, N'Mojang', N'moj', N'mojang@mine.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (48, N'Ludeon Studio', N'lude', N'ludeon@st.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (49, N'Valve', N'valv', N'valve@help.com', CAST(100.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (50, N'Coffee Stain', N'cof', N'coffee@st.com', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Users] ([idUser], [UserName], [Password], [Email], [Balance]) VALUES (51, N'Endnight Games', N'endn', N'end@night.com', CAST(0.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
/****** Object:  Index [IX_Game_idGame]    Script Date: 20.03.2023 22:22:40 ******/
CREATE NONCLUSTERED INDEX [IX_Game_idGame] ON [dbo].[CartGames]
(
	[Game_idGame] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_idUser]    Script Date: 20.03.2023 22:22:40 ******/
CREATE NONCLUSTERED INDEX [IX_User_idUser] ON [dbo].[CartGames]
(
	[User_idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_idUser]    Script Date: 20.03.2023 22:22:40 ******/
CREATE NONCLUSTERED INDEX [IX_User_idUser] ON [dbo].[Developers]
(
	[User_idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DeveloperID_id]    Script Date: 20.03.2023 22:22:40 ******/
CREATE NONCLUSTERED INDEX [IX_DeveloperID_id] ON [dbo].[Games]
(
	[DeveloperID_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Ganre_idGanre]    Script Date: 20.03.2023 22:22:40 ******/
CREATE NONCLUSTERED INDEX [IX_Ganre_idGanre] ON [dbo].[Games]
(
	[Ganre_idGanre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_idUser]    Script Date: 20.03.2023 22:22:40 ******/
CREATE NONCLUSTERED INDEX [IX_User_idUser] ON [dbo].[Logs]
(
	[User_idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_idUser]    Script Date: 20.03.2023 22:22:40 ******/
CREATE NONCLUSTERED INDEX [IX_User_idUser] ON [dbo].[LogsBalances]
(
	[User_idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Game_idGame]    Script Date: 20.03.2023 22:22:40 ******/
CREATE NONCLUSTERED INDEX [IX_Game_idGame] ON [dbo].[LogsGames]
(
	[Game_idGame] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_idUser]    Script Date: 20.03.2023 22:22:40 ******/
CREATE NONCLUSTERED INDEX [IX_User_idUser] ON [dbo].[LogsGames]
(
	[User_idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Game_idGame]    Script Date: 20.03.2023 22:22:40 ******/
CREATE NONCLUSTERED INDEX [IX_Game_idGame] ON [dbo].[UserGames]
(
	[Game_idGame] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_idUser]    Script Date: 20.03.2023 22:22:40 ******/
CREATE NONCLUSTERED INDEX [IX_User_idUser] ON [dbo].[UserGames]
(
	[User_idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CartGames]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CartGames_dbo.Games_Game_idGame] FOREIGN KEY([Game_idGame])
REFERENCES [dbo].[Games] ([idGame])
GO
ALTER TABLE [dbo].[CartGames] CHECK CONSTRAINT [FK_dbo.CartGames_dbo.Games_Game_idGame]
GO
ALTER TABLE [dbo].[CartGames]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CartGames_dbo.Users_User_idUser] FOREIGN KEY([User_idUser])
REFERENCES [dbo].[Users] ([idUser])
GO
ALTER TABLE [dbo].[CartGames] CHECK CONSTRAINT [FK_dbo.CartGames_dbo.Users_User_idUser]
GO
ALTER TABLE [dbo].[Developers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Developers_dbo.Users_User_idUser] FOREIGN KEY([User_idUser])
REFERENCES [dbo].[Users] ([idUser])
GO
ALTER TABLE [dbo].[Developers] CHECK CONSTRAINT [FK_dbo.Developers_dbo.Users_User_idUser]
GO
ALTER TABLE [dbo].[Games]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Games_dbo.Developers_DeveloperID_id] FOREIGN KEY([DeveloperID_id])
REFERENCES [dbo].[Developers] ([id])
GO
ALTER TABLE [dbo].[Games] CHECK CONSTRAINT [FK_dbo.Games_dbo.Developers_DeveloperID_id]
GO
ALTER TABLE [dbo].[Games]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Games_dbo.Ganres_Ganre_idGanre] FOREIGN KEY([Ganre_idGanre])
REFERENCES [dbo].[Ganres] ([idGanre])
GO
ALTER TABLE [dbo].[Games] CHECK CONSTRAINT [FK_dbo.Games_dbo.Ganres_Ganre_idGanre]
GO
ALTER TABLE [dbo].[Logs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Logs_dbo.Users_User_idUser] FOREIGN KEY([User_idUser])
REFERENCES [dbo].[Users] ([idUser])
GO
ALTER TABLE [dbo].[Logs] CHECK CONSTRAINT [FK_dbo.Logs_dbo.Users_User_idUser]
GO
ALTER TABLE [dbo].[LogsBalances]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LogsBalances_dbo.Users_User_idUser] FOREIGN KEY([User_idUser])
REFERENCES [dbo].[Users] ([idUser])
GO
ALTER TABLE [dbo].[LogsBalances] CHECK CONSTRAINT [FK_dbo.LogsBalances_dbo.Users_User_idUser]
GO
ALTER TABLE [dbo].[LogsGames]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LogsGames_dbo.Games_Game_idGame] FOREIGN KEY([Game_idGame])
REFERENCES [dbo].[Games] ([idGame])
GO
ALTER TABLE [dbo].[LogsGames] CHECK CONSTRAINT [FK_dbo.LogsGames_dbo.Games_Game_idGame]
GO
ALTER TABLE [dbo].[LogsGames]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LogsGames_dbo.Users_User_idUser] FOREIGN KEY([User_idUser])
REFERENCES [dbo].[Users] ([idUser])
GO
ALTER TABLE [dbo].[LogsGames] CHECK CONSTRAINT [FK_dbo.LogsGames_dbo.Users_User_idUser]
GO
ALTER TABLE [dbo].[UserGames]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UserGames_dbo.Games_Game_idGame] FOREIGN KEY([Game_idGame])
REFERENCES [dbo].[Games] ([idGame])
GO
ALTER TABLE [dbo].[UserGames] CHECK CONSTRAINT [FK_dbo.UserGames_dbo.Games_Game_idGame]
GO
ALTER TABLE [dbo].[UserGames]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UserGames_dbo.Users_User_idUser] FOREIGN KEY([User_idUser])
REFERENCES [dbo].[Users] ([idUser])
GO
ALTER TABLE [dbo].[UserGames] CHECK CONSTRAINT [FK_dbo.UserGames_dbo.Users_User_idUser]
GO

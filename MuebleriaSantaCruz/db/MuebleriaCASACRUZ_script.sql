USE [master]
GO
/****** Object:  Database [MuebleriaCASACRUZ]    Script Date: 04/05/2016 20:23:53 ******/
CREATE DATABASE [MuebleriaCASACRUZ] ON  PRIMARY 
( NAME = N'MuebleriaCASACRUZ', FILENAME = N'C:\BD\MuebleriaCASACRUZ\MuebleriaCASACRUZ.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MuebleriaCASACRUZ_log', FILENAME = N'C:\BD\MuebleriaCASACRUZ\MuebleriaCASACRUZ_log.ldf' , SIZE = 4096KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MuebleriaCASACRUZ].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET ANSI_NULLS OFF
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET ANSI_PADDING OFF
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET ARITHABORT OFF
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET  DISABLE_BROKER
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET  READ_WRITE
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET RECOVERY FULL
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET  MULTI_USER
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [MuebleriaCASACRUZ] SET DB_CHAINING OFF
GO
USE [MuebleriaCASACRUZ]
GO
/****** Object:  User [mccruz]    Script Date: 04/05/2016 20:23:55 ******/
CREATE USER [mccruz] FOR LOGIN [mccruz] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[puestos]    Script Date: 04/05/2016 20:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[puestos](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_PUESTOS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[puestos] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[puestos] ([id], [nombre], [activo]) VALUES (1, N'Agente', 1)
INSERT [dbo].[puestos] ([id], [nombre], [activo]) VALUES (2, N'Jefe de grupo', 1)
/****** Object:  Table [dbo].[proveedores]    Script Date: 04/05/2016 20:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[proveedores](
	[id] [int] NOT NULL,
	[nombre_comercial] [varchar](100) NULL,
	[razon_social] [varchar](100) NULL,
	[nombre_contacto] [varchar](50) NULL,
	[direccion] [varchar](200) NULL,
	[telefonos] [varchar](100) NULL,
	[email] [varchar](50) NULL,
	[fecha_registro] [datetime] NULL,
	[fecha_modificacion] [datetime] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_PROVEEDORES] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[proveedores] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_2] ON [dbo].[proveedores] 
(
	[nombre_comercial] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_3] ON [dbo].[proveedores] 
(
	[razon_social] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[conceptos_pago]    Script Date: 04/05/2016 20:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[conceptos_pago](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_CONCEPTOS_PAGO] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[conceptos_pago] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[conceptos_pago] ([id], [nombre], [activo]) VALUES (1, N'Descuento por pronto pago', 1)
INSERT [dbo].[conceptos_pago] ([id], [nombre], [activo]) VALUES (2, N'Bonificaciones', 1)
/****** Object:  Table [dbo].[modulos]    Script Date: 04/05/2016 20:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[modulos](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[fecha_reg] [datetime] NULL,
	[fecha_mod] [datetime] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_MODULOS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[modulos] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[modulos] ([id], [nombre], [fecha_reg], [fecha_mod], [activo]) VALUES (1, N'Módulo de catálogos', CAST(0x0000A582011FAFF5 AS DateTime), CAST(0x0000A5820120005E AS DateTime), 1)
INSERT [dbo].[modulos] ([id], [nombre], [fecha_reg], [fecha_mod], [activo]) VALUES (2, N'Módulo de Inventarios', CAST(0x0000A58201201B34 AS DateTime), NULL, 1)
INSERT [dbo].[modulos] ([id], [nombre], [fecha_reg], [fecha_mod], [activo]) VALUES (3, N'Módulo de Ventas', CAST(0x0000A58201202FF9 AS DateTime), NULL, 1)
/****** Object:  Table [dbo].[ocupaciones]    Script Date: 04/05/2016 20:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ocupaciones](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_OCUPACIONES] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[ocupaciones] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[ocupaciones] ([id], [nombre], [activo]) VALUES (1, N'Ama de casa', 1)
INSERT [dbo].[ocupaciones] ([id], [nombre], [activo]) VALUES (2, N'Desarrollador web', 1)
/****** Object:  Table [dbo].[grupos_seguridad]    Script Date: 04/05/2016 20:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[grupos_seguridad](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[fecha_reg] [datetime] NULL,
	[fecha_mod] [datetime] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_GRUPOS_SEGURIDAD] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[grupos_seguridad] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[grupos_seguridad] ([id], [nombre], [fecha_reg], [fecha_mod], [activo]) VALUES (1, N'Super Administradores', CAST(0x0000A58201150557 AS DateTime), NULL, 1)
INSERT [dbo].[grupos_seguridad] ([id], [nombre], [fecha_reg], [fecha_mod], [activo]) VALUES (2, N'Administradores', CAST(0x0000A58201150557 AS DateTime), NULL, 1)
INSERT [dbo].[grupos_seguridad] ([id], [nombre], [fecha_reg], [fecha_mod], [activo]) VALUES (3, N'Usuario de consulta', CAST(0x0000A5820115CB12 AS DateTime), CAST(0x0000A5820118AD58 AS DateTime), 1)
/****** Object:  Table [dbo].[estados_civiles]    Script Date: 04/05/2016 20:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estados_civiles](
	[id] [int] NOT NULL,
	[nombre] [varchar](30) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_ESTADOS_CIVILES] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[estados_civiles] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[estados_civiles] ([id], [nombre], [activo]) VALUES (1, N'Soltero', 1)
INSERT [dbo].[estados_civiles] ([id], [nombre], [activo]) VALUES (2, N'Casado', 1)
INSERT [dbo].[estados_civiles] ([id], [nombre], [activo]) VALUES (3, N'Divorciado', 1)
INSERT [dbo].[estados_civiles] ([id], [nombre], [activo]) VALUES (4, N'Viudo', 1)
/****** Object:  Table [dbo].[estados]    Script Date: 04/05/2016 20:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estados](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_ESTADOS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[estados] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (1, N'Aguascalientes', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (2, N'Baja California', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (3, N'Baja California Sur', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (4, N'Campeche', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (5, N'Chiapas', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (6, N'Chihuahua', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (7, N'Ciudad de México', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (8, N'Coahuila de Zaragoza', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (9, N'Colima', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (10, N'Durango', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (11, N'Guanajuato', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (12, N'Guerrero', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (13, N'Hidalgo', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (14, N'Jalisco', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (15, N'México', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (16, N'Michoacán de Ocampo', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (17, N'Morelos', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (18, N'Nayarit', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (19, N'Nuevo León', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (20, N'Oaxaca', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (21, N'Puebla', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (22, N'Querétaro de Arteaga', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (23, N'Quintana Roo', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (24, N'San Luis Potosí', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (25, N'Sinaloa', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (26, N'Sonora', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (27, N'Tabasco', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (28, N'Tamaulipas', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (29, N'Tlaxcala', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (30, N'Veracruz de Ignacio de la Llave', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (31, N'Yucatán', 1)
INSERT [dbo].[estados] ([id], [nombre], [activo]) VALUES (32, N'Zacatecas', 1)
/****** Object:  Table [dbo].[clasificaciones_contrato]    Script Date: 04/05/2016 20:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[clasificaciones_contrato](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_CLASIFICACIONES_CONTRATO] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[clasificaciones_contrato] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[clasificaciones_contrato] ([id], [nombre], [activo]) VALUES (1, N'Sin clasificar', 1)
INSERT [dbo].[clasificaciones_contrato] ([id], [nombre], [activo]) VALUES (2, N'Bola negra', 1)
INSERT [dbo].[clasificaciones_contrato] ([id], [nombre], [activo]) VALUES (3, N'Selecto', 1)
INSERT [dbo].[clasificaciones_contrato] ([id], [nombre], [activo]) VALUES (4, N'Moroso', 1)
/****** Object:  Table [dbo].[clasificaciones_clientes]    Script Date: 04/05/2016 20:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[clasificaciones_clientes](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_CLASIFICACIONES_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[clasificaciones_clientes] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[clasificaciones_clientes] ([id], [nombre], [activo]) VALUES (1, N'Sin clasificar', 1)
INSERT [dbo].[clasificaciones_clientes] ([id], [nombre], [activo]) VALUES (2, N'Normal', 1)
INSERT [dbo].[clasificaciones_clientes] ([id], [nombre], [activo]) VALUES (3, N'Fuga', 1)
INSERT [dbo].[clasificaciones_clientes] ([id], [nombre], [activo]) VALUES (4, N'Legal', 1)
/****** Object:  Table [dbo].[lineas_productos]    Script Date: 04/05/2016 20:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[lineas_productos](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_LINEAS_PRODUCTOS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[lineas_productos] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[lineas_productos] ([id], [nombre], [activo]) VALUES (1, N'Línea tubular', 1)
INSERT [dbo].[lineas_productos] ([id], [nombre], [activo]) VALUES (2, N'Línea de madera', 1)
INSERT [dbo].[lineas_productos] ([id], [nombre], [activo]) VALUES (3, N'Linea de refrigeradores', 1)
/****** Object:  Table [dbo].[tipos_medios_comunicacion]    Script Date: 04/05/2016 20:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipos_medios_comunicacion](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_TIPOS_MEDIOS_COMUNICACION] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[tipos_medios_comunicacion] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[tipos_medios_comunicacion] ([id], [nombre], [activo]) VALUES (1, N'Teléfono', 1)
INSERT [dbo].[tipos_medios_comunicacion] ([id], [nombre], [activo]) VALUES (2, N'Celular', 1)
INSERT [dbo].[tipos_medios_comunicacion] ([id], [nombre], [activo]) VALUES (3, N'Email', 1)
/****** Object:  Table [dbo].[tipos_identificacion]    Script Date: 04/05/2016 20:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipos_identificacion](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_TIPOS_IDENTIFICACION] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[tipos_identificacion] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[tipos_identificacion] ([id], [nombre], [activo]) VALUES (1, N'Credencial de elector (IFE)', 1)
INSERT [dbo].[tipos_identificacion] ([id], [nombre], [activo]) VALUES (2, N'Acta de nacimiento', 1)
INSERT [dbo].[tipos_identificacion] ([id], [nombre], [activo]) VALUES (3, N'Cartilla militar', 1)
INSERT [dbo].[tipos_identificacion] ([id], [nombre], [activo]) VALUES (4, N'Pasaporte', 1)
INSERT [dbo].[tipos_identificacion] ([id], [nombre], [activo]) VALUES (5, N'Cedula profesional', 1)
/****** Object:  Table [dbo].[tipos_asentamientos]    Script Date: 04/05/2016 20:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipos_asentamientos](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_TIPOS_ASENTAMIENTOS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[tipos_asentamientos] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (1, N'Ranchería', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (2, N'Colonia', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (3, N'Poblado comunal', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (4, N'Ejido', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (5, N'Barrio', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (6, N'Congregación', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (7, N'Villa', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (8, N'Equipamiento', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (9, N'Ingenio', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (10, N'Pueblo', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (11, N'Ampliación', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (12, N'Fraccionamiento', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (13, N'Campamento', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (14, N'Unidad habitacional', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (15, N'Gran usuario', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (16, N'Zona industrial', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (17, N'Residencial', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (18, N'Aeropuerto', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (19, N'Conjunto habitacional', 1)
INSERT [dbo].[tipos_asentamientos] ([id], [nombre], [activo]) VALUES (20, N'Condominio', 1)
/****** Object:  Table [dbo].[sucursales]    Script Date: 04/05/2016 20:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sucursales](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_SUCURSALES] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[sucursales] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_2] ON [dbo].[sucursales] 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[sucursales] ([id], [nombre], [activo]) VALUES (1, N'La Manga (La Pera)', 1)
/****** Object:  Table [dbo].[usuarios]    Script Date: 04/05/2016 20:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [int] NOT NULL,
	[nombre_completo] [varchar](50) NULL,
	[login] [varchar](15) NULL,
	[password] [varchar](15) NULL,
	[fecha_reg] [datetime] NULL,
	[fecha_mod] [datetime] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[usuarios] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_2] ON [dbo].[usuarios] 
(
	[login] ASC,
	[password] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[usuarios] ([id], [nombre_completo], [login], [password], [fecha_reg], [fecha_mod], [activo]) VALUES (2, N'Alfredo Ovando Arévalo', N'iscalfredo81', N'iscalfredo81', CAST(0x0000A58200D6A060 AS DateTime), NULL, 1)
INSERT [dbo].[usuarios] ([id], [nombre_completo], [login], [password], [fecha_reg], [fecha_mod], [activo]) VALUES (3, N'ADMIN Muebleria CASA CRUZ', N'casacruz', N'casacruz', CAST(0x0000A58200D6A060 AS DateTime), NULL, 1)
/****** Object:  Table [dbo].[tipos_viviendas]    Script Date: 04/05/2016 20:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipos_viviendas](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_TIPOS_VIVIENDAS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[tipos_viviendas] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[tipos_viviendas] ([id], [nombre], [activo]) VALUES (1, N'Material', 1)
INSERT [dbo].[tipos_viviendas] ([id], [nombre], [activo]) VALUES (2, N'Lamina', 1)
INSERT [dbo].[tipos_viviendas] ([id], [nombre], [activo]) VALUES (3, N'Madera', 1)
INSERT [dbo].[tipos_viviendas] ([id], [nombre], [activo]) VALUES (4, N'Otros', 1)
/****** Object:  Table [dbo].[tipos_productos]    Script Date: 04/05/2016 20:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipos_productos](
	[id] [int] NOT NULL,
	[linea_producto_id] [int] NULL,
	[nombre] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_TIPOS_PRODUCTOS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[tipos_productos] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_2] ON [dbo].[tipos_productos] 
(
	[linea_producto_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[tipos_productos] ([id], [linea_producto_id], [nombre], [activo]) VALUES (1, 3, N'Refrigerador 1', 1)
INSERT [dbo].[tipos_productos] ([id], [linea_producto_id], [nombre], [activo]) VALUES (2, 2, N'Madera 1', 1)
/****** Object:  Table [dbo].[rutas]    Script Date: 04/05/2016 20:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[rutas](
	[id] [int] NOT NULL,
	[sucursal_id] [int] NULL,
	[nombre] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_RUTAS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[rutas] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_2] ON [dbo].[rutas] 
(
	[sucursal_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_3] ON [dbo].[rutas] 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[rutas] ([id], [sucursal_id], [nombre], [activo]) VALUES (1, 1, N'Ruta 1', 1)
/****** Object:  Table [dbo].[grupos_seguridad_usuarios]    Script Date: 04/05/2016 20:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grupos_seguridad_usuarios](
	[grupo_seguridad_id] [int] NOT NULL,
	[usuario_id] [int] NOT NULL,
	[fecha_reg] [datetime] NULL,
	[fecha_mod] [datetime] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_GRUPOS_SEGURIDAD_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[grupo_seguridad_id] ASC,
	[usuario_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[grupos_seguridad_usuarios] 
(
	[grupo_seguridad_id] ASC,
	[usuario_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[grupos_seguridad_modulos]    Script Date: 04/05/2016 20:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grupos_seguridad_modulos](
	[grupo_seguridad_id] [int] NOT NULL,
	[modulo_id] [int] NOT NULL,
	[fecha_reg] [datetime] NULL,
	[fecha_mod] [datetime] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_GRUPOS_SEGURIDAD_MODULOS] PRIMARY KEY CLUSTERED 
(
	[grupo_seguridad_id] ASC,
	[modulo_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[grupos_seguridad_modulos] 
(
	[grupo_seguridad_id] ASC,
	[modulo_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[municipios]    Script Date: 04/05/2016 20:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[municipios](
	[id] [int] NOT NULL,
	[estado_id] [int] NULL,
	[nombre] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_MUNICIPIOS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[municipios] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_2] ON [dbo].[municipios] 
(
	[estado_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[municipios] ([id], [estado_id], [nombre], [activo]) VALUES (1, 27, N'Balancán', 1)
INSERT [dbo].[municipios] ([id], [estado_id], [nombre], [activo]) VALUES (2, 27, N'Cárdenas', 1)
INSERT [dbo].[municipios] ([id], [estado_id], [nombre], [activo]) VALUES (3, 27, N'Centla', 1)
INSERT [dbo].[municipios] ([id], [estado_id], [nombre], [activo]) VALUES (4, 27, N'Centro', 1)
INSERT [dbo].[municipios] ([id], [estado_id], [nombre], [activo]) VALUES (5, 27, N'Comalcalco', 1)
INSERT [dbo].[municipios] ([id], [estado_id], [nombre], [activo]) VALUES (6, 27, N'Cunduacán', 1)
INSERT [dbo].[municipios] ([id], [estado_id], [nombre], [activo]) VALUES (7, 27, N'Emiliano Zapata', 1)
INSERT [dbo].[municipios] ([id], [estado_id], [nombre], [activo]) VALUES (8, 27, N'Huimanguillo', 1)
INSERT [dbo].[municipios] ([id], [estado_id], [nombre], [activo]) VALUES (9, 27, N'Jalapa', 1)
INSERT [dbo].[municipios] ([id], [estado_id], [nombre], [activo]) VALUES (10, 27, N'Jalpa de Méndez', 1)
INSERT [dbo].[municipios] ([id], [estado_id], [nombre], [activo]) VALUES (11, 27, N'Jonuta', 1)
INSERT [dbo].[municipios] ([id], [estado_id], [nombre], [activo]) VALUES (12, 27, N'Macuspana', 1)
INSERT [dbo].[municipios] ([id], [estado_id], [nombre], [activo]) VALUES (13, 27, N'Nacajuca', 1)
INSERT [dbo].[municipios] ([id], [estado_id], [nombre], [activo]) VALUES (14, 27, N'Paraíso', 1)
INSERT [dbo].[municipios] ([id], [estado_id], [nombre], [activo]) VALUES (15, 27, N'Tacotalpa', 1)
INSERT [dbo].[municipios] ([id], [estado_id], [nombre], [activo]) VALUES (16, 27, N'Teapa', 1)
INSERT [dbo].[municipios] ([id], [estado_id], [nombre], [activo]) VALUES (17, 27, N'Tenosique', 1)
/****** Object:  Table [dbo].[personas]    Script Date: 04/05/2016 20:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[personas](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[ap_paterno] [varchar](50) NULL,
	[ap_materno] [varchar](50) NULL,
	[fecha_nacimiento] [date] NULL,
	[sexo] [varchar](1) NULL,
	[estado_civil_id] [int] NULL,
	[fecha_registro] [datetime] NULL,
	[fecha_modificacion] [datetime] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_PERSONAS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[personas] 
(
	[nombre] ASC,
	[ap_paterno] ASC,
	[ap_materno] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_2] ON [dbo].[personas] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos]    Script Date: 04/05/2016 20:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[productos](
	[id] [int] NOT NULL,
	[tipo_producto_id] [int] NULL,
	[nombre] [varchar](100) NULL,
	[descripcion] [varchar](100) NULL,
	[precio_costo] [float] NULL,
	[precio_contado] [float] NULL,
	[precio_credito] [float] NULL,
	[precio_enganche] [float] NULL,
	[precio_pago_semanal] [float] NULL,
	[stock_minimo] [int] NULL,
	[stock_maximo] [int] NULL,
	[fecha_registro] [datetime] NULL,
	[fecha_modificacion] [datetime] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_PRODUCTOS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[productos] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_2] ON [dbo].[productos] 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_3] ON [dbo].[productos] 
(
	[tipo_producto_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[productos] ([id], [tipo_producto_id], [nombre], [descripcion], [precio_costo], [precio_contado], [precio_credito], [precio_enganche], [precio_pago_semanal], [stock_minimo], [stock_maximo], [fecha_registro], [fecha_modificacion], [activo]) VALUES (1, 1, N'Refrigerador bonito 1', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[productos] ([id], [tipo_producto_id], [nombre], [descripcion], [precio_costo], [precio_contado], [precio_credito], [precio_enganche], [precio_pago_semanal], [stock_minimo], [stock_maximo], [fecha_registro], [fecha_modificacion], [activo]) VALUES (2, 2, N'Ropero de madera bonito 1', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
/****** Object:  Table [dbo].[medios_comunicacion]    Script Date: 04/05/2016 20:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[medios_comunicacion](
	[id] [int] NOT NULL,
	[tipo_medio_comunicacion_id] [int] NULL,
	[persona_id] [int] NULL,
	[valor] [varchar](50) NULL,
	[fecha_registro] [datetime] NULL,
	[fecha_modificacion] [datetime] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_MEDIOS_COMUNICACION] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[medios_comunicacion] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_2] ON [dbo].[medios_comunicacion] 
(
	[persona_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 04/05/2016 20:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[clientes](
	[persona_id] [int] NOT NULL,
	[ocupacion_id] [int] NULL,
	[tipo_identificacion_id] [int] NULL,
	[numero_identificacion] [varchar](30) NULL,
	[empresa] [varchar](100) NULL,
	[nombre_conyuge] [varchar](100) NULL,
	[ocupacion_conyuge] [int] NULL,
	[fecha_registro] [datetime] NULL,
	[fecha_modificacion] [datetime] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[persona_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[clientes] 
(
	[persona_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[asentamientos]    Script Date: 04/05/2016 20:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[asentamientos](
	[id] [int] NOT NULL,
	[tipo_asentamiento_id] [int] NULL,
	[municipio_id] [int] NULL,
	[nombre] [varchar](100) NULL,
	[cp] [varchar](5) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_ASENTAMIENTOS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[asentamientos] 
(
	[cp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_2] ON [dbo].[asentamientos] 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (1, 15, 4, N'Teléfonos de México S.A. de CV', N'86006', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (2, 2, 4, N'El Recreo', N'86020', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (3, 2, 4, N'Jose Maria Pino Suárez', N'86029', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (4, 2, 4, N'Tierra Colorada', N'86029', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (5, 12, 4, N'Heriberto Kehoe Vicent', N'86030', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (6, 12, 4, N'Carrizal', N'86038', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (7, 12, 4, N'Sol Campestre', N'86039', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (8, 2, 4, N'Lidia Esther Mónica de Portilla', N'86040', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (9, 18, 4, N'Villahermosa (Cap. P. A. Carlos Rovirosa)', N'86049', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (10, 2, 4, N'Jose N Rovirosa', N'86050', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (11, 2, 4, N'Loma Linda', N'86050', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (12, 2, 4, N'Centro Delegacional 3', N'86077', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (13, 2, 4, N'Centro Delegacional 4', N'86077', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (14, 2, 4, N'Atasta', N'86100', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (15, 12, 4, N'España', N'86107', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (16, 12, 4, N'Hacienda Buena Vista', N'86126', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (17, 12, 4, N'Joyas de Buena Vista', N'86126', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (18, 12, 4, N'Manuel Andrade Díaz', N'86126', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (19, 1, 4, N'Miguel Hidalgo 2a Sección', N'86127', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (20, 12, 4, N'Vista Alegre', N'86137', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (21, 2, 4, N'18 de Marzo', N'86140', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (22, 17, 4, N'Los Robles', N'86143', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (23, 12, 4, N'El Edén', N'86153', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (24, 12, 4, N'Edén Premier', N'86153', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (25, 14, 4, N'Fovissste 2a Etapa', N'86170', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (26, 12, 4, N'Plaza Jardín', N'86170', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (27, 12, 4, N'Bugambilias', N'86180', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (28, 17, 4, N'Deportiva Residencial', N'86189', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (29, 1, 4, N'Parrilla 1a Sección', N'86195', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (30, 10, 4, N'La Manga', N'86255', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (31, 12, 4, N'3er. Milenio', N'86256', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (32, 7, 4, N'Ocuiltzapotlan', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (33, 12, 4, N'Isset', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (34, 12, 4, N'Kilómetro 15 Induvitab', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (35, 12, 4, N'Los Angeles', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (36, 12, 4, N'Real de Diamante', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (37, 10, 4, N'La Vuelta (laguna)', N'86274', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (38, 10, 4, N'2 Montes', N'86275', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (39, 1, 4, N'Medellín y Pigua 4a Secc (El Aguacate)', N'86276', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (40, 17, 4, N'La Huerta', N'86276', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (41, 12, 4, N'Las Giraldas', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (42, 12, 4, N'Alfa y Omega', N'86281', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (43, 12, 4, N'Casas Para Todos', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (44, 7, 4, N'Parrilla', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (45, 12, 4, N'Unión Hace La Fuerza', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (46, 10, 4, N'Gaviotas Sur 2a Sección', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (47, 12, 4, N'El Árbol 1ra', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (48, 1, 4, N'Corregidora Ortiz 2a Secc', N'86287', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (49, 10, 4, N'Anacleto Canabal 3a Sección', N'86287', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (50, 12, 4, N'Villa los Claustros', N'86288', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (51, 12, 4, N'Santa Bárbara', N'86288', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (52, 12, 4, N'La Venta', N'86288', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (53, 12, 4, N'27 de Octubre', N'86288', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (54, 1, 4, N'Alvarado (Colima)', N'86291', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (55, 4, 4, N'Subteniente Garcia', N'86291', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (56, 1, 4, N'Alvarado Jimbal 3a Secc', N'86292', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (57, 1, 4, N'Estanzuela 1a Secc', N'86293', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (58, 1, 4, N'Pablo L. Sidar (Guineo)', N'86295', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (59, 1, 4, N'Coronel Traconis 2a (El Zapote)', N'86296', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (60, 15, 4, N'Palacio de Gobierno Del Estado de Tabasco', N'86009', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (61, 2, 4, N'Ciudad Industrial', N'86010', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (62, 12, 4, N'Cosmos', N'86017', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (63, 2, 4, N'Lagunas', N'86019', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (64, 12, 4, N'Olmeca', N'86019', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (65, 2, 4, N'Villa de las Palmas', N'86026', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (66, 2, 4, N'Jardines de Villahermosa', N'86027', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (67, 2, 4, N'Paseos Del Usumacinta', N'86035', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (68, 12, 4, N'Galaxia', N'86035', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (69, 12, 4, N'Club de Lago', N'86035', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (70, 12, 4, N'La Gran Villa', N'86035', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (71, 12, 4, N'Las Torres', N'86039', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (72, 17, 4, N'Puerta de Hierro', N'86039', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (73, 2, 4, N'Gaviotas Norte Sector Popular', N'86067', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (74, 2, 4, N'Centro Delegacional 1', N'86077', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (75, 2, 4, N'Reforma', N'86080', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (76, 15, 4, N'DIR Gral. de Servicios Coordinados de Educación Publica', N'86086', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (77, 2, 4, N'Villa de los Trabajadores', N'86108', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (78, 2, 4, N'El Espejo 2', N'86109', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (79, 2, 4, N'Guadalupe Borja', N'86120', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (80, 12, 4, N'Islas Del Mundo', N'86126', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (81, 12, 4, N'Santa Elena', N'86126', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (82, 12, 4, N'Villa las Torres', N'86126', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (83, 12, 4, N'Edificio Del Rio Viejo', N'86127', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (84, 12, 4, N'Macuili', N'86127', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (85, 12, 4, N'Proclama', N'86127', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (86, 1, 4, N'Ixtacomitán 1ra. Sección', N'86143', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (87, 12, 4, N'San Jorge III', N'86153', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (88, 12, 4, N'San José', N'86153', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (89, 14, 4, N'Fovissste 1a Etapa', N'86180', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (90, 2, 4, N'Primero de Mayo', N'86190', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (91, 12, 4, N'Parrilla II', N'86193', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (92, 1, 4, N'Jolochero (Boca de Culebra)', N'86250', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (93, 10, 4, N'La Estancia Vieja', N'86253', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (94, 1, 4, N'Aztlán 5ta. Sección (Palomillal)', N'86255', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (95, 1, 4, N'Lomas Del Encanto', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (96, 1, 4, N'Tierra Amarilla 1a Secc', N'86272', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (97, 10, 4, N'El Novillo', N'86273', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (98, 1, 4, N'La Palma', N'86275', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (99, 10, 4, N'Boca de Guanal', N'86276', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (100, 1, 4, N'Acachapan y Colmena 7a Sección (el Agricultor)', N'86277', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (101, 10, 4, N'Boca de Aztlán', N'86278', 1)
GO
print 'Processed 100 total records'
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (102, 1, 4, N'Agraria', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (103, 1, 4, N'Gonzalez 3a Secc', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (104, 1, 4, N'Lázaro Cárdenas 1a Sección', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (105, 1, 4, N'Rio Viejo 4a Secc', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (106, 12, 4, N'Las Hadas', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (107, 12, 4, N'Américas', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (108, 12, 4, N'Los Mezquites', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (109, 1, 4, N'Rio Tinto 1a Secc', N'86283', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (110, 12, 4, N'Fovissste Kilómetro 9', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (111, 12, 4, N'Popular Manuel Silva', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (112, 10, 4, N'Anacleto Canabal 4a Sección', N'86287', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (113, 12, 4, N'Puerta Grande', N'86287', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (114, 12, 4, N'El Almendro', N'86288', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (115, 7, 4, N'Pueblo Nuevo de las Raíces', N'86289', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (116, 1, 4, N'Tumbuluschal', N'86290', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (117, 1, 4, N'Boquerón 2a Sección (El Barquillo)', N'86293', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (118, 1, 4, N'Torno Largo 2a Secc', N'86293', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (119, 12, 4, N'Bosques de Araba', N'86294', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (120, 1, 4, N'Miraflores 1a (Arroyo Grande)', N'86297', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (121, 15, 4, N'Secretaria de La Reforma Agraria', N'86008', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (122, 14, 4, N'Infonavit', N'86018', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (123, 12, 4, N'Laguna de Mecoacan', N'86019', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (124, 12, 4, N'Los Ríos', N'86035', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (125, 12, 4, N'Club Campestre', N'86037', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (126, 2, 4, N'Parque Tabasco', N'86037', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (127, 2, 4, N'Magisterial', N'86040', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (128, 15, 4, N'Secretaria de La Defensa Nacional', N'86087', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (129, 15, 4, N'Procuraduría General de Justicia', N'86088', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (130, 12, 4, N'Militar', N'86107', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (131, 1, 4, N'Rio Viejo 3a Sección', N'86127', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (132, 1, 4, N'Miguel Hidalgo 1a Sección', N'86127', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (133, 17, 4, N'Olimpo', N'86127', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (134, 2, 4, N'Miguel Hidalgo', N'86128', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (135, 14, 4, N'Artesanos Infonavit', N'86130', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (136, 1, 4, N'Miguel Hidalgo 5a Sección', N'86143', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (137, 12, 4, N'Plaza Villahermosa', N'86179', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (138, 12, 4, N'Marcos Buendia', N'86190', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (139, 2, 4, N'La Providencia (La Majahua)', N'86193', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (140, 7, 4, N'Villa Unión', N'86250', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (141, 1, 4, N'Alambrada', N'86250', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (142, 2, 4, N'Reforma', N'86250', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (143, 12, 4, N'Lomas de Ocuiltzapotlan', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (144, 1, 4, N'Tierra Amarilla 2a Sección (El Amatón)', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (145, 1, 4, N'Ismate y Chilpilla 1a (San Antonio)', N'86274', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (146, 1, 4, N'Las Matillas 4a Secc', N'86274', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (147, 1, 4, N'Acachapan y Colmena 2da. Sección (La Arena)', N'86276', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (148, 1, 4, N'Medellin y Pigua 2a Secc', N'86276', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (149, 1, 4, N'Aztlán 1a Sección (Sector La Piedad)', N'86277', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (150, 1, 4, N'Corregidora Ortiz 5a Secc', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (151, 1, 4, N'Pablo L Sidar', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (152, 1, 4, N'Plátano y Cacao', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (153, 1, 4, N'Plátano y Cacao 1a Secc', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (154, 1, 4, N'Plátano y Cacao 2a Secc', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (155, 1, 4, N'Plátano y Cacao 3a Secc', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (156, 10, 4, N'Amaton', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (157, 1, 4, N'Buena Vista Río Nuevo 4a Sección', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (158, 12, 4, N'Real del Valle', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (159, 1, 4, N'Pablo L. Sidar (La Aurora)', N'86283', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (160, 12, 4, N'El Amate', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (161, 1, 4, N'Gaviotas Sur (El Cedral)', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (162, 1, 4, N'Las Gaviotas Sur 5a Sección (El Monal)', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (163, 12, 4, N'Residencial Lomas de Parrilla Huapinol', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (164, 12, 4, N'Santa Cecilia (los Músicos)', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (165, 12, 4, N'Santa Fe 1 2 y 3ra Sección', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (166, 1, 4, N'Corozal', N'86285', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (167, 1, 4, N'Lázaro Cárdenas 2a Sección', N'86287', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (168, 1, 4, N'Playas Del Rosario', N'86288', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (169, 12, 4, N'El Manzano', N'86289', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (170, 1, 4, N'La Agraria', N'86289', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (171, 1, 4, N'Villa Unión', N'86289', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (172, 2, 4, N'San Antonio', N'86289', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (173, 1, 4, N'Ixtacomitan 5a Sección', N'86294', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (174, 1, 4, N'Miraflores 1ra. Sección', N'86297', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (175, 2, 4, N'Centro Delegacional 6', N'86000', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (176, 2, 4, N'Triangulo Industrial', N'86010', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (177, 16, 4, N'Fideicomiso Ciudad Industrial', N'86010', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (178, 12, 4, N'La Pigua', N'86017', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (179, 12, 4, N'Insurgentes', N'86019', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (180, 2, 4, N'Framboyanes', N'86020', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (181, 2, 4, N'Las Golondrinas Priv.', N'86026', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (182, 12, 4, N'Real de Minas', N'86035', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (183, 14, 4, N'Fovissste 4a Sección Carrizal', N'86037', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (184, 14, 4, N'Fovissste 4a Etapa', N'86038', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (185, 2, 4, N'Lago Ilusiones', N'86040', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (186, 2, 4, N'Lindavista', N'86050', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (187, 12, 4, N'Brisas Del Grijalva', N'86060', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (188, 2, 4, N'La Manga III', N'86068', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (189, 12, 4, N'Cedros', N'86068', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (190, 2, 4, N'Gil y Sáenz (El Águila)', N'86080', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (191, 2, 4, N'Guayabal', N'86090', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (192, 2, 4, N'Gaviotas Sur Sección San Jose', N'86090', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (193, 12, 4, N'Bonampak', N'86127', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (194, 2, 4, N'Tamulte de las Barrancas', N'86150', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (195, 2, 4, N'Villa las Fuentes', N'86167', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (196, 12, 4, N'La Gloria', N'86170', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (197, 1, 4, N'Buena Vista 2da. Sección', N'86250', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (198, 19, 4, N'Tercer Milenio', N'86250', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (199, 1, 4, N'Aztlán 4a Sección (Chocho y Chilapilla)', N'86255', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (200, 1, 4, N'Jolochero 2da. Sección', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (201, 1, 4, N'Medellín y Madero 1a Secc', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (202, 12, 4, N'Colinas de Santo Domingo', N'86270', 1)
GO
print 'Processed 200 total records'
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (203, 1, 4, N'Ismate y Chilapilla 2a Sección (Zapotal)', N'86274', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (204, 1, 4, N'Chacte', N'86274', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (205, 1, 4, N'Las Matillas (San Antonio)', N'86274', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (206, 1, 4, N'Pajonal', N'86275', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (207, 1, 4, N'Aztlán 3a Sección (Jahuacte)', N'86278', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (208, 1, 4, N'Buena Vista Río Nuevo 1ra. Sección', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (209, 1, 4, N'Corregidora Ortiz 1a Secc', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (210, 1, 4, N'Gonzalez 2a Secc', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (211, 1, 4, N'Ixtacomitan 2a Secc', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (212, 12, 4, N'J A Sibilla Zurita', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (213, 12, 4, N'Nuevo Tabasco', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (214, 1, 4, N'Río Viejo', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (215, 1, 4, N'Corregidora Ortiz 4a Sección', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (216, 17, 4, N'Residencial Puerta Real', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (217, 1, 4, N'Acachapan y Colmena 1a Secc', N'86281', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (218, 1, 4, N'Guineo 1a Secc', N'86283', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (219, 12, 4, N'Los Gansos', N'86283', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (220, 12, 4, N'Huapinol', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (221, 12, 4, N'Infonavit Parrilla', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (222, 12, 4, N'Policía y Transito', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (223, 2, 4, N'Anacleto Canabal 1a Sección', N'86287', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (224, 1, 4, N'La Parrilla 2a Secc La Lima', N'86288', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (225, 12, 4, N'Hacienda Del Sol', N'86288', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (226, 12, 4, N'El Encanto', N'86288', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (227, 2, 4, N'Santa Rita', N'86289', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (228, 1, 4, N'Alvarado Guardacosta', N'86291', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (229, 1, 4, N'Boquerón 3a Sección (Guanal)', N'86294', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (230, 1, 4, N'Miraflores 2a Secc', N'86297', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (231, 1, 4, N'Alvarado Santa Irene 1a Sección', N'86298', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (232, 1, 4, N'La Huasteca 2a Secc', N'86298', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (233, 15, 4, N'Secretaria de Hacienda y Crédito Publico', N'86007', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (234, 2, 4, N'Interés Social 1', N'86016', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (235, 14, 4, N'Indeco Unidad', N'86017', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (236, 12, 4, N'Jardines Del Sol', N'86017', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (237, 2, 4, N'Vicente Guerrero', N'86019', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (238, 12, 4, N'Francisco Villa', N'86019', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (239, 16, 4, N'Ciudad Induistrial 2da Etapa', N'86019', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (240, 12, 4, N'Valle Marino', N'86026', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (241, 12, 4, N'Golondrinas', N'86027', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (242, 12, 4, N'La Hacienda', N'86035', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (243, 2, 4, N'Periodista', N'86059', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (244, 2, 4, N'Centro Delegacional 5', N'86073', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (245, 2, 4, N'Centro Delegacional 2', N'86077', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (246, 2, 4, N'Municipal', N'86090', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (247, 2, 4, N'Gaviotas Sur Sector Armenia', N'86099', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (248, 17, 4, N'Residencial Villas del Sol', N'86100', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (249, 12, 4, N'Flores Del Trópico', N'86105', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (250, 12, 4, N'Virginia', N'86108', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (251, 12, 4, N'Carlos A Madrazo', N'86126', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (252, 2, 4, N'Miguel Hidalgo 2a Sección', N'86127', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (253, 17, 4, N'Rio Viejo', N'86127', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (254, 2, 4, N'Cotip', N'86129', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (255, 14, 4, N'Infonavit 3a Secc', N'86139', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (256, 12, 4, N'Palma Real', N'86143', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (257, 17, 4, N'Paso Real', N'86143', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (258, 2, 4, N'Punta Brava', N'86150', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (259, 12, 4, N'Popular Pedro C Colorado', N'86153', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (260, 12, 4, N'Lomas Del Dorado', N'86153', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (261, 1, 4, N'Ixtacomitan 3a Sección', N'86153', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (262, 12, 4, N'Real Del Porvenir', N'86153', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (263, 2, 4, N'Real de Sabina', N'86153', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (264, 2, 4, N'Pino Suárez', N'86168', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (265, 2, 4, N'Pensiones', N'86169', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (266, 12, 4, N'Militar', N'86170', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (267, 12, 4, N'Residencial Esmeralda', N'86190', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (268, 7, 4, N'Macultepec', N'86250', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (269, 7, 4, N'Tamulte de las Sabanas Real', N'86250', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (270, 1, 4, N'La Ceiba', N'86250', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (271, 1, 4, N'Estancia 2a Sección', N'86253', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (272, 10, 4, N'Chilapa Margen Izquierda 1a Sección', N'86254', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (273, 1, 4, N'Buena Vista 1a Sección', N'86254', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (274, 10, 4, N'El Manguito', N'86257', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (275, 12, 4, N'Las Rosas', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (276, 1, 4, N'Medellín y Madero 3a Secc', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (277, 1, 4, N'Sabanas Nuevas', N'86274', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (278, 1, 4, N'Chiquiguao 2da. Sección (Chiquiguaíto)', N'86274', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (279, 1, 4, N'Barrancas y Guanal 2a Sección (González)', N'86276', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (280, 1, 4, N'El Zapotal', N'86276', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (281, 1, 4, N'Lagartera 2a Secc', N'86276', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (282, 1, 4, N'Aztlán 1a Secc', N'86277', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (283, 10, 4, N'Jornaleros y Aparceros Del Maluco', N'86277', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (284, 1, 4, N'Majagual Matillas', N'86277', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (285, 1, 4, N'Gonzalez 1a Secc', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (286, 1, 4, N'La Parrilla 1a Secc', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (287, 12, 4, N'Las Lomas', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (288, 12, 4, N'Hacienda Casa Blanca', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (289, 12, 4, N'Hacienda Casa Blanca II', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (290, 2, 4, N'Los Pinos', N'86281', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (291, 1, 4, N'González 4a Secc', N'86283', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (292, 1, 4, N'Río Tinto 3a Secc', N'86283', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (293, 12, 4, N'Villa Parrilla', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (294, 12, 4, N'San Manuel', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (295, 2, 4, N'Anacleto Canabal 2a Sección', N'86287', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (296, 1, 4, N'Lázaro Cárdenas 2a (21 de Marzo)', N'86287', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (297, 1, 4, N'Las Raíces', N'86289', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (298, 12, 4, N'Villa el Cielo', N'86290', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (299, 10, 4, N'Estanzuela 2a Sección', N'86293', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (300, 1, 4, N'Torno Largo 3a Secc', N'86293', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (301, 1, 4, N'Plutarco Elías Calles (La Majahua)', N'86294', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (302, 1, 4, N'Boquerón 5a Sección (La Lagartera)', N'86295', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (303, 1, 4, N'Tepate Abajo (San Isidro)', N'86295', 1)
GO
print 'Processed 300 total records'
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (304, 1, 4, N'Gaviotas Sur (El Chiflón)', N'86296', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (305, 12, 4, N'Granja Dorantes', N'86296', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (306, 1, 4, N'Barranca y Amate 2a Sección', N'86297', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (307, 1, 4, N'Miraflores 2a Secc (Zapotillo)', N'86297', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (308, 2, 4, N'Las Margaritas', N'86016', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (309, 12, 4, N'Cosmos II', N'86017', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (310, 2, 4, N'Las Torres', N'86026', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (311, 12, 4, N'Bonanza', N'86030', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (312, 12, 4, N'Nance', N'86030', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (313, 2, 4, N'Galaxia/tabasco 2000', N'86035', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (314, 12, 4, N'Multiochenta', N'86035', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (315, 12, 4, N'Villas Del Campestre', N'86035', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (316, 2, 4, N'Real de Tabasco', N'86035', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (317, 2, 4, N'El Cedro', N'86038', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (318, 2, 4, N'Loma Bonita', N'86050', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (319, 12, 4, N'Álvaro Obregón', N'86050', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (320, 2, 4, N'Casa Blanca 1a Sección', N'86060', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (321, 20, 4, N'Fovissste Casa Blanca', N'86060', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (322, 2, 4, N'La Manga II', N'86068', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (323, 2, 4, N'La Manga I', N'86069', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (324, 12, 4, N'Los Tulipanes', N'86097', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (325, 2, 4, N'Mayito', N'86098', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (326, 12, 4, N'Triunfo La Manga 3', N'86099', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (327, 2, 4, N'Jose Colomo', N'86100', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (328, 19, 4, N'Alcatraz', N'86100', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (329, 2, 4, N'El Espejo 1', N'86108', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (330, 2, 4, N'Carrizal', N'86108', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (331, 12, 4, N'La Joya', N'86109', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (332, 2, 4, N'Jose Pages Llergo', N'86125', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (333, 12, 4, N'Real Hidalgo', N'86126', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (334, 12, 4, N'Lomas de Bella Vista', N'86126', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (335, 1, 4, N'Rio Viejo 1a Sección', N'86127', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (336, 12, 4, N'La Ceiba', N'86127', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (337, 14, 4, N'Palmitas', N'86130', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (338, 14, 4, N'Infonavit 2da Secc', N'86139', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (339, 2, 4, N'Privada La Mandarina', N'86143', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (340, 2, 4, N'Sanchez Magallanes', N'86160', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (341, 2, 4, N'Plutarco Elias Calles Cura Hueso', N'86170', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (342, 2, 4, N'Santa Isabel', N'86250', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (343, 1, 4, N'Estancia 1a Sección', N'86253', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (344, 1, 4, N'Acachapan y Colmena 5a Sección', N'86255', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (345, 10, 4, N'La Arena', N'86257', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (346, 1, 4, N'Tierra Amarilla 3ra Sección', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (347, 12, 4, N'La Ceiba', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (348, 1, 4, N'Chiquiguao 1ra. Sección', N'86274', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (349, 1, 4, N'La Manga 2a Secc', N'86275', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (350, 4, 4, N'Acachapan y Colmena 2a (El Maluco)', N'86276', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (351, 1, 4, N'Acachapan y Colmena 4a Secc', N'86277', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (352, 1, 4, N'Anona y Tintillo 2a Secc', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (353, 1, 4, N'Corregidora Ortiz 3a Secc', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (354, 1, 4, N'Luis Gil Perez', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (355, 10, 4, N'Carlos A Madrazo', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (356, 1, 4, N'Platano y Cacao 4a Sección', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (357, 12, 4, N'Chichicaste', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (358, 1, 4, N'Medellin y Pigua 1a Secc', N'86281', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (359, 1, 4, N'Samarkanda', N'86281', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (360, 12, 4, N'San Ángel', N'86281', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (361, 1, 4, N'Estancia Vieja 1a Secc', N'86283', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (362, 1, 4, N'Buena Vista Río Nuevo 3a Sección', N'86283', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (363, 1, 4, N'Río Tinto 2a Secc', N'86283', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (364, 12, 4, N'Villa Floresta', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (365, 12, 4, N'El Paraíso', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (366, 12, 4, N'Jardines de Huapinol', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (367, 12, 4, N'Casa del Árbol', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (368, 12, 4, N'Logístico Industrial Tabasco', N'86287', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (369, 12, 4, N'Espinoza Galindo', N'86288', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (370, 2, 4, N'Constitución', N'86289', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (371, 10, 4, N'El Recreo', N'86289', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (372, 12, 4, N'San Vicente', N'86289', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (373, 12, 4, N'Gracias México', N'86289', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (374, 12, 4, N'Bicentenario', N'86290', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (375, 1, 4, N'Plutarco Elias Calles 3a (La Providencia)', N'86294', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (376, 1, 4, N'Coronel Traconis (Guerrero 3ra. Sección)', N'86296', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (377, 1, 4, N'Coronel Traconis 4a (San Francisco)', N'86296', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (378, 1, 4, N'Barranca y Guanal Sección (Tintillo)', N'86297', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (379, 1, 4, N'Hueso de Puerco', N'86298', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (380, 12, 4, N'Portal Del Agua', N'86000', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (381, 2, 4, N'Ciudad Industrial III', N'86015', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (382, 12, 4, N'San José', N'86019', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (383, 12, 4, N'Lagunas de San José', N'86019', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (384, 15, 4, N'Universidad Autónoma de Tabasco', N'86025', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (385, 2, 4, N'Los Caracoles', N'86029', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (386, 12, 4, N'Prados de Villahermosa', N'86030', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (387, 12, 4, N'Bosques de Villahermosa', N'86030', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (388, 17, 4, N'Villa de los Ríos', N'86035', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (389, 12, 4, N'El Country', N'86039', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (390, 17, 4, N'Residencial las Puertas', N'86039', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (391, 19, 4, N'Paseo las Palmas', N'86050', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (392, 2, 4, N'Nueva Villahermosa', N'86070', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (393, 2, 4, N'Las Brisas', N'86095', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (394, 2, 4, N'El Parque', N'86096', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (395, 2, 4, N'Triunfo la Manga I', N'86099', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (396, 12, 4, N'Brisa del Usumacinta', N'86100', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (397, 12, 4, N'Tucanes las Quintas', N'86107', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (398, 19, 4, N'Los Álamos', N'86108', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (399, 12, 4, N'Real Del Usumacinta', N'86108', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (400, 12, 4, N'Nueva Invitab', N'86126', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (401, 1, 4, N'Buena Vista', N'86126', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (402, 2, 4, N'Villa de los Arcos', N'86130', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (403, 19, 4, N'Revolución I y II', N'86140', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (404, 12, 4, N'Los Huerta Ixtacomitan', N'86143', 1)
GO
print 'Processed 400 total records'
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (405, 1, 4, N'Ixtacomitan 4a Sección', N'86144', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (406, 1, 4, N'Ixtacomitan 2a Sección', N'86144', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (407, 12, 4, N'Santa Karla II', N'86150', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (408, 12, 4, N'Real Del Angel', N'86153', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (409, 12, 4, N'América', N'86153', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (410, 2, 4, N'Del Bosque', N'86160', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (411, 12, 4, N'Real Del Sur', N'86170', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (412, 12, 4, N'Blancas Mariposas', N'86170', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (413, 12, 4, N'Loma Real', N'86170', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (414, 12, 4, N'Guadalupe', N'86180', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (415, 12, 4, N'Palmeira', N'86190', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (416, 15, 4, N'Centro Sct Tabasco', N'86191', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (417, 1, 4, N'Parrilla 2a Sección Guapinol', N'86195', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (418, 1, 4, N'Tocoal', N'86250', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (419, 1, 4, N'Estancia', N'86253', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (420, 1, 4, N'Estancia 3a Sección', N'86253', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (421, 1, 4, N'La Loma', N'86253', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (422, 1, 4, N'Miramar', N'86254', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (423, 1, 4, N'Rovirosa', N'86255', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (424, 1, 4, N'Buena Vista 3a Sección (Boca de Escoba)', N'86255', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (425, 10, 4, N'El Espino', N'86257', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (426, 1, 4, N'Lagartera', N'86271', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (427, 1, 4, N'Acachapan y Colmena 3a Secc', N'86277', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (428, 12, 4, N'Hacienda Esmeralda', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (429, 1, 4, N'Buena Vista Río Nuevo 2a Sección', N'86283', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (430, 1, 4, N'Torno Largo 1a Secc', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (431, 12, 4, N'Campestre Parrilla', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (432, 12, 4, N'Chilam Balam', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (433, 12, 4, N'Monte Líbano Km. 10.5', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (434, 12, 4, N'Juchimán', N'86284', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (435, 1, 4, N'Izmate y Chilapilla 1a Secc', N'86285', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (436, 12, 4, N'La Lima', N'86288', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (437, 2, 4, N'Revolución', N'86289', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (438, 10, 4, N'El Censo', N'86289', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (439, 4, 4, N'La Victoria', N'86290', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (440, 12, 4, N'Las Margaritas', N'86293', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (441, 1, 4, N'Pablo L Sidar', N'86294', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (442, 1, 4, N'Coronel Traconis 5a (San Rafael y San Diego)', N'86296', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (443, 1, 4, N'Barrancas y Amate 3a Secc', N'86297', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (444, 1, 4, N'Barranca y Guanal Sección (López Portillo)', N'86297', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (445, 2, 4, N'Villahermosa Centro', N'86000', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (446, 2, 4, N'El Porvenir 1a Sección', N'86016', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (447, 12, 4, N'Las Garzas', N'86017', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (448, 12, 4, N'Villa de las Flores', N'86019', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (449, 12, 4, N'Privada de Lagunas del Maurel', N'86019', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (450, 15, 4, N'Comisión Federal de Electricidad', N'86030', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (451, 12, 4, N'Oropeza', N'86030', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (452, 17, 4, N'Flamingos', N'86030', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (453, 14, 4, N'Nueva Imagen', N'86030', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (454, 15, 4, N'Palacio Municipal', N'86034', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (455, 12, 4, N'La Choca', N'86037', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (456, 2, 4, N'Adolfo Lopez Mateos', N'86040', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (457, 2, 4, N'Florida', N'86040', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (458, 2, 4, N'Jesús Garcia', N'86040', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (459, 14, 4, N'Fovissste 3a Etapa', N'86058', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (460, 2, 4, N'Casa Blanca 2a Sección', N'86060', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (461, 2, 4, N'Gaviotas Norte', N'86068', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (462, 19, 4, N'Arboledas', N'86079', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (463, 2, 4, N'Gaviotas Norte Sector Explanada', N'86090', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (464, 14, 4, N'Triunfo La Manga 2', N'86099', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (465, 1, 4, N'Miguel Hidalgo 1a Secc', N'86103', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (466, 12, 4, N'Aurora', N'86107', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (467, 12, 4, N'Villas Del Bosque', N'86109', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (468, 12, 4, N'Benito Juárez', N'86126', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (469, 1, 4, N'Rio Viejo 2a Sección', N'86127', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (470, 12, 4, N'Jardines de Buenavista', N'86127', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (471, 2, 4, N'Las Delicias', N'86140', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (472, 12, 4, N'Invitab', N'86143', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (473, 2, 4, N'Nueva Pensiones', N'86149', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (474, 12, 4, N'Jardines Del Sur I y II', N'86150', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (475, 2, 4, N'Sabina', N'86153', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (476, 12, 4, N'Real de San Jorge', N'86153', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (477, 1, 4, N'Parrilla 4a Sección los Acosta', N'86194', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (478, 1, 4, N'Encrucijada', N'86250', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (479, 10, 4, N'Aniceto', N'86250', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (480, 1, 4, N'Medellin y Madero 2a Secc', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (481, 1, 4, N'Paso Real de La Victoria', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (482, 12, 4, N'Carlos Pellicer', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (483, 1, 4, N'Medellín y Madero 4ta. Sección', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (484, 12, 4, N'Carlos Pellicer Camara 2da Etapa', N'86270', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (485, 1, 4, N'Chilapilla 2a Secc', N'86274', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (486, 1, 4, N'Las Matillas', N'86274', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (487, 1, 4, N'Ismate y Chilapilla 2a Sección (Jahuactillo)', N'86274', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (488, 1, 4, N'La Cruz del Bajío', N'86275', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (489, 1, 4, N'Lagartera 1a Secc', N'86276', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (490, 10, 4, N'Aztlán 2da. Sección el Cuy', N'86278', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (491, 1, 4, N'Medellin y Pigua 3a Secc', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (492, 12, 4, N'Ángeles Ixtacomitan', N'86280', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (493, 1, 4, N'Estancia Vieja 2a Secc', N'86283', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (494, 10, 4, N'Santa Catalina', N'86287', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (495, 12, 4, N'Las Mercedes', N'86288', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (496, 12, 4, N'Topacio', N'86288', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (497, 1, 4, N'Ribera de las Raíces', N'86289', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (498, 12, 4, N'Monteceibas', N'86289', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (499, 4, 4, N'Parrilla 5a Secc', N'86293', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (500, 1, 4, N'Boquerón (San Pedro)', N'86294', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (501, 1, 4, N'Boquerón 4a Sección (Laguna Nueva)', N'86294', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (502, 1, 4, N'Coronel Traconis 1ra Sección (La Isla)', N'86296', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (503, 1, 4, N'Miraflores 3a Secc', N'86297', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (504, 1, 4, N'La Huasteca 1a Secc', N'86298', 1)
INSERT [dbo].[asentamientos] ([id], [tipo_asentamiento_id], [municipio_id], [nombre], [cp], [activo]) VALUES (505, 2, 4, N'WEBXICO UPDATE', N'86146', 1)
GO
print 'Processed 500 total records'
/****** Object:  Table [dbo].[empleados]    Script Date: 04/05/2016 20:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleados](
	[persona_id] [int] NOT NULL,
	[puesto_id] [int] NULL,
	[fecha_laboral_inicio] [date] NULL,
	[fecha_laboral_fin] [date] NULL,
	[fecha_registro] [datetime] NULL,
	[fecha_modificacion] [datetime] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_EMPLEADOS] PRIMARY KEY CLUSTERED 
(
	[persona_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[empleados] 
(
	[persona_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[referencias]    Script Date: 04/05/2016 20:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[referencias](
	[id] [int] NOT NULL,
	[persona_id] [int] NULL,
	[nombre_completo] [varchar](100) NULL,
	[asentamiento_id] [int] NULL,
	[calle] [varchar](100) NULL,
	[numero_interior] [varchar](50) NULL,
	[numero_exterior] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[anios_conocerlo] [int] NULL,
	[parentesco] [varchar](30) NULL,
	[fecha_registro] [datetime] NULL,
	[fecha_modificacion] [datetime] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_REFERENCIAS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[referencias] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_2] ON [dbo].[referencias] 
(
	[persona_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[domicilios]    Script Date: 04/05/2016 20:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[domicilios](
	[id] [int] NOT NULL,
	[persona_id] [int] NULL,
	[asentamiento_id] [int] NULL,
	[tipo_vivienda_id] [int] NULL,
	[calle] [varchar](100) NULL,
	[numero_interior] [varchar](50) NULL,
	[numero_exterior] [varchar](50) NULL,
	[descripcion] [varchar](200) NULL,
	[fecha_registro] [datetime] NULL,
	[fecha_modificacion] [datetime] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_DOMICILIOS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [index_1] ON [dbo].[domicilios] 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_2] ON [dbo].[domicilios] 
(
	[persona_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [index_3] ON [dbo].[domicilios] 
(
	[asentamiento_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_TIPOS_PR_REFERENCE_LINEAS_P]    Script Date: 04/05/2016 20:24:10 ******/
ALTER TABLE [dbo].[tipos_productos]  WITH CHECK ADD  CONSTRAINT [FK_TIPOS_PR_REFERENCE_LINEAS_P] FOREIGN KEY([linea_producto_id])
REFERENCES [dbo].[lineas_productos] ([id])
GO
ALTER TABLE [dbo].[tipos_productos] CHECK CONSTRAINT [FK_TIPOS_PR_REFERENCE_LINEAS_P]
GO
/****** Object:  ForeignKey [FK_RUTAS_REFERENCE_SUCURSAL]    Script Date: 04/05/2016 20:24:10 ******/
ALTER TABLE [dbo].[rutas]  WITH CHECK ADD  CONSTRAINT [FK_RUTAS_REFERENCE_SUCURSAL] FOREIGN KEY([sucursal_id])
REFERENCES [dbo].[sucursales] ([id])
GO
ALTER TABLE [dbo].[rutas] CHECK CONSTRAINT [FK_RUTAS_REFERENCE_SUCURSAL]
GO
/****** Object:  ForeignKey [FK_GRUPOS_S_REFERENCE_USUARIOS]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[grupos_seguridad_usuarios]  WITH CHECK ADD  CONSTRAINT [FK_GRUPOS_S_REFERENCE_USUARIOS] FOREIGN KEY([usuario_id])
REFERENCES [dbo].[usuarios] ([id])
GO
ALTER TABLE [dbo].[grupos_seguridad_usuarios] CHECK CONSTRAINT [FK_GRUPOS_S_REFERENCE_USUARIOS]
GO
/****** Object:  ForeignKey [FK_GRUPOS_S_USUARIOS_REFERENCE_GRUPOS_SEGURIDAD]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[grupos_seguridad_usuarios]  WITH CHECK ADD  CONSTRAINT [FK_GRUPOS_S_USUARIOS_REFERENCE_GRUPOS_SEGURIDAD] FOREIGN KEY([grupo_seguridad_id])
REFERENCES [dbo].[grupos_seguridad] ([id])
GO
ALTER TABLE [dbo].[grupos_seguridad_usuarios] CHECK CONSTRAINT [FK_GRUPOS_S_USUARIOS_REFERENCE_GRUPOS_SEGURIDAD]
GO
/****** Object:  ForeignKey [FK_GRUPOS_S_MODULOS_REFERENCE_GRUPOS_SEGURIDAD]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[grupos_seguridad_modulos]  WITH CHECK ADD  CONSTRAINT [FK_GRUPOS_S_MODULOS_REFERENCE_GRUPOS_SEGURIDAD] FOREIGN KEY([grupo_seguridad_id])
REFERENCES [dbo].[grupos_seguridad] ([id])
GO
ALTER TABLE [dbo].[grupos_seguridad_modulos] CHECK CONSTRAINT [FK_GRUPOS_S_MODULOS_REFERENCE_GRUPOS_SEGURIDAD]
GO
/****** Object:  ForeignKey [FK_GRUPOS_S_REFERENCE_MODULOS]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[grupos_seguridad_modulos]  WITH CHECK ADD  CONSTRAINT [FK_GRUPOS_S_REFERENCE_MODULOS] FOREIGN KEY([modulo_id])
REFERENCES [dbo].[modulos] ([id])
GO
ALTER TABLE [dbo].[grupos_seguridad_modulos] CHECK CONSTRAINT [FK_GRUPOS_S_REFERENCE_MODULOS]
GO
/****** Object:  ForeignKey [FK_MUNICIPI_REFERENCE_ESTADOS]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[municipios]  WITH CHECK ADD  CONSTRAINT [FK_MUNICIPI_REFERENCE_ESTADOS] FOREIGN KEY([estado_id])
REFERENCES [dbo].[estados] ([id])
GO
ALTER TABLE [dbo].[municipios] CHECK CONSTRAINT [FK_MUNICIPI_REFERENCE_ESTADOS]
GO
/****** Object:  ForeignKey [FK_personas_estados_civiles]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[personas]  WITH CHECK ADD  CONSTRAINT [FK_personas_estados_civiles] FOREIGN KEY([estado_civil_id])
REFERENCES [dbo].[estados_civiles] ([id])
GO
ALTER TABLE [dbo].[personas] CHECK CONSTRAINT [FK_personas_estados_civiles]
GO
/****** Object:  ForeignKey [FK_PRODUCTO_REFERENCE_TIPOS_PR]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTO_REFERENCE_TIPOS_PR] FOREIGN KEY([tipo_producto_id])
REFERENCES [dbo].[tipos_productos] ([id])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [FK_PRODUCTO_REFERENCE_TIPOS_PR]
GO
/****** Object:  ForeignKey [FK_MEDIOS_C_REFERENCE_TIPOS_ME]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[medios_comunicacion]  WITH CHECK ADD  CONSTRAINT [FK_MEDIOS_C_REFERENCE_TIPOS_ME] FOREIGN KEY([tipo_medio_comunicacion_id])
REFERENCES [dbo].[tipos_medios_comunicacion] ([id])
GO
ALTER TABLE [dbo].[medios_comunicacion] CHECK CONSTRAINT [FK_MEDIOS_C_REFERENCE_TIPOS_ME]
GO
/****** Object:  ForeignKey [FK_medios_comunicacion_personas]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[medios_comunicacion]  WITH CHECK ADD  CONSTRAINT [FK_medios_comunicacion_personas] FOREIGN KEY([persona_id])
REFERENCES [dbo].[personas] ([id])
GO
ALTER TABLE [dbo].[medios_comunicacion] CHECK CONSTRAINT [FK_medios_comunicacion_personas]
GO
/****** Object:  ForeignKey [FK_clientes_ocupaciones]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_clientes_ocupaciones] FOREIGN KEY([ocupacion_conyuge])
REFERENCES [dbo].[ocupaciones] ([id])
GO
ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [FK_clientes_ocupaciones]
GO
/****** Object:  ForeignKey [FK_CLIENTES_REFERENCE_OCUPACIO]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTES_REFERENCE_OCUPACIO] FOREIGN KEY([ocupacion_id])
REFERENCES [dbo].[ocupaciones] ([id])
GO
ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [FK_CLIENTES_REFERENCE_OCUPACIO]
GO
/****** Object:  ForeignKey [FK_CLIENTES_REFERENCE_PERSONAS]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTES_REFERENCE_PERSONAS] FOREIGN KEY([persona_id])
REFERENCES [dbo].[personas] ([id])
GO
ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [FK_CLIENTES_REFERENCE_PERSONAS]
GO
/****** Object:  ForeignKey [FK_CLIENTES_REFERENCE_TIPOS_ID]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTES_REFERENCE_TIPOS_ID] FOREIGN KEY([tipo_identificacion_id])
REFERENCES [dbo].[tipos_identificacion] ([id])
GO
ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [FK_CLIENTES_REFERENCE_TIPOS_ID]
GO
/****** Object:  ForeignKey [FK_ASENTAMI_REFERENCE_MUNICIPI]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[asentamientos]  WITH CHECK ADD  CONSTRAINT [FK_ASENTAMI_REFERENCE_MUNICIPI] FOREIGN KEY([municipio_id])
REFERENCES [dbo].[municipios] ([id])
GO
ALTER TABLE [dbo].[asentamientos] CHECK CONSTRAINT [FK_ASENTAMI_REFERENCE_MUNICIPI]
GO
/****** Object:  ForeignKey [FK_ASENTAMI_REFERENCE_TIPOS_AS]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[asentamientos]  WITH CHECK ADD  CONSTRAINT [FK_ASENTAMI_REFERENCE_TIPOS_AS] FOREIGN KEY([tipo_asentamiento_id])
REFERENCES [dbo].[tipos_asentamientos] ([id])
GO
ALTER TABLE [dbo].[asentamientos] CHECK CONSTRAINT [FK_ASENTAMI_REFERENCE_TIPOS_AS]
GO
/****** Object:  ForeignKey [FK_EMPLEADO_REFERENCE_PERSONAS]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[empleados]  WITH CHECK ADD  CONSTRAINT [FK_EMPLEADO_REFERENCE_PERSONAS] FOREIGN KEY([persona_id])
REFERENCES [dbo].[personas] ([id])
GO
ALTER TABLE [dbo].[empleados] CHECK CONSTRAINT [FK_EMPLEADO_REFERENCE_PERSONAS]
GO
/****** Object:  ForeignKey [FK_EMPLEADO_REFERENCE_PUESTOS]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[empleados]  WITH CHECK ADD  CONSTRAINT [FK_EMPLEADO_REFERENCE_PUESTOS] FOREIGN KEY([puesto_id])
REFERENCES [dbo].[puestos] ([id])
GO
ALTER TABLE [dbo].[empleados] CHECK CONSTRAINT [FK_EMPLEADO_REFERENCE_PUESTOS]
GO
/****** Object:  ForeignKey [FK_REFERENC_REFERENCE_ASENTAMI]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[referencias]  WITH CHECK ADD  CONSTRAINT [FK_REFERENC_REFERENCE_ASENTAMI] FOREIGN KEY([asentamiento_id])
REFERENCES [dbo].[asentamientos] ([id])
GO
ALTER TABLE [dbo].[referencias] CHECK CONSTRAINT [FK_REFERENC_REFERENCE_ASENTAMI]
GO
/****** Object:  ForeignKey [FK_REFERENC_REFERENCE_PERSONAS]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[referencias]  WITH CHECK ADD  CONSTRAINT [FK_REFERENC_REFERENCE_PERSONAS] FOREIGN KEY([persona_id])
REFERENCES [dbo].[personas] ([id])
GO
ALTER TABLE [dbo].[referencias] CHECK CONSTRAINT [FK_REFERENC_REFERENCE_PERSONAS]
GO
/****** Object:  ForeignKey [FK_DOMICILI_REFERENCE_ASENTAMI]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[domicilios]  WITH CHECK ADD  CONSTRAINT [FK_DOMICILI_REFERENCE_ASENTAMI] FOREIGN KEY([asentamiento_id])
REFERENCES [dbo].[asentamientos] ([id])
GO
ALTER TABLE [dbo].[domicilios] CHECK CONSTRAINT [FK_DOMICILI_REFERENCE_ASENTAMI]
GO
/****** Object:  ForeignKey [FK_DOMICILI_REFERENCE_PERSONAS]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[domicilios]  WITH CHECK ADD  CONSTRAINT [FK_DOMICILI_REFERENCE_PERSONAS] FOREIGN KEY([persona_id])
REFERENCES [dbo].[personas] ([id])
GO
ALTER TABLE [dbo].[domicilios] CHECK CONSTRAINT [FK_DOMICILI_REFERENCE_PERSONAS]
GO
/****** Object:  ForeignKey [FK_domicilios_tipos_viviendas]    Script Date: 04/05/2016 20:24:11 ******/
ALTER TABLE [dbo].[domicilios]  WITH CHECK ADD  CONSTRAINT [FK_domicilios_tipos_viviendas] FOREIGN KEY([tipo_vivienda_id])
REFERENCES [dbo].[tipos_viviendas] ([id])
GO
ALTER TABLE [dbo].[domicilios] CHECK CONSTRAINT [FK_domicilios_tipos_viviendas]
GO

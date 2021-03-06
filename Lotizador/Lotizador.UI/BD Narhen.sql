USE [master]
GO
/****** Object:  Database [narhen]    Script Date: 10/29/2011 00:57:40 ******/
CREATE DATABASE [narhen] ON  PRIMARY 
( NAME = N'narhen', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\narhen.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'narhen_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\narhen_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [narhen] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [narhen].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [narhen] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [narhen] SET ANSI_NULLS OFF
GO
ALTER DATABASE [narhen] SET ANSI_PADDING OFF
GO
ALTER DATABASE [narhen] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [narhen] SET ARITHABORT OFF
GO
ALTER DATABASE [narhen] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [narhen] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [narhen] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [narhen] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [narhen] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [narhen] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [narhen] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [narhen] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [narhen] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [narhen] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [narhen] SET  DISABLE_BROKER
GO
ALTER DATABASE [narhen] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [narhen] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [narhen] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [narhen] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [narhen] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [narhen] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [narhen] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [narhen] SET  READ_WRITE
GO
ALTER DATABASE [narhen] SET RECOVERY FULL
GO
ALTER DATABASE [narhen] SET  MULTI_USER
GO
ALTER DATABASE [narhen] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [narhen] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'narhen', N'ON'
GO
USE [narhen]
GO
ALTER TABLE [dbo].[ListaError] DROP CONSTRAINT [DF_ListaError_Atendido]
GO
/****** Object:  ForeignKey [fkLetraIdContrato]    Script Date: 10/29/2011 00:57:49 ******/
ALTER TABLE [dbo].[Letra] DROP CONSTRAINT [fkLetraIdContrato]
GO
/****** Object:  ForeignKey [fkSocioIdTipoDocumento]    Script Date: 10/29/2011 00:57:49 ******/
ALTER TABLE [dbo].[Socio] DROP CONSTRAINT [fkSocioIdTipoDocumento]
GO
/****** Object:  ForeignKey [fkProyectoIdBanco]    Script Date: 10/29/2011 00:57:49 ******/
ALTER TABLE [dbo].[Proyecto] DROP CONSTRAINT [fkProyectoIdBanco]
GO
/****** Object:  ForeignKey [fkSecuenciaIdProyecto]    Script Date: 10/29/2011 00:57:49 ******/
ALTER TABLE [dbo].[Secuencia] DROP CONSTRAINT [fkSecuenciaIdProyecto]
GO
/****** Object:  ForeignKey [fkSecuenciaIdTipoDocumento]    Script Date: 10/29/2011 00:57:49 ******/
ALTER TABLE [dbo].[Secuencia] DROP CONSTRAINT [fkSecuenciaIdTipoDocumento]
GO
/****** Object:  ForeignKey [fkLoteIdProyecto]    Script Date: 10/29/2011 00:57:49 ******/
ALTER TABLE [dbo].[Lote] DROP CONSTRAINT [fkLoteIdProyecto]
GO
/****** Object:  ForeignKey [fkLoteIdUnidadCatastral]    Script Date: 10/29/2011 00:57:49 ******/
ALTER TABLE [dbo].[Lote] DROP CONSTRAINT [fkLoteIdUnidadCatastral]
GO
/****** Object:  ForeignKey [fkDocumentoContableIdImpuesto]    Script Date: 10/29/2011 00:57:49 ******/
ALTER TABLE [dbo].[DocumentoContable] DROP CONSTRAINT [fkDocumentoContableIdImpuesto]
GO
/****** Object:  ForeignKey [fkDocumentoContableIdSecuencia]    Script Date: 10/29/2011 00:57:49 ******/
ALTER TABLE [dbo].[DocumentoContable] DROP CONSTRAINT [fkDocumentoContableIdSecuencia]
GO
/****** Object:  StoredProcedure [dbo].[upObtenerInformacionPorContrato]    Script Date: 10/29/2011 00:57:50 ******/
DROP PROCEDURE [dbo].[upObtenerInformacionPorContrato]
GO
/****** Object:  StoredProcedure [dbo].[upObtenerLetrasPorContrato]    Script Date: 10/29/2011 00:57:50 ******/
DROP PROCEDURE [dbo].[upObtenerLetrasPorContrato]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_NumeroEnLetra]    Script Date: 10/29/2011 00:57:50 ******/
DROP FUNCTION [dbo].[Fn_NumeroEnLetra]
GO
/****** Object:  StoredProcedure [dbo].[upInsertarDocumentoContablePorLetra]    Script Date: 10/29/2011 00:57:50 ******/
DROP PROCEDURE [dbo].[upInsertarDocumentoContablePorLetra]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Millares]    Script Date: 10/29/2011 00:57:50 ******/
DROP FUNCTION [dbo].[Fn_Millares]
GO
/****** Object:  StoredProcedure [dbo].[SECUENCIA_DEL01]    Script Date: 10/29/2011 00:57:50 ******/
DROP PROCEDURE [dbo].[SECUENCIA_DEL01]
GO
/****** Object:  StoredProcedure [dbo].[SECUENCIA_GET01]    Script Date: 10/29/2011 00:57:50 ******/
DROP PROCEDURE [dbo].[SECUENCIA_GET01]
GO
/****** Object:  StoredProcedure [dbo].[SECUENCIA_GET02]    Script Date: 10/29/2011 00:57:50 ******/
DROP PROCEDURE [dbo].[SECUENCIA_GET02]
GO
/****** Object:  StoredProcedure [dbo].[SECUENCIA_INS01]    Script Date: 10/29/2011 00:57:50 ******/
DROP PROCEDURE [dbo].[SECUENCIA_INS01]
GO
/****** Object:  StoredProcedure [dbo].[SECUENCIA_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[SECUENCIA_UPD01]
GO
/****** Object:  StoredProcedure [dbo].[LOTE_DEL01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[LOTE_DEL01]
GO
/****** Object:  StoredProcedure [dbo].[LOTE_GET01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[LOTE_GET01]
GO
/****** Object:  StoredProcedure [dbo].[LOTE_GET02]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[LOTE_GET02]
GO
/****** Object:  StoredProcedure [dbo].[LOTE_INS01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[LOTE_INS01]
GO
/****** Object:  StoredProcedure [dbo].[LOTE_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[LOTE_UPD01]
GO
/****** Object:  Table [dbo].[DocumentoContable]    Script Date: 10/29/2011 00:57:49 ******/
DROP TABLE [dbo].[DocumentoContable]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_ObtenerIdSecuencia]    Script Date: 10/29/2011 00:57:49 ******/
DROP FUNCTION [dbo].[Fn_ObtenerIdSecuencia]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Centenas]    Script Date: 10/29/2011 00:57:49 ******/
DROP FUNCTION [dbo].[Fn_Centenas]
GO
/****** Object:  Table [dbo].[Lote]    Script Date: 10/29/2011 00:57:49 ******/
DROP TABLE [dbo].[Lote]
GO
/****** Object:  StoredProcedure [dbo].[upInsertarLetrasPorContrato]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[upInsertarLetrasPorContrato]
GO
/****** Object:  StoredProcedure [dbo].[PROYECTO_DEL01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[PROYECTO_DEL01]
GO
/****** Object:  StoredProcedure [dbo].[PROYECTO_GET01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[PROYECTO_GET01]
GO
/****** Object:  StoredProcedure [dbo].[PROYECTO_GET02]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[PROYECTO_GET02]
GO
/****** Object:  StoredProcedure [dbo].[PROYECTO_INS01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[PROYECTO_INS01]
GO
/****** Object:  StoredProcedure [dbo].[PROYECTO_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[PROYECTO_UPD01]
GO
/****** Object:  Table [dbo].[Secuencia]    Script Date: 10/29/2011 00:57:49 ******/
DROP TABLE [dbo].[Secuencia]
GO
/****** Object:  StoredProcedure [dbo].[SOCIO_DEL01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[SOCIO_DEL01]
GO
/****** Object:  StoredProcedure [dbo].[SOCIO_GET01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[SOCIO_GET01]
GO
/****** Object:  StoredProcedure [dbo].[SOCIO_GET02]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[SOCIO_GET02]
GO
/****** Object:  StoredProcedure [dbo].[SOCIO_INS01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[SOCIO_INS01]
GO
/****** Object:  StoredProcedure [dbo].[SOCIO_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[SOCIO_UPD01]
GO
/****** Object:  Table [dbo].[Proyecto]    Script Date: 10/29/2011 00:57:49 ******/
DROP TABLE [dbo].[Proyecto]
GO
/****** Object:  StoredProcedure [dbo].[UNIDADCATASTRAL_DEL01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[UNIDADCATASTRAL_DEL01]
GO
/****** Object:  StoredProcedure [dbo].[UNIDADCATASTRAL_GET01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[UNIDADCATASTRAL_GET01]
GO
/****** Object:  StoredProcedure [dbo].[UNIDADCATASTRAL_GET02]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[UNIDADCATASTRAL_GET02]
GO
/****** Object:  StoredProcedure [dbo].[UNIDADCATASTRAL_INS01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[UNIDADCATASTRAL_INS01]
GO
/****** Object:  StoredProcedure [dbo].[UNIDADCATASTRAL_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[UNIDADCATASTRAL_UPD01]
GO
/****** Object:  StoredProcedure [dbo].[UBIGEO_GET_DEPARTAMENTOS]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[UBIGEO_GET_DEPARTAMENTOS]
GO
/****** Object:  StoredProcedure [dbo].[UBIGEO_GET_DISTRITOS]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[UBIGEO_GET_DISTRITOS]
GO
/****** Object:  StoredProcedure [dbo].[UBIGEO_GET_PROVINCIAS]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[UBIGEO_GET_PROVINCIAS]
GO
/****** Object:  StoredProcedure [dbo].[UBIGEO_GET01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[UBIGEO_GET01]
GO
/****** Object:  StoredProcedure [dbo].[UBIGEO_GET02]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[UBIGEO_GET02]
GO
/****** Object:  Table [dbo].[Socio]    Script Date: 10/29/2011 00:57:49 ******/
DROP TABLE [dbo].[Socio]
GO
/****** Object:  StoredProcedure [dbo].[TIPODOCUMENTO_DEL01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[TIPODOCUMENTO_DEL01]
GO
/****** Object:  StoredProcedure [dbo].[TIPODOCUMENTO_GET01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[TIPODOCUMENTO_GET01]
GO
/****** Object:  StoredProcedure [dbo].[TIPODOCUMENTO_GET02]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[TIPODOCUMENTO_GET02]
GO
/****** Object:  StoredProcedure [dbo].[TIPODOCUMENTO_INS01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[TIPODOCUMENTO_INS01]
GO
/****** Object:  StoredProcedure [dbo].[TIPODOCUMENTO_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[TIPODOCUMENTO_UPD01]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_ObtenerFactorImpuesto]    Script Date: 10/29/2011 00:57:49 ******/
DROP FUNCTION [dbo].[Fn_ObtenerFactorImpuesto]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_ObtenerIdImpuesto]    Script Date: 10/29/2011 00:57:49 ******/
DROP FUNCTION [dbo].[Fn_ObtenerIdImpuesto]
GO
/****** Object:  Table [dbo].[Letra]    Script Date: 10/29/2011 00:57:49 ******/
DROP TABLE [dbo].[Letra]
GO
/****** Object:  StoredProcedure [dbo].[MONEDA_DEL01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[MONEDA_DEL01]
GO
/****** Object:  StoredProcedure [dbo].[MONEDA_GET01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[MONEDA_GET01]
GO
/****** Object:  StoredProcedure [dbo].[MONEDA_GET02]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[MONEDA_GET02]
GO
/****** Object:  StoredProcedure [dbo].[MONEDA_INS01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[MONEDA_INS01]
GO
/****** Object:  StoredProcedure [dbo].[MONEDA_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[MONEDA_UPD01]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Decenas]    Script Date: 10/29/2011 00:57:49 ******/
DROP FUNCTION [dbo].[Fn_Decenas]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_ObtenerValorImpuesto]    Script Date: 10/29/2011 00:57:49 ******/
DROP FUNCTION [dbo].[Fn_ObtenerValorImpuesto]
GO
/****** Object:  StoredProcedure [dbo].[BANCO_DEL01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[BANCO_DEL01]
GO
/****** Object:  StoredProcedure [dbo].[BANCO_GET01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[BANCO_GET01]
GO
/****** Object:  StoredProcedure [dbo].[BANCO_GET02]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[BANCO_GET02]
GO
/****** Object:  StoredProcedure [dbo].[BANCO_INS01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[BANCO_INS01]
GO
/****** Object:  StoredProcedure [dbo].[BANCO_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[BANCO_UPD01]
GO
/****** Object:  StoredProcedure [dbo].[VARIABLE_DEL01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[VARIABLE_DEL01]
GO
/****** Object:  StoredProcedure [dbo].[VARIABLE_GET01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[VARIABLE_GET01]
GO
/****** Object:  StoredProcedure [dbo].[VARIABLE_GET02]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[VARIABLE_GET02]
GO
/****** Object:  StoredProcedure [dbo].[VARIABLE_INS01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[VARIABLE_INS01]
GO
/****** Object:  StoredProcedure [dbo].[VARIABLE_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[VARIABLE_UPD01]
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_GET02]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[USUARIO_GET02]
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_INS01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[USUARIO_INS01]
GO
/****** Object:  StoredProcedure [dbo].[Usuario_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[Usuario_UPD01]
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_UPD02]    Script Date: 10/29/2011 00:57:49 ******/
DROP PROCEDURE [dbo].[USUARIO_UPD02]
GO
/****** Object:  Table [dbo].[UsuarioAcceso]    Script Date: 10/29/2011 00:57:47 ******/
DROP TABLE [dbo].[UsuarioAcceso]
GO
/****** Object:  Table [dbo].[UsuarioPerfil]    Script Date: 10/29/2011 00:57:47 ******/
DROP TABLE [dbo].[UsuarioPerfil]
GO
/****** Object:  Table [dbo].[Variable]    Script Date: 10/29/2011 00:57:47 ******/
DROP TABLE [dbo].[Variable]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 10/29/2011 00:57:47 ******/
DROP TABLE [dbo].[Usuario]
GO
/****** Object:  Table [dbo].[Contrato]    Script Date: 10/29/2011 00:57:47 ******/
DROP TABLE [dbo].[Contrato]
GO
/****** Object:  Table [dbo].[ContratoSocio]    Script Date: 10/29/2011 00:57:47 ******/
DROP TABLE [dbo].[ContratoSocio]
GO
/****** Object:  Table [dbo].[Banco]    Script Date: 10/29/2011 00:57:47 ******/
DROP TABLE [dbo].[Banco]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Unidades]    Script Date: 10/29/2011 00:57:47 ******/
DROP FUNCTION [dbo].[Fn_Unidades]
GO
/****** Object:  Table [dbo].[Impuesto]    Script Date: 10/29/2011 00:57:47 ******/
DROP TABLE [dbo].[Impuesto]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_FechaEnLetra]    Script Date: 10/29/2011 00:57:47 ******/
DROP FUNCTION [dbo].[Fn_FechaEnLetra]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_FechaEnTexto]    Script Date: 10/29/2011 00:57:47 ******/
DROP FUNCTION [dbo].[Fn_FechaEnTexto]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_IsLeapYear]    Script Date: 10/29/2011 00:57:47 ******/
DROP FUNCTION [dbo].[Fn_IsLeapYear]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 10/29/2011 00:57:43 ******/
DROP TABLE [dbo].[Perfil]
GO
/****** Object:  Table [dbo].[PerfilAcceso]    Script Date: 10/29/2011 00:57:43 ******/
DROP TABLE [dbo].[PerfilAcceso]
GO
/****** Object:  Table [dbo].[Moneda]    Script Date: 10/29/2011 00:57:43 ******/
DROP TABLE [dbo].[Moneda]
GO
/****** Object:  Table [dbo].[ListaError]    Script Date: 10/29/2011 00:57:43 ******/
DROP TABLE [dbo].[ListaError]
GO
/****** Object:  Table [dbo].[Ubigeo]    Script Date: 10/29/2011 00:57:43 ******/
DROP TABLE [dbo].[Ubigeo]
GO
/****** Object:  Table [dbo].[UnidadCatastral]    Script Date: 10/29/2011 00:57:43 ******/
DROP TABLE [dbo].[UnidadCatastral]
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 10/29/2011 00:57:43 ******/
DROP TABLE [dbo].[TipoDocumento]
GO
/****** Object:  User [SYSUSER]    Script Date: 10/29/2011 00:57:40 ******/
DROP USER [SYSUSER]
GO
/****** Object:  User [SYSUSER]    Script Date: 10/29/2011 00:57:40 ******/
CREATE USER [SYSUSER] FOR LOGIN [SYSUSER] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 10/29/2011 00:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoDocumento](
	[IdTipoDocumento] [smallint] NOT NULL,
	[CodigoTipoDocumento] [char](3) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Valorado] [char](1) NOT NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [smallint] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
 CONSTRAINT [pkTipoDocumento] PRIMARY KEY CLUSTERED 
(
	[IdTipoDocumento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TipoDocumento] ([IdTipoDocumento], [CodigoTipoDocumento], [Descripcion], [Valorado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (1, N'DNI', N'DOCUMENTO NACIONAL DE IDENTIDAD', N'N', 1, CAST(0x00009F7000000000 AS DateTime), 1, CAST(0x00009F7000000000 AS DateTime))
INSERT [dbo].[TipoDocumento] ([IdTipoDocumento], [CodigoTipoDocumento], [Descripcion], [Valorado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (2, N'RUC', N'REGISTRO UNICO DE CONTRIBUYENTE', N'N', 1, CAST(0x00009F7000000000 AS DateTime), 1, CAST(0x00009F7000000000 AS DateTime))
INSERT [dbo].[TipoDocumento] ([IdTipoDocumento], [CodigoTipoDocumento], [Descripcion], [Valorado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (3, N'FAC', N'FACTURA', N'S', 1, CAST(0x00009F7000000000 AS DateTime), 1, CAST(0x00009F7000000000 AS DateTime))
INSERT [dbo].[TipoDocumento] ([IdTipoDocumento], [CodigoTipoDocumento], [Descripcion], [Valorado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (4, N'BOL', N'BOLETA DE VENTA', N'S', 1, CAST(0x00009F7000000000 AS DateTime), 1, CAST(0x00009F7000000000 AS DateTime))
INSERT [dbo].[TipoDocumento] ([IdTipoDocumento], [CodigoTipoDocumento], [Descripcion], [Valorado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (5, N'N/C', N'NOTA DE CREDITO', N'S', 1, CAST(0x00009F7000000000 AS DateTime), 1, CAST(0x00009F7000000000 AS DateTime))
/****** Object:  Table [dbo].[UnidadCatastral]    Script Date: 10/29/2011 00:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UnidadCatastral](
	[IdUnidadCatastral] [int] NOT NULL,
	[Descripcion] [varchar](10) NOT NULL,
	[Superficie] [decimal](18, 2) NOT NULL,
	[PartidaRegistral] [varchar](12) NOT NULL,
	[RegistroPredial] [varchar](150) NOT NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [smallint] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
 CONSTRAINT [pkUnidadCatastral] PRIMARY KEY CLUSTERED 
(
	[IdUnidadCatastral] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[UnidadCatastral] ([IdUnidadCatastral], [Descripcion], [Superficie], [PartidaRegistral], [RegistroPredial], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (1, N'PRUEBA', CAST(100.00 AS Decimal(18, 2)), N'PE-000010', N'RP-XXXX', 1, CAST(0x00009F7B00000000 AS DateTime), 1, CAST(0x00009F8101440C05 AS DateTime))
INSERT [dbo].[UnidadCatastral] ([IdUnidadCatastral], [Descripcion], [Superficie], [PartidaRegistral], [RegistroPredial], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (2, N'XXX-XX', CAST(10.00 AS Decimal(18, 2)), N'KJHKJ88', N'HJGHJGBNMB', 1, CAST(0x00009F8801745BED AS DateTime), 1, CAST(0x00009F8801745BED AS DateTime))
/****** Object:  Table [dbo].[Ubigeo]    Script Date: 10/29/2011 00:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ubigeo](
	[IdUbigeo] [int] NOT NULL,
	[IdDepartamento] [smallint] NOT NULL,
	[NombreDepartamento] [varchar](150) NOT NULL,
	[IdProvincia] [smallint] NOT NULL,
	[NombreProvincia] [varchar](150) NOT NULL,
	[IdDistrito] [smallint] NOT NULL,
	[NombreDistrito] [varchar](150) NOT NULL,
 CONSTRAINT [pkUbigeo] PRIMARY KEY CLUSTERED 
(
	[IdUbigeo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 1, N'CHACHAPOYAS                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (2, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 2, N'ASUNCION                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (3, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 3, N'BALSAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (4, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 4, N'CHETO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (5, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 5, N'CHILIQUIN                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (6, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 6, N'CHUQUIBAMBA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (7, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 7, N'GRANADA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (8, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 8, N'HUANCAS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (9, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 9, N'LA JALCA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (10, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 10, N'LEIMEBAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (11, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 11, N'LEVANTO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (12, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 12, N'MAGDALENA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (13, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 13, N'MARISCAL CASTILLA             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (14, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 14, N'MOLINOPAMPA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (15, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 15, N'MONTEVIDEO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (16, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 16, N'OLLEROS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (17, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 17, N'QUINJALCA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (18, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 18, N'SAN FCO DE DAGUAS             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (19, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 19, N'SAN ISIDRO DE MAINO           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (20, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 20, N'SOLOCO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (21, 1, N'AMAZONAS       ', 1, N'CHACHAPOYAS                   ', 21, N'SONCHE                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (22, 1, N'AMAZONAS       ', 2, N'BAGUA                         ', 1, N'LA PECA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (23, 1, N'AMAZONAS       ', 2, N'BAGUA                         ', 2, N'ARAMANGO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (24, 1, N'AMAZONAS       ', 2, N'BAGUA                         ', 3, N'COPALLIN                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (25, 1, N'AMAZONAS       ', 2, N'BAGUA                         ', 4, N'EL PARCO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (26, 1, N'AMAZONAS       ', 2, N'BAGUA                         ', 6, N'IMAZA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (27, 1, N'AMAZONAS       ', 3, N'BONGARA                       ', 1, N'JUMBILLA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (28, 1, N'AMAZONAS       ', 3, N'BONGARA                       ', 2, N'COROSHA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (29, 1, N'AMAZONAS       ', 3, N'BONGARA                       ', 3, N'CUISPES                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (30, 1, N'AMAZONAS       ', 3, N'BONGARA                       ', 4, N'CHISQUILLA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (31, 1, N'AMAZONAS       ', 3, N'BONGARA                       ', 5, N'CHURUJA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (32, 1, N'AMAZONAS       ', 3, N'BONGARA                       ', 6, N'FLORIDA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (33, 1, N'AMAZONAS       ', 3, N'BONGARA                       ', 7, N'RECTA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (34, 1, N'AMAZONAS       ', 3, N'BONGARA                       ', 8, N'SAN CARLOS                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (35, 1, N'AMAZONAS       ', 3, N'BONGARA                       ', 9, N'SHIPASBAMBA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (36, 1, N'AMAZONAS       ', 3, N'BONGARA                       ', 10, N'VALERA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (37, 1, N'AMAZONAS       ', 3, N'BONGARA                       ', 11, N'YAMBRASBAMBA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (38, 1, N'AMAZONAS       ', 3, N'BONGARA                       ', 12, N'JAZAN                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (39, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 1, N'LAMUD                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (40, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 2, N'CAMPORREDONDO                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (41, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 3, N'COCABAMBA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (42, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 4, N'COLCAMAR                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (43, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 5, N'CONILA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (44, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 6, N'INGUILPATA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (45, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 7, N'LONGUITA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (46, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 8, N'LONYA CHICO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (47, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 9, N'LUYA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (48, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 10, N'LUYA VIEJO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (49, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 11, N'MARIA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (50, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 12, N'OCALLI                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (51, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 13, N'OCUMAL                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (52, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 14, N'PISUQUIA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (53, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 15, N'SAN CRISTOBAL                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (54, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 16, N'SAN FRANCISCO DE YESO         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (55, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 17, N'SAN JERONIMO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (56, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 18, N'SAN JUAN DE LOPECANCHA        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (57, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 19, N'SANTA CATALINA                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (58, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 20, N'SANTO TOMAS                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (59, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 21, N'TINGO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (60, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 22, N'TRITA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (61, 1, N'AMAZONAS       ', 4, N'LUYA                          ', 23, N'PROVIDENCIA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (62, 1, N'AMAZONAS       ', 5, N'RODRIGUEZ DE MENDOZA          ', 1, N'SAN NICOLAS                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (63, 1, N'AMAZONAS       ', 5, N'RODRIGUEZ DE MENDOZA          ', 2, N'COCHAMAL                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (64, 1, N'AMAZONAS       ', 5, N'RODRIGUEZ DE MENDOZA          ', 3, N'CHIRIMOTO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (65, 1, N'AMAZONAS       ', 5, N'RODRIGUEZ DE MENDOZA          ', 4, N'HUAMBO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (66, 1, N'AMAZONAS       ', 5, N'RODRIGUEZ DE MENDOZA          ', 5, N'LIMABAMBA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (67, 1, N'AMAZONAS       ', 5, N'RODRIGUEZ DE MENDOZA          ', 6, N'LONGAR                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (68, 1, N'AMAZONAS       ', 5, N'RODRIGUEZ DE MENDOZA          ', 7, N'MILPUC                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (69, 1, N'AMAZONAS       ', 5, N'RODRIGUEZ DE MENDOZA          ', 8, N'MCAL BENAVIDES                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (70, 1, N'AMAZONAS       ', 5, N'RODRIGUEZ DE MENDOZA          ', 9, N'OMIA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (71, 1, N'AMAZONAS       ', 5, N'RODRIGUEZ DE MENDOZA          ', 10, N'SANTA ROSA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (72, 1, N'AMAZONAS       ', 5, N'RODRIGUEZ DE MENDOZA          ', 11, N'TOTORA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (73, 1, N'AMAZONAS       ', 5, N'RODRIGUEZ DE MENDOZA          ', 12, N'VISTA ALEGRE                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (74, 1, N'AMAZONAS       ', 6, N'CONDORCANQUI                  ', 1, N'NIEVA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (75, 1, N'AMAZONAS       ', 6, N'CONDORCANQUI                  ', 2, N'RIO SANTIAGO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (76, 1, N'AMAZONAS       ', 6, N'CONDORCANQUI                  ', 3, N'EL CENEPA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (77, 1, N'AMAZONAS       ', 7, N'UTCUBAMBA                     ', 1, N'BAGUA GRANDE                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (78, 1, N'AMAZONAS       ', 7, N'UTCUBAMBA                     ', 2, N'CAJARURO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (79, 1, N'AMAZONAS       ', 7, N'UTCUBAMBA                     ', 3, N'CUMBA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (80, 1, N'AMAZONAS       ', 7, N'UTCUBAMBA                     ', 4, N'EL MILAGRO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (81, 1, N'AMAZONAS       ', 7, N'UTCUBAMBA                     ', 5, N'JAMALCA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (82, 1, N'AMAZONAS       ', 7, N'UTCUBAMBA                     ', 6, N'LONYA GRANDE                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (83, 1, N'AMAZONAS       ', 7, N'UTCUBAMBA                     ', 7, N'YAMON                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (84, 2, N'ANCASH         ', 1, N'HUARAZ                        ', 1, N'HUARAZ                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (85, 2, N'ANCASH         ', 1, N'HUARAZ                        ', 2, N'INDEPENDENCIA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (86, 2, N'ANCASH         ', 1, N'HUARAZ                        ', 3, N'COCHABAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (87, 2, N'ANCASH         ', 1, N'HUARAZ                        ', 4, N'COLCABAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (88, 2, N'ANCASH         ', 1, N'HUARAZ                        ', 5, N'HUANCHAY                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (89, 2, N'ANCASH         ', 1, N'HUARAZ                        ', 6, N'JANGAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (90, 2, N'ANCASH         ', 1, N'HUARAZ                        ', 7, N'LA LIBERTAD                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (91, 2, N'ANCASH         ', 1, N'HUARAZ                        ', 8, N'OLLEROS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (92, 2, N'ANCASH         ', 1, N'HUARAZ                        ', 9, N'PAMPAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (93, 2, N'ANCASH         ', 1, N'HUARAZ                        ', 10, N'PARIACOTO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (94, 2, N'ANCASH         ', 1, N'HUARAZ                        ', 11, N'PIRA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (95, 2, N'ANCASH         ', 1, N'HUARAZ                        ', 12, N'TARICA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (96, 2, N'ANCASH         ', 2, N'AIJA                          ', 1, N'AIJA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (97, 2, N'ANCASH         ', 2, N'AIJA                          ', 3, N'CORIS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (98, 2, N'ANCASH         ', 2, N'AIJA                          ', 5, N'HUACLLAN                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (99, 2, N'ANCASH         ', 2, N'AIJA                          ', 6, N'LA MERCED                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (100, 2, N'ANCASH         ', 2, N'AIJA                          ', 8, N'SUCCHA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (101, 2, N'ANCASH         ', 3, N'BOLOGNESI                     ', 1, N'CHIQUIAN                      ')
GO
print 'Processed 100 total records'
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (102, 2, N'ANCASH         ', 3, N'BOLOGNESI                     ', 2, N'A PARDO LEZAMETA              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (103, 2, N'ANCASH         ', 3, N'BOLOGNESI                     ', 4, N'AQUIA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (104, 2, N'ANCASH         ', 3, N'BOLOGNESI                     ', 5, N'CAJACAY                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (105, 2, N'ANCASH         ', 3, N'BOLOGNESI                     ', 10, N'HUAYLLACAYAN                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (106, 2, N'ANCASH         ', 3, N'BOLOGNESI                     ', 11, N'HUASTA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (107, 2, N'ANCASH         ', 3, N'BOLOGNESI                     ', 13, N'MANGAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (108, 2, N'ANCASH         ', 3, N'BOLOGNESI                     ', 15, N'PACLLON                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (109, 2, N'ANCASH         ', 3, N'BOLOGNESI                     ', 17, N'SAN MIGUEL DE CORPANQUI       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (110, 2, N'ANCASH         ', 3, N'BOLOGNESI                     ', 20, N'TICLLOS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (111, 2, N'ANCASH         ', 3, N'BOLOGNESI                     ', 21, N'ANTONIO RAIMONDI              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (112, 2, N'ANCASH         ', 3, N'BOLOGNESI                     ', 22, N'CANIS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (113, 2, N'ANCASH         ', 3, N'BOLOGNESI                     ', 23, N'COLQUIOC                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (114, 2, N'ANCASH         ', 3, N'BOLOGNESI                     ', 24, N'LA PRIMAVERA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (115, 2, N'ANCASH         ', 3, N'BOLOGNESI                     ', 25, N'HUALLANCA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (116, 2, N'ANCASH         ', 4, N'CARHUAZ                       ', 1, N'CARHUAZ                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (117, 2, N'ANCASH         ', 4, N'CARHUAZ                       ', 2, N'ACOPAMPA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (118, 2, N'ANCASH         ', 4, N'CARHUAZ                       ', 3, N'AMASHCA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (119, 2, N'ANCASH         ', 4, N'CARHUAZ                       ', 4, N'ANTA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (120, 2, N'ANCASH         ', 4, N'CARHUAZ                       ', 5, N'ATAQUERO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (121, 2, N'ANCASH         ', 4, N'CARHUAZ                       ', 6, N'MARCARA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (122, 2, N'ANCASH         ', 4, N'CARHUAZ                       ', 7, N'PARIAHUANCA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (123, 2, N'ANCASH         ', 4, N'CARHUAZ                       ', 8, N'SAN MIGUEL DE ACO             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (124, 2, N'ANCASH         ', 4, N'CARHUAZ                       ', 9, N'SHILLA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (125, 2, N'ANCASH         ', 4, N'CARHUAZ                       ', 10, N'TINCO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (126, 2, N'ANCASH         ', 4, N'CARHUAZ                       ', 11, N'YUNGAR                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (127, 2, N'ANCASH         ', 5, N'CASMA                         ', 1, N'CASMA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (128, 2, N'ANCASH         ', 5, N'CASMA                         ', 2, N'BUENA VISTA ALTA              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (129, 2, N'ANCASH         ', 5, N'CASMA                         ', 3, N'COMANDANTE NOEL               ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (130, 2, N'ANCASH         ', 5, N'CASMA                         ', 5, N'YAUTAN                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (131, 2, N'ANCASH         ', 6, N'CORONGO                       ', 1, N'CORONGO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (132, 2, N'ANCASH         ', 6, N'CORONGO                       ', 2, N'ACO                           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (133, 2, N'ANCASH         ', 6, N'CORONGO                       ', 3, N'BAMBAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (134, 2, N'ANCASH         ', 6, N'CORONGO                       ', 4, N'CUSCA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (135, 2, N'ANCASH         ', 6, N'CORONGO                       ', 5, N'LA PAMPA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (136, 2, N'ANCASH         ', 6, N'CORONGO                       ', 6, N'YANAC                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (137, 2, N'ANCASH         ', 6, N'CORONGO                       ', 7, N'YUPAN                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (138, 2, N'ANCASH         ', 7, N'HUAYLAS                       ', 1, N'CARAZ                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (139, 2, N'ANCASH         ', 7, N'HUAYLAS                       ', 2, N'HUALLANCA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (140, 2, N'ANCASH         ', 7, N'HUAYLAS                       ', 3, N'HUATA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (141, 2, N'ANCASH         ', 7, N'HUAYLAS                       ', 4, N'HUAYLAS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (142, 2, N'ANCASH         ', 7, N'HUAYLAS                       ', 5, N'MATO                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (143, 2, N'ANCASH         ', 7, N'HUAYLAS                       ', 6, N'PAMPAROMAS                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (144, 2, N'ANCASH         ', 7, N'HUAYLAS                       ', 7, N'PUEBLO LIBRE                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (145, 2, N'ANCASH         ', 7, N'HUAYLAS                       ', 8, N'SANTA CRUZ                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (146, 2, N'ANCASH         ', 7, N'HUAYLAS                       ', 9, N'YURACMARCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (147, 2, N'ANCASH         ', 7, N'HUAYLAS                       ', 10, N'SANTO TORIBIO                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (148, 2, N'ANCASH         ', 8, N'HUARI                         ', 1, N'HUARI                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (149, 2, N'ANCASH         ', 8, N'HUARI                         ', 2, N'CAJAY                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (150, 2, N'ANCASH         ', 8, N'HUARI                         ', 3, N'CHAVIN DE HUANTAR             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (151, 2, N'ANCASH         ', 8, N'HUARI                         ', 4, N'HUACACHI                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (152, 2, N'ANCASH         ', 8, N'HUARI                         ', 5, N'HUACHIS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (153, 2, N'ANCASH         ', 8, N'HUARI                         ', 6, N'HUACCHIS                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (154, 2, N'ANCASH         ', 8, N'HUARI                         ', 7, N'HUANTAR                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (155, 2, N'ANCASH         ', 8, N'HUARI                         ', 8, N'MASIN                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (156, 2, N'ANCASH         ', 8, N'HUARI                         ', 9, N'PAUCAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (157, 2, N'ANCASH         ', 8, N'HUARI                         ', 10, N'PONTO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (158, 2, N'ANCASH         ', 8, N'HUARI                         ', 11, N'RAHUAPAMPA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (159, 2, N'ANCASH         ', 8, N'HUARI                         ', 12, N'RAPAYAN                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (160, 2, N'ANCASH         ', 8, N'HUARI                         ', 13, N'SAN MARCOS                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (161, 2, N'ANCASH         ', 8, N'HUARI                         ', 14, N'SAN PEDRO DE CHANA            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (162, 2, N'ANCASH         ', 8, N'HUARI                         ', 15, N'UCO                           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (163, 2, N'ANCASH         ', 8, N'HUARI                         ', 16, N'ANRA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (164, 2, N'ANCASH         ', 9, N'MARISCAL LUZURIAGA            ', 1, N'PISCOBAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (165, 2, N'ANCASH         ', 9, N'MARISCAL LUZURIAGA            ', 2, N'CASCA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (166, 2, N'ANCASH         ', 9, N'MARISCAL LUZURIAGA            ', 3, N'LUCMA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (167, 2, N'ANCASH         ', 9, N'MARISCAL LUZURIAGA            ', 4, N'FIDEL OLIVAS ESCUDERO         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (168, 2, N'ANCASH         ', 9, N'MARISCAL LUZURIAGA            ', 5, N'LLAMA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (169, 2, N'ANCASH         ', 9, N'MARISCAL LUZURIAGA            ', 6, N'LLUMPA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (170, 2, N'ANCASH         ', 9, N'MARISCAL LUZURIAGA            ', 7, N'MUSGA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (171, 2, N'ANCASH         ', 9, N'MARISCAL LUZURIAGA            ', 8, N'ELEAZAR GUZMAN BARRON         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (172, 2, N'ANCASH         ', 10, N'PALLASCA                      ', 1, N'CABANA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (173, 2, N'ANCASH         ', 10, N'PALLASCA                      ', 2, N'BOLOGNESI                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (174, 2, N'ANCASH         ', 10, N'PALLASCA                      ', 3, N'CONCHUCOS                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (175, 2, N'ANCASH         ', 10, N'PALLASCA                      ', 4, N'HUACASCHUQUE                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (176, 2, N'ANCASH         ', 10, N'PALLASCA                      ', 5, N'HUANDOVAL                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (177, 2, N'ANCASH         ', 10, N'PALLASCA                      ', 6, N'LACABAMBA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (178, 2, N'ANCASH         ', 10, N'PALLASCA                      ', 7, N'LLAPO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (179, 2, N'ANCASH         ', 10, N'PALLASCA                      ', 8, N'PALLASCA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (180, 2, N'ANCASH         ', 10, N'PALLASCA                      ', 9, N'PAMPAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (181, 2, N'ANCASH         ', 10, N'PALLASCA                      ', 10, N'SANTA ROSA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (182, 2, N'ANCASH         ', 10, N'PALLASCA                      ', 11, N'TAUCA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (183, 2, N'ANCASH         ', 11, N'POMABAMBA                     ', 1, N'POMABAMBA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (184, 2, N'ANCASH         ', 11, N'POMABAMBA                     ', 2, N'HUAYLLAN                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (185, 2, N'ANCASH         ', 11, N'POMABAMBA                     ', 3, N'PAROBAMBA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (186, 2, N'ANCASH         ', 11, N'POMABAMBA                     ', 4, N'QUINUABAMBA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (187, 2, N'ANCASH         ', 12, N'RECUAY                        ', 1, N'RECUAY                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (188, 2, N'ANCASH         ', 12, N'RECUAY                        ', 2, N'COTAPARACO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (189, 2, N'ANCASH         ', 12, N'RECUAY                        ', 3, N'HUAYLLAPAMPA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (190, 2, N'ANCASH         ', 12, N'RECUAY                        ', 4, N'MARCA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (191, 2, N'ANCASH         ', 12, N'RECUAY                        ', 5, N'PAMPAS CHICO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (192, 2, N'ANCASH         ', 12, N'RECUAY                        ', 6, N'PARARIN                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (193, 2, N'ANCASH         ', 12, N'RECUAY                        ', 7, N'TAPACOCHA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (194, 2, N'ANCASH         ', 12, N'RECUAY                        ', 8, N'TICAPAMPA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (195, 2, N'ANCASH         ', 12, N'RECUAY                        ', 9, N'LLACLLIN                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (196, 2, N'ANCASH         ', 12, N'RECUAY                        ', 10, N'CATAC                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (197, 2, N'ANCASH         ', 13, N'SANTA                         ', 1, N'CHIMBOTE                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (198, 2, N'ANCASH         ', 13, N'SANTA                         ', 2, N'CACERES DEL PERU              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (199, 2, N'ANCASH         ', 13, N'SANTA                         ', 3, N'MACATE                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (200, 2, N'ANCASH         ', 13, N'SANTA                         ', 4, N'MORO                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (201, 2, N'ANCASH         ', 13, N'SANTA                         ', 5, N'NEPEÑA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (202, 2, N'ANCASH         ', 13, N'SANTA                         ', 6, N'SAMANCO                       ')
GO
print 'Processed 200 total records'
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (203, 2, N'ANCASH         ', 13, N'SANTA                         ', 7, N'SANTA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (204, 2, N'ANCASH         ', 13, N'SANTA                         ', 8, N'COISHCO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (205, 2, N'ANCASH         ', 13, N'SANTA                         ', 9, N'NUEVO CHIMBOTE                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (206, 2, N'ANCASH         ', 14, N'SIHUAS                        ', 1, N'SIHUAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (207, 2, N'ANCASH         ', 14, N'SIHUAS                        ', 2, N'ALFONSO UGARTE                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (208, 2, N'ANCASH         ', 14, N'SIHUAS                        ', 3, N'CHINGALPO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (209, 2, N'ANCASH         ', 14, N'SIHUAS                        ', 4, N'HUAYLLABAMBA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (210, 2, N'ANCASH         ', 14, N'SIHUAS                        ', 5, N'QUICHES                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (211, 2, N'ANCASH         ', 14, N'SIHUAS                        ', 6, N'SICSIBAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (212, 2, N'ANCASH         ', 14, N'SIHUAS                        ', 7, N'ACOBAMBA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (213, 2, N'ANCASH         ', 14, N'SIHUAS                        ', 8, N'CASHAPAMPA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (214, 2, N'ANCASH         ', 14, N'SIHUAS                        ', 9, N'RAGASH                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (215, 2, N'ANCASH         ', 14, N'SIHUAS                        ', 10, N'SAN JUAN                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (216, 2, N'ANCASH         ', 15, N'YUNGAY                        ', 1, N'YUNGAY                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (217, 2, N'ANCASH         ', 15, N'YUNGAY                        ', 2, N'CASCAPARA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (218, 2, N'ANCASH         ', 15, N'YUNGAY                        ', 3, N'MANCOS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (219, 2, N'ANCASH         ', 15, N'YUNGAY                        ', 4, N'MATACOTO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (220, 2, N'ANCASH         ', 15, N'YUNGAY                        ', 5, N'QUILLO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (221, 2, N'ANCASH         ', 15, N'YUNGAY                        ', 6, N'RANRAHIRCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (222, 2, N'ANCASH         ', 15, N'YUNGAY                        ', 7, N'SHUPLUY                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (223, 2, N'ANCASH         ', 15, N'YUNGAY                        ', 8, N'YANAMA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (224, 2, N'ANCASH         ', 16, N'ANTONIO RAIMONDI              ', 1, N'LLAMELLIN                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (225, 2, N'ANCASH         ', 16, N'ANTONIO RAIMONDI              ', 2, N'ACZO                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (226, 2, N'ANCASH         ', 16, N'ANTONIO RAIMONDI              ', 3, N'CHACCHO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (227, 2, N'ANCASH         ', 16, N'ANTONIO RAIMONDI              ', 4, N'CHINGAS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (228, 2, N'ANCASH         ', 16, N'ANTONIO RAIMONDI              ', 5, N'MIRGAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (229, 2, N'ANCASH         ', 16, N'ANTONIO RAIMONDI              ', 6, N'SAN JUAN DE RONTOY            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (230, 2, N'ANCASH         ', 17, N'CARLOS FERMIN FITZCARRALD     ', 1, N'SAN LUIS                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (231, 2, N'ANCASH         ', 17, N'CARLOS FERMIN FITZCARRALD     ', 2, N'YAUYA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (232, 2, N'ANCASH         ', 17, N'CARLOS FERMIN FITZCARRALD     ', 3, N'SAN NICOLAS                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (233, 2, N'ANCASH         ', 18, N'ASUNCION                      ', 1, N'CHACAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (234, 2, N'ANCASH         ', 18, N'ASUNCION                      ', 2, N'ACOCHACA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (235, 2, N'ANCASH         ', 19, N'HUARMEY                       ', 1, N'HUARMEY                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (236, 2, N'ANCASH         ', 19, N'HUARMEY                       ', 2, N'COCHAPETI                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (237, 2, N'ANCASH         ', 19, N'HUARMEY                       ', 3, N'HUAYAN                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (238, 2, N'ANCASH         ', 19, N'HUARMEY                       ', 4, N'MALVAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (239, 2, N'ANCASH         ', 19, N'HUARMEY                       ', 5, N'CULEBRAS                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (240, 2, N'ANCASH         ', 20, N'OCROS                         ', 1, N'ACAS                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (241, 2, N'ANCASH         ', 20, N'OCROS                         ', 2, N'CAJAMARQUILLA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (242, 2, N'ANCASH         ', 20, N'OCROS                         ', 3, N'CARHUAPAMPA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (243, 2, N'ANCASH         ', 20, N'OCROS                         ', 4, N'COCHAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (244, 2, N'ANCASH         ', 20, N'OCROS                         ', 5, N'CONGAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (245, 2, N'ANCASH         ', 20, N'OCROS                         ', 6, N'LLIPA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (246, 2, N'ANCASH         ', 20, N'OCROS                         ', 7, N'OCROS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (247, 2, N'ANCASH         ', 20, N'OCROS                         ', 8, N'SAN CRISTOBAL DE RAJAN        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (248, 2, N'ANCASH         ', 20, N'OCROS                         ', 9, N'SAN PEDRO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (249, 2, N'ANCASH         ', 20, N'OCROS                         ', 10, N'SANTIAGO DE CHILCAS           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (250, 3, N'APURIMAC       ', 1, N'ABANCAY                       ', 1, N'ABANCAY                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (251, 3, N'APURIMAC       ', 1, N'ABANCAY                       ', 2, N'CIRCA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (252, 3, N'APURIMAC       ', 1, N'ABANCAY                       ', 3, N'CURAHUASI                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (253, 3, N'APURIMAC       ', 1, N'ABANCAY                       ', 4, N'CHACOCHE                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (254, 3, N'APURIMAC       ', 1, N'ABANCAY                       ', 5, N'HUANIPACA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (255, 3, N'APURIMAC       ', 1, N'ABANCAY                       ', 6, N'LAMBRAMA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (256, 3, N'APURIMAC       ', 1, N'ABANCAY                       ', 7, N'PICHIRHUA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (257, 3, N'APURIMAC       ', 1, N'ABANCAY                       ', 8, N'SAN PEDRO DE CACHORA          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (258, 3, N'APURIMAC       ', 1, N'ABANCAY                       ', 9, N'TAMBURCO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (259, 3, N'APURIMAC       ', 2, N'AYMARAES                      ', 1, N'CHALHUANCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (260, 3, N'APURIMAC       ', 2, N'AYMARAES                      ', 2, N'CAPAYA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (261, 3, N'APURIMAC       ', 2, N'AYMARAES                      ', 3, N'CARAYBAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (262, 3, N'APURIMAC       ', 2, N'AYMARAES                      ', 4, N'COLCABAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (263, 3, N'APURIMAC       ', 2, N'AYMARAES                      ', 5, N'COTARUSE                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (264, 3, N'APURIMAC       ', 2, N'AYMARAES                      ', 6, N'CHAPIMARCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (265, 3, N'APURIMAC       ', 2, N'AYMARAES                      ', 7, N'IHUAYLLO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (266, 3, N'APURIMAC       ', 2, N'AYMARAES                      ', 8, N'LUCRE                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (267, 3, N'APURIMAC       ', 2, N'AYMARAES                      ', 9, N'POCOHUANCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (268, 3, N'APURIMAC       ', 2, N'AYMARAES                      ', 10, N'SAÑAICA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (269, 3, N'APURIMAC       ', 2, N'AYMARAES                      ', 11, N'SORAYA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (270, 3, N'APURIMAC       ', 2, N'AYMARAES                      ', 12, N'TAPAIRIHUA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (271, 3, N'APURIMAC       ', 2, N'AYMARAES                      ', 13, N'TINTAY                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (272, 3, N'APURIMAC       ', 2, N'AYMARAES                      ', 14, N'TORAYA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (273, 3, N'APURIMAC       ', 2, N'AYMARAES                      ', 15, N'YANACA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (274, 3, N'APURIMAC       ', 2, N'AYMARAES                      ', 16, N'SAN JUAN DE CHACÑA            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (275, 3, N'APURIMAC       ', 2, N'AYMARAES                      ', 17, N'JUSTO APU SAHUARAURA          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (276, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 1, N'ANDAHUAYLAS                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (277, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 2, N'ANDARAPA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (278, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 3, N'CHIARA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (279, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 4, N'HUANCARAMA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (280, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 5, N'HUANCARAY                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (281, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 6, N'KISHUARA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (282, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 7, N'PACOBAMBA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (283, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 8, N'PAMPACHIRI                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (284, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 9, N'SAN ANTONIO DE CACHI          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (285, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 10, N'SAN JERONIMO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (286, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 11, N'TALAVERA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (287, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 12, N'TURPO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (288, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 13, N'PACUCHA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (289, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 14, N'POMACOCHA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (290, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 15, N'STA MARIA DE CHICMO           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (291, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 16, N'TUMAY HUARACA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (292, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 17, N'HUAYANA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (293, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 18, N'SAN MIGUEL DE CHACCRAMPA      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (294, 3, N'APURIMAC       ', 3, N'ANDAHUAYLAS                   ', 19, N'KAQUIABAMBA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (295, 3, N'APURIMAC       ', 4, N'ANTABAMBA                     ', 1, N'ANTABAMBA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (296, 3, N'APURIMAC       ', 4, N'ANTABAMBA                     ', 2, N'EL ORO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (297, 3, N'APURIMAC       ', 4, N'ANTABAMBA                     ', 3, N'HUAQUIRCA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (298, 3, N'APURIMAC       ', 4, N'ANTABAMBA                     ', 4, N'JUAN ESPINOZA MEDRANO         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (299, 3, N'APURIMAC       ', 4, N'ANTABAMBA                     ', 5, N'OROPESA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (300, 3, N'APURIMAC       ', 4, N'ANTABAMBA                     ', 6, N'PACHACONAS                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (301, 3, N'APURIMAC       ', 4, N'ANTABAMBA                     ', 7, N'SABAINO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (302, 3, N'APURIMAC       ', 5, N'COTABAMBAS                    ', 1, N'TAMBOBAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (303, 3, N'APURIMAC       ', 5, N'COTABAMBAS                    ', 2, N'COYLLURQUI                    ')
GO
print 'Processed 300 total records'
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (304, 3, N'APURIMAC       ', 5, N'COTABAMBAS                    ', 3, N'COTABAMBAS                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (305, 3, N'APURIMAC       ', 5, N'COTABAMBAS                    ', 4, N'HAQUIRA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (306, 3, N'APURIMAC       ', 5, N'COTABAMBAS                    ', 5, N'MARA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (307, 3, N'APURIMAC       ', 5, N'COTABAMBAS                    ', 6, N'CHALLHUAHUACHO                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (308, 3, N'APURIMAC       ', 6, N'GRAU                          ', 1, N'CHUQUIBAMBILLA                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (309, 3, N'APURIMAC       ', 6, N'GRAU                          ', 2, N'CURPAHUASI                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (310, 3, N'APURIMAC       ', 6, N'GRAU                          ', 3, N'HUAILLATI                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (311, 3, N'APURIMAC       ', 6, N'GRAU                          ', 4, N'MAMARA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (312, 3, N'APURIMAC       ', 6, N'GRAU                          ', 5, N'MARISCAL GAMARRA              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (313, 3, N'APURIMAC       ', 6, N'GRAU                          ', 6, N'MICAELA BASTIDAS              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (314, 3, N'APURIMAC       ', 6, N'GRAU                          ', 7, N'PROGRESO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (315, 3, N'APURIMAC       ', 6, N'GRAU                          ', 8, N'PATAYPAMPA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (316, 3, N'APURIMAC       ', 6, N'GRAU                          ', 9, N'SAN ANTONIO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (317, 3, N'APURIMAC       ', 6, N'GRAU                          ', 10, N'TURPAY                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (318, 3, N'APURIMAC       ', 6, N'GRAU                          ', 11, N'VILCABAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (319, 3, N'APURIMAC       ', 6, N'GRAU                          ', 12, N'VIRUNDO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (320, 3, N'APURIMAC       ', 6, N'GRAU                          ', 13, N'SANTA ROSA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (321, 3, N'APURIMAC       ', 6, N'GRAU                          ', 14, N'CURASCO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (322, 3, N'APURIMAC       ', 7, N'CHINCHEROS                    ', 1, N'CHINCHEROS                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (323, 3, N'APURIMAC       ', 7, N'CHINCHEROS                    ', 2, N'ONGOY                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (324, 3, N'APURIMAC       ', 7, N'CHINCHEROS                    ', 3, N'OCOBAMBA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (325, 3, N'APURIMAC       ', 7, N'CHINCHEROS                    ', 4, N'COCHARCAS                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (326, 3, N'APURIMAC       ', 7, N'CHINCHEROS                    ', 5, N'ANCO HUALLO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (327, 3, N'APURIMAC       ', 7, N'CHINCHEROS                    ', 6, N'HUACCANA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (328, 3, N'APURIMAC       ', 7, N'CHINCHEROS                    ', 7, N'URANMARCA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (329, 3, N'APURIMAC       ', 7, N'CHINCHEROS                    ', 8, N'RANRACANCHA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (330, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 1, N'AREQUIPA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (331, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 2, N'CAYMA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (332, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 3, N'CERRO COLORADO                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (333, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 4, N'CHARACATO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (334, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 5, N'CHIGUATA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (335, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 6, N'LA JOYA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (336, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 7, N'MIRAFLORES                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (337, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 8, N'MOLLEBAYA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (338, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 9, N'PAUCARPATA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (339, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 10, N'POCSI                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (340, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 11, N'POLOBAYA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (341, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 12, N'QUEQUEÑA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (342, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 13, N'SABANDIA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (343, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 14, N'SACHACA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (344, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 15, N'SAN JUAN DE SIGUAS            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (345, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 16, N'SAN JUAN DE TARUCANI          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (346, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 17, N'SANTA ISABEL DE SIGUAS        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (347, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 18, N'STA RITA DE SIGUAS            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (348, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 19, N'SOCABAYA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (349, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 20, N'TIABAYA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (350, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 21, N'UCHUMAYO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (351, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 22, N'VITOR                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (352, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 23, N'YANAHUARA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (353, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 24, N'YARABAMBA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (354, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 25, N'YURA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (355, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 26, N'MARIANO MELGAR                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (356, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 27, N'JACOBO HUNTER                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (357, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 28, N'ALTO SELVA ALEGRE             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (358, 4, N'AREQUIPA       ', 1, N'AREQUIPA                      ', 29, N'JOSE LUIS BUSTAMANTE Y RIVERO ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (359, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 1, N'CHIVAY                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (360, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 2, N'ACHOMA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (361, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 3, N'CABANACONDE                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (362, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 4, N'CAYLLOMA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (363, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 5, N'CALLALLI                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (364, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 6, N'COPORAQUE                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (365, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 7, N'HUAMBO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (366, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 8, N'HUANCA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (367, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 9, N'ICHUPAMPA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (368, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 10, N'LARI                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (369, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 11, N'LLUTA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (370, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 12, N'MACA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (371, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 13, N'MADRIGAL                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (372, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 14, N'SAN ANTONIO DE CHUCA          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (373, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 15, N'SIBAYO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (374, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 16, N'TAPAY                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (375, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 17, N'TISCO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (376, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 18, N'TUTI                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (377, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 19, N'YANQUE                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (378, 4, N'AREQUIPA       ', 2, N'CAYLLOMA                      ', 20, N'MAJES                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (379, 4, N'AREQUIPA       ', 3, N'CAMANA                        ', 1, N'CAMANA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (380, 4, N'AREQUIPA       ', 3, N'CAMANA                        ', 2, N'JOSE MARIA QUIMPER            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (381, 4, N'AREQUIPA       ', 3, N'CAMANA                        ', 3, N'MARIANO N VALCARCEL           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (382, 4, N'AREQUIPA       ', 3, N'CAMANA                        ', 4, N'MARISCAL CACERES              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (383, 4, N'AREQUIPA       ', 3, N'CAMANA                        ', 5, N'NICOLAS DE PIEROLA            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (384, 4, N'AREQUIPA       ', 3, N'CAMANA                        ', 6, N'OCOÑA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (385, 4, N'AREQUIPA       ', 3, N'CAMANA                        ', 7, N'QUILCA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (386, 4, N'AREQUIPA       ', 3, N'CAMANA                        ', 8, N'SAMUEL PASTOR                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (387, 4, N'AREQUIPA       ', 4, N'CARAVELI                      ', 1, N'CARAVELI                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (388, 4, N'AREQUIPA       ', 4, N'CARAVELI                      ', 2, N'ACARI                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (389, 4, N'AREQUIPA       ', 4, N'CARAVELI                      ', 3, N'ATICO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (390, 4, N'AREQUIPA       ', 4, N'CARAVELI                      ', 4, N'ATIQUIPA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (391, 4, N'AREQUIPA       ', 4, N'CARAVELI                      ', 5, N'BELLA UNION                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (392, 4, N'AREQUIPA       ', 4, N'CARAVELI                      ', 6, N'CAHUACHO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (393, 4, N'AREQUIPA       ', 4, N'CARAVELI                      ', 7, N'CHALA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (394, 4, N'AREQUIPA       ', 4, N'CARAVELI                      ', 8, N'CHAPARRA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (395, 4, N'AREQUIPA       ', 4, N'CARAVELI                      ', 9, N'HUANUHUANU                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (396, 4, N'AREQUIPA       ', 4, N'CARAVELI                      ', 10, N'JAQUI                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (397, 4, N'AREQUIPA       ', 4, N'CARAVELI                      ', 11, N'LOMAS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (398, 4, N'AREQUIPA       ', 4, N'CARAVELI                      ', 12, N'QUICACHA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (399, 4, N'AREQUIPA       ', 4, N'CARAVELI                      ', 13, N'YAUCA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (400, 4, N'AREQUIPA       ', 5, N'CASTILLA                      ', 1, N'APLAO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (401, 4, N'AREQUIPA       ', 5, N'CASTILLA                      ', 2, N'ANDAGUA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (402, 4, N'AREQUIPA       ', 5, N'CASTILLA                      ', 3, N'AYO                           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (403, 4, N'AREQUIPA       ', 5, N'CASTILLA                      ', 4, N'CHACHAS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (404, 4, N'AREQUIPA       ', 5, N'CASTILLA                      ', 5, N'CHILCAYMARCA                  ')
GO
print 'Processed 400 total records'
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (405, 4, N'AREQUIPA       ', 5, N'CASTILLA                      ', 6, N'CHOCO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (406, 4, N'AREQUIPA       ', 5, N'CASTILLA                      ', 7, N'HUANCARQUI                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (407, 4, N'AREQUIPA       ', 5, N'CASTILLA                      ', 8, N'MACHAGUAY                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (408, 4, N'AREQUIPA       ', 5, N'CASTILLA                      ', 9, N'ORCOPAMPA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (409, 4, N'AREQUIPA       ', 5, N'CASTILLA                      ', 10, N'PAMPACOLCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (410, 4, N'AREQUIPA       ', 5, N'CASTILLA                      ', 11, N'TIPAN                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (411, 4, N'AREQUIPA       ', 5, N'CASTILLA                      ', 12, N'URACA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (412, 4, N'AREQUIPA       ', 5, N'CASTILLA                      ', 13, N'UÑON                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (413, 4, N'AREQUIPA       ', 5, N'CASTILLA                      ', 14, N'VIRACO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (414, 4, N'AREQUIPA       ', 6, N'CONDESUYOS                    ', 1, N'CHUQUIBAMBA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (415, 4, N'AREQUIPA       ', 6, N'CONDESUYOS                    ', 2, N'ANDARAY                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (416, 4, N'AREQUIPA       ', 6, N'CONDESUYOS                    ', 3, N'CAYARANI                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (417, 4, N'AREQUIPA       ', 6, N'CONDESUYOS                    ', 4, N'CHICHAS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (418, 4, N'AREQUIPA       ', 6, N'CONDESUYOS                    ', 5, N'IRAY                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (419, 4, N'AREQUIPA       ', 6, N'CONDESUYOS                    ', 6, N'SALAMANCA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (420, 4, N'AREQUIPA       ', 6, N'CONDESUYOS                    ', 7, N'YANAQUIHUA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (421, 4, N'AREQUIPA       ', 6, N'CONDESUYOS                    ', 8, N'RIO GRANDE                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (422, 4, N'AREQUIPA       ', 7, N'ISLAY                         ', 1, N'MOLLENDO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (423, 4, N'AREQUIPA       ', 7, N'ISLAY                         ', 2, N'COCACHACRA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (424, 4, N'AREQUIPA       ', 7, N'ISLAY                         ', 3, N'DEAN VALDIVIA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (425, 4, N'AREQUIPA       ', 7, N'ISLAY                         ', 4, N'ISLAY                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (426, 4, N'AREQUIPA       ', 7, N'ISLAY                         ', 5, N'MEJIA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (427, 4, N'AREQUIPA       ', 7, N'ISLAY                         ', 6, N'PUNTA DE BOMBON               ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (428, 4, N'AREQUIPA       ', 8, N'LA UNION                      ', 1, N'COTAHUASI                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (429, 4, N'AREQUIPA       ', 8, N'LA UNION                      ', 2, N'ALCA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (430, 4, N'AREQUIPA       ', 8, N'LA UNION                      ', 3, N'CHARCANA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (431, 4, N'AREQUIPA       ', 8, N'LA UNION                      ', 4, N'HUAYNACOTAS                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (432, 4, N'AREQUIPA       ', 8, N'LA UNION                      ', 5, N'PAMPAMARCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (433, 4, N'AREQUIPA       ', 8, N'LA UNION                      ', 6, N'PUYCA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (434, 4, N'AREQUIPA       ', 8, N'LA UNION                      ', 7, N'QUECHUALLA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (435, 4, N'AREQUIPA       ', 8, N'LA UNION                      ', 8, N'SAYLA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (436, 4, N'AREQUIPA       ', 8, N'LA UNION                      ', 9, N'TAURIA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (437, 4, N'AREQUIPA       ', 8, N'LA UNION                      ', 10, N'TOMEPAMPA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (438, 4, N'AREQUIPA       ', 8, N'LA UNION                      ', 11, N'TORO                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (439, 5, N'AYACUCHO       ', 1, N'HUAMANGA                      ', 1, N'AYACUCHO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (440, 5, N'AYACUCHO       ', 1, N'HUAMANGA                      ', 2, N'ACOS VINCHOS                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (441, 5, N'AYACUCHO       ', 1, N'HUAMANGA                      ', 3, N'CARMEN ALTO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (442, 5, N'AYACUCHO       ', 1, N'HUAMANGA                      ', 4, N'CHIARA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (443, 5, N'AYACUCHO       ', 1, N'HUAMANGA                      ', 5, N'QUINUA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (444, 5, N'AYACUCHO       ', 1, N'HUAMANGA                      ', 6, N'SAN JOSE DE TICLLAS           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (445, 5, N'AYACUCHO       ', 1, N'HUAMANGA                      ', 7, N'SAN JUAN BAUTISTA             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (446, 5, N'AYACUCHO       ', 1, N'HUAMANGA                      ', 8, N'SANTIAGO DE PISCHA            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (447, 5, N'AYACUCHO       ', 1, N'HUAMANGA                      ', 9, N'VINCHOS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (448, 5, N'AYACUCHO       ', 1, N'HUAMANGA                      ', 10, N'TAMBILLO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (449, 5, N'AYACUCHO       ', 1, N'HUAMANGA                      ', 11, N'ACOCRO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (450, 5, N'AYACUCHO       ', 1, N'HUAMANGA                      ', 12, N'SOCOS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (451, 5, N'AYACUCHO       ', 1, N'HUAMANGA                      ', 13, N'OCROS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (452, 5, N'AYACUCHO       ', 1, N'HUAMANGA                      ', 14, N'PACAYCASA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (453, 5, N'AYACUCHO       ', 1, N'HUAMANGA                      ', 15, N'JESUS NAZARENO                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (454, 5, N'AYACUCHO       ', 2, N'CANGALLO                      ', 1, N'CANGALLO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (455, 5, N'AYACUCHO       ', 2, N'CANGALLO                      ', 4, N'CHUSCHI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (456, 5, N'AYACUCHO       ', 2, N'CANGALLO                      ', 6, N'LOS MOROCHUCOS                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (457, 5, N'AYACUCHO       ', 2, N'CANGALLO                      ', 7, N'PARAS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (458, 5, N'AYACUCHO       ', 2, N'CANGALLO                      ', 8, N'TOTOS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (459, 5, N'AYACUCHO       ', 2, N'CANGALLO                      ', 11, N'MARIA PARADO DE BELLIDO       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (460, 5, N'AYACUCHO       ', 3, N'HUANTA                        ', 1, N'HUANTA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (461, 5, N'AYACUCHO       ', 3, N'HUANTA                        ', 2, N'AYAHUANCO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (462, 5, N'AYACUCHO       ', 3, N'HUANTA                        ', 3, N'HUAMANGUILLA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (463, 5, N'AYACUCHO       ', 3, N'HUANTA                        ', 4, N'IGUAIN                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (464, 5, N'AYACUCHO       ', 3, N'HUANTA                        ', 5, N'LURICOCHA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (465, 5, N'AYACUCHO       ', 3, N'HUANTA                        ', 7, N'SANTILLANA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (466, 5, N'AYACUCHO       ', 3, N'HUANTA                        ', 8, N'SIVIA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (467, 5, N'AYACUCHO       ', 3, N'HUANTA                        ', 9, N'LLOCHEGUA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (468, 5, N'AYACUCHO       ', 4, N'LA MAR                        ', 1, N'SAN MIGUEL                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (469, 5, N'AYACUCHO       ', 4, N'LA MAR                        ', 2, N'ANCO                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (470, 5, N'AYACUCHO       ', 4, N'LA MAR                        ', 3, N'AYNA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (471, 5, N'AYACUCHO       ', 4, N'LA MAR                        ', 4, N'CHILCAS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (472, 5, N'AYACUCHO       ', 4, N'LA MAR                        ', 5, N'CHUNGUI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (473, 5, N'AYACUCHO       ', 4, N'LA MAR                        ', 6, N'TAMBO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (474, 5, N'AYACUCHO       ', 4, N'LA MAR                        ', 7, N'LUIS CARRANZA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (475, 5, N'AYACUCHO       ', 4, N'LA MAR                        ', 8, N'SANTA ROSA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (476, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 1, N'PUQUIO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (477, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 2, N'AUCARA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (478, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 3, N'CABANA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (479, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 4, N'CARMEN SALCEDO                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (480, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 6, N'CHAVIÑA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (481, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 8, N'CHIPAO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (482, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 10, N'HUAC-HUAS                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (483, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 11, N'LARAMATE                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (484, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 12, N'LEONCIO PRADO                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (485, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 13, N'LUCANAS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (486, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 14, N'LLAUTA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (487, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 16, N'OCAÑA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (488, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 17, N'OTOCA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (489, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 20, N'SANCOS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (490, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 21, N'SAN JUAN                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (491, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 22, N'SAN PEDRO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (492, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 24, N'STA ANA DE HUAYCAHUACHO       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (493, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 25, N'SANTA LUCIA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (494, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 29, N'SAISA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (495, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 31, N'SAN PEDRO DE PALCO            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (496, 5, N'AYACUCHO       ', 5, N'LUCANAS                       ', 32, N'SAN CRISTOBAL                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (497, 5, N'AYACUCHO       ', 6, N'PARINACOCHAS                  ', 1, N'CORACORA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (498, 5, N'AYACUCHO       ', 6, N'PARINACOCHAS                  ', 4, N'CORONEL CASTAÑEDA             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (499, 5, N'AYACUCHO       ', 6, N'PARINACOCHAS                  ', 5, N'CHUMPI                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (500, 5, N'AYACUCHO       ', 6, N'PARINACOCHAS                  ', 8, N'PACAPAUSA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (501, 5, N'AYACUCHO       ', 6, N'PARINACOCHAS                  ', 11, N'PULLO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (502, 5, N'AYACUCHO       ', 6, N'PARINACOCHAS                  ', 12, N'PUYUSCA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (503, 5, N'AYACUCHO       ', 6, N'PARINACOCHAS                  ', 15, N'SAN FCO DE RAVACAYCO          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (504, 5, N'AYACUCHO       ', 6, N'PARINACOCHAS                  ', 16, N'UPAHUACHO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (505, 5, N'AYACUCHO       ', 7, N'VICTOR FAJARDO                ', 1, N'HUANCAPI                      ')
GO
print 'Processed 500 total records'
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (506, 5, N'AYACUCHO       ', 7, N'VICTOR FAJARDO                ', 2, N'ALCAMENCA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (507, 5, N'AYACUCHO       ', 7, N'VICTOR FAJARDO                ', 3, N'APONGO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (508, 5, N'AYACUCHO       ', 7, N'VICTOR FAJARDO                ', 4, N'CANARIA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (509, 5, N'AYACUCHO       ', 7, N'VICTOR FAJARDO                ', 6, N'CAYARA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (510, 5, N'AYACUCHO       ', 7, N'VICTOR FAJARDO                ', 7, N'COLCA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (511, 5, N'AYACUCHO       ', 7, N'VICTOR FAJARDO                ', 8, N'HUAYA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (512, 5, N'AYACUCHO       ', 7, N'VICTOR FAJARDO                ', 9, N'HUAMANQUIQUIA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (513, 5, N'AYACUCHO       ', 7, N'VICTOR FAJARDO                ', 10, N'HUANCARAYLLA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (514, 5, N'AYACUCHO       ', 7, N'VICTOR FAJARDO                ', 13, N'SARHUA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (515, 5, N'AYACUCHO       ', 7, N'VICTOR FAJARDO                ', 14, N'VILCANCHOS                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (516, 5, N'AYACUCHO       ', 7, N'VICTOR FAJARDO                ', 15, N'ASQUIPATA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (517, 5, N'AYACUCHO       ', 8, N'HUANCA SANCOS                 ', 1, N'SANCOS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (518, 5, N'AYACUCHO       ', 8, N'HUANCA SANCOS                 ', 2, N'SACSAMARCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (519, 5, N'AYACUCHO       ', 8, N'HUANCA SANCOS                 ', 3, N'SANTIAGO DE LUCANAMARCA       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (520, 5, N'AYACUCHO       ', 8, N'HUANCA SANCOS                 ', 4, N'CARAPO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (521, 5, N'AYACUCHO       ', 9, N'VILCAS HUAMAN                 ', 1, N'VILCAS HUAMAN                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (522, 5, N'AYACUCHO       ', 9, N'VILCAS HUAMAN                 ', 2, N'VISCHONGO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (523, 5, N'AYACUCHO       ', 9, N'VILCAS HUAMAN                 ', 3, N'ACCOMARCA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (524, 5, N'AYACUCHO       ', 9, N'VILCAS HUAMAN                 ', 4, N'CARHUANCA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (525, 5, N'AYACUCHO       ', 9, N'VILCAS HUAMAN                 ', 5, N'CONCEPCION                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (526, 5, N'AYACUCHO       ', 9, N'VILCAS HUAMAN                 ', 6, N'HUAMBALPA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (527, 5, N'AYACUCHO       ', 9, N'VILCAS HUAMAN                 ', 7, N'SAURAMA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (528, 5, N'AYACUCHO       ', 9, N'VILCAS HUAMAN                 ', 8, N'INDEPENDENCIA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (529, 5, N'AYACUCHO       ', 10, N'PAUCAR DEL SARA SARA          ', 1, N'PAUSA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (530, 5, N'AYACUCHO       ', 10, N'PAUCAR DEL SARA SARA          ', 2, N'COLTA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (531, 5, N'AYACUCHO       ', 10, N'PAUCAR DEL SARA SARA          ', 3, N'CORCULLA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (532, 5, N'AYACUCHO       ', 10, N'PAUCAR DEL SARA SARA          ', 4, N'LAMPA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (533, 5, N'AYACUCHO       ', 10, N'PAUCAR DEL SARA SARA          ', 5, N'MARCABAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (534, 5, N'AYACUCHO       ', 10, N'PAUCAR DEL SARA SARA          ', 6, N'OYOLO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (535, 5, N'AYACUCHO       ', 10, N'PAUCAR DEL SARA SARA          ', 7, N'PARARCA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (536, 5, N'AYACUCHO       ', 10, N'PAUCAR DEL SARA SARA          ', 8, N'SAN JAVIER DE ALPABAMBA       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (537, 5, N'AYACUCHO       ', 10, N'PAUCAR DEL SARA SARA          ', 9, N'SAN JOSE DE USHUA             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (538, 5, N'AYACUCHO       ', 10, N'PAUCAR DEL SARA SARA          ', 10, N'SARA SARA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (539, 5, N'AYACUCHO       ', 11, N'SUCRE                         ', 1, N'QUEROBAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (540, 5, N'AYACUCHO       ', 11, N'SUCRE                         ', 2, N'BELEN                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (541, 5, N'AYACUCHO       ', 11, N'SUCRE                         ', 3, N'CHALCOS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (542, 5, N'AYACUCHO       ', 11, N'SUCRE                         ', 4, N'SAN SALVADOR DE QUIJE         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (543, 5, N'AYACUCHO       ', 11, N'SUCRE                         ', 5, N'PAICO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (544, 5, N'AYACUCHO       ', 11, N'SUCRE                         ', 6, N'SANTIAGO DE PAUCARAY          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (545, 5, N'AYACUCHO       ', 11, N'SUCRE                         ', 7, N'SAN PEDRO DE LARCAY           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (546, 5, N'AYACUCHO       ', 11, N'SUCRE                         ', 8, N'SORAS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (547, 5, N'AYACUCHO       ', 11, N'SUCRE                         ', 9, N'HUACAÑA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (548, 5, N'AYACUCHO       ', 11, N'SUCRE                         ', 10, N'CHILCAYOC                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (549, 5, N'AYACUCHO       ', 11, N'SUCRE                         ', 11, N'MORCOLLA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (550, 6, N'CAJAMARCA      ', 1, N'CAJAMARCA                     ', 1, N'CAJAMARCA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (551, 6, N'CAJAMARCA      ', 1, N'CAJAMARCA                     ', 2, N'ASUNCION                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (552, 6, N'CAJAMARCA      ', 1, N'CAJAMARCA                     ', 3, N'COSPAN                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (553, 6, N'CAJAMARCA      ', 1, N'CAJAMARCA                     ', 4, N'CHETILLA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (554, 6, N'CAJAMARCA      ', 1, N'CAJAMARCA                     ', 5, N'ENCAÑADA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (555, 6, N'CAJAMARCA      ', 1, N'CAJAMARCA                     ', 6, N'JESUS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (556, 6, N'CAJAMARCA      ', 1, N'CAJAMARCA                     ', 7, N'LOS BAÑOS DEL INCA            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (557, 6, N'CAJAMARCA      ', 1, N'CAJAMARCA                     ', 8, N'LLACANORA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (558, 6, N'CAJAMARCA      ', 1, N'CAJAMARCA                     ', 9, N'MAGDALENA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (559, 6, N'CAJAMARCA      ', 1, N'CAJAMARCA                     ', 10, N'MATARA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (560, 6, N'CAJAMARCA      ', 1, N'CAJAMARCA                     ', 11, N'NAMORA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (561, 6, N'CAJAMARCA      ', 1, N'CAJAMARCA                     ', 12, N'SAN JUAN                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (562, 6, N'CAJAMARCA      ', 2, N'CAJABAMBA                     ', 1, N'CAJABAMBA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (563, 6, N'CAJAMARCA      ', 2, N'CAJABAMBA                     ', 2, N'CACHACHI                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (564, 6, N'CAJAMARCA      ', 2, N'CAJABAMBA                     ', 3, N'CONDEBAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (565, 6, N'CAJAMARCA      ', 2, N'CAJABAMBA                     ', 5, N'SITACOCHA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (566, 6, N'CAJAMARCA      ', 3, N'CELENDIN                      ', 1, N'CELENDIN                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (567, 6, N'CAJAMARCA      ', 3, N'CELENDIN                      ', 2, N'CORTEGANA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (568, 6, N'CAJAMARCA      ', 3, N'CELENDIN                      ', 3, N'CHUMUCH                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (569, 6, N'CAJAMARCA      ', 3, N'CELENDIN                      ', 4, N'HUASMIN                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (570, 6, N'CAJAMARCA      ', 3, N'CELENDIN                      ', 5, N'JORGE CHAVEZ                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (571, 6, N'CAJAMARCA      ', 3, N'CELENDIN                      ', 6, N'JOSE GALVEZ                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (572, 6, N'CAJAMARCA      ', 3, N'CELENDIN                      ', 7, N'MIGUEL IGLESIAS               ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (573, 6, N'CAJAMARCA      ', 3, N'CELENDIN                      ', 8, N'OXAMARCA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (574, 6, N'CAJAMARCA      ', 3, N'CELENDIN                      ', 9, N'SOROCHUCO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (575, 6, N'CAJAMARCA      ', 3, N'CELENDIN                      ', 10, N'SUCRE                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (576, 6, N'CAJAMARCA      ', 3, N'CELENDIN                      ', 11, N'UTCO                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (577, 6, N'CAJAMARCA      ', 3, N'CELENDIN                      ', 12, N'LA LIBERTAD DE PALLAN         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (578, 6, N'CAJAMARCA      ', 4, N'CONTUMAZA                     ', 1, N'CONTUMAZA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (579, 6, N'CAJAMARCA      ', 4, N'CONTUMAZA                     ', 3, N'CHILETE                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (580, 6, N'CAJAMARCA      ', 4, N'CONTUMAZA                     ', 4, N'GUZMANGO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (581, 6, N'CAJAMARCA      ', 4, N'CONTUMAZA                     ', 5, N'SAN BENITO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (582, 6, N'CAJAMARCA      ', 4, N'CONTUMAZA                     ', 6, N'CUPISNIQUE                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (583, 6, N'CAJAMARCA      ', 4, N'CONTUMAZA                     ', 7, N'TANTARICA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (584, 6, N'CAJAMARCA      ', 4, N'CONTUMAZA                     ', 8, N'YONAN                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (585, 6, N'CAJAMARCA      ', 4, N'CONTUMAZA                     ', 9, N'STA CRUZ DE TOLEDO            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (586, 6, N'CAJAMARCA      ', 5, N'CUTERVO                       ', 1, N'CUTERVO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (587, 6, N'CAJAMARCA      ', 5, N'CUTERVO                       ', 2, N'CALLAYUC                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (588, 6, N'CAJAMARCA      ', 5, N'CUTERVO                       ', 3, N'CUJILLO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (589, 6, N'CAJAMARCA      ', 5, N'CUTERVO                       ', 4, N'CHOROS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (590, 6, N'CAJAMARCA      ', 5, N'CUTERVO                       ', 5, N'LA RAMADA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (591, 6, N'CAJAMARCA      ', 5, N'CUTERVO                       ', 6, N'PIMPINGOS                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (592, 6, N'CAJAMARCA      ', 5, N'CUTERVO                       ', 7, N'QUEROCOTILLO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (593, 6, N'CAJAMARCA      ', 5, N'CUTERVO                       ', 8, N'SAN ANDRES DE CUTERVO         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (594, 6, N'CAJAMARCA      ', 5, N'CUTERVO                       ', 9, N'SAN JUAN DE CUTERVO           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (595, 6, N'CAJAMARCA      ', 5, N'CUTERVO                       ', 10, N'SAN LUIS DE LUCMA             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (596, 6, N'CAJAMARCA      ', 5, N'CUTERVO                       ', 11, N'SANTA CRUZ                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (597, 6, N'CAJAMARCA      ', 5, N'CUTERVO                       ', 12, N'SANTO DOMINGO DE LA CAPILLA   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (598, 6, N'CAJAMARCA      ', 5, N'CUTERVO                       ', 13, N'SANTO TOMAS                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (599, 6, N'CAJAMARCA      ', 5, N'CUTERVO                       ', 14, N'SOCOTA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (600, 6, N'CAJAMARCA      ', 5, N'CUTERVO                       ', 15, N'TORIBIO CASANOVA              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (601, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 1, N'CHOTA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (602, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 2, N'ANGUIA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (603, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 3, N'COCHABAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (604, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 4, N'CONCHAN                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (605, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 5, N'CHADIN                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (606, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 6, N'CHIGUIRIP                     ')
GO
print 'Processed 600 total records'
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (607, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 7, N'CHIMBAN                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (608, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 8, N'HUAMBOS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (609, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 9, N'LAJAS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (610, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 10, N'LLAMA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (611, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 11, N'MIRACOSTA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (612, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 12, N'PACCHA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (613, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 13, N'PION                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (614, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 14, N'QUEROCOTO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (615, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 15, N'TACABAMBA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (616, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 16, N'TOCMOCHE                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (617, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 17, N'SAN JUAN DE LICUPIS           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (618, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 18, N'CHOROPAMPA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (619, 6, N'CAJAMARCA      ', 6, N'CHOTA                         ', 19, N'CHALAMARCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (620, 6, N'CAJAMARCA      ', 7, N'HUALGAYOC                     ', 1, N'BAMBAMARCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (621, 6, N'CAJAMARCA      ', 7, N'HUALGAYOC                     ', 2, N'CHUGUR                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (622, 6, N'CAJAMARCA      ', 7, N'HUALGAYOC                     ', 3, N'HUALGAYOC                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (623, 6, N'CAJAMARCA      ', 8, N'JAEN                          ', 1, N'JAEN                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (624, 6, N'CAJAMARCA      ', 8, N'JAEN                          ', 2, N'BELLAVISTA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (625, 6, N'CAJAMARCA      ', 8, N'JAEN                          ', 3, N'COLASAY                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (626, 6, N'CAJAMARCA      ', 8, N'JAEN                          ', 4, N'CHONTALI                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (627, 6, N'CAJAMARCA      ', 8, N'JAEN                          ', 5, N'POMAHUACA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (628, 6, N'CAJAMARCA      ', 8, N'JAEN                          ', 6, N'PUCARA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (629, 6, N'CAJAMARCA      ', 8, N'JAEN                          ', 7, N'SALLIQUE                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (630, 6, N'CAJAMARCA      ', 8, N'JAEN                          ', 8, N'SAN FELIPE                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (631, 6, N'CAJAMARCA      ', 8, N'JAEN                          ', 9, N'SAN JOSE DEL ALTO             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (632, 6, N'CAJAMARCA      ', 8, N'JAEN                          ', 10, N'SANTA ROSA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (633, 6, N'CAJAMARCA      ', 8, N'JAEN                          ', 11, N'LAS PIRIAS                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (634, 6, N'CAJAMARCA      ', 8, N'JAEN                          ', 12, N'HUABAL                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (635, 6, N'CAJAMARCA      ', 9, N'SANTA CRUZ                    ', 1, N'SANTA CRUZ                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (636, 6, N'CAJAMARCA      ', 9, N'SANTA CRUZ                    ', 2, N'CATACHE                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (637, 6, N'CAJAMARCA      ', 9, N'SANTA CRUZ                    ', 3, N'CHANCAIBAÑOS                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (638, 6, N'CAJAMARCA      ', 9, N'SANTA CRUZ                    ', 4, N'LA ESPERANZA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (639, 6, N'CAJAMARCA      ', 9, N'SANTA CRUZ                    ', 5, N'NINABAMBA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (640, 6, N'CAJAMARCA      ', 9, N'SANTA CRUZ                    ', 6, N'PULAN                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (641, 6, N'CAJAMARCA      ', 9, N'SANTA CRUZ                    ', 7, N'SEXI                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (642, 6, N'CAJAMARCA      ', 9, N'SANTA CRUZ                    ', 8, N'UTICYACU                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (643, 6, N'CAJAMARCA      ', 9, N'SANTA CRUZ                    ', 9, N'YAUYUCAN                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (644, 6, N'CAJAMARCA      ', 9, N'SANTA CRUZ                    ', 10, N'ANDABAMBA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (645, 6, N'CAJAMARCA      ', 9, N'SANTA CRUZ                    ', 11, N'SAUCEPAMPA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (646, 6, N'CAJAMARCA      ', 10, N'SAN MIGUEL                    ', 1, N'SAN MIGUEL                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (647, 6, N'CAJAMARCA      ', 10, N'SAN MIGUEL                    ', 2, N'CALQUIS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (648, 6, N'CAJAMARCA      ', 10, N'SAN MIGUEL                    ', 3, N'LA FLORIDA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (649, 6, N'CAJAMARCA      ', 10, N'SAN MIGUEL                    ', 4, N'LLAPA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (650, 6, N'CAJAMARCA      ', 10, N'SAN MIGUEL                    ', 5, N'NANCHOC                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (651, 6, N'CAJAMARCA      ', 10, N'SAN MIGUEL                    ', 6, N'NIEPOS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (652, 6, N'CAJAMARCA      ', 10, N'SAN MIGUEL                    ', 7, N'SAN GREGORIO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (653, 6, N'CAJAMARCA      ', 10, N'SAN MIGUEL                    ', 8, N'SAN SILVESTRE DE COCHAN       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (654, 6, N'CAJAMARCA      ', 10, N'SAN MIGUEL                    ', 9, N'EL PRADO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (655, 6, N'CAJAMARCA      ', 10, N'SAN MIGUEL                    ', 10, N'UNION AGUA BLANCA             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (656, 6, N'CAJAMARCA      ', 10, N'SAN MIGUEL                    ', 11, N'TONGOD                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (657, 6, N'CAJAMARCA      ', 10, N'SAN MIGUEL                    ', 12, N'CATILLUC                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (658, 6, N'CAJAMARCA      ', 10, N'SAN MIGUEL                    ', 13, N'BOLIVAR                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (659, 6, N'CAJAMARCA      ', 11, N'SAN IGNACIO                   ', 1, N'SAN IGNACIO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (660, 6, N'CAJAMARCA      ', 11, N'SAN IGNACIO                   ', 2, N'CHIRINOS                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (661, 6, N'CAJAMARCA      ', 11, N'SAN IGNACIO                   ', 3, N'HUARANGO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (662, 6, N'CAJAMARCA      ', 11, N'SAN IGNACIO                   ', 4, N'NAMBALLE                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (663, 6, N'CAJAMARCA      ', 11, N'SAN IGNACIO                   ', 5, N'LA COIPA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (664, 6, N'CAJAMARCA      ', 11, N'SAN IGNACIO                   ', 6, N'SAN JOSE DE LOURDES           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (665, 6, N'CAJAMARCA      ', 11, N'SAN IGNACIO                   ', 7, N'TABACONAS                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (666, 6, N'CAJAMARCA      ', 12, N'SAN MARCOS                    ', 1, N'PEDRO GALVEZ                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (667, 6, N'CAJAMARCA      ', 12, N'SAN MARCOS                    ', 2, N'ICHOCAN                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (668, 6, N'CAJAMARCA      ', 12, N'SAN MARCOS                    ', 3, N'GREGORIO PITA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (669, 6, N'CAJAMARCA      ', 12, N'SAN MARCOS                    ', 4, N'JOSE MANUEL QUIROZ            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (670, 6, N'CAJAMARCA      ', 12, N'SAN MARCOS                    ', 5, N'EDUARDO VILLANUEVA            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (671, 6, N'CAJAMARCA      ', 12, N'SAN MARCOS                    ', 6, N'JOSE SABOGAL                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (672, 6, N'CAJAMARCA      ', 12, N'SAN MARCOS                    ', 7, N'CHANCAY                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (673, 6, N'CAJAMARCA      ', 13, N'SAN PABLO                     ', 1, N'SAN PABLO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (674, 6, N'CAJAMARCA      ', 13, N'SAN PABLO                     ', 2, N'SAN BERNARDINO                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (675, 6, N'CAJAMARCA      ', 13, N'SAN PABLO                     ', 3, N'SAN LUIS                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (676, 6, N'CAJAMARCA      ', 13, N'SAN PABLO                     ', 4, N'TUMBADEN                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (677, 7, N'CUSCO          ', 1, N'CUSCO                         ', 1, N'CUSCO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (678, 7, N'CUSCO          ', 1, N'CUSCO                         ', 2, N'CCORCA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (679, 7, N'CUSCO          ', 1, N'CUSCO                         ', 3, N'POROY                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (680, 7, N'CUSCO          ', 1, N'CUSCO                         ', 4, N'SAN JERONIMO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (681, 7, N'CUSCO          ', 1, N'CUSCO                         ', 5, N'SAN SEBASTIAN                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (682, 7, N'CUSCO          ', 1, N'CUSCO                         ', 6, N'SANTIAGO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (683, 7, N'CUSCO          ', 1, N'CUSCO                         ', 7, N'SAYLLA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (684, 7, N'CUSCO          ', 1, N'CUSCO                         ', 8, N'WANCHAQ                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (685, 7, N'CUSCO          ', 2, N'ACOMAYO                       ', 1, N'ACOMAYO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (686, 7, N'CUSCO          ', 2, N'ACOMAYO                       ', 2, N'ACOPIA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (687, 7, N'CUSCO          ', 2, N'ACOMAYO                       ', 3, N'ACOS                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (688, 7, N'CUSCO          ', 2, N'ACOMAYO                       ', 4, N'POMACANCHI                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (689, 7, N'CUSCO          ', 2, N'ACOMAYO                       ', 5, N'RONDOCAN                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (690, 7, N'CUSCO          ', 2, N'ACOMAYO                       ', 6, N'SANGARARA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (691, 7, N'CUSCO          ', 2, N'ACOMAYO                       ', 7, N'MOSOC LLACTA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (692, 7, N'CUSCO          ', 3, N'ANTA                          ', 1, N'ANTA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (693, 7, N'CUSCO          ', 3, N'ANTA                          ', 2, N'CHINCHAYPUJIO                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (694, 7, N'CUSCO          ', 3, N'ANTA                          ', 3, N'HUAROCONDO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (695, 7, N'CUSCO          ', 3, N'ANTA                          ', 4, N'LIMATAMBO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (696, 7, N'CUSCO          ', 3, N'ANTA                          ', 5, N'MOLLEPATA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (697, 7, N'CUSCO          ', 3, N'ANTA                          ', 6, N'PUCYURA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (698, 7, N'CUSCO          ', 3, N'ANTA                          ', 7, N'ZURITE                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (699, 7, N'CUSCO          ', 3, N'ANTA                          ', 8, N'CACHIMAYO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (700, 7, N'CUSCO          ', 3, N'ANTA                          ', 9, N'ANCAHUASI                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (701, 7, N'CUSCO          ', 4, N'CALCA                         ', 1, N'CALCA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (702, 7, N'CUSCO          ', 4, N'CALCA                         ', 2, N'COYA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (703, 7, N'CUSCO          ', 4, N'CALCA                         ', 3, N'LAMAY                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (704, 7, N'CUSCO          ', 4, N'CALCA                         ', 4, N'LARES                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (705, 7, N'CUSCO          ', 4, N'CALCA                         ', 5, N'PISAC                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (706, 7, N'CUSCO          ', 4, N'CALCA                         ', 6, N'SAN SALVADOR                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (707, 7, N'CUSCO          ', 4, N'CALCA                         ', 7, N'TARAY                         ')
GO
print 'Processed 700 total records'
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (708, 7, N'CUSCO          ', 4, N'CALCA                         ', 8, N'YANATILE                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (709, 7, N'CUSCO          ', 5, N'CANAS                         ', 1, N'YANAOCA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (710, 7, N'CUSCO          ', 5, N'CANAS                         ', 2, N'CHECCA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (711, 7, N'CUSCO          ', 5, N'CANAS                         ', 3, N'KUNTURKANKI                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (712, 7, N'CUSCO          ', 5, N'CANAS                         ', 4, N'LANGUI                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (713, 7, N'CUSCO          ', 5, N'CANAS                         ', 5, N'LAYO                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (714, 7, N'CUSCO          ', 5, N'CANAS                         ', 6, N'PAMPAMARCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (715, 7, N'CUSCO          ', 5, N'CANAS                         ', 7, N'QUEHUE                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (716, 7, N'CUSCO          ', 5, N'CANAS                         ', 8, N'TUPAC AMARU                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (717, 7, N'CUSCO          ', 6, N'CANCHIS                       ', 1, N'SICUANI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (718, 7, N'CUSCO          ', 6, N'CANCHIS                       ', 2, N'COMBAPATA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (719, 7, N'CUSCO          ', 6, N'CANCHIS                       ', 3, N'CHECACUPE                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (720, 7, N'CUSCO          ', 6, N'CANCHIS                       ', 4, N'MARANGANI                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (721, 7, N'CUSCO          ', 6, N'CANCHIS                       ', 5, N'PITUMARCA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (722, 7, N'CUSCO          ', 6, N'CANCHIS                       ', 6, N'SAN PABLO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (723, 7, N'CUSCO          ', 6, N'CANCHIS                       ', 7, N'SAN PEDRO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (724, 7, N'CUSCO          ', 6, N'CANCHIS                       ', 8, N'TINTA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (725, 7, N'CUSCO          ', 7, N'CHUMBIVILCAS                  ', 1, N'SANTO TOMAS                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (726, 7, N'CUSCO          ', 7, N'CHUMBIVILCAS                  ', 2, N'CAPACMARCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (727, 7, N'CUSCO          ', 7, N'CHUMBIVILCAS                  ', 3, N'COLQUEMARCA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (728, 7, N'CUSCO          ', 7, N'CHUMBIVILCAS                  ', 4, N'CHAMACA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (729, 7, N'CUSCO          ', 7, N'CHUMBIVILCAS                  ', 5, N'LIVITACA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (730, 7, N'CUSCO          ', 7, N'CHUMBIVILCAS                  ', 6, N'LLUSCO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (731, 7, N'CUSCO          ', 7, N'CHUMBIVILCAS                  ', 7, N'QUIÑOTA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (732, 7, N'CUSCO          ', 7, N'CHUMBIVILCAS                  ', 8, N'VELILLE                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (733, 7, N'CUSCO          ', 8, N'ESPINAR                       ', 1, N'ESPINAR                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (734, 7, N'CUSCO          ', 8, N'ESPINAR                       ', 2, N'CONDOROMA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (735, 7, N'CUSCO          ', 8, N'ESPINAR                       ', 3, N'COPORAQUE                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (736, 7, N'CUSCO          ', 8, N'ESPINAR                       ', 4, N'OCORURO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (737, 7, N'CUSCO          ', 8, N'ESPINAR                       ', 5, N'PALLPATA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (738, 7, N'CUSCO          ', 8, N'ESPINAR                       ', 6, N'PICHIGUA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (739, 7, N'CUSCO          ', 8, N'ESPINAR                       ', 7, N'SUYKUTAMBO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (740, 7, N'CUSCO          ', 8, N'ESPINAR                       ', 8, N'ALTO PICHIGUA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (741, 7, N'CUSCO          ', 9, N'LA CONVENCION                 ', 1, N'SANTA ANA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (742, 7, N'CUSCO          ', 9, N'LA CONVENCION                 ', 2, N'ECHARATE                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (743, 7, N'CUSCO          ', 9, N'LA CONVENCION                 ', 3, N'HUAYOPATA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (744, 7, N'CUSCO          ', 9, N'LA CONVENCION                 ', 4, N'MARANURA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (745, 7, N'CUSCO          ', 9, N'LA CONVENCION                 ', 5, N'OCOBAMBA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (746, 7, N'CUSCO          ', 9, N'LA CONVENCION                 ', 6, N'SANTA TERESA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (747, 7, N'CUSCO          ', 9, N'LA CONVENCION                 ', 7, N'VILCABAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (748, 7, N'CUSCO          ', 9, N'LA CONVENCION                 ', 8, N'QUELLOUNO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (749, 7, N'CUSCO          ', 9, N'LA CONVENCION                 ', 9, N'KIMBIRI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (750, 7, N'CUSCO          ', 9, N'LA CONVENCION                 ', 10, N'PICHARI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (751, 7, N'CUSCO          ', 10, N'PARURO                        ', 1, N'PARURO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (752, 7, N'CUSCO          ', 10, N'PARURO                        ', 2, N'ACCHA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (753, 7, N'CUSCO          ', 10, N'PARURO                        ', 3, N'CCAPI                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (754, 7, N'CUSCO          ', 10, N'PARURO                        ', 4, N'COLCHA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (755, 7, N'CUSCO          ', 10, N'PARURO                        ', 5, N'HUANOQUITE                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (756, 7, N'CUSCO          ', 10, N'PARURO                        ', 6, N'OMACHA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (757, 7, N'CUSCO          ', 10, N'PARURO                        ', 7, N'YAURISQUE                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (758, 7, N'CUSCO          ', 10, N'PARURO                        ', 8, N'PACCARITAMBO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (759, 7, N'CUSCO          ', 10, N'PARURO                        ', 9, N'PILLPINTO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (760, 7, N'CUSCO          ', 11, N'PAUCARTAMBO                   ', 1, N'PAUCARTAMBO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (761, 7, N'CUSCO          ', 11, N'PAUCARTAMBO                   ', 2, N'CAICAY                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (762, 7, N'CUSCO          ', 11, N'PAUCARTAMBO                   ', 3, N'COLQUEPATA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (763, 7, N'CUSCO          ', 11, N'PAUCARTAMBO                   ', 4, N'CHALLABAMBA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (764, 7, N'CUSCO          ', 11, N'PAUCARTAMBO                   ', 5, N'COSÑIPATA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (765, 7, N'CUSCO          ', 11, N'PAUCARTAMBO                   ', 6, N'HUANCARANI                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (766, 7, N'CUSCO          ', 12, N'QUISPICANCHI                  ', 1, N'URCOS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (767, 7, N'CUSCO          ', 12, N'QUISPICANCHI                  ', 2, N'ANDAHUAYLILLAS                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (768, 7, N'CUSCO          ', 12, N'QUISPICANCHI                  ', 3, N'CAMANTI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (769, 7, N'CUSCO          ', 12, N'QUISPICANCHI                  ', 4, N'CCARHUAYO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (770, 7, N'CUSCO          ', 12, N'QUISPICANCHI                  ', 5, N'CCATCA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (771, 7, N'CUSCO          ', 12, N'QUISPICANCHI                  ', 6, N'CUSIPATA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (772, 7, N'CUSCO          ', 12, N'QUISPICANCHI                  ', 7, N'HUARO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (773, 7, N'CUSCO          ', 12, N'QUISPICANCHI                  ', 8, N'LUCRE                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (774, 7, N'CUSCO          ', 12, N'QUISPICANCHI                  ', 9, N'MARCAPATA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (775, 7, N'CUSCO          ', 12, N'QUISPICANCHI                  ', 10, N'OCONGATE                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (776, 7, N'CUSCO          ', 12, N'QUISPICANCHI                  ', 11, N'OROPESA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (777, 7, N'CUSCO          ', 12, N'QUISPICANCHI                  ', 12, N'QUIQUIJANA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (778, 7, N'CUSCO          ', 13, N'URUBAMBA                      ', 1, N'URUBAMBA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (779, 7, N'CUSCO          ', 13, N'URUBAMBA                      ', 2, N'CHINCHERO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (780, 7, N'CUSCO          ', 13, N'URUBAMBA                      ', 3, N'HUAYLLABAMBA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (781, 7, N'CUSCO          ', 13, N'URUBAMBA                      ', 4, N'MACHUPICCHU                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (782, 7, N'CUSCO          ', 13, N'URUBAMBA                      ', 5, N'MARAS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (783, 7, N'CUSCO          ', 13, N'URUBAMBA                      ', 6, N'OLLANTAYTAMBO                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (784, 7, N'CUSCO          ', 13, N'URUBAMBA                      ', 7, N'YUCAY                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (785, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 1, N'HUANCAVELICA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (786, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 2, N'ACOBAMBILLA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (787, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 3, N'ACORIA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (788, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 4, N'CONAYCA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (789, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 5, N'CUENCA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (790, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 6, N'HUACHOCOLPA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (791, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 8, N'HUAYLLAHUARA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (792, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 9, N'IZCUCHACA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (793, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 10, N'LARIA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (794, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 11, N'MANTA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (795, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 12, N'MARISCAL CACERES              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (796, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 13, N'MOYA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (797, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 14, N'NUEVO OCCORO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (798, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 15, N'PALCA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (799, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 16, N'PILCHACA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (800, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 17, N'VILCA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (801, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 18, N'YAULI                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (802, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 19, N'ASCENSION                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (803, 8, N'HUANCAVELICA   ', 1, N'HUANCAVELICA                  ', 20, N'HUANDO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (804, 8, N'HUANCAVELICA   ', 2, N'ACOBAMBA                      ', 1, N'ACOBAMBA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (805, 8, N'HUANCAVELICA   ', 2, N'ACOBAMBA                      ', 2, N'ANTA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (806, 8, N'HUANCAVELICA   ', 2, N'ACOBAMBA                      ', 3, N'ANDABAMBA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (807, 8, N'HUANCAVELICA   ', 2, N'ACOBAMBA                      ', 4, N'CAJA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (808, 8, N'HUANCAVELICA   ', 2, N'ACOBAMBA                      ', 5, N'MARCAS                        ')
GO
print 'Processed 800 total records'
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (809, 8, N'HUANCAVELICA   ', 2, N'ACOBAMBA                      ', 6, N'PAUCARA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (810, 8, N'HUANCAVELICA   ', 2, N'ACOBAMBA                      ', 7, N'POMACOCHA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (811, 8, N'HUANCAVELICA   ', 2, N'ACOBAMBA                      ', 8, N'ROSARIO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (812, 8, N'HUANCAVELICA   ', 3, N'ANGARAES                      ', 1, N'LIRCAY                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (813, 8, N'HUANCAVELICA   ', 3, N'ANGARAES                      ', 2, N'ANCHONGA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (814, 8, N'HUANCAVELICA   ', 3, N'ANGARAES                      ', 3, N'CALLANMARCA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (815, 8, N'HUANCAVELICA   ', 3, N'ANGARAES                      ', 4, N'CONGALLA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (816, 8, N'HUANCAVELICA   ', 3, N'ANGARAES                      ', 5, N'CHINCHO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (817, 8, N'HUANCAVELICA   ', 3, N'ANGARAES                      ', 6, N'HUAYLLAY GRANDE               ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (818, 8, N'HUANCAVELICA   ', 3, N'ANGARAES                      ', 7, N'HUANCA HUANCA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (819, 8, N'HUANCAVELICA   ', 3, N'ANGARAES                      ', 8, N'JULCAMARCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (820, 8, N'HUANCAVELICA   ', 3, N'ANGARAES                      ', 9, N'SAN ANTONIO DE ANTAPARCO      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (821, 8, N'HUANCAVELICA   ', 3, N'ANGARAES                      ', 10, N'STO TOMAS DE PATA             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (822, 8, N'HUANCAVELICA   ', 3, N'ANGARAES                      ', 11, N'SECCLLA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (823, 8, N'HUANCAVELICA   ', 3, N'ANGARAES                      ', 12, N'CCOCHACCASA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (824, 8, N'HUANCAVELICA   ', 4, N'CASTROVIRREYNA                ', 1, N'CASTROVIRREYNA                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (825, 8, N'HUANCAVELICA   ', 4, N'CASTROVIRREYNA                ', 2, N'ARMA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (826, 8, N'HUANCAVELICA   ', 4, N'CASTROVIRREYNA                ', 3, N'AURAHUA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (827, 8, N'HUANCAVELICA   ', 4, N'CASTROVIRREYNA                ', 5, N'CAPILLAS                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (828, 8, N'HUANCAVELICA   ', 4, N'CASTROVIRREYNA                ', 6, N'COCAS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (829, 8, N'HUANCAVELICA   ', 4, N'CASTROVIRREYNA                ', 8, N'CHUPAMARCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (830, 8, N'HUANCAVELICA   ', 4, N'CASTROVIRREYNA                ', 9, N'HUACHOS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (831, 8, N'HUANCAVELICA   ', 4, N'CASTROVIRREYNA                ', 10, N'HUAMATAMBO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (832, 8, N'HUANCAVELICA   ', 4, N'CASTROVIRREYNA                ', 14, N'MOLLEPAMPA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (833, 8, N'HUANCAVELICA   ', 4, N'CASTROVIRREYNA                ', 22, N'SAN JUAN                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (834, 8, N'HUANCAVELICA   ', 4, N'CASTROVIRREYNA                ', 27, N'TANTARA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (835, 8, N'HUANCAVELICA   ', 4, N'CASTROVIRREYNA                ', 28, N'TICRAPO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (836, 8, N'HUANCAVELICA   ', 4, N'CASTROVIRREYNA                ', 29, N'SANTA ANA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (837, 8, N'HUANCAVELICA   ', 5, N'TAYACAJA                      ', 1, N'PAMPAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (838, 8, N'HUANCAVELICA   ', 5, N'TAYACAJA                      ', 2, N'ACOSTAMBO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (839, 8, N'HUANCAVELICA   ', 5, N'TAYACAJA                      ', 3, N'ACRAQUIA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (840, 8, N'HUANCAVELICA   ', 5, N'TAYACAJA                      ', 4, N'AHUAYCHA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (841, 8, N'HUANCAVELICA   ', 5, N'TAYACAJA                      ', 6, N'COLCABAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (842, 8, N'HUANCAVELICA   ', 5, N'TAYACAJA                      ', 9, N'DANIEL HERNANDEZ              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (843, 8, N'HUANCAVELICA   ', 5, N'TAYACAJA                      ', 11, N'HUACHOCOLPA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (844, 8, N'HUANCAVELICA   ', 5, N'TAYACAJA                      ', 12, N'HUARIBAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (845, 8, N'HUANCAVELICA   ', 5, N'TAYACAJA                      ', 15, N'ÑAHUIMPUQUIO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (846, 8, N'HUANCAVELICA   ', 5, N'TAYACAJA                      ', 17, N'PAZOS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (847, 8, N'HUANCAVELICA   ', 5, N'TAYACAJA                      ', 18, N'QUISHUAR                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (848, 8, N'HUANCAVELICA   ', 5, N'TAYACAJA                      ', 19, N'SALCABAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (849, 8, N'HUANCAVELICA   ', 5, N'TAYACAJA                      ', 20, N'SAN MARCOS DE ROCCHAC         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (850, 8, N'HUANCAVELICA   ', 5, N'TAYACAJA                      ', 23, N'SURCUBAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (851, 8, N'HUANCAVELICA   ', 5, N'TAYACAJA                      ', 25, N'TINTAY PUNCU                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (852, 8, N'HUANCAVELICA   ', 5, N'TAYACAJA                      ', 26, N'SALCAHUASI                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (853, 8, N'HUANCAVELICA   ', 6, N'HUAYTARA                      ', 1, N'AYAVI                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (854, 8, N'HUANCAVELICA   ', 6, N'HUAYTARA                      ', 2, N'CORDOVA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (855, 8, N'HUANCAVELICA   ', 6, N'HUAYTARA                      ', 3, N'HUAYACUNDO ARMA               ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (856, 8, N'HUANCAVELICA   ', 6, N'HUAYTARA                      ', 4, N'HUAYTARA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (857, 8, N'HUANCAVELICA   ', 6, N'HUAYTARA                      ', 5, N'LARAMARCA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (858, 8, N'HUANCAVELICA   ', 6, N'HUAYTARA                      ', 6, N'OCOYO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (859, 8, N'HUANCAVELICA   ', 6, N'HUAYTARA                      ', 7, N'PILPICHACA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (860, 8, N'HUANCAVELICA   ', 6, N'HUAYTARA                      ', 8, N'QUERCO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (861, 8, N'HUANCAVELICA   ', 6, N'HUAYTARA                      ', 9, N'QUITO ARMA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (862, 8, N'HUANCAVELICA   ', 6, N'HUAYTARA                      ', 10, N'SAN ANTONIO DE CUSICANCHA     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (863, 8, N'HUANCAVELICA   ', 6, N'HUAYTARA                      ', 11, N'SAN FRANCISCO DE SANGAYAICO   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (864, 8, N'HUANCAVELICA   ', 6, N'HUAYTARA                      ', 12, N'SAN ISIDRO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (865, 8, N'HUANCAVELICA   ', 6, N'HUAYTARA                      ', 13, N'SANTIAGO DE CHOCORVOS         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (866, 8, N'HUANCAVELICA   ', 6, N'HUAYTARA                      ', 14, N'SANTIAGO DE QUIRAHUARA        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (867, 8, N'HUANCAVELICA   ', 6, N'HUAYTARA                      ', 15, N'SANTO DOMINGO DE CAPILLAS     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (868, 8, N'HUANCAVELICA   ', 6, N'HUAYTARA                      ', 16, N'TAMBO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (869, 8, N'HUANCAVELICA   ', 7, N'CHURCAMPA                     ', 1, N'CHURCAMPA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (870, 8, N'HUANCAVELICA   ', 7, N'CHURCAMPA                     ', 2, N'ANCO                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (871, 8, N'HUANCAVELICA   ', 7, N'CHURCAMPA                     ', 3, N'CHINCHIHUASI                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (872, 8, N'HUANCAVELICA   ', 7, N'CHURCAMPA                     ', 4, N'EL CARMEN                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (873, 8, N'HUANCAVELICA   ', 7, N'CHURCAMPA                     ', 5, N'LA MERCED                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (874, 8, N'HUANCAVELICA   ', 7, N'CHURCAMPA                     ', 6, N'LOCROJA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (875, 8, N'HUANCAVELICA   ', 7, N'CHURCAMPA                     ', 7, N'PAUCARBAMBA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (876, 8, N'HUANCAVELICA   ', 7, N'CHURCAMPA                     ', 8, N'SAN MIGUEL DE MAYOC           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (877, 8, N'HUANCAVELICA   ', 7, N'CHURCAMPA                     ', 9, N'SAN PEDRO DE CORIS            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (878, 8, N'HUANCAVELICA   ', 7, N'CHURCAMPA                     ', 10, N'PACHAMARCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (879, 9, N'HUANUCO        ', 1, N'HUANUCO                       ', 1, N'HUANUCO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (880, 9, N'HUANUCO        ', 1, N'HUANUCO                       ', 2, N'CHINCHAO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (881, 9, N'HUANUCO        ', 1, N'HUANUCO                       ', 3, N'CHURUBAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (882, 9, N'HUANUCO        ', 1, N'HUANUCO                       ', 4, N'MARGOS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (883, 9, N'HUANUCO        ', 1, N'HUANUCO                       ', 5, N'QUISQUI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (884, 9, N'HUANUCO        ', 1, N'HUANUCO                       ', 6, N'SAN FCO DE CAYRAN             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (885, 9, N'HUANUCO        ', 1, N'HUANUCO                       ', 7, N'SAN PEDRO DE CHAULAN          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (886, 9, N'HUANUCO        ', 1, N'HUANUCO                       ', 8, N'STA MARIA DEL VALLE           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (887, 9, N'HUANUCO        ', 1, N'HUANUCO                       ', 9, N'YARUMAYO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (888, 9, N'HUANUCO        ', 1, N'HUANUCO                       ', 10, N'AMARILIS                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (889, 9, N'HUANUCO        ', 1, N'HUANUCO                       ', 11, N'PILLCO MARCA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (890, 9, N'HUANUCO        ', 2, N'AMBO                          ', 1, N'AMBO                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (891, 9, N'HUANUCO        ', 2, N'AMBO                          ', 2, N'CAYNA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (892, 9, N'HUANUCO        ', 2, N'AMBO                          ', 3, N'COLPAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (893, 9, N'HUANUCO        ', 2, N'AMBO                          ', 4, N'CONCHAMARCA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (894, 9, N'HUANUCO        ', 2, N'AMBO                          ', 5, N'HUACAR                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (895, 9, N'HUANUCO        ', 2, N'AMBO                          ', 6, N'SAN FRANCISCO                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (896, 9, N'HUANUCO        ', 2, N'AMBO                          ', 7, N'SAN RAFAEL                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (897, 9, N'HUANUCO        ', 2, N'AMBO                          ', 8, N'TOMAY KICHWA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (898, 9, N'HUANUCO        ', 3, N'DOS DE MAYO                   ', 1, N'LA UNION                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (899, 9, N'HUANUCO        ', 3, N'DOS DE MAYO                   ', 7, N'CHUQUIS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (900, 9, N'HUANUCO        ', 3, N'DOS DE MAYO                   ', 12, N'MARIAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (901, 9, N'HUANUCO        ', 3, N'DOS DE MAYO                   ', 14, N'PACHAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (902, 9, N'HUANUCO        ', 3, N'DOS DE MAYO                   ', 16, N'QUIVILLA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (903, 9, N'HUANUCO        ', 3, N'DOS DE MAYO                   ', 17, N'RIPAN                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (904, 9, N'HUANUCO        ', 3, N'DOS DE MAYO                   ', 21, N'SHUNQUI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (905, 9, N'HUANUCO        ', 3, N'DOS DE MAYO                   ', 22, N'SILLAPATA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (906, 9, N'HUANUCO        ', 3, N'DOS DE MAYO                   ', 23, N'YANAS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (907, 9, N'HUANUCO        ', 4, N'HUAMALIES                     ', 1, N'LLATA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (908, 9, N'HUANUCO        ', 4, N'HUAMALIES                     ', 2, N'ARANCAY                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (909, 9, N'HUANUCO        ', 4, N'HUAMALIES                     ', 3, N'CHAVIN DE PARIARCA            ')
GO
print 'Processed 900 total records'
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (910, 9, N'HUANUCO        ', 4, N'HUAMALIES                     ', 4, N'JACAS GRANDE                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (911, 9, N'HUANUCO        ', 4, N'HUAMALIES                     ', 5, N'JIRCAN                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (912, 9, N'HUANUCO        ', 4, N'HUAMALIES                     ', 6, N'MIRAFLORES                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (913, 9, N'HUANUCO        ', 4, N'HUAMALIES                     ', 7, N'MONZON                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (914, 9, N'HUANUCO        ', 4, N'HUAMALIES                     ', 8, N'PUNCHAO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (915, 9, N'HUANUCO        ', 4, N'HUAMALIES                     ', 9, N'PUÑOS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (916, 9, N'HUANUCO        ', 4, N'HUAMALIES                     ', 10, N'SINGA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (917, 9, N'HUANUCO        ', 4, N'HUAMALIES                     ', 11, N'TANTAMAYO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (918, 9, N'HUANUCO        ', 5, N'MARAÑON                       ', 1, N'HUACRACHUCO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (919, 9, N'HUANUCO        ', 5, N'MARAÑON                       ', 2, N'CHOLON                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (920, 9, N'HUANUCO        ', 5, N'MARAÑON                       ', 5, N'SAN BUENAVENTURA              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (921, 9, N'HUANUCO        ', 6, N'LEONCIO PRADO                 ', 1, N'RUPA RUPA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (922, 9, N'HUANUCO        ', 6, N'LEONCIO PRADO                 ', 2, N'DANIEL ALOMIA ROBLES          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (923, 9, N'HUANUCO        ', 6, N'LEONCIO PRADO                 ', 3, N'HERMILIO VALDIZAN             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (924, 9, N'HUANUCO        ', 6, N'LEONCIO PRADO                 ', 4, N'LUYANDO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (925, 9, N'HUANUCO        ', 6, N'LEONCIO PRADO                 ', 5, N'MARIANO DAMASO BERAUN         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (926, 9, N'HUANUCO        ', 6, N'LEONCIO PRADO                 ', 6, N'JOSE CRESPO Y CASTILLO        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (927, 9, N'HUANUCO        ', 7, N'PACHITEA                      ', 1, N'PANAO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (928, 9, N'HUANUCO        ', 7, N'PACHITEA                      ', 2, N'CHAGLLA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (929, 9, N'HUANUCO        ', 7, N'PACHITEA                      ', 4, N'MOLINO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (930, 9, N'HUANUCO        ', 7, N'PACHITEA                      ', 6, N'UMARI                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (931, 9, N'HUANUCO        ', 8, N'PUERTO INCA                   ', 1, N'HONORIA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (932, 9, N'HUANUCO        ', 8, N'PUERTO INCA                   ', 2, N'PUERTO INCA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (933, 9, N'HUANUCO        ', 8, N'PUERTO INCA                   ', 3, N'CODO DEL POZUZO               ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (934, 9, N'HUANUCO        ', 8, N'PUERTO INCA                   ', 4, N'TOURNAVISTA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (935, 9, N'HUANUCO        ', 8, N'PUERTO INCA                   ', 5, N'YUYAPICHIS                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (936, 9, N'HUANUCO        ', 9, N'HUACAYBAMBA                   ', 1, N'HUACAYBAMBA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (937, 9, N'HUANUCO        ', 9, N'HUACAYBAMBA                   ', 2, N'PINRA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (938, 9, N'HUANUCO        ', 9, N'HUACAYBAMBA                   ', 3, N'CANCHABAMBA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (939, 9, N'HUANUCO        ', 9, N'HUACAYBAMBA                   ', 4, N'COCHABAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (940, 9, N'HUANUCO        ', 10, N'LAURICOCHA                    ', 1, N'JESUS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (941, 9, N'HUANUCO        ', 10, N'LAURICOCHA                    ', 2, N'BAÑOS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (942, 9, N'HUANUCO        ', 10, N'LAURICOCHA                    ', 3, N'SAN FRANCISCO DE ASIS         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (943, 9, N'HUANUCO        ', 10, N'LAURICOCHA                    ', 4, N'QUEROPALCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (944, 9, N'HUANUCO        ', 10, N'LAURICOCHA                    ', 5, N'SAN MIGUEL DE CAURI           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (945, 9, N'HUANUCO        ', 10, N'LAURICOCHA                    ', 6, N'RONDOS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (946, 9, N'HUANUCO        ', 10, N'LAURICOCHA                    ', 7, N'JIVIA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (947, 9, N'HUANUCO        ', 11, N'YAROWILCA                     ', 1, N'CHAVINILLO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (948, 9, N'HUANUCO        ', 11, N'YAROWILCA                     ', 2, N'APARICIO POMARES (CHUPAN)     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (949, 9, N'HUANUCO        ', 11, N'YAROWILCA                     ', 3, N'CAHUAC                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (950, 9, N'HUANUCO        ', 11, N'YAROWILCA                     ', 4, N'CHACABAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (951, 9, N'HUANUCO        ', 11, N'YAROWILCA                     ', 5, N'JACAS CHICO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (952, 9, N'HUANUCO        ', 11, N'YAROWILCA                     ', 6, N'OBAS                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (953, 9, N'HUANUCO        ', 11, N'YAROWILCA                     ', 7, N'PAMPAMARCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (954, 9, N'HUANUCO        ', 11, N'YAROWILCA                     ', 8, N'CHORAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (955, 10, N'ICA            ', 1, N'ICA                           ', 1, N'ICA                           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (956, 10, N'ICA            ', 1, N'ICA                           ', 2, N'LA TINGUIÑA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (957, 10, N'ICA            ', 1, N'ICA                           ', 3, N'LOS AQUIJES                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (958, 10, N'ICA            ', 1, N'ICA                           ', 4, N'PARCONA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (959, 10, N'ICA            ', 1, N'ICA                           ', 5, N'PUEBLO NUEVO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (960, 10, N'ICA            ', 1, N'ICA                           ', 6, N'SALAS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (961, 10, N'ICA            ', 1, N'ICA                           ', 7, N'SAN JOSE DE LOS MOLINOS       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (962, 10, N'ICA            ', 1, N'ICA                           ', 8, N'SAN JUAN BAUTISTA             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (963, 10, N'ICA            ', 1, N'ICA                           ', 9, N'SANTIAGO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (964, 10, N'ICA            ', 1, N'ICA                           ', 10, N'SUBTANJALLA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (965, 10, N'ICA            ', 1, N'ICA                           ', 11, N'YAUCA DEL ROSARIO             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (966, 10, N'ICA            ', 1, N'ICA                           ', 12, N'TATE                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (967, 10, N'ICA            ', 1, N'ICA                           ', 13, N'PACHACUTEC                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (968, 10, N'ICA            ', 1, N'ICA                           ', 14, N'OCUCAJE                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (969, 10, N'ICA            ', 2, N'CHINCHA                       ', 1, N'CHINCHA ALTA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (970, 10, N'ICA            ', 2, N'CHINCHA                       ', 2, N'CHAVIN                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (971, 10, N'ICA            ', 2, N'CHINCHA                       ', 3, N'CHINCHA BAJA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (972, 10, N'ICA            ', 2, N'CHINCHA                       ', 4, N'EL CARMEN                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (973, 10, N'ICA            ', 2, N'CHINCHA                       ', 5, N'GROCIO PRADO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (974, 10, N'ICA            ', 2, N'CHINCHA                       ', 6, N'SAN PEDRO DE HUACARPANA       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (975, 10, N'ICA            ', 2, N'CHINCHA                       ', 7, N'SUNAMPE                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (976, 10, N'ICA            ', 2, N'CHINCHA                       ', 8, N'TAMBO DE MORA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (977, 10, N'ICA            ', 2, N'CHINCHA                       ', 9, N'ALTO LARAN                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (978, 10, N'ICA            ', 2, N'CHINCHA                       ', 10, N'PUEBLO NUEVO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (979, 10, N'ICA            ', 2, N'CHINCHA                       ', 11, N'SAN JUAN DE YANAC             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (980, 10, N'ICA            ', 3, N'NAZCA                         ', 1, N'NAZCA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (981, 10, N'ICA            ', 3, N'NAZCA                         ', 2, N'CHANGUILLO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (982, 10, N'ICA            ', 3, N'NAZCA                         ', 3, N'EL INGENIO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (983, 10, N'ICA            ', 3, N'NAZCA                         ', 4, N'MARCONA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (984, 10, N'ICA            ', 3, N'NAZCA                         ', 5, N'VISTA ALEGRE                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (985, 10, N'ICA            ', 4, N'PISCO                         ', 1, N'PISCO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (986, 10, N'ICA            ', 4, N'PISCO                         ', 2, N'HUANCANO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (987, 10, N'ICA            ', 4, N'PISCO                         ', 3, N'HUMAY                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (988, 10, N'ICA            ', 4, N'PISCO                         ', 4, N'INDEPENDENCIA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (989, 10, N'ICA            ', 4, N'PISCO                         ', 5, N'PARACAS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (990, 10, N'ICA            ', 4, N'PISCO                         ', 6, N'SAN ANDRES                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (991, 10, N'ICA            ', 4, N'PISCO                         ', 7, N'SAN CLEMENTE                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (992, 10, N'ICA            ', 4, N'PISCO                         ', 8, N'TUPAC AMARU INCA              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (993, 10, N'ICA            ', 5, N'PALPA                         ', 1, N'PALPA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (994, 10, N'ICA            ', 5, N'PALPA                         ', 2, N'LLIPATA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (995, 10, N'ICA            ', 5, N'PALPA                         ', 3, N'RIO GRANDE                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (996, 10, N'ICA            ', 5, N'PALPA                         ', 4, N'SANTA CRUZ                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (997, 10, N'ICA            ', 5, N'PALPA                         ', 5, N'TIBILLO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (998, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 1, N'HUANCAYO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (999, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 3, N'CARHUACALLANGA                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1000, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 4, N'COLCA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1001, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 5, N'CULLHUAS                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1002, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 6, N'CHACAPAMPA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1003, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 7, N'CHICCHE                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1004, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 8, N'CHILCA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1005, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 9, N'CHONGOS ALTO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1006, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 12, N'CHUPURO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1007, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 13, N'EL TAMBO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1008, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 14, N'HUACRAPUQUIO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1009, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 16, N'HUALHUAS                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1010, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 18, N'HUANCAN                       ')
GO
print 'Processed 1000 total records'
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1011, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 19, N'HUASICANCHA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1012, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 20, N'HUAYUCACHI                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1013, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 21, N'INGENIO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1014, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 22, N'PARIAHUANCA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1015, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 23, N'PILCOMAYO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1016, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 24, N'PUCARA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1017, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 25, N'QUICHUAY                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1018, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 26, N'QUILCAS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1019, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 27, N'SAN AGUSTIN                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1020, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 28, N'SAN JERONIMO DE TUNAN         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1021, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 31, N'STO DOMINGO DE ACOBAMBA       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1022, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 32, N'SAÑO                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1023, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 33, N'SAPALLANGA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1024, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 34, N'SICAYA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1025, 11, N'JUNIN          ', 1, N'HUANCAYO                      ', 36, N'VIQUES                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1026, 11, N'JUNIN          ', 2, N'CONCEPCION                    ', 1, N'CONCEPCION                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1027, 11, N'JUNIN          ', 2, N'CONCEPCION                    ', 2, N'ACO                           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1028, 11, N'JUNIN          ', 2, N'CONCEPCION                    ', 3, N'ANDAMARCA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1029, 11, N'JUNIN          ', 2, N'CONCEPCION                    ', 4, N'COMAS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1030, 11, N'JUNIN          ', 2, N'CONCEPCION                    ', 5, N'COCHAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1031, 11, N'JUNIN          ', 2, N'CONCEPCION                    ', 6, N'CHAMBARA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1032, 11, N'JUNIN          ', 2, N'CONCEPCION                    ', 7, N'HEROINAS TOLEDO               ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1033, 11, N'JUNIN          ', 2, N'CONCEPCION                    ', 8, N'MANZANARES                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1034, 11, N'JUNIN          ', 2, N'CONCEPCION                    ', 9, N'MCAL CASTILLA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1035, 11, N'JUNIN          ', 2, N'CONCEPCION                    ', 10, N'MATAHUASI                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1036, 11, N'JUNIN          ', 2, N'CONCEPCION                    ', 11, N'MITO                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1037, 11, N'JUNIN          ', 2, N'CONCEPCION                    ', 12, N'NUEVE DE JULIO                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1038, 11, N'JUNIN          ', 2, N'CONCEPCION                    ', 13, N'ORCOTUNA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1039, 11, N'JUNIN          ', 2, N'CONCEPCION                    ', 14, N'STA ROSA DE OCOPA             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1040, 11, N'JUNIN          ', 2, N'CONCEPCION                    ', 15, N'SAN JOSE DE QUERO             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1041, 11, N'JUNIN          ', 3, N'JAUJA                         ', 1, N'JAUJA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1042, 11, N'JUNIN          ', 3, N'JAUJA                         ', 2, N'ACOLLA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1043, 11, N'JUNIN          ', 3, N'JAUJA                         ', 3, N'APATA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1044, 11, N'JUNIN          ', 3, N'JAUJA                         ', 4, N'ATAURA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1045, 11, N'JUNIN          ', 3, N'JAUJA                         ', 5, N'CANCHAILLO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1046, 11, N'JUNIN          ', 3, N'JAUJA                         ', 6, N'EL MANTARO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1047, 11, N'JUNIN          ', 3, N'JAUJA                         ', 7, N'HUAMALI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1048, 11, N'JUNIN          ', 3, N'JAUJA                         ', 8, N'HUARIPAMPA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1049, 11, N'JUNIN          ', 3, N'JAUJA                         ', 9, N'HUERTAS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1050, 11, N'JUNIN          ', 3, N'JAUJA                         ', 10, N'JANJAILLO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1051, 11, N'JUNIN          ', 3, N'JAUJA                         ', 11, N'JULCAN                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1052, 11, N'JUNIN          ', 3, N'JAUJA                         ', 12, N'LEONOR ORDOÑEZ                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1053, 11, N'JUNIN          ', 3, N'JAUJA                         ', 13, N'LLOCLLAPAMPA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1054, 11, N'JUNIN          ', 3, N'JAUJA                         ', 14, N'MARCO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1055, 11, N'JUNIN          ', 3, N'JAUJA                         ', 15, N'MASMA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1056, 11, N'JUNIN          ', 3, N'JAUJA                         ', 16, N'MOLINOS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1057, 11, N'JUNIN          ', 3, N'JAUJA                         ', 17, N'MONOBAMBA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1058, 11, N'JUNIN          ', 3, N'JAUJA                         ', 18, N'MUQUI                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1059, 11, N'JUNIN          ', 3, N'JAUJA                         ', 19, N'MUQUIYAUYO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1060, 11, N'JUNIN          ', 3, N'JAUJA                         ', 20, N'PACA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1061, 11, N'JUNIN          ', 3, N'JAUJA                         ', 21, N'PACCHA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1062, 11, N'JUNIN          ', 3, N'JAUJA                         ', 22, N'PANCAN                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1063, 11, N'JUNIN          ', 3, N'JAUJA                         ', 23, N'PARCO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1064, 11, N'JUNIN          ', 3, N'JAUJA                         ', 24, N'POMACANCHA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1065, 11, N'JUNIN          ', 3, N'JAUJA                         ', 25, N'RICRAN                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1066, 11, N'JUNIN          ', 3, N'JAUJA                         ', 26, N'SAN LORENZO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1067, 11, N'JUNIN          ', 3, N'JAUJA                         ', 27, N'SAN PEDRO DE CHUNAN           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1068, 11, N'JUNIN          ', 3, N'JAUJA                         ', 28, N'SINCOS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1069, 11, N'JUNIN          ', 3, N'JAUJA                         ', 29, N'TUNAN MARCA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1070, 11, N'JUNIN          ', 3, N'JAUJA                         ', 30, N'YAULI                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1071, 11, N'JUNIN          ', 3, N'JAUJA                         ', 31, N'CURICACA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1072, 11, N'JUNIN          ', 3, N'JAUJA                         ', 32, N'MASMA CHICCHE                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1073, 11, N'JUNIN          ', 3, N'JAUJA                         ', 33, N'SAUSA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1074, 11, N'JUNIN          ', 3, N'JAUJA                         ', 34, N'YAUYOS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1075, 11, N'JUNIN          ', 4, N'JUNIN                         ', 1, N'JUNIN                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1076, 11, N'JUNIN          ', 4, N'JUNIN                         ', 2, N'CARHUAMAYO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1077, 11, N'JUNIN          ', 4, N'JUNIN                         ', 3, N'ONDORES                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1078, 11, N'JUNIN          ', 4, N'JUNIN                         ', 4, N'ULCUMAYO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1079, 11, N'JUNIN          ', 5, N'TARMA                         ', 1, N'TARMA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1080, 11, N'JUNIN          ', 5, N'TARMA                         ', 2, N'ACOBAMBA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1081, 11, N'JUNIN          ', 5, N'TARMA                         ', 3, N'HUARICOLCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1082, 11, N'JUNIN          ', 5, N'TARMA                         ', 4, N'HUASAHUASI                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1083, 11, N'JUNIN          ', 5, N'TARMA                         ', 5, N'LA UNION                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1084, 11, N'JUNIN          ', 5, N'TARMA                         ', 6, N'PALCA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1085, 11, N'JUNIN          ', 5, N'TARMA                         ', 7, N'PALCAMAYO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1086, 11, N'JUNIN          ', 5, N'TARMA                         ', 8, N'SAN PEDRO DE CAJAS            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1087, 11, N'JUNIN          ', 5, N'TARMA                         ', 9, N'TAPO                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1088, 11, N'JUNIN          ', 6, N'YAULI                         ', 1, N'LA OROYA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1089, 11, N'JUNIN          ', 6, N'YAULI                         ', 2, N'CHACAPALPA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1090, 11, N'JUNIN          ', 6, N'YAULI                         ', 3, N'HUAY HUAY                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1091, 11, N'JUNIN          ', 6, N'YAULI                         ', 4, N'MARCAPOMACOCHA                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1092, 11, N'JUNIN          ', 6, N'YAULI                         ', 5, N'MOROCOCHA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1093, 11, N'JUNIN          ', 6, N'YAULI                         ', 6, N'PACCHA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1094, 11, N'JUNIN          ', 6, N'YAULI                         ', 7, N'STA BARBARA DE CARHUACAYAN    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1095, 11, N'JUNIN          ', 6, N'YAULI                         ', 8, N'SUITUCANCHA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1096, 11, N'JUNIN          ', 6, N'YAULI                         ', 9, N'YAULI                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1097, 11, N'JUNIN          ', 6, N'YAULI                         ', 10, N'STA ROSA DE SACCO             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1098, 11, N'JUNIN          ', 7, N'SATIPO                        ', 1, N'SATIPO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1099, 11, N'JUNIN          ', 7, N'SATIPO                        ', 2, N'COVIRIALI                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1100, 11, N'JUNIN          ', 7, N'SATIPO                        ', 3, N'LLAYLLA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1101, 11, N'JUNIN          ', 7, N'SATIPO                        ', 4, N'MAZAMARI                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1102, 11, N'JUNIN          ', 7, N'SATIPO                        ', 5, N'PAMPA HERMOSA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1103, 11, N'JUNIN          ', 7, N'SATIPO                        ', 6, N'PANGOA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1104, 11, N'JUNIN          ', 7, N'SATIPO                        ', 7, N'RIO NEGRO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1105, 11, N'JUNIN          ', 7, N'SATIPO                        ', 8, N'RIO TAMBO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1106, 11, N'JUNIN          ', 8, N'CHANCHAMAYO                   ', 1, N'CHANCHAMAYO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1107, 11, N'JUNIN          ', 8, N'CHANCHAMAYO                   ', 2, N'SAN RAMON                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1108, 11, N'JUNIN          ', 8, N'CHANCHAMAYO                   ', 3, N'VITOC                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1109, 11, N'JUNIN          ', 8, N'CHANCHAMAYO                   ', 4, N'SAN LUIS DE SHUARO            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1110, 11, N'JUNIN          ', 8, N'CHANCHAMAYO                   ', 5, N'PICHANAQUI                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1111, 11, N'JUNIN          ', 8, N'CHANCHAMAYO                   ', 6, N'PERENE                        ')
GO
print 'Processed 1100 total records'
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1112, 11, N'JUNIN          ', 9, N'CHUPACA                       ', 1, N'CHUPACA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1113, 11, N'JUNIN          ', 9, N'CHUPACA                       ', 2, N'AHUAC                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1114, 11, N'JUNIN          ', 9, N'CHUPACA                       ', 3, N'CHONGOS BAJO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1115, 11, N'JUNIN          ', 9, N'CHUPACA                       ', 4, N'HUACHAC                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1116, 11, N'JUNIN          ', 9, N'CHUPACA                       ', 5, N'HUAMANCACA CHICO              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1117, 11, N'JUNIN          ', 9, N'CHUPACA                       ', 6, N'SAN JUAN DE ISCOS             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1118, 11, N'JUNIN          ', 9, N'CHUPACA                       ', 7, N'SAN JUAN DE JARPA             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1119, 11, N'JUNIN          ', 9, N'CHUPACA                       ', 8, N'TRES DE DICIEMBRE             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1120, 11, N'JUNIN          ', 9, N'CHUPACA                       ', 9, N'YANACANCHA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1121, 12, N'LA LIBERTAD    ', 1, N'TRUJILLO                      ', 1, N'TRUJILLO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1122, 12, N'LA LIBERTAD    ', 1, N'TRUJILLO                      ', 2, N'HUANCHACO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1123, 12, N'LA LIBERTAD    ', 1, N'TRUJILLO                      ', 3, N'LAREDO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1124, 12, N'LA LIBERTAD    ', 1, N'TRUJILLO                      ', 4, N'MOCHE                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1125, 12, N'LA LIBERTAD    ', 1, N'TRUJILLO                      ', 5, N'SALAVERRY                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1126, 12, N'LA LIBERTAD    ', 1, N'TRUJILLO                      ', 6, N'SIMBAL                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1127, 12, N'LA LIBERTAD    ', 1, N'TRUJILLO                      ', 7, N'VICTOR LARCO HERRERA          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1128, 12, N'LA LIBERTAD    ', 1, N'TRUJILLO                      ', 9, N'POROTO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1129, 12, N'LA LIBERTAD    ', 1, N'TRUJILLO                      ', 10, N'EL PORVENIR                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1130, 12, N'LA LIBERTAD    ', 1, N'TRUJILLO                      ', 11, N'LA ESPERANZA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1131, 12, N'LA LIBERTAD    ', 1, N'TRUJILLO                      ', 12, N'FLORENCIA DE MORA             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1132, 12, N'LA LIBERTAD    ', 2, N'BOLIVAR                       ', 1, N'BOLIVAR                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1133, 12, N'LA LIBERTAD    ', 2, N'BOLIVAR                       ', 2, N'BAMBAMARCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1134, 12, N'LA LIBERTAD    ', 2, N'BOLIVAR                       ', 3, N'CONDORMARCA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1135, 12, N'LA LIBERTAD    ', 2, N'BOLIVAR                       ', 4, N'LONGOTEA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1136, 12, N'LA LIBERTAD    ', 2, N'BOLIVAR                       ', 5, N'UCUNCHA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1137, 12, N'LA LIBERTAD    ', 2, N'BOLIVAR                       ', 6, N'UCHUMARCA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1138, 12, N'LA LIBERTAD    ', 3, N'SANCHEZ CARRION               ', 1, N'HUAMACHUCO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1139, 12, N'LA LIBERTAD    ', 3, N'SANCHEZ CARRION               ', 2, N'COCHORCO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1140, 12, N'LA LIBERTAD    ', 3, N'SANCHEZ CARRION               ', 3, N'CURGOS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1141, 12, N'LA LIBERTAD    ', 3, N'SANCHEZ CARRION               ', 4, N'CHUGAY                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1142, 12, N'LA LIBERTAD    ', 3, N'SANCHEZ CARRION               ', 5, N'MARCABAL                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1143, 12, N'LA LIBERTAD    ', 3, N'SANCHEZ CARRION               ', 6, N'SANAGORAN                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1144, 12, N'LA LIBERTAD    ', 3, N'SANCHEZ CARRION               ', 7, N'SARIN                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1145, 12, N'LA LIBERTAD    ', 3, N'SANCHEZ CARRION               ', 8, N'SARTIMBAMBA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1146, 12, N'LA LIBERTAD    ', 4, N'OTUZCO                        ', 1, N'OTUZCO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1147, 12, N'LA LIBERTAD    ', 4, N'OTUZCO                        ', 2, N'AGALLPAMPA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1148, 12, N'LA LIBERTAD    ', 4, N'OTUZCO                        ', 3, N'CHARAT                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1149, 12, N'LA LIBERTAD    ', 4, N'OTUZCO                        ', 4, N'HUARANCHAL                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1150, 12, N'LA LIBERTAD    ', 4, N'OTUZCO                        ', 5, N'LA CUESTA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1151, 12, N'LA LIBERTAD    ', 4, N'OTUZCO                        ', 8, N'PARANDAY                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1152, 12, N'LA LIBERTAD    ', 4, N'OTUZCO                        ', 9, N'SALPO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1153, 12, N'LA LIBERTAD    ', 4, N'OTUZCO                        ', 10, N'SINSICAP                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1154, 12, N'LA LIBERTAD    ', 4, N'OTUZCO                        ', 11, N'USQUIL                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1155, 12, N'LA LIBERTAD    ', 4, N'OTUZCO                        ', 13, N'MACHE                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1156, 12, N'LA LIBERTAD    ', 5, N'PACASMAYO                     ', 1, N'SAN PEDRO DE LLOC             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1157, 12, N'LA LIBERTAD    ', 5, N'PACASMAYO                     ', 3, N'GUADALUPE                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1158, 12, N'LA LIBERTAD    ', 5, N'PACASMAYO                     ', 4, N'JEQUETEPEQUE                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1159, 12, N'LA LIBERTAD    ', 5, N'PACASMAYO                     ', 6, N'PACASMAYO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1160, 12, N'LA LIBERTAD    ', 5, N'PACASMAYO                     ', 8, N'SAN JOSE                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1161, 12, N'LA LIBERTAD    ', 6, N'PATAZ                         ', 1, N'TAYABAMBA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1162, 12, N'LA LIBERTAD    ', 6, N'PATAZ                         ', 2, N'BULDIBUYO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1163, 12, N'LA LIBERTAD    ', 6, N'PATAZ                         ', 3, N'CHILLIA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1164, 12, N'LA LIBERTAD    ', 6, N'PATAZ                         ', 4, N'HUAYLILLAS                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1165, 12, N'LA LIBERTAD    ', 6, N'PATAZ                         ', 5, N'HUANCASPATA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1166, 12, N'LA LIBERTAD    ', 6, N'PATAZ                         ', 6, N'HUAYO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1167, 12, N'LA LIBERTAD    ', 6, N'PATAZ                         ', 7, N'ONGON                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1168, 12, N'LA LIBERTAD    ', 6, N'PATAZ                         ', 8, N'PARCOY                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1169, 12, N'LA LIBERTAD    ', 6, N'PATAZ                         ', 9, N'PATAZ                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1170, 12, N'LA LIBERTAD    ', 6, N'PATAZ                         ', 10, N'PIAS                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1171, 12, N'LA LIBERTAD    ', 6, N'PATAZ                         ', 11, N'TAURIJA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1172, 12, N'LA LIBERTAD    ', 6, N'PATAZ                         ', 12, N'URPAY                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1173, 12, N'LA LIBERTAD    ', 6, N'PATAZ                         ', 13, N'SANTIAGO DE CHALLAS           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1174, 12, N'LA LIBERTAD    ', 7, N'SANTIAGO DE CHUCO             ', 1, N'SANTIAGO DE CHUCO             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1175, 12, N'LA LIBERTAD    ', 7, N'SANTIAGO DE CHUCO             ', 2, N'CACHICADAN                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1176, 12, N'LA LIBERTAD    ', 7, N'SANTIAGO DE CHUCO             ', 3, N'MOLLEBAMBA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1177, 12, N'LA LIBERTAD    ', 7, N'SANTIAGO DE CHUCO             ', 4, N'MOLLEPATA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1178, 12, N'LA LIBERTAD    ', 7, N'SANTIAGO DE CHUCO             ', 5, N'QUIRUVILCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1179, 12, N'LA LIBERTAD    ', 7, N'SANTIAGO DE CHUCO             ', 6, N'SANTA CRUZ DE CHUCA           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1180, 12, N'LA LIBERTAD    ', 7, N'SANTIAGO DE CHUCO             ', 7, N'SITABAMBA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1181, 12, N'LA LIBERTAD    ', 7, N'SANTIAGO DE CHUCO             ', 8, N'ANGASMARCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1182, 12, N'LA LIBERTAD    ', 8, N'ASCOPE                        ', 1, N'ASCOPE                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1183, 12, N'LA LIBERTAD    ', 8, N'ASCOPE                        ', 2, N'CHICAMA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1184, 12, N'LA LIBERTAD    ', 8, N'ASCOPE                        ', 3, N'CHOCOPE                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1185, 12, N'LA LIBERTAD    ', 8, N'ASCOPE                        ', 4, N'SANTIAGO DE CAO               ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1186, 12, N'LA LIBERTAD    ', 8, N'ASCOPE                        ', 5, N'MAGDALENA DE CAO              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1187, 12, N'LA LIBERTAD    ', 8, N'ASCOPE                        ', 6, N'PAIJAN                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1188, 12, N'LA LIBERTAD    ', 8, N'ASCOPE                        ', 7, N'RAZURI                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1189, 12, N'LA LIBERTAD    ', 8, N'ASCOPE                        ', 8, N'CASA GRANDE                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1190, 12, N'LA LIBERTAD    ', 9, N'CHEPEN                        ', 1, N'CHEPEN                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1191, 12, N'LA LIBERTAD    ', 9, N'CHEPEN                        ', 2, N'PACANGA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1192, 12, N'LA LIBERTAD    ', 9, N'CHEPEN                        ', 3, N'PUEBLO NUEVO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1193, 12, N'LA LIBERTAD    ', 10, N'JULCAN                        ', 1, N'JULCAN                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1194, 12, N'LA LIBERTAD    ', 10, N'JULCAN                        ', 2, N'CARABAMBA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1195, 12, N'LA LIBERTAD    ', 10, N'JULCAN                        ', 3, N'CALAMARCA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1196, 12, N'LA LIBERTAD    ', 10, N'JULCAN                        ', 4, N'HUASO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1197, 12, N'LA LIBERTAD    ', 11, N'GRAN CHIMU                    ', 1, N'CASCAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1198, 12, N'LA LIBERTAD    ', 11, N'GRAN CHIMU                    ', 2, N'LUCMA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1199, 12, N'LA LIBERTAD    ', 11, N'GRAN CHIMU                    ', 3, N'MARMOT                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1200, 12, N'LA LIBERTAD    ', 11, N'GRAN CHIMU                    ', 4, N'SAYAPULLO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1201, 12, N'LA LIBERTAD    ', 12, N'VIRU                          ', 1, N'VIRU                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1202, 12, N'LA LIBERTAD    ', 12, N'VIRU                          ', 2, N'CHAO                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1203, 12, N'LA LIBERTAD    ', 12, N'VIRU                          ', 3, N'GUADALUPITO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1204, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 1, N'CHICLAYO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1205, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 2, N'CHONGOYAPE                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1206, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 3, N'ETEN                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1207, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 4, N'ETEN PUERTO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1208, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 5, N'LAGUNAS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1209, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 6, N'MONSEFU                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1210, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 7, N'NUEVA ARICA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1211, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 8, N'OYOTUN                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1212, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 9, N'PICSI                         ')
GO
print 'Processed 1200 total records'
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1213, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 10, N'PIMENTEL                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1214, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 11, N'REQUE                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1215, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 12, N'JOSE LEONARDO ORTIZ           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1216, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 13, N'SANTA ROSA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1217, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 14, N'SAÑA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1218, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 15, N'LA VICTORIA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1219, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 16, N'CAYALTI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1220, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 17, N'PATAPO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1221, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 18, N'POMALCA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1222, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 19, N'PUCALA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1223, 13, N'LAMBAYEQUE     ', 1, N'CHICLAYO                      ', 20, N'TUMAN                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1224, 13, N'LAMBAYEQUE     ', 2, N'FERREÑAFE                     ', 1, N'FERREÑAFE                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1225, 13, N'LAMBAYEQUE     ', 2, N'FERREÑAFE                     ', 2, N'INCAHUASI                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1226, 13, N'LAMBAYEQUE     ', 2, N'FERREÑAFE                     ', 3, N'CAÑARIS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1227, 13, N'LAMBAYEQUE     ', 2, N'FERREÑAFE                     ', 4, N'PITIPO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1228, 13, N'LAMBAYEQUE     ', 2, N'FERREÑAFE                     ', 5, N'PUEBLO NUEVO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1229, 13, N'LAMBAYEQUE     ', 2, N'FERREÑAFE                     ', 6, N'MANUEL ANTONIO MESONES MURO   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1230, 13, N'LAMBAYEQUE     ', 3, N'LAMBAYEQUE                    ', 1, N'LAMBAYEQUE                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1231, 13, N'LAMBAYEQUE     ', 3, N'LAMBAYEQUE                    ', 2, N'CHOCHOPE                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1232, 13, N'LAMBAYEQUE     ', 3, N'LAMBAYEQUE                    ', 3, N'ILLIMO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1233, 13, N'LAMBAYEQUE     ', 3, N'LAMBAYEQUE                    ', 4, N'JAYANCA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1234, 13, N'LAMBAYEQUE     ', 3, N'LAMBAYEQUE                    ', 5, N'MOCHUMI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1235, 13, N'LAMBAYEQUE     ', 3, N'LAMBAYEQUE                    ', 6, N'MORROPE                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1236, 13, N'LAMBAYEQUE     ', 3, N'LAMBAYEQUE                    ', 7, N'MOTUPE                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1237, 13, N'LAMBAYEQUE     ', 3, N'LAMBAYEQUE                    ', 8, N'OLMOS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1238, 13, N'LAMBAYEQUE     ', 3, N'LAMBAYEQUE                    ', 9, N'PACORA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1239, 13, N'LAMBAYEQUE     ', 3, N'LAMBAYEQUE                    ', 10, N'SALAS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1240, 13, N'LAMBAYEQUE     ', 3, N'LAMBAYEQUE                    ', 11, N'SAN JOSE                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1241, 13, N'LAMBAYEQUE     ', 3, N'LAMBAYEQUE                    ', 12, N'TUCUME                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1242, 14, N'LIMA           ', 1, N'LIMA                          ', 1, N'LIMA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1243, 14, N'LIMA           ', 1, N'LIMA                          ', 2, N'ANCON                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1244, 14, N'LIMA           ', 1, N'LIMA                          ', 3, N'ATE                           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1245, 14, N'LIMA           ', 1, N'LIMA                          ', 4, N'BREÑA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1246, 14, N'LIMA           ', 1, N'LIMA                          ', 5, N'CARABAYLLO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1247, 14, N'LIMA           ', 1, N'LIMA                          ', 6, N'COMAS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1248, 14, N'LIMA           ', 1, N'LIMA                          ', 7, N'CHACLACAYO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1249, 14, N'LIMA           ', 1, N'LIMA                          ', 8, N'CHORRILLOS                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1250, 14, N'LIMA           ', 1, N'LIMA                          ', 9, N'LA VICTORIA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1251, 14, N'LIMA           ', 1, N'LIMA                          ', 10, N'LA MOLINA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1252, 14, N'LIMA           ', 1, N'LIMA                          ', 11, N'LINCE                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1253, 14, N'LIMA           ', 1, N'LIMA                          ', 12, N'LURIGANCHO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1254, 14, N'LIMA           ', 1, N'LIMA                          ', 13, N'LURIN                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1255, 14, N'LIMA           ', 1, N'LIMA                          ', 14, N'MAGDALENA DEL MAR             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1256, 14, N'LIMA           ', 1, N'LIMA                          ', 15, N'MIRAFLORES                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1257, 14, N'LIMA           ', 1, N'LIMA                          ', 16, N'PACHACAMAC                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1258, 14, N'LIMA           ', 1, N'LIMA                          ', 17, N'PUEBLO LIBRE                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1259, 14, N'LIMA           ', 1, N'LIMA                          ', 18, N'PUCUSANA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1260, 14, N'LIMA           ', 1, N'LIMA                          ', 19, N'PUENTE PIEDRA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1261, 14, N'LIMA           ', 1, N'LIMA                          ', 20, N'PUNTA HERMOSA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1262, 14, N'LIMA           ', 1, N'LIMA                          ', 21, N'PUNTA NEGRA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1263, 14, N'LIMA           ', 1, N'LIMA                          ', 22, N'RIMAC                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1264, 14, N'LIMA           ', 1, N'LIMA                          ', 23, N'SAN BARTOLO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1265, 14, N'LIMA           ', 1, N'LIMA                          ', 24, N'SAN ISIDRO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1266, 14, N'LIMA           ', 1, N'LIMA                          ', 25, N'BARRANCO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1267, 14, N'LIMA           ', 1, N'LIMA                          ', 26, N'SAN MARTIN DE PORRES          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1268, 14, N'LIMA           ', 1, N'LIMA                          ', 27, N'SAN MIGUEL                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1269, 14, N'LIMA           ', 1, N'LIMA                          ', 28, N'STA MARIA DEL MAR             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1270, 14, N'LIMA           ', 1, N'LIMA                          ', 29, N'SANTA ROSA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1271, 14, N'LIMA           ', 1, N'LIMA                          ', 30, N'SANTIAGO DE SURCO             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1272, 14, N'LIMA           ', 1, N'LIMA                          ', 31, N'SURQUILLO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1273, 14, N'LIMA           ', 1, N'LIMA                          ', 32, N'VILLA MARIA DEL TRIUNFO       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1274, 14, N'LIMA           ', 1, N'LIMA                          ', 33, N'JESUS MARIA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1275, 14, N'LIMA           ', 1, N'LIMA                          ', 34, N'INDEPENDENCIA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1276, 14, N'LIMA           ', 1, N'LIMA                          ', 35, N'EL AGUSTINO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1277, 14, N'LIMA           ', 1, N'LIMA                          ', 36, N'SAN JUAN DE MIRAFLORES        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1278, 14, N'LIMA           ', 1, N'LIMA                          ', 37, N'SAN JUAN DE LURIGANCHO        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1279, 14, N'LIMA           ', 1, N'LIMA                          ', 38, N'SAN LUIS                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1280, 14, N'LIMA           ', 1, N'LIMA                          ', 39, N'CIENEGUILLA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1281, 14, N'LIMA           ', 1, N'LIMA                          ', 40, N'SAN BORJA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1282, 14, N'LIMA           ', 1, N'LIMA                          ', 41, N'VILLA EL SALVADOR             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1283, 14, N'LIMA           ', 1, N'LIMA                          ', 42, N'LOS OLIVOS                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1284, 14, N'LIMA           ', 1, N'LIMA                          ', 43, N'SANTA ANITA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1285, 14, N'LIMA           ', 2, N'CAJATAMBO                     ', 1, N'CAJATAMBO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1286, 14, N'LIMA           ', 2, N'CAJATAMBO                     ', 5, N'COPA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1287, 14, N'LIMA           ', 2, N'CAJATAMBO                     ', 6, N'GORGOR                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1288, 14, N'LIMA           ', 2, N'CAJATAMBO                     ', 7, N'HUANCAPON                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1289, 14, N'LIMA           ', 2, N'CAJATAMBO                     ', 8, N'MANAS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1290, 14, N'LIMA           ', 3, N'CANTA                         ', 1, N'CANTA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1291, 14, N'LIMA           ', 3, N'CANTA                         ', 2, N'ARAHUAY                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1292, 14, N'LIMA           ', 3, N'CANTA                         ', 3, N'HUAMANTANGA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1293, 14, N'LIMA           ', 3, N'CANTA                         ', 4, N'HUAROS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1294, 14, N'LIMA           ', 3, N'CANTA                         ', 5, N'LACHAQUI                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1295, 14, N'LIMA           ', 3, N'CANTA                         ', 6, N'SAN BUENAVENTURA              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1296, 14, N'LIMA           ', 3, N'CANTA                         ', 7, N'SANTA ROSA DE QUIVES          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1297, 14, N'LIMA           ', 4, N'CAÑETE                        ', 1, N'SAN VICENTE DE CAÑETE         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1298, 14, N'LIMA           ', 4, N'CAÑETE                        ', 2, N'CALANGO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1299, 14, N'LIMA           ', 4, N'CAÑETE                        ', 3, N'CERRO AZUL                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1300, 14, N'LIMA           ', 4, N'CAÑETE                        ', 4, N'COAYLLO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1301, 14, N'LIMA           ', 4, N'CAÑETE                        ', 5, N'CHILCA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1302, 14, N'LIMA           ', 4, N'CAÑETE                        ', 6, N'IMPERIAL                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1303, 14, N'LIMA           ', 4, N'CAÑETE                        ', 7, N'LUNAHUANA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1304, 14, N'LIMA           ', 4, N'CAÑETE                        ', 8, N'MALA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1305, 14, N'LIMA           ', 4, N'CAÑETE                        ', 9, N'NUEVO IMPERIAL                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1306, 14, N'LIMA           ', 4, N'CAÑETE                        ', 10, N'PACARAN                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1307, 14, N'LIMA           ', 4, N'CAÑETE                        ', 11, N'QUILMANA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1308, 14, N'LIMA           ', 4, N'CAÑETE                        ', 12, N'SAN ANTONIO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1309, 14, N'LIMA           ', 4, N'CAÑETE                        ', 13, N'SAN LUIS                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1310, 14, N'LIMA           ', 4, N'CAÑETE                        ', 14, N'SANTA CRUZ DE FLORES          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1311, 14, N'LIMA           ', 4, N'CAÑETE                        ', 15, N'ZUÑIGA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1312, 14, N'LIMA           ', 4, N'CAÑETE                        ', 16, N'ASIA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1313, 14, N'LIMA           ', 5, N'HUAURA                        ', 1, N'HUACHO                        ')
GO
print 'Processed 1300 total records'
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1314, 14, N'LIMA           ', 5, N'HUAURA                        ', 2, N'AMBAR                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1315, 14, N'LIMA           ', 5, N'HUAURA                        ', 4, N'CALETA DE CARQUIN             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1316, 14, N'LIMA           ', 5, N'HUAURA                        ', 5, N'CHECRAS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1317, 14, N'LIMA           ', 5, N'HUAURA                        ', 6, N'HUALMAY                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1318, 14, N'LIMA           ', 5, N'HUAURA                        ', 7, N'HUAURA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1319, 14, N'LIMA           ', 5, N'HUAURA                        ', 8, N'LEONCIO PRADO                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1320, 14, N'LIMA           ', 5, N'HUAURA                        ', 9, N'PACCHO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1321, 14, N'LIMA           ', 5, N'HUAURA                        ', 11, N'SANTA LEONOR                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1322, 14, N'LIMA           ', 5, N'HUAURA                        ', 12, N'SANTA MARIA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1323, 14, N'LIMA           ', 5, N'HUAURA                        ', 13, N'SAYAN                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1324, 14, N'LIMA           ', 5, N'HUAURA                        ', 16, N'VEGUETA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1325, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 1, N'MATUCANA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1326, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 2, N'ANTIOQUIA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1327, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 3, N'CALLAHUANCA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1328, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 4, N'CARAMPOMA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1329, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 5, N'CASTA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1330, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 6, N'SAN JOSE DE LOS CHORRILLOS    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1331, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 7, N'CHICLA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1332, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 8, N'HUANZA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1333, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 9, N'HUAROCHIRI                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1334, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 10, N'LAHUAYTAMBO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1335, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 11, N'LANGA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1336, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 12, N'MARIATANA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1337, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 13, N'RICARDO PALMA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1338, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 14, N'SAN ANDRES DE TUPICOCHA       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1339, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 15, N'SAN ANTONIO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1340, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 16, N'SAN BARTOLOME                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1341, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 17, N'SAN DAMIAN                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1342, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 18, N'SANGALLAYA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1343, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 19, N'SAN JUAN DE TANTARANCHE       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1344, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 20, N'SAN LORENZO DE QUINTI         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1345, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 21, N'SAN MATEO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1346, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 22, N'SAN MATEO DE OTAO             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1347, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 23, N'SAN PEDRO DE HUANCAYRE        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1348, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 24, N'SANTA CRUZ DE COCACHACRA      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1349, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 25, N'SANTA EULALIA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1350, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 26, N'SANTIAGO DE ANCHUCAYA         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1351, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 27, N'SANTIAGO DE TUNA              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1352, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 28, N'SANTO DOMINGO DE LOS OLLEROS  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1353, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 29, N'SURCO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1354, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 30, N'HUACHUPAMPA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1355, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 31, N'LARAOS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1356, 14, N'LIMA           ', 6, N'HUAROCHIRI                    ', 32, N'SAN JUAN DE IRIS              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1357, 14, N'LIMA           ', 7, N'YAUYOS                        ', 1, N'YAUYOS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1358, 14, N'LIMA           ', 7, N'YAUYOS                        ', 2, N'ALIS                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1359, 14, N'LIMA           ', 7, N'YAUYOS                        ', 3, N'AYAUCA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1360, 14, N'LIMA           ', 7, N'YAUYOS                        ', 4, N'AYAVIRI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1361, 14, N'LIMA           ', 7, N'YAUYOS                        ', 5, N'AZANGARO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1362, 14, N'LIMA           ', 7, N'YAUYOS                        ', 6, N'CACRA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1363, 14, N'LIMA           ', 7, N'YAUYOS                        ', 7, N'CARANIA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1364, 14, N'LIMA           ', 7, N'YAUYOS                        ', 8, N'COCHAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1365, 14, N'LIMA           ', 7, N'YAUYOS                        ', 9, N'COLONIA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1366, 14, N'LIMA           ', 7, N'YAUYOS                        ', 10, N'CHOCOS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1367, 14, N'LIMA           ', 7, N'YAUYOS                        ', 11, N'HUAMPARA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1368, 14, N'LIMA           ', 7, N'YAUYOS                        ', 12, N'HUANCAYA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1369, 14, N'LIMA           ', 7, N'YAUYOS                        ', 13, N'HUANGASCAR                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1370, 14, N'LIMA           ', 7, N'YAUYOS                        ', 14, N'HUANTAN                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1371, 14, N'LIMA           ', 7, N'YAUYOS                        ', 15, N'HUAÑEC                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1372, 14, N'LIMA           ', 7, N'YAUYOS                        ', 16, N'LARAOS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1373, 14, N'LIMA           ', 7, N'YAUYOS                        ', 17, N'LINCHA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1374, 14, N'LIMA           ', 7, N'YAUYOS                        ', 18, N'MIRAFLORES                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1375, 14, N'LIMA           ', 7, N'YAUYOS                        ', 19, N'OMAS                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1376, 14, N'LIMA           ', 7, N'YAUYOS                        ', 20, N'QUINCHES                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1377, 14, N'LIMA           ', 7, N'YAUYOS                        ', 21, N'QUINOCAY                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1378, 14, N'LIMA           ', 7, N'YAUYOS                        ', 22, N'SAN JOAQUIN                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1379, 14, N'LIMA           ', 7, N'YAUYOS                        ', 23, N'SAN PEDRO DE PILAS            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1380, 14, N'LIMA           ', 7, N'YAUYOS                        ', 24, N'TANTA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1381, 14, N'LIMA           ', 7, N'YAUYOS                        ', 25, N'TAURIPAMPA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1382, 14, N'LIMA           ', 7, N'YAUYOS                        ', 26, N'TUPE                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1383, 14, N'LIMA           ', 7, N'YAUYOS                        ', 27, N'TOMAS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1384, 14, N'LIMA           ', 7, N'YAUYOS                        ', 28, N'VIÑAC                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1385, 14, N'LIMA           ', 7, N'YAUYOS                        ', 29, N'VITIS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1386, 14, N'LIMA           ', 7, N'YAUYOS                        ', 30, N'HONGOS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1387, 14, N'LIMA           ', 7, N'YAUYOS                        ', 31, N'MADEAN                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1388, 14, N'LIMA           ', 7, N'YAUYOS                        ', 32, N'PUTINZA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1389, 14, N'LIMA           ', 7, N'YAUYOS                        ', 33, N'CATAHUASI                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1390, 14, N'LIMA           ', 8, N'HUARAL                        ', 1, N'HUARAL                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1391, 14, N'LIMA           ', 8, N'HUARAL                        ', 2, N'ATAVILLOS ALTO                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1392, 14, N'LIMA           ', 8, N'HUARAL                        ', 3, N'ATAVILLOS BAJO                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1393, 14, N'LIMA           ', 8, N'HUARAL                        ', 4, N'AUCALLAMA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1394, 14, N'LIMA           ', 8, N'HUARAL                        ', 5, N'CHANCAY                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1395, 14, N'LIMA           ', 8, N'HUARAL                        ', 6, N'IHUARI                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1396, 14, N'LIMA           ', 8, N'HUARAL                        ', 7, N'LAMPIAN                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1397, 14, N'LIMA           ', 8, N'HUARAL                        ', 8, N'PACARAOS                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1398, 14, N'LIMA           ', 8, N'HUARAL                        ', 9, N'SAN MIGUEL DE ACOS            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1399, 14, N'LIMA           ', 8, N'HUARAL                        ', 10, N'VEINTISIETE DE NOVIEMBRE      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1400, 14, N'LIMA           ', 8, N'HUARAL                        ', 11, N'STA CRUZ DE ANDAMARCA         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1401, 14, N'LIMA           ', 8, N'HUARAL                        ', 12, N'SUMBILCA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1402, 14, N'LIMA           ', 9, N'BARRANCA                      ', 1, N'BARRANCA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1403, 14, N'LIMA           ', 9, N'BARRANCA                      ', 2, N'PARAMONGA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1404, 14, N'LIMA           ', 9, N'BARRANCA                      ', 3, N'PATIVILCA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1405, 14, N'LIMA           ', 9, N'BARRANCA                      ', 4, N'SUPE                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1406, 14, N'LIMA           ', 9, N'BARRANCA                      ', 5, N'SUPE PUERTO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1407, 14, N'LIMA           ', 10, N'OYON                          ', 1, N'OYON                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1408, 14, N'LIMA           ', 10, N'OYON                          ', 2, N'NAVAN                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1409, 14, N'LIMA           ', 10, N'OYON                          ', 3, N'CAUJUL                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1410, 14, N'LIMA           ', 10, N'OYON                          ', 4, N'ANDAJES                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1411, 14, N'LIMA           ', 10, N'OYON                          ', 5, N'PACHANGARA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1412, 14, N'LIMA           ', 10, N'OYON                          ', 6, N'COCHAMARCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1413, 15, N'LORETO         ', 1, N'MAYNAS                        ', 1, N'IQUITOS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1414, 15, N'LORETO         ', 1, N'MAYNAS                        ', 2, N'ALTO NANAY                    ')
GO
print 'Processed 1400 total records'
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1415, 15, N'LORETO         ', 1, N'MAYNAS                        ', 3, N'FERNANDO LORES                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1416, 15, N'LORETO         ', 1, N'MAYNAS                        ', 4, N'LAS AMAZONAS                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1417, 15, N'LORETO         ', 1, N'MAYNAS                        ', 5, N'MAZAN                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1418, 15, N'LORETO         ', 1, N'MAYNAS                        ', 6, N'NAPO                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1419, 15, N'LORETO         ', 1, N'MAYNAS                        ', 7, N'PUTUMAYO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1420, 15, N'LORETO         ', 1, N'MAYNAS                        ', 8, N'TORRES CAUSANA                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1421, 15, N'LORETO         ', 1, N'MAYNAS                        ', 10, N'INDIANA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1422, 15, N'LORETO         ', 1, N'MAYNAS                        ', 11, N'PUNCHANA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1423, 15, N'LORETO         ', 1, N'MAYNAS                        ', 12, N'BELEN                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1424, 15, N'LORETO         ', 1, N'MAYNAS                        ', 13, N'SAN JUAN BAUTISTA             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1425, 15, N'LORETO         ', 1, N'MAYNAS                        ', 14, N'TNTE MANUEL CLAVERO           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1426, 15, N'LORETO         ', 2, N'ALTO AMAZONAS                 ', 1, N'YURIMAGUAS                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1427, 15, N'LORETO         ', 2, N'ALTO AMAZONAS                 ', 2, N'BALSAPUERTO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1428, 15, N'LORETO         ', 2, N'ALTO AMAZONAS                 ', 5, N'JEBEROS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1429, 15, N'LORETO         ', 2, N'ALTO AMAZONAS                 ', 6, N'LAGUNAS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1430, 15, N'LORETO         ', 2, N'ALTO AMAZONAS                 ', 10, N'SANTA CRUZ                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1431, 15, N'LORETO         ', 2, N'ALTO AMAZONAS                 ', 11, N'TNTE CESAR LOPEZ ROJAS        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1432, 15, N'LORETO         ', 3, N'LORETO                        ', 1, N'NAUTA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1433, 15, N'LORETO         ', 3, N'LORETO                        ', 2, N'PARINARI                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1434, 15, N'LORETO         ', 3, N'LORETO                        ', 3, N'TIGRE                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1435, 15, N'LORETO         ', 3, N'LORETO                        ', 4, N'URARINAS                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1436, 15, N'LORETO         ', 3, N'LORETO                        ', 5, N'TROMPETEROS                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1437, 15, N'LORETO         ', 4, N'REQUENA                       ', 1, N'REQUENA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1438, 15, N'LORETO         ', 4, N'REQUENA                       ', 2, N'ALTO TAPICHE                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1439, 15, N'LORETO         ', 4, N'REQUENA                       ', 3, N'CAPELO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1440, 15, N'LORETO         ', 4, N'REQUENA                       ', 4, N'EMILIO SAN MARTIN             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1441, 15, N'LORETO         ', 4, N'REQUENA                       ', 5, N'MAQUIA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1442, 15, N'LORETO         ', 4, N'REQUENA                       ', 6, N'PUINAHUA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1443, 15, N'LORETO         ', 4, N'REQUENA                       ', 7, N'SAPUENA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1444, 15, N'LORETO         ', 4, N'REQUENA                       ', 8, N'SOPLIN                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1445, 15, N'LORETO         ', 4, N'REQUENA                       ', 9, N'TAPICHE                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1446, 15, N'LORETO         ', 4, N'REQUENA                       ', 10, N'JENARO HERRERA                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1447, 15, N'LORETO         ', 4, N'REQUENA                       ', 11, N'YAQUERANA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1448, 15, N'LORETO         ', 5, N'UCAYALI                       ', 1, N'CONTAMANA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1449, 15, N'LORETO         ', 5, N'UCAYALI                       ', 2, N'VARGAS GUERRA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1450, 15, N'LORETO         ', 5, N'UCAYALI                       ', 3, N'PADRE MARQUEZ                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1451, 15, N'LORETO         ', 5, N'UCAYALI                       ', 4, N'PAMPA HERMOZA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1452, 15, N'LORETO         ', 5, N'UCAYALI                       ', 5, N'SARAYACU                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1453, 15, N'LORETO         ', 5, N'UCAYALI                       ', 6, N'INAHUAYA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1454, 15, N'LORETO         ', 6, N'MARISCAL RAMON CASTILLA       ', 1, N'MARISCAL RAMON CASTILLA       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1455, 15, N'LORETO         ', 6, N'MARISCAL RAMON CASTILLA       ', 2, N'PEBAS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1456, 15, N'LORETO         ', 6, N'MARISCAL RAMON CASTILLA       ', 3, N'YAVARI                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1457, 15, N'LORETO         ', 6, N'MARISCAL RAMON CASTILLA       ', 4, N'SAN PABLO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1458, 15, N'LORETO         ', 7, N'DATEM DEL MARAÑON             ', 1, N'BARRANCA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1459, 15, N'LORETO         ', 7, N'DATEM DEL MARAÑON             ', 2, N'ANDOAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1460, 15, N'LORETO         ', 7, N'DATEM DEL MARAÑON             ', 3, N'CAHUAPANAS                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1461, 15, N'LORETO         ', 7, N'DATEM DEL MARAÑON             ', 4, N'MANSERICHE                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1462, 15, N'LORETO         ', 7, N'DATEM DEL MARAÑON             ', 5, N'MORONA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1463, 15, N'LORETO         ', 7, N'DATEM DEL MARAÑON             ', 6, N'PASTAZA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1464, 16, N'MADRE DE DIOS  ', 1, N'TAMBOPATA                     ', 1, N'TAMBOPATA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1465, 16, N'MADRE DE DIOS  ', 1, N'TAMBOPATA                     ', 2, N'INAMBARI                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1466, 16, N'MADRE DE DIOS  ', 1, N'TAMBOPATA                     ', 3, N'LAS PIEDRAS                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1467, 16, N'MADRE DE DIOS  ', 1, N'TAMBOPATA                     ', 4, N'LABERINTO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1468, 16, N'MADRE DE DIOS  ', 2, N'MANU                          ', 1, N'MANU                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1469, 16, N'MADRE DE DIOS  ', 2, N'MANU                          ', 2, N'FITZCARRALD                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1470, 16, N'MADRE DE DIOS  ', 2, N'MANU                          ', 3, N'MADRE DE DIOS                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1471, 16, N'MADRE DE DIOS  ', 2, N'MANU                          ', 4, N'HUEPETUHE                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1472, 16, N'MADRE DE DIOS  ', 3, N'TAHUAMANU                     ', 1, N'IÑAPARI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1473, 16, N'MADRE DE DIOS  ', 3, N'TAHUAMANU                     ', 2, N'IBERIA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1474, 16, N'MADRE DE DIOS  ', 3, N'TAHUAMANU                     ', 3, N'TAHUAMANU                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1475, 17, N'MOQUEGUA       ', 1, N'MARISCAL NIETO                ', 1, N'MOQUEGUA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1476, 17, N'MOQUEGUA       ', 1, N'MARISCAL NIETO                ', 2, N'CARUMAS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1477, 17, N'MOQUEGUA       ', 1, N'MARISCAL NIETO                ', 3, N'CUCHUMBAYA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1478, 17, N'MOQUEGUA       ', 1, N'MARISCAL NIETO                ', 4, N'SAN CRISTOBAL                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1479, 17, N'MOQUEGUA       ', 1, N'MARISCAL NIETO                ', 5, N'TORATA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1480, 17, N'MOQUEGUA       ', 1, N'MARISCAL NIETO                ', 6, N'SAMEGUA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1481, 17, N'MOQUEGUA       ', 2, N'GENERAL SANCHEZ CERRO         ', 1, N'OMATE                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1482, 17, N'MOQUEGUA       ', 2, N'GENERAL SANCHEZ CERRO         ', 2, N'COALAQUE                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1483, 17, N'MOQUEGUA       ', 2, N'GENERAL SANCHEZ CERRO         ', 3, N'CHOJATA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1484, 17, N'MOQUEGUA       ', 2, N'GENERAL SANCHEZ CERRO         ', 4, N'ICHUÑA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1485, 17, N'MOQUEGUA       ', 2, N'GENERAL SANCHEZ CERRO         ', 5, N'LA CAPILLA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1486, 17, N'MOQUEGUA       ', 2, N'GENERAL SANCHEZ CERRO         ', 6, N'LLOQUE                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1487, 17, N'MOQUEGUA       ', 2, N'GENERAL SANCHEZ CERRO         ', 7, N'MATALAQUE                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1488, 17, N'MOQUEGUA       ', 2, N'GENERAL SANCHEZ CERRO         ', 8, N'PUQUINA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1489, 17, N'MOQUEGUA       ', 2, N'GENERAL SANCHEZ CERRO         ', 9, N'QUINISTAQUILLAS               ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1490, 17, N'MOQUEGUA       ', 2, N'GENERAL SANCHEZ CERRO         ', 10, N'UBINAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1491, 17, N'MOQUEGUA       ', 2, N'GENERAL SANCHEZ CERRO         ', 11, N'YUNGA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1492, 17, N'MOQUEGUA       ', 3, N'ILO                           ', 1, N'ILO                           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1493, 17, N'MOQUEGUA       ', 3, N'ILO                           ', 2, N'EL ALGARROBAL                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1494, 17, N'MOQUEGUA       ', 3, N'ILO                           ', 3, N'PACOCHA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1495, 18, N'PASCO          ', 1, N'PASCO                         ', 1, N'CHAUPIMARCA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1496, 18, N'PASCO          ', 1, N'PASCO                         ', 3, N'HUACHON                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1497, 18, N'PASCO          ', 1, N'PASCO                         ', 4, N'HUARIACA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1498, 18, N'PASCO          ', 1, N'PASCO                         ', 5, N'HUAYLLAY                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1499, 18, N'PASCO          ', 1, N'PASCO                         ', 6, N'NINACACA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1500, 18, N'PASCO          ', 1, N'PASCO                         ', 7, N'PALLANCHACRA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1501, 18, N'PASCO          ', 1, N'PASCO                         ', 8, N'PAUCARTAMBO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1502, 18, N'PASCO          ', 1, N'PASCO                         ', 9, N'SAN FCO DE ASIS DE YARUSYACAN ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1503, 18, N'PASCO          ', 1, N'PASCO                         ', 10, N'SIMON BOLIVAR                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1504, 18, N'PASCO          ', 1, N'PASCO                         ', 11, N'TICLACAYAN                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1505, 18, N'PASCO          ', 1, N'PASCO                         ', 12, N'TINYAHUARCO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1506, 18, N'PASCO          ', 1, N'PASCO                         ', 13, N'VICCO                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1507, 18, N'PASCO          ', 1, N'PASCO                         ', 14, N'YANACANCHA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1508, 18, N'PASCO          ', 2, N'DANIEL ALCIDES CARRION        ', 1, N'YANAHUANCA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1509, 18, N'PASCO          ', 2, N'DANIEL ALCIDES CARRION        ', 2, N'CHACAYAN                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1510, 18, N'PASCO          ', 2, N'DANIEL ALCIDES CARRION        ', 3, N'GOYLLARISQUIZGA               ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1511, 18, N'PASCO          ', 2, N'DANIEL ALCIDES CARRION        ', 4, N'PAUCAR                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1512, 18, N'PASCO          ', 2, N'DANIEL ALCIDES CARRION        ', 5, N'SAN PEDRO DE PILLAO           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1513, 18, N'PASCO          ', 2, N'DANIEL ALCIDES CARRION        ', 6, N'SANTA ANA DE TUSI             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1514, 18, N'PASCO          ', 2, N'DANIEL ALCIDES CARRION        ', 7, N'TAPUC                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1515, 18, N'PASCO          ', 2, N'DANIEL ALCIDES CARRION        ', 8, N'VILCABAMBA                    ')
GO
print 'Processed 1500 total records'
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1516, 18, N'PASCO          ', 3, N'OXAPAMPA                      ', 1, N'OXAPAMPA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1517, 18, N'PASCO          ', 3, N'OXAPAMPA                      ', 2, N'CHONTABAMBA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1518, 18, N'PASCO          ', 3, N'OXAPAMPA                      ', 3, N'HUANCABAMBA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1519, 18, N'PASCO          ', 3, N'OXAPAMPA                      ', 4, N'PUERTO BERMUDEZ               ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1520, 18, N'PASCO          ', 3, N'OXAPAMPA                      ', 5, N'VILLA RICA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1521, 18, N'PASCO          ', 3, N'OXAPAMPA                      ', 6, N'POZUZO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1522, 18, N'PASCO          ', 3, N'OXAPAMPA                      ', 7, N'PALCAZU                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1523, 19, N'PIURA          ', 1, N'PIURA                         ', 1, N'PIURA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1524, 19, N'PIURA          ', 1, N'PIURA                         ', 3, N'CASTILLA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1525, 19, N'PIURA          ', 1, N'PIURA                         ', 4, N'CATACAOS                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1526, 19, N'PIURA          ', 1, N'PIURA                         ', 5, N'LA ARENA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1527, 19, N'PIURA          ', 1, N'PIURA                         ', 6, N'LA UNION                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1528, 19, N'PIURA          ', 1, N'PIURA                         ', 7, N'LAS LOMAS                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1529, 19, N'PIURA          ', 1, N'PIURA                         ', 9, N'TAMBO GRANDE                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1530, 19, N'PIURA          ', 1, N'PIURA                         ', 13, N'CURA MORI                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1531, 19, N'PIURA          ', 1, N'PIURA                         ', 14, N'EL TALLAN                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1532, 19, N'PIURA          ', 2, N'AYABACA                       ', 1, N'AYABACA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1533, 19, N'PIURA          ', 2, N'AYABACA                       ', 2, N'FRIAS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1534, 19, N'PIURA          ', 2, N'AYABACA                       ', 3, N'LAGUNAS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1535, 19, N'PIURA          ', 2, N'AYABACA                       ', 4, N'MONTERO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1536, 19, N'PIURA          ', 2, N'AYABACA                       ', 5, N'PACAIPAMPA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1537, 19, N'PIURA          ', 2, N'AYABACA                       ', 6, N'SAPILLICA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1538, 19, N'PIURA          ', 2, N'AYABACA                       ', 7, N'SICCHEZ                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1539, 19, N'PIURA          ', 2, N'AYABACA                       ', 8, N'SUYO                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1540, 19, N'PIURA          ', 2, N'AYABACA                       ', 9, N'JILILI                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1541, 19, N'PIURA          ', 2, N'AYABACA                       ', 10, N'PAIMAS                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1542, 19, N'PIURA          ', 3, N'HUANCABAMBA                   ', 1, N'HUANCABAMBA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1543, 19, N'PIURA          ', 3, N'HUANCABAMBA                   ', 2, N'CANCHAQUE                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1544, 19, N'PIURA          ', 3, N'HUANCABAMBA                   ', 3, N'HUARMACA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1545, 19, N'PIURA          ', 3, N'HUANCABAMBA                   ', 4, N'SONDOR                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1546, 19, N'PIURA          ', 3, N'HUANCABAMBA                   ', 5, N'SONDORILLO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1547, 19, N'PIURA          ', 3, N'HUANCABAMBA                   ', 6, N'EL CARMEN DE LA FRONTERA      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1548, 19, N'PIURA          ', 3, N'HUANCABAMBA                   ', 7, N'SAN MIGUEL DE EL FAIQUE       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1549, 19, N'PIURA          ', 3, N'HUANCABAMBA                   ', 8, N'LALAQUIZ                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1550, 19, N'PIURA          ', 4, N'MORROPON                      ', 1, N'CHULUCANAS                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1551, 19, N'PIURA          ', 4, N'MORROPON                      ', 2, N'BUENOS AIRES                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1552, 19, N'PIURA          ', 4, N'MORROPON                      ', 3, N'CHALACO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1553, 19, N'PIURA          ', 4, N'MORROPON                      ', 4, N'MORROPON                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1554, 19, N'PIURA          ', 4, N'MORROPON                      ', 5, N'SALITRAL                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1555, 19, N'PIURA          ', 4, N'MORROPON                      ', 6, N'SANTA CATALINA DE MOSSA       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1556, 19, N'PIURA          ', 4, N'MORROPON                      ', 7, N'SANTO DOMINGO                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1557, 19, N'PIURA          ', 4, N'MORROPON                      ', 8, N'LA MATANZA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1558, 19, N'PIURA          ', 4, N'MORROPON                      ', 9, N'YAMANGO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1559, 19, N'PIURA          ', 4, N'MORROPON                      ', 10, N'SAN JUAN DE BIGOTE            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1560, 19, N'PIURA          ', 5, N'PAITA                         ', 1, N'PAITA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1561, 19, N'PIURA          ', 5, N'PAITA                         ', 2, N'AMOTAPE                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1562, 19, N'PIURA          ', 5, N'PAITA                         ', 3, N'ARENAL                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1563, 19, N'PIURA          ', 5, N'PAITA                         ', 4, N'LA HUACA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1564, 19, N'PIURA          ', 5, N'PAITA                         ', 5, N'PUEBLO NUEVO DE COLAN         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1565, 19, N'PIURA          ', 5, N'PAITA                         ', 6, N'TAMARINDO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1566, 19, N'PIURA          ', 5, N'PAITA                         ', 7, N'VICHAYAL                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1567, 19, N'PIURA          ', 6, N'SULLANA                       ', 1, N'SULLANA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1568, 19, N'PIURA          ', 6, N'SULLANA                       ', 2, N'BELLAVISTA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1569, 19, N'PIURA          ', 6, N'SULLANA                       ', 3, N'LANCONES                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1570, 19, N'PIURA          ', 6, N'SULLANA                       ', 4, N'MARCAVELICA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1571, 19, N'PIURA          ', 6, N'SULLANA                       ', 5, N'MIGUEL CHECA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1572, 19, N'PIURA          ', 6, N'SULLANA                       ', 6, N'QUERECOTILLO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1573, 19, N'PIURA          ', 6, N'SULLANA                       ', 7, N'SALITRAL                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1574, 19, N'PIURA          ', 6, N'SULLANA                       ', 8, N'IGNACIO ESCUDERO              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1575, 19, N'PIURA          ', 7, N'TALARA                        ', 1, N'PARIÑAS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1576, 19, N'PIURA          ', 7, N'TALARA                        ', 2, N'EL ALTO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1577, 19, N'PIURA          ', 7, N'TALARA                        ', 3, N'LA BREA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1578, 19, N'PIURA          ', 7, N'TALARA                        ', 4, N'LOBITOS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1579, 19, N'PIURA          ', 7, N'TALARA                        ', 5, N'MANCORA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1580, 19, N'PIURA          ', 7, N'TALARA                        ', 6, N'LOS ORGANOS                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1581, 19, N'PIURA          ', 8, N'SECHURA                       ', 1, N'SECHURA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1582, 19, N'PIURA          ', 8, N'SECHURA                       ', 2, N'VICE                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1583, 19, N'PIURA          ', 8, N'SECHURA                       ', 3, N'BERNAL                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1584, 19, N'PIURA          ', 8, N'SECHURA                       ', 4, N'BELLAVISTA DE LA UNION        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1585, 19, N'PIURA          ', 8, N'SECHURA                       ', 5, N'CRISTO NOS VALGA              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1586, 19, N'PIURA          ', 8, N'SECHURA                       ', 6, N'RINCONADA LLICUAR             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1587, 20, N'PUNO           ', 1, N'PUNO                          ', 1, N'PUNO                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1588, 20, N'PUNO           ', 1, N'PUNO                          ', 2, N'ACORA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1589, 20, N'PUNO           ', 1, N'PUNO                          ', 3, N'ATUNCOLLA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1590, 20, N'PUNO           ', 1, N'PUNO                          ', 4, N'CAPACHICA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1591, 20, N'PUNO           ', 1, N'PUNO                          ', 5, N'COATA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1592, 20, N'PUNO           ', 1, N'PUNO                          ', 6, N'CHUCUITO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1593, 20, N'PUNO           ', 1, N'PUNO                          ', 7, N'HUATA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1594, 20, N'PUNO           ', 1, N'PUNO                          ', 8, N'MAÑAZO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1595, 20, N'PUNO           ', 1, N'PUNO                          ', 9, N'PAUCARCOLLA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1596, 20, N'PUNO           ', 1, N'PUNO                          ', 10, N'PICHACANI                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1597, 20, N'PUNO           ', 1, N'PUNO                          ', 11, N'SAN ANTONIO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1598, 20, N'PUNO           ', 1, N'PUNO                          ', 12, N'TIQUILLACA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1599, 20, N'PUNO           ', 1, N'PUNO                          ', 13, N'VILQUE                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1600, 20, N'PUNO           ', 1, N'PUNO                          ', 14, N'PLATERIA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1601, 20, N'PUNO           ', 1, N'PUNO                          ', 15, N'AMANTANI                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1602, 20, N'PUNO           ', 2, N'AZANGARO                      ', 1, N'AZANGARO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1603, 20, N'PUNO           ', 2, N'AZANGARO                      ', 2, N'ACHAYA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1604, 20, N'PUNO           ', 2, N'AZANGARO                      ', 3, N'ARAPA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1605, 20, N'PUNO           ', 2, N'AZANGARO                      ', 4, N'ASILLO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1606, 20, N'PUNO           ', 2, N'AZANGARO                      ', 5, N'CAMINACA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1607, 20, N'PUNO           ', 2, N'AZANGARO                      ', 6, N'CHUPA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1608, 20, N'PUNO           ', 2, N'AZANGARO                      ', 7, N'JOSE DOMINGO CHOQUEHUANCA     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1609, 20, N'PUNO           ', 2, N'AZANGARO                      ', 8, N'MUÑANI                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1610, 20, N'PUNO           ', 2, N'AZANGARO                      ', 10, N'POTONI                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1611, 20, N'PUNO           ', 2, N'AZANGARO                      ', 12, N'SAMAN                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1612, 20, N'PUNO           ', 2, N'AZANGARO                      ', 13, N'SAN ANTON                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1613, 20, N'PUNO           ', 2, N'AZANGARO                      ', 14, N'SAN JOSE                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1614, 20, N'PUNO           ', 2, N'AZANGARO                      ', 15, N'SAN JUAN DE SALINAS           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1615, 20, N'PUNO           ', 2, N'AZANGARO                      ', 16, N'STGO DE PUPUJA                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1616, 20, N'PUNO           ', 2, N'AZANGARO                      ', 17, N'TIRAPATA                      ')
GO
print 'Processed 1600 total records'
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1617, 20, N'PUNO           ', 3, N'CARABAYA                      ', 1, N'MACUSANI                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1618, 20, N'PUNO           ', 3, N'CARABAYA                      ', 2, N'AJOYANI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1619, 20, N'PUNO           ', 3, N'CARABAYA                      ', 3, N'AYAPATA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1620, 20, N'PUNO           ', 3, N'CARABAYA                      ', 4, N'COASA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1621, 20, N'PUNO           ', 3, N'CARABAYA                      ', 5, N'CORANI                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1622, 20, N'PUNO           ', 3, N'CARABAYA                      ', 6, N'CRUCERO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1623, 20, N'PUNO           ', 3, N'CARABAYA                      ', 7, N'ITUATA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1624, 20, N'PUNO           ', 3, N'CARABAYA                      ', 8, N'OLLACHEA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1625, 20, N'PUNO           ', 3, N'CARABAYA                      ', 9, N'SAN GABAN                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1626, 20, N'PUNO           ', 3, N'CARABAYA                      ', 10, N'USICAYOS                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1627, 20, N'PUNO           ', 4, N'CHUCUITO                      ', 1, N'JULI                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1628, 20, N'PUNO           ', 4, N'CHUCUITO                      ', 2, N'DESAGUADERO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1629, 20, N'PUNO           ', 4, N'CHUCUITO                      ', 3, N'HUACULLANI                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1630, 20, N'PUNO           ', 4, N'CHUCUITO                      ', 6, N'PISACOMA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1631, 20, N'PUNO           ', 4, N'CHUCUITO                      ', 7, N'POMATA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1632, 20, N'PUNO           ', 4, N'CHUCUITO                      ', 10, N'ZEPITA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1633, 20, N'PUNO           ', 4, N'CHUCUITO                      ', 12, N'KELLUYO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1634, 20, N'PUNO           ', 5, N'HUANCANE                      ', 1, N'HUANCANE                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1635, 20, N'PUNO           ', 5, N'HUANCANE                      ', 2, N'COJATA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1636, 20, N'PUNO           ', 5, N'HUANCANE                      ', 4, N'INCHUPALLA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1637, 20, N'PUNO           ', 5, N'HUANCANE                      ', 6, N'PUSI                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1638, 20, N'PUNO           ', 5, N'HUANCANE                      ', 7, N'ROSASPATA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1639, 20, N'PUNO           ', 5, N'HUANCANE                      ', 8, N'TARACO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1640, 20, N'PUNO           ', 5, N'HUANCANE                      ', 9, N'VILQUE CHICO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1641, 20, N'PUNO           ', 5, N'HUANCANE                      ', 11, N'HUATASANI                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1642, 20, N'PUNO           ', 6, N'LAMPA                         ', 1, N'LAMPA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1643, 20, N'PUNO           ', 6, N'LAMPA                         ', 2, N'CABANILLA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1644, 20, N'PUNO           ', 6, N'LAMPA                         ', 3, N'CALAPUJA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1645, 20, N'PUNO           ', 6, N'LAMPA                         ', 4, N'NICASIO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1646, 20, N'PUNO           ', 6, N'LAMPA                         ', 5, N'OCUVIRI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1647, 20, N'PUNO           ', 6, N'LAMPA                         ', 6, N'PALCA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1648, 20, N'PUNO           ', 6, N'LAMPA                         ', 7, N'PARATIA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1649, 20, N'PUNO           ', 6, N'LAMPA                         ', 8, N'PUCARA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1650, 20, N'PUNO           ', 6, N'LAMPA                         ', 9, N'SANTA LUCIA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1651, 20, N'PUNO           ', 6, N'LAMPA                         ', 10, N'VILAVILA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1652, 20, N'PUNO           ', 7, N'MELGAR                        ', 1, N'AYAVIRI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1653, 20, N'PUNO           ', 7, N'MELGAR                        ', 2, N'ANTAUTA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1654, 20, N'PUNO           ', 7, N'MELGAR                        ', 3, N'CUPI                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1655, 20, N'PUNO           ', 7, N'MELGAR                        ', 4, N'LLALLI                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1656, 20, N'PUNO           ', 7, N'MELGAR                        ', 5, N'MACARI                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1657, 20, N'PUNO           ', 7, N'MELGAR                        ', 6, N'NUÑOA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1658, 20, N'PUNO           ', 7, N'MELGAR                        ', 7, N'ORURILLO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1659, 20, N'PUNO           ', 7, N'MELGAR                        ', 8, N'SANTA ROSA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1660, 20, N'PUNO           ', 7, N'MELGAR                        ', 9, N'UMACHIRI                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1661, 20, N'PUNO           ', 8, N'SANDIA                        ', 1, N'SANDIA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1662, 20, N'PUNO           ', 8, N'SANDIA                        ', 3, N'CUYOCUYO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1663, 20, N'PUNO           ', 8, N'SANDIA                        ', 4, N'LIMBANI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1664, 20, N'PUNO           ', 8, N'SANDIA                        ', 5, N'PHARA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1665, 20, N'PUNO           ', 8, N'SANDIA                        ', 6, N'PATAMBUCO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1666, 20, N'PUNO           ', 8, N'SANDIA                        ', 7, N'QUIACA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1667, 20, N'PUNO           ', 8, N'SANDIA                        ', 8, N'SAN JUAN DEL ORO              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1668, 20, N'PUNO           ', 8, N'SANDIA                        ', 10, N'YANAHUAYA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1669, 20, N'PUNO           ', 8, N'SANDIA                        ', 11, N'ALTO INAMBARI                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1670, 20, N'PUNO           ', 8, N'SANDIA                        ', 12, N'SAN PEDRO DE PUTINA PUNCO     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1671, 20, N'PUNO           ', 9, N'SAN ROMAN                     ', 1, N'JULIACA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1672, 20, N'PUNO           ', 9, N'SAN ROMAN                     ', 2, N'CABANA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1673, 20, N'PUNO           ', 9, N'SAN ROMAN                     ', 3, N'CABANILLAS                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1674, 20, N'PUNO           ', 9, N'SAN ROMAN                     ', 4, N'CARACOTO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1675, 20, N'PUNO           ', 10, N'YUNGUYO                       ', 1, N'YUNGUYO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1676, 20, N'PUNO           ', 10, N'YUNGUYO                       ', 2, N'UNICACHI                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1677, 20, N'PUNO           ', 10, N'YUNGUYO                       ', 3, N'ANAPIA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1678, 20, N'PUNO           ', 10, N'YUNGUYO                       ', 4, N'COPANI                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1679, 20, N'PUNO           ', 10, N'YUNGUYO                       ', 5, N'CUTURAPI                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1680, 20, N'PUNO           ', 10, N'YUNGUYO                       ', 6, N'OLLARAYA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1681, 20, N'PUNO           ', 10, N'YUNGUYO                       ', 7, N'TINICACHI                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1682, 20, N'PUNO           ', 11, N'SAN ANTONIO DE PUTINA         ', 1, N'PUTINA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1683, 20, N'PUNO           ', 11, N'SAN ANTONIO DE PUTINA         ', 2, N'PEDRO VILCA APAZA             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1684, 20, N'PUNO           ', 11, N'SAN ANTONIO DE PUTINA         ', 3, N'QUILCA PUNCU                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1685, 20, N'PUNO           ', 11, N'SAN ANTONIO DE PUTINA         ', 4, N'ANANEA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1686, 20, N'PUNO           ', 11, N'SAN ANTONIO DE PUTINA         ', 5, N'SINA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1687, 20, N'PUNO           ', 12, N'EL COLLAO                     ', 1, N'ILAVE                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1688, 20, N'PUNO           ', 12, N'EL COLLAO                     ', 2, N'PILCUYO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1689, 20, N'PUNO           ', 12, N'EL COLLAO                     ', 3, N'SANTA ROSA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1690, 20, N'PUNO           ', 12, N'EL COLLAO                     ', 4, N'CAPASO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1691, 20, N'PUNO           ', 12, N'EL COLLAO                     ', 5, N'CONDURIRI                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1692, 20, N'PUNO           ', 13, N'MOHO                          ', 1, N'MOHO                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1693, 20, N'PUNO           ', 13, N'MOHO                          ', 2, N'CONIMA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1694, 20, N'PUNO           ', 13, N'MOHO                          ', 3, N'TILALI                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1695, 20, N'PUNO           ', 13, N'MOHO                          ', 4, N'HUAYRAPATA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1696, 21, N'SAN MARTIN     ', 1, N'MOYOBAMBA                     ', 1, N'MOYOBAMBA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1697, 21, N'SAN MARTIN     ', 1, N'MOYOBAMBA                     ', 2, N'CALZADA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1698, 21, N'SAN MARTIN     ', 1, N'MOYOBAMBA                     ', 3, N'HABANA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1699, 21, N'SAN MARTIN     ', 1, N'MOYOBAMBA                     ', 4, N'JEPELACIO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1700, 21, N'SAN MARTIN     ', 1, N'MOYOBAMBA                     ', 5, N'SORITOR                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1701, 21, N'SAN MARTIN     ', 1, N'MOYOBAMBA                     ', 6, N'YANTALO                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1702, 21, N'SAN MARTIN     ', 2, N'HUALLAGA                      ', 1, N'SAPOSOA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1703, 21, N'SAN MARTIN     ', 2, N'HUALLAGA                      ', 2, N'PISCOYACU                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1704, 21, N'SAN MARTIN     ', 2, N'HUALLAGA                      ', 3, N'SACANCHE                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1705, 21, N'SAN MARTIN     ', 2, N'HUALLAGA                      ', 4, N'TINGO DE SAPOSOA              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1706, 21, N'SAN MARTIN     ', 2, N'HUALLAGA                      ', 5, N'ALTO SAPOSOA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1707, 21, N'SAN MARTIN     ', 2, N'HUALLAGA                      ', 6, N'EL ESLABON                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1708, 21, N'SAN MARTIN     ', 3, N'LAMAS                         ', 1, N'LAMAS                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1709, 21, N'SAN MARTIN     ', 3, N'LAMAS                         ', 3, N'BARRANQUITA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1710, 21, N'SAN MARTIN     ', 3, N'LAMAS                         ', 4, N'CAYNARACHI                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1711, 21, N'SAN MARTIN     ', 3, N'LAMAS                         ', 5, N'CUÑUMBUQUI                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1712, 21, N'SAN MARTIN     ', 3, N'LAMAS                         ', 6, N'PINTO RECODO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1713, 21, N'SAN MARTIN     ', 3, N'LAMAS                         ', 7, N'RUMISAPA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1714, 21, N'SAN MARTIN     ', 3, N'LAMAS                         ', 11, N'SHANAO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1715, 21, N'SAN MARTIN     ', 3, N'LAMAS                         ', 13, N'TABALOSOS                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1716, 21, N'SAN MARTIN     ', 3, N'LAMAS                         ', 14, N'ZAPATERO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1717, 21, N'SAN MARTIN     ', 3, N'LAMAS                         ', 15, N'ALONSO DE ALVARADO            ')
GO
print 'Processed 1700 total records'
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1718, 21, N'SAN MARTIN     ', 3, N'LAMAS                         ', 16, N'SAN ROQUE DE CUMBAZA          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1719, 21, N'SAN MARTIN     ', 4, N'MARISCAL CACERES              ', 1, N'JUANJUI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1720, 21, N'SAN MARTIN     ', 4, N'MARISCAL CACERES              ', 2, N'CAMPANILLA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1721, 21, N'SAN MARTIN     ', 4, N'MARISCAL CACERES              ', 3, N'HUICUNGO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1722, 21, N'SAN MARTIN     ', 4, N'MARISCAL CACERES              ', 4, N'PACHIZA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1723, 21, N'SAN MARTIN     ', 4, N'MARISCAL CACERES              ', 5, N'PAJARILLO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1724, 21, N'SAN MARTIN     ', 5, N'RIOJA                         ', 1, N'RIOJA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1725, 21, N'SAN MARTIN     ', 5, N'RIOJA                         ', 2, N'POSIC                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1726, 21, N'SAN MARTIN     ', 5, N'RIOJA                         ', 3, N'YORONGOS                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1727, 21, N'SAN MARTIN     ', 5, N'RIOJA                         ', 4, N'YURACYACU                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1728, 21, N'SAN MARTIN     ', 5, N'RIOJA                         ', 5, N'NUEVA CAJAMARCA               ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1729, 21, N'SAN MARTIN     ', 5, N'RIOJA                         ', 6, N'ELIAS SOPLIN                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1730, 21, N'SAN MARTIN     ', 5, N'RIOJA                         ', 7, N'SAN FERNANDO                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1731, 21, N'SAN MARTIN     ', 5, N'RIOJA                         ', 8, N'PARDO MIGUEL                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1732, 21, N'SAN MARTIN     ', 5, N'RIOJA                         ', 9, N'AWAJUN                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1733, 21, N'SAN MARTIN     ', 6, N'SAN MARTIN                    ', 1, N'TARAPOTO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1734, 21, N'SAN MARTIN     ', 6, N'SAN MARTIN                    ', 2, N'ALBERTO LEVEAU                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1735, 21, N'SAN MARTIN     ', 6, N'SAN MARTIN                    ', 4, N'CACATACHI                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1736, 21, N'SAN MARTIN     ', 6, N'SAN MARTIN                    ', 6, N'CHAZUTA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1737, 21, N'SAN MARTIN     ', 6, N'SAN MARTIN                    ', 7, N'CHIPURANA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1738, 21, N'SAN MARTIN     ', 6, N'SAN MARTIN                    ', 8, N'EL PORVENIR                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1739, 21, N'SAN MARTIN     ', 6, N'SAN MARTIN                    ', 9, N'HUIMBAYOC                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1740, 21, N'SAN MARTIN     ', 6, N'SAN MARTIN                    ', 10, N'JUAN GUERRA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1741, 21, N'SAN MARTIN     ', 6, N'SAN MARTIN                    ', 11, N'MORALES                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1742, 21, N'SAN MARTIN     ', 6, N'SAN MARTIN                    ', 12, N'PAPAPLAYA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1743, 21, N'SAN MARTIN     ', 6, N'SAN MARTIN                    ', 16, N'SAN ANTONIO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1744, 21, N'SAN MARTIN     ', 6, N'SAN MARTIN                    ', 19, N'SAUCE                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1745, 21, N'SAN MARTIN     ', 6, N'SAN MARTIN                    ', 20, N'SHAPAJA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1746, 21, N'SAN MARTIN     ', 6, N'SAN MARTIN                    ', 21, N'LA BANDA DE SHILCAYO          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1747, 21, N'SAN MARTIN     ', 7, N'BELLAVISTA                    ', 1, N'BELLAVISTA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1748, 21, N'SAN MARTIN     ', 7, N'BELLAVISTA                    ', 2, N'SAN RAFAEL                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1749, 21, N'SAN MARTIN     ', 7, N'BELLAVISTA                    ', 3, N'SAN PABLO                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1750, 21, N'SAN MARTIN     ', 7, N'BELLAVISTA                    ', 4, N'ALTO BIAVO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1751, 21, N'SAN MARTIN     ', 7, N'BELLAVISTA                    ', 5, N'HUALLAGA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1752, 21, N'SAN MARTIN     ', 7, N'BELLAVISTA                    ', 6, N'BAJO BIAVO                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1753, 21, N'SAN MARTIN     ', 8, N'TOCACHE                       ', 1, N'TOCACHE                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1754, 21, N'SAN MARTIN     ', 8, N'TOCACHE                       ', 2, N'NUEVO PROGRESO                ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1755, 21, N'SAN MARTIN     ', 8, N'TOCACHE                       ', 3, N'POLVORA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1756, 21, N'SAN MARTIN     ', 8, N'TOCACHE                       ', 4, N'SHUNTE                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1757, 21, N'SAN MARTIN     ', 8, N'TOCACHE                       ', 5, N'UCHIZA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1758, 21, N'SAN MARTIN     ', 9, N'PICOTA                        ', 1, N'PICOTA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1759, 21, N'SAN MARTIN     ', 9, N'PICOTA                        ', 2, N'BUENOS AIRES                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1760, 21, N'SAN MARTIN     ', 9, N'PICOTA                        ', 3, N'CASPIZAPA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1761, 21, N'SAN MARTIN     ', 9, N'PICOTA                        ', 4, N'PILLUANA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1762, 21, N'SAN MARTIN     ', 9, N'PICOTA                        ', 5, N'PUCACACA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1763, 21, N'SAN MARTIN     ', 9, N'PICOTA                        ', 6, N'SAN CRISTOBAL                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1764, 21, N'SAN MARTIN     ', 9, N'PICOTA                        ', 7, N'SAN HILARION                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1765, 21, N'SAN MARTIN     ', 9, N'PICOTA                        ', 8, N'TINGO DE PONASA               ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1766, 21, N'SAN MARTIN     ', 9, N'PICOTA                        ', 9, N'TRES UNIDOS                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1767, 21, N'SAN MARTIN     ', 9, N'PICOTA                        ', 10, N'SHAMBOYACU                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1768, 21, N'SAN MARTIN     ', 10, N'EL DORADO                     ', 1, N'SAN JOSE DE SISA              ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1769, 21, N'SAN MARTIN     ', 10, N'EL DORADO                     ', 2, N'AGUA BLANCA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1770, 21, N'SAN MARTIN     ', 10, N'EL DORADO                     ', 3, N'SHATOJA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1771, 21, N'SAN MARTIN     ', 10, N'EL DORADO                     ', 4, N'SAN MARTIN                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1772, 21, N'SAN MARTIN     ', 10, N'EL DORADO                     ', 5, N'SANTA ROSA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1773, 22, N'TACNA          ', 1, N'TACNA                         ', 1, N'TACNA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1774, 22, N'TACNA          ', 1, N'TACNA                         ', 2, N'CALANA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1775, 22, N'TACNA          ', 1, N'TACNA                         ', 4, N'INCLAN                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1776, 22, N'TACNA          ', 1, N'TACNA                         ', 7, N'PACHIA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1777, 22, N'TACNA          ', 1, N'TACNA                         ', 8, N'PALCA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1778, 22, N'TACNA          ', 1, N'TACNA                         ', 9, N'POCOLLAY                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1779, 22, N'TACNA          ', 1, N'TACNA                         ', 10, N'SAMA                          ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1780, 22, N'TACNA          ', 1, N'TACNA                         ', 11, N'ALTO DE LA ALIANZA            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1781, 22, N'TACNA          ', 1, N'TACNA                         ', 12, N'CIUDAD NUEVA                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1782, 22, N'TACNA          ', 1, N'TACNA                         ', 13, N'CORONEL GREGORIO ALBARRACIN L.')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1783, 22, N'TACNA          ', 2, N'TARATA                        ', 1, N'TARATA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1784, 22, N'TACNA          ', 2, N'TARATA                        ', 5, N'HEROES ALBARRACIN             ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1785, 22, N'TACNA          ', 2, N'TARATA                        ', 6, N'ESTIQUE                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1786, 22, N'TACNA          ', 2, N'TARATA                        ', 7, N'ESTIQUE PAMPA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1787, 22, N'TACNA          ', 2, N'TARATA                        ', 10, N'SITAJARA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1788, 22, N'TACNA          ', 2, N'TARATA                        ', 11, N'SUSAPAYA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1789, 22, N'TACNA          ', 2, N'TARATA                        ', 12, N'TARUCACHI                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1790, 22, N'TACNA          ', 2, N'TARATA                        ', 13, N'TICACO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1791, 22, N'TACNA          ', 3, N'JORGE BASADRE                 ', 1, N'LOCUMBA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1792, 22, N'TACNA          ', 3, N'JORGE BASADRE                 ', 2, N'ITE                           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1793, 22, N'TACNA          ', 3, N'JORGE BASADRE                 ', 3, N'ILABAYA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1794, 22, N'TACNA          ', 4, N'CANDARAVE                     ', 1, N'CANDARAVE                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1795, 22, N'TACNA          ', 4, N'CANDARAVE                     ', 2, N'CAIRANI                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1796, 22, N'TACNA          ', 4, N'CANDARAVE                     ', 3, N'CURIBAYA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1797, 22, N'TACNA          ', 4, N'CANDARAVE                     ', 4, N'HUANUARA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1798, 22, N'TACNA          ', 4, N'CANDARAVE                     ', 5, N'QUILAHUANI                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1799, 22, N'TACNA          ', 4, N'CANDARAVE                     ', 6, N'CAMILACA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1800, 23, N'TUMBES         ', 1, N'TUMBES                        ', 1, N'TUMBES                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1801, 23, N'TUMBES         ', 1, N'TUMBES                        ', 2, N'CORRALES                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1802, 23, N'TUMBES         ', 1, N'TUMBES                        ', 3, N'LA CRUZ                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1803, 23, N'TUMBES         ', 1, N'TUMBES                        ', 4, N'PAMPAS DE HOSPITAL            ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1804, 23, N'TUMBES         ', 1, N'TUMBES                        ', 5, N'SAN JACINTO                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1805, 23, N'TUMBES         ', 1, N'TUMBES                        ', 6, N'SAN JUAN DE LA VIRGEN         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1806, 23, N'TUMBES         ', 2, N'CONTRALMIRANTE VILLAR         ', 1, N'ZORRITOS                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1807, 23, N'TUMBES         ', 2, N'CONTRALMIRANTE VILLAR         ', 2, N'CASITAS                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1808, 23, N'TUMBES         ', 2, N'CONTRALMIRANTE VILLAR         ', 3, N'CANOAS DE PUNTA SAL           ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1809, 23, N'TUMBES         ', 3, N'ZARUMILLA                     ', 1, N'ZARUMILLA                     ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1810, 23, N'TUMBES         ', 3, N'ZARUMILLA                     ', 2, N'MATAPALO                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1811, 23, N'TUMBES         ', 3, N'ZARUMILLA                     ', 3, N'PAPAYAL                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1812, 23, N'TUMBES         ', 3, N'ZARUMILLA                     ', 4, N'AGUAS VERDES                  ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1813, 24, N'               ', 1, N'CALLAO                        ', 1, N'CALLAO                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1814, 24, N'               ', 1, N'CALLAO                        ', 2, N'BELLAVISTA                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1815, 24, N'               ', 1, N'CALLAO                        ', 3, N'LA PUNTA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1816, 24, N'               ', 1, N'CALLAO                        ', 4, N'CARMEN DE LA LEGUA-REYNOSO    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1817, 24, N'               ', 1, N'CALLAO                        ', 5, N'LA PERLA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1818, 24, N'               ', 1, N'CALLAO                        ', 6, N'VENTANILLA                    ')
GO
print 'Processed 1800 total records'
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1819, 25, N'UCAYALI        ', 1, N'CORONEL PORTILLO              ', 1, N'CALLERIA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1820, 25, N'UCAYALI        ', 1, N'CORONEL PORTILLO              ', 2, N'YARINACOCHA                   ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1821, 25, N'UCAYALI        ', 1, N'CORONEL PORTILLO              ', 3, N'MASISEA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1822, 25, N'UCAYALI        ', 1, N'CORONEL PORTILLO              ', 4, N'CAMPOVERDE                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1823, 25, N'UCAYALI        ', 1, N'CORONEL PORTILLO              ', 5, N'IPARIA                        ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1824, 25, N'UCAYALI        ', 1, N'CORONEL PORTILLO              ', 6, N'NUEVA REQUENA                 ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1825, 25, N'UCAYALI        ', 1, N'CORONEL PORTILLO              ', 7, N'MANANTAY                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1826, 25, N'UCAYALI        ', 2, N'PADRE ABAD                    ', 1, N'PADRE ABAD                    ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1827, 25, N'UCAYALI        ', 2, N'PADRE ABAD                    ', 2, N'YRAZOLA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1828, 25, N'UCAYALI        ', 2, N'PADRE ABAD                    ', 3, N'CURIMANA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1829, 25, N'UCAYALI        ', 3, N'ATALAYA                       ', 1, N'RAIMONDI                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1830, 25, N'UCAYALI        ', 3, N'ATALAYA                       ', 2, N'TAHUANIA                      ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1831, 25, N'UCAYALI        ', 3, N'ATALAYA                       ', 3, N'YURUA                         ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1832, 25, N'UCAYALI        ', 3, N'ATALAYA                       ', 4, N'SEPAHUA                       ')
INSERT [dbo].[Ubigeo] ([IdUbigeo], [IdDepartamento], [NombreDepartamento], [IdProvincia], [NombreProvincia], [IdDistrito], [NombreDistrito]) VALUES (1833, 25, N'UCAYALI        ', 4, N'PURUS                         ', 1, N'PURUS                         ')
/****** Object:  Table [dbo].[ListaError]    Script Date: 10/29/2011 00:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ListaError](
	[IdError] [int] IDENTITY(1,1) NOT NULL,
	[NombreError] [varchar](50) NOT NULL,
	[DescripcionError] [varchar](300) NOT NULL,
	[Ubicacion] [varchar](50) NOT NULL,
	[Usuario] [varchar](20) NOT NULL,
	[NombreObjeto] [varchar](30) NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[Atendido] [char](1) NOT NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [varchar](20) NOT NULL,
	[FechaModificacion] [smallint] NOT NULL,
 CONSTRAINT [pkListaError] PRIMARY KEY CLUSTERED 
(
	[IdError] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Moneda]    Script Date: 10/29/2011 00:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Moneda](
	[IdMoneda] [smallint] NOT NULL,
	[CodigoMoneda] [char](3) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[TextoImpresion] [varchar](50) NOT NULL,
	[Simbolo] [varchar](5) NOT NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [smallint] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
 CONSTRAINT [pkMoneda] PRIMARY KEY CLUSTERED 
(
	[IdMoneda] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Moneda] ([IdMoneda], [CodigoMoneda], [Descripcion], [TextoImpresion], [Simbolo], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (1, N'PEN', N'NUEVO SOL', N'NUEVOS SOLES', N'S/.', 1, CAST(0x00009F7000000000 AS DateTime), 1, CAST(0x00009F7A00000000 AS DateTime))
INSERT [dbo].[Moneda] ([IdMoneda], [CodigoMoneda], [Descripcion], [TextoImpresion], [Simbolo], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (2, N'USD', N'DOLAR', N'DOLARES AMERICANOS', N'US$', 1, CAST(0x00009F7000000000 AS DateTime), 1, CAST(0x00009F7000000000 AS DateTime))
/****** Object:  Table [dbo].[PerfilAcceso]    Script Date: 10/29/2011 00:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PerfilAcceso](
	[PerfilId] [int] NOT NULL,
	[AccesoId] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [pkSpa] PRIMARY KEY CLUSTERED 
(
	[PerfilId] ASC,
	[AccesoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 10/29/2011 00:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Perfil](
	[PerfilId] [int] IDENTITY(1,1) NOT NULL,
	[Perfil] [varchar](100) NOT NULL,
	[DescripcionPerfil] [varchar](50) NULL,
	[Tipo] [int] NULL,
	[Activo] [bit] NOT NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [smallint] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
 CONSTRAINT [pkSep] PRIMARY KEY CLUSTERED 
(
	[PerfilId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_IsLeapYear]    Script Date: 10/29/2011 00:57:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE FUNCTION [dbo].[Fn_IsLeapYear](@Year as Integer)
RETURNS char(1) AS  
BEGIN 
 declare @Bisiesto char(1)
 declare @date_begin datetime, @date_end datetime

 set @date_begin = convert(char(4), @year) + '0101'
 set @date_end = convert(char(4), @year) + '1231'
 set @Bisiesto = 'N'

 if datediff(day, @date_begin, @date_end) > 364
      set @Bisiesto = 'Y'
 RETURN @Bisiesto
END
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_FechaEnTexto]    Script Date: 10/29/2011 00:57:47 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE FUNCTION [dbo].[Fn_FechaEnTexto](@Numero as datetime) 
RETURNS varchar(500) AS  
BEGIN 
 DECLARE @Texto nvarchar(500)

 SELECT @Texto = dbo.NumeroEnLetra(day(@Numero)) + ' de '
 SELECT @Texto = @Texto +
 CASE
 WHEN month(@Numero)=1 THEN 'Enero'
 WHEN month(@Numero)=2 THEN 'Febrero'
 WHEN month(@Numero)=3 THEN 'Marzo'
 WHEN month(@Numero)=4 THEN 'Abril'
 WHEN month(@Numero)=5 THEN 'Mayo'
 WHEN month(@Numero)=6 THEN 'Junio'
 WHEN month(@Numero)=7 THEN 'Julio'
 WHEN month(@Numero)=8 THEN 'Agosto'
 WHEN month(@Numero)=9 THEN 'Septiembre'
 WHEN month(@Numero)=10 THEN 'Octubre'
 WHEN month(@Numero)=11 THEN 'Noviembre'
 WHEN month(@Numero)=12 THEN 'Diciembre'
 END
 SELECT @Texto = @Texto + ' de ' + dbo.NumeroEnLetra(year(@Numero))

 RETURN @Texto
END
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_FechaEnLetra]    Script Date: 10/29/2011 00:57:47 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE FUNCTION [dbo].[Fn_FechaEnLetra](@Numero as datetime) 
RETURNS varchar(500) AS  
BEGIN 
 DECLARE @Texto nvarchar(500)

 SELECT @Texto = convert(char(2),day(@Numero)) + ' de '
 SELECT @Texto = @Texto +
 CASE
 WHEN month(@Numero)=1 THEN 'Enero'
 WHEN month(@Numero)=2 THEN 'Febrero'
 WHEN month(@Numero)=3 THEN 'Marzo'
 WHEN month(@Numero)=4 THEN 'Abril'
 WHEN month(@Numero)=5 THEN 'Mayo'
 WHEN month(@Numero)=6 THEN 'Junio'
 WHEN month(@Numero)=7 THEN 'Julio'
 WHEN month(@Numero)=8 THEN 'Agosto'
 WHEN month(@Numero)=9 THEN 'Septiembre'
 WHEN month(@Numero)=10 THEN 'Octubre'
 WHEN month(@Numero)=11 THEN 'Noviembre'
 WHEN month(@Numero)=12 THEN 'Diciembre'
 END
 SELECT @Texto = @Texto + ' de ' + convert(char(4),year(@Numero))

 RETURN @Texto
END
GO
/****** Object:  Table [dbo].[Impuesto]    Script Date: 10/29/2011 00:57:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Impuesto](
	[IdImpuesto] [int] NOT NULL,
	[Tipo] [char](3) NOT NULL,
	[Valor] [char](2) NOT NULL,
	[Factor] [decimal](11, 2) NOT NULL,
	[FechaDesde] [datetime] NOT NULL,
	[FechaHasta] [datetime] NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [smallint] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
 CONSTRAINT [pkImpuesto] PRIMARY KEY CLUSTERED 
(
	[IdImpuesto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Impuesto] ([IdImpuesto], [Tipo], [Valor], [Factor], [FechaDesde], [FechaHasta], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (1, N'IGV', N'18', CAST(0.18 AS Decimal(11, 2)), CAST(0x00009E9900000000 AS DateTime), NULL, 1, CAST(0x00009F7000000000 AS DateTime), 1, CAST(0x00009F7000000000 AS DateTime))
/****** Object:  UserDefinedFunction [dbo].[Fn_Unidades]    Script Date: 10/29/2011 00:57:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE FUNCTION [dbo].[Fn_Unidades](@Numero as bigint, @Estilo as bit=0) 
RETURNS varchar(500) AS  
BEGIN 
 DECLARE @Texto varchar(500)
 SELECT @Texto=''
 
 SELECT @Texto=
 CASE 
  WHEN @Numero=0 THEN '' --'cero'
  WHEN @Numero=1 THEN 'uno'
  WHEN @Numero=2 AND @Estilo=0 THEN 'dos'
  WHEN @Numero=2 AND @Estilo=1 THEN 'dos'
  WHEN @Numero=3 AND @Estilo=0 THEN 'tres'
  WHEN @Numero=3 AND @Estilo=1 THEN 'tres'
  WHEN @Numero=4 THEN 'cuatro'
  WHEN @Numero=5 THEN 'cinco'
  WHEN @Numero=6 AND @Estilo=0 THEN 'seis'
  WHEN @Numero=6 AND @Estilo=1 THEN 'seis'
  WHEN @Numero=7 THEN 'siete'
  WHEN @Numero=8 THEN 'ocho'
  WHEN @Numero=9 AND @Estilo=0 THEN 'nueve'
  WHEN @Numero=9 AND @Estilo=1 THEN 'nove'
 END

 RETURN @Texto
END
GO
/****** Object:  Table [dbo].[Banco]    Script Date: 10/29/2011 00:57:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Banco](
	[IdBanco] [smallint] NOT NULL,
	[CodigoBanco] [char](3) NOT NULL,
	[Descripcion] [varchar](60) NOT NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [smallint] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
 CONSTRAINT [pkBanco] PRIMARY KEY CLUSTERED 
(
	[IdBanco] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE UNIQUE NONCLUSTERED INDEX [ixncCodigoBanco] ON [dbo].[Banco] 
(
	[CodigoBanco] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 60) ON [PRIMARY]
GO
INSERT [dbo].[Banco] ([IdBanco], [CodigoBanco], [Descripcion], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (1, N'BCP', N'BANCO DE CREDITO DEL PERU', 1, CAST(0x00009F7000000000 AS DateTime), 1, CAST(0x00009F7000000000 AS DateTime))
INSERT [dbo].[Banco] ([IdBanco], [CodigoBanco], [Descripcion], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (2, N'CON', N'BBVA BANCO CONTINENTAL', 1, CAST(0x00009F8000000000 AS DateTime), 1, CAST(0x00009F8000000000 AS DateTime))
/****** Object:  Table [dbo].[ContratoSocio]    Script Date: 10/29/2011 00:57:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ContratoSocio](
	[IdContrato] [int] NOT NULL,
	[IdSocio] [int] NOT NULL,
	[Principal] [char](1) NOT NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [smallint] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
 CONSTRAINT [pkContratoCliente] PRIMARY KEY CLUSTERED 
(
	[IdContrato] ASC,
	[IdSocio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ContratoSocio] ([IdContrato], [IdSocio], [Principal], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (1, 1, N'S', 1, CAST(0x00009F8900000000 AS DateTime), 1, CAST(0x00009F8900000000 AS DateTime))
INSERT [dbo].[ContratoSocio] ([IdContrato], [IdSocio], [Principal], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (1, 2, N'N', 1, CAST(0x00009F8900000000 AS DateTime), 1, CAST(0x00009F8900000000 AS DateTime))
/****** Object:  Table [dbo].[Contrato]    Script Date: 10/29/2011 00:57:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contrato](
	[IdContrato] [int] NOT NULL,
	[IdLote] [int] NOT NULL,
	[FechaEmision] [date] NOT NULL,
	[NumeroCuotas] [smallint] NOT NULL,
	[ValorCuotas] [money] NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[DiaPago] [smallint] NOT NULL,
	[IdMoneda] [smallint] NOT NULL,
	[ImporteTotal] [money] NOT NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [smallint] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
 CONSTRAINT [pkContrato] PRIMARY KEY CLUSTERED 
(
	[IdContrato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Contrato] ([IdContrato], [IdLote], [FechaEmision], [NumeroCuotas], [ValorCuotas], [FechaInicio], [DiaPago], [IdMoneda], [ImporteTotal], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (1, 1, CAST(0xD7340B00 AS Date), 111, 371.0000, CAST(0xD6340B00 AS Date), 19, 1, 41181.0000, 1, CAST(0x00009F7B00000000 AS DateTime), 1, CAST(0x00009F7B00000000 AS DateTime))
/****** Object:  Table [dbo].[Usuario]    Script Date: 10/29/2011 00:57:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Cuenta] [varchar](100) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Password] [varchar](255) NULL,
	[Correo] [varchar](200) NOT NULL,
	[LookAndFeel] [varchar](50) NOT NULL,
	[Imagen] [image] NULL,
	[Activo] [bit] NOT NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [smallint] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
	[FlgCambioPwd] [bit] NULL,
 CONSTRAINT [pkUsuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON
INSERT [dbo].[Usuario] ([IdUsuario], [Cuenta], [Nombre], [Descripcion], [Password], [Correo], [LookAndFeel], [Imagen], [Activo], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion], [FlgCambioPwd]) VALUES (1, N'fernando.arellano', N'Fernando Arellano', N'Coordinador de Desarrollo', N'²Ü©î’ÒŸ©}', N'', N'Default', NULL, 1, 0, CAST(0x00009F7800000000 AS DateTime), 1, CAST(0x00009F8B000EE00D AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
/****** Object:  Table [dbo].[Variable]    Script Date: 10/29/2011 00:57:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Variable](
	[IdVariable] [int] NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Codigo] [varchar](20) NOT NULL,
	[Valor] [varchar](300) NOT NULL,
	[Descripcion] [varchar](300) NOT NULL,
	[Estado] [char](1) NOT NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [smallint] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
 CONSTRAINT [pkVariable] PRIMARY KEY CLUSTERED 
(
	[IdVariable] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE UNIQUE NONCLUSTERED INDEX [ixncNombreCodigoDescripcion] ON [dbo].[Variable] 
(
	[Nombre] ASC,
	[Codigo] ASC,
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 60) ON [PRIMARY]
GO
INSERT [dbo].[Variable] ([IdVariable], [Nombre], [Codigo], [Valor], [Descripcion], [Estado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (1, N'TipoSocio', N'1', N'C', N'Cliente', N'A', 1, CAST(0x00009F7300000000 AS DateTime), 1, CAST(0x00009F7300000000 AS DateTime))
INSERT [dbo].[Variable] ([IdVariable], [Nombre], [Codigo], [Valor], [Descripcion], [Estado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (2, N'TipoSocio', N'2', N'P', N'Proveedor', N'A', 1, CAST(0x00009F7300000000 AS DateTime), 1, CAST(0x00009F7300000000 AS DateTime))
INSERT [dbo].[Variable] ([IdVariable], [Nombre], [Codigo], [Valor], [Descripcion], [Estado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (3, N'TipoPago', N'1', N'DB', N'Depósito Bancario', N'A', 1, CAST(0x00009F7B00000000 AS DateTime), 1, CAST(0x00009F7B00000000 AS DateTime))
INSERT [dbo].[Variable] ([IdVariable], [Nombre], [Codigo], [Valor], [Descripcion], [Estado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (4, N'TipoPago', N'2', N'CH', N'Cheque', N'A', 1, CAST(0x00009F7B00000000 AS DateTime), 1, CAST(0x00009F7B00000000 AS DateTime))
INSERT [dbo].[Variable] ([IdVariable], [Nombre], [Codigo], [Valor], [Descripcion], [Estado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (5, N'TipoPago', N'3', N'TR', N'Transferencia', N'A', 1, CAST(0x00009F7B00000000 AS DateTime), 1, CAST(0x00009F7B00000000 AS DateTime))
INSERT [dbo].[Variable] ([IdVariable], [Nombre], [Codigo], [Valor], [Descripcion], [Estado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (6, N'Sexo', N'1', N'M', N'Masculino', N'A', 1, CAST(0x00009EDF00000000 AS DateTime), 1, CAST(0x00009EDF00000000 AS DateTime))
INSERT [dbo].[Variable] ([IdVariable], [Nombre], [Codigo], [Valor], [Descripcion], [Estado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (7, N'Sexo', N'2', N'F', N'Masculino', N'A', 1, CAST(0x00009EDF00000000 AS DateTime), 1, CAST(0x00009EDF00000000 AS DateTime))
INSERT [dbo].[Variable] ([IdVariable], [Nombre], [Codigo], [Valor], [Descripcion], [Estado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (8, N'DatosContrato', N'Vendedor', N'JUAN ENRIQUE NARVAEZ CHAVEZ', N'Nombre', N'A', 1, CAST(0x00009EDF00000000 AS DateTime), 1, CAST(0x00009EDF00000000 AS DateTime))
INSERT [dbo].[Variable] ([IdVariable], [Nombre], [Codigo], [Valor], [Descripcion], [Estado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (9, N'DatosContrato', N'TipoDocumento', N'DNI', N'Tipo de Documento', N'A', 1, CAST(0x00009EDF00000000 AS DateTime), 1, CAST(0x00009EDF00000000 AS DateTime))
INSERT [dbo].[Variable] ([IdVariable], [Nombre], [Codigo], [Valor], [Descripcion], [Estado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (10, N'DatosContrato', N'NumeroDocumento', N'06702640', N'Número de Documento', N'A', 1, CAST(0x00009EDF00000000 AS DateTime), 1, CAST(0x00009EDF00000000 AS DateTime))
INSERT [dbo].[Variable] ([IdVariable], [Nombre], [Codigo], [Valor], [Descripcion], [Estado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (11, N'DatosContrato', N'Direccion', N'Bartolomé Herrera 549, Lince, Lima', N'Dirección', N'A', 1, CAST(0x00009EDF00000000 AS DateTime), 1, CAST(0x00009EDF00000000 AS DateTime))
/****** Object:  Table [dbo].[UsuarioPerfil]    Script Date: 10/29/2011 00:57:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioPerfil](
	[PerfilId] [int] NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[Estado] [bit] NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [smallint] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
 CONSTRAINT [pkUsp] PRIMARY KEY CLUSTERED 
(
	[PerfilId] ASC,
	[UsuarioId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioAcceso]    Script Date: 10/29/2011 00:57:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UsuarioAcceso](
	[AccesoId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[Objeto] [varchar](100) NOT NULL,
	[WebForm] [varchar](200) NOT NULL,
	[PadreId] [int] NOT NULL,
	[TipoMenu] [int] NOT NULL,
	[Imagen] [image] NULL,
	[NombreImagen] [varchar](30) NULL,
	[Activo] [bit] NOT NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [smallint] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
 CONSTRAINT [pkSea] PRIMARY KEY CLUSTERED 
(
	[AccesoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_UPD02]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create

 

 

PROCEDURE [dbo].[USUARIO_UPD02](


  @IdUsuario  int 

, @Password varchar(255)

, @UsuarioModificacion smallint

, @FechaModificacion datetime

)


AS


UPDATE  USUARIO

SET


 Password=@Password,
  FlgCambioPwd = 0,

 UsuarioModificacion=@UsuarioModificacion, 

 FechaModificacion=@FechaModificacion


WHERE


 

IDUSUARIO=@IDUSUARIO
GO
/****** Object:  StoredProcedure [dbo].[Usuario_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_UPD01]
 (
@IdUsuario  int
           ,  @Cuenta varchar(100)
           , @Nombre varchar(100)
           , @Descripcion varchar(100)
           , @Password varchar(255)
           , @Correo varchar(200)
           , @LookAndFeel varchar(50)
           , @Imagen image = null
           , @Activo bit
           , @UsuarioCreacion smallint
           , @FechaCreacion datetime
           , @UsuarioModificacion smallint
           , @FechaModificacion  datetime
            , @FlgCambioPwd bit
           )

AS

UPDATE USUARIO
SET

             Cuenta=@Cuenta, 
             Nombre=@Nombre, 
             Descripcion=@Descripcion,
             Password=@Password,
             Correo=@Correo,
             LookAndFeel=@LookAndFeel,
             Imagen=@Imagen,
             Activo=@Activo,
             FlgCambioPwd = @FlgCambioPwd ,
             UsuarioCreacion=@UsuarioCreacion, 
             FechaCreacion=@FechaCreacion,
             UsuarioModificacion=@UsuarioModificacion, 
             FechaModificacion=@FechaModificacion
WHERE
	IDUSUARIO=@IDUSUARIO
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_INS01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[USUARIO_INS01] (
              @IdUsuario  int
           ,  @Cuenta varchar(100)
           , @Nombre varchar(100)
           , @Descripcion varchar(100)
           , @Password varchar(255)
           , @Correo varchar(200)
           , @LookAndFeel varchar(50)
           , @Imagen image = null
           , @Activo bit
           , @UsuarioCreacion smallint
           , @FechaCreacion datetime
           , @UsuarioModificacion smallint
           , @FechaModificacion  datetime
            , @FlgCambioPwd bit
           )

AS

SELECT @IDUSUARIO = ISNULL(MAX(IDUSUARIO),0) + 1 FROM USUARIO  

INSERT INTO Usuario
           ( Cuenta 
           , Nombre 
           , Descripcion 
           , Password 
           , Correo 
           , LookAndFeel 
           , Imagen 
           , Activo
            , FlgCambioPwd 
           , UsuarioCreacion 
           , FechaCreacion 
           , UsuarioModificacion 
           , FechaModificacion )
     VALUES
           (@Cuenta 
           , @Nombre 
           , @Descripcion 
           , @Password 
           , @Correo 
           , @LookAndFeel 
           , @Imagen 
           , @Activo 
           , @FlgCambioPwd
           , @UsuarioCreacion 
           , @FechaCreacion 
           , @UsuarioModificacion 
           , @FechaModificacion )
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_GET02]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[USUARIO_GET02] (
 @cuenta varchar(100)=null
)
AS

SELECT  

	  IdUsuario, Cuenta, Nombre, Descripcion, Password, Correo, LookAndFeel, Imagen, Activo, UsuarioCreacion, FechaCreacion, UsuarioModificacion, 
                      FechaModificacion , FlgCambioPwd
FROM         Usuario u (nolock)
where (@cuenta  = Cuenta or ISNULL(@cuenta,'')='')
ORDER BY IDUsuario
GO
/****** Object:  StoredProcedure [dbo].[VARIABLE_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VARIABLE_UPD01]
 
@IDVARIABLE		INT,
@NOMBRE		VARCHAR(30),
@CODIGO		VARCHAR(20),
@VALOR		VARCHAR(300),
@DESCRIPCION		VARCHAR(300),
@ESTADO		CHAR(1),
@USUARIOCREACION		SMALLINT,
@FECHACREACION		DATETIME,
@USUARIOMODIFICACION		SMALLINT,
@FECHAMODIFICACION		DATETIME

AS

UPDATE VARIABLE
SET
	NOMBRE=@NOMBRE,
	CODIGO=@CODIGO,
	VALOR=@VALOR,
	DESCRIPCION=@DESCRIPCION,
	ESTADO=@ESTADO,
	USUARIOCREACION=@USUARIOCREACION,
	FECHACREACION=@FECHACREACION,
	USUARIOMODIFICACION=@USUARIOMODIFICACION,
	FECHAMODIFICACION=@FECHAMODIFICACION
WHERE
	IDVARIABLE=@IDVARIABLE
GO
/****** Object:  StoredProcedure [dbo].[VARIABLE_INS01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VARIABLE_INS01]
 
@IDVARIABLE		INT,
@NOMBRE		VARCHAR(30),
@CODIGO		VARCHAR(20),
@VALOR		VARCHAR(300),
@DESCRIPCION		VARCHAR(300),
@ESTADO		CHAR(1),
@USUARIOCREACION		SMALLINT,
@FECHACREACION		DATETIME,
@USUARIOMODIFICACION		SMALLINT,
@FECHAMODIFICACION		DATETIME

AS

SELECT @IDVARIABLE = ISNULL(MAX(IDVARIABLE),0) + 1 FROM VARIABLE

INSERT INTO VARIABLE
(
	IDVARIABLE,
	NOMBRE,
	CODIGO,
	VALOR,
	DESCRIPCION,
	ESTADO,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
)
VALUES
(
	@IDVARIABLE,
	@NOMBRE,
	@CODIGO,
	@VALOR,
	@DESCRIPCION,
	@ESTADO,
	@USUARIOCREACION,
	@FECHACREACION,
	@USUARIOMODIFICACION,
	@FECHAMODIFICACION
)
GO
/****** Object:  StoredProcedure [dbo].[VARIABLE_GET02]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VARIABLE_GET02] --'N'
 
@Nombre		varchar(30)

AS

SELECT  

	 IdVariable ,
	 Nombre ,
	 Codigo ,
	 Valor ,
	 Descripcion ,
	 Estado ,
	 UsuarioCreacion ,
	 FechaCreacion ,
	 UsuarioModificacion ,
	 FechaModificacion 
FROM  
	Variable
WHERE
	(Nombre=@Nombre or isnull(@Nombre,'')='')
GO
/****** Object:  StoredProcedure [dbo].[VARIABLE_GET01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VARIABLE_GET01]
 
@IDVARIABLE		INT

AS

SELECT  

	IDVARIABLE,
	NOMBRE,
	CODIGO,
	VALOR,
	DESCRIPCION,
	ESTADO,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
FROM  
	VARIABLE
WHERE
	IDVARIABLE=@IDVARIABLE
GO
/****** Object:  StoredProcedure [dbo].[VARIABLE_DEL01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VARIABLE_DEL01]
 
@IDVARIABLE		INT

AS

DELETE FROM VARIABLE
WHERE
	IDVARIABLE=@IDVARIABLE
GO
/****** Object:  StoredProcedure [dbo].[BANCO_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BANCO_UPD01]
 
@IDBANCO		SMALLINT,
@CODIGOBANCO		CHAR(3),
@DESCRIPCION		VARCHAR(60),
@USUARIOCREACION		SMALLINT,
@FECHACREACION		DATETIME,
@USUARIOMODIFICACION		SMALLINT,
@FECHAMODIFICACION		DATETIME

AS

UPDATE BANCO
SET
	CODIGOBANCO=@CODIGOBANCO,
	DESCRIPCION=@DESCRIPCION,
	USUARIOCREACION=@USUARIOCREACION,
	FECHACREACION=@FECHACREACION,
	USUARIOMODIFICACION=@USUARIOMODIFICACION,
	FECHAMODIFICACION=@FECHAMODIFICACION
WHERE
	IDBANCO=@IDBANCO
GO
/****** Object:  StoredProcedure [dbo].[BANCO_INS01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BANCO_INS01]
 
@IDBANCO		SMALLINT,
@CODIGOBANCO		CHAR(3),
@DESCRIPCION		VARCHAR(60),
@USUARIOCREACION		SMALLINT,
@FECHACREACION		DATETIME,
@USUARIOMODIFICACION		SMALLINT,
@FECHAMODIFICACION		DATETIME

AS

SELECT @IDBANCO = ISNULL(MAX(IDBANCO),0) + 1 FROM BANCO

INSERT INTO BANCO
(
	IDBANCO,
	CODIGOBANCO,
	DESCRIPCION,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
)
VALUES
(
	@IDBANCO,
	@CODIGOBANCO,
	@DESCRIPCION,
	@USUARIOCREACION,
	@FECHACREACION,
	@USUARIOMODIFICACION,
	@FECHAMODIFICACION
)
GO
/****** Object:  StoredProcedure [dbo].[BANCO_GET02]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BANCO_GET02]
 

AS

SELECT  

	IDBANCO,
	CODIGOBANCO,
	DESCRIPCION,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
FROM  
	BANCO
ORDER BY IDBANCO
GO
/****** Object:  StoredProcedure [dbo].[BANCO_GET01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BANCO_GET01]
 
@IDBANCO		SMALLINT

AS

SELECT  

	IDBANCO,
	CODIGOBANCO,
	DESCRIPCION,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
FROM  
	BANCO
WHERE
	IDBANCO=@IDBANCO
GO
/****** Object:  StoredProcedure [dbo].[BANCO_DEL01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BANCO_DEL01]
 
@IDBANCO		SMALLINT

AS

DELETE FROM BANCO
WHERE
	IDBANCO=@IDBANCO
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_ObtenerValorImpuesto]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==============================================
-- Author:		Fernando Arellano
-- Create date: 04/08/2011
-- Description:	Obtiene Impuesto por Tipo y Fecha
-- ==============================================
CREATE FUNCTION [dbo].[Fn_ObtenerValorImpuesto]
(
	-- Add the parameters for the function here
	@Tipo as char(3), @Fecha as datetime
)
RETURNS float
AS
BEGIN
	-- Declare the return variable here
	DECLARE @valor as smallint

	-- Add the T-SQL statements to compute the return value here
	SELECT @valor = valor
	  FROM Impuesto
	 WHERE ((FechaHasta is null and FechaDesde <= @Fecha)
        or  (FechaHasta is not null and @Fecha between FechaDesde and FechaHasta))

	-- Return the result of the function
	RETURN @valor

END
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Decenas]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Fn_Decenas](@Numero as bigint, @Estilo as bit=0) 
RETURNS varchar(500) AS  
BEGIN 
 DECLARE @Texto varchar(500)
 SELECT @Texto=''
 
 SELECT @Texto=
 CASE 
  WHEN @Numero=10 THEN 'diez'
  WHEN @Numero=11 THEN 'once'
  WHEN @Numero=12 THEN 'doce'
  WHEN @Numero=13 THEN 'trece'
  WHEN @Numero=14 THEN 'catorce'
  WHEN @Numero=15 THEN 'quince'
  WHEN @Numero>15 and @Numero<19 THEN 'dieci' + 
       dbo.Fn_Unidades(RIGHT(CONVERT(varchar, @Numero), 1), 1)
  WHEN @Numero=19 THEN 'diecinueve'
  WHEN @Numero=20 THEN 'veinte'
  WHEN @Numero=29 THEN 'veintinueve'
  WHEN @Numero>20 and @Numero<30 and @Numero<>29 THEN 'veinti' + 
       dbo.Fn_Unidades(RIGHT(CONVERT(varchar, @Numero), 1), 1)
  WHEN @Numero=30 THEN 'treinta'
  WHEN @Numero>30 and @Numero<40 THEN 'treinta y ' + 
       dbo.Fn_Unidades(RIGHT(CONVERT(varchar, @Numero), 1), 0)
  WHEN @Numero=40 THEN 'cuarenta'
  WHEN @Numero>40 and @Numero<50 THEN 'cuarenta y ' + 
       dbo.Fn_Unidades(RIGHT(CONVERT(varchar, @Numero), 1), 0)
  WHEN @Numero=50 THEN 'cincuenta'
  WHEN @Numero>50 and @Numero<60 THEN 'cincuenta y ' + 
       dbo.Fn_Unidades(RIGHT(CONVERT(varchar, @Numero), 1), 0)
  WHEN @Numero=60 THEN 'sesenta'
  WHEN @Numero>60 and @Numero<70 THEN 'sesenta y ' + 
       dbo.Fn_Unidades(RIGHT(CONVERT(varchar, @Numero), 1), 0)
  WHEN @Numero=70 THEN 'setenta'
  WHEN @Numero>70 and @Numero<80 THEN 'setenta y ' + 
       dbo.Fn_Unidades(RIGHT(CONVERT(varchar, @Numero), 1), 0)
  WHEN @Numero=80 THEN 'ochenta'
  WHEN @Numero>80 and @Numero<90 THEN 'ochenta y ' + 
       dbo.Fn_Unidades(RIGHT(CONVERT(varchar, @Numero), 1), 0)
  WHEN @Numero=90 THEN 'noventa'
  WHEN @Numero>90 and @Numero<100 THEN 'noventa y ' + 
       dbo.Fn_Unidades(RIGHT(CONVERT(varchar, @Numero), 1), 0)
  WHEN @Numero<10 THEN dbo.Fn_Unidades(@Numero, @Estilo)
 END

 RETURN @Texto
END
GO
/****** Object:  StoredProcedure [dbo].[MONEDA_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MONEDA_UPD01]
 
@IDMONEDA		SMALLINT,
@CODIGOMONEDA		CHAR(3),
@DESCRIPCION		VARCHAR(50),
@USUARIOCREACION		SMALLINT,
@FECHACREACION		DATETIME,
@USUARIOMODIFICACION		SMALLINT,
@FECHAMODIFICACION		DATETIME

AS

UPDATE MONEDA
SET
	CODIGOMONEDA=@CODIGOMONEDA,
	DESCRIPCION=@DESCRIPCION,
	USUARIOCREACION=@USUARIOCREACION,
	FECHACREACION=@FECHACREACION,
	USUARIOMODIFICACION=@USUARIOMODIFICACION,
	FECHAMODIFICACION=@FECHAMODIFICACION
WHERE
	IDMONEDA=@IDMONEDA
GO
/****** Object:  StoredProcedure [dbo].[MONEDA_INS01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MONEDA_INS01]
 
@IDMONEDA		SMALLINT,
@CODIGOMONEDA		CHAR(3),
@DESCRIPCION		VARCHAR(50),
@USUARIOCREACION		SMALLINT,
@FECHACREACION		DATETIME,
@USUARIOMODIFICACION		SMALLINT,
@FECHAMODIFICACION		DATETIME

AS

SELECT @IDMONEDA = ISNULL(MAX(IDMONEDA),0) + 1 FROM MONEDA
 
INSERT INTO MONEDA
(
	IDMONEDA,
	CODIGOMONEDA,
	DESCRIPCION,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
)
VALUES
(
	@IDMONEDA,
	@CODIGOMONEDA,
	@DESCRIPCION,
	@USUARIOCREACION,
	@FECHACREACION,
	@USUARIOMODIFICACION,
	@FECHAMODIFICACION
)
GO
/****** Object:  StoredProcedure [dbo].[MONEDA_GET02]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MONEDA_GET02]
 

AS

SELECT  

	IDMONEDA,
	CODIGOMONEDA,
	DESCRIPCION,
	TEXTOIMPRESION,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
FROM  
	MONEDA
ORDER BY IDMONEDA
GO
/****** Object:  StoredProcedure [dbo].[MONEDA_GET01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MONEDA_GET01]
 
@IDMONEDA		SMALLINT

AS

SELECT  

	IDMONEDA,
	CODIGOMONEDA,
	DESCRIPCION,
	TEXTOIMPRESION,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
FROM  
	MONEDA
WHERE
	IDMONEDA=@IDMONEDA
GO
/****** Object:  StoredProcedure [dbo].[MONEDA_DEL01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MONEDA_DEL01]
 
@IDMONEDA		SMALLINT

AS

DELETE FROM MONEDA
WHERE
	IDMONEDA=@IDMONEDA
GO
/****** Object:  Table [dbo].[Letra]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Letra](
	[IdLetra] [int] NOT NULL,
	[IdContrato] [int] NOT NULL,
	[NumeroCuota] [smallint] NOT NULL,
	[FechaCuota] [date] NOT NULL,
	[ImporteCuota] [money] NOT NULL,
	[Estado] [char](1) NOT NULL,
	[FechaPago] [date] NULL,
	[TipoPago] [char](2) NULL,
	[NumeroPago] [varchar](25) NULL,
	[IdDocumentoContable] [int] NULL,
	[ImporteMora] [money] NOT NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [smallint] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
 CONSTRAINT [pkLetra] PRIMARY KEY CLUSTERED 
(
	[IdLetra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (1, 1, 1, CAST(0xD6340B00 AS Date), 371.0000, N'P', CAST(0xD6340B00 AS Date), N'DB', N'000344222', 1, 0.0000, 1, CAST(0x00009F7B0142F726 AS DateTime), 1, CAST(0x00009F7B014B2F75 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (2, 1, 2, CAST(0xFB340B00 AS Date), 371.0000, N'P', CAST(0xD6340B00 AS Date), N'DB', N'000344222', 2, 0.0000, 1, CAST(0x00009F7B0142F727 AS DateTime), 1, CAST(0x00009F7B014B814F AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (3, 1, 3, CAST(0x19350B00 AS Date), 371.0000, N'P', CAST(0xD6340B00 AS Date), N'DB', N'000344222', 3, 0.0000, 1, CAST(0x00009F7B0142F733 AS DateTime), 1, CAST(0x00009F7B014B9665 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (4, 1, 4, CAST(0x38350B00 AS Date), 371.0000, N'P', CAST(0xD6340B00 AS Date), N'DB', N'000344229', 4, 0.0000, 1, CAST(0x00009F7B0142F736 AS DateTime), 1, CAST(0x00009F7B014BCF77 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (5, 1, 5, CAST(0x57350B00 AS Date), 371.0000, N'P', CAST(0xD6340B00 AS Date), N'CH', N'0003449897', 5, 0.0000, 1, CAST(0x00009F7B0142F736 AS DateTime), 1, CAST(0x00009F7B014E98A0 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (6, 1, 6, CAST(0x74350B00 AS Date), 371.0000, N'P', CAST(0xD6340B00 AS Date), N'TR', N'000344985444', 6, 0.0000, 1, CAST(0x00009F7B0142F737 AS DateTime), 1, CAST(0x00009F7B0153D11A AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (7, 1, 7, CAST(0x93350B00 AS Date), 371.0000, N'P', CAST(0xD6340B00 AS Date), N'TR', N'000344985444', 7, 0.0000, 1, CAST(0x00009F7B0142F737 AS DateTime), 1, CAST(0x00009F7B0154D130 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (8, 1, 8, CAST(0xB1350B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F737 AS DateTime), 1, CAST(0x00009F7B0142F737 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (9, 1, 9, CAST(0xD0350B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F737 AS DateTime), 1, CAST(0x00009F7B0142F737 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (10, 1, 10, CAST(0xEE350B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F737 AS DateTime), 1, CAST(0x00009F7B0142F737 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (11, 1, 11, CAST(0x0D360B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F738 AS DateTime), 1, CAST(0x00009F7B0142F738 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (12, 1, 12, CAST(0x2C360B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F739 AS DateTime), 1, CAST(0x00009F7B0142F739 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (13, 1, 13, CAST(0x4A360B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F739 AS DateTime), 1, CAST(0x00009F7B0142F739 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (14, 1, 14, CAST(0x69360B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F73A AS DateTime), 1, CAST(0x00009F7B0142F73A AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (15, 1, 15, CAST(0x87360B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F73A AS DateTime), 1, CAST(0x00009F7B0142F73A AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (16, 1, 16, CAST(0xA6360B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F73A AS DateTime), 1, CAST(0x00009F7B0142F73A AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (17, 1, 17, CAST(0xC5360B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F73A AS DateTime), 1, CAST(0x00009F7B0142F73A AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (18, 1, 18, CAST(0xE1360B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F73B AS DateTime), 1, CAST(0x00009F7B0142F73B AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (19, 1, 19, CAST(0x00370B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F73B AS DateTime), 1, CAST(0x00009F7B0142F73B AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (20, 1, 20, CAST(0x1E370B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F73C AS DateTime), 1, CAST(0x00009F7B0142F73C AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (21, 1, 21, CAST(0x3D370B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F73C AS DateTime), 1, CAST(0x00009F7B0142F73C AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (22, 1, 22, CAST(0x5B370B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F73D AS DateTime), 1, CAST(0x00009F7B0142F73D AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (23, 1, 23, CAST(0x7A370B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F73D AS DateTime), 1, CAST(0x00009F7B0142F73D AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (24, 1, 24, CAST(0x99370B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F73E AS DateTime), 1, CAST(0x00009F7B0142F73E AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (25, 1, 25, CAST(0xB7370B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F73F AS DateTime), 1, CAST(0x00009F7B0142F73F AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (26, 1, 26, CAST(0xD6370B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F740 AS DateTime), 1, CAST(0x00009F7B0142F740 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (27, 1, 27, CAST(0xF4370B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F740 AS DateTime), 1, CAST(0x00009F7B0142F740 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (28, 1, 28, CAST(0x13380B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F741 AS DateTime), 1, CAST(0x00009F7B0142F741 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (29, 1, 29, CAST(0x32380B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F741 AS DateTime), 1, CAST(0x00009F7B0142F741 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (30, 1, 30, CAST(0x4E380B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F742 AS DateTime), 1, CAST(0x00009F7B0142F742 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (31, 1, 31, CAST(0x6D380B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F743 AS DateTime), 1, CAST(0x00009F7B0142F743 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (32, 1, 32, CAST(0x8B380B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F743 AS DateTime), 1, CAST(0x00009F7B0142F743 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (33, 1, 33, CAST(0xAA380B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F744 AS DateTime), 1, CAST(0x00009F7B0142F744 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (34, 1, 34, CAST(0xC8380B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F746 AS DateTime), 1, CAST(0x00009F7B0142F746 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (35, 1, 35, CAST(0xE7380B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F746 AS DateTime), 1, CAST(0x00009F7B0142F746 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (36, 1, 36, CAST(0x06390B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F747 AS DateTime), 1, CAST(0x00009F7B0142F747 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (37, 1, 37, CAST(0x24390B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F747 AS DateTime), 1, CAST(0x00009F7B0142F747 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (38, 1, 38, CAST(0x43390B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F748 AS DateTime), 1, CAST(0x00009F7B0142F748 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (39, 1, 39, CAST(0x61390B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F749 AS DateTime), 1, CAST(0x00009F7B0142F749 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (40, 1, 40, CAST(0x80390B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F74A AS DateTime), 1, CAST(0x00009F7B0142F74A AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (41, 1, 41, CAST(0x9F390B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F74A AS DateTime), 1, CAST(0x00009F7B0142F74A AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (42, 1, 42, CAST(0xBB390B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F74B AS DateTime), 1, CAST(0x00009F7B0142F74B AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (43, 1, 43, CAST(0xDA390B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F74B AS DateTime), 1, CAST(0x00009F7B0142F74B AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (44, 1, 44, CAST(0xF8390B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F74C AS DateTime), 1, CAST(0x00009F7B0142F74C AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (45, 1, 45, CAST(0x173A0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F74C AS DateTime), 1, CAST(0x00009F7B0142F74C AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (46, 1, 46, CAST(0x353A0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F74D AS DateTime), 1, CAST(0x00009F7B0142F74D AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (47, 1, 47, CAST(0x543A0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F74E AS DateTime), 1, CAST(0x00009F7B0142F74E AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (48, 1, 48, CAST(0x733A0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F74E AS DateTime), 1, CAST(0x00009F7B0142F74E AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (49, 1, 49, CAST(0x913A0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F74F AS DateTime), 1, CAST(0x00009F7B0142F74F AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (50, 1, 50, CAST(0xB03A0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F74F AS DateTime), 1, CAST(0x00009F7B0142F74F AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (51, 1, 51, CAST(0xCE3A0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F750 AS DateTime), 1, CAST(0x00009F7B0142F750 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (52, 1, 52, CAST(0xED3A0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F750 AS DateTime), 1, CAST(0x00009F7B0142F750 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (53, 1, 53, CAST(0x0C3B0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F751 AS DateTime), 1, CAST(0x00009F7B0142F751 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (54, 1, 54, CAST(0x293B0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F751 AS DateTime), 1, CAST(0x00009F7B0142F751 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (55, 1, 55, CAST(0x483B0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F752 AS DateTime), 1, CAST(0x00009F7B0142F752 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (56, 1, 56, CAST(0x663B0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F752 AS DateTime), 1, CAST(0x00009F7B0142F752 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (57, 1, 57, CAST(0x853B0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F752 AS DateTime), 1, CAST(0x00009F7B0142F752 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (58, 1, 58, CAST(0xA33B0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F752 AS DateTime), 1, CAST(0x00009F7B0142F752 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (59, 1, 59, CAST(0xC23B0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F752 AS DateTime), 1, CAST(0x00009F7B0142F752 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (60, 1, 60, CAST(0xE13B0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F753 AS DateTime), 1, CAST(0x00009F7B0142F753 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (61, 1, 61, CAST(0xFF3B0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F753 AS DateTime), 1, CAST(0x00009F7B0142F753 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (62, 1, 62, CAST(0x1E3C0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F754 AS DateTime), 1, CAST(0x00009F7B0142F754 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (63, 1, 63, CAST(0x3C3C0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F754 AS DateTime), 1, CAST(0x00009F7B0142F754 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (64, 1, 64, CAST(0x5B3C0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F754 AS DateTime), 1, CAST(0x00009F7B0142F754 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (65, 1, 65, CAST(0x7A3C0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F754 AS DateTime), 1, CAST(0x00009F7B0142F754 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (66, 1, 66, CAST(0x963C0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F755 AS DateTime), 1, CAST(0x00009F7B0142F755 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (67, 1, 67, CAST(0xB53C0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F755 AS DateTime), 1, CAST(0x00009F7B0142F755 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (68, 1, 68, CAST(0xD33C0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F755 AS DateTime), 1, CAST(0x00009F7B0142F755 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (69, 1, 69, CAST(0xF23C0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F755 AS DateTime), 1, CAST(0x00009F7B0142F755 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (70, 1, 70, CAST(0x103D0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F755 AS DateTime), 1, CAST(0x00009F7B0142F755 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (71, 1, 71, CAST(0x2F3D0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F755 AS DateTime), 1, CAST(0x00009F7B0142F755 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (72, 1, 72, CAST(0x4E3D0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F755 AS DateTime), 1, CAST(0x00009F7B0142F755 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (73, 1, 73, CAST(0x6C3D0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F756 AS DateTime), 1, CAST(0x00009F7B0142F756 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (74, 1, 74, CAST(0x8B3D0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F756 AS DateTime), 1, CAST(0x00009F7B0142F756 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (75, 1, 75, CAST(0xA93D0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F756 AS DateTime), 1, CAST(0x00009F7B0142F756 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (76, 1, 76, CAST(0xC83D0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F756 AS DateTime), 1, CAST(0x00009F7B0142F756 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (77, 1, 77, CAST(0xE73D0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F756 AS DateTime), 1, CAST(0x00009F7B0142F756 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (78, 1, 78, CAST(0x033E0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F758 AS DateTime), 1, CAST(0x00009F7B0142F758 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (79, 1, 79, CAST(0x223E0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F764 AS DateTime), 1, CAST(0x00009F7B0142F764 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (80, 1, 80, CAST(0x403E0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F766 AS DateTime), 1, CAST(0x00009F7B0142F766 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (81, 1, 81, CAST(0x5F3E0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F766 AS DateTime), 1, CAST(0x00009F7B0142F766 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (82, 1, 82, CAST(0x7D3E0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F76F AS DateTime), 1, CAST(0x00009F7B0142F76F AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (83, 1, 83, CAST(0x9C3E0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F770 AS DateTime), 1, CAST(0x00009F7B0142F770 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (84, 1, 84, CAST(0xBB3E0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F772 AS DateTime), 1, CAST(0x00009F7B0142F772 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (85, 1, 85, CAST(0xD93E0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F772 AS DateTime), 1, CAST(0x00009F7B0142F772 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (86, 1, 86, CAST(0xF83E0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F772 AS DateTime), 1, CAST(0x00009F7B0142F772 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (87, 1, 87, CAST(0x163F0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F772 AS DateTime), 1, CAST(0x00009F7B0142F772 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (88, 1, 88, CAST(0x353F0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F772 AS DateTime), 1, CAST(0x00009F7B0142F772 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (89, 1, 89, CAST(0x543F0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F772 AS DateTime), 1, CAST(0x00009F7B0142F772 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (90, 1, 90, CAST(0x703F0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F773 AS DateTime), 1, CAST(0x00009F7B0142F773 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (91, 1, 91, CAST(0x8F3F0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F773 AS DateTime), 1, CAST(0x00009F7B0142F773 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (92, 1, 92, CAST(0xAD3F0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F773 AS DateTime), 1, CAST(0x00009F7B0142F773 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (93, 1, 93, CAST(0xCC3F0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F773 AS DateTime), 1, CAST(0x00009F7B0142F773 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (94, 1, 94, CAST(0xEA3F0B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F773 AS DateTime), 1, CAST(0x00009F7B0142F773 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (95, 1, 95, CAST(0x09400B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F773 AS DateTime), 1, CAST(0x00009F7B0142F773 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (96, 1, 96, CAST(0x28400B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F773 AS DateTime), 1, CAST(0x00009F7B0142F773 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (97, 1, 97, CAST(0x46400B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F773 AS DateTime), 1, CAST(0x00009F7B0142F773 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (98, 1, 98, CAST(0x65400B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F773 AS DateTime), 1, CAST(0x00009F7B0142F773 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (99, 1, 99, CAST(0x83400B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F773 AS DateTime), 1, CAST(0x00009F7B0142F773 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (100, 1, 100, CAST(0xA2400B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F773 AS DateTime), 1, CAST(0x00009F7B0142F773 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (101, 1, 101, CAST(0xC1400B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F774 AS DateTime), 1, CAST(0x00009F7B0142F774 AS DateTime))
GO
print 'Processed 100 total records'
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (102, 1, 102, CAST(0xDE400B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F774 AS DateTime), 1, CAST(0x00009F7B0142F774 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (103, 1, 103, CAST(0xFD400B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F774 AS DateTime), 1, CAST(0x00009F7B0142F774 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (104, 1, 104, CAST(0x1B410B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F774 AS DateTime), 1, CAST(0x00009F7B0142F774 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (105, 1, 105, CAST(0x3A410B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F774 AS DateTime), 1, CAST(0x00009F7B0142F774 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (106, 1, 106, CAST(0x58410B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F774 AS DateTime), 1, CAST(0x00009F7B0142F774 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (107, 1, 107, CAST(0x77410B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F775 AS DateTime), 1, CAST(0x00009F7B0142F775 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (108, 1, 108, CAST(0x96410B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F775 AS DateTime), 1, CAST(0x00009F7B0142F775 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (109, 1, 109, CAST(0xB4410B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F775 AS DateTime), 1, CAST(0x00009F7B0142F775 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (110, 1, 110, CAST(0xD3410B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F775 AS DateTime), 1, CAST(0x00009F7B0142F775 AS DateTime))
INSERT [dbo].[Letra] ([IdLetra], [IdContrato], [NumeroCuota], [FechaCuota], [ImporteCuota], [Estado], [FechaPago], [TipoPago], [NumeroPago], [IdDocumentoContable], [ImporteMora], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (111, 1, 111, CAST(0xF1410B00 AS Date), 371.0000, N'A', NULL, NULL, NULL, NULL, 0.0000, 1, CAST(0x00009F7B0142F775 AS DateTime), 1, CAST(0x00009F7B0142F775 AS DateTime))
/****** Object:  UserDefinedFunction [dbo].[Fn_ObtenerIdImpuesto]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==============================================
-- Author:		Fernando Arellano
-- Create date: 04/08/2011
-- Description:	Obtiene Impuesto por Tipo y Fecha
-- ==============================================
CREATE FUNCTION [dbo].[Fn_ObtenerIdImpuesto]
(
	-- Add the parameters for the function here
	@Tipo as char(3), @Fecha as datetime
)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE @IdImpuesto as smallint

	-- Add the T-SQL statements to compute the return value here
	SELECT @IdImpuesto = IdImpuesto
	  FROM Impuesto
	 WHERE ((FechaHasta is null and FechaDesde <= @Fecha)
        or  (FechaHasta is not null and @Fecha between FechaDesde and FechaHasta))

	-- Return the result of the function
	RETURN @IdImpuesto

END
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_ObtenerFactorImpuesto]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==============================================
-- Author:		Fernando Arellano
-- Create date: 04/08/2011
-- Description:	Obtiene Impuesto por Tipo y Fecha
-- ==============================================
CREATE FUNCTION [dbo].[Fn_ObtenerFactorImpuesto]
(
	-- Add the parameters for the function here
	@Tipo as char(3), @Fecha as datetime
)
RETURNS decimal(10,2)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @factor as smallint

	-- Add the T-SQL statements to compute the return value here
	SELECT @factor = factor
	  FROM Impuesto
	 WHERE ((FechaHasta is null and FechaDesde <= @Fecha)
        or  (FechaHasta is not null and @Fecha between FechaDesde and FechaHasta))

	-- Return the result of the function
	RETURN @factor

END
GO
/****** Object:  StoredProcedure [dbo].[TIPODOCUMENTO_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TIPODOCUMENTO_UPD01]
 
@IDTIPODOCUMENTO		SMALLINT,
@CODIGOTIPODOCUMENTO		CHAR(3),
@DESCRIPCION		VARCHAR(50),
@VALORADO		CHAR(1),
@USUARIOCREACION		SMALLINT,
@FECHACREACION		DATETIME,
@USUARIOMODIFICACION		SMALLINT,
@FECHAMODIFICACION		DATETIME

AS

UPDATE TIPODOCUMENTO
SET
	CODIGOTIPODOCUMENTO=@CODIGOTIPODOCUMENTO,
	DESCRIPCION=@DESCRIPCION,
	VALORADO=@VALORADO,
	USUARIOCREACION=@USUARIOCREACION,
	FECHACREACION=@FECHACREACION,
	USUARIOMODIFICACION=@USUARIOMODIFICACION,
	FECHAMODIFICACION=@FECHAMODIFICACION
WHERE
	IDTIPODOCUMENTO=@IDTIPODOCUMENTO
GO
/****** Object:  StoredProcedure [dbo].[TIPODOCUMENTO_INS01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TIPODOCUMENTO_INS01]
 
@IDTIPODOCUMENTO		SMALLINT,
@CODIGOTIPODOCUMENTO		CHAR(3),
@DESCRIPCION		VARCHAR(50),
@VALORADO		CHAR(1),
@USUARIOCREACION		SMALLINT,
@FECHACREACION		DATETIME,
@USUARIOMODIFICACION		SMALLINT,
@FECHAMODIFICACION		DATETIME

AS

SELECT @IDTIPODOCUMENTO = ISNULL(MAX(IDTIPODOCUMENTO),0) + 1 FROM TIPODOCUMENTO

INSERT INTO TIPODOCUMENTO
(
	IDTIPODOCUMENTO,
	CODIGOTIPODOCUMENTO,
	DESCRIPCION,
	VALORADO,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
)
VALUES
(
	@IDTIPODOCUMENTO,
	@CODIGOTIPODOCUMENTO,
	@DESCRIPCION,
	@VALORADO,
	@USUARIOCREACION,
	@FECHACREACION,
	@USUARIOMODIFICACION,
	@FECHAMODIFICACION
)
GO
/****** Object:  StoredProcedure [dbo].[TIPODOCUMENTO_GET02]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[TIPODOCUMENTO_GET02] --'N'
 
@Valorado		varchar(1)

AS

SELECT  

	IdTipoDocumento,
	CodigoTipoDocumento,
	Descripcion ,
	Valorado,
	UsuarioCreacion,
	FechaCreacion,
	UsuarioModificacion,
	FechaModificacion
FROM  
	TipoDocumento
WHERE
	(valorado=@Valorado or isnull(@Valorado,'')='')
GO
/****** Object:  StoredProcedure [dbo].[TIPODOCUMENTO_GET01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TIPODOCUMENTO_GET01]
 
@IDTIPODOCUMENTO		SMALLINT

AS

SELECT  

	IDTIPODOCUMENTO,
	CODIGOTIPODOCUMENTO,
	DESCRIPCION,
	VALORADO,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
FROM  
	TIPODOCUMENTO
WHERE
	IDTIPODOCUMENTO=@IDTIPODOCUMENTO
GO
/****** Object:  StoredProcedure [dbo].[TIPODOCUMENTO_DEL01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TIPODOCUMENTO_DEL01]
 
@IDTIPODOCUMENTO		SMALLINT

AS

DELETE FROM TIPODOCUMENTO
WHERE
	IDTIPODOCUMENTO=@IDTIPODOCUMENTO
GO
/****** Object:  Table [dbo].[Socio]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Socio](
	[IdSocio] [int] NOT NULL,
	[TipoSocio] [char](1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[ApellidoPaterno] [varchar](100) NOT NULL,
	[ApellidoMaterno] [varchar](100) NOT NULL,
	[IdTipoDocumento] [smallint] NOT NULL,
	[NumeroDocumento] [varchar](25) NOT NULL,
	[TelefonoDomicilio] [varchar](20) NOT NULL,
	[TelefonoMovil] [varchar](20) NOT NULL,
	[TelefonoOficina] [varchar](20) NOT NULL,
	[Fax] [varchar](20) NOT NULL,
	[Direccion] [varchar](120) NOT NULL,
	[IdUbigeo] [int] NOT NULL,
	[ReferenciaDireccion] [varchar](100) NOT NULL,
	[Correo] [varchar](60) NOT NULL,
	[Mensajeria] [varchar](100) NOT NULL,
	[FechaNacimiento] [date] NULL,
	[Sexo] [char](1) NOT NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [smallint] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [pkSocio] PRIMARY KEY CLUSTERED 
(
	[IdSocio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Socio] ([IdSocio], [TipoSocio], [Nombre], [ApellidoPaterno], [ApellidoMaterno], [IdTipoDocumento], [NumeroDocumento], [TelefonoDomicilio], [TelefonoMovil], [TelefonoOficina], [Fax], [Direccion], [IdUbigeo], [ReferenciaDireccion], [Correo], [Mensajeria], [FechaNacimiento], [Sexo], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion], [Estado]) VALUES (1, N'C', N'FERNANDO', N'ARELLANO', N'MONTOYA', 1, N'07977308', N'', N'', N'', N'', N'AV. HÚSARES DE JUNÍN 1123 DPTO.101', 1274, N'ESPALDA DEL CÍRCULO MILITAR', N'', N'', NULL, N'M', 1, CAST(0x00009F8300B85BE0 AS DateTime), 1, CAST(0x00009F880173D7BE AS DateTime), N'A')
INSERT [dbo].[Socio] ([IdSocio], [TipoSocio], [Nombre], [ApellidoPaterno], [ApellidoMaterno], [IdTipoDocumento], [NumeroDocumento], [TelefonoDomicilio], [TelefonoMovil], [TelefonoOficina], [Fax], [Direccion], [IdUbigeo], [ReferenciaDireccion], [Correo], [Mensajeria], [FechaNacimiento], [Sexo], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion], [Estado]) VALUES (2, N'C', N'MARCO', N'COMUN', N'CMCC', 1, N'99999999', N'', N'', N'', N'', N'SU CASA', 1282, N'POR LA PLAYA', N'', N'', NULL, N'M', 1, CAST(0x00009F8300B85BE0 AS DateTime), 1, CAST(0x00009F8900F7A944 AS DateTime), N'A')
/****** Object:  StoredProcedure [dbo].[UBIGEO_GET02]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UBIGEO_GET02]-- 2 --1,1
(
@IdUbigeo int
 )
 AS

SELECT  
    IdUbigeo,
    IdDepartamento,
	NombreDepartamento,
	IdProvincia,
	NombreProvincia,
	IdDistrito,
	NombreDistrito
FROM  
	Ubigeo
where IdUbigeo=@IdUbigeo
GO
/****** Object:  StoredProcedure [dbo].[UBIGEO_GET01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UBIGEO_GET01]  --1,1
@IdUbigeo int
 
 AS

SELECT  
    IdUbigeo,
    IdDepartamento,
	NombreDepartamento,
	IdProvincia,
	NombreProvincia,
	IdDistrito,
	NombreDistrito
FROM  
	Ubigeo
where IdUbigeo=@IdUbigeo
GO
/****** Object:  StoredProcedure [dbo].[UBIGEO_GET_PROVINCIAS]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UBIGEO_GET_PROVINCIAS]
@IdDepartamento int 
 AS

SELECT  distinct	
	IdProvincia,
	NombreProvincia
FROM  
	Ubigeo (NOLOCK)
where IdDepartamento=@IdDepartamento
GO
/****** Object:  StoredProcedure [dbo].[UBIGEO_GET_DISTRITOS]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UBIGEO_GET_DISTRITOS]  --1,1
@IdDepartamento int,
@IdProvincia int
 
 AS

SELECT  distinct
    IdUbigeo,	
	IdDistrito,
	NombreDistrito
FROM  
	Ubigeo (NOLOCK)
where Iddepartamento=@IdDepartamento and IdProvincia=@IdProvincia
GO
/****** Object:  StoredProcedure [dbo].[UBIGEO_GET_DEPARTAMENTOS]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UBIGEO_GET_DEPARTAMENTOS] 
 AS

SELECT  distinct
	IdDepartamento,
	NombreDepartamento
FROM  
	Ubigeo (NOLOCK)
GO
/****** Object:  StoredProcedure [dbo].[UNIDADCATASTRAL_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UNIDADCATASTRAL_UPD01]
 
@IDUNIDADCATASTRAL		INT,
@DESCRIPCION		VARCHAR(10),
@SUPERFICIE		DECIMAL,
@PARTIDAREGISTRAL		VARCHAR(12),
@REGISTROPREDIAL		VARCHAR(150),
@USUARIOCREACION		SMALLINT,
@FECHACREACION		DATETIME,
@USUARIOMODIFICACION		SMALLINT,
@FECHAMODIFICACION		DATETIME

AS

UPDATE UNIDADCATASTRAL
SET
	DESCRIPCION=@DESCRIPCION,
	SUPERFICIE=@SUPERFICIE,
	PARTIDAREGISTRAL=@PARTIDAREGISTRAL,
	REGISTROPREDIAL=@REGISTROPREDIAL,
	USUARIOCREACION=@USUARIOCREACION,
	FECHACREACION=@FECHACREACION,
	USUARIOMODIFICACION=@USUARIOMODIFICACION,
	FECHAMODIFICACION=@FECHAMODIFICACION
WHERE
	IDUNIDADCATASTRAL=@IDUNIDADCATASTRAL
GO
/****** Object:  StoredProcedure [dbo].[UNIDADCATASTRAL_INS01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UNIDADCATASTRAL_INS01]
 
@IDUNIDADCATASTRAL		INT,
@DESCRIPCION		VARCHAR(10),
@SUPERFICIE		DECIMAL,
@PARTIDAREGISTRAL		VARCHAR(12),
@REGISTROPREDIAL		VARCHAR(150),
@USUARIOCREACION		SMALLINT,
@FECHACREACION		DATETIME,
@USUARIOMODIFICACION		SMALLINT,
@FECHAMODIFICACION		DATETIME

AS

SELECT @IDUNIDADCATASTRAL = ISNULL(MAX(IDUNIDADCATASTRAL),0) + 1 FROM UNIDADCATASTRAL

INSERT INTO UNIDADCATASTRAL
(
	IDUNIDADCATASTRAL,
	DESCRIPCION,
	SUPERFICIE,
	PARTIDAREGISTRAL,
	REGISTROPREDIAL,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
)
VALUES
(
	@IDUNIDADCATASTRAL,
	@DESCRIPCION,
	@SUPERFICIE,
	@PARTIDAREGISTRAL,
	@REGISTROPREDIAL,
	@USUARIOCREACION,
	@FECHACREACION,
	@USUARIOMODIFICACION,
	@FECHAMODIFICACION
)
GO
/****** Object:  StoredProcedure [dbo].[UNIDADCATASTRAL_GET02]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UNIDADCATASTRAL_GET02]
 

AS

SELECT  

	IDUNIDADCATASTRAL,
	DESCRIPCION,
	SUPERFICIE,
	PARTIDAREGISTRAL,
	REGISTROPREDIAL,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
FROM  
	UNIDADCATASTRAL
ORDER BY IDUNIDADCATASTRAL
GO
/****** Object:  StoredProcedure [dbo].[UNIDADCATASTRAL_GET01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UNIDADCATASTRAL_GET01]
 
@IDUNIDADCATASTRAL		INT

AS

SELECT  

	IDUNIDADCATASTRAL,
	DESCRIPCION,
	SUPERFICIE,
	PARTIDAREGISTRAL,
	REGISTROPREDIAL,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
FROM  
	UNIDADCATASTRAL
WHERE
	IDUNIDADCATASTRAL=@IDUNIDADCATASTRAL
GO
/****** Object:  StoredProcedure [dbo].[UNIDADCATASTRAL_DEL01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UNIDADCATASTRAL_DEL01]
 
@IDUNIDADCATASTRAL		INT

AS

DELETE FROM UNIDADCATASTRAL
WHERE
	IDUNIDADCATASTRAL=@IDUNIDADCATASTRAL
GO
/****** Object:  Table [dbo].[Proyecto]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proyecto](
	[IdProyecto] [int] NOT NULL,
	[Descripcion] [varchar](30) NOT NULL,
	[CantidadLotes] [smallint] NOT NULL,
	[IdMoneda] [smallint] NOT NULL,
	[IdBanco] [smallint] NOT NULL,
	[IdUbigeo] [int] NOT NULL,
	[CuentaCorriente] [varchar](20) NOT NULL,
	[ImporteMora] [money] NOT NULL,
	[Alquiler] [varchar](10) NOT NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [smallint] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
 CONSTRAINT [pkProyecto] PRIMARY KEY CLUSTERED 
(
	[IdProyecto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Proyecto] ([IdProyecto], [Descripcion], [CantidadLotes], [IdMoneda], [IdBanco], [IdUbigeo], [CuentaCorriente], [ImporteMora], [Alquiler], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (1, N'LAS VIÑAS DE CARABAYLLO', 40, 2, 2, 1246, N'8768768768', 1.6000, N'N', 1, CAST(0x00009F7B00000000 AS DateTime), 1, CAST(0x00009F820105F817 AS DateTime))
INSERT [dbo].[Proyecto] ([IdProyecto], [Descripcion], [CantidadLotes], [IdMoneda], [IdBanco], [IdUbigeo], [CuentaCorriente], [ImporteMora], [Alquiler], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (2, N'NUEVO PROYECTO', 120, 1, 1, 1246, N'76575676', 8.0000, N'N', 1, CAST(0x00009F8201061D6A AS DateTime), 1, CAST(0x00009F880173F342 AS DateTime))
/****** Object:  StoredProcedure [dbo].[SOCIO_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SOCIO_UPD01]
 
@IDSOCIO		INT,
@TIPOSOCIO		CHAR(1),
@NOMBRE		VARCHAR(100),
@APELLIDOPATERNO		VARCHAR(100),
@APELLIDOMATERNO		VARCHAR(100),
@ESTADO		VARCHAR(100),
@SEXO     CHAR(1),
@IDTIPODOCUMENTO		SMALLINT,
@NUMERODOCUMENTO		VARCHAR(25),
@TELEFONODOMICILIO		VARCHAR(20),
@TELEFONOMOVIL		VARCHAR(20),
@TELEFONOOFICINA		VARCHAR(20),
@FAX		VARCHAR(20),
@DIRECCION		VARCHAR(120),
@IDUBIGEO		INT,
@REFERENCIADIRECCION		VARCHAR(100),
@CORREO		VARCHAR(60),
@MENSAJERIA		VARCHAR(100),
@FECHANACIMIENTO		DATE,
@USUARIOCREACION		SMALLINT,
@FECHACREACION		DATETIME,
@USUARIOMODIFICACION		SMALLINT,
@FECHAMODIFICACION		DATETIME

AS

UPDATE SOCIO
SET
	TIPOSOCIO=@TIPOSOCIO,
	NOMBRE=@NOMBRE,
	APELLIDOPATERNO=@APELLIDOPATERNO,
	APELLIDOMATERNO=@APELLIDOMATERNO,
	Estado=@ESTADO,
	SEXO = @SEXO,
	IDTIPODOCUMENTO=@IDTIPODOCUMENTO,
	NUMERODOCUMENTO=@NUMERODOCUMENTO,
	TELEFONODOMICILIO=@TELEFONODOMICILIO,
	TELEFONOMOVIL=@TELEFONOMOVIL,
	TELEFONOOFICINA=@TELEFONOOFICINA,
	FAX=@FAX,
	DIRECCION=@DIRECCION,
	IDUBIGEO=@IDUBIGEO,
	REFERENCIADIRECCION=@REFERENCIADIRECCION,
	CORREO=@CORREO,
	MENSAJERIA=@MENSAJERIA,
	FECHANACIMIENTO=@FECHANACIMIENTO,
	USUARIOCREACION=@USUARIOCREACION,
	FECHACREACION=@FECHACREACION,
	USUARIOMODIFICACION=@USUARIOMODIFICACION,
	FECHAMODIFICACION=@FECHAMODIFICACION
WHERE
	IDSOCIO=@IDSOCIO
GO
/****** Object:  StoredProcedure [dbo].[SOCIO_INS01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SOCIO_INS01]
 
@IDSOCIO		INT,
@TIPOSOCIO		CHAR(1),
@NOMBRE		VARCHAR(100),
@APELLIDOPATERNO		VARCHAR(100),
@APELLIDOMATERNO		VARCHAR(100),
@IDTIPODOCUMENTO		SMALLINT,
@NUMERODOCUMENTO		VARCHAR(25),
@TELEFONODOMICILIO		VARCHAR(20),
@TELEFONOMOVIL		VARCHAR(20),
@TELEFONOOFICINA		VARCHAR(20),
@FAX		VARCHAR(20),
@DIRECCION		VARCHAR(120),
@IDUBIGEO		INT,
@REFERENCIADIRECCION		VARCHAR(100),
@CORREO		VARCHAR(60),
@ESTADO     CHAR(1),
@SEXO char(1),
@MENSAJERIA		VARCHAR(100),
@FECHANACIMIENTO		DATE,
@USUARIOCREACION		SMALLINT,
@FECHACREACION		DATETIME,
@USUARIOMODIFICACION		SMALLINT,
@FECHAMODIFICACION		DATETIME

AS

SELECT @IDSOCIO = ISNULL(MAX(IDSOCIO),0) + 1 FROM SOCIO

INSERT INTO SOCIO
(
	IDSOCIO,
	TIPOSOCIO,
	NOMBRE,
	APELLIDOPATERNO,
	APELLIDOMATERNO,
	IDTIPODOCUMENTO,
	NUMERODOCUMENTO,
	TELEFONODOMICILIO,
	TELEFONOMOVIL,
	TELEFONOOFICINA,
	FAX,
	DIRECCION,
	IDUBIGEO,
	REFERENCIADIRECCION,
	CORREO,
	ESTADO,
	SEXO,
	MENSAJERIA,
	FECHANACIMIENTO,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
)
VALUES
(
	@IDSOCIO,
	@TIPOSOCIO,
	@NOMBRE,
	@APELLIDOPATERNO,
	@APELLIDOMATERNO,
	
	@IDTIPODOCUMENTO,
	@NUMERODOCUMENTO,
	@TELEFONODOMICILIO,
	@TELEFONOMOVIL,
	@TELEFONOOFICINA,
	@FAX,
	@DIRECCION,
	@IDUBIGEO,
	@REFERENCIADIRECCION,
	@CORREO,
	@ESTADO,
	@SEXO,
	@MENSAJERIA,
	@FECHANACIMIENTO,
	@USUARIOCREACION,
	@FECHACREACION,
	@USUARIOMODIFICACION,
	@FECHAMODIFICACION
)
GO
/****** Object:  StoredProcedure [dbo].[SOCIO_GET02]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SOCIO_GET02]
 

AS

SELECT  

	IDSOCIO,
	TIPOSOCIO,
	s.NOMBRE,
	APELLIDOPATERNO,
	APELLIDOMATERNO,
	s.Estado,
	s.Sexo,
	s.IDTIPODOCUMENTO,	
	NUMERODOCUMENTO,
	TELEFONODOMICILIO,
	TELEFONOMOVIL,
	TELEFONOOFICINA,
	FAX,
	DIRECCION,
	s.IDUBIGEO,
	REFERENCIADIRECCION,
	CORREO,
	MENSAJERIA,
	FECHANACIMIENTO,
	s.USUARIOCREACION,
	s.FECHACREACION,
	s.USUARIOMODIFICACION,
	s.FECHAMODIFICACION,
	u.NombreDepartamento as Departamento,
	u.NombreProvincia as Provincia ,
	u.NombreDistrito as Distrito,
	u.IdDepartamento ,
	u.IdProvincia ,
	u.IdDistrito ,
	CodigoTipoDocumento,
	v.Descripcion as TipoSocioDesc
FROM  SOCIO s (nolock)
JOIN  TIPODOCUMENTO T (nolock) on t.IDTIPODOCUMENTO = s.IDTIPODOCUMENTO
JOIN  Ubigeo u (nolock) on u.IdUbigeo= s.IdUbigeo
JOIN  Variable v (nolock) on v.Valor= s.TipoSocio and v.Nombre='TipoSocio'
ORDER BY IDSOCIO
GO
/****** Object:  StoredProcedure [dbo].[SOCIO_GET01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SOCIO_GET01]
 
@IDSOCIO		INT

AS

SELECT  

	IDSOCIO,
	TIPOSOCIO,
	NOMBRE,
	APELLIDOMATERNO,
	ApellidoPaterno,
	IDTIPODOCUMENTO,
	NUMERODOCUMENTO,
	TELEFONODOMICILIO,
	TELEFONOMOVIL,
	TELEFONOOFICINA,
	FAX,
	DIRECCION,
	IDUBIGEO,
	REFERENCIADIRECCION,
	CORREO,
	MENSAJERIA,
	FECHANACIMIENTO,
	SEXO,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
FROM  
	SOCIO
WHERE
	IDSOCIO=@IDSOCIO
GO
/****** Object:  StoredProcedure [dbo].[SOCIO_DEL01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SOCIO_DEL01]
 
@IDSOCIO		INT

AS

UPDATE SOCIO 
SET Estado='E'
WHERE
	IDSOCIO=@IDSOCIO
GO
/****** Object:  Table [dbo].[Secuencia]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Secuencia](
	[IdSecuencia] [smallint] NOT NULL,
	[IdProyecto] [int] NOT NULL,
	[IdTipoDocumento] [smallint] NOT NULL,
	[SerieDocumento] [smallint] NOT NULL,
	[NumeroDocumentoInicial] [int] NOT NULL,
	[NumeroDocumentoFinal] [int] NOT NULL,
	[NumeroDocumentoCorriente] [int] NOT NULL,
	[Estado] [char](1) NOT NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [smallint] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
 CONSTRAINT [pkSecuencia] PRIMARY KEY CLUSTERED 
(
	[IdSecuencia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Secuencia] ([IdSecuencia], [IdProyecto], [IdTipoDocumento], [SerieDocumento], [NumeroDocumentoInicial], [NumeroDocumentoFinal], [NumeroDocumentoCorriente], [Estado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (1, 1, 3, 3, 1, 100, 83, N'A', 1, CAST(0x00009F7B00000000 AS DateTime), 1, CAST(0x00009F7B00000000 AS DateTime))
INSERT [dbo].[Secuencia] ([IdSecuencia], [IdProyecto], [IdTipoDocumento], [SerieDocumento], [NumeroDocumentoInicial], [NumeroDocumentoFinal], [NumeroDocumentoCorriente], [Estado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (2, 1, 4, 1, 1, 500, 500, N'C', 1, CAST(0x00009F7B00000000 AS DateTime), 1, CAST(0x00009F7B00000000 AS DateTime))
INSERT [dbo].[Secuencia] ([IdSecuencia], [IdProyecto], [IdTipoDocumento], [SerieDocumento], [NumeroDocumentoInicial], [NumeroDocumentoFinal], [NumeroDocumentoCorriente], [Estado], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (3, 1, 4, 1, 501, 1000, 501, N'A', 1, CAST(0x00009F7B00000000 AS DateTime), 1, CAST(0x00009F8801739C24 AS DateTime))
/****** Object:  StoredProcedure [dbo].[PROYECTO_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROYECTO_UPD01]
 
@IDPROYECTO		INT,
@DESCRIPCION		VARCHAR(30),
@CANTIDADLOTES		SMALLINT,
@IDMONEDA		SMALLINT,
@IDBANCO		SMALLINT,
@IDUBIGEO		INT,
@CUENTACORRIENTE		VARCHAR(20),
@IMPORTEMORA		MONEY,
@ALQUILER		VARCHAR(10),
@USUARIOCREACION		SMALLINT,
@FECHACREACION		DATETIME,
@USUARIOMODIFICACION		SMALLINT,
@FECHAMODIFICACION		DATETIME

AS

UPDATE PROYECTO
SET
	DESCRIPCION=@DESCRIPCION,
	CANTIDADLOTES=@CANTIDADLOTES,
	IDMONEDA=@IDMONEDA,
	IDBANCO=@IDBANCO,
	IDUBIGEO=@IDUBIGEO,
	CUENTACORRIENTE=@CUENTACORRIENTE,
	IMPORTEMORA=@IMPORTEMORA,
	ALQUILER=@ALQUILER,
	USUARIOCREACION=@USUARIOCREACION,
	FECHACREACION=@FECHACREACION,
	USUARIOMODIFICACION=@USUARIOMODIFICACION,
	FECHAMODIFICACION=@FECHAMODIFICACION
WHERE
	IDPROYECTO=@IDPROYECTO
GO
/****** Object:  StoredProcedure [dbo].[PROYECTO_INS01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROYECTO_INS01]
 
@IDPROYECTO		INT,
@DESCRIPCION		VARCHAR(30),
@CANTIDADLOTES		SMALLINT,
@IDMONEDA		SMALLINT,
@IDBANCO		SMALLINT,
@IDUBIGEO		INT,
@CUENTACORRIENTE		VARCHAR(20),
@IMPORTEMORA		MONEY,
@ALQUILER		VARCHAR(10),
@USUARIOCREACION		SMALLINT,
@FECHACREACION		DATETIME,
@USUARIOMODIFICACION		SMALLINT,
@FECHAMODIFICACION		DATETIME

AS

SELECT @IDPROYECTO = ISNULL(MAX(IDPROYECTO),0) + 1 FROM PROYECTO

INSERT INTO PROYECTO
(
	IDPROYECTO,
	DESCRIPCION,
	CANTIDADLOTES,
	IDMONEDA,
	IDBANCO,
	IDUBIGEO,
	CUENTACORRIENTE,
	IMPORTEMORA,
	ALQUILER,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
)
VALUES
(
	@IDPROYECTO,
	@DESCRIPCION,
	@CANTIDADLOTES,
	@IDMONEDA,
	@IDBANCO,
	@IDUBIGEO,
	@CUENTACORRIENTE,
	@IMPORTEMORA,
	@ALQUILER,
	@USUARIOCREACION,
	@FECHACREACION,
	@USUARIOMODIFICACION,
	@FECHAMODIFICACION
)
GO
/****** Object:  StoredProcedure [dbo].[PROYECTO_GET02]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROYECTO_GET02]
 

AS

 SELECT p.IDPROYECTO,
		p.DESCRIPCION,
		p.CANTIDADLOTES,
		p.IDMONEDA,
		m.CodigoMoneda,
		p.IDBANCO,
		b.CodigoBanco,
		b.Descripcion AS Banco,
		p.IDUBIGEO,
		p.CUENTACORRIENTE,
		p.IMPORTEMORA,
		p.ALQUILER,
		u.IdDepartamento,
		u.NombreDepartamento as Departamento,
		u.IdProvincia,
		u.NombreProvincia as Provincia,
		u.IdDistrito,		
		u.NombreDistrito as Distrito,
		p.USUARIOCREACION,
		p.FECHACREACION,
		p.USUARIOMODIFICACION,
		p.FECHAMODIFICACION
   FROM PROYECTO p (nolock)
   JOIN Ubigeo u (nolock) on u.IdUbigeo= p.IdUbigeo
   JOIN Moneda m (nolock) on m.IdMoneda = p.IdMoneda
   JOIN Banco b (nolock) on b.IdBanco = p.IdBanco
  ORDER BY p.IDPROYECTO
GO
/****** Object:  StoredProcedure [dbo].[PROYECTO_GET01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROYECTO_GET01]
 
@IDPROYECTO		INT

AS

SELECT  

	IDPROYECTO,
	DESCRIPCION,
	CANTIDADLOTES,
	IDMONEDA,
	IDBANCO,
	IDUBIGEO,
	CUENTACORRIENTE,
	IMPORTEMORA,
	ALQUILER,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
FROM  
	PROYECTO
WHERE
	IDPROYECTO=@IDPROYECTO
GO
/****** Object:  StoredProcedure [dbo].[PROYECTO_DEL01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROYECTO_DEL01]
 
@IDPROYECTO		INT

AS

DELETE FROM PROYECTO
WHERE
	IDPROYECTO=@IDPROYECTO
GO
/****** Object:  StoredProcedure [dbo].[upInsertarLetrasPorContrato]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==============================================
-- Author:		Fernando Arellano
-- Create date: 13/10/2011
-- Description:	Generación de Letras por Contrato
-- ==============================================
CREATE PROCEDURE [dbo].[upInsertarLetrasPorContrato]
	-- Add the parameters for the stored procedure here
	@IdContrato int, @Usuario smallint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    IF EXISTS(SELECT * FROM Letra WHERE IdContrato = @IdContrato)
    BEGIN
		GOTO FIN1
    END
    
    DECLARE @nCuota int, @NumeroCuotas smallint, @ValorCuotas money, 
            @FechaInicio date, @DiaPago smallint, @IdLetra int, 
            @FechaCuota date, @ImporteCuota numeric(10,2),
            @ImporteMora decimal(10,2)
    
    SET @nCuota = 1    
	
	BEGIN TRY
		BEGIN TRAN
		DECLARE insert_cursor CURSOR 
		FOR
		SELECT I.IdContrato, I.NumeroCuotas, I.ValorCuotas, I.FechaInicio, I.DiaPago
		  FROM Contrato I 
		 WHERE I.IdContrato = @IdContrato
		OPEN insert_cursor
		FETCH NEXT FROM insert_cursor
		 INTO @IdContrato, @NumeroCuotas, @ValorCuotas, @FechaInicio, @DiaPago
		WHILE @nCuota <= @NumeroCuotas
		BEGIN
			SELECT @IdLetra = ISNULL(MAX(IdLetra),0) FROM Letra
			IF @nCuota = 1	    
				SET @FechaCuota = @FechaInicio
			ELSE
				SET @FechaCuota = DATEADD(m,1,CONVERT(char(6),@FechaCuota,112)+CONVERT(CHAR,@DiaPago))
	 
			INSERT INTO Letra
			(IdLetra, IdContrato, NumeroCuota, FechaCuota, ImporteCuota, Estado, ImporteMora, 
			 UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion)
			SELECT @IdLetra + 1, @IdContrato, @nCuota, @FechaCuota, @ValorCuotas, 'A', 0, 
			 @Usuario, GETDATE(), @Usuario, GETDATE()
		
			SET @nCuota = @nCuota + 1	    
		    
			FETCH NEXT FROM insert_cursor
			 INTO @IdContrato, @NumeroCuotas, @ValorCuotas, @FechaInicio, @DiaPago
		 
		END
		CLOSE insert_cursor
		DEALLOCATE insert_cursor
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		RETURN(2)
	END CATCH
	
	COMMIT TRAN
	
	RETURN (0)
	
	FIN1:
	RETURN(1)	
END
GO
/****** Object:  Table [dbo].[Lote]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lote](
	[IdLote] [int] NOT NULL,
	[Descripcion] [varchar](30) NOT NULL,
	[IdProyecto] [int] NOT NULL,
	[IdUnidadCatastral] [int] NOT NULL,
	[Superficie] [float] NOT NULL,
	[Manzana] [varchar](20) NOT NULL,
	[LinderoFrente] [varchar](50) NOT NULL,
	[LinderoDerecha] [varchar](50) NOT NULL,
	[LinderoIzquierda] [varchar](50) NOT NULL,
	[LinderoFondo] [varchar](50) NOT NULL,
	[ImporteLote] [money] NOT NULL,
	[CuotasMaximas] [smallint] NOT NULL,
	[ImporteMinimo] [money] NOT NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [smallint] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
 CONSTRAINT [pkLote] PRIMARY KEY CLUSTERED 
(
	[IdLote] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Lote] ([IdLote], [Descripcion], [IdProyecto], [IdUnidadCatastral], [Superficie], [Manzana], [LinderoFrente], [LinderoDerecha], [LinderoIzquierda], [LinderoFondo], [ImporteLote], [CuotasMaximas], [ImporteMinimo], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (1, N'PRUEBA LOTE', 1, 1, 100, N'A-200', N'A', N'B', N'C', N'D', 1250.2000, 2, 250.0000, 1, CAST(0x00009F7B00000000 AS DateTime), 1, CAST(0x00009F880174E6CE AS DateTime))
/****** Object:  UserDefinedFunction [dbo].[Fn_Centenas]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE FUNCTION [dbo].[Fn_Centenas](@Numero as bigint, @Estilo as bit=0) 
RETURNS varchar(500) AS  
BEGIN 
 DECLARE @Texto varchar(500)
 SELECT @Texto=''
 
 SELECT @Texto=
 CASE 
  WHEN @Numero=100 THEN 'cien'
  WHEN @Numero>100 and @Numero<200 THEN 'ciento ' + 
       dbo.Fn_Decenas(RIGHT(CONVERT(varchar, @Numero), 2), 0)
  WHEN @Numero>=500 and @Numero<600 THEN 'quinientos ' + 
       dbo.Fn_Decenas(RIGHT(CONVERT(varchar, @Numero), 2), 1)
  WHEN (@Numero>=200 and @Numero<500) or 
       (@Numero>500 and @Numero<1000) THEN 
       dbo.Fn_Decenas(LEFT(CONVERT(varchar, @Numero), 1), 1) + 
       'cientos ' + 
       dbo.Fn_Decenas(RIGHT(CONVERT(varchar, @Numero), 2), 0)
  WHEN @Numero<10 THEN dbo.Fn_Unidades(@Numero, 0)
  WHEN @Numero<100 THEN dbo.Fn_Decenas(@Numero, @Estilo)
 END

 RETURN @Texto
END
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_ObtenerIdSecuencia]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==============================================
-- Author:		Fernando Arellano
-- Create date: 04/08/2011
-- Description:	Obtiene Impuesto por Tipo y Fecha
-- ==============================================
CREATE FUNCTION [dbo].[Fn_ObtenerIdSecuencia]
(
	-- Add the parameters for the function here
	@IdLetra int, @IdTipoDocumento int
)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE @IdSecuencia as smallint

	-- Add the T-SQL statements to compute the return value here

	SELECT @IdSecuencia = IdSecuencia
	  FROM Letra a
	  JOIN Contrato b ON b.IdContrato = a.IdContrato
	  JOIN Lote c ON c.IdLote = b.IdLote
	  JOIN Secuencia d ON d.IdProyecto = c.IdProyecto
	 WHERE a.IdLetra = @IdLetra
	   AND d.IdTipoDocumento = @IdTipoDocumento
	   AND d.Estado = 'A'

	-- Return the result of the function
	RETURN @IdSecuencia

END
GO
/****** Object:  Table [dbo].[DocumentoContable]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentoContable](
	[IdDocumentoContable] [int] NOT NULL,
	[IdLetra] [int] NOT NULL,
	[IdImpuesto] [int] NOT NULL,
	[IdSecuencia] [smallint] NOT NULL,
	[NumeroDocumento] [int] NOT NULL,
	[IdMoneda] [smallint] NOT NULL,
	[Importe] [money] NOT NULL,
	[UsuarioCreacion] [smallint] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioModificacion] [smallint] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
 CONSTRAINT [pkDocumentoContable] PRIMARY KEY CLUSTERED 
(
	[IdDocumentoContable] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DocumentoContable] ([IdDocumentoContable], [IdLetra], [IdImpuesto], [IdSecuencia], [NumeroDocumento], [IdMoneda], [Importe], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (1, 1, 1, 1, 2, 1, 396.0000, 1, CAST(0x00009F7B014B2F75 AS DateTime), 1, CAST(0x00009F7B014B2F75 AS DateTime))
INSERT [dbo].[DocumentoContable] ([IdDocumentoContable], [IdLetra], [IdImpuesto], [IdSecuencia], [NumeroDocumento], [IdMoneda], [Importe], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (2, 2, 1, 1, 81, 1, 396.0000, 1, CAST(0x00009F7B014B814F AS DateTime), 1, CAST(0x00009F7B014B814F AS DateTime))
INSERT [dbo].[DocumentoContable] ([IdDocumentoContable], [IdLetra], [IdImpuesto], [IdSecuencia], [NumeroDocumento], [IdMoneda], [Importe], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (3, 3, 1, 1, 82, 1, 371.0000, 1, CAST(0x00009F7B014B9665 AS DateTime), 1, CAST(0x00009F7B014B9665 AS DateTime))
INSERT [dbo].[DocumentoContable] ([IdDocumentoContable], [IdLetra], [IdImpuesto], [IdSecuencia], [NumeroDocumento], [IdMoneda], [Importe], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (4, 4, 1, 2, 201, 1, 371.0000, 1, CAST(0x00009F7B014BCF77 AS DateTime), 1, CAST(0x00009F7B014BCF77 AS DateTime))
INSERT [dbo].[DocumentoContable] ([IdDocumentoContable], [IdLetra], [IdImpuesto], [IdSecuencia], [NumeroDocumento], [IdMoneda], [Importe], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (5, 5, 1, 2, 202, 1, 371.0000, 1, CAST(0x00009F7B014E98A0 AS DateTime), 1, CAST(0x00009F7B014E98A0 AS DateTime))
INSERT [dbo].[DocumentoContable] ([IdDocumentoContable], [IdLetra], [IdImpuesto], [IdSecuencia], [NumeroDocumento], [IdMoneda], [Importe], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (6, 6, 1, 1, 83, 1, 371.0000, 1, CAST(0x00009F7B0153D118 AS DateTime), 1, CAST(0x00009F7B0153D118 AS DateTime))
INSERT [dbo].[DocumentoContable] ([IdDocumentoContable], [IdLetra], [IdImpuesto], [IdSecuencia], [NumeroDocumento], [IdMoneda], [Importe], [UsuarioCreacion], [FechaCreacion], [UsuarioModificacion], [FechaModificacion]) VALUES (7, 7, 1, 3, 501, 1, 371.0000, 1, CAST(0x00009F7B0154D130 AS DateTime), 1, CAST(0x00009F7B0154D130 AS DateTime))
/****** Object:  StoredProcedure [dbo].[LOTE_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOTE_UPD01]
 
@IDLOTE		INT,
@DESCRIPCION		VARCHAR(30),
@IDPROYECTO		INT,
@IDUNIDADCATASTRAL		INT,
@SUPERFICIE		FLOAT,
@MANZANA		VARCHAR(20),
@LINDEROFRENTE		VARCHAR(50),
@LINDERODERECHA		VARCHAR(50),
@LINDEROIZQUIERDA		VARCHAR(50),
@LINDEROFONDO		VARCHAR(50),
@IMPORTELOTE		MONEY,
@CUOTASMAXIMAS		SMALLINT,
@IMPORTEMINIMO		MONEY,
@USUARIOCREACION		SMALLINT,
@FECHACREACION		DATETIME,
@USUARIOMODIFICACION		SMALLINT,
@FECHAMODIFICACION		DATETIME

AS

UPDATE LOTE
SET
	DESCRIPCION=@DESCRIPCION,
	IDPROYECTO=@IDPROYECTO,
	IDUNIDADCATASTRAL=@IDUNIDADCATASTRAL,
	SUPERFICIE=@SUPERFICIE,
	MANZANA=@MANZANA,
	LINDEROFRENTE=@LINDEROFRENTE,
	LINDERODERECHA=@LINDERODERECHA,
	LINDEROIZQUIERDA=@LINDEROIZQUIERDA,
	LINDEROFONDO=@LINDEROFONDO,
	IMPORTELOTE=@IMPORTELOTE,
	CUOTASMAXIMAS=@CUOTASMAXIMAS,
	IMPORTEMINIMO=@IMPORTEMINIMO,
	USUARIOCREACION=@USUARIOCREACION,
	FECHACREACION=@FECHACREACION,
	USUARIOMODIFICACION=@USUARIOMODIFICACION,
	FECHAMODIFICACION=@FECHAMODIFICACION
WHERE
	IDLOTE=@IDLOTE
GO
/****** Object:  StoredProcedure [dbo].[LOTE_INS01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOTE_INS01]
 
@IDLOTE		INT,
@DESCRIPCION		VARCHAR(30),
@IDPROYECTO		INT,
@IDUNIDADCATASTRAL		INT,
@SUPERFICIE		FLOAT,
@MANZANA		VARCHAR(20),
@LINDEROFRENTE		VARCHAR(50),
@LINDERODERECHA		VARCHAR(50),
@LINDEROIZQUIERDA		VARCHAR(50),
@LINDEROFONDO		VARCHAR(50),
@IMPORTELOTE		MONEY,
@CUOTASMAXIMAS		SMALLINT,
@IMPORTEMINIMO		MONEY,
@USUARIOCREACION		SMALLINT,
@FECHACREACION		DATETIME,
@USUARIOMODIFICACION		SMALLINT,
@FECHAMODIFICACION		DATETIME

AS

SELECT @IDLOTE = ISNULL(MAX(IDLOTE),0) + 1 FROM LOTE

INSERT INTO LOTE
(
	IDLOTE,
	DESCRIPCION,
	IDPROYECTO,
	IDUNIDADCATASTRAL,
	SUPERFICIE,
	MANZANA,
	LINDEROFRENTE,
	LINDERODERECHA,
	LINDEROIZQUIERDA,
	LINDEROFONDO,
	IMPORTELOTE,
	CUOTASMAXIMAS,
	IMPORTEMINIMO,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
)
VALUES
(
	@IDLOTE,
	@DESCRIPCION,
	@IDPROYECTO,
	@IDUNIDADCATASTRAL,
	@SUPERFICIE,
	@MANZANA,
	@LINDEROFRENTE,
	@LINDERODERECHA,
	@LINDEROIZQUIERDA,
	@LINDEROFONDO,
	@IMPORTELOTE,
	@CUOTASMAXIMAS,
	@IMPORTEMINIMO,
	@USUARIOCREACION,
	@FECHACREACION,
	@USUARIOMODIFICACION,
	@FECHAMODIFICACION
)
GO
/****** Object:  StoredProcedure [dbo].[LOTE_GET02]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOTE_GET02]
 

AS

SELECT  

	a.IDLOTE,
	a.DESCRIPCION,
	a.IDPROYECTO,
	a.IDUNIDADCATASTRAL,
	a.SUPERFICIE,
	a.MANZANA,
	a.LINDEROFRENTE,
	a.LINDERODERECHA,
	a.LINDEROIZQUIERDA,
	a.LINDEROFONDO,
	a.IMPORTELOTE,
	a.CUOTASMAXIMAS,
	a.IMPORTEMINIMO,
	p.Descripcion AS Proyecto,
	u.Descripcion AS UnidadCatastral,
	m.CodigoMoneda,
	a.USUARIOCREACION,
	a.FECHACREACION,
	a.USUARIOMODIFICACION,
	a.FECHAMODIFICACION
FROM  
	LOTE a (nolock)
JOIN Proyecto p (nolock) on p.IdProyecto = a.IdProyecto
JOIN UnidadCatastral u (nolock) on u.IdUnidadCatastral = a.IdUnidadCatastral
JOIN Moneda m (nolock) on m.IdMoneda = p.IdMoneda
ORDER BY IDLOTE
GO
/****** Object:  StoredProcedure [dbo].[LOTE_GET01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOTE_GET01]
 
@IDLOTE		INT

AS

SELECT  

	IDLOTE,
	DESCRIPCION,
	IDPROYECTO,
	IDUNIDADCATASTRAL,
	SUPERFICIE,
	MANZANA,
	LINDEROFRENTE,
	LINDERODERECHA,
	LINDEROIZQUIERDA,
	LINDEROFONDO,
	IMPORTELOTE,
	CUOTASMAXIMAS,
	IMPORTEMINIMO,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
FROM  
	LOTE
WHERE
	IDLOTE=@IDLOTE
GO
/****** Object:  StoredProcedure [dbo].[LOTE_DEL01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOTE_DEL01]
 
@IDLOTE		INT

AS

DELETE FROM LOTE
WHERE
	IDLOTE=@IDLOTE
GO
/****** Object:  StoredProcedure [dbo].[SECUENCIA_UPD01]    Script Date: 10/29/2011 00:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SECUENCIA_UPD01]
 
@IDSECUENCIA		SMALLINT,
@IDPROYECTO		INT,
@IDTIPODOCUMENTO		SMALLINT,
@SERIEDOCUMENTO		SMALLINT,
@NUMERODOCUMENTOINICIAL		INT,
@NUMERODOCUMENTOFINAL		INT,
@NUMERODOCUMENTOCORRIENTE		INT,
@ESTADO	CHAR(1),
@USUARIOCREACION		SMALLINT,
@FECHACREACION		DATETIME,
@USUARIOMODIFICACION		SMALLINT,
@FECHAMODIFICACION		DATETIME

AS

UPDATE SECUENCIA
SET
	IDPROYECTO=@IDPROYECTO,
	IDTIPODOCUMENTO=@IDTIPODOCUMENTO,
	SERIEDOCUMENTO=@SERIEDOCUMENTO,
	NUMERODOCUMENTOINICIAL=@NUMERODOCUMENTOINICIAL,
	NUMERODOCUMENTOFINAL=@NUMERODOCUMENTOFINAL,
	NUMERODOCUMENTOCORRIENTE=@NUMERODOCUMENTOCORRIENTE,
	ESTADO=@ESTADO,
	USUARIOCREACION=@USUARIOCREACION,
	FECHACREACION=@FECHACREACION,
	USUARIOMODIFICACION=@USUARIOMODIFICACION,
	FECHAMODIFICACION=@FECHAMODIFICACION
WHERE
	IDSECUENCIA=@IDSECUENCIA
GO
/****** Object:  StoredProcedure [dbo].[SECUENCIA_INS01]    Script Date: 10/29/2011 00:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SECUENCIA_INS01]
 
@IDSECUENCIA		SMALLINT,
@IDPROYECTO		INT,
@IDTIPODOCUMENTO		SMALLINT,
@SERIEDOCUMENTO		SMALLINT,
@NUMERODOCUMENTOINICIAL		INT,
@NUMERODOCUMENTOFINAL		INT,
@NUMERODOCUMENTOCORRIENTE		INT,
@ESTADO	CHAR(1),
@USUARIOCREACION		SMALLINT,
@FECHACREACION		DATETIME,
@USUARIOMODIFICACION		SMALLINT,
@FECHAMODIFICACION		DATETIME

AS

SELECT @IDSECUENCIA = ISNULL(MAX(IDSECUENCIA),0) + 1 FROM SECUENCIA

INSERT INTO SECUENCIA
(
	IDSECUENCIA,
	IDPROYECTO,
	IDTIPODOCUMENTO,
	SERIEDOCUMENTO,
	NUMERODOCUMENTOINICIAL,
	NUMERODOCUMENTOFINAL,
	NUMERODOCUMENTOCORRIENTE,
	ESTADO,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
)
VALUES
(
	@IDSECUENCIA,
	@IDPROYECTO,
	@IDTIPODOCUMENTO,
	@SERIEDOCUMENTO,
	@NUMERODOCUMENTOINICIAL,
	@NUMERODOCUMENTOFINAL,
	@NUMERODOCUMENTOCORRIENTE,
	@ESTADO,
	@USUARIOCREACION,
	@FECHACREACION,
	@USUARIOMODIFICACION,
	@FECHAMODIFICACION
)
GO
/****** Object:  StoredProcedure [dbo].[SECUENCIA_GET02]    Script Date: 10/29/2011 00:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SECUENCIA_GET02]
 

AS

SELECT
	s.IDSECUENCIA,
	s.IDPROYECTO,
	p.Descripcion as Proyecto,
	s.IDTIPODOCUMENTO,
	t.CodigoTipoDocumento,
	t.Descripcion as TipoDocumento,
	s.SERIEDOCUMENTO,
	s.NUMERODOCUMENTOINICIAL,
	s.NUMERODOCUMENTOFINAL,
	s.NUMERODOCUMENTOCORRIENTE,
	s.Estado,
	s.USUARIOCREACION,
	s.FECHACREACION,
	s.USUARIOMODIFICACION,
	s.FECHAMODIFICACION
FROM  
	SECUENCIA s (nolock)
JOIN Proyecto p (nolock) on p.IdProyecto = s.IdProyecto
JOIN TipoDocumento t (nolock) on t.IdTipoDocumento = s.IdTipoDocumento
ORDER BY s.IDSECUENCIA
GO
/****** Object:  StoredProcedure [dbo].[SECUENCIA_GET01]    Script Date: 10/29/2011 00:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SECUENCIA_GET01]
 
@IDSECUENCIA		SMALLINT

AS

SELECT  

	IDSECUENCIA,
	IDPROYECTO,
	IDTIPODOCUMENTO,
	SERIEDOCUMENTO,
	NUMERODOCUMENTOINICIAL,
	NUMERODOCUMENTOFINAL,
	NUMERODOCUMENTOCORRIENTE,
	ESTADO,
	USUARIOCREACION,
	FECHACREACION,
	USUARIOMODIFICACION,
	FECHAMODIFICACION
FROM  
	SECUENCIA
WHERE
	IDSECUENCIA=@IDSECUENCIA
GO
/****** Object:  StoredProcedure [dbo].[SECUENCIA_DEL01]    Script Date: 10/29/2011 00:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SECUENCIA_DEL01]
 
@IDSECUENCIA		SMALLINT

AS

DELETE FROM SECUENCIA
WHERE
	IDSECUENCIA=@IDSECUENCIA
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Millares]    Script Date: 10/29/2011 00:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Fn_Millares](@Numero as bigint, @Estilo as bit=0) 
RETURNS varchar(500) AS  
BEGIN 
 DECLARE @Texto varchar(500)
 DECLARE @EstiloCentenas bit

 SELECT @EstiloCentenas=CONVERT(bit,LEN(@Numero)-4)
 SELECT @Texto=
 CASE 
  WHEN @Numero=1000 THEN 'mil'
  WHEN @Numero>1000 and @Numero<2000 THEN 'mil ' + 
       dbo.Fn_Centenas(RIGHT(CONVERT(varchar, @Numero), 3), 1)
  WHEN @Numero>=2000 and @Numero<1000000 THEN 
       dbo.Fn_Centenas(LEFT(CONVERT(varchar, @Numero), LEN(@Numero)-3), 
        @EstiloCentenas) + 
       ' mil ' + 
       dbo.Fn_Centenas(RIGHT(CONVERT(varchar, @Numero), 3), 1)
  WHEN @Numero<1000 THEN dbo.Fn_Centenas(@Numero, @Estilo)
  WHEN @Numero<10 THEN dbo.Fn_Unidades(@Numero, 0)
  WHEN @Numero<100 THEN dbo.Fn_Decenas(@Numero, @Estilo)
  WHEN @Numero<1000 THEN dbo.Fn_Centenas(@Numero, @Estilo)
 END
 RETURN @Texto
END
GO
/****** Object:  StoredProcedure [dbo].[upInsertarDocumentoContablePorLetra]    Script Date: 10/29/2011 00:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Fernando Arellano
-- Create date: 13/10/2011
-- Description:	Generación de Documento Contable
-- =============================================
CREATE PROCEDURE [dbo].[upInsertarDocumentoContablePorLetra]
	-- Add the parameters for the stored procedure here
	(@IdLetra int, @FechaPago date, @IdMoneda int, @IdTipoDocumento int, @Usuario smallint,
	 @TipoPago char(2), @NumeroPago varchar(25), @ImporteMora numeric(10,2))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS(SELECT * FROM DocumentoContable WHERE IdLetra = @IdLetra)
		GOTO FIN1
		
	DECLARE @IdDocumentoContable int, @IdSecuencia int, @NumeroDocumento int
	SELECT @IdDocumentoContable = ISNULL(MAX(IdDocumentoContable),0) + 1 FROM DocumentoContable
	SET @IdSecuencia = dbo.Fn_ObtenerIdSecuencia(@IdLetra,@IdTipoDocumento)
	SELECT @NumeroDocumento = NumeroDocumentoCorriente + 1 FROM Secuencia WHERE IdSecuencia = @IdSecuencia
	
	BEGIN TRY
		BEGIN TRAN
		--Genera Documento Contable
		INSERT DocumentoContable
		SELECT @IdDocumentoContable, 
			   @IdLetra, 
			   dbo.Fn_ObtenerIdImpuesto('IGV',@FechaPago),
			   @IdSecuencia,
			   @NumeroDocumento,
			   @IdMoneda,
			   ImporteCuota + ImporteMora,
			   @Usuario,
			   GETDATE(),
			   @Usuario,
			   GETDATE()
		  FROM Letra
		 WHERE IdLetra = @IdLetra
		 --Actualiza Secuencia de Documento Contable
		 UPDATE Secuencia 
			SET NumeroDocumentoCorriente = @NumeroDocumento 
		  WHERE IdSecuencia = @IdSecuencia
		 --Actualiza Pago de Letra
		 UPDATE Letra
			SET Estado = 'P',
				FechaPago = @FechaPago,
				TipoPago = @TipoPago,
				NumeroPago = @NumeroPago,
				IdDocumentoContable = @IdDocumentoContable,
				ImporteMora = @ImporteMora,
				UsuarioModificacion = @Usuario,
				FechaModificacion = GETDATE()	
		  WHERE IdLetra = @IdLetra
	 END TRY
	 BEGIN CATCH
		ROLLBACK TRAN
		RETURN(2)
	 END CATCH
	 
	 COMMIT TRAN
	 
	 RETURN(0)
	 
	 FIN1:
	 RETURN(1)
END
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_NumeroEnLetra]    Script Date: 10/29/2011 00:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE FUNCTION [dbo].[Fn_NumeroEnLetra](@NumeroAProcesar as varchar(30)) 
RETURNS varchar(500) AS
BEGIN 
 DECLARE @Numero bigint
 DECLARE @Decimal varchar(30)
 DECLARE @Texto varchar(500)
 DECLARE @EstiloMillares bit

 SELECT @Texto=''

/* Obtenemos parte entera */
 IF patindex('%.%', @NumeroAProcesar)>0
 BEGIN
  SELECT @Numero=LEFT(@NumeroAProcesar, 
                      patindex('%.%', @NumeroAProcesar)-1)
 END
 ELSE
 BEGIN
  SELECT @Numero=CONVERT(bigint, @NumeroAProcesar)
 END

 SELECT @EstiloMillares=CONVERT(bit,LEN(@Numero)-7)

/* Proceso número negativos */
 IF @Numero<0
 BEGIN 
  SELECT @Texto='menos ' 
  SELECT @Numero=ABS(@Numero)
 END

/* Proceso parte entera */
 SELECT @Texto= @Texto +
 CASE 
  WHEN @Numero=1000000 THEN 'millón'
  WHEN @Numero>1000000 AND @Numero<1000000000000 THEN 
	dbo.Fn_Millares(
	 LEFT(CONVERT(varchar, @Numero), LEN(@Numero)-6), 
	 @EstiloMillares) +
	' millones ' +
	dbo.Fn_Millares(RIGHT(CONVERT(varchar, @Numero), 6), 1)
  WHEN @Numero<10 THEN dbo.Fn_Unidades(@Numero, 0)
  WHEN @Numero<100 THEN dbo.Fn_Decenas(@Numero, 1)
  WHEN @Numero<1000 THEN dbo.Fn_Centenas(@Numero, 1)
  WHEN @Numero<1000000 THEN dbo.Fn_Millares(@Numero, 1)
 END

/* Proceso parte decimal */
 IF patindex('%.%', @NumeroAProcesar)>0
 BEGIN
  SELECT @Decimal=
   RIGHT(@NumeroAProcesar, 
         LEN(@NumeroAProcesar)-patindex('%.%', @NumeroAProcesar))
  SELECT @Numero=@Decimal
  SELECT @Texto= @Texto + ' y ' +
  CASE 
   WHEN @Numero=1000000 THEN 'millón'
   WHEN @Numero>1000000 AND @Numero<1000000000000 THEN 
    dbo.Fn_Millares(
     LEFT(CONVERT(varchar, @Numero), LEN(@Numero)-6), 
     @EstiloMillares) +
    ' millones ' + 
    dbo.Fn_Millares(RIGHT(CONVERT(varchar, @Numero), 6), 1)
   WHEN @Numero<10 THEN right('00' + convert(varchar,@Numero),2)
   WHEN @Numero<100 THEN right('00' + convert(varchar,@Numero),2)
   WHEN @Numero<1000 THEN right('00' + convert(varchar,@Numero),2)
   WHEN @Numero<1000000 THEN right('00' + convert(varchar,@Numero),2)

--   WHEN @Numero<10 THEN dbo.Fn_Unidades(@Numero, 0)
--   WHEN @Numero<100 THEN dbo.Fn_Decenas(@Numero, 1)
--   WHEN @Numero<1000 THEN dbo.Fn_Centenas(@Numero, 1)
--   WHEN @Numero<1000000 THEN dbo.Fn_Millares(@Numero, 1)
  END

  SELECT @Texto = @Texto + '/100'
--  CASE 
--    WHEN LEN(@Decimal)=1 THEN ' decimas'
--    WHEN LEN(@Decimal)=2 THEN ' centimos'
--    WHEN LEN(@Decimal)=3 THEN ' milesimas'
--  END
 END

 RETURN @Texto
END
GO
/****** Object:  StoredProcedure [dbo].[upObtenerLetrasPorContrato]    Script Date: 10/29/2011 00:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Fernando Arellano
-- Create date: 13/10/2011
-- Description:	Consulta de Letras por Contrato
-- =============================================
CREATE PROCEDURE [dbo].[upObtenerLetrasPorContrato]
	-- Add the parameters for the stored procedure here
	(@IdContrato int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT a.IdLetra,
		   a.IdContrato,
		   a.NumeroCuota,
		   a.FechaCuota,
		   a.ImporteCuota,
		   a.Estado,
		   a.FechaPago,
		   a.TipoPago,
		   a.NumeroPago,
		   d.CodigoTipoDocumento,
		   e.IdMoneda,
		   c.IdTipoDocumento,
		   c.SerieDocumento,
		   b.NumeroDocumento,
		   a.ImporteMora,
		   a.UsuarioCreacion,
		   a.FechaCreacion,
		   a.UsuarioModificacion,
		   a.FechaModificacion
	  FROM Letra a (nolock)
	  LEFT JOIN DocumentoContable b (nolock) ON b.IdDocumentoContable = a.IdDocumentoContable
	  LEFT JOIN Secuencia c (nolock) ON c.IdSecuencia = b.IdSecuencia
	  LEFT JOIN TipoDocumento d (nolock) ON d.IdTipoDocumento = c.IdTipoDocumento
	  LEFT JOIN Contrato e (nolock) ON e.IdContrato = a.IdContrato
	 WHERE a.IdContrato = @IdContrato
END
GO
/****** Object:  StoredProcedure [dbo].[upObtenerInformacionPorContrato]    Script Date: 10/29/2011 00:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Fernando Arellano
-- Create date: 27/10/2011
-- Description:	Obtener Información por Contrato
-- =============================================
CREATE PROCEDURE [dbo].[upObtenerInformacionPorContrato]
	-- Add the parameters for the stored procedure here
	(@IdContrato int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DISTINCT
	       (select Valor from Variable where Nombre = 'DatosContrato' and Codigo = 'Vendedor') as NombreVendedor,
	       (select Valor from Variable where Nombre = 'DatosContrato' and Codigo = 'TipoDocumento') as TipoDocumentoVendedor,
	       (select Valor from Variable where Nombre = 'DatosContrato' and Codigo = 'NumeroDocumento') as NumeroDocumentoVendedor,
	       (select Valor from Variable where Nombre = 'DatosContrato' and Codigo = 'Direccion') as DireccionVendedor,
		   ct.DiaPago,
	       ct.FechaInicio,
	       mn.CodigoMoneda,
	       mn.Simbolo as SimboloMoneda,
	       ct.ImporteTotal,
	       UPPER(dbo.Fn_NumeroEnLetra(ct.ImporteTotal)) + space(1) + mn.TextoImpresion as ImporteTotalLetras,
	       ct.NumeroCuotas,
	       ct.ValorCuotas,
	       sp.Nombre as Nombre_SP,
	       sp.ApellidoPaterno as ApellidoPaterno_SP,
	       sp.ApellidoMaterno as ApellidoMaterno_SP,
	       sp.Correo as Correo_SP,
	       sp.Direccion as Direccion_SP,
	       usp.NombreDepartamento as Departamento_SP,
	       usp.NombreProvincia as Provincia_SP,
	       usp.NombreDistrito as Distrito_SP,
	       sp.Estado as Estado_SP,
	       sp.Fax as fax_SP,
	       sp.FechaNacimiento as FechaNacimiento_SP,
	       sp.Mensajeria as Mensajeria_SP,
	       tdp.CodigoTipoDocumento as CodigoTipoDocumento_SP,
	       sp.NumeroDocumento as NumeroDocumento_SP,
	       sp.ReferenciaDireccion as ReferenciaDireccion_SP,
	       sp.Sexo as Sexo_SP,
	       sp.TelefonoDomicilio as TelefonoDomicilio_SP,
	       sp.TelefonoMovil as TelefonoMovil_SP,
	       sp.TelefonoOficina as TelefonoOficina_SP,
	       sp.TipoSocio as TipoSocio_SP,	       
	       ss.Nombre as Nombre_SS,
	       ss.ApellidoPaterno as ApellidoPaterno_SS,
	       ss.ApellidoMaterno as ApellidoMaterno_SS,
	       ss.Correo as Correo_SS,
	       ss.Direccion as Direccion_SS,
	       uss.NombreDepartamento as Departamento_SS,
	       uss.NombreProvincia as Provincia_SS,
	       uss.NombreDistrito as Distrito_SS,
	       ss.Estado as Estado_SS,
	       ss.Fax as fax_SS,
	       ss.FechaNacimiento as FechaNacimiento_SS,
	       ss.Mensajeria as Mensajeria_SS,
	       tds.CodigoTipoDocumento as CodigoTipoDocumento_SS,
	       ss.NumeroDocumento as NumeroDocumento_SS,
	       ss.ReferenciaDireccion as ReferenciaDireccion_SS,
	       ss.Sexo as Sexo_SS,
	       ss.TelefonoDomicilio as TelefonoDomicilio_SS,
	       ss.TelefonoMovil as TelefonoMovil_SS,
	       ss.TelefonoOficina as TelefonoOficina_SS,
	       ss.TipoSocio as TipoSocio_SS,
	       lt.Descripcion as LoteContrato,
	       lt.ImporteLote,
	       lt.LinderoDerecha,
	       lt.LinderoFondo,
	       lt.LinderoFrente,
	       lt.LinderoIzquierda,
	       lt.Manzana as ManzanaLote,
	       lt.Superficie as SuperficieLote,
	       pr.Descripcion as NombreProyecto,
	       up.NombreDepartamento as DepartamentoProyecto,
	       up.NombreProvincia as ProvinciaProyecto,
	       up.NombreDistrito as DistritoProyecto,
	       pr.Alquiler,
	       pr.CantidadLotes,
	       pr.CuentaCorriente,
	       bc.Descripcion as Banco,
	       pr.ImporteMora,
	       uc.Descripcion as UnidadCatastral,
	       uc.PartidaRegistral,
	       uc.RegistroPredial,
	       uc.Superficie as SuperficieUC	       
	  FROM Contrato ct (nolock)
	  JOIN ContratoSocio csp (nolock) on csp.IdContrato = ct.IdContrato and csp.Principal = 'S'
	  JOIN Socio sp (nolock) on sp.IdSocio = csp.IdSocio
	  LEFT JOIN ContratoSocio css (nolock) on css.IdContrato = ct.IdContrato and css.Principal = 'N'
	  LEFT JOIN Socio ss (nolock) on ss.IdSocio = css.IdSocio
	  LEFT JOIN Lote lt (nolock) on lt.IdLote = ct.IdLote
	  LEFT JOIN Proyecto pr (nolock) on pr.IdProyecto = lt.IdProyecto
	  LEFT JOIN UnidadCatastral uc (nolock) on uc.IdUnidadCatastral = lt.IdUnidadCatastral
	  LEFT JOIN Moneda mn (nolock) on mn.IdMoneda = ct.IdMoneda
	  LEFT JOIN Banco bc (nolock) on bc.IdBanco = pr.IdBanco	  	  
	  LEFT JOIN TipoDocumento tdp (nolock) ON tdp.IdTipoDocumento = sp.IdTipoDocumento
	  LEFT JOIN TipoDocumento tds (nolock) ON tds.IdTipoDocumento = ss.IdTipoDocumento
	  LEFT JOIN Ubigeo up (nolock) ON up.IdUbigeo = pr.IdUbigeo 
	  LEFT JOIN Ubigeo usp (nolock) ON usp.IdUbigeo = sp.IdUbigeo and csp.Principal = 'S'
	  LEFT JOIN Ubigeo uss (nolock) ON uss.IdUbigeo = ss.IdUbigeo and css.Principal = 'N'
	 WHERE ct.IdContrato = @IdContrato
END
GO
/****** Object:  Default [DF_ListaError_Atendido]    Script Date: 10/29/2011 00:57:43 ******/
ALTER TABLE [dbo].[ListaError] ADD  CONSTRAINT [DF_ListaError_Atendido]  DEFAULT ('0') FOR [Atendido]
GO
/****** Object:  ForeignKey [fkLetraIdContrato]    Script Date: 10/29/2011 00:57:49 ******/
ALTER TABLE [dbo].[Letra]  WITH CHECK ADD  CONSTRAINT [fkLetraIdContrato] FOREIGN KEY([IdContrato])
REFERENCES [dbo].[Contrato] ([IdContrato])
GO
ALTER TABLE [dbo].[Letra] CHECK CONSTRAINT [fkLetraIdContrato]
GO
/****** Object:  ForeignKey [fkSocioIdTipoDocumento]    Script Date: 10/29/2011 00:57:49 ******/
ALTER TABLE [dbo].[Socio]  WITH CHECK ADD  CONSTRAINT [fkSocioIdTipoDocumento] FOREIGN KEY([IdTipoDocumento])
REFERENCES [dbo].[TipoDocumento] ([IdTipoDocumento])
GO
ALTER TABLE [dbo].[Socio] CHECK CONSTRAINT [fkSocioIdTipoDocumento]
GO
/****** Object:  ForeignKey [fkProyectoIdBanco]    Script Date: 10/29/2011 00:57:49 ******/
ALTER TABLE [dbo].[Proyecto]  WITH CHECK ADD  CONSTRAINT [fkProyectoIdBanco] FOREIGN KEY([IdBanco])
REFERENCES [dbo].[Banco] ([IdBanco])
GO
ALTER TABLE [dbo].[Proyecto] CHECK CONSTRAINT [fkProyectoIdBanco]
GO
/****** Object:  ForeignKey [fkSecuenciaIdProyecto]    Script Date: 10/29/2011 00:57:49 ******/
ALTER TABLE [dbo].[Secuencia]  WITH CHECK ADD  CONSTRAINT [fkSecuenciaIdProyecto] FOREIGN KEY([IdProyecto])
REFERENCES [dbo].[Proyecto] ([IdProyecto])
GO
ALTER TABLE [dbo].[Secuencia] CHECK CONSTRAINT [fkSecuenciaIdProyecto]
GO
/****** Object:  ForeignKey [fkSecuenciaIdTipoDocumento]    Script Date: 10/29/2011 00:57:49 ******/
ALTER TABLE [dbo].[Secuencia]  WITH CHECK ADD  CONSTRAINT [fkSecuenciaIdTipoDocumento] FOREIGN KEY([IdTipoDocumento])
REFERENCES [dbo].[TipoDocumento] ([IdTipoDocumento])
GO
ALTER TABLE [dbo].[Secuencia] CHECK CONSTRAINT [fkSecuenciaIdTipoDocumento]
GO
/****** Object:  ForeignKey [fkLoteIdProyecto]    Script Date: 10/29/2011 00:57:49 ******/
ALTER TABLE [dbo].[Lote]  WITH CHECK ADD  CONSTRAINT [fkLoteIdProyecto] FOREIGN KEY([IdProyecto])
REFERENCES [dbo].[Proyecto] ([IdProyecto])
GO
ALTER TABLE [dbo].[Lote] CHECK CONSTRAINT [fkLoteIdProyecto]
GO
/****** Object:  ForeignKey [fkLoteIdUnidadCatastral]    Script Date: 10/29/2011 00:57:49 ******/
ALTER TABLE [dbo].[Lote]  WITH CHECK ADD  CONSTRAINT [fkLoteIdUnidadCatastral] FOREIGN KEY([IdUnidadCatastral])
REFERENCES [dbo].[UnidadCatastral] ([IdUnidadCatastral])
GO
ALTER TABLE [dbo].[Lote] CHECK CONSTRAINT [fkLoteIdUnidadCatastral]
GO
/****** Object:  ForeignKey [fkDocumentoContableIdImpuesto]    Script Date: 10/29/2011 00:57:49 ******/
ALTER TABLE [dbo].[DocumentoContable]  WITH CHECK ADD  CONSTRAINT [fkDocumentoContableIdImpuesto] FOREIGN KEY([IdImpuesto])
REFERENCES [dbo].[Impuesto] ([IdImpuesto])
GO
ALTER TABLE [dbo].[DocumentoContable] CHECK CONSTRAINT [fkDocumentoContableIdImpuesto]
GO
/****** Object:  ForeignKey [fkDocumentoContableIdSecuencia]    Script Date: 10/29/2011 00:57:49 ******/
ALTER TABLE [dbo].[DocumentoContable]  WITH CHECK ADD  CONSTRAINT [fkDocumentoContableIdSecuencia] FOREIGN KEY([IdSecuencia])
REFERENCES [dbo].[Secuencia] ([IdSecuencia])
GO
ALTER TABLE [dbo].[DocumentoContable] CHECK CONSTRAINT [fkDocumentoContableIdSecuencia]
GO

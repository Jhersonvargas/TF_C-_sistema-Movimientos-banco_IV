USE [master]
GO
/****** Object:  Database [MovimientosBanco]    Script Date: 28/09/2023 1:19:38 ******/
CREATE DATABASE [MovimientosBanco]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MovimientosBanco', FILENAME = N'C:\Users\maico\OneDrive\Documentos\MSSQL16.MSSQLSERVER\MSSQL\DATA\MovimientosBanco.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MovimientosBanco_log', FILENAME = N'C:\Users\maico\OneDrive\Documentos\MSSQL16.MSSQLSERVER\MSSQL\DATA\MovimientosBanco_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MovimientosBanco] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MovimientosBanco].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MovimientosBanco] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MovimientosBanco] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MovimientosBanco] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MovimientosBanco] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MovimientosBanco] SET ARITHABORT OFF 
GO
ALTER DATABASE [MovimientosBanco] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MovimientosBanco] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MovimientosBanco] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MovimientosBanco] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MovimientosBanco] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MovimientosBanco] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MovimientosBanco] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MovimientosBanco] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MovimientosBanco] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MovimientosBanco] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MovimientosBanco] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MovimientosBanco] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MovimientosBanco] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MovimientosBanco] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MovimientosBanco] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MovimientosBanco] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MovimientosBanco] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MovimientosBanco] SET RECOVERY FULL 
GO
ALTER DATABASE [MovimientosBanco] SET  MULTI_USER 
GO
ALTER DATABASE [MovimientosBanco] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MovimientosBanco] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MovimientosBanco] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MovimientosBanco] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MovimientosBanco] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MovimientosBanco] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MovimientosBanco', N'ON'
GO
ALTER DATABASE [MovimientosBanco] SET QUERY_STORE = ON
GO
ALTER DATABASE [MovimientosBanco] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [MovimientosBanco]
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[cod_cli] [int] IDENTITY(1,1) NOT NULL,
	[dni] [int] NOT NULL,
	[apellidos] [varchar](50) NOT NULL,
	[nombres] [varchar](50) NOT NULL,
	[direccion] [varchar](100) NULL,
	[ciudad] [varchar](50) NOT NULL,
	[email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_cli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CUENTA]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUENTA](
	[nro_cta] [int] NOT NULL,
	[nro_sucursal] [int] NOT NULL,
	[cod_banco] [int] NOT NULL,
	[cod_cli] [int] NOT NULL,
	[saldo] [float] NOT NULL,
	[fechaapertura] [date] NOT NULL,
	[tipocta] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nro_cta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOVIMIENTOS]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOVIMIENTOS](
	[nro_mov] [int] IDENTITY(1,1) NOT NULL,
	[nro_cta] [int] NOT NULL,
	[nro_sucursal] [int] NOT NULL,
	[cod_banco] [int] NOT NULL,
	[tipo_mov] [varchar](50) NOT NULL,
	[fecha_mov] [int] NOT NULL,
	[importe] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nro_mov] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Vista_MovimientosCliente]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_MovimientosCliente]
AS
SELECT dbo.MOVIMIENTOS.nro_mov, dbo.CUENTA.nro_cta, dbo.CUENTA.tipocta, dbo.CUENTA.fechaapertura, dbo.CLIENTE.nombres, dbo.CLIENTE.apellidos, dbo.CLIENTE.dni, dbo.MOVIMIENTOS.tipo_mov, dbo.MOVIMIENTOS.fecha_mov, dbo.MOVIMIENTOS.importe
FROM   dbo.MOVIMIENTOS INNER JOIN
             dbo.CUENTA ON dbo.MOVIMIENTOS.nro_cta = dbo.CUENTA.nro_cta INNER JOIN
             dbo.CLIENTE ON dbo.CUENTA.cod_cli = dbo.CLIENTE.cod_cli
GO
/****** Object:  Table [dbo].[SUCURSAL]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUCURSAL](
	[nro_sucursal] [int] IDENTITY(1,1) NOT NULL,
	[cod_banco] [int] NOT NULL,
	[direccion] [varchar](100) NOT NULL,
	[ciudad] [varchar](100) NULL,
	[telefono] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nro_sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Vista_Cuenta_Sucursal]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_Cuenta_Sucursal]
AS
SELECT dbo.CUENTA.nro_cta, dbo.SUCURSAL.ciudad
FROM   dbo.CUENTA INNER JOIN
             dbo.SUCURSAL ON dbo.CUENTA.nro_sucursal = dbo.SUCURSAL.nro_sucursal
GO
/****** Object:  View [dbo].[Vista_CuentaMovimientos]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_CuentaMovimientos]
AS
SELECT C.nro_cta, C.nro_sucursal, C.cod_banco, C.cod_cli, C.saldo, M.tipo_mov, M.fecha_mov, M.importe
FROM   dbo.CUENTA AS C INNER JOIN
             dbo.MOVIMIENTOS AS M ON C.nro_cta = M.nro_cta
GO
/****** Object:  Table [dbo].[BANCO]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANCO](
	[cod_banco] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[direccion] [varchar](100) NOT NULL,
	[localidad] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_banco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CUENTA]  WITH CHECK ADD  CONSTRAINT [FK_CUENTA_cod_banco] FOREIGN KEY([cod_banco])
REFERENCES [dbo].[BANCO] ([cod_banco])
GO
ALTER TABLE [dbo].[CUENTA] CHECK CONSTRAINT [FK_CUENTA_cod_banco]
GO
ALTER TABLE [dbo].[CUENTA]  WITH CHECK ADD  CONSTRAINT [FK_CUENTA_nro_sucursal] FOREIGN KEY([nro_sucursal])
REFERENCES [dbo].[SUCURSAL] ([nro_sucursal])
GO
ALTER TABLE [dbo].[CUENTA] CHECK CONSTRAINT [FK_CUENTA_nro_sucursal]
GO
ALTER TABLE [dbo].[CUENTA]  WITH CHECK ADD  CONSTRAINT [FK_CUENTAE_cod_cli] FOREIGN KEY([cod_cli])
REFERENCES [dbo].[CLIENTE] ([cod_cli])
GO
ALTER TABLE [dbo].[CUENTA] CHECK CONSTRAINT [FK_CUENTAE_cod_cli]
GO
ALTER TABLE [dbo].[MOVIMIENTOS]  WITH CHECK ADD  CONSTRAINT [FK_MOVIMIENTOS_cod_banco] FOREIGN KEY([cod_banco])
REFERENCES [dbo].[BANCO] ([cod_banco])
GO
ALTER TABLE [dbo].[MOVIMIENTOS] CHECK CONSTRAINT [FK_MOVIMIENTOS_cod_banco]
GO
ALTER TABLE [dbo].[MOVIMIENTOS]  WITH CHECK ADD  CONSTRAINT [FK_MOVIMIENTOS_nro_cta] FOREIGN KEY([nro_cta])
REFERENCES [dbo].[CUENTA] ([nro_cta])
GO
ALTER TABLE [dbo].[MOVIMIENTOS] CHECK CONSTRAINT [FK_MOVIMIENTOS_nro_cta]
GO
ALTER TABLE [dbo].[MOVIMIENTOS]  WITH CHECK ADD  CONSTRAINT [FK_MOVIMIENTOS_nro_sucursal] FOREIGN KEY([nro_sucursal])
REFERENCES [dbo].[SUCURSAL] ([nro_sucursal])
GO
ALTER TABLE [dbo].[MOVIMIENTOS] CHECK CONSTRAINT [FK_MOVIMIENTOS_nro_sucursal]
GO
ALTER TABLE [dbo].[SUCURSAL]  WITH CHECK ADD  CONSTRAINT [FK_SUCURSAL_cod_banco] FOREIGN KEY([cod_banco])
REFERENCES [dbo].[BANCO] ([cod_banco])
GO
ALTER TABLE [dbo].[SUCURSAL] CHECK CONSTRAINT [FK_SUCURSAL_cod_banco]
GO
/****** Object:  StoredProcedure [dbo].[Consultar_Cuentas_Idcuentas]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Consultar_Cuentas_Idcuentas]
@nro_cta int
as
select c.*, b.nombre AS banco_nombre, s.ciudad AS ciudad_sucursal, cl.nombres AS nombres_cliente from CUENTA c
LEFT JOIN BANCO b ON b.cod_banco = c.cod_banco
LEFT JOIN CLIENTE cl ON cl.cod_cli = c.cod_cli
LEFT JOIN SUCURSAL s ON s.nro_sucursal = c.nro_sucursal
where nro_cta=@nro_cta
GO
/****** Object:  StoredProcedure [dbo].[CrearCuenta]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREAMOS EL PROCEDIMIENTO PARA CREAR UNA CUENTA
CREATE PROCEDURE [dbo].[CrearCuenta]
@nro_cta INT,
@nro_sucursal INT,
@cod_banco INT,
@cod_cli INT,
@saldo FLOAT,
@fechaapertura DATE,
@tipocta VARCHAR(50)
AS
BEGIN
    INSERT INTO CUENTA (nro_cta, nro_sucursal, cod_banco, cod_cli, saldo, fechaapertura, tipocta)
    VALUES (@nro_cta, @nro_sucursal, @cod_banco, @cod_cli, @saldo, @fechaapertura, @tipocta);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertarCliente]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarCliente]
(
    @dni INT,
    @apellidos VARCHAR(50),
    @nombres VARCHAR(50),
    @direccion VARCHAR(100),
    @ciudad VARCHAR(50),
    @email VARCHAR(100)
)
AS
BEGIN
    INSERT INTO CLIENTE (dni, apellidos, nombres, direccion, ciudad, email)
    VALUES (@dni, @apellidos, @nombres, @direccion, @ciudad, @email)
END
GO
/****** Object:  StoredProcedure [dbo].[Llenar_Banco]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Crear procedimiento almacenado para llenar el combox del formulario usando la tabla banco
CREATE PROCEDURE [dbo].[Llenar_Banco]
AS
BEGIN
    SELECT * FROM BANCO
END;
GO
/****** Object:  StoredProcedure [dbo].[Llenar_Cliente]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Crear procedimiento almacenado para llenar el combox del formulario usando la tabla cliente
CREATE PROCEDURE [dbo].[Llenar_Cliente]
AS
BEGIN
    SELECT * FROM CLIENTE
END;
GO
/****** Object:  StoredProcedure [dbo].[Llenar_Cuenta]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Crear procedimiento almacenado para llenar el combox del formulario usando la tabla cliente
CREATE PROCEDURE [dbo].[Llenar_Cuenta]
AS
BEGIN
    SELECT * FROM CUENTA
END;
GO
/****** Object:  StoredProcedure [dbo].[Llenar_Sucursal]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Llenar_Sucursal]
AS
BEGIN
    SELECT * FROM SUCURSAL
END;
GO
/****** Object:  StoredProcedure [dbo].[RealizarDeposito]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RealizarDeposito]
@nro_cta INT,
@importe FLOAT
AS
BEGIN
    UPDATE CUENTA
    SET saldo = saldo + @importe
    WHERE nro_cta = @nro_cta;
	
	insert into MOVIMIENTOS (cod_banco, importe, nro_cta,nro_sucursal, tipo_mov, fecha_mov)
	SELECT cod_banco, @importe, nro_cta,nro_sucursal, 'Deposito', Year(GETDATE()) FROM CUENTA c WHERE c.nro_cta = @nro_cta;
END
GO
/****** Object:  StoredProcedure [dbo].[RealizarRetiro]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RealizarRetiro]
@nro_cta INT,
@importe FLOAT
AS
BEGIN
    DECLARE @saldo FLOAT;
    SET @saldo = (SELECT saldo FROM CUENTA WHERE nro_cta = @nro_cta);

    IF @saldo >= @importe
    BEGIN
        UPDATE CUENTA
        SET saldo = saldo - @importe
        WHERE nro_cta = @nro_cta;

		insert into MOVIMIENTOS (cod_banco, importe, nro_cta,nro_sucursal, tipo_mov, fecha_mov)
	    SELECT cod_banco, @importe, nro_cta,nro_sucursal, 'Retiro', Year(GETDATE()) FROM CUENTA c WHERE c.nro_cta = @nro_cta;
    END
END
GO
/****** Object:  StoredProcedure [dbo].[ReporteFecha]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ReporteFecha]
@año int,
@año2 int
as
select * from Vista_MovimientosCliente where fecha_mov >= @año and fecha_mov <= @año2
GO
/****** Object:  StoredProcedure [dbo].[validar_usuario]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREAMOS EL PROCEDIMIENTOS VALIDAR USUARIO PARA EL FORMULARIO ACCESO(LOGIN)
CREATE PROCEDURE [dbo].[validar_usuario]
@cod_cli INT,
@dni INT
AS
BEGIN
    SELECT * FROM CLIENTE
    WHERE ((cod_cli = @cod_cli) AND (dni= @dni));
END;
GO
/****** Object:  StoredProcedure [dbo].[VConsultar_Cuenta_Sucursal]    Script Date: 28/09/2023 1:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[VConsultar_Cuenta_Sucursal]
@nro_cta int
as
select * from Vista_Cuenta_Sucursal where nro_cta=@nro_cta
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CUENTA"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SUCURSAL"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 206
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Cuenta_Sucursal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Cuenta_Sucursal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[10] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "C"
            Begin Extent = 
               Top = 44
               Left = 446
               Bottom = 241
               Right = 668
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "M"
            Begin Extent = 
               Top = 43
               Left = 137
               Bottom = 240
               Right = 359
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_CuentaMovimientos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_CuentaMovimientos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "MOVIMIENTOS"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "CUENTA"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 206
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "CLIENTE"
            Begin Extent = 
               Top = 9
               Left = 615
               Bottom = 206
               Right = 837
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_MovimientosCliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_MovimientosCliente'
GO
USE [master]
GO
ALTER DATABASE [MovimientosBanco] SET  READ_WRITE 
GO

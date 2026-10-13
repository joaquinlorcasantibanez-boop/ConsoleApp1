USE [master]
GO
/****** Objeto: Database [Tarea_aiep] Fecha de script: 13/10/2026 19:01:36 ******/
CREATE DATABASE [Tarea_aiep]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Tarea_aiep', FILENAME = N'D:\Nueva carpeta\MSSQL17.SQLEXPRESS\MSSQL\DATA\Tarea_aiep.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Tarea_aiep_log', FILENAME = N'D:\Nueva carpeta\MSSQL17.SQLEXPRESS\MSSQL\DATA\Tarea_aiep_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Tarea_aiep] SET COMPATIBILITY_LEVEL = 170
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Tarea_aiep].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Tarea_aiep] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Tarea_aiep] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Tarea_aiep] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Tarea_aiep] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Tarea_aiep] SET ARITHABORT OFF 
GO
ALTER DATABASE [Tarea_aiep] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Tarea_aiep] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Tarea_aiep] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Tarea_aiep] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Tarea_aiep] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Tarea_aiep] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Tarea_aiep] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Tarea_aiep] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Tarea_aiep] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Tarea_aiep] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Tarea_aiep] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Tarea_aiep] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Tarea_aiep] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Tarea_aiep] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Tarea_aiep] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Tarea_aiep] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Tarea_aiep] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Tarea_aiep] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Tarea_aiep] SET  MULTI_USER 
GO
ALTER DATABASE [Tarea_aiep] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Tarea_aiep] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Tarea_aiep] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Tarea_aiep] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Tarea_aiep] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Tarea_aiep] SET OPTIMIZED_LOCKING = OFF 
GO
ALTER DATABASE [Tarea_aiep] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Tarea_aiep] SET QUERY_STORE = ON
GO
ALTER DATABASE [Tarea_aiep] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Tarea_aiep]
GO
/****** Objeto: Table [dbo].[Casos] Fecha de script: 13/10/2026 19:01:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Casos](
	[IdCaso] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](5000) NOT NULL,
	[Estado] [bit] NOT NULL,
	[IdCliente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCaso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: View [dbo].[VW_Casos] Fecha de script: 13/10/2026 19:01:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_Casos]
AS
SELECT
    IdCaso,
    Descripcion,
    CASE
        WHEN Estado = 1 THEN 'En proceso'
        WHEN Estado = 0 THEN 'Finalizado'
    END AS Estado,
    IdCliente
FROM Casos;
GO
/****** Objeto: Table [dbo].[Clientes] Fecha de script: 13/10/2026 19:01:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Celular] [varchar](25) NOT NULL,
	[correo] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Celular] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[Historial_Modificaciones] Fecha de script: 13/10/2026 19:01:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historial_Modificaciones](
	[IdHistorial] [int] IDENTITY(1,1) NOT NULL,
	[IdCaso] [int] NOT NULL,
	[EstadoAnterior] [bit] NOT NULL,
	[EstadoNuevo] [bit] NOT NULL,
	[IdTrabajador] [int] NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Correo] [nvarchar](100) NOT NULL,
	[Celular] [varchar](20) NOT NULL,
	[Cargo] [nvarchar](50) NOT NULL,
	[FechaCambio] [datetime2](7) NULL,
	[TipoOperacion] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdHistorial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[Trabajadores] Fecha de script: 13/10/2026 19:01:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trabajadores](
	[IdTrabajador] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Correo] [varchar](75) NOT NULL,
	[Celular] [varchar](25) NOT NULL,
	[Contraseña] [varchar](100) NOT NULL,
	[Cargo] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTrabajador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Celular] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Contraseña] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Historial_Modificaciones] ADD  DEFAULT (sysdatetime()) FOR [FechaCambio]
GO
ALTER TABLE [dbo].[Casos]  WITH CHECK ADD  CONSTRAINT [FK_Casos_Clientes] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[Casos] CHECK CONSTRAINT [FK_Casos_Clientes]
GO
ALTER TABLE [dbo].[Casos]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Casos] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Casos] CHECK CONSTRAINT [FK_Ventas_Casos]
GO
/****** Objeto: StoredProcedure [dbo].[SP_ActualizarEstadoCaso] Fecha de script: 13/10/2026 19:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ActualizarEstadoCaso]
    @IdCaso INT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM Casos
        WHERE IdCaso = @IdCaso
    )
    BEGIN
        RAISERROR('El caso no existe.', 16, 1);
        RETURN;
    END

    UPDATE Casos
    SET Estado = CASE
                    WHEN Estado = 0 THEN 1
                    ELSE 0
                 END
    WHERE IdCaso = @IdCaso;

    SELECT
        IdCaso,
        Descripcion,
        Estado,
        IdCliente
    FROM Casos
    WHERE IdCaso = @IdCaso;
END;
GO
/****** Objeto: StoredProcedure [dbo].[sp_BuscarCasosPorEstado] Fecha de script: 13/10/2026 19:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_BuscarCasosPorEstado]
    @Estado INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @Estado NOT IN (0,1)
    BEGIN
        RAISERROR('El estado debe ser 0 o 1.', 16, 1);
        RETURN;
    END

    SELECT
        IdCaso,
        Descripcion,
        IdCliente
    FROM Casos
    WHERE Estado = @Estado;
END;
GO
/****** Objeto: StoredProcedure [dbo].[SP_BuscarTrabajadorPorId] Fecha de script: 13/10/2026 19:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BuscarTrabajadorPorId]
(
    @IdTrabajador INT
)
AS
BEGIN

    SELECT
        Nombre,
        Correo,
        Celular,
        Cargo
    FROM Trabajadores
    WHERE IdTrabajador = @IdTrabajador;

END;
GO
/****** Objeto: StoredProcedure [dbo].[sp_CasosPorEstado] Fecha de script: 13/10/2026 19:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CasosPorEstado]
    @Estado INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @Estado NOT IN (0,1)
    BEGIN
        RAISERROR('El estado debe ser 0 o 1.', 16, 1);
        RETURN;
    END

    SELECT
        IdCaso,
        Descripcion,
        IdCliente
    FROM Casos
    WHERE Estado = @Estado;
END;
GO
/****** Objeto: StoredProcedure [dbo].[SP_EliminarCaso] Fecha de script: 13/10/2026 19:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EliminarCaso]
(
    @IdCaso INT
)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM Casos
        WHERE IdCaso = @IdCaso
    )
    BEGIN
        RAISERROR('El caso no existe.',16,1);
        RETURN;
    END

    DELETE FROM Casos
    WHERE IdCaso = @IdCaso;

    PRINT 'Caso eliminado correctamente.';
END;
GO
/****** Objeto: StoredProcedure [dbo].[SP_EliminarClienteYCasos] Fecha de script: 13/10/2026 19:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EliminarClienteYCasos]
(
    @IdCliente INT
)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM Clientes
        WHERE IdCliente = @IdCliente
    )
    BEGIN
        RAISERROR('El cliente no existe.',16,1);
        RETURN;
    END

    DELETE FROM Clientes
    WHERE IdCliente = @IdCliente;

    PRINT 'Cliente y casos eliminados correctamente.';
END;
GO
/****** Objeto: StoredProcedure [dbo].[SP_InsertarCaso] Fecha de script: 13/10/2026 19:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertarCaso]
(
    @Descripcion VARCHAR(5000),
    @Estado BIT,
    @IdCliente INT
)
AS
BEGIN

    INSERT INTO Casos
    (
        Descripcion,
        Estado,
        IdCliente
    )
    VALUES
    (
        @Descripcion,
        @Estado,
        @IdCliente
    );

END;
GO
/****** Objeto: StoredProcedure [dbo].[SP_InsertarCliente] Fecha de script: 13/10/2026 19:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertarCliente]
(
    @Nombre VARCHAR(50),
    @Celular VARCHAR(25),
    @Correo VARCHAR(50)
)
AS
BEGIN

    IF EXISTS (SELECT 1 FROM Clientes WHERE Celular = @Celular)
    BEGIN
        RAISERROR('El celular ya existe',16,1);
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM Clientes WHERE Correo = @Correo)
    BEGIN
        RAISERROR('El correo ya existe',16,1);
        RETURN;
    END

    INSERT INTO Clientes
    (
        Nombre,
        Celular,
        Correo
    )
    VALUES
    (
        @Nombre,
        @Celular,
        @Correo
    );

    SELECT SCOPE_IDENTITY() AS IdCliente;
END;
GO
/****** Objeto: StoredProcedure [dbo].[SP_InsertarTrabajador] Fecha de script: 13/10/2026 19:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_InsertarTrabajador]
(
    @Nombre VARCHAR(100),
    @Correo VARCHAR(100),
    @Celular VARCHAR(25),
    @Contrasena VARCHAR(100),
    @Cargo VARCHAR(50)
)
AS
BEGIN

    IF EXISTS (SELECT 1 FROM Trabajadores WHERE Correo = @Correo)
    BEGIN
        PRINT 'El correo ya existe';
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM Trabajadores WHERE Celular = @Celular)
    BEGIN
        PRINT 'El celular ya existe';
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM Trabajadores WHERE Contraseña = @Contrasena)
    BEGIN
        PRINT 'La contraseña ya existe';
        RETURN;
    END

    INSERT INTO Trabajadores
    (
        Nombre,
        Correo,
        Celular,
        Contraseña,
        Cargo
    )
    VALUES
    (
        @Nombre,
        @Correo,
        @Celular,
        @Contrasena,
        @Cargo
    );

    PRINT 'Trabajador registrado correctamente';

END
GO
/****** Objeto: StoredProcedure [dbo].[SP_MostrarCasos] Fecha de script: 13/10/2026 19:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MostrarCasos]
AS
BEGIN
    SELECT *
    FROM VW_Casos;
END;
GO
/****** Objeto: StoredProcedure [dbo].[sp_Validacion_datos] Fecha de script: 13/10/2026 19:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Validacion_datos]
(
    @Correo VARCHAR(75),
    @Contrasena VARCHAR(100)
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        IdTrabajador,
        Nombre,
        Cargo
    FROM Trabajadores
    WHERE Correo = @Correo
    AND Contraseña = @Contrasena;
END
GO
/****** Objeto: StoredProcedure [dbo].[SP_VerHistorialModificaciones] Fecha de script: 13/10/2026 19:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_VerHistorialModificaciones]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        IdHistorial,
        IdCaso,
        TipoOperacion,
        EstadoAnterior,
        EstadoNuevo,
        IdTrabajador,
        Nombre,
        Correo,
        Celular,
        Cargo,
        FechaCambio
    FROM Historial_Modificaciones
    ORDER BY FechaCambio DESC;
END;
GO
/****** Objeto: StoredProcedure [dbo].[SP_VerTriggerDelete] Fecha de script: 13/10/2026 19:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_VerTriggerDelete]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        IdHistorial,
        IdCaso,
        EstadoAnterior,
        EstadoNuevo,
        IdTrabajador,
        Nombre,
        Cargo,
        FechaCambio
    FROM Historial_Modificaciones
    WHERE TipoOperacion = 'DELETE'
    ORDER BY FechaCambio DESC;
END;
GO
/****** Objeto: StoredProcedure [dbo].[SP_VerTriggerInsert] Fecha de script: 13/10/2026 19:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_VerTriggerInsert]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        IdHistorial,
        IdCaso,
        EstadoAnterior,
        EstadoNuevo,
        IdTrabajador,
        Nombre,
        Cargo,
        FechaCambio
    FROM Historial_Modificaciones
    WHERE TipoOperacion = 'INSERT'
    ORDER BY FechaCambio DESC;
END;
GO
/****** Objeto: StoredProcedure [dbo].[SP_VerTriggerUpdate] Fecha de script: 13/10/2026 19:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_VerTriggerUpdate]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        IdHistorial,
        IdCaso,
        EstadoAnterior,
        EstadoNuevo,
        IdTrabajador,
        Nombre,
        Cargo,
        FechaCambio
    FROM Historial_Modificaciones
    WHERE TipoOperacion = 'UPDATE'
    ORDER BY FechaCambio DESC;
END;
GO
USE [master]
GO
ALTER DATABASE [Tarea_aiep] SET  READ_WRITE 
GO

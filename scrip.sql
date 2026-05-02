-- =========================
-- BASE DE DATOS
-- =========================
CREATE DATABASE GymDB;
GO

USE GymDB;
GO
-- =========================
-- PERSONAS (BASE)
-- =========================
CREATE TABLE Personas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    Apellido NVARCHAR(100),
    Documento NVARCHAR(50),
    Telefono NVARCHAR(50),
    Correo NVARCHAR(100),
    Direccion NVARCHAR(150),
    FechaNacimiento DATE
);

USE GymDB;
GO
-- =========================
-- SEDES
-- =========================
CREATE TABLE Sedes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    Ciudad NVARCHAR(100),
    Direccion NVARCHAR(150),
    CapacidadMaxima INT,
    Telefono NVARCHAR(50)
);
USE GymDB;
GO
-- =========================
-- HORARIOS 
-- =========================
CREATE TABLE Horarios (
    Id INT PRIMARY KEY IDENTITY(1,1),
    DiaSemana INT,
    HoraInicio TIME,
    HoraFin TIME,
    TipoActividad NVARCHAR(100),
    Turno BIT
);

USE GymDB;
GO
-- =========================
-- TIPOS DE MEMBRESIAS
-- =========================
CREATE TABLE TiposMembresias (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    Precio DECIMAL(10,2),
    Descripcion NVARCHAR(255)
);
USE GymDB;
GO
-- =========================
--  TIPOS DE PAGOS
-- =========================
CREATE TABLE TiposPagos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    DigitalEfectivo BIT,
    TieneComision BIT,
    Disponible BIT
);

USE GymDB;
GO
-- =========================
-- ROLES
-- =========================
CREATE TABLE Roles (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    Descripcion NVARCHAR(255)
);

USE GymDB;
GO
-- =========================
-- PRODUCTOS
-- =========================
CREATE TABLE Productos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    PrecioUnidad DECIMAL(10,2),
    Categoria NVARCHAR(100),
    Disponible BIT
);

USE GymDB;
GO
-- =========================
-- SUBTIPOS DE MEMBRESIAS
-- =========================
CREATE TABLE SubtiposMembresias (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100)
);


USE GymDB;
GO
-- =========================
-- INVENTARIOS
-- =========================
CREATE TABLE Inventarios (
    Id INT PRIMARY KEY IDENTITY(1,1),
    StockActual INT,
    FechActulizacion DATETIME,
    Producto INT,

    FOREIGN KEY (Producto) REFERENCES Productos(Id)
);

USE GymDB;
GO
-- =========================
-- REPORTES
-- =========================
CREATE TABLE Reportes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Mensaje NVARCHAR(255),
    FechaReporte DATETIME,
    Estado BIT,
    Persona INT,

    FOREIGN KEY (Persona) REFERENCES Personas(Id)
);


USE GymDB;
GO
-- =========================
-- EQUIPOS
-- =========================
CREATE TABLE Equipos (
    Id INT PRIMARY KEY IDENTITY,
    Estado BIT,
    Nombre NVARCHAR(100),
    Marca NVARCHAR(100),
    FechaCompra DATETIME,
    VidaUtil INT,
    Sede INT,

    FOREIGN KEY (Sede) REFERENCES Sedes(Id)
);

USE GymDB;
GO
-- =========================
-- MANTENIMIENTOS DE EQUIPOS
-- =========================
CREATE TABLE MantenimientosEquipos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FechaMantenimiento DATETIME,
    Descripcion NVARCHAR(255),
    Costo DECIMAL(10,2),
    Equipo INT,

    FOREIGN KEY (Equipo) REFERENCES Equipos(Id)
);

USE GymDB;
GO
-- =========================
-- SALONES DE SEDES
-- =========================
CREATE TABLE SalonesSedes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    Capacidad INT,
    TipoSalon NVARCHAR(100),
    Piso INT,
    Estado BIT,
    Sede INT,

    FOREIGN KEY (Sede) REFERENCES Sedes(Id)
);

USE GymDB;
GO
-- =========================
-- ADMINISTRATIVOS
-- =========================
CREATE TABLE Administrativos(
 Id INT PRIMARY KEY IDENTITY(1,1),
 FechaInicio DATETIME,
 FechaSalida DATETIME,
 Salario DECIMAL,
 Cargo NVARCHAR(50),
 Estado BIT,
 Persona INT,
 Sede INT

 FOREIGN KEY (Persona) REFERENCES Personas(Id),
 FOREIGN KEY (Sede) REFERENCES Sedes(Id)
);

USE GymDB;
GO
-- =========================
-- CLIENTES (HEREDA DE PERSONAS)
-- =========================
CREATE TABLE Clientes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FechaRegistro DATETIME,
    Activo BIT,
    Persona INT 
    FOREIGN KEY (Persona) REFERENCES Personas(Id)
);

USE GymDB;
GO
-- =========================
-- ENTRENADORES
-- =========================
CREATE TABLE Entrenadores (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Certificacion BIT,
    FechaIngreso DATETIME,
    AñosExperiencia INT,
    Salario DECIMAL(10,2),
    Activo BIT,
    Persona INT,

    FOREIGN KEY (Persona) REFERENCES Personas(Id)
);

USE GymDB;
GO
-- =========================
-- COMPRAS
-- =========================
CREATE TABLE Compras (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FechaCompra DATETIME,
    Total DECIMAL(10,2),
    Cliente INT,

    FOREIGN KEY (Cliente) REFERENCES Clientes(Id)
);


USE GymDB;
GO
-- =========================
-- RUTINAS
-- =========================
CREATE TABLE Rutinas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    Objetivo NVARCHAR(255),
    FechaAsignacion DATETIME,
    Estado BIT,
    Cliente INT,

    FOREIGN KEY (Cliente) REFERENCES Clientes(Id)
);

USE GymDB;
GO
-- =========================
-- EVALUACIONES FISICAS
-- =========================
CREATE TABLE EvaluacionesFisicas (
    Id INT PRIMARY KEY IDENTITY,
    GrasaCorporal DECIMAL(5,2),
    FechaEvaluacion DATETIME,
    Peso DECIMAL(5,2),
    Observaciones NVARCHAR(255),
    Cliente INT,

    FOREIGN KEY (Cliente) REFERENCES Clientes(Id)
);

USE GymDB;
GO
-- =========================
-- Clases Grupales
-- =========================
CREATE TABLE ClasesGrupales(
Id INT PRIMARY KEY IDENTITY(1,1),
Nombre NVARCHAR(100),
CupoMaximo INT,
Estado BIT,
RequiereReserva BIT,
DuracionMinutos INT,
Entrenador INT,
Horario INT,
Salon INT,

FOREIGN KEY (Entrenador) REFERENCES Entrenadores(Id),
FOREIGN KEY (Horario) REFERENCES Horarios(Id),
FOREIGN KEY (Salon) REFERENCES SalonesSedes(Id)
);


USE GymDB;
GO
-- =========================
-- RESERVAS
-- =========================
CREATE TABLE Reservas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FechaReserva DATETIME,
    Estado BIT,
    Cliente INT,
    Clase INT,

    FOREIGN KEY (Cliente) REFERENCES Clientes(Id),
    FOREIGN KEY (Clase) REFERENCES ClasesGrupales(Id)
);

USE GymDB;
GO

-- =========================
-- COMPRAS DE PRODUCTOS
-- =========================
CREATE TABLE ComprasProductos (
    IdCompraProducto INT PRIMARY KEY IDENTITY,
    SubTotal DECIMAL(10,2),
    Cantidad INT,
    Compra INT,
    Producto INT,

    FOREIGN KEY (Compra) REFERENCES Compras(Id),
    FOREIGN KEY (Producto) REFERENCES Productos(Id)
);

USE GymDB;
GO
-- =========================
-- CONTROL DE ACCESOS
-- =========================
CREATE TABLE ControlAccesos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FechaEntrada DATETIME,
    FechaSalida DATETIME,
    Persona INT,
    Sede INT,

    FOREIGN KEY (Persona) REFERENCES Personas(Id),
    FOREIGN KEY (Sede) REFERENCES Sedes(Id)
);

USE GymDB;
GO
-- =========================
-- USUARIOS
-- =========================
CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FechaCreacion DATETIME,
    UserName NVARCHAR(100),
    Contraseña NVARCHAR(100),
    Estado BIT,
    Rol INT,
    Persona INT UNIQUE,

    FOREIGN KEY (Rol) REFERENCES Roles(Id),
    FOREIGN KEY (Persona) REFERENCES Personas(Id)
);

USE GymDB;
GO
-- =========================
-- NOTIFICACIONES
-- =========================
CREATE TABLE Notificaciones (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Mensaje NVARCHAR(255),
    FechaEnvio DATETIME,
    Leida BIT,
    Usuario INT,

    FOREIGN KEY (Usuario) REFERENCES Usuarios(Id)
);

USE GymDB;
GO
-- =========================
-- MEMBRESIAS
-- =========================
CREATE TABLE Membresias (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FechaInicio DATETIME,
    Estado BIT,
    DuracionMeses INT,
    TipoMembresia INT,
    Subtipo INT,
    Cliente INT,

    FOREIGN KEY (TipoMembresia) REFERENCES TiposMembresias(Id),
    FOREIGN KEY (Subtipo) REFERENCES SubtiposMembresias(Id),
    FOREIGN KEY (Cliente) REFERENCES Clientes(Id)
);


USE GymDB;
GO
-- =========================
-- PAGOS
-- =========================
CREATE TABLE Pagos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Valor DECIMAL(10,2),
    FechaPago DATETIME,
    Aprobado BIT,
    Observaciones NVARCHAR(255),
    Membresia INT NULL,
    TipoPago INT,
    Compra INT NULL,

    FOREIGN KEY (Membresia) REFERENCES Membresias(Id),
    FOREIGN KEY (TipoPago) REFERENCES TiposPagos(Id),
    FOREIGN KEY (Compra) REFERENCES Compras(Id)
);

USE GymDB;
GO
-- =========================
-- TIPOS SUBTIPOS
-- =========================
-- TABLA PUENTE (BIEN HECHA)
CREATE TABLE TiposSubtipos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Tipo INT,
    Subtipo INT,
    Descuento DECIMAL(5,2),

    FOREIGN KEY (Tipo) REFERENCES TiposMembresias(Id),
    FOREIGN KEY (Subtipo) REFERENCES SubtiposMembresias(Id)
);


USE GymDB;
GO
-- =========================
-- TIPOS SUBTIPOS
-- =========================
CREATE TABLE Facturas (
    Id INT PRIMARY KEY IDENTITY,
    CodigoFactura VARCHAR(100),
    FechaEmision DATETIME,
    Subtotal DECIMAL(10,2),
    Impuestos DECIMAL(10,2),
    Total DECIMAL(10,2),
    Pago INT,

    FOREIGN KEY (Pago) REFERENCES Pagos(Id)
);

USE GymDB
GO
--INSERT TABLA PESONAS
INSERT INTO Personas (Nombre, Apellido, Documento, Telefono, Correo, Direccion, FechaNacimiento)
VALUES 
('Juan', 'Perez', '1001', '300111', 'juan@mail.com', 'Calle 1', '1990-01-01'),
('Ana', 'Lopez', '1002', '300222', 'ana@mail.com', 'Calle 2', '1992-02-02'),
('Carlos', 'Ramirez', '1003', '300333', 'carlos@mail.com', 'Calle 3', '1988-03-03'),
('Laura', 'Gomez', '1004', '300444', 'laura@mail.com', 'Calle 4', '1995-04-04'),
('Pedro', 'Torres', '1005', '300555', 'pedro@mail.com', 'Calle 5', '1991-05-05');


--INSERT TABLA SEDES
USE GymDB
GO
INSERT INTO Sedes (Nombre, Ciudad, Direccion, CapacidadMaxima, Telefono)
VALUES
('ROBLEDO', 'Medellin', 'Av 1', 2, '604111'),
('ARANJUEZ', 'Medellin', 'Av 2', 100, '604222'),
('BOSTON', 'Medellin', 'Av 3', 220, '604333'),
('PRADO', 'Medellin', 'Av 4', 170, '604444'),
('CASTILLA', 'Medellin', 'Av 5', 60, '604555');


--INSERT DE ADMINISTRATIVOS
USE GymDB
GO
INSERT INTO Administrativos (FechaInicio, FechaSalida, Salario, Cargo, Estado, Persona,Sede)
VALUES 
(GETDATE(), GETDATE(), 1800000, 'Gerente', 1, 1,1);



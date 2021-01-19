--Crear la base de datos
CREATE DATABASE db_sistema
GO

USE db_sistema
GO

--Crear Tablas de la BD

--Crear Tabla Categoria
if (not exists(select 1 from SYS.tables where name = 'Categoria'))
	CREATE TABLE dbo.Categoria(
		categoria_id int identity(1,1) PRIMARY KEY,
		nombre char(250) NOT NULL,		
		descripcion text NULL,
		estado char(1) NULL
)
GO

--Crear Tabla Documento
if (not exists(select 1 from SYS.tables where name = 'Documento'))
	CREATE TABLE dbo.Documento(
		documento_id int identity(1,1) PRIMARY KEY,
		categoria_id int NOT NULL,
		nombre varchar(255) NOT NULL,		
		extension varchar(4) NULL,
		tamanio numeric(10,2) NULL,
		descripcion text NULL,
		estado char(1) NULL
		FOREIGN KEY (documento_id) REFERENCES Categoria
)
GO


--Crear Tabla Persona
if (not exists(select 1 from SYS.tables where name = 'Persona'))
	CREATE TABLE dbo.Persona(
		persona_id int identity(1,1) PRIMARY KEY,
		dni char(8) UNIQUE NOT NULL,
		nombre varchar(150) NOT NULL,
		apellido varchar(250) NOT NULL,
		sexo char(1) NOT NULL,
		email varchar(250) UNIQUE NOT NULL,
		celular char(9)	UNIQUE NOT NULL,
		direccion text NULL,
		fechanacimiento date NULL
)
GO

--Crear Tabla Usario
if (not exists(select 1 from SYS.tables where name = 'Usuario'))
	CREATE TABLE dbo.Usuario(
		usuario_id int identity(1,1),
		persona_id int,
		usuario varchar(50) UNIQUE NOT NULL,
		clave varchar(100) NOT NULL,
		nivel varchar(30) NOT NULL,
		estado char(1) NOT NULL
		PRIMARY KEY (usuario_id),
		FOREIGN KEY (persona_id) REFERENCES Persona
)
GO

if (not exists(select 1 from SYS.tables where name = 'Producto'))
	CREATE TABLE dbo.Producto(
		producto_id int identity(1,1),
		proveedor_id int,
		descripcion varchar(50) UNIQUE NOT NULL,
		precio varchar(100) NOT NULL,
		nivel varchar(30) NOT NULL,
		estado char(1) NOT NULL
		PRIMARY KEY (producto_id),
		FOREIGN KEY (proveedor_id) REFERENCES Proveedor
)
GO

if (not exists(select 1 from SYS.tables where name = 'Proveedor'))
	CREATE TABLE dbo.Proveedo(
		proveedor_id int identity(1,1) PRIMARY KEY,
		telefono varchar(50) UNIQUE NOT NULL,
		nombre varchar(100) NOT NULL,
		direccion varchar(30) NOT NULL
)
GO
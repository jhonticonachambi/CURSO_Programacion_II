
-- ING SOLO CORRA EL FRMDOCUMENTOS DE  LOS FORMULARIOS
CREATE DATABASE db_sistema
GO

USE db_sistema
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
		celular char(9) NULL,
		direccion text NULL,
		fechanacimiento date NULL,
		foto varchar(250) NULL
)
GO

--Crear Tabla Documento
if (not exists(select 1 from SYS.tables where name = 'Documento'))
	CREATE TABLE dbo.Documento(
		documento_id int identity(1,1) PRIMARY KEY,
		categoria_id varchar(255) NOT NULL,
		nombre varchar(255) NOT NULL,		
		extension varchar(4) NULL,
		tamanio numeric(10,2) NULL,
		descripcion text NULL,
		estado char(1) NULL
)
GO
--Crear Tabla Usuario
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


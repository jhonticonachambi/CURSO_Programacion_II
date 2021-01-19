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
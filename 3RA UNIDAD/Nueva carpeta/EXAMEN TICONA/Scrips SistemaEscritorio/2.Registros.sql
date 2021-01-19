--Manipulacion de registros 

insert into dbo.Persona(Dni,nombre,apellido,sexo,email,celular,direccion,Fecha_Nacimiento)	

values ('12345678','Enrique','Lanchipa Valencia','M','elanchipa@upt.pe','987654321','Av. SanMartin 1857','1995/04/074')
GO
insert into dbo.Persona(Dni,nombre,apellido,sexo,email,celular,direccion,Fecha_Nacimiento)	

values ('22345678','Carlos','Maldonado Cancapi','M','cmaldonado@virtual.upt.pe','923654321','Av. Bolognessi 1857','2000/03/27')
GO

insert into dbo.Persona(Dni,nombre,apellido,sexo,email,celular)
values ('75895442','Gloria','Hidalgo Flores','F','gflores125@hotmail.com','923554825')
insert into dbo.Persona

values ('22341678','Maria','Mendoza Guitierrez','F','mmendoza1@gmail.com','923688571','Av. Bolognessi 258','1995/11/12')
GO
-- Actualizar campos
update dbo.Persona
       set nombre = 'Julia Ines',
	   apellido = 'Castro Flores'
where Dni=22341678 

--Eliminar un registro

delete from dbo.Persona 
where persona_id  = 5


select * from dbo.Persona

--insertanto valores a tabla usuario

insert into dbo.Usuario values	(2,'elanchipa','123456','Administrador','A')
insert into dbo.Usuario (persona_id,nombreUsuario,clave,nivel,estado)	values	(2,'cmaldonado','1234','Supervisor','A')
insert into dbo.Usuario (persona_id,nombreUsuario,clave,nivel,estado)	values	(3,'ghidalgo','1234','Usuario','A')
insert into dbo.Usuario (persona_id,nombreUsuario,clave,nivel,estado)	values	(9,'mgutierrez','1234','Usuario','I')

select * from dbo.Usuario
Create view  V_Persona 
   As select * from dbo.Persona
go	

create view V_Usuario
    As select persona_id,nombreusuario,nivel,estado from dbo.Usuario
go

create view V_UsuarioPersona
    As select u.persona_id,p.apellido,p.nombre,u.nombreUsuario,u.nivel,u.estado from dbo.Usuario as u
	Inner join dbo.Persona as p
	on u.persona_id = p.persona_id

go
-- Ejecutando vistas 

select * from V_Persona
select * from V_Usuario
select * from V_UsuarioPersona
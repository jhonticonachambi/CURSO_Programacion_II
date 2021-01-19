--RELAIZAR ACCIONES CON LOS PROCEDIMIENTOS ALAMACENADOS 


--insertar
EXEC USP_Persona_I 2,'75214521','Enrique','Valencia', 'M' , 'elanchipa@upt.pe','923554215'
GO
EXEC USP_Persona_I 2,'00421892','CarlosPrueba','Maldonado', 'carmaldonado@upt.pe' , '923551245'
GO
EXEC USP_Persona_I 2,'00586214','UPT','epis', 'Supervisor' , 'epis@upt.pe', '987550216'
GO

--Actualizar
EXEC USP_Persona_U 3,2 ,'73762630','Carlos', 'Maldonado Cancapi','carmaldonado4445@gmail.com','923550243'
Go

--Eliminar
EXEC USP_Persona_E 6

--Listar
EXEC USP_Persona_S
GO

--Buscar	
Exec USP_Persona_S_Buscar	'Enrique'--por nombre
go
Exec USP_Persona_S_Buscar	'Lanchipa Valencia'--POr Apellido
Go
Exec USP_Persona_S_Buscar	'75895442'--Por Dni
go



--Verificar

EXEC USP_Persona_Verificar 'Enrique', 1

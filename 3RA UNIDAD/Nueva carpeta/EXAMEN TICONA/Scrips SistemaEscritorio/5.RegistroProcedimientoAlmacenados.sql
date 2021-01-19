--RELAIZAR ACCIONES CON LOS PROCEDIMIENTOS ALAMACENADOS 


--insertar
EXEC USP_Usario_I 2,'PruebaEpis','789', 'Usuario' , 'A'
GO
EXEC USP_Usario_I 2,'PruebitaEpis','456789', 'Supervisor' , 'I'
GO
EXEC USP_Usario_I 2,'UPT','epis', 'Supervisor' , 'I'
GO

--Actualizar
EXEC USP_Usario_U 12,2 ,'Administrador', 'Sistemas.123','Administrador','I'
Go

--Eliminar
EXEC USP_Usario_E 6

--Listar
EXEC USP_Usario_S
GO

--Buscar	
Exec USP_Usario_S_Buscar	'Administrador'--POr nivel
go
Exec USP_Usario_S_Buscar	'Lanchipa'--POr Apellido
Go
Exec USP_Usario_S_Buscar	'upt'--Por usuario
go

--Activar 
EXEC USP_Usuario_Activar	13 --por nivel
GO
--DesActivar 
EXEC USP_Usuario_DesActivar	2 --por nivel
GO

--Verificar

EXEC USP_Usuario_Verificar 'elanchipa', 1

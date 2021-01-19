-- procedimientos almacenados 


--PROCEDIMIENTO ALMACENADO DE INSERTAR EN LA TABAL USUARIO
create procedure USP_Usario_I

  @ppersona_id int,
  @pusuario varchar(50),
  @pclave varchar(100),
  @pnivel varchar(30),
  @pestado char(1)

As 
BEGIN 
   BEGIN TRAN 
       BEGIN TRY  
         INSERT INTO dbo.Usuario
         VALUES(@ppersona_id,@pusuario,@pclave,@pnivel,@pestado)
   COMMIT 
       END TRY
       BEGIN CATCH
	       ROLLBACK
	   END CATCH
   END
go

--PROCEDIMIENTO ALMACENAD PARA ACTUALIZAR
create procedure USP_Usario_U

  @pusaurio_id int ,
  @ppersona_id int,
  @pusuario varchar(50),
  @pclave varchar(100),
  @pnivel varchar(30),
  @pestado char(1)

As 
BEGIN 
   BEGIN TRAN 
       BEGIN TRY  
         UPDATE  dbo.Usuario SET

			 persona_id =@ppersona_id,
			 nombreUsuario = @pusuario,
			 clave = @pclave,
			 nivel = @pnivel,
			 estado= @pestado
				
		WHERE usuario_id = @pusaurio_id
   COMMIT 
       END TRY
       BEGIN CATCH
	       ROLLBACK
	   END CATCH
   END
go

--Procedimiento almacenado para eliminar

create procedure USP_Usario_E

  @pusaurio_id int 

As 
BEGIN 
   BEGIN TRAN 
       BEGIN TRY  
         DELETE  dbo.Usuario 				
		 WHERE usuario_id = @pusaurio_id
   COMMIT 
       END TRY
       BEGIN CATCH
	       ROLLBACK
	   END CATCH
   END
go

--Procedimiento almacenado de Listar en la tabla usuario

create procedure USP_Usario_S
As 
BEGIN 
	SELECT * FROM Usuario
END
go

--PROCEDIMIENTO ALMACENAD DE BUSCAR EN LA TABLA USUARIO
create procedure USP_Usario_S_Buscar

  @pbusqueda varchar(150)


As 
BEGIN 
	select u.persona_id,p.apellido,p.nombre,u.nombreUsuario,u.nivel,u.estado from dbo.Usuario as u
	Inner join dbo.Persona as p
	on u.persona_id = p.persona_id
	WHERE nombreUsuario like '%' + @pbusqueda + '%'
	OR 
	p.apellido LIKE '%' + @pbusqueda + '%'
	OR
	nivel  = @pbusqueda
END
go


--PROCEDIMIENTO ALMACENAD DE ACTIVAR USUARIO

CREATE PROCEDURE USP_Usuario_Activar
	@pusuario_id int 
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY 
		UPDATE dbo.Usuario SET
			estado = 'A'
			WHERE usuario_id = @pusuario_id
	COMMIT 
       END TRY
       BEGIN CATCH
	       ROLLBACK
	   END CATCH
   END
go

--PROCEDIMIENTO ALMACENAD DE DESACTIVAR USUARIO

CREATE PROCEDURE USP_Usuario_DesActivar
	@pusuario_id int 
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY 
		UPDATE dbo.Usuario SET
			estado = 'I'
			WHERE usuario_id = @pusuario_id
	COMMIT 
       END TRY
       BEGIN CATCH
	       ROLLBACK
	   END CATCH
   END
go

--PROCEDIMIENTO ALMACENAD DE VERIFICAR USUARIO

CREATE PROCEDURE USP_Usuario_Verificar
	@pvalor varchar(100),
	@existe bit output

AS
BEGIN
	BEGIN TRAN
		BEGIN TRY 
		IF EXISTS (SELECT nombreusuario FROM  Usuario WHERE nombreUsuario = LTRIM(RTRIM(@pvalor)))
			BEGIN
				SET @existe = 1
			END 
		ELSE 
		BEGIN
				SET @existe = 0
			END
	COMMIT 
       END TRY
       BEGIN CATCH
	       ROLLBACK
	   END CATCH
   END
go


-- procedimientos almacenados 


--PROCEDIMIENTO ALMACENADO DE INSERTAR EN LA TABLA PERSONA
create procedure USP_Persona_I

  @pusuario_id int,
  @ppersona_id int,
  @pDni varchar(8),
  @pnombre varchar(100),
  @papellido varchar(250),
  @psexo char(1),
  @pemail varchar(250),
  @pcelular char(9)
  
As 
BEGIN 
   BEGIN TRAN 
       BEGIN TRY  
         INSERT INTO dbo.Persona
         VALUES(@pusuario_id,@ppersona_id,@pDni,@pnombre,@papellido,@psexo,@pemail,@pcelular)
   COMMIT 
       END TRY
       BEGIN CATCH
	       ROLLBACK
	   END CATCH
   END
go

--PROCEDIMIENTO ALMACENAD PARA ACTUALIZAR
create procedure USP_Persona_U

  
  @ppersona_id int,
  @pDni varchar(8),
  @pnombre varchar(100),
  @papellido varchar(250),
  @psexo char(1),
  @pemail varchar(250),
  @pcelular char(9)

As 
BEGIN 
   BEGIN TRAN 
       BEGIN TRY  
         UPDATE  dbo.Persona SET

			 Dni= @pDni,
			 nombre = @pnombre,
			 apellido = @papellido,
			 sexo = @psexo,
			 email = @pemail,
			 celular = @pcelular
					
		WHERE persona_id = @ppersona_id
   COMMIT 
       END TRY
       BEGIN CATCH
	       ROLLBACK
	   END CATCH
   END
go

--Procedimiento almacenado para eliminar

create procedure USP_Persona_E

  @ppersona_id int 

As 
BEGIN 
   BEGIN TRAN 
       BEGIN TRY  
         DELETE  dbo.Persona				
		 WHERE persona_id = @ppersona_id
   COMMIT 
       END TRY
       BEGIN CATCH
	       ROLLBACK
	   END CATCH
   END
go

--Procedimiento almacenado de Listar en la tabla usuario

create procedure USP_Persona_S
As 
BEGIN 
	SELECT * FROM Persona
END
go

--PROCEDIMIENTO ALMACENAD DE BUSCAR EN LA TABLA USUARIO
create procedure USP_Persona_S_Buscar

  @pbusqueda varchar(150)


As 
BEGIN 
	select u.persona_id,p.apellido,p.nombre,u.nombreUsuario,u.nivel,u.estado, p.Dni,p.celular from dbo.Usuario as u
	Inner join dbo.Persona as p
	on u.persona_id = p.persona_id
	WHERE nombreUsuario like '%' + @pbusqueda + '%'
	OR 
	p.apellido LIKE '%' + @pbusqueda + '%'
	OR
	nivel  = @pbusqueda
END
go



--PROCEDIMIENTO ALMACENAD DE VERIFICAR USUARIO

CREATE PROCEDURE USP_Persona_Verificar
	@pvalor varchar(100),
	@existe bit output

AS
BEGIN
	BEGIN TRAN
		BEGIN TRY 
		IF EXISTS (SELECT nombre FROM  Persona WHERE nombre = LTRIM(RTRIM(@pvalor)))
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


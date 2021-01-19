-- Procedimientos Almacenados

-- PROCEDIMIENTO ALMACENADO DE INSERTAR EN LA TABLA CATEGORIA
CREATE PROCEDURE USP_Persona_U 
  @pnombre varchar(250),
  @pdescripcion text,  
  @pestado char(1)
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			VALUES(@pnombre, @pdescripcion, @pestado)
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO

-- PROCEDIMIENTO ALMACENADO DE ACTUALIZAR EN LA TABLA CATEGORIA
CREATE PROCEDURE USP_Categoria_U
  @pcategoria_id int,
  @pnombre varchar(250),
  @pdescripcion text,  
  @pestado char(1)
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
		UPDATE dbo.Categoria SET					
			nombre = @pnombre, 
			descripcion = @pdescripcion,			
			estado = @pestado
		WHERE categoria_id = @pcategoria_id
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO


-- PROCEDIMIENTO ALMACENADO DE ELIMINAR EN LA TABLA CATEGORIA
CREATE PROCEDURE USP_Categoria_D
  @pcategoria_id int  
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			DELETE dbo.Categoria 
			WHERE categoria_id = @pcategoria_id
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO

-- PROCEDIMIENTO ALMACENADO DE LISTAR EN LA TABLA USUARIO
CREATE PROCEDURE USP_Categoria_S
  
AS
BEGIN	
	SELECT * FROM Categoria	
END
GO

-- PROCEDIMIENTO ALMACENADO DE BUSCAR EN LA TABLA CATEGORIA
CREATE PROCEDURE USP_Categoria_S_Buscar
  @pbusqueda varchar(150)
AS
BEGIN	
	SELECT categoria_id, nombre, descripcion, estado 
	FROM dbo.Categoria
	WHERE 
	nombre LIKE '%' + @pbusqueda + '%'
	OR
	descripcion LIKE '%' + @pbusqueda + '%'
	OR
	estado = @pbusqueda
END
GO

-- PROCEDIMIENTO ALMACENADO DE ACTIVAR CATEGORIA
CREATE PROCEDURE USP_Categoria_Activar
  @pcategoria_id int  
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
		UPDATE dbo.Categoria SET					 
			estado = 'A'
		WHERE categoria_id = @pcategoria_id
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO

-- PROCEDIMIENTO ALMACENADO DE DESACTIVAR CATEGORIA
CREATE PROCEDURE USP_Categoria_Desactivar
  @pcategoria_id int  
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
		UPDATE dbo.Categoria SET					 
			estado = 'I'
		WHERE categoria_id = @pcategoria_id
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO

-- PROCEDIMIENTO ALMACENADO VERIFICAR
CREATE PROCEDURE USP_Categoria_Verificar
  @pvalor varchar(100),
  @existe bit output  
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY

		IF EXISTS (SELECT nombre FROM Categoria WHERE nombre = LTRIM(rtrim(@pvalor)))
			BEGIN
				SET @existe=1
			END
		ELSE
		BEGIN
				SET @existe=0
			END		
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO



-- PROCEDIMIENTO ALMACENADO DE INSERTAR EN LA TABLA USUARIO
CREATE PROCEDURE USP_Usuario_I
  @ppersona_id int,
  @pusuario varchar(50),
  @pclave varchar(100),
  @pnivel varchar(30),
  @pestado char(1)
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			INSERT INTO dbo.Usuario
			VALUES(@ppersona_id, @pusuario, @pclave, @pnivel, @pestado)
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO

-- PROCEDIMIENTO ALMACENADO DE ACTUALIZAR EN LA TABLA USUARIO
CREATE PROCEDURE USP_Usuario_U
  @pusuario_id int,
  @ppersona_id int,
  @pusuario varchar(50),
  @pclave varchar(100),
  @pnivel varchar(30),
  @pestado char(1)
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
		UPDATE dbo.Usuario SET		
			persona_id = @ppersona_id,
			usuario = @pusuario, 
			clave = @pclave,
			nivel = @pnivel, 
			estado = @pestado
		WHERE usuario_id = @pusuario_id
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO


-- PROCEDIMIENTO ALMACENADO DE ELIMINAR EN LA TABLA USUARIO
CREATE PROCEDURE USP_Usuario_D
  @pusuario_id int  
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			DELETE dbo.Usuario 
			WHERE usuario_id = @pusuario_id
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO

-- PROCEDIMIENTO ALMACENADO DE LISTAR EN LA TABLA USUARIO
CREATE PROCEDURE USP_Usuario_S
  
AS
BEGIN	
	SELECT * FROM USUARIO	
END
GO

-- PROCEDIMIENTO ALMACENADO DE BUSCAR EN LA TABLA USUARIO
CREATE PROCEDURE USP_Usuario_S_Buscar
  @pbusqueda varchar(150)
AS
BEGIN	
	SELECT u.persona_id, p.apellido, p.nombre, u.usuario, u.nivel, u.estado 
	FROM dbo.Usuario as u
	INNER JOIN dbo.Persona as p
	ON u.persona_id = p.persona_id		
	WHERE 
	u.usuario LIKE '%' + @pbusqueda + '%'
	OR
	p.apellido LIKE '%' + @pbusqueda + '%'
	OR
	u.nivel = @pbusqueda
END
GO

-- PROCEDIMIENTO ALMACENADO DE ACTIVAR USUARIO
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
GO

-- PROCEDIMIENTO ALMACENADO DE ACTIVAR USUARIO
CREATE PROCEDURE USP_Usuario_Desactivar
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
GO

-- PROCEDIMIENTO ALMACENADO VERIFICAR
CREATE PROCEDURE USP_Usuario_Verificar
  @pvalor varchar(100),
  @existe bit output  
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY

		IF EXISTS (SELECT usuario FROM Usuario WHERE usuario = LTRIM(rtrim(@pvalor)))
			BEGIN
				SET @existe=1
			END
		ELSE
		BEGIN
				SET @existe=0
			END		
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO



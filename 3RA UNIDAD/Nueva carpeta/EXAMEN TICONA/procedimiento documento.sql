-- Procedimientos Almacenados

-- PROCEDIMIENTO ALMACENADO DE INSERTAR
CREATE PROCEDURE USP_Documento_I 
  @pcategoria varchar(150),
  @pnombre varchar(100),
  @pextension varchar(100),
  @ptamaño varchar(100),
  @pdescripcion varchar(250),
  @pestado char(1)
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			INSERT INTO dbo.Documento
			VALUES(@pcategoria, @pnombre,  @pextension, @ptamaño, @pdescripcion, @pestado)
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO

-- PROCEDIMIENTO ALMACENADO DE ACTUALIZAR 
CREATE PROCEDURE USP_Documento_U
  @pdocumento_id int,
  @pcategoria varchar(150),
  @pnombre varchar(100),
  @pextension varchar(100),
  @ptamaño varchar(100),
  @pdescripcion varchar(250),
  @pestado char(1)
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
		UPDATE dbo.Documento SET					
			categoria = @pcategoria, 			
			nombre = @pnombre,
			extension = @pextension, 
			tamaño = @ptamaño,
			descripcion = @pdescripcion,	
			estado = @pestado
		WHERE documento_id = @pdocumento_id
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO


-- PROCEDIMIENTO ALMACENADO DE ELIMINAR 
CREATE PROCEDURE USP_Documento_D
  @pdocumento_id int  
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			DELETE dbo.Documento
			WHERE documento_id = @pdocumento_id
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO

-- PROCEDIMIENTO ALMACENADO DE LISTAR EN LA TABLA USUARIO
CREATE PROCEDURE USP_Documento_S
  
AS
BEGIN	
	SELECT * FROM Documento	
END
GO

-- PROCEDIMIENTO ALMACENADO DE BUSCAR EN LA TABLA USUARIO
CREATE PROCEDURE USP_Documento_S_Buscar
  @pbusqueda varchar(150)
AS
BEGIN	
	SELECT documento_id,categoria,nombre,extension, tamaño, descripcion, estado  
	FROM dbo.Documento
	WHERE 
	categoria LIKE '%' + @pbusqueda + '%'
	OR
	nombre LIKE '%' + @pbusqueda + '%'
	OR
	extension LIKE '%' + @pbusqueda + '%'
END
GO


-- PROCEDIMIENTO ALMACENADO VERIFICAR
CREATE PROCEDURE USP_Documento_Verificar
  @pvalor varchar(100),
  @existe bit output  
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY

		IF EXISTS (SELECT categoria FROM Documento WHERE categoria = LTRIM(rtrim(@pvalor)))
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




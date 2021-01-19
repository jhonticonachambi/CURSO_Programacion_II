create procedure USP_Usuario_CambiarContraseña
  @pclave varchar(100)
As 
BEGIN 
   BEGIN TRAN 
       BEGIN TRY  
         UPDATE  dbo.Usuario SET
			 clave = @pclave
		WHERE clave = @pclave
   COMMIT 
       END TRY
       BEGIN CATCH
	       ROLLBACK
	   END CATCH
   END
go

create procedure USP_Usuario_ContraseñaVerificar
  @pvalor varchar (100),
	@existe bit output
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
		IF EXISTS (SELECT clave FROM usuario WHERE usuario = LTRIM(rtrim(@pvalor)))
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
go
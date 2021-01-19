CREATE PROCEDURE USP_Persona_U
  @pusuario_id int,
  @pnombre varchar(50),
  @papellido varchar(100),
  @psexo varchar(30),
  @pemail varchar(20),
  @pcelular int,
  @pdireccion varchar(40),
  @pfechanacimiento varchar(8),
  @pfoto varchar(250)
AS
BEGIN 
	BEGIN TRAN
		BEGIN TRY
		UPDATE dbo.Persona SET
		nombre = @pnombre,
		apellido = @papellido,
		sexo = @psexo,
		email = @pemail,
		celular = @pcelular,
		direccion = @pdireccion,
		fechanacimiento = @pfechanacimiento,
		foto = @pfoto
		WHERE persona_id = @pusuario_id
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO
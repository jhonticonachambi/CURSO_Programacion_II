CREATE PROCEDURE USP_Documento_Cantidad
AS
BEGIN	
	SELECT categoria as tipodearchivo,count(categoria) AS Cantidad,
	round((count(categoria)*100)/ (SELECT count(*) FROM dbo.Documento),2) as porcentaje
		FROM dbo.Documento
		GROUP BY categoria;
END
GO
USE [ESCOLA]
GO
CREATE PROCEDURE [dbo].[RETORNA_INADIMPLENTES]
AS
BEGIN
	DECLARE
		@CPF NVARCHAR(450) = NULL

	IF @CPF IS NULL
		SELECT 
			U.CPF, 
			U.NOME, 
			S.DESCRICAO, 
			S.PRECO 
		FROM USUARIOS U
			INNER JOIN INADIMPLENTES I
				ON U.CPF = I.CPF_USUARIO
			INNER JOIN SERVICOS S
				ON I.ID_SERVICO = S.ID
	ELSE
		SELECT 
			U.CPF, 
			U.NOME, 
			S.DESCRICAO, 
			S.PRECO 
		FROM USUARIOS U
			INNER JOIN INADIMPLENTES I
				ON U.CPF = I.CPF_USUARIO
			INNER JOIN SERVICOS S
				ON I.ID_SERVICO = S.ID
		WHERE U.CPF = @CPF
	
	SET NOCOUNT OFF
END
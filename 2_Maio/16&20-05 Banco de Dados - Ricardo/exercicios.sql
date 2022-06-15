/*
1) Selecionar todas as linhas das tabelas BANCOS, com os nomes dos bancos em ordem alfabética.
Para os bancos com nomes repetidos, ordenar a agência em ordem crescente.
*/
SELECT *
FROM BANCOS
ORDER BY NM_BANCO, NU_AGENCIA
GO

---------------------------------------------------------------------------------------------------
/*
2) Selecionar os bancos que não tem nenhum funcionário vinculado
*/
SELECT NM_BANCO
FROM BANCOS B
	LEFT JOIN FUNCIONARIOS F 
		ON F.CD_BANCO = B.CD_BANCO
WHERE F.CD_FUNCIONARIO IS NULL
GO

---------------------------------------------------------------------------------------------------
/*
3) Selecionar os bancos com o numero do banco seja nulo ou o primeiro dígito número do seja igual a 1.
*/
SELECT B.NM_BANCO, B.NU_BANCO
FROM BANCOS B
WHERE NU_BANCO IS NULL OR NU_BANCO LIKE '1%'
GO

---------------------------------------------------------------------------------------------------
/*
4) Selecionar os funcionários que ganham R$ 200,00 ou menos que nasceram depois depois de 1974
*/
SELECT F.NM_FUNCIONARIO,F.DT_NASCIMENTO, F.VL_SALARIO
FROM FUNCIONARIOS F
WHERE VL_SALARIO <= 200.00 
	AND YEAR(DT_NASCIMENTO) > 1974
GO

---------------------------------------------------------------------------------------------------
/*
5) Selecionar os funcionários que foram contratado no mes 2
*/
SELECT *
FROM FUNCIONARIOS
WHERE MONTH(DT_ADMISSAO) = 2
GO

---------------------------------------------------------------------------------------------------
/*
6) Selecionar os fucionários que tem conta em banco, mas não estão vinculados em nenhum departamento
*/
SELECT *
FROM FUNCIONARIOS F
	LEFT JOIN BANCOS B 
		ON F.CD_BANCO = B.CD_BANCO
WHERE F.CD_BANCO IS NOT NULL AND CD_DEPARTAMENTO IS NULL
GO

---------------------------------------------------------------------------------------------------
/*
7) Mostrar uma tabela com nome do funcionário, nome do departamento e nome do banco
*/
SELECT F.NM_FUNCIONARIO, D.NM_DEPARTAMENTO, B.NM_BANCO
FROM FUNCIONARIOS F 
	LEFT JOIN DEPARTAMENTOS D ON F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO
	LEFT JOIN BANCOS B ON F.CD_BANCO = B.CD_BANCO
GO

---------------------------------------------------------------------------------------------------
/*
8) Mostrar uma tabela com nome do funcionário, nome do departamento e nome do banco, para todos os funcionários que estão em algum departamento. 
Se o funcionário não tiver conta em nenhum banco, exibir a mensagem "Conta inexistente"
*/
SELECT 
	F.NM_FUNCIONARIO AS [Nome do funcionario], 
	D.NM_DEPARTAMENTO AS [Nome do departamento], 
	ISNULL(B.NM_BANCO, 'Conta inexistente') AS [Nome do Banco]
FROM FUNCIONARIOS F 
	LEFT JOIN DEPARTAMENTOS D ON F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO
	LEFT JOIN BANCOS B ON F.CD_BANCO = B.CD_BANCO
ORDER BY B.NM_BANCO
GO

---------------------------------------------------------------------------------------------------
/*
9) Selecionar os funcionários que tenham conta no banco do brasil e trabalhem no departamento de desenvolvimento ou
que trabalhem no departamento de recursos humanos e não tenham conta em nenhum banco
*/
SELECT NM_FUNCIONARIO, NM_BANCO, NM_DEPARTAMENTO
FROM FUNCIONARIOS F
	LEFT JOIN BANCOS B 
		ON F.CD_BANCO = B.CD_BANCO
	LEFT JOIN DEPARTAMENTOS D 
		ON F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO
WHERE (F.CD_DEPARTAMENTO = 1 AND F.CD_BANCO = 1) 
	OR (F.CD_DEPARTAMENTO = 4 AND F.CD_BANCO IS NULL)
GO

---------------------------------------------------------------------------------------------------
/*
10) Selecionar todos os funcionários, mostrando o nome do funcionário, a data de admissão,
Salário atual, uma mensagem nas seguintes condições:
1 - Se foram admitidos antes do ano 2000. Mensagem: "Senior"
2 - Se foi admitido entre o ano 2000 e 2014. Mensagem: "Pleno"
3 - Se foi admitido depois de 2014. Mensagem: "Novato"
e uma coluna chamada "Salário Previsto" com o aumento de 12,35% para os funcionários novatos com conta no bradesco da agencia 500-4
e aumento de 15% para os funcionários plenos que tiverem conta na caixa econômica Federal.
*/
SELECT F.NM_FUNCIONARIO, F.DT_ADMISSAO, F.VL_SALARIO, B.NM_BANCO, 
CASE 
	WHEN YEAR(F.DT_ADMISSAO) < 2000 THEN 'Senior'
	WHEN YEAR(F.DT_ADMISSAO) BETWEEN 2000 AND 2014 THEN 'Pleno'
	WHEN YEAR(F.DT_ADMISSAO) > 2014 THEN 'Novato'
END AS TIPO,
CASE
	WHEN YEAR(F.DT_ADMISSAO) > 2014 AND NM_BANCO = 'Bradesco' AND NU_AGENCIA = '500-4' THEN VL_SALARIO * 1.1235
	WHEN YEAR(F.DT_ADMISSAO) BETWEEN 2000 AND 2014 AND NM_BANCO = 'Caixa Econômica Federal' THEN VL_SALARIO * 1.15
	WHEN YEAR(F.DT_ADMISSAO) = YEAR(F.DT_ADMISSAO) THEN VL_SALARIO
END AS [Salário Previsto]
FROM FUNCIONARIOS F LEFT JOIN BANCOS B ON F.CD_BANCO = B.CD_BANCO
GO

---------------------------------------------------------------------------------------------------
/*
11)Fazer um relatório que para cada departamento mostre o nome do departamento e a quantidade
de pessoas que foram admitidos antes do ano 2000, entre o ano 2000 e 2014 e depois de 2014.
*/
SELECT D.NM_DEPARTAMENTO AS [Nome do Departamento], 
	SUM(IIF(YEAR(F.DT_ADMISSAO) < 2000, 1, 0)) AS [Antes de 2000],
	SUM(IIF(YEAR(F.DT_ADMISSAO) BETWEEN 2000 AND 2014, 1, 0)) AS [Entre 2000 e 2014],
	SUM(IIF(YEAR(F.DT_ADMISSAO) > 2014, 1, 0)) AS [Depois de 2014]
FROM FUNCIONARIOS F
	JOIN DEPARTAMENTOS D 
		ON F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO
GROUP BY D.NM_DEPARTAMENTO
GO

SELECT *
FROM FUNCIONARIOS F


















---------------------------------------------------------------------------------------------------
--UNIÃO
/*TODOS OS FUNCIONARIOS QUE NÃO TEM CONTA EM BANCO UNIDOS COM O DEPARTAMENTO 3 E 4*/
SELECT *
FROM FUNCIONARIOS F
WHERE F.CD_BANCO IS NULL
UNION
SELECT *
FROM FUNCIONARIOS F
WHERE F.CD_DEPARTAMENTO IN (3,4)



SELECT *
FROM FUNCIONARIOS F
	LEFT JOIN DEPARTAMENTOS D
		ON F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO



/*
SELECT *
FROM(SELECT F.NM_FUNCIONARIO AS [NOME], 
	F.VL_SALARIO AS SALARIO,
	DATEDIFF(YEAR,DT_NASCIMENTO, GETDATE()) AS [IDADE],
	F.DT_ADMISSAO AS [DATA DE ADMISSAO],
	DATEDIFF(YEAR,DT_ADMISSAO, GETDATE()) AS [TEMPO DE SERVICO]
		FROM FUNCIONARIOS F) X
WHERE X.[TEMPO DE SERVICO] < 15
GO
*/

DROP TABLE IF EXISTS #X
SELECT *
INTO #X
FROM FUNCIONARIOS
GO


SELECT D.NM_DEPARTAMENTO, COUNT(*)
FROM FUNCIONARIOS F
	LEFT JOIN DEPARTAMENTOS D
		ON F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO
GROUP BY D.NM_DEPARTAMENTO
GO

SELECT *
FROM FUNCIONARIOS F

SELECT *
FROM DEPARTAMENTOS D

SELECT *
FROM BANCOS B

SELECT D.NM_DEPARTAMENTO, COUNT(*) AS [TOTAL_FUNCIONARIOS]
INTO #tabela FROM DEPARTAMENTOS D JOIN FUNCIONARIOS F ON
D.CD_DEPARTAMENTO = F.CD_DEPARTAMENTO
GROUP BY D.NM_DEPARTAMENTO

SELECT *
FROM #tabela














--PARA CADA DEPARTAMENTO O MENOR SALARIO, COM SUBCONSULTA NO JOIN OU FROM
SELECT *
FROM (	SELECT D.NM_DEPARTAMENTO, MIN(F.VL_SALARIO) [Salario]
		FROM FUNCIONARIOS F
		LEFT JOIN DEPARTAMENTOS D
			ON D.CD_DEPARTAMENTO = F.CD_DEPARTAMENTO
		GROUP BY D.NM_DEPARTAMENTO) AS [X]


--EXISTS
SELECT *
FROM FUNCIONARIOS F
WHERE EXISTS (	SELECT *
				FROM BANCOS B
				WHERE B.NU_AGENCIA = '345-1')

---------------------------------------------------------------------------------------------------









--PIVOT
SELECT *
FROM (	SELECT D.NM_DEPARTAMENTO, F.VL_SALARIO
		FROM FUNCIONARIOS F
		JOIN DEPARTAMENTOS D
			ON F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO) T
PIVOT(	AVG(T.VL_SALARIO)
		FOR T.NM_DEPARTAMENTO IN ([Desenvolvimento],[Editoração],[Financeiro],[Recursos Humanos])) AS X

---------------------------------------------------------------------------------------------------










--JSON
--FUNCIONARIOS
SELECT *
FROM FUNCIONARIOS
FOR JSON AUTO


DECLARE @JS VARCHAR(MAX) = '[{"CD_FUNCIONARIO":1,"NM_FUNCIONARIO":"Antônio Nascimento","CD_DEPARTAMENTO":3,"DT_ADMISSAO":"1992-01-10T00:00:00","DT_NASCIMENTO":"1974-01-10T00:00:00","VL_SALARIO":200.0000},{"CD_FUNCIONARIO":2,"NM_FUNCIONARIO":"João Anastácio","CD_DEPARTAMENTO":1,"DT_ADMISSAO":"2005-01-01T00:00:00","DT_NASCIMENTO":"1987-01-01T00:00:00","CD_BANCO":1,"VL_SALARIO":500.0000},{"CD_FUNCIONARIO":3,"NM_FUNCIONARIO":"João Malha","CD_DEPARTAMENTO":4,"DT_ADMISSAO":"2009-04-10T00:00:00","DT_NASCIMENTO":"1991-04-10T00:00:00","CD_BANCO":4,"VL_SALARIO":189.0000},{"CD_FUNCIONARIO":4,"NM_FUNCIONARIO":"Manoel da R. Pizzolo","CD_DEPARTAMENTO":3,"DT_ADMISSAO":"2015-05-02T00:00:00","DT_NASCIMENTO":"1997-05-02T00:00:00","CD_BANCO":3,"VL_SALARIO":1500.0000},{"CD_FUNCIONARIO":5,"NM_FUNCIONARIO":"Maria de Jesus","CD_DEPARTAMENTO":4,"DT_ADMISSAO":"1998-02-11T00:00:00","DT_NASCIMENTO":"1980-02-11T00:00:00","VL_SALARIO":180.0000},{"CD_FUNCIONARIO":6,"NM_FUNCIONARIO":"Pedro Brasona","CD_DEPARTAMENTO":2,"DT_ADMISSAO":"2019-02-05T00:00:00","DT_NASCIMENTO":"2001-02-05T00:00:00","CD_BANCO":2,"VL_SALARIO":800.0000},{"CD_FUNCIONARIO":7,"NM_FUNCIONARIO":"Raimundo Pizzolo","CD_DEPARTAMENTO":4,"DT_ADMISSAO":"1998-02-11T00:00:00","DT_NASCIMENTO":"1980-02-11T00:00:00","VL_SALARIO":180.0000}]'


SELECT *
FROM OPENJSON(@JS)
WITH (
	CD_FUNCIONARIO INT,
	NM_FUNCIONARIO VARCHAR(150),
	CD_DEPARTAMENTO INT,
	DT_ADMISSAO DATETIME,
	DT_NASCIMENTO DATETIME,
	CD_BANCO INT,
	VL_SALARIO MONEY
	) AS FUNCIONARIOS

--BANCOS
SELECT *
FROM BANCOS
FOR JSON AUTO


DECLARE @BANCOS VARCHAR(MAX) = '[{"CD_BANCO":1,"NM_BANCO":"Banco do Brasil","NU_AGENCIA":"0407-3","NU_BANCO":"6620-6"},{"CD_BANCO":2,"NM_BANCO":"Bradesco","NU_AGENCIA":"500-4","NU_BANCO":"1246-88"},{"CD_BANCO":3,"NM_BANCO":"Bradesco","NU_AGENCIA":"345-1","NU_BANCO":"1232-2"},{"CD_BANCO":4,"NM_BANCO":"Caixa Econômica Federal","NU_AGENCIA":"0258-0","NU_BANCO":"104"},{"CD_BANCO":5,"NM_BANCO":"Itaú","NU_AGENCIA":"2323-24","NU_BANCO":"34534"}]'


SELECT *
FROM OPENJSON(@BANCOS)
WITH (
	CD_BANCO INT,
	NM_BANCO VARCHAR(150),
	NU_AGENCIA VARCHAR(15),
	NU_BANCO VARCHAR(15)
	) AS BANCOS

--DEPARTAMENTOS
SELECT *
FROM DEPARTAMENTOS
FOR JSON AUTO


DECLARE @DEPARTAMENTOS VARCHAR(MAX) = '[{"CD_DEPARTAMENTO":1,"NM_DEPARTAMENTO":"Desenvolvimento"},{"CD_DEPARTAMENTO":2,"NM_DEPARTAMENTO":"Editoração"},{"CD_DEPARTAMENTO":3,"NM_DEPARTAMENTO":"Financeiro"},{"CD_DEPARTAMENTO":4,"NM_DEPARTAMENTO":"Recursos Humanos"}]'


SELECT *
FROM OPENJSON(@DEPARTAMENTOS)
WITH (
	CD_DEPARTAMENTO INT,
	NM_DEPARTAMENTO VARCHAR(150)
	) AS DEPARTAMENTO

---------------------------------------------------------------------------------------------------




DROP TABLE IF EXISTS #X
SELECT F.CD_DEPARTAMENTO, F.NM_FUNCIONARIO
INTO #X
FROM FUNCIONARIOS F
ORDER BY CD_DEPARTAMENTO

SELECT X1.CD_DEPARTAMENTO
	, FUNCS = STUFF((	SELECT CONCAT(',', X2.NM_FUNCIONARIO)
						FROM #X X2
						WHERE X2.CD_DEPARTAMENTO = X1.CD_DEPARTAMENTO
						ORDER BY X2.NM_FUNCIONARIO
						FOR XML PATH('')) , 1, 1, '')
FROM #X X1
GROUP BY X1.CD_DEPARTAMENTO

---------------------------------------------------------------------------------------------------
--REFAZENDO UMA CONSULTA

SELECT D.NM_DEPARTAMENTO,
	QTD_SENIOR = SUM(IIF(YEAR(F.DT_ADMISSAO) < 2000, 1, 0)),
	QTD_PLENO = SUM(IIF(YEAR(F.DT_ADMISSAO) BETWEEN 2000 AND 2014, 1, 0)),
	QTD_JUNIOR = SUM(IIF(YEAR(F.DT_ADMISSAO) > 2014, 1, 0))
FROM FUNCIONARIOS F
	JOIN DEPARTAMENTOS D
		ON D.CD_DEPARTAMENTO = F.CD_DEPARTAMENTO
GROUP BY D.NM_DEPARTAMENTO





SELECT D.NM_DEPARTAMENTO,	QNT_SENIOR = (	SELECT COUNT(*) 
											FROM FUNCIONARIOS F
											WHERE YEAR(DT_ADMISSAO) < 2000 AND F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO),
							QNT_PLENO = (	SELECT COUNT(*)
											FROM FUNCIONARIOS F
											WHERE YEAR(DT_ADMISSAO) BETWEEN 2000 AND 2014 AND F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO),
							QNT_NOVATO = (	SELECT COUNT(*)
											FROM FUNCIONARIOS F
											WHERE YEAR(DT_ADMISSAO) > 2014 AND F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO)
FROM DEPARTAMENTOS D
ORDER BY NM_DEPARTAMENTO





SELECT NM_DEPARTAMENTO, QTD_SENIOR = (SELECT COUNT(*) FROM FUNCIONARIOS WHERE YEAR(DT_ADMISSAO) < 2000 AND CD_DEPARTAMENTO = D.CD_DEPARTAMENTO),
						QTD_PLENO = (SELECT COUNT(*) FROM FUNCIONARIOS WHERE YEAR(DT_ADMISSAO) BETWEEN 2000 AND 2014 AND CD_DEPARTAMENTO = D.CD_DEPARTAMENTO ),
						QTD_NOVATO = (SELECT COUNT(*) FROM FUNCIONARIOS WHERE YEAR(DT_ADMISSAO) > 2014 AND CD_DEPARTAMENTO = D.CD_DEPARTAMENTO)
FROM DEPARTAMENTOS D ORDER BY NM_DEPARTAMENTO

---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
--20-05
--PRIMEIRA ADMISSÃO ATÉ A ULTIMA ADMISSÃO
/*
SELECT *
FROM FUNCIONARIOS F


SELECT YEAR(F.DT_ADMISSAO) AS [ANO], COUNT(YEAR(F.DT_ADMISSAO)) AS [QNT_ADMISSOES]
FROM FUNCIONARIOS F
GROUP BY F.DT_ADMISSAO


DROP TABLE IF EXISTS #X
CREATE TABLE #X(
	[ANO] INT,
	[QTD_ADMISSOES] INT
)
DECLARE @MIN INT = (SELECT MIN(YEAR(F.DT_ADMISSAO)) FROM FUNCIONARIOS F)
DECLARE @MAX INT = (SELECT MAX(YEAR(F.DT_ADMISSAO)) FROM FUNCIONARIOS F)


DROP TABLE IF EXISTS #RELATORIOS
CREATE TABLE #RELATORIOS(
ANO INT,
QTD INT
)

USE FUNCIONARIOS
DECLARE @ANO_MIN INT = (SELECT ANO_MIN = MIN(YEAR(DT_ADMISSAO))
FROM FUNCIONARIOS)
DECLARE @ANO_MAX INT = (SELECT ANO_MAX = MAX(YEAR(DT_ADMISSAO))
FROM FUNCIONARIOS)
DECLARE @MES INT = 1


WHILE @ANO_MIN <= @ANO_MAX
BEGIN
INSERT INTO #RELATORIOS VALUES
(@ANO_MIN, (SELECT COUNT(CD_FUNCIONARIO) FROM FUNCIONARIOS WHERE YEAR(DT_ADMISSAO) = @ANO_MIN))
SET @ANO_MIN = @ANO_MIN + 1
END


SELECT * FROM #RELATORIOS
*/
---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
DECLARE @MIN_ANO INT = (SELECT MIN(YEAR(F.DT_ADMISSAO)) FROM FUNCIONARIOS F)
DECLARE @MAX_ANO INT = (SELECT MAX(YEAR(F.DT_ADMISSAO)) FROM FUNCIONARIOS F)
DECLARE @MES INT = 1

DROP TABLE IF EXISTS #X
CREATE TABLE #X(
	[ANO] INT,
	[MES] INT,
	[QTD_ADMISSOES] INT
)

WHILE @MIN_ANO <= @MAX_ANO
	BEGIN
		WHILE @MES <= 12
			BEGIN
			INSERT INTO #X VALUES (	@MIN_ANO,
									@MES,
								  (		SELECT COUNT(F.CD_FUNCIONARIO) 
										FROM FUNCIONARIOS F 
										WHERE YEAR(DT_ADMISSAO) = @MIN_ANO 
										AND MONTH(DT_ADMISSAO) = @MES))
			SET @MES = @MES + 1
			END
	SET @MIN_ANO += 1
	IF @MIN_ANO <= @MAX_ANO
	SET @MES = 1
	END

SELECT *
FROM #X

SELECT YEAR(DT_ADMISSAO), MONTH(DT_ADMISSAO)
FROM FUNCIONARIOS
ORDER BY DT_ADMISSAO
GO

---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
DECLARE @MIN_ANO INT = (SELECT MIN(YEAR(F.DT_ADMISSAO)) FROM FUNCIONARIOS F)
DECLARE @MAX_ANO INT = (SELECT MAX(YEAR(F.DT_ADMISSAO)) FROM FUNCIONARIOS F)

DROP TABLE IF EXISTS #X
CREATE TABLE #X(
	[ANO] INT,
	[QTD_ADMISSOES] INT)

WHILE @MIN_ANO <= @MAX_ANO
	BEGIN
	INSERT INTO #X VALUES (	@MIN_ANO,
						  (	SELECT COUNT(F.CD_FUNCIONARIO) 
							FROM FUNCIONARIOS F 
							WHERE YEAR(DT_ADMISSAO) = @MIN_ANO))
	DELETE FROM #X WHERE #X.QTD_ADMISSOES != 0
	SET @MIN_ANO += 1
	END

SELECT *
FROM #X
GO

---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
SELECT	YEAR(F.DT_ADMISSAO) AS [ANO],
		F.VL_SALARIO AS [SALARIO],
		LAG(F.VL_SALARIO) OVER (ORDER BY F.VL_SALARIO) AS [ACUMULADO]
FROM FUNCIONARIOS F
GROUP BY F.DT_ADMISSAO, F.VL_SALARIO
ORDER BY ANO

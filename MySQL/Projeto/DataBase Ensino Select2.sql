USE ENSINO;

SELECT IDEstudante,
	   ClassificacaoFinal,
       DataInscricao
FROM Inscricao
WHERE IDAccao = 3;

SELECT Nome,
	   Endereco,
       DataNascimento
FROM Estudante
WHERE Cidade IN ('Lisboa', 'Coimbra');

SELECT ID,
	   Nome,
       Endereco
FROM Estudante
WHERE Endereco LIKE 'Rua%';

SELECT ID,
	   Nome,
       CodigoPostal
FROM Estudante
WHERE CodigoPostal BETWEEN 3002 AND 3005;

SELECT ID,
	   Nome,
       CodigoPostal
FROM Estudante
WHERE CodigoPostal NOT BETWEEN 3002 AND 3005;

SELECT ID,
	   Nome,
       DataNascimento
FROM Estudante
WHERE YEAR(DataNascimento) = 1998;

SELECT IDEstudante,
	   DATEDIFF(CURDATE(), DataInscricao),
	   DataInscricao
FROM Inscricao
WHERE IDAccao = 2;

SELECT IDEstudante,
	   DataInscricao
FROM Inscricao
WHERE DataInscricao >= CURDATE() - INTERVAL 20 MONTH;

SELECT IDEstudante,
	   DAYOFWEEK(DataInscricao),
       DAYOFMONTH(DataInscricao),
       DAYOFYEAR(DataInscricao)
FROM Inscricao;

SELECT CONCAT(Nome, ' ', Apelido) AS 'Nome completo',
	   ID AS 'ID do estudante',
       DataNascimento AS 'Data de nascimento'
FROM Estudante
WHERE YEAR(DataNascimento) = 1998;

DROP VIEW IF EXISTS EstContab;
CREATE VIEW EstContab AS
	SELECT IDEstudante,
		   DataInscricao
	FROM Inscricao
    WHERE IDAccao IN (4, 5);

SELECT * FROM EstContab;

DROP VIEW IF EXISTS EstNatureza;
CREATE VIEW EstNatureza AS
	SELECT IDEstudante,
		   DataInscricao
	FROM Inscricao
    WHERE IDAccao IN (1, 2, 3);

SELECT * FROM EstNatureza;

DROP VIEW IF EXISTS Maiores25;
CREATE VIEW Maiores25 AS
	SELECT ID,
		   Nome,
           DataNascimento
	FROM Estudante
    WHERE Nome LIKE 'Antonio%' AND YEAR(DataNascimento) <= 2000;

SELECT * FROM Maiores25;
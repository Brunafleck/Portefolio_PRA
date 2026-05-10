USE ENSINO;

SELECT Accao.ID,
	   Curso.Nome,
       Accao.Numero,
       Accao.DataInicial,
       Accao.DataFinal,
       Curso.Duracao
FROM Accao
JOIN Curso
ON Accao.IDCurso = Curso.ID;

SELECT Estudante.Nome,
	   Curso.Nome,
       Duracao
FROM Estudante
JOIN Inscricao
ON Inscricao.IDEstudante = Estudante.ID
JOIN Accao
ON Inscricao.IDAccao = Accao.ID
JOIN Curso
ON Accao.IDCurso = Curso.ID;

SELECT Estudante.Nome AS 'Nome do estudante',
	   Curso.Nome AS 'Nome do curso',
       Duracao
FROM Estudante, Inscricao, Accao, Curso
WHERE Inscricao.IDEstudante = Estudante.ID
	  AND Inscricao.IDAccao = Accao.ID
      AND Accao.IDCurso = Curso.ID;

SELECT Estudante.Nome AS 'Nome do estudante',
	   Curso.Nome AS 'Nome do curso',
       Duracao
FROM Estudante
JOIN Inscricao
ON Inscricao.IDEstudante = Estudante.ID
JOIN Accao
ON Inscricao.IDAccao = Accao.ID
JOIN Curso
ON Accao.IDCurso = Curso.ID
WHERE Curso.Nome IN ('Biologia', 'Agricultura Aplicada');

DROP VIEW IF EXISTS AccaoCurso;
CREATE VIEW AccaoCurso AS
	SELECT Accao.ID AS 'IDAccao',
		   Curso.Nome AS 'NomeCurso',
           Accao.Numero,
           Accao.DataInicial,
           Accao.DataFinal,
           Curso.Duracao,
           Curso.Tipo
FROM Accao
JOIN Curso
ON Accao.IDCurso = Curso.ID;

SELECT * FROM AccaoCurso;

DROP VIEW IF EXISTS InscricaoEstudante;
CREATE VIEW InscricaoEstudante AS
	SELECT Inscricao.ID AS 'IDInscricao',
		   Inscricao.ClassificacaoFinal,
           Inscricao.IDAccao,
           Inscricao.DataInscricao,
           Estudante.ID AS 'IDEstudante',
           Estudante.Nome AS 'NomeEstudante',
           Estudante.Apelido AS 'Apelido'
FROM Inscricao
JOIN Estudante
ON Inscricao.IDEstudante = Estudante.ID;

SELECT * FROM InscricaoEstudante;

/*
ERRADO
VERIFICAR
SELECT NomeEstudante,
	   NomeCurso,
       Duracao
FROM AccaoCurso
JOIN InscricaoEstudante
ON AccaoCurso.IDAccao = InscricaoEstudante.IDAccao
WHERE NomeCurso IN ('Biologia', 'Agricultura Aplicada');
*/

SELECT Nome AS 'Nome do estudante',
	   DataEstatuto,
       NIF
FROM Estudante, EstudanteTrabalhador
WHERE Estudante.ID = EstudanteTrabalhador.IDEstudante;

/*
ERRADO
SELECT Estudante.Nome AS 'Nome do estudante',
	   Curso.Nome AS 'Nome do curso',
       Inscricao.DataInscricao AS 'Data de inscricao',
       NIF
FROM AccaoCurso, InscricaoEstudante, EstudanteTrabalhador
WHERE AccaoCurso.IDAccao = InscricaoEstudante.IDAccao
	  AND InscricaoEstudante.IDEstudante = EstudanteTrabalhador.IDEstudante;
*/


/*
SELECT Estudante.Nome AS 'Nome do estudante',
	   Curso.Nome AS 'Nome do curso',
       Inscricao.DataInscricao AS 'Data da inscricao',
       NIF
FROM AccaoCurso AS AC, InscricaoEstudante AS IE, EstudanteTrabalhador AS ET
WHERE AC.IDAccao = IE.IDAccao
	  AND IE.IDEstudante = ET.IDEstudante;
*/

/*
ERRADO
SELECT Estudante.Nome AS 'Nome do estudante',
	   Curso.Nome AS 'Nome do curso',
       Inscricao.DataInscricao AS 'Data da inscricao',
       COALESCE (NIF, '<nao aplicavel>') AS NIF
FROM InscricaoEstudante AS IE
JOIN AccaoCurso AS AC
ON IE.IDAccao = AC.IDAccao
LEFT OUTER JOIN EstudanteTrabalhador AS ET
ON IE.IDEstudante = ET.IDEstudante;
*/

SELECT Estudante.Nome,
	   Inscricao.ClassificacaoFinal
FROM Inscricao
JOIN Estudante
ON Inscricao.IDEstudante = Estudante.ID
ORDER BY ClassificacaoFinal ASC;

SELECT Estudante.Nome,
	   Inscricao.ClassificacaoFinal
FROM Inscricao
JOIN Estudante
ON Inscricao.IDEstudante = Estudante.ID
ORDER BY ClassificacaoFinal DESC;

SELECT Estudante.Nome,
	   Inscricao.ClassificacaoFinal
FROM Inscricao
JOIN Estudante
ON Inscricao.IDEstudante = Estudante.ID
ORDER BY ClassificacaoFinal DESC, Nome ASC;

SELECT Estudante.Nome,
	   Inscricao.ClassificacaoFinal
FROM Inscricao
JOIN Estudante
ON Inscricao.IDEstudante = Estudante.ID
ORDER BY ClassificacaoFinal DESC, Nome ASC
LIMIT 0, 5;

SELECT Estudante.Nome,
	   Inscricao.ClassificacaoFinal
FROM Inscricao
JOIN Estudante
ON Inscricao.IDEstudante = Estudante.ID
ORDER BY ClassificacaoFinal DESC
LIMIT 0, 7;

/*
ERRADO
SELECT Estudante.Nome,
	   Inscricao.ClassificacaoFinal
FROM (SELECT Estudante.Nome,
			 Inscricao.ClassificacaoFinal
	  FROM Inscricao
	  JOIN Estudante
	  ON Inscricao.IDEstudante = Estudante.ID
	  ORDER BY ClassificacaoFinal DESC
      LIMIT 7) AS M
ORDER BY ClassificacaoFinal ASC;
*/

SELECT IDEstudante,
	   IDAccao,
       Estado
FROM Inscricao
ORDER BY FIELD(Estado, 'acctiva', 'suspensa', 'concluida');

SELECT MAX(ClassificacaoFinal), MIN(ClassificacaoFinal), AVG(ClassificacaoFinal)
FROM Inscricao;

SELECT COUNT(*)
FROM Estudante;

SELECT COUNT(*)
FROM InscricaoEstudante
WHERE ClassificacaoFinal >= 14;

SELECT DISTINCT Duracao
FROM Curso;

SELECT DISTINCT
	   Cidade, CodigoPostal
FROM Estudante;

/*
ERRADO
SELECT Curso.Nome,
	   COUNT(*) AS NumAccoes
FROM AccaoCurso
GROUP BY Curso.Nome;
*/

/*
ERRADO
SELECT IDAccao,
	   AVG(ClassificacaoFinal) AS Media
FROM IscricaoEstudante
GROUP BY IDAccao;
*/

SELECT C.ID, C.Nome, COUNT(I.IDEstudante), AVG(I.ClassificacaoFinal)
FROM Inscricao AS I
JOIN Accao AS A
ON I.IDAccao = A.ID
JOIN Curso AS C
ON A.IDCurso = C.ID
GROUP BY C.ID;
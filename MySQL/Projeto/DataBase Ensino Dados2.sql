USE ENSINO;

INSERT INTO Curso
	(Nome, Duracao, Tipo)
VALUES
    ('Agricultura Aplicada', 1500, 'Ciencias Agrarias'),
    ('Biologia', 1600, 'Ciências da Vida'),
    ('Contabilidade', 1700, 'Ciências Economicas e Fiscalidade');
    
INSERT INTO Accao
	(Numero, IDCurso, DataInicial, DataFinal, Coordenador)
VALUES
    (1, 1, '2023-07-02', '2024-09-02', 'Alberto Antunes'),
    (2, 1, '2024-08-02', '2026-04-02', 'Alberto Antunes'),
    (1, 2, '2024-02-02', '2025-12-02', 'Armando Almeida'),
    (1, 3, '2024-09-02', '2025-12-02', 'Arnaldo Alves'),
    (2, 3, '2024-11-02', '2025-02-02', 'Arnaldo Alves');

INSERT INTO Estudante
	(Nome, Apelido, Endereco, Cidade, CodigoPostal, DataNascimento, NISS)
VALUES
    ('Antonio', 'Americo', 'Rua do Alecrim, n. 1', 'Albufeira', 3001, '1997-08-22', 1111),
    ('Beatriz', 'Bastos', 'Rua do Beato, lote 2', 'Braga', 3002, '1997-02-23', 1112),
    ('Catarina', 'Coelho', 'Praça da Consituicao, n. 3', 'Coimbra', 3003, '1998-02-23', 1113),
    ('Diogo', 'Diniz', 'Avenida Dom Afonso Lote 4', 'Domelas', 3004, '1995-02-04', 1114),
    ('Eduardo', 'Esteves', 'Praca de Espanha, n. 5', 'Evora', 3005, '2002-03-05', 1115),
    ('Filipa', 'Fernandes', 'Travessa da Ferreirinha, 6', 'Faro', 3006, '2004-02-29', 1116);

INSERT INTO Estudante
	(Nome, Apelido, Endereco, Cidade, CodigoPostal, DataNascimento, NISS)
VALUES
	('Filipa', 'Fernandes', 'Travessa da Ferreirinha, 6', 'Faro', 3006, '2004-02-29', 1117);

INSERT INTO Inscricao
    (IDEstudante, IDAccao, DataInscricao, ClassificacaoFinal)
VALUES
    (1, 2, '2023-05-15', 16),
	(2, 3, '2023-12-12', 15),
    (3, 3, '2023-12-10', 8),
    (4, 3, '2023-12-14', 7),
    (5, 2, '2024-05-10', 18),
    (6, 4, '2023-08-01', 17);

INSERT INTO Inscricao
	(IDEstudante, IDAccao, DataInscricao, ClassificacaoFinal)
VALUES
    (7, 4, '2023-08-01', 17);
    
INSERT INTO EstudanteTrabalhador
	(IDEstudante, NIF, DataEstatuto, NumExames, Profissao)
VALUES
	(3, 232454, '2024-02-12', 3, 'Restauracao'),
    (4, 345761, '2020-01-02', 5, 'Entretenimento'),
    (6, 434456, '2020-02-02', 4, 'Programador');

INSERT INTO EstudanteTrabalhador
	(IDEstudante, NIF, DataEstatuto, NumExames, Profissao)
VALUES
    (7, 434455, '2020-02-02', 4, 'Programador');

SELECT ID, Nome FROM Estudante;
SELECT IDEstudante FROM Inscricao;
SELECT IDEstudante FROM EstudanteTrabalhador;

UPDATE Estudante SET ID = 10 WHERE ID = 7;

DELETE FROM Inscricao WHERE IDEstudante = 10;
DELETE FROM EstudanteTrabalhador WHERE IDEstudante = 10;
DELETE FROM Estudante WHERE ID = 10;

ALTER TABLE Estudante RENAME Aluno;
ALTER TABLE Aluno RENAME Estudante;

ALTER TABLE EstudanteTrabalhador MODIFY NumExames TINYINT NULL;

ALTER TABLE Estudante DROP CONSTRAINT CodigoPostalCHK;
ALTER TABLE Estudante RENAME COLUMN CodigoPostal TO CodPostal;
ALTER TABLE Estudante ADD CONSTRAINT CodigoPostalCHK CHECK (CodPostal BETWEEN 3000 AND 4999);

ALTER TABLE Estudante DROP CONSTRAINT CodigoPostalCHK;
ALTER TABLE Estudante RENAME COLUMN CodPostal TO CodigoPostal;
ALTER TABLE Estudante MODIFY CodigoPostal SMALLINT;
ALTER TABLE Estudante ADD CONSTRAINT CodigoPostalCHK CHECK (CodigoPostal BETWEEN 3000 AND 4999);
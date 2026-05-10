USE ENSINO;

INSERT INTO Estudante
	(NomeEstudante, Endereco, Cidade, CodigoPostal, DataNascimento)
VALUES
	('Antonio', 'Rua do Alecrim, n. 1', 'Albufeira', 3001, '1997-08-22'),
    ('Beatriz', 'Rua do Beato, lote 2', 'Braga', 3002, '1997-02-23'),
    ('Catarina', 'Praça da Constituição, n. 3', 'Coimbra', 3003, '1998-08-10'),
    ('Diogo', 'Avenida Dom Afonso, lote 4', 'Domelas', 3004, '1995-02-04'),
    ('Eduardo', 'Praça de Espanha, n.5', 'Évora', 3005, '2002-03-05'),
    ('Filipa', 'Travessa da Ferreirinha, 6', 'Faro', 3006, '2004-02-29');

SELECT ID, NomeEstudante FROM Estudante;
SELECT * FROM Estudante;

ALTER TABLE Estudante ADD COLUMN Nacionalidade VARCHAR(20);

UPDATE Estudante SET Nacionalidade = 'Portugues' WHERE ID > 0;

ALTER TABLE Estudante ADD COLUMN Apelido VARCHAR(50);

UPDATE Estudante SET Apelido = 'Americo' WHERE ID = 1;
UPDATE Estudante SET Apelido = 'Bastos' WHERE ID = 2;
UPDATE Estudante SET Apelido = 'Coelho' WHERE ID = 3;
UPDATE Estudante SET Apelido = 'Diniz' WHERE ID = 4;
UPDATE Estudante SET Apelido = 'Esteves' WHERE ID = 5;
UPDATE Estudante SET Apelido = 'Fernandes' WHERE ID = 6;
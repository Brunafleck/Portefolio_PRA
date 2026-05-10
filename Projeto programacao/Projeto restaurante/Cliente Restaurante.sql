DROP DATABASE IF EXISTS ClienteRestaurante;
CREATE DATABASE ClienteRestaurante;

USE ClienteRestaurante;

DROP TABLE IF EXISTS Cliente;
CREATE TABLE Cliente(
ID							INT PRIMARY KEY AUTO_INCREMENT,
Email						VARCHAR(100) NOT NULL,
Nome						VARCHAR(40) NOT NULL,
Pessoas						INT NOT NULL,
Dia							DATE NOT NULL,
Hora						TIME NOT NULL
);


SELECT * FROM Cliente;


/*
DROP TABLE IF EXISTS Reservas;
CREATE TABLE Reservas(
ID							INT PRIMARY KEY AUTO_INCREMENT,
NumeroMesa					INT,
DataHora					DATETIME,
IDCliente					INT,

CONSTRAINT IDClienteFK FOREIGN KEY (IDCliente) REFERENCES Cliente(ID)
)*/
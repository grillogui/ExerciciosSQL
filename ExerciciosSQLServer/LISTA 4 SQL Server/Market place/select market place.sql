CREATE DATABASE db_marketplace

USE db_marketplace

CREATE TABLE Usuarios (
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	Nome VARCHAR (50) NOT NULL,
	Email VARCHAR (50) NOT NULL,
	Senha VARCHAR(100) NOT NULL,
	Endereco VARCHAR (100) NULL,
)

CREATE TABLE Categorias (
	Id INT PRIMARY KEY NOT NULL,
	Descricaoo VARCHAR (50)
)

CREATE TABLE Produtos (
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	NomeProduto VARCHAR (50) NOT NULL,
	Descricao VARCHAR (150) NOT NULL,
	Preco FLOAT NULL,
	FK_Criador INT NOT NULL,
	FK_Categoria INT NOT NULL,
	FOREIGN KEY (FK_Criador) REFERENCES Usuarios (Id),
	FOREIGN KEY (FK_Categoria) REFERENCES Categorias (Id)
)

CREATE TABLE Compras(
	FK_Comprador INT NOT NULL,
	FK_Produto INT NOT NULL,
	FOREIGN KEY (FK_Comprador) REFERENCES Usuarios (Id),
	FOREIGN KEY (FK_Produto) REFERENCES Produtos (Id)
)

USE db_marketplace

INSERT INTO Usuarios
VALUES
('Murilo','murilo@email.com','654321','Rua Forte de Tamandaré - 556'),
('Matheus','matheus@email.com','654321','Rua Matildes - 354'),
('Gaby','gaby@email.com','568368','Rua Camões - 263'),
('Lucas','lucas@email.com','134652','Rua São Paulo - 126')

INSERT INTO Categorias
VALUES
(1, 'Eletrônicos'),
(2, 'Cozinha')

INSERT INTO Produtos
VALUES
('TV', 'Smart 65 polegadas', 4200.00, 1, 1),
('Panela de Pressão','Tramontina com Fechamento Externo', 249.99,2,2),
('Som', '1500w Bivolt',259.99,3,1),
('Alexa', '3ºgeração', 331.55, 3,1),
('Geladeira','2 portas BRANCA',5479.99,4,2)

INSERT INTO Compras
VALUES
(1,3),
(2,4),
(4,5),
(3,2),
(1,1)

SELECT
Usuarios.Nome AS Nome,
COUNT(Compras.FK_Comprador) AS QtdProduto
--Produtos.NomeProduto AS 'Nome Produto'
FROM Usuarios
LEFT JOIN Compras
ON Usuarios.Id = Compras.FK_Comprador

LEFT JOIN Produtos ON Compras.FK_Produto = Produtos.Id
GROUP BY Usuarios.Nome
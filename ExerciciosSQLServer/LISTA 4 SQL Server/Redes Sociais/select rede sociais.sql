CREATE DATABASE db_redesocial

USE db_redesocial

CREATE TABLE Usuarios
(
Id_Usuario INT PRIMARY KEY IDENTITY NOT NULL,
Nome VARCHAR(50) NOT NULL,
Email VARCHAR(50) NOT NULL,
Senha VARCHAR(100) NOT NULL,
)

CREATE TABLE Tema
(
Id_Tema INT PRIMARY KEY IDENTITY NOT NULL,
Descricao VARCHAR(100) NOT NULL,
)

CREATE TABLE Grupos
(
Id_Grupo INT PRIMARY KEY IDENTITY NOT NULL,
 Nome VARCHAR(50) NOT NULL,
 FK_Id_Tema INT NOT NULL,
 FK_Id_Usuario INT NOT NULL,
 FOREIGN KEY (FK_Id_Tema) REFERENCES Tema (Id_Tema),
 FOREIGN KEY (FK_Id_Usuario) REFERENCES Usuarios (Id_Usuario)
)

CREATE TABLE Postagens
(
Id_Postagem INT PRIMARY KEY IDENTITY NOT NULL,
Titulo VARCHAR(50) NOT NULL,
Descricao VARCHAR(100) NOT NULL,
FK_Id_Usuario INT NULL,
FK_Id_Tema INT NOT NULL,
FK_Id_Grupo INT NOT NULL,
FOREIGN KEY (FK_Id_Usuario) REFERENCES Usuarios (Id_Usuario),
FOREIGN KEY (FK_Id_Grupo) REFERENCES Grupos (Id_Grupo),
FOREIGN KEY (FK_Id_Tema) REFERENCES Tema (Id_Tema),
)

INSERT INTO Usuarios 
VALUES
('Julio','julio@email.com','134652'),
('Kauane','kauane@email.com','134652'),
('Leonardo','leonardo@email.com','134652')

INSERT INTO Tema 
VALUES
('Cosméticos'),
('Games'),
('Culinaria')

INSERT INTO Grupos
VALUES
('Avon',1 ,1),
('RockStar',2 ,1),
('Ana Maria Braga',3 ,2),
('Culinaria Caseira',3, 3),
('Natura',1 ,2)

INSERT INTO Postagens
VALUES
('Perfumes', 'Perfumes feitos com rosas', 1, 1, 1),
('God of war', 'Lançamento do novo jogo',1 ,2 ,2 ),
('Bolinho de queijo', 'Receita prática e rápida',2 ,3 ,2 ),
('Strogonoff', 'Strogonoff de carne',3 ,3 ,3 ),
('Desorante', 'Masculino',2 ,1 ,1 )


SELECT
Usuarios.Nome AS 'Nome Usuario',
COUNT(Grupos.Nome) AS 'Quantidade de grupos que participa'


FROM Usuarios

FULL JOIN Grupos ON Usuarios.Id_Usuario = Grupos.FK_Id_Usuario
FULL JOIN Tema ON Grupos.FK_Id_Tema = Tema.Id_Tema

WHERE Tema.Descricao IN ('Cosméticos', 'Culinaria')
GROUP BY
Usuarios.Nome
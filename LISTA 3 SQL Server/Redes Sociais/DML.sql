USE db_RedeSocial

INSERT INTO Usuarios
VALUES
(1, 'Junior', 'juninbololo@gmail.com', 'Jinindogral'),
(2, 'Gabriel', 'brielzin_xitado@gg.com', 'matonorolas123')

INSERT INTO Categoria
VALUES
(1, 'Motos'),
(2, 'Games')

INSERT INTO Grupos
VALUES
(1, 'Grau é arte', 1),
(2, 'RPzin de cria', 2)

INSERT INTO Postagens
VALUES
(1, 'Grau, Marcha e bololo', 'como manter no grau', 1, 1, 1),
(2, 'Como ficar rico no RP', 'cheat sem hack', 2, 2, 2)

SELECT * FROM Usuarios
WHERE Nome like 'Junior'
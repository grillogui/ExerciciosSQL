use db_ecomerce

insert into Usuarios
values
(1, 'Claudio Felix', 'claudiogatinho2001@hotmail.com', 'clauclau123', '562789876-15'),
(2, 'Diana Trovao', 'ditrovs@gmail.com', '9uska', '786545678-43'),
(3, 'Marcos Raro', 'Rarotropadourso@uol.com', 'urso00', '764289283-23')

 insert into Produtos
 values
 (1, 50.00, 1, 'ovo de pascoa', 'cartão', 1),
 (2, 10.00, 3, 'chocolate', 'pix', 2),
 (3, 150.00, 2, 'roupa', 'cartão', 3)

 insert into entrega 
 values
 (1, 'Retirada no caixa', 'Pronta entrega', 1 , 1),
 (2, 'pague e pegue', 'Pronta entrega', 2 , 2),
 (3, 'entrega em domicilio', '5 dias', 3 , 3)

 Select * from Usuarios
 where nome like 'Diana Trovao'
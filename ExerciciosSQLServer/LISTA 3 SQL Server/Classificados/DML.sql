use db_classificados

insert into Usuario
values 
(555, '45147284897', 'anunciante', 'SP', '11 98244-1222'),
(556, '86756573892', 'anunciante', 'SP', '11 94756-7832'),
(557, '64374895473', 'anunciante', 'RJ', '21 97564-6743')

insert into Anuncio
values 
(1, 'Carro', 'Corsinha rebaixado', 'SP', '11 98244-1222', 555),
(2, 'Carro', 'Saveiro com paredão', 'SP', '11 94756-7832', 556),
(3, 'Carro', 'Taxi amarelo', 'RJ', '21 97564-6743', 557)

select * from Anuncio 
where Regiao like 'SP'
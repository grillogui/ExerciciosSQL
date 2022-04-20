use db_ecomerce

create table Usuarios 
(
id_usuarios int primary key not null,
nome varchar(100) not null,
email varchar(50) not null,
Senha varchar(100) not null,
CPF varchar(15) not null
)

Create Table Produtos
(
id_produtos int primary Key not null,
preco float not null,
quantidade int not null,
categoria varchar(50) null,
tipo_de_pagamento varchar(50) not null,
FK_id_usuarios int not null,
foreign key (FK_id_usuarios) references Usuarios (id_Usuarios)
)

create table entrega 
(
id_Entrega int primary key not null,
descricao varchar(100) not null,
previsao_de_Entrega varchar(50) not null,
FK_id_usuarios int not null,
FK_id_produtos int not null,
foreign key (FK_id_Usuarios) references Usuarios (id_usuarios),
foreign key (FK_id_produtos) references Produtos (id_produtos)
)

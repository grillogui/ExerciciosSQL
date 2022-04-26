create database db_classificados
use db_classificados

create table Usuario
(
id_usuario int primary key not null,
CPF_CNPJ varchar(20) not null,
Tipo varchar(20),
Regiao varchar(50),
Contato varchar(20)
)
create table Anuncio
(
id_Anuncio int primary key not null,
Classificacao varchar(50),
Descricao varchar(50),
Regiao varchar(50),
Contato varchar(20),
FK_id_usuario int not null,
foreign key (FK_id_usuario) references Usuario (id_usuario)
)
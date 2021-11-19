CREATE DATABASE db3camadas;
USE db3camadas;

CREATE TABLE tbl_Artista
(
    id int not null AUTO_INCREMENT PRIMARY KEY,
    NomeArtista varchar(45) not null,
    Email VARCHAR(100) NOT NULL,
    senha varchar(45) not null
);

CREATE TABLE tbl_Postagem
(
	idPostagem INT AUTO_INCREMENT PRIMARY KEY,
    comentario Varchar(999) not null
);

CREATE TABLE tbl_Avaliação
(
    idArte INT AUTO_INCREMENT PRIMARY KEY,
    NomeArte VARCHAR(45) not null,
    Avaliação Varchar(45) not null,
    ComentarioAvalia varchar(999)
);
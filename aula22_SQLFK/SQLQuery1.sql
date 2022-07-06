CREATE DATABASE Escola;

USE Escola;



CREATE TABLE Instituicao(
Id int primary key,
Nome varchar(100),
Endereco varchar(200),
CNPJ int
);

CREATE TABLE AlunoOFICIAL(
Id int primary key,
Id_Instituicao int,
Nome varchar(100),
Sobrenome varchar(100),
Matricula int
constraint FK_AlunoOFICIAL_Instituicao
foreign key (Id_Instituicao) references Instituicao(Id)
);

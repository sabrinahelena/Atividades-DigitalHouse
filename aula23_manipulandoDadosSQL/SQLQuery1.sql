CREATE DATABASE Catalogo
 
 -- Cria��o de tabelas
 create table Filme 
 (
 id int primary key identity,
 nome varchar(45) not null,
 [data de lan�amento] date not null,
 duracao int not null
)

create table Ator
(
id int primary key identity,
nome varchar(45) not null,
sobrenome varchar(45) not null

)

create table filme_ator 
(
id int primary key identity,
id_filme int,
id_ator int,

constraint fk_filme 
foreign key (id_filme) references Filme(id),

constraint fk_ator 
foreign key (id_ator) references Ator(id)
)

-- Inser��o de valores

INSERT INTO Filme VALUES 
('Thor: Amor e trov�o', '2022-07-07', 120),
('O Homem do Norte', '2022-05-12', 137),
('O Homem nas Trevas', '2016-09-08', 88)

INSERT INTO Ator VALUES
('Stephen', 'Lang'),
('Jane', 'Levy'),
('Dylan', 'Minnette'),
('Daniel', 'Zavatto'),
('Natalie', 'Portman'),
('Christian', 'Bale'),
('Chris', 'Hemsworth'),
('Matt', 'Damon'),
('Russel', 'Crowe'),
('Anya', 'Taylor-Joy'),
('Alexander', 'Skarsgard'),
('Willian', 'Defoe'),
('Nicole', 'Kidman'),
('Ethan', 'Hawke')


-- SELE��O

SELECT * FROM Filme order by nome asc -- Filmes em ordem alfab�tica 
SELECT * FROM Filme order by [data de lan�amento] desc -- Ordem decrescente de data de lan�amento
SELECT * FROM Ator order by nome asc -- Atores em ordem alfab�tica

-- Criar alias/apelido para tabela

select a.nome from Ator a;

-- Criar alias/apelido de colunas
select f.nome as 'Nome do Filme' ,
f.[data de lan�amento] as 'Data do lan�amento'

from Filme f;

-- Juntar duas tabelas

select a.nome + ' ' + a.sobrenome as 'Nome do ator' from Ator a;

-- Consultas

select nome, sobrenome from ator where nome = 'jane'
select nome, sobrenome from ator where nome like 'j%' -- Puxa todos nomes que come�am com J
select nome, sobrenome from ator where nome like 'a%'-- Puxa todos nomes que come�am com A
select nome, sobrenome from ator where nome like '%a' -- Puxa todos nomes que terminam com A
select nome, sobrenome from ator where nome like '%a%' -- puxa todos nomes que possuem A no nome

-- INSERT na tabela de muitos pra muitos
insert into filme_ator(id_filme, id_ator)	values 		(1, 5),		(1, 6),		(1, 7),		(1, 8),		(1, 9),		(2, 10),		(2, 11),		(2, 12),		(2, 13),		(2, 14),		(3, 1),		(3, 2),		(3, 3);


-- Consulta em m�ltiplas tabelas

select * from filme_ator

select * from filme_ator at, filme, ator
where at.id_filme = filme.id and at.id_ator = ator.id
-- onde o id_filme = filme.id ou seja, vai igualar o ID do filme com o ID_Filme da tabela m�ltipla, trazendo a rela��o.

select a.nome + ' ' + a.sobrenome as 'Nome do ator', 
f.nome as 'Nome do filme', 
year(f.[data de lan�amento]) as 'Ano de lan�amento'
from filme_ator fa, filme f, ator a
where
fa.id_filme = f.id and fa.id_ator = a.id










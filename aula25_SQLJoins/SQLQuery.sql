-- Criei banco de dados
create database maternidade;

-- Criei tabela mam�e
create table mamae(
	id int identity,
	nome varchar(50) not null

	constraint Pk_mamae primary key (id)
);

-- Criei a tabela beb�
create table bebe(
	id int identity,
	nome varchar(50) not null,
	data_nascimento date not null,
	hora_nascimento time not null,
	id_mae int not null

	constraint Pk_bebe primary key (id)
	
	-- Criei uma FK para tabela mam�e
	constraint Fk_mae foreign key (id_mae)
	references mamae(id)
);

-- Inserir os valores da tabela mam�e
insert into mamae (nome)
values 
	('Helena'),
	('Alice'),
	('Laura'),
	('Manuela'),
	('Valentia'),
	('Sophia'),
	('Isabella'),
	('Helo�sa'),
	('Luiza'),
	('J�lia'),
	('Lorena'),
	('L�via'),
	('Maria Lu�sa'),
	('Cec�lia'),
	('Elo�'),
	('Lucicreide'),
	('Giovanna'),
	('Maria Clara'),
	('Maria Eduarda'),
	('Mariana'),
	('Lara'),
	('Beatriz'),
	('Antonella'),
	('Maria J�lia'),
	('Emanuelly'),
	('Isadora'),
	('Ana Clara'),
	('Melissa'),
	('Ana Luiza'),
	('Rosanea'),
	('Eliane'),
	('Beatriz'),
	('Vanusa'),
	('Eduarda'),
	('Maria Eduarda'),
	('Monique');


-- Inserir os valores da tabela beb�
insert into bebe 
values 
	('Miguel', '2022-03-01', '14:00:00', 1),
	('Arthur', '2022-03-27', '01:00:00', 2),
	('Th�o', '2022-03-29', '05:47:00', 3),
	('Heitor', '2022-04-05', '02:00:00', 4),
	('Gael', '2022-04-05', '02:00:00', 5),
	('Davi', '2022-04-05', '02:00:00', 6),
	('Bernardo', '2022-04-05', '08:00:00', 7),
	('Gabriel', '2022-04-05', '09:00:00', 8),
	('Ravi', '2022-05-06', '12:00:00', 9),
	('Noah', '2022-05-15', '16:00:00', 10),
	('Samuel', '25/07/2022', '16:00', 11),
	('Pedro', '26/07/2022', '10:00', 12),	('Ben�cio', '29/07/2022', '17:42', 13),	('Benjamin', '29/07/2022', '18:11', 14),	('Matheus', '01/08/2022', '11:11', 15),	('Isaac', '01/08/2022', '11:11', 16),
	('Anthony', '05/08/2022', '11:12', 17),	('Joaquim', '12/08/2022', '05:22', 18),	('Lucas', '12/08/2022', '08:29', 19),	('Lorenzo', '27/08/2022', '08:31', 20),
	('Rafael', '27/08/2022', '13:14', 21),	('Nicolas', '28/09/2022', '13:16', 22),	('Henrique', '30/08/2022', '19:01', 23),	('Murilo', '30/08/2022', '23:59', 24),	('Jo�o Miguel', '31/08/2022', '23:40', 25),
	('Lucca', '31/08/2022', '23:12', 26),	('Guilherme', '31/08/2022', '10:12', 27),	('Henry', '31/08/2022', '13:19', 28),	('Bryan', '31/08/2022', '12:57', 29),
	('Caroline', '2022-09-08', '14:00', 30),
	('Iasmin', '2022-09-27', '01:00', 31),
	('Ma�ra', '2022-09-29', '05:47', 32),
	('Eloar', '2022-10-05', '02:00', 33),
	('Patr�cia', '2022-11-05', '02:00', 34);

	insert into bebe values
	('Daiane', '2022-05-07', '03:00', null),
	('Vitor', '2022-08-12', '05:30', null);
	




-- Todas as beb�s nascidas entre 01/06/2022 e 30/07/2022
select 
	b.nome as 'Nome do beb�',
	m.nome as 'Nome da mam�e',
	b.data_nascimento as 'Data nascimento'
	from bebe b, mamae m
		where b.id_mae = m.id 
		and
		b.data_nascimento
			between '2022-06-01' and '2022-07-30';

-- Todos os beb�s por ordem alfab�tica 
select 
	b.nome as 'Nome do beb�',
	m.nome as 'Nome da mam�e',
	b.data_nascimento as 'Data nascimento'
	from bebe b, mamae m
		where
		b.id_mae = m.id
	
	order by b.nome asc;

-- O beb� da mam�e Elo�
select 
	b.nome as 'Nome do beb�',
	m.nome as 'Nome da mam�e',
	b.data_nascimento as 'Data nascimento'
	from bebe b, mamae m
		where 
			b.id_mae = m.id
			and m.nome like 'elo�';


-- Todas as beb�s nascidas entre 01/05/2022 e 30/10/2022 que n�o possua uma m�e cadastrada no banco de dados.
select 
	b.nome as 'Nome do beb�',
	m.nome as 'Nome da mam�e',
	b.data_nascimento as 'Data nascimento',
	b.hora_nascimento as 'Hora de nascimento'
	from bebe b	
	left JOIN 
	mamae m on 
		b.id_mae = m.id 
	where
	b.id_mae is null
			and
		data_nascimento between '2022-05-01' and '2022-10-30'
	
-- Todos os beb�s por ordem alfab�tica 
select 
	b.nome as 'Nome do beb�',
	m.nome as 'Nome da mam�e',
	b.data_nascimento as 'Data nascimento',
	b.hora_nascimento as 'Hora de nascimento'
	from bebe b, mamae m 
	where
	b.id_mae = m.id  
	order by b.nome
		
-- Todos os beb�s que nasceram no mesmo hor�rio CANCELADO

SELECT hora_nascimento, count(*) from bebe group by hora_nascimento having count(*)>1 

SELECT bebe.hora_nascimento, count(bebe.hora_nascimento) from bebe group by  bebe.hora_nascimento


--Todos os beb�s que nasceram entre 22:00 e 5:00, que n�o possuem m�e no cadastro.

select 
	b.nome as 'Nome do beb�',
	m.nome as 'Nome da mam�e',
	b.data_nascimento as 'Data nascimento',
	b.hora_nascimento as 'Hora de nascimento'
	from bebe b	
	left JOIN 
	mamae m on 
		b.id_mae = m.id 
	where
	(hora_nascimento BETWEEN '00:00' AND '05:00' OR hora_nascimento BETWEEN '22:00' AND '23:59' )
		and 
		b.id_mae is null




--Todas as mam�es que possuem cadastro, mas com beb�s cadastrados  01/05/2022 e 30/07/2022 no banco de dados.
select 
	b.nome as 'Nome do beb�',
	m.nome as 'Nome da mam�e',
	b.data_nascimento as 'Data nascimento',
	b.hora_nascimento as 'Hora de nascimento'
	from bebe b, mamae m 
	where
	b.id_mae = m.id  
	and
	data_nascimento between '2022-05-01' and '2022-07-30'
	
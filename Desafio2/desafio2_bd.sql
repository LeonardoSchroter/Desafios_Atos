create database controleProdutos_db

create table fornecedores
(
	idFornecedor int primary key identity,
	nome varchar(50) not null

);

insert into fornecedores values('coca-cola');
insert into fornecedores values('Cotonote');
insert into fornecedores values('Colgate');

create table produtos
(
	idProdutos int primary key identity,
	preco float not null,
	tipo varchar(20) not null,
	fk_idFornecedor int not null,
	--nome varchar(50)

	 CONSTRAINT fk_IdFonecedor FOREIGN KEY(fk_idFornecedor) REFERENCES fornecedores(idFornecedor) 
);

insert into produtos values(15,'higiene',3,'pasta de dente');
select * from fornecedores
select * from produtos


create table clientes
(
	idClientes int primary key identity,
	cpf varchar(20) not null,
	nome varchar(50) not null
);



insert into clientes values (043431247830,'Seu zé');

create table nota
(
	idNota int primary key identity,
	fk_idClientes int not null,
	fk_idProdutos int not null,
	--quantidade
	--valor
	--codigo
	
	constraint fk_idClientes foreign key(fk_idClientes) references clientes(idClientes),
	constraint fk_idProdutos foreign key(fk_idProdutos) references produtos(idProdutos),
	
);

alter table nota drop column valor;
alter table nota add quantidade int;
alter table nota add valor float;
alter table nota add codigo float;
alter table nota alter column codigo varchar(50);


select * from nota;



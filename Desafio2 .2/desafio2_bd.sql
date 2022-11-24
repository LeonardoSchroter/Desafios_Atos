

create table providers
(
	idFornecedor int primary key identity,
	nome varchar(50) not null

);

insert into providers values('coca-cola');
insert into providers values('Cotonote');
insert into providers values('Colgate');

drop table producs;
drop table clients;
drop table nota;
drop table fornecedores;

create table products
(
	idProdutos int primary key identity,
	preco float not null,
	tipo varchar(20) not null,
	fk_idFornecedor int not null,
	nome varchar(50),

	 CONSTRAINT fk_IdFonecedor FOREIGN KEY(fk_idFornecedor) REFERENCES providers(idFornecedor) 
);

insert into products values(15,'higiene',3,'pasta de dente');
select * from providers
select * from products


create table clients
(
	idClientes int primary key identity,
	cpf varchar(20) not null,
	nome varchar(50) not null
);



insert into clients values (043431247830,'Seu zé');

create table nota
(
	idNota int primary key identity,
	fk_idClientes int not null,
	fk_idProdutos int not null,
	quantidade int not null,
	valor float not null,
	codigo float not null,
	
	constraint fk_idClientes foreign key(fk_idClientes) references clients(idClientes),
	constraint fk_idProdutos foreign key(fk_idProdutos) references products(idProdutos),
	
);




select * from nota;
select * from providers;
select * from products;
select * from clients;


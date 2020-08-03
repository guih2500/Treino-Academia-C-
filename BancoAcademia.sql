create database academia default character set utf8mb4 default collate utf8mb4_general_ci;

create table Inicial(
	login varchar (50) not null,
    senha varchar (20) not null,
    acesso varchar (20) not null,
    primary key (login)
)default charset = utf8mb4;

create table cliente(
	cli_nome varchar(50) not null,
    cli_imc decimal(20) not null,
    cli_cpf varchar(20) not null,
    cli_data date not null,
    cli_pag varchar(20) not null,
    cli_ativo varchar(5) not null,
    primary key(cli_cpf)
)default charset = utf8mb4;

create table produtos(
	prod_id numeric(10) not null,
	prod_nome varchar(50) not null,
	prod_qtde numeric(3) not null,
    prod_cat varchar(20) not null,
    primary key(prod_id)
)default charset = utf8mb4;

create table movimenta(
	mov_id int auto_increment,
	mov_op varchar(20) not null,
    mov_desc varchar(50) not null,
    mov_clas varchar(50) not null,
    mov_for varchar(50) not null,
    mov_data date not null,
    mov_tipo varchar(30) not null,
    mov_val decimal(20,2) not null,
    primary key(mov_id)
)default charset = utf8mb4;

insert into Inicial (login, senha, acesso) values ('admin', 'admin', 'Gerente');
insert into Inicial (login, senha, acesso) values ('teste', 'teste', 'Recepção');
insert into produtos (prod_id, prod_nome, prod_qtde, prod_cat) values ('1', 'agua sanitaria', '3', 'limpeza');
insert into produtos (prod_id, prod_nome, prod_qtde, prod_cat) values ('6', 'candida', '3', 'limpeza');
insert into produtos (prod_id, prod_nome, prod_qtde, prod_cat) values ('7', 'veja', '1', 'limpeza');
insert into produtos (prod_id, prod_nome, prod_qtde, prod_cat) values ('8', 'sabão', '2', 'limpeza');
INSERT INTO cliente(cli_nome, cli_imc, cli_cpf, cli_data, cli_pag, cli_ativo) VALUES ('Guilherme', '26', '476,200,658-06', '1998-10-21', 'dinheiro', 's');
INSERT INTO cliente(cli_nome, cli_imc, cli_cpf, cli_data, cli_pag, cli_ativo) VALUES ('Guilherme', '26', '111,222,244-00', '1998-10-21', 'dinheiro', 's');

select * from cliente;
select * from inicial;
select * from produtos;
select * from movimenta;

drop table inicial;
drop table cliente;
drop table produtos;

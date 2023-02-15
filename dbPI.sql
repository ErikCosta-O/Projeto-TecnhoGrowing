drop database dbPI;

create database dbPI;	

show databases;

use dbPI;


create table tbFuncionario(
codFunc int auto_increment,
Nome varchar(45) not null,
CPF varchar (16) unique not null,
dataNascimento date not null,
CTPS varchar(35) unique not null,
Serie varchar(4) not null,
Tel varchar(15) not null,
Email varchar(45) not null,
Endereco varchar(80)not null,
Numero varchar(7) not null,
Complemento varchar(45) not null,
CEP varchar(10) not null,
Bairro varchar(45) not null,
Cidade varchar(45) not null,
Cargo varchar(15) not null,
primary key (codFunc)
);


create table tbUsuario(
codUsuario int auto_increment,
Login varchar(20) unique not null,
Senha varchar(100) not null,
codFunc int not null,
primary key (codUsuario),
foreign key (codFunc) references tbFuncionario (codFunc)
);

create table tbVoluntario(
codVoluntario int auto_increment,
Nome varchar(45) not null,
dataNascimento date not null,
Email varchar (100) not null,
Senha varchar(45) not null,
CPF varchar(16) unique not null,
Tel varchar(45) not null,
Experiencia varchar(12),
RedeSocial varchar (20),
Url varchar(100),
primary key (codVoluntario)
);

create table tbONG(
codONG int auto_increment,
Nome varchar(45) not null,
Email varchar(100) not null,
Senha varchar(100) not null,
Tel varchar(18) not null,
CNPJ varchar(25),
Endereco varchar(100) not null,
Numero varchar (10) not null,
Complemento varchar(40)not null,
CEP varchar(10) not null,
Bairro varchar(45) not null,
Cidade varchar(45) not null,
Categoria varchar(15) not null,
Descricao varchar(150) not null,
WebSite varchar (75),
RedeSocial varchar (35),
Url varchar(100),
primary key (codONG)
);

create table tbLoja(
codLoja int auto_increment,
nomeProduto varchar(45) not null,
Valor varchar (10) not null,
Quantidade varchar (5) not null,
Descricao varchar(45) not null,
codFunc int not null,
primary key (codLoja),
foreign key (codFunc) references tbFuncionario (codFunc)
);


create table tbVenda(
codVenda int not null auto_increment,
cpfCliente varchar(15) not null,
nomeprodutoVenda varchar(45) not null,
valorVenda varchar (10) not null,
quantidadeVenda int not null,
dataVenda date not null,
Pagamento varchar(50) not null,
codFunc int not null,
codLoja int not null,
primary key (codVenda),
foreign key (codFunc) references tbFuncionario (codFunc),
foreign key (codLoja) references tbLoja (codLoja)
);

create table tbContato(
codContato int not null auto_increment,
Nome varchar(155) not null,
Email varchar(155) not null,
Mensagem varchar(255) not null,
primary key(codContato)
);




desc tbFuncionario;

insert into tbFuncionario (Nome,CPF,dataNascimento,CTPS,Serie,Tel,Email,Endereco,Numero,Complemento,CEP,Bairro,Cidade,Cargo) values('Thaina Araujo','123.456.788-10','1980.01.25','907.54875.46-1','3554','(11)1234-5578','thaina@tg.com','Av Paulista','12','Apt 1','0471-000','Consolacao','Sao Paulo','Administrador');
insert into tbFuncionario (Nome,CPF,dataNascimento,CTPS,Serie,Tel,Email,Endereco,Numero,Complemento,CEP,Bairro,Cidade,Cargo) values('Victoria Amorim','123.456.689-10','1982.02.17','108.95086.55-4','1254','(11)1233-5678','victoria@tg.com','Av Morumbi','22','Casa 4','04751-000','Ibirapuera','Sao Paulo','Administrador');
insert into tbFuncionario (Nome,CPF,dataNascimento,CTPS,Serie,Tel,Email,Endereco,Numero,Complemento,CEP,Bairro,Cidade,Cargo) values ('Erik Costa de Oliveira','123.156.589-10','1984.02.17','122.10001.15-7','1478','(11)1244-5771','erik@tg.com','Av Pacaembu','145','Apt 12','04751-000','Vista Bela','Sao Paulo','Loja');
insert into tbFuncionario (Nome,CPF,dataNascimento,CTPS,Serie,Tel,Email,Endereco,Numero,Complemento,CEP,Bairro,Cidade,Cargo) values ('Caio Cesar Consiglio','123.451.589-12','1980.02.17','113.10001.13-2','1458','(11)1233-5777','caio@tg.com','Av Moema','912','Casa 5','04741-000','Brooklin','Sao Paulo','SAC');
insert into tbFuncionario (Nome,CPF,dataNascimento,CTPS,Serie,Tel,Email,Endereco,Numero,Complemento,CEP,Bairro,Cidade,Cargo) values ('Jose Hugo','000.000.000-11','1997.05.31','100.10001.17-1','2147','(11)1233-5645','jose@tg.com','Rebouca','254','Apt 12','04751-185','Oscar Freire','Sao Paulo','SAC');

--update  tbFuncionario  set Tel ='(11)55555-0000',Email ='Fulano@gmail.com',Endereco='Av Paulista',Numero = '444',Complemento= 'Casa 1',CEP='01311-100',Bairro='Vela Vista',Cidade='São Paulo',Cargo='Administrador' where registroFunc = 5--

select * from tbFuncionario;

desc tbUsuario;

insert into tbUsuario (Login,Senha,codFunc) values ('admin-thai','gabrielti104',1);
insert into tbUsuario (Login,Senha,codFunc) values ('admin-vick','photografic',2);
insert into tbUsuario (Login,Senha,codFunc) values ('dev-erick','motorista',3);
insert into tbUsuario (Login,Senha,codFunc) values ('sac-caio','cabeloblue',4);	
insert into tbUsuario (Login,Senha,codFunc) values ('sac-jhss','l0s3',5);

select * from tbUsuario;


desc tbVoluntario;

insert into tbVoluntario (Nome,dataNascimento,Email,Senha,CPF,Tel,Experiencia,RedeSocial,Url) values ('Erik Oliveira','1997-06-27','Erick.O@senacsp.com',SHA1('12345'),'111.111.111-11','(11)91234-5678','Iniciante','Github','');
insert into tbVoluntario (Nome,dataNascimento,Email,Senha,CPF,Tel,Experiencia,RedeSocial,Url) values ('Herick Cesar','1996-08-31','Herick.C@senacsp.com',SHA1('123456'),'111.111.111-12','(11)91234-5659','Iniciante','Github','');
insert into tbVoluntario (Nome,dataNascimento,Email,Senha,CPF,Tel,Experiencia,RedeSocial,Url) values ('Wesley','1994-12-25','Wesley@senacsp.com',SHA1('123457'),'111.111.111-13','(11)91234-5648','Iniciante','Linkdlin','');
insert into tbVoluntario (Nome,dataNascimento,Email,Senha,CPF,Tel,Experiencia,RedeSocial,Url) values ('Gabriel Souza','1990-12-24','gabriel.S@senacsp.com',SHA1('123459'),'111.111.111-17','(11)91234-5677','Iniciante','Github','');


select * from tbVoluntario;

desc tbONG;

insert into tbONG (Nome,Email,Senha,Tel,CNPJ,Endereco,Numero,Complemento,CEP,Bairro,Cidade,Categoria,Descricao,WebSite,RedeSocial,Url) values('Arroz e Feijao','bomprato@mail.com',SHA1('@%#S215548R'),'(11)1234-5678','63.958.777/0001-83','Av Paulista','254','Conj AB445','04341-010','Bela Vista','São Paulo','Alimentacao','Alimento para todos','','Instagram','@BoaComida');
insert into tbONG (Nome,Email,Senha,Tel,CNPJ,Endereco,Numero,Complemento,CEP,Bairro,Cidade,Categoria,Descricao,WebSite,RedeSocial,Url) values('TrapoChique','doeroupa@mail.com',SHA1('@#488#$'),'(11)1234-4478','','Av 23 de Maio','22','Conj 144','04751-040','Heliopolis','São Paulo','Vestimento','Roupa para todos','www.wordpress.trapochique.com','Instagram','@TrapoChique');

select * from tbONG;


desc tbLoja;

insert into tbLoja (nomeProduto,Valor,Quantidade,Descricao,codFunc) values('Bolsa','R$30,00','10','Feita de materiais reciclaveis',2);
insert into tbLoja (nomeProduto,Valor,Quantidade,Descricao,codFunc) values('Camiseta','R$ 30,00','30','Feita de materiais reciclaveis',1);
insert into tbLoja (nomeProduto,Valor,Quantidade,Descricao,codFunc) values('Pagina Exclusiva','R$ 30,00','30','Material de apoio e conteudo exclusivo',2);
insert into tbLoja (nomeProduto,Valor,Quantidade,Descricao,codFunc) values('Oculos','R$15,00','30','Armacao de Oculos',1);
insert into tbLoja (nomeProduto,Valor,Quantidade,Descricao,codFunc) values('Chaveiro','R$10,00','30','Chaveiro Personalizado',2);
insert into tbLoja (nomeProduto,Valor,Quantidade,Descricao,codFunc) values('Case de Celular','R$10,00','30','Diversos modelos',2);
insert into tbLoja (nomeProduto,Valor,Quantidade,Descricao,codFunc) values('Caderno','R$15,00','30','20 Materias e 160 Folhas',2);
insert into tbLoja (nomeProduto,Valor,Quantidade,Descricao,codFunc) values('Acesso VIP','R$25,00','10','Eventos e Palestras',1);

select * from tbLoja;


desc tbVenda;
insert into tbVenda(cpfCliente,nomeprodutoVenda,valorVenda,quantidadeVenda,dataVenda,Pagamento,codFunc,codLoja) values('415.875.987-78','Bolsa','R$30,00',1,'2022.12.27','Debito',1,1);
select * from tbVenda;


desc tbContato;
insert into tbContato (Nome,Email,Mensagem) values ('Fulano','fulalo@mail.com','No meu xinélo da humildade eu gostaria muito de ver o Neymar e o Ganso. Por que eu acho que.... 11 entre 10 brasileiros gostariam. Você veja, eu já vi, parei de ver. Voltei a ver, e acho que o Neymar e o Ganso têm essa capacidade de fazer a gente olhar.

Se hoje é o dia das crianças... Ontem eu disse: o dia da criança é o dia da mãe, dos pais, das professoras, mas também é o dia dos animais, sempre que você olha uma criança, há sempre uma figura oculta, que é um cachorro atrás. O que é algo muito importante!

Ai você fala o seguinte: "- Mas vocês acabaram isso?" Vou te falar: -"Não, está em andamento!" Tem obras que "vai" durar pra depois de 2010. Agora, por isso, nós já não desenhamos, não começamos a fazer projeto do que nós "podêmo fazê"? 11, 12, 13, 14... Por que é que não?');
select * from tbContato;	
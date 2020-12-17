create database CF_BOX_Final

use CF_BOX_Final

create table Usuario(

	WOD int,
	userID nvarchar(50),
	loginName nvarchar(50),
	PassW nvarchar(50),

	constraint pk_WOD primary key (WOD),
)

create table Registro(

	idRegistro int,
	WOD int,

	constraint pk_idRegistro primary key (idRegistro),
	constraint fk_idWOD foreign key (WOD) references Usuario(WOD)
)

create table Personal(

	idPersonal int,
	Nombre nvarchar(30),
	Apellido nvarchar(50),
	Edad int,
	Direccion nvarchar(70),
	Telefono nvarchar(20),
	Correo nvarchar(70),
	Puesto nvarchar(70),
	idRegistro int,

	constraint pk_idPersonal primary key (idPersonal),
	constraint fk_idRegistro foreign key (idRegistro) references Registro(idRegistro)
)

create table Material(

	idMaterial int,
	Nombre nvarchar(40),
	Cantidad int,
	Stock int,
	idRegistro int,

	constraint pk_idMaterial primary key (idMaterial),
	constraint fk_idRegistroM foreign key (idRegistro) references Registro(idRegistro)
)

create table Clases(

	idClases int,
	Dia nvarchar(30),
	HorarioInicio nvarchar(30),
	horarioFinaliza nvarchar(30),
	idRegistro int,
	
	constraint pk_idClase primary key (idClases),
	constraint fk_idRegistroC foreign key (idRegistro) references Registro(idRegistro)
)


create table Cliente(

	idCliente int,
	Nombre nvarchar(30),
	Apellido nvarchar(50),
	Edad int,
	Direccion nvarchar(70),
	Telefono nvarchar(20),
	Correo nvarchar(70),
	idClases int,
	
	constraint pk_idCliente primary key (idCliente),
	constraint fk_idClases foreign key (idClases) references Clases(idClases)
)


insert into Usuario VALUES ('1','1','francisco','1234567')
insert into Registro VALUES ('1','1')
insert into Personal VALUES ('1','francisco','Ortiz','21','Direccion','1234567','frO@gmail.com','Dueño','1')
insert into Personal VALUES ('2','Emmanuel','Barajas','21','Direccion2','1234567','EmB@gmail.com','Gerente','1')
insert into Personal VALUES ('3','Robert','Cruz','21','Direccion3','1234567','RoC@gmail.com','Encargado','1')
insert into Material VALUES ('1','Ketter Bell','1','12','1')
insert into Material VALUES ('2','Box','2','12','1')
insert into Clases VALUES ('1','Lunes','8:00 PM','9:00 PM','1')


insert into Cliente VALUES ('1','Geli','Olmedo','24','Direccion2','123456789','geo@gmail.com','1')
insert into Cliente VALUES ('2','Marco','Ramirez','27','Direccion1','123456789','MaR@gmail.com','1')
insert into Usuario VALUES ('2','2','ivan','10');

insert into Usuario VALUES ('3','3','admin','admin');
insert into Registro VALUES ('2','2');
insert into Registro VALUES ('3','3');
insert into Clases VALUES ('0','Sin asignar','Sin horario','Sin horario','1');


drop database CF_BOX_Final;

use master;
create database inventario
go

use inventario
go

create table TipoCategoria(
	id_tipo_categoria int primary key,
	nombre_categoria varchar(60),
	habilitar_tipo bit
);

create table Sucursal(
	id_sucursal int primary key,
	nombre_sucursal varchar(60),
	telefono_sucursal varchar(15),
	habilitar_sucursal bit
);

create table Usuarios(
	id_usuario int primary key,
	nombre_usuario varchar(60),
	apellido_usuario varchar(60),
	username varchar(60),
	clave varchar(20)
);

create table Electrodomesticos(
	id_electrodomestico int primary key,
	nombre_electrodomestico varchar(50),
	id_tipo_categoria int not null,
	habilitar_producto bit,
	CONSTRAINT fk_tipo_categoria FOREIGN KEY (id_tipo_categoria) REFERENCES TipoCategoria(id_tipo_categoria)
);

create table SucursaElectrodomestico(
	id_sucursal_electrodomestico int primary key,
	id_sucursal int not null,
	id_electrodomestico int not null,
	cantidad_inventario int,
	CONSTRAINT fk_sucursal FOREIGN KEY (id_sucursal) REFERENCES Sucursal(id_sucursal),
	CONSTRAINT fk_electrodomestico FOREIGN KEY (id_electrodomestico) REFERENCES Electrodomesticos(id_electrodomestico)
);

create table inventario(
	id_inventario int primary key,
	id_sucursal_electrodomestico int not null,
	cantidad_entradas_salidas int,
	movimiento varchar(10)
	CONSTRAINT fk_sucursal_electrodomestico FOREIGN KEY (id_sucursal_electrodomestico) REFERENCES SucursaElectrodomestico(id_sucursal_electrodomestico)
);
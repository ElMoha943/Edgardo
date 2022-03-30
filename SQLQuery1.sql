USE dashboard

create table Producto (
	id int primary key identity(1,1),
	nombre varchar,
	precio decimal,
	stock int
);

create table Venta (
	id int primary key identity(1,1),
	fecha datetime,
	total decimal
);

create table Venta_Productos(
	id_venta int primary key,
	id_producto int,
	cant_producto int
);
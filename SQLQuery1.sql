create table persona
(
idpersona int primary key,
nombre varchar(20) not null,
apellido varchar(20)not null,
telefono varchar (20)not null,
ci varchar(20)not null,
correo varchar(20)not null,
estado varchar(20)not null,
);
create table usuario
(
idusuario int primary key,
idpersona int not null,
nombreuser varchar(20) not null,
contraseña varchar(20)not null,
fechareg datetime not null,
foreign key(idpersona) references persona(idpersona)
);
create table rol
(
idrol int primary key,
nombre varchar(20) not null,
estado varchar(20)not null,
);
create table usuariorol
(
idusuariorol int primary key,
idusuario int not null,
idrol int not null,
fechaasigna datetime not null,
estado varchar (20)not null,
foreign key(idusuario) references usuario(idusuario),
foreign key(idrol) references rol(idrol)
);
create table cliente
(
idcliente int primary key,
idpersona int not null,
tipocliente varchar(20) not null,
codigocliente varchar(20)not null,
estado varchar(20)not null,
foreign key(idpersona) references persona(idpersona),
);
create table venta
(
idventa int primary key,
idcliente int not null, 
idvendedor int not null,
fecha datetime not null,
total varchar(20) not null,
estado varchar(20) not null,
foreign key(idcliente) references cliente(idcliente),
foreign key(idvendedor) references usuario(idusuario)
);
create table tipoprod
(
idtipoprod int primary key,
nombre varchar(20) not null,
estado varchar(20) not null,
);
create table marca
(
idmarca int primary key,
nombre varchar(20) not null,
estado varchar(20) not null,
);
create table producto
(
idproducto int primary key,
idtipoproducto int not null,
nombre varchar(20) not null,
codigobarra varchar(20) not null,
idmarca int not null,
unidad varchar(20) not null,
descripcion varchar(20) not null,
estado varchar(20) not null,
foreign key (idtipoproducto) references tipoprod(idtipoprod), 
foreign key (idmarca) references marca(idmarca)
);
create table detallevent
(
iddetallevent int primary key,
idventa int not null,
idproducto int not null,
cantidad varchar(20) not null,
precioventa varchar(20) not null,
subtotal varchar(20) not null,
estado varchar(20) not null,
foreign key(idventa) references venta(idventa),
foreign key (idproducto) references producto(idproducto)
);
create table proveedor
(
idproveedor int primary key,
nombre varchar(20) not null,
telefono varchar(20) not null,
direccion varchar(20) not null,
estado varchar(20) not null,
);
create table ingreso
(
idingreso int primary key,
idproveedor int not null,
fechaingreso datetime not null,
total varchar(20) not null,
estado varchar(20) not null,
foreign key (idproveedor) references proveedor(idproveedor)
);
create table detalleing
(
iddetalleing int primary key,
idproducto int not null,
idingreso int not null,
fechavenc datetime not null,
cantidad varchar(20) not null,
preciocosto varchar(20) not null,
precioventa varchar(20) not null,
subtotal varchar(20) not null,
estado varchar(20) not null,
foreign key (idproducto) references producto(idproducto),
foreign key (idingreso) references ingreso(idingreso),
)
create table provee
(
idprovee int primary key,
idproducto int not null,
idproveedor int not null,
fecha varchar(20) not null,
precio varchar(20) not null,
foreign key(idproducto) references producto(idproducto),
foreign key(idproveedor) references proveedor(idproveedor)
);
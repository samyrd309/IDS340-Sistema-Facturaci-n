create database bdFacturacion
use bdFacturacion

-- Tabla inventario --
create table tblInventario
(
codigo int primary key,
nombre varchar(120),
precio money,
cantidad tinyint
)

insert into tblInventario values
(125693 ,'Mouse Ergonomico Logitech MX Vertical Advance', 4602.00, 1),
(158965, 'Mouse Inalámbrico M720 Triathlon 2.4GHZ ', 3127.00, 1),
(198654, 'Teclado K480 Bluetooth Negro', 3245.00, 1),
(169742, 'Teclado Microsoft Todo en 1', 2419.00, 1),
(145863, 'Headset Netsys Stereo/USB c/Micrófono', 1770.00 , 1),
(114789, 'Headset Inalámbrico Palladium Xtech c/Mic BG', 1121.00, 1),
(176548, 'Bulto Dell Pro 15', 2891.00, 1),
(104589, 'Mochila Dell 15.0" Pro Slim', 2714.00, 1),
(231586, 'Lenovo C530 Cubo GAMING Core i5-9400 2.9GHz 1TB+128GB 8GB GTX 1060Ti 6GB', 55000.00, 1),
(231547, 'Lenovo IdeaCentre Y900 RE Intel Core i7 6th 4.00GHz 16GB 256GB SSD 2TB HDD GTX 1080 8GB WIN10', 75000.00, 1),
(231552, 'Lenovo LEGION T5 28IMB05 Core i5-10400F 1TB+256GB 16GB GTX 1660 6GB', 50000.00, 1),
(231519, 'Lenovo 720-18APR AMD Ryzen 7 3.2GHz 2TB+128GB 16GB WIN10 AMD RX 560 4G', 40000.00, 1),
(231512, 'Dell Monitor 32" D3218HN', 15000.00, 1),
(231584, 'Lenovo T27i-10 ThinkVision 27" FHD (1920x1080) IPS Monitor', 15000.00, 1),
(231572, 'Monitor Acer 32'' ET322QR Curvo FHD 1080p 4ms Gaming', 20000.00, 1),
(231591, 'MSI OPTIX G241VC Curved 24" FHD 1ms 75Hz VGA HDMI AMD FreeSync Anti-Glare Backlit', 16000.00, 1),
(222846, 'Samsung Galaxy TAB A 8" QC/32GB B (SM-T290)', 9794.00, 1),
(222844, 'Tablet Samsumg Galaxy Tab A7 10.4"(SM-T500NZSAGTO)', 16107.00, 1),
(222803, 'Tablet Microsoft Surface Pro 12.3" CI3/4GB/128GB S', 59295.00, 1),
(222819, 'Cargador Portátil Klipx Slim Enox 2.1 A (KBH-140SV', 649.00, 1),
(222856, 'Power Bank Argom 2500mAh (ARG-AC-0233L)', 354.00, 1),
(222843, 'Adaptador Wifi Sabrent VF-RADU', 1357.00, 1),
(222877, 'Base Argom p/Celular de Carro (ARG-AC-0325)', 324.50, 1),
(222813, 'Cargador Maxell USB CAR 1PT 2.4A Negro (347408)', 383.00, 1)

select * from tblInventario

-- Tabla Factura --
create table tblFactura
(
codigoFactura tinyint identity (1,1),
empleado varchar(40),
nombreCliente varchar(40),
fechaEmision datetime,
tipoFactura varchar(25),
NCF varchar(15) default 'N/A',
subtotal money default 0.0,
impuesto money default 0.0,
totalPagar money default 0.0
)

select *from tblFactura
insert into tblFactura values ('','',10/10/2020,'',default, default, default, default)
insert into tblFactura values (1,'','',10/10/2021,'',default,15.00,15.00,15.00)

-- PROCEDIMIENTO CREAR FACTURA CONSUMIDOR FINAL
create proc procCrearFactura
@empleado varchar(40),
@nombreCliente varchar(40),
@fechaEmision date,
@tipoFactura varchar(25),
@subtotal money,
@impuesto money,
@totalPagar money
as
insert into tblFactura values (@empleado,@nombreCliente,@fechaEmision,@tipoFactura,default, @subtotal, @impuesto, @totalPagar)
go

-- PROCEDIMIENTO CREAR FACTURA CON NCF
create proc procCrearFacturaNCF
@empleado varchar(40),
@nombreCliente varchar(40),
@fechaEmision datetime,
@tipoFactura varchar(25),
@NCF varchar(15),
@subtotal money,
@impuesto money,
@totalPagar money
as
insert into tblFactura values (@empleado,@nombreCliente,@fechaEmision,@tipoFactura, @NCF, @subtotal, @impuesto, @totalPagar)
go

exec procCrearFacturaNCF '','','','','NCF'


-- Tabla DetalleFactura --
create table tblDetalleFactura
(
idControl tinyint identity (1,1),
empleado varchar(40),
nombreCliente varchar(40),
codigoArticulo int,
articulo varchar(120),
cantidad tinyint,
precio money,
totalArt as cantidad * precio,
NCF varchar(15) DEFAULT 'N/A',
razonSocial varchar(40),
fechaEmision datetime,
montoITBIS money default ' ',
totalPagar money default ' '
)

select *from tblDetalleFactura

-- PROCEDIMIENTO AGREGAR ARTÍCULOS
create proc procLlamarArt
@codigoArticulo int, @cantidad tinyint
as
insert into tblDetalleFactura (codigoArticulo, articulo, precio, cantidad)
select codigo, nombre, precio, cantidad
from tblInventario
where codigo like @codigoArticulo
update tblDetalleFactura set cantidad = @cantidad
where codigoArticulo like @codigoArticulo
go

-- PROCEDIMIENTO PARA MODIFICAR NCF
create proc procAgregarNCF
@codigoFactura tinyint, @NCF varchar(15)
as
update tblFactura set NCF = @NCF
where codigoFactura like @NCF
go 

exec procAgregarNCF 1,'1'

-- PROCEDIMIENTO PARA MOSTRAR ARTÍCULOS
create proc procMostrarArt
as
select articulo as 'Artículo', cantidad as 'Cantidad' , precio as 'Precio', totalArt as 'Total por artículo', NCF as 'NCF'
from tblDetalleFactura
go

-- PROCEDIMIENTO PARA VACIAR tblDetalleFactura
create proc procLimpiarDetalleFactura
as
truncate table tblDetalleFactura
go

-- PROCEDIMIENTO PARA ACTUALIZAR EL ITBIS Y TOTAL EN tblDetalleFactura
create proc procIngresarITBISTOTAL
@ITBIS money,
@Total money
as
update tblDetalleFactura set montoITBIS = @ITBIS, totalPagar = @Total 
go

-- PROCEDIMIENTO PARA MOSTRAR ARTÍCULOS
create proc procMostrarFactura
as
select articulo as 'Artículo', cantidad as 'Cantidad' , precio as 'Precio', totalArt as 'Total por artículo', NCF as 'NCF', montoITBIS as 'ITBIS', totalPagar as 'Total a pagar'
from tblDetalleFactura
go

select *from tblDetalleFactura
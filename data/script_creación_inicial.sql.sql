
---- E J E C U T A  E L  B A T  Q U E  G E N E R A  L A  TABLA  MAESTRA
-- EXEC master..xp_CMDShell 'D:\Mis Documentos\_UTN\Base de Datos\EjecutarScriptTablaMaestra.bat'
--- inserta 528444 registros en tabla gd_esquema.Maestra
--DROP SCHEMA [WHERE_EN_EL_DELETE_FROM]

CREATE SCHEMA [WHERE_EN_EL_DELETE_FROM]

/**** C R E A C I O N  T A B L A S  D E S T I N O  ****/
--DROP TABLE [WHERE_EN_EL_DELETE_FROM].hoteles
CREATE TABLE hoteles (
	id int IDENTITY(1,1) PRIMARY KEY, 
	nombre nvarchar(255) not null,
	mail varchar(255), 
	telefono varchar(255), 
	direccion nvarchar(255), 
	ciudad nvarchar(255),
	pais nvarchar(255), 
	estrellas_cant smallint, 
	estrellas_recargo smallint, 
	fecha_creacion datetime
)


INSERT INTO [WHERE_EN_EL_DELETE_FROM].hoteles (nombre, mail, telefono, direccion , ciudad, pais, 
		estrellas_cant, estrellas_recargo, fecha_creacion)
SELECT distinct
	'Hotel ' + Hotel_calle + ' ' + convert(varchar(255) ,Hotel_Nro_Calle) ,
		null,
		null,
		Hotel_calle + ' ' + convert(varchar(255) ,Hotel_Nro_Calle),
		Hotel_Ciudad,
		'Argentina', -- Las ciudades en la tabla maestra son todas de Argentina
		Hotel_CantEstrella,
		Hotel_Recarga_Estrella,
		getdate()
 from gd_esquema.Maestra
 
 

DROP TABLE [WHERE_EN_EL_DELETE_FROM].regimenes
CREATE TABLE [WHERE_EN_EL_DELETE_FROM].regimenes (
	id int IDENTITY(1,1) PRIMARY KEY, 
	codigo nvarchar(255), 
	descripcion nvarchar(255),
	precio numeric(18,2), 
	habilitado bit DEFAULT 1
)

INSERT INTO [WHERE_EN_EL_DELETE_FROM].regimenes (codigo, descripcion, precio, habilitado)
SELECT distinct
	--'REGIMEN_' + convert(varchar(255), ROW_NUMBER() OVER (ORDER BY (select Regimen_Descripcion))), -- Podemos pensar en hacer codigos tipo RMP: Regimen media pension, RAI: Regimen all inclusive. 
	'REGIMEN_' +  convert(varchar(255), RANK() OVER(order by (Select Regimen_Descripcion))), -- Ver esto para que tire un row_number sin repetir
	Regimen_Descripcion,
	Regimen_Precio,
	1
FROM
	gd_esquema.Maestra
	
	

-- Chequeo si hay reservas sin hotel asociado -> NO HAY
/* select * FROM gd_esquema.Maestra where isnull(gd_esquema.Maestra.Hotel_Nro_Calle, 0) = 0
		OR isnull(gd_esquema.Maestra.Hotel_Calle, '') = ''
 select * FROM gd_esquema.Maestra where isnull(gd_esquema.Maestra.Regimen_Descripcion, '') = ''
	*/

DROP TABLE [WHERE_EN_EL_DELETE_FROM].regimenes_hoteles
CREATE TABLE [WHERE_EN_EL_DELETE_FROM].regimenes_hoteles (
	hotel_id int NOT NULL,
	regimen_id int NOT NULL,
	CONSTRAINT FK_Hotel FOREIGN KEY (hotel_id) 
	REFERENCES [WHERE_EN_EL_DELETE_FROM].hoteles(id),
	CONSTRAINT FK_Regimen FOREIGN KEY (regimen_id)
	REFERENCES [WHERE_EN_EL_DELETE_FROM].regimenes (id)
)

INSERT INTO [WHERE_EN_EL_DELETE_FROM].regimenes_hoteles (hotel_id, regimen_id)
SELECT distinct
	hot.id,
	reg.id
FROM
	gd_esquema.Maestra m
inner join
	[WHERE_EN_EL_DELETE_FROM].regimenes reg on reg.descripcion = m.Regimen_Descripcion
inner join
	[WHERE_EN_EL_DELETE_FROM].hoteles hot on hot.nombre = 'Hotel ' + m.Hotel_calle + ' ' + convert(varchar(255), m.Hotel_Nro_Calle)



DROP TABLE [WHERE_EN_EL_DELETE_FROM].tipos_habitaciones
CREATE TABLE [WHERE_EN_EL_DELETE_FROM].tipos_habitaciones (	
	id int IDENTITY(1,1) PRIMARY KEY,
	codigo int,
	descripcion nvarchar(255) NOT NULL,
	porcentual numeric(18, 2),
	max_huespedes smallint
)

INSERT INTO [WHERE_EN_EL_DELETE_FROM].tipos_habitaciones (codigo, descripcion, porcentual, max_huespedes)
SELECT distinct 
	Habitacion_Tipo_Codigo, 
	Habitacion_Tipo_Descripcion, 
	Habitacion_Tipo_Porcentual, 
	NULL
FROM
	gd_esquema.Maestra
		



DROP TABLE [WHERE_EN_EL_DELETE_FROM].habitaciones
CREATE TABLE [WHERE_EN_EL_DELETE_FROM].habitaciones (	
	id int IDENTITY(1,1) PRIMARY KEY,
	hoteles_id int NOT NULL,
	numero numeric(18,0) NOT NULL,
	piso smallint,
    frente bit,
	descripcion nvarchar(255),
	habilitado bit,
	tipos_id int NOT NULL,
	CONSTRAINT FK_Habitaciones_Hotel FOREIGN KEY (hoteles_id) 
	REFERENCES gd_esquema.Hotel (id),
	CONSTRAINT FK_Habitaciones_Tipos FOREIGN KEY (tipos_id)
	REFERENCES gd_esquema.Tipos_Habitaciones (id))

INSERT INTO [WHERE_EN_EL_DELETE_FROM].habitaciones (
	Hoteles_id, 
	Numero, 
	Piso, 
	Frente, 
	Descripcion, 
	Habilitado, 
	Tipos_id
)
SELECT distinct
	hot.id,
	m.Habitacion_Numero,
	m.Habitacion_Piso,
	CASE WHEN m.Habitacion_Frente = 'N' THEN 0 ELSE 1 END,
	'',
	1,
	t.id
FROM
	gd_esquema.Maestra m
INNER JOIN
	[WHERE_EN_EL_DELETE_FROM].hoteles hot ON
	hot.nombre =  'Hotel ' + m.Hotel_calle + ' ' + convert(varchar(255), m.Hotel_Nro_Calle)
INNER JOIN
	[WHERE_EN_EL_DELETE_FROM].tipos_habitaciones t ON
	t.codigo = m.Habitacion_Tipo_Codigo


/******* T A B L A  U S U A R I O S ********/
drop table [WHERE_EN_EL_DELETE_FROM].usuarios
CREATE table [WHERE_EN_EL_DELETE_FROM].usuarios (
	id int identity(1,1) PRIMARY KEY, 
	usuario varchar(255), 
	contrasena varbinary(32),
	habilitado bit DEFAULT 1, 
	cant_intentos char DEFAULT 0
)




--- I N S E R T O  E N  U S U A R I O S a los C L I E N T E S
INSERT INTO [WHERE_EN_EL_DELETE_FROM].usuarios (usuario, contrasena)
VALUES(NULL, NULL)



/******* T A B L A  de C L I E N T E S ******/
DROP TABLE [WHERE_EN_EL_DELETE_FROM].clientes
CREATE TABLE [WHERE_EN_EL_DELETE_FROM].clientes (
	id int identity(1,1) PRIMARY KEY, 
	usuarios_id int , 
	habilitado bit default 1,
	mail varchar(255),
	nombre nvarchar(255),
	apellido nvarchar(255),
	telefono varchar(30),
	pasaporte varchar(255),
	direccion_calle nvarchar (255),
	direccion_nro nvarchar (255),
	direccion_piso nvarchar (255),
	direccion_depto nvarchar (255),
	direccion_localidad nvarchar (255),
	direccion_pais nvarchar (255),
	nacionalidad nvarchar (255),
	consistente bit default 0
)

INSERT INTO [WHERE_EN_EL_DELETE_FROM].clientes (
	usuarios_id, 
	habilitado,
	mail,
	nombre,
	apellido,
	telefono,
	pasaporte,
	direccion_calle,
	direccion_nro,
	direccion_piso,
	direccion_depto,
	direccion_localidad,
	direccion_pais, 
	nacionalidad
)
SELECT DISTINCT
	1, -- ID USUARIO DE GUEST
	1,
	m.Cliente_Mail,
	m.Cliente_Nombre,
	m.Cliente_Apellido,
	NULL,
	m.Cliente_Pasaporte_Nro,
	m.Cliente_Dom_Calle,
	m.Cliente_Nro_Calle,
	NULL,
	NULL,
	NULL,
	NULL,
	m.Cliente_Nacionalidad
FROM
	gd_esquema.Maestra m 



CREATE TABLE [WHERE_EN_EL_DELETE_FROM].cese_actividades(
	cese_id int identity(1,1) PRIMARY KEY,
	hotel_id int NOT NULL,
	CONSTRAINT FK_cese_actividades_hotel FOREIGN KEY (hotel_id) 
	REFERENCES [WHERE_EN_EL_DELETE_FROM].hoteles (id),
	fecha_inicio datetime,
	fecha_fin datetime,
	titulo nvarchar(100),
	descripcion nvarchar(255),
)

DROP TABLE [WHERE_EN_EL_DELETE_FROM].estadias
CREATE TABLE [WHERE_EN_EL_DELETE_FROM].estadias(
	estadia_id int identity(1,1) PRIMARY KEY,
	CONSTRAINT FK_reserva_id FOREIGN KEY (reserva_id)
		REFERENCES [WHERE_EN_EL_DELETE_FROM].reservas (id),
	ingreso_fecha datetime NOT NULL,
	CONSTRAINT FK_ingreso_empleado_id FOREIGN KEY (empleado_id)
		REFERENCES [WHERE_EN_EL_DELETE_FROM].empleados (id),
	egreso_fecha datetime NOT  NULL,
	CONSTRAINT FK_egreso_empleado_id FOREIGN KEY (empleado_id)
		REFERENCES [WHERE_EN_EL_DELETE_FROM].empleados (id),
	)
DROP TABLE [WHERE_EN_EL_DELETE_FROM].huespedes
CREATE TABLE [WHERE_EN_EL_DELETE_FROM].huespedes(
	estadia_id int identity(1,1) PRIMARY KEY,
	CONSTRAINT FK_estadia_id FOREIGN KEY (estadia_id)
		REFERENCES [WHERE_EN_EL_DELETE_FROM].estadias (id),
	cliente_id int identity(1,1) PRIMARY KEY,
	CONSTRAINT FK_cliente_id FOREIGN KEY (cliente_id)
			REFERENCES [WHERE_EN_EL_DELETE_FROM].clientes (id),
			)

---- E J E C U T A  E L  B A T  Q U E  G E N E R A  L A  TABLA  MAESTRA
-- EXEC master..xp_CMDShell 'D:\Mis Documentos\_UTN\Base de Datos\EjecutarScriptTablaMaestra.bat'
--- inserta 528444 registros en tabla gd_esquema.Maestra
--DROP SCHEMA [WHERE_EN_EL_DELETE_FROM]

CREATE SCHEMA [WHERE_EN_EL_DELETE_FROM]

/**** C R E A C I O N  T A B L A S  D E S T I N O  ****/
--DROP TABLE [WHERE_EN_EL_DELETE_FROM].hoteles
CREATE TABLE hoteles (
	id int IDENTITY(1,1) PRIMARY KEY, 
	nombre nvarchar(255) not null,
	mail varchar(255), 
	telefono varchar(255), 
	direccion nvarchar(255), 
	ciudad nvarchar(255),
	pais nvarchar(255), 
	estrellas_cant smallint, 
	estrellas_recargo smallint, 
	fecha_creacion datetime
)


INSERT INTO [WHERE_EN_EL_DELETE_FROM].hoteles (nombre, mail, telefono, direccion , ciudad, pais, 
		estrellas_cant, estrellas_recargo, fecha_creacion)
SELECT distinct
	'Hotel ' + Hotel_calle + ' ' + convert(varchar(255) ,Hotel_Nro_Calle) ,
		null,
		null,
		Hotel_calle + ' ' + convert(varchar(255) ,Hotel_Nro_Calle),
		Hotel_Ciudad,
		'Argentina', -- Las ciudades en la tabla maestra son todas de Argentina
		Hotel_CantEstrella,
		Hotel_Recarga_Estrella,
		getdate()
 from gd_esquema.Maestra
 
 

DROP TABLE [WHERE_EN_EL_DELETE_FROM].regimenes
CREATE TABLE [WHERE_EN_EL_DELETE_FROM].regimenes (
	id int IDENTITY(1,1) PRIMARY KEY, 
	codigo nvarchar(255), 
	descripcion nvarchar(255),
	precio numeric(18,2), 
	habilitado bit DEFAULT 1
)

INSERT INTO [WHERE_EN_EL_DELETE_FROM].regimenes (codigo, descripcion, precio, habilitado)
SELECT distinct
	--'REGIMEN_' + convert(varchar(255), ROW_NUMBER() OVER (ORDER BY (select Regimen_Descripcion))), -- Podemos pensar en hacer codigos tipo RMP: Regimen media pension, RAI: Regimen all inclusive. 
	'REGIMEN_' +  convert(varchar(255), RANK() OVER(order by (Select Regimen_Descripcion))), -- Ver esto para que tire un row_number sin repetir
	Regimen_Descripcion,
	Regimen_Precio,
	1
FROM
	gd_esquema.Maestra
	
	

-- Chequeo si hay reservas sin hotel asociado -> NO HAY
/* select * FROM gd_esquema.Maestra where isnull(gd_esquema.Maestra.Hotel_Nro_Calle, 0) = 0
		OR isnull(gd_esquema.Maestra.Hotel_Calle, '') = ''
 select * FROM gd_esquema.Maestra where isnull(gd_esquema.Maestra.Regimen_Descripcion, '') = ''
	*/

DROP TABLE [WHERE_EN_EL_DELETE_FROM].regimenes_hoteles
CREATE TABLE [WHERE_EN_EL_DELETE_FROM].regimenes_hoteles (
	hotel_id int NOT NULL,
	regimen_id int NOT NULL,
	CONSTRAINT FK_Hotel FOREIGN KEY (hotel_id) 
	REFERENCES [WHERE_EN_EL_DELETE_FROM].hoteles(id),
	CONSTRAINT FK_Regimen FOREIGN KEY (regimen_id)
	REFERENCES [WHERE_EN_EL_DELETE_FROM].regimenes (id)
)

INSERT INTO [WHERE_EN_EL_DELETE_FROM].regimenes_hoteles (hotel_id, regimen_id)
SELECT distinct
	hot.id,
	reg.id
FROM
	gd_esquema.Maestra m
inner join
	[WHERE_EN_EL_DELETE_FROM].regimenes reg on reg.descripcion = m.Regimen_Descripcion
inner join
	[WHERE_EN_EL_DELETE_FROM].hoteles hot on hot.nombre = 'Hotel ' + m.Hotel_calle + ' ' + convert(varchar(255), m.Hotel_Nro_Calle)



DROP TABLE [WHERE_EN_EL_DELETE_FROM].tipos_habitaciones
CREATE TABLE [WHERE_EN_EL_DELETE_FROM].tipos_habitaciones (	
	id int IDENTITY(1,1) PRIMARY KEY,
	codigo int,
	descripcion nvarchar(255) NOT NULL,
	porcentual numeric(18, 2),
	max_huespedes smallint
)

INSERT INTO [WHERE_EN_EL_DELETE_FROM].tipos_habitaciones (codigo, descripcion, porcentual, max_huespedes)
SELECT distinct 
	Habitacion_Tipo_Codigo, 
	Habitacion_Tipo_Descripcion, 
	Habitacion_Tipo_Porcentual, 
	NULL
FROM
	gd_esquema.Maestra
		



DROP TABLE [WHERE_EN_EL_DELETE_FROM].habitaciones
CREATE TABLE [WHERE_EN_EL_DELETE_FROM].habitaciones (	
	id int IDENTITY(1,1) PRIMARY KEY,
	hoteles_id int NOT NULL,
	numero numeric(18,0) NOT NULL,
	piso smallint,
    frente bit,
	descripcion nvarchar(255),
	habilitado bit,
	tipos_id int NOT NULL,
	CONSTRAINT FK_Habitaciones_Hotel FOREIGN KEY (hoteles_id) 
	REFERENCES gd_esquema.Hotel (id),
	CONSTRAINT FK_Habitaciones_Tipos FOREIGN KEY (tipos_id)
	REFERENCES gd_esquema.Tipos_Habitaciones (id))

INSERT INTO [WHERE_EN_EL_DELETE_FROM].habitaciones (
	Hoteles_id, 
	Numero, 
	Piso, 
	Frente, 
	Descripcion, 
	Habilitado, 
	Tipos_id
)
SELECT distinct
	hot.id,
	m.Habitacion_Numero,
	m.Habitacion_Piso,
	CASE WHEN m.Habitacion_Frente = 'N' THEN 0 ELSE 1 END,
	'',
	1,
	t.id
FROM
	gd_esquema.Maestra m
INNER JOIN
	[WHERE_EN_EL_DELETE_FROM].hoteles hot ON
	hot.nombre =  'Hotel ' + m.Hotel_calle + ' ' + convert(varchar(255), m.Hotel_Nro_Calle)
INNER JOIN
	[WHERE_EN_EL_DELETE_FROM].tipos_habitaciones t ON
	t.codigo = m.Habitacion_Tipo_Codigo


/******* T A B L A  U S U A R I O S ********/
drop table [WHERE_EN_EL_DELETE_FROM].usuarios
CREATE table [WHERE_EN_EL_DELETE_FROM].usuarios (
	id int identity(1,1) PRIMARY KEY, 
	usuario varchar(255), 
	contrasena varbinary(32),
	habilitado bit DEFAULT 1, 
	cant_intentos char DEFAULT 0
)




--- I N S E R T O  E N  U S U A R I O S a los C L I E N T E S
INSERT INTO [WHERE_EN_EL_DELETE_FROM].usuarios (usuario, contrasena)
VALUES(NULL, NULL)



/******* T A B L A  de C L I E N T E S ******/
DROP TABLE [WHERE_EN_EL_DELETE_FROM].clientes
CREATE TABLE [WHERE_EN_EL_DELETE_FROM].clientes (
	id int identity(1,1) PRIMARY KEY, 
	usuarios_id int , 
	habilitado bit default 1,
	mail varchar(255),
	nombre nvarchar(255),
	apellido nvarchar(255),
	telefono varchar(30),
	pasaporte varchar(255),
	direccion_calle nvarchar (255),
	direccion_nro nvarchar (255),
	direccion_piso nvarchar (255),
	direccion_depto nvarchar (255),
	direccion_localidad nvarchar (255),
	direccion_pais nvarchar (255),
	nacionalidad nvarchar (255),
	consistente bit default 0
)

INSERT INTO [WHERE_EN_EL_DELETE_FROM].clientes (
	usuarios_id, 
	habilitado,
	mail,
	nombre,
	apellido,
	telefono,
	pasaporte,
	direccion_calle,
	direccion_nro,
	direccion_piso,
	direccion_depto,
	direccion_localidad,
	direccion_pais, 
	nacionalidad
)
SELECT DISTINCT
	1, -- ID USUARIO DE GUEST
	1,
	m.Cliente_Mail,
	m.Cliente_Nombre,
	m.Cliente_Apellido,
	NULL,
	m.Cliente_Pasaporte_Nro,
	m.Cliente_Dom_Calle,
	m.Cliente_Nro_Calle,
	NULL,
	NULL,
	NULL,
	NULL,
	m.Cliente_Nacionalidad
FROM
	gd_esquema.Maestra m 



CREATE TABLE [WHERE_EN_EL_DELETE_FROM].cese_actividades(
	cese_id int identity(1,1) PRIMARY KEY,
	hotel_id int NOT NULL,
	CONSTRAINT FK_cese_actividades_hotel FOREIGN KEY (hotel_id) 
	REFERENCES [WHERE_EN_EL_DELETE_FROM].hoteles (id),
	fecha_inicio datetime,
	fecha_fin datetime,
	titulo nvarchar(100),
	descripcion nvarchar(255),
)

DROP TABLE [WHERE_EN_EL_DELETE_FROM].estadias
CREATE TABLE [WHERE_EN_EL_DELETE_FROM].estadias(
	estadia_id int identity(1,1) PRIMARY KEY,
	CONSTRAINT FK_reserva_id FOREIGN KEY (reserva_id)
		REFERENCES [WHERE_EN_EL_DELETE_FROM].reservas (id),
	ingreso_fecha datetime NOT NULL,
	CONSTRAINT FK_ingreso_empleado_id FOREIGN KEY (empleado_id)
		REFERENCES [WHERE_EN_EL_DELETE_FROM].empleados (id),
	egreso_fecha datetime NOT  NULL,
	CONSTRAINT FK_egreso_empleado_id FOREIGN KEY (empleado_id)
		REFERENCES [WHERE_EN_EL_DELETE_FROM].empleados (id),
	)
DROP TABLE [WHERE_EN_EL_DELETE_FROM].facturas
CREATE TABLE [WHERE_EN_EL_DELETE_FROM].facturas(
	factura_id int identity(1,1) PRIMARY KEY,
	CONSTRAINT FK_estadia_id FOREIGN KEY (estadia_id)
		REFERENCES [WHERE_EN_EL_DELETE_FROM].estadias (id),
	numero int NOT NULL,
	fecha datetime NOT NULL,
	total real NOT NULL,
	CONSTRAINT FK_cliente_id FOREIGN KEY (cliente_id)
		REFERENCES [WHERE_EN_EL_DELETE_FROM].clientes (id),
	pasaporte nvarchar(15) NOT NULL,
	nacionalidad varchar(15) NOT NULL,
	direccion nvarchar(30) NOT NULL,
	nombre nvarchar(15) not null,
	appelido nvarchar(15) not null,
)
DROP TABLE [WHERE_EN_EL_DELETE_FROM].

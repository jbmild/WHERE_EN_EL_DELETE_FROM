USE GD1C2018
GO

CREATE SCHEMA WHERE_EN_EL_DELETE_FROM
GO

/* +++ BEGIN +++ Hoteles */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.hoteles', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.hoteles;
	GO

	CREATE TABLE WHERE_EN_EL_DELETE_FROM.hoteles (
		hotel_id int IDENTITY(1,1) PRIMARY KEY, 
		nombre nvarchar(255),
		mail varchar(255), 
		telefono varchar(255), 
		direccion nvarchar(255), 
		ciudad nvarchar(255),
		pais nvarchar(255), 
		estrellas_cant smallint, 
		estrellas_recargo smallint, 
		fecha_creacion datetime
	)

	INSERT INTO WHERE_EN_EL_DELETE_FROM.hoteles (
		nombre, 
		mail, 
		telefono, 
		direccion, 
		ciudad, 
		pais, 
		estrellas_cant, 
		estrellas_recargo, 
		fecha_creacion
	)
	SELECT DISTINCT
		NULL,
		NULL,
		NULL,
		Hotel_calle + ' ' + convert(varchar(255) ,Hotel_Nro_Calle),
		Hotel_Ciudad,
		'Argentina', -- Las ciudades en la tabla maestra son todas de Argentina
		Hotel_CantEstrella,
		Hotel_Recarga_Estrella,
		getdate()
	 FROM 
	 	gd_esquema.Maestra
/* +++ END +++ Hoteles */	

/* +++ BEGIN +++ Regimenes */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.regimenes', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.regimenes;
	GO

	CREATE TABLE WHERE_EN_EL_DELETE_FROM.regimenes (
		regimen_id int IDENTITY(1,1) PRIMARY KEY, 
		codigo nvarchar(255), 
		descripcion nvarchar(255),
		precio numeric(18,2), 
		habilitado bit DEFAULT 1
	)

	INSERT INTO WHERE_EN_EL_DELETE_FROM.regimenes (
		codigo, 
		descripcion, 
		precio, 
		habilitado
	)
	SELECT DISTINCT
		'REGIMEN_' +  convert(varchar(255), RANK() OVER(order by (Select Regimen_Descripcion))), -- TODO: esto deberia ser nulo
		Regimen_Descripcion,
		Regimen_Precio,
		1
	FROM
		gd_esquema.Maestra
/* +++ END +++ Regimenes */

/* +++ BEGIN +++ Regimenes Hoteles */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.regimenes_hoteles', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.regimenes_hoteles;
	GO

	CREATE TABLE WHERE_EN_EL_DELETE_FROM.regimenes_hoteles (
		hotel_id int NOT NULL,
		regimen_id int NOT NULL,

		PRIMARY KEY (hotel_id, regimen_id),
		CONSTRAINT FK_Hotel FOREIGN KEY (hotel_id) REFERENCES WHERE_EN_EL_DELETE_FROM.hoteles (hotel_id),
		CONSTRAINT FK_Regimen FOREIGN KEY (regimen_id) REFERENCES WHERE_EN_EL_DELETE_FROM.regimenes (regimen_id)
	)

	INSERT INTO WHERE_EN_EL_DELETE_FROM.regimenes_hoteles (
		hotel_id, 
		regimen_id
	)
	SELECT DISTINCT
		hot.hotel_id,
		reg.regimen_id
	FROM
		gd_esquema.Maestra m
		INNER JOIN WHERE_EN_EL_DELETE_FROM.regimenes reg ON 
			reg.descripcion = m.Regimen_Descripcion
		INNER JOIN WHERE_EN_EL_DELETE_FROM.hoteles hot ON 
			hot.nombre = 'Hotel ' + m.Hotel_calle + ' ' + convert(varchar(255), m.Hotel_Nro_Calle)
/* +++ END +++ Regimenes Hoteles */ 

/* +++ BEGIN +++ Habitaciones Tipos */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.habitaciones_tipos', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.habitaciones_tipos;
	GO

	CREATE TABLE WHERE_EN_EL_DELETE_FROM.habitaciones_tipos (	
		tipo_id int IDENTITY(1,1) PRIMARY KEY,
		codigo int,
		descripcion nvarchar(255) NOT NULL,
		porcentual numeric(18, 2),
		max_huespedes smallint
	)

	INSERT INTO WHERE_EN_EL_DELETE_FROM.habitaciones_tipos (
		codigo, 
		descripcion, 
		porcentual,
		max_huespedes
	)
	SELECT DISTINCT 
		Habitacion_Tipo_Codigo, 
		Habitacion_Tipo_Descripcion, 
		Habitacion_Tipo_Porcentual, 
		NULL --TODO esto deberiamos cargarlo de alguna forma
	FROM
		gd_esquema.Maestra
/* +++ END +++ Habitaciones Tipos */ 
	
/* +++ BEGIN +++ Habitaciones */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.habitaciones', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.habitaciones;
	GO

	CREATE TABLE WHERE_EN_EL_DELETE_FROM.habitaciones (	
		id int IDENTITY(1,1) PRIMARY KEY,
		hoteles_id int NOT NULL,
		numero numeric(18,0) NOT NULL,
		piso smallint,
	    frente bit,
		descripcion nvarchar(255),
		habilitado bit,
		tipos_id int NOT NULL,

		CONSTRAINT FK_Habitaciones_Hotel FOREIGN KEY (hoteles_id) REFERENCES WHERE_EN_EL_DELETE_FROM.hoteles (hotel_id),
		CONSTRAINT FK_Habitaciones_Tipos FOREIGN KEY (tipos_id) REFERENCES WHERE_EN_EL_DELETE_FROM.habitaciones_tipos (tipo_id)
	)

	INSERT INTO WHERE_EN_EL_DELETE_FROM.habitaciones (
		Hoteles_id, 
		Numero, 
		Piso, 
		Frente, 
		Descripcion, 
		Habilitado, 
		Tipos_id
	)
	SELECT DISTINCT
		hot.hotel_id,
		m.Habitacion_Numero,
		m.Habitacion_Piso,
		CASE WHEN m.Habitacion_Frente = 'N' THEN 0 ELSE 1 END,
		'',
		1,
		t.tipo_id
	FROM
		gd_esquema.Maestra m
		INNER JOIN WHERE_EN_EL_DELETE_FROM.hoteles hot ON
			hot.nombre =  'Hotel ' + m.Hotel_calle + ' ' + convert(varchar(255), m.Hotel_Nro_Calle)
		INNER JOIN WHERE_EN_EL_DELETE_FROM.habitaciones_tipos t ON
			t.codigo = m.Habitacion_Tipo_Codigo
/* +++ END +++ Habitaciones */ 

/* +++ BEGIN +++ Usuarios */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.usuarios', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.usuarios;
	GO

	CREATE TABLE WHERE_EN_EL_DELETE_FROM.usuarios (
		usuario_id int identity(1,1) PRIMARY KEY, 
		usuario varchar(255), 
		contrasena varbinary(32),
		habilitado bit DEFAULT 1, 
		cant_intentos char DEFAULT 0
	)
/* +++ END +++ Usuarios */ 

/* +++ BEGIN +++ Clientes */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.clientes', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.clientes;
	GO

	CREATE TABLE WHERE_EN_EL_DELETE_FROM.clientes (
		cliente_id int identity(1,1) PRIMARY KEY, 
		usuarios_id int, 
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

	INSERT INTO WHERE_EN_EL_DELETE_FROM.clientes (
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
		1, -- TODO: completar con el usuario guest
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
/* +++ END +++ Clientes */ 

/* +++ BEGIN +++ Cese Actividades */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.cese_actividades', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.cese_actividades;
	GO

	CREATE TABLE WHERE_EN_EL_DELETE_FROM.cese_actividades(
		cese_id int identity(1,1) PRIMARY KEY,
		hotel_id int NOT NULL,
		fecha_inicio datetime,
		fecha_fin datetime,
		titulo nvarchar(100),
		descripcion nvarchar(255),

		CONSTRAINT FK_cese_actividades_hotel FOREIGN KEY (hotel_id) REFERENCES WHERE_EN_EL_DELETE_FROM.hoteles (hotel_id)
	)
/* +++ END +++ Cese Actividades */ 

/* +++ BEGIN +++ Reservas */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.reservas', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.reservas;
	GO

	CREATE TABLE WHERE_EN_EL_DELETE_FROM.reservas(
		reserva_id INT identity(1,1) PRIMARY KEY,
		fecha_desde DATE NOT NULL,
		fecha_hasta DATE NOT NULL,
		fecha_creacion DATETIME DEFAULT CURRENT_TIMESTAMP,
		cliente_id INT NOT NULL,
		codigo NVARCHAR(255),
		estado NVARCHAR(19) CHECK (estado IN('correcta', 'modificada', 'cancelada_recepcion', 'cancelada_cliente', 'cancelada_noshow', 'efectivizada')) DEFAULT 'correcta',
		usuario_id INT NOT NULL,
		cancelacion_fecha DATETIME NULL,
		cancelacion_usuario_id INT NULL,
		total NUMERIC(10,2) DEFAULT 0,
		regimen_id INT NOT NULL,
		hotel_id INT NOT NULL,

		CONSTRAINT FK_reservas_clientes FOREIGN KEY (cliente_id) REFERENCES WHERE_EN_EL_DELETE_FROM.clientes (cliente_id),
		CONSTRAINT FK_reservas_usuarios FOREIGN KEY (usuario_id) REFERENCES WHERE_EN_EL_DELETE_FROM.usuarios (usuario_id),
		CONSTRAINT FK_reservas_usuarios_cancelacion FOREIGN KEY (cancelacion_usuario_id) REFERENCES WHERE_EN_EL_DELETE_FROM.usuarios (usuario_id),
		CONSTRAINT FK_reservas_regimenes FOREIGN KEY (regimen_id) REFERENCES WHERE_EN_EL_DELETE_FROM.regimenes (regimen_id),
	)

	--TODO: completar datos de migracion
/* +++ END +++ Reservas */ 

/* +++ BEGIN +++ Empleados */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.empleados', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.empleados;
	GO

	CREATE TABLE WHERE_EN_EL_DELETE_FROM.empleados (
		empleado_id int identity(1,1) PRIMARY KEY, 
		usuario_id int NOT NULL, 
		mail NVARCHAR(255),
		nombre NVARCHAR(255),
		apellido NVARCHAR(255),
		documento_tipo NVARCHAR(255),
		documento_nro NVARCHAR(255),
		telefono NVARCHAR(255),
		direccion_calle NVARCHAR (255),
		direccion_nro NVARCHAR (255),
		direccion_piso NVARCHAR (255),
		direccion_depto NVARCHAR (255),
		direccion_localidad NVARCHAR (255),
		direccion_pais NVARCHAR (255),

		CONSTRAINT FK_empleados_usuarios FOREIGN KEY (usuario_id) REFERENCES WHERE_EN_EL_DELETE_FROM.usuarios (usuario_id)
	)
/* +++ END +++ Empleados */ 

/* +++ BEGIN +++ Estadias */ --TODO: no esta funcionando
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.estadias', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.estadias;
	GO

	CREATE TABLE WHERE_EN_EL_DELETE_FROM.estadias(
		estadia_id int identity(1,1) PRIMARY KEY,
		reserva_id int,
		ingreso_empleado_id int,
		ingreso_fecha datetime NOT NULL,
		egreso_empleado_id int,
		egreso_fecha datetime NOT  NULL,

		CONSTRAINT FK_reserva_id FOREIGN KEY (reserva_id) REFERENCES WHERE_EN_EL_DELETE_FROM.reservas (reserva_id),
		CONSTRAINT FK_ingreso_empleado_id FOREIGN KEY (ingreso_empleado_id) REFERENCES WHERE_EN_EL_DELETE_FROM.empleados (empleado_id),
		CONSTRAINT FK_egreso_empleado_id FOREIGN KEY (egreso_empleado_id) REFERENCES WHERE_EN_EL_DELETE_FROM.empleados (empleado_id)
	)
/* +++ END +++ Estadias */

/* +++ BEGIN +++ Huespedes */ -- TODO: no esta funcionando
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.huespedes', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.huespedes;
	GO

	CREATE TABLE WHERE_EN_EL_DELETE_FROM.huespedes(
		estadia_id int NOT NULL,
		cliente_id int NOT NULL,

		PRIMARY KEY (estadia_id, cliente_id),
		CONSTRAINT FK_estadia_id FOREIGN KEY (estadia_id) REFERENCES WHERE_EN_EL_DELETE_FROM.estadias (estadia_id),
		CONSTRAINT FK_cliente_id FOREIGN KEY (cliente_id) REFERENCES WHERE_EN_EL_DELETE_FROM.clientes (cliente_id)
	)

/* +++ END +++ Huespedes */


/* +++ BEGIN +++ Facturas */ --TODO: No esta funcionando
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.facturas', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.facturas;
	GO

	CREATE TABLE WHERE_EN_EL_DELETE_FROM.facturas(
		factura_id int identity(1,1) PRIMARY KEY,
		estadia_id int,
		cliente_id int,
		numero int NOT NULL,
		fecha datetime NOT NULL,
		total real NOT NULL,
		pasaporte nvarchar(255) NOT NULL,
		nacionalidad varchar(255) NOT NULL,
		direccion nvarchar(255) NOT NULL,
		nombre nvarchar(255) NOT NULL,
		apellido nvarchar(255) NOT NULL,

		CONSTRAINT FK_facturas_estadias FOREIGN KEY (estadia_id) REFERENCES WHERE_EN_EL_DELETE_FROM.estadias (estadia_id),
		CONSTRAINT FK_facturas_clientes FOREIGN KEY (cliente_id) REFERENCES WHERE_EN_EL_DELETE_FROM.clientes (cliente_id)
	)
/* +++ END+++ Facturas */

USE GD1C2018
GO

--CREATE SCHEMA WHERE_EN_EL_DELETE_FROM
--GO

/* +++ BEGIN +++ Drops */
	/* Items */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.items', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.items;
	GO

	/* Facturas */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.facturas', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.facturas;
	GO

	/* Consumos */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.consumos','U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.consumos;
	GO

	/* Consumibles */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.consumibles','U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.consumibles;
	GO

	/* Huespedes */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.huespedes', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.huespedes;
	GO

	/* Estadias */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.estadias', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.estadias;
	GO

	/* Empleados Hoteles */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.empleados_hoteles', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.empleados_hoteles;
	GO

	/* Empleados */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.empleados', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.empleados;
	GO

	/* Reservas Habitaciones */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.reservas_habitaciones', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.reservas_habitaciones;
	GO

	/* Reservas */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.reservas', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.reservas;
	GO

	/* Cese Actividades */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.cese_actividades', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.cese_actividades;
	GO

	/* Clientes */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.clientes', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.clientes;
	GO

	/* Usuarios Roles */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.usuarios_roles', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.usuarios_roles;
	GO

	/* Roles Permisos */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.roles_permisos', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.roles_permisos;
	GO

	/* Roles */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.roles', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.roles;
	GO

	/* Permisos */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.permisos', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.permisos;
	GO

	/* Usuarios */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.usuarios', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.usuarios;
	GO

	/* Habitaciones */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.habitaciones', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.habitaciones;
	GO

	/* Habitaciones Tipos */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.habitaciones_tipos', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.habitaciones_tipos;
	GO

	/* Regimenes Hoteles */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.regimenes_hoteles', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.regimenes_hoteles;
	GO
		
	/* Regimenes */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.regimenes', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.regimenes;
	GO

	/* Hoteles */
	IF OBJECT_ID('WHERE_EN_EL_DELETE_FROM.hoteles', 'U') IS NOT NULL
		DROP TABLE WHERE_EN_EL_DELETE_FROM.hoteles;
	GO

/* +++ END +++ Drops */
DECLARE @FechaActual date;
SET @FechaActual = GETDATE();

/* +++ BEGIN +++ Creates */
	/* Hoteles */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.hoteles (
		hotel_id int IDENTITY(1,1) PRIMARY KEY, 
		nombre NVARCHAR(255),
		mail NVARCHAR(255), 
		telefono NVARCHAR(255), 
		direccion NVARCHAR(255), 
		ciudad NVARCHAR(255),
		pais NVARCHAR(255), 
		estrellas_cant smallint, 
		estrellas_recargo smallint, 
		fecha_creacion date
	)

	/* Regimenes */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.regimenes (
		regimen_id int IDENTITY(1,1) PRIMARY KEY, 
		codigo NVARCHAR(255), 
		descripcion NVARCHAR(255),
		precio numeric(18,2), 
		habilitado bit DEFAULT 1
	)

	/* Regimenes Hoteles */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.regimenes_hoteles (
		hotel_id int NOT NULL,
		regimen_id int NOT NULL,

		PRIMARY KEY (hotel_id, regimen_id),
		CONSTRAINT FK_Hotel FOREIGN KEY (hotel_id) REFERENCES WHERE_EN_EL_DELETE_FROM.hoteles (hotel_id),
		CONSTRAINT FK_Regimen FOREIGN KEY (regimen_id) REFERENCES WHERE_EN_EL_DELETE_FROM.regimenes (regimen_id)
	)

	/* Habitaciones Tipos */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.habitaciones_tipos (	
		tipo_id int IDENTITY(1,1) PRIMARY KEY,
		codigo int,
		descripcion NVARCHAR(255) NOT NULL,
		porcentual numeric(18, 2),
		max_huespedes smallint
	)

	/* Habitaciones */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.habitaciones (	
		habitacion_id int IDENTITY(1,1) PRIMARY KEY,
		hotel_id int NOT NULL,
		numero numeric(18,0) NOT NULL,
		piso smallint,
	    frente bit,
		descripcion NVARCHAR(255),
		habilitado bit,
		tipos_id int NOT NULL,

		CONSTRAINT FK_Habitaciones_Hotel FOREIGN KEY (hotel_id) REFERENCES WHERE_EN_EL_DELETE_FROM.hoteles (hotel_id),
		CONSTRAINT FK_Habitaciones_Tipos FOREIGN KEY (tipos_id) REFERENCES WHERE_EN_EL_DELETE_FROM.habitaciones_tipos (tipo_id)
	)

	/* Usuarios */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.usuarios (
		usuario_id int identity(1,1) PRIMARY KEY, 
		usuario NVARCHAR(255), 
		contrasena varbinary(32),
		habilitado bit DEFAULT 1, 
		cant_intentos char DEFAULT 0
	)

	/* Permisos */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.permisos (
		permiso_id int identity(1,1) PRIMARY KEY, 
		nombre NVARCHAR(255), 
	)

	/* Roles */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.roles (
		rol_id int identity(1,1) PRIMARY KEY, 
		nombre NVARCHAR(255), 
		habilitado bit DEFAULT 1, 
		esDefault bit DEFAULT 0, 
	)

	/* Roles Permisos */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.roles_permisos (
		rol_id int, 
		permiso_id int, 

		PRIMARY KEY (rol_id, permiso_id),
		CONSTRAINT FK_roles_permisos_roles FOREIGN KEY (rol_id) REFERENCES WHERE_EN_EL_DELETE_FROM.roles (rol_id),
		CONSTRAINT FK_roles_permisos_permisos FOREIGN KEY (permiso_id) REFERENCES WHERE_EN_EL_DELETE_FROM.permisos (permiso_id),
	)

	/* Usuarios Roles */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.usuarios_roles (
		rol_id int, 
		usuario_id int, 

		PRIMARY KEY (rol_id, usuario_id),
		CONSTRAINT FK_usuarios_roles_roles FOREIGN KEY (rol_id) REFERENCES WHERE_EN_EL_DELETE_FROM.roles (rol_id),
		CONSTRAINT FK_usuarios_roles_usuarios FOREIGN KEY (usuario_id) REFERENCES WHERE_EN_EL_DELETE_FROM.usuarios (usuario_id),
	)

	/* Clientes */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.clientes (
		cliente_id int identity(1,1) PRIMARY KEY, 
		usuarios_id int, 
		habilitado bit default 1,
		mail NVARCHAR(255),
		nombre NVARCHAR(255),
		apellido NVARCHAR(255),
		telefono NVARCHAR(255),
		documento_tipo NVARCHAR(255),
		documento_nro NVARCHAR(255),
		direccion_calle NVARCHAR(255),
		direccion_nro NVARCHAR(255),
		direccion_piso NVARCHAR(255),
		direccion_depto NVARCHAR(255),
		direccion_localidad NVARCHAR(255),
		direccion_pais NVARCHAR(255),
		nacionalidad NVARCHAR(255),
		consistente bit default 0
	)

	/* Cese Actividades */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.cese_actividades(
		cese_id int identity(1,1) PRIMARY KEY,
		hotel_id int NOT NULL,
		fecha_inicio date,
		fecha_fin date,
		titulo NVARCHAR(100),
		descripcion NVARCHAR(255),

		CONSTRAINT FK_cese_actividades_hotel FOREIGN KEY (hotel_id) REFERENCES WHERE_EN_EL_DELETE_FROM.hoteles (hotel_id)
	)

	/* Reservas */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.reservas(
		reserva_id INT identity(1,1) PRIMARY KEY,
		fecha_desde DATE NOT NULL,
		fecha_hasta DATE NOT NULL,
		fecha_creacion DATE DEFAULT CURRENT_TIMESTAMP,
		cliente_id INT NOT NULL,
		codigo INT,
		estado NVARCHAR(255) CHECK (estado IN('correcta', 'modificada', 'cancelada_recepcion', 'cancelada_cliente', 'cancelada_noshow', 'efectivizada')) DEFAULT 'correcta',
		usuario_id INT NOT NULL,
		ultima_modificacion_usuario_id INT NULL,
		cancelacion_fecha DATE NULL,
		cancelacion_usuario_id INT NULL,
		motivo_cancelacion NVARCHAR(255) NULL,
		total NUMERIC(10,2) DEFAULT 0,
		regimen_id INT NOT NULL,
		hotel_id INT NOT NULL,

		CONSTRAINT FK_reservas_clientes FOREIGN KEY (cliente_id) REFERENCES WHERE_EN_EL_DELETE_FROM.clientes (cliente_id),
		CONSTRAINT FK_reservas_usuarios FOREIGN KEY (usuario_id) REFERENCES WHERE_EN_EL_DELETE_FROM.usuarios (usuario_id),
		CONSTRAINT FK_reservas_usuarios_cancelacion FOREIGN KEY (cancelacion_usuario_id) REFERENCES WHERE_EN_EL_DELETE_FROM.usuarios (usuario_id),
		CONSTRAINT FK_reservas_usuarios_modificacion FOREIGN KEY (ultima_modificacion_usuario_id) REFERENCES WHERE_EN_EL_DELETE_FROM.usuarios (usuario_id),
		CONSTRAINT FK_reservas_regimenes FOREIGN KEY (regimen_id) REFERENCES WHERE_EN_EL_DELETE_FROM.regimenes (regimen_id),
	)

	/* Reservas Habitaciones */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.reservas_habitaciones(
		habitacion_id INT,
		reserva_id INT,
		precio_diario NUMERIC(10,2) DEFAULT 0,

		PRIMARY KEY (habitacion_id, reserva_id),
		CONSTRAINT FK_reservas_habitaciones_habitaciones FOREIGN KEY (habitacion_id) REFERENCES WHERE_EN_EL_DELETE_FROM.habitaciones (habitacion_id),
		CONSTRAINT FK_reservas_habitaciones_reservas FOREIGN KEY (reserva_id) REFERENCES WHERE_EN_EL_DELETE_FROM.reservas (reserva_id)
	)

	/* Empleados */
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

	/* Empleados Hoteles */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.empleados_hoteles (
		empleado_id int NOT NULL,
		hotel_id int NOT NULL

		PRIMARY KEY(empleado_id, hotel_id),
		CONSTRAINT FK_empleados_hoteles_empleados FOREIGN KEY (empleado_id) REFERENCES WHERE_EN_EL_DELETE_FROM.empleados (empleado_id),
		CONSTRAINT FK_empleados_hoteles_hoteles FOREIGN KEY (hotel_id) REFERENCES WHERE_EN_EL_DELETE_FROM.hoteles (hotel_id),
	)

	/* Estadias */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.estadias(
		estadia_id int identity(1,1) PRIMARY KEY,
		reserva_id int,
		ingreso_empleado_id int,
		ingreso_fecha date NOT NULL,
		egreso_empleado_id int,
		egreso_fecha date NOT  NULL,

		CONSTRAINT FK_reserva_id FOREIGN KEY (reserva_id) REFERENCES WHERE_EN_EL_DELETE_FROM.reservas (reserva_id),
		CONSTRAINT FK_ingreso_empleado_id FOREIGN KEY (ingreso_empleado_id) REFERENCES WHERE_EN_EL_DELETE_FROM.empleados (empleado_id),
		CONSTRAINT FK_egreso_empleado_id FOREIGN KEY (egreso_empleado_id) REFERENCES WHERE_EN_EL_DELETE_FROM.empleados (empleado_id)
	)

	/* Huespedes */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.huespedes(
		estadia_id int NOT NULL,
		cliente_id int NOT NULL,

		PRIMARY KEY (estadia_id, cliente_id),
		CONSTRAINT FK_estadia_id FOREIGN KEY (estadia_id) REFERENCES WHERE_EN_EL_DELETE_FROM.estadias (estadia_id),
		CONSTRAINT FK_cliente_id FOREIGN KEY (cliente_id) REFERENCES WHERE_EN_EL_DELETE_FROM.clientes (cliente_id)
	)

	/* Consumibles */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.consumibles(
		consumible_id int identity(1,1) PRIMARY KEY,
		codigo int NOT NULL,
		descripcion NVARCHAR(50) NOT NULL,
		precio real NOT NULL
		--orden int NOT NULL
	)

	/* Consumos */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.consumos(
		consumo_id int identity(1,1) PRIMARY KEY,
		habitacion_id int,
		consumible_id int,
		estadia_id int,
		cantidad int NOT NULL,
		precio_unitario real NOT NULL,

		CONSTRAINT FK_consumos_consumibles FOREIGN KEY (consumible_id) REFERENCES WHERE_EN_EL_DELETE_FROM.consumibles (consumible_id),
		CONSTRAINT FK_consumos_estadias FOREIGN KEY (estadia_id) REFERENCES WHERE_EN_EL_DELETE_FROM.estadias (estadia_id),
		CONSTRAINT FK_consumos_habitaciones FOREIGN KEY (habitacion_id) REFERENCES WHERE_EN_EL_DELETE_FROM.habitaciones (habitacion_id)
	)

	/* Facturas */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.facturas(
		factura_id int identity(1,1) PRIMARY KEY,
		estadia_id int,
		cliente_id int,
		numero int NOT NULL,
		fecha date NOT NULL,
		total real NOT NULL,
		documento_tipo NVARCHAR(255) NOT NULL,
		documento_nro NVARCHAR(255) NOT NULL,
		nacionalidad varchar(255) NOT NULL,
		direccion NVARCHAR(255) NOT NULL,
		nombre NVARCHAR(255) NOT NULL,
		apellido NVARCHAR(255) NOT NULL,

		CONSTRAINT FK_facturas_estadias FOREIGN KEY (estadia_id) REFERENCES WHERE_EN_EL_DELETE_FROM.estadias (estadia_id),
		CONSTRAINT FK_facturas_clientes FOREIGN KEY (cliente_id) REFERENCES WHERE_EN_EL_DELETE_FROM.clientes (cliente_id)
	)

	/* Items */
	CREATE TABLE WHERE_EN_EL_DELETE_FROM.items(
		item_id int identity(1,1) PRIMARY KEY,
		factura_id int NOT NULL,
		consumo_id int,
		codigo NVARCHAR(100),
		descripcion NVARCHAR(100),
		cantidad int,
		precio_unitario NVARCHAR(20),

		CONSTRAINT FK_facturas FOREIGN KEY (factura_id) REFERENCES WHERE_EN_EL_DELETE_FROM.facturas (factura_id),
		CONSTRAINT FK_consumos FOREIGN KEY (consumo_id) REFERENCES WHERE_EN_EL_DELETE_FROM.consumos (consumo_id)

	)
/* +++ END +++ Creates */

/* +++ BEGIN +++ Fill data */
	/* Hoteles */
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
		concat(Hotel_calle,' ',convert(NVARCHAR(255), Hotel_Nro_Calle)),
		NULL,
		NULL,
		concat(Hotel_calle,' ',convert(NVARCHAR(255), Hotel_Nro_Calle)),
		Hotel_Ciudad,
		'Argentina', -- Las ciudades en la tabla maestra son todas de Argentina
		convert(smallint,Hotel_CantEstrella),
		convert(smallint,Hotel_Recarga_Estrella),
		@FechaActual
	FROM 
	 	gd_esquema.Maestra

	/* Regimenes*/
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

	/* Regimenes Hoteles*/
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
			hot.direccion = m.Hotel_calle + ' ' + convert(varchar(255), m.Hotel_Nro_Calle)
		
	/* Habitaciones Tipos*/
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
		CASE 
			WHEN Habitacion_Tipo_Descripcion LIKE '%simple%' THEN 1
			WHEN Habitacion_Tipo_Descripcion LIKE '%doble%' THEN 2
			WHEN Habitacion_Tipo_Descripcion LIKE '%triple%' THEN 3
			WHEN Habitacion_Tipo_Descripcion LIKE '%cuadruple%' THEN 4
			WHEN Habitacion_Tipo_Descripcion LIKE '%king%' THEN 5
			ELSE NULL
		END
	FROM
		gd_esquema.Maestra

	/* Habitaciones */
	INSERT INTO WHERE_EN_EL_DELETE_FROM.habitaciones (
		hotel_id, 
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
			hot.direccion = CONCAT(m.Hotel_calle,' ',convert(NVARCHAR(255), m.Hotel_Nro_Calle))
		INNER JOIN WHERE_EN_EL_DELETE_FROM.habitaciones_tipos t ON
			t.codigo = m.Habitacion_Tipo_Codigo

	/* Usuarios */
	INSERT INTO WHERE_EN_EL_DELETE_FROM.usuarios (
		usuario, 
		contrasena, 
		habilitado,
		cant_intentos
	) VALUES 
	('guest', convert(varbinary, ''), 1, 0),
	('admin',HASHBYTES('SHA2_256',CONVERT(VARCHAR(32),'w23e')),1,0)

	/* Permisos */
	insert into WHERE_EN_EL_DELETE_FROM.permisos (nombre) VALUES 
	('Roles'), 
	('Clientes'), 
	('Usuarios'),
	('Hoteles'), 
	('Habitaciones'), 
	('Generar o Modificar Reserva'),
	('Cancelar Reserva'),
	('Estadias'),
	('Consumibles'),
	('Facturacion'),
	('Estadisticas')

	/* Roles */
	INSERT INTO WHERE_EN_EL_DELETE_FROM.roles (nombre, habilitado, esDefault) VALUES
	('Administrador General', 1, 0),
	('Guest', 1, 1)

	/* Roles Permisos*/
	INSERT INTO WHERE_EN_EL_DELETE_FROM.roles_permisos (rol_id, permiso_id)
	SELECT (SELECT TOP 1 rol_id FROM WHERE_EN_EL_DELETE_FROM.roles WHERE nombre='Administrador General'), permiso_id FROM WHERE_EN_EL_DELETE_FROM.permisos

	INSERT INTO WHERE_EN_EL_DELETE_FROM.roles_permisos (rol_id, permiso_id)
	SELECT (SELECT TOP 1 rol_id FROM WHERE_EN_EL_DELETE_FROM.roles WHERE nombre='Guest'), permiso_id FROM WHERE_EN_EL_DELETE_FROM.permisos WHERE nombre in ('Generar o Modificar Reserva', 'Cancelar Reserva')

	/* Usuarios Roles */
	INSERT INTO WHERE_EN_EL_DELETE_FROM.usuarios_roles (usuario_id, rol_id) VALUES
	((SELECT TOP 1 usuario_id FROM WHERE_EN_EL_DELETE_FROM.usuarios WHERE usuario='admin'), (SELECT TOP 1 rol_id FROM WHERE_EN_EL_DELETE_FROM.roles WHERE nombre='Administrador General')),
	((SELECT TOP 1 usuario_id FROM WHERE_EN_EL_DELETE_FROM.usuarios WHERE usuario='guest'), (SELECT TOP 1 rol_id FROM WHERE_EN_EL_DELETE_FROM.roles WHERE nombre='Guest'))

	/* Clientes */
	INSERT INTO WHERE_EN_EL_DELETE_FROM.clientes (
		usuarios_id, 
		habilitado,
		mail,
		nombre,
		apellido,
		telefono,
		documento_tipo,
		documento_nro,
		direccion_calle,
		direccion_nro,
		direccion_piso,
		direccion_depto,
		direccion_localidad,
		direccion_pais, 
		nacionalidad
	)
	SELECT DISTINCT
		(SELECT usuario_id FROM WHERE_EN_EL_DELETE_FROM.usuarios WHERE usuario = 'guest'),
		1,
		m.Cliente_Mail,
		m.Cliente_Nombre,
		m.Cliente_Apellido,
		NULL,
		'pasaporte',
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
	
	/* Cese Actividades*/ 
	
	/* Reservas */
	INSERT INTO WHERE_EN_EL_DELETE_FROM.reservas(
		fecha_desde,
		fecha_hasta,
		fecha_creacion,
		cliente_id,
		codigo,
		estado,
		usuario_id,
		regimen_id,
		hotel_id
	) 
	SELECT DISTINCT
		m.Reserva_Fecha_Inicio, 
		dateadd(day, m.Reserva_Cant_Noches, m.Reserva_Fecha_Inicio),
		m.Reserva_Fecha_Inicio,
		cli.cliente_id, 
		m.Reserva_Codigo,
		(
			CASE
				WHEN (Estadia_Fecha_Inicio = '1970-01-01 00:00:00' AND m.Reserva_Fecha_Inicio>@FechaActual) THEN 'correcta' 
				WHEN (Estadia_Fecha_Inicio = '1970-01-01 00:00:00' AND m.Reserva_Fecha_Inicio<@FechaActual) THEN 'cancelada_noshow'
				WHEN Estadia_Fecha_Inicio <> '1970-01-01 00:00:00' THEN 'efectivizada' 
				ELSE NULL
			END
		),
		(SELECT usuario_id FROM WHERE_EN_EL_DELETE_FROM.usuarios WHERE usuario = 'guest'),
		reg.regimen_id,
		hot.hotel_id
	FROM 
		(
			SELECT 
				Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, 
				Regimen_Descripcion, Regimen_Precio, 
				Reserva_Fecha_Inicio, Reserva_Codigo, Reserva_Cant_Noches,
				MAX(ISNULL(Estadia_Fecha_Inicio, '1970-01-01 00:00:00')) as Estadia_Fecha_Inicio,
				Cliente_Pasaporte_Nro, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac, Cliente_Mail, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, Cliente_Nacionalidad 
			FROM 
				gd_esquema.Maestra
			GROUP BY Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, Regimen_Descripcion, Regimen_Precio, Reserva_Fecha_Inicio, Reserva_Codigo, Reserva_Cant_Noches, Cliente_Pasaporte_Nro, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac, Cliente_Mail, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, Cliente_Nacionalidad
		) m
		INNER JOIN WHERE_EN_EL_DELETE_FROM.clientes cli ON
			cli.documento_nro = m.Cliente_Pasaporte_Nro 
			AND  cli.apellido = m.Cliente_Apellido 
			AND cli.nombre = m.Cliente_Nombre
			AND cli.direccion_calle = m.Cliente_Dom_Calle
			AND cli.direccion_nro = m.Cliente_Nro_Calle
			AND cli.mail = m.Cliente_Mail
			AND cli.nacionalidad = m.Cliente_Nacionalidad
		INNER join WHERE_EN_EL_DELETE_FROM.regimenes reg ON
			reg.descripcion = m.Regimen_Descripcion
			AND reg.precio = m.Regimen_Precio
		INNER join WHERE_EN_EL_DELETE_FROM.hoteles hot ON
			hot.direccion = concat(m.Hotel_calle,' ',convert(NVARCHAR(255), m.Hotel_Nro_Calle))
	WHERE 
		m.Reserva_Fecha_Inicio is not null
	
	
	/* Reservas Habitaciones */
	INSERT INTO WHERE_EN_EL_DELETE_FROM.reservas_habitaciones(
		habitacion_id,
		reserva_id,
		precio_diario
	)
	SELECT distinct
		ha.habitacion_id, 
		r.reserva_id, 
		Regimen_Precio * Habitacion_Tipo_Porcentual
	FROM 
		gd_esquema.Maestra m 
		INNER JOIN WHERE_EN_EL_DELETE_FROM.hoteles h on
			h.direccion = concat(Hotel_calle,' ',convert(NVARCHAR(255), Hotel_Nro_Calle))
		INNER JOIN WHERE_EN_EL_DELETE_FROM.habitaciones_tipos ht on
			ht.codigo = m.Habitacion_Tipo_Codigo
			AND ht.descripcion = m.Habitacion_Tipo_Descripcion
			AND ht.porcentual = m.Habitacion_Tipo_Porcentual
		INNER JOIN WHERE_EN_EL_DELETE_FROM.habitaciones ha on
			h.hotel_id = ha.hotel_id
			AND ha.numero = m.Habitacion_Numero
			AND ha.piso = m.Habitacion_Piso
			AND ha.frente = CASE WHEN m.Habitacion_Frente = 'N' THEN 0 ELSE 1 END
			AND ha.tipos_id = ht.tipo_id
		INNER JOIN WHERE_EN_EL_DELETE_FROM.reservas r on
			m.Reserva_Codigo = r.codigo

	/* Empleados */
	INSERT INTO WHERE_EN_EL_DELETE_FROM.empleados (usuario_id, mail, nombre, apellido) VALUES
	((SELECT TOP 1 usuario_id FROM WHERE_EN_EL_DELETE_FROM.usuarios WHERE usuario='admin'), 'admin@hotel.com', 'Administrador', 'General')

	/* Empleados Hoteles */
	INSERT INTO WHERE_EN_EL_DELETE_FROM.empleados_hoteles(empleado_id, hotel_id)
	SELECT (SELECT TOP 1 empleado_id FROM WHERE_EN_EL_DELETE_FROM.empleados WHERE nombre='Administrador' AND apellido='General'), hotel_id FROM WHERE_EN_EL_DELETE_FROM.hoteles

	/* Estadias */
	INSERT INTO WHERE_EN_EL_DELETE_FROM.estadias (
		reserva_id,
		ingreso_empleado_id,
		ingreso_fecha,
		egreso_empleado_id,
		egreso_fecha
	)
	SELECT DISTINCT
		r.reserva_id,
		NULL,
		m.Estadia_Fecha_Inicio,
		NULL,
		dateadd(day,m.Estadia_Cant_Noches,m.Estadia_Fecha_Inicio)
	FROM 
		(
			SELECT 
				Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, 
				Regimen_Descripcion, Regimen_Precio, 
				Reserva_Fecha_Inicio, Reserva_Codigo, Reserva_Cant_Noches,
				Cliente_Pasaporte_Nro, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac, Cliente_Mail, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, Cliente_Nacionalidad,
				Estadia_Fecha_Inicio, Estadia_Cant_Noches
			FROM 
				gd_esquema.Maestra
			WHERE
				Estadia_Fecha_Inicio IS NOT NULL
			GROUP BY Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, Regimen_Descripcion, Regimen_Precio, Reserva_Fecha_Inicio, Reserva_Codigo, Reserva_Cant_Noches, Cliente_Pasaporte_Nro, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac, Cliente_Mail, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, Cliente_Nacionalidad, Estadia_Fecha_Inicio, Estadia_Cant_Noches
		) m
		INNER JOIN WHERE_EN_EL_DELETE_FROM.clientes cli ON
			cli.documento_nro = m.Cliente_Pasaporte_Nro 
			AND  cli.apellido = m.Cliente_Apellido 
			AND cli.nombre = m.Cliente_Nombre
			AND cli.direccion_calle = m.Cliente_Dom_Calle
			AND cli.direccion_nro = m.Cliente_Nro_Calle
			AND cli.mail = m.Cliente_Mail
			AND cli.nacionalidad = m.Cliente_Nacionalidad
		INNER JOIN WHERE_EN_EL_DELETE_FROM.regimenes reg ON
			reg.descripcion = m.Regimen_Descripcion
			AND reg.precio = m.Regimen_Precio
		INNER JOIN WHERE_EN_EL_DELETE_FROM.hoteles hot ON
			hot.direccion = concat(m.Hotel_calle,' ',convert(NVARCHAR(255), m.Hotel_Nro_Calle))
		INNER JOIN WHERE_EN_EL_DELETE_FROM.Reservas r ON
			r.fecha_desde = m.Reserva_Fecha_Inicio
			AND r.fecha_hasta = dateadd(day, m.Reserva_Cant_Noches, m.Reserva_Fecha_Inicio)
			AND r.codigo = m.Reserva_Codigo
			AND r.cliente_id = cli.cliente_id
			AND r.regimen_id = reg.regimen_id
			AND r.hotel_id = hot.hotel_id
			AND r.estado='efectivizada'

	/* Huespedes */

	/* Consumibles */
	INSERT INTO WHERE_EN_EL_DELETE_FROM.consumibles (
		codigo,
		descripcion,
		precio
	) 
	SELECT 
		m.Consumible_Codigo, 
		m.Consumible_Descripcion, 
		MAX(m.Consumible_Precio)
	FROM
		gd_esquema.Maestra m
	WHERE
		m.Consumible_Codigo is not null
	GROUP BY 
		m.Consumible_Codigo, m.Consumible_Descripcion

	/* Consumos */
	INSERT INTO WHERE_EN_EL_DELETE_FROM.consumos(
		habitacion_id,
		consumible_id,
		estadia_id,
		cantidad,
		precio_unitario
	)
	SELECT
		h.habitacion_id,
		con.consumible_id,
		e.estadia_id,
		m.Consumible_Cantidad,
		con.precio
	FROM 
		(
			SELECT 
				Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, 
				Regimen_Descripcion, Regimen_Precio, 
				Reserva_Fecha_Inicio, Reserva_Codigo, Reserva_Cant_Noches,
				Cliente_Pasaporte_Nro, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac, Cliente_Mail, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, Cliente_Nacionalidad,
				Estadia_Fecha_Inicio, Estadia_Cant_Noches,
				Habitacion_Numero, Habitacion_Piso, Habitacion_Frente, 
				Consumible_Codigo, Consumible_Descripcion, Consumible_Precio, count(1) as Consumible_Cantidad
			FROM 
				gd_esquema.Maestra
			WHERE
				Consumible_Codigo IS NOT NULL
			GROUP BY Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, Regimen_Descripcion, Regimen_Precio, Reserva_Fecha_Inicio, Reserva_Codigo, Reserva_Cant_Noches, Cliente_Pasaporte_Nro, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac, Cliente_Mail, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, Cliente_Nacionalidad, Estadia_Fecha_Inicio, Estadia_Cant_Noches, Habitacion_Numero, Habitacion_Piso, Habitacion_Frente, Consumible_Codigo, Consumible_Descripcion, Consumible_Precio
		) m
		INNER JOIN WHERE_EN_EL_DELETE_FROM.Reservas r ON
			r.codigo = m.Reserva_Codigo
		INNER JOIN WHERE_EN_EL_DELETE_FROM.reservas_habitaciones rh ON
			rh.reserva_id = r.reserva_id
		INNER JOIN WHERE_EN_EL_DELETE_FROM.habitaciones h ON
			h.habitacion_id = rh.habitacion_id
			AND h.numero = m.Habitacion_Numero
			AND h.piso = m.Habitacion_Piso
			AND h.frente = CASE WHEN m.Habitacion_Frente = 'N' THEN 0 ELSE 1 END
		INNER JOIN WHERE_EN_EL_DELETE_FROM.consumibles con ON
			con.codigo = m.Consumible_Codigo
			AND con.precio = m.Consumible_Precio
		INNER JOIN WHERE_EN_EL_DELETE_FROM.Estadias e ON
			e.reserva_id = r.reserva_id
		INNER JOIN WHERE_EN_EL_DELETE_FROM.Clientes c ON
			c.cliente_id = r.cliente_id

	/* Facturas */
	INSERT INTO WHERE_EN_EL_DELETE_FROM.facturas(
		estadia_id,
		cliente_id,
		numero,
		fecha,
		total,
		documento_tipo,
		documento_nro,
		nacionalidad,
		direccion,
		nombre,
		apellido
	)
	SELECT
		e.estadia_id,
		c.cliente_id,
		m.Factura_Nro,
		m.Factura_Fecha,
		m.Factura_Total,
		c.documento_tipo,
		c.documento_nro,
		c.nacionalidad,
		CONCAT(c.direccion_calle, ' ', c.direccion_nro, ' ', c.direccion_piso, c.direccion_depto, ', ', c.direccion_localidad, ', ', c.direccion_pais),
		c.nombre,
		c.apellido
	FROM 
		(
			SELECT 
				Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, 
				Regimen_Descripcion, Regimen_Precio, 
				Reserva_Fecha_Inicio, Reserva_Codigo, Reserva_Cant_Noches,
				Cliente_Pasaporte_Nro, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac, Cliente_Mail, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, Cliente_Nacionalidad,
				Estadia_Fecha_Inicio, Estadia_Cant_Noches,
				Factura_Nro, Factura_Fecha, Factura_Total
			FROM 
				gd_esquema.Maestra
			WHERE
				Factura_Nro IS NOT NULL
				AND Factura_Fecha IS NOT NULL
			GROUP BY Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, Regimen_Descripcion, Regimen_Precio, Reserva_Fecha_Inicio, Reserva_Codigo, Reserva_Cant_Noches, Cliente_Pasaporte_Nro, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac, Cliente_Mail, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, Cliente_Nacionalidad, Estadia_Fecha_Inicio, Estadia_Cant_Noches, Factura_Nro, Factura_Fecha, Factura_Total
		) m
		INNER JOIN WHERE_EN_EL_DELETE_FROM.Reservas r ON
			r.codigo = m.Reserva_Codigo
		INNER JOIN WHERE_EN_EL_DELETE_FROM.Estadias e ON
			e.reserva_id = r.reserva_id
		INNER JOIN WHERE_EN_EL_DELETE_FROM.Clientes c ON
			c.cliente_id = r.cliente_id
	ORDER BY 
		m.Factura_Nro

	/* Items */
	INSERT INTO WHERE_EN_EL_DELETE_FROM.items(
		factura_id,
		consumo_id,
		codigo,
		descripcion,
		cantidad,
		precio_unitario
	)
	SELECT
		f.factura_id,
		co.consumo_id,
		con.codigo,
		con.descripcion,
		co.cantidad,
		co.precio_unitario
	FROM 
		(
			SELECT 
				Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, 
				Regimen_Descripcion, Regimen_Precio, 
				Reserva_Fecha_Inicio, Reserva_Codigo, Reserva_Cant_Noches,
				Cliente_Pasaporte_Nro, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac, Cliente_Mail, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, Cliente_Nacionalidad,
				Estadia_Fecha_Inicio, Estadia_Cant_Noches,
				Habitacion_Numero, Habitacion_Piso, Habitacion_Frente, 
				Consumible_Codigo, Consumible_Descripcion, Consumible_Precio, count(1) as Consumible_Cantidad,
				Factura_Nro, Factura_Fecha, Factura_Total
			FROM 
				gd_esquema.Maestra
			WHERE
				Consumible_Codigo IS NOT NULL
				AND Factura_Nro IS NOT NULL
				AND Factura_Fecha IS NOT NULL
			GROUP BY Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, Regimen_Descripcion, Regimen_Precio, Reserva_Fecha_Inicio, Reserva_Codigo, Reserva_Cant_Noches, Cliente_Pasaporte_Nro, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac, Cliente_Mail, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, Cliente_Nacionalidad, Estadia_Fecha_Inicio, Estadia_Cant_Noches, Habitacion_Numero, Habitacion_Piso, Habitacion_Frente, Consumible_Codigo, Consumible_Descripcion, Consumible_Precio, Factura_Nro, Factura_Fecha, Factura_Total
		) m
		INNER JOIN WHERE_EN_EL_DELETE_FROM.Reservas r ON
			r.codigo = m.Reserva_Codigo
		INNER JOIN WHERE_EN_EL_DELETE_FROM.Estadias e ON
			e.reserva_id = r.reserva_id
		INNER JOIN WHERE_EN_EL_DELETE_FROM.Facturas f ON
			f.estadia_id = e.estadia_id
		INNER JOIN WHERE_EN_EL_DELETE_FROM.Clientes c ON
			c.cliente_id = r.cliente_id
		INNER JOIN WHERE_EN_EL_DELETE_FROM.Consumos co ON
			co.estadia_id = e.estadia_id
		INNER JOIN WHERE_EN_EL_DELETE_FROM.consumibles con ON
			co.consumible_id = con.consumible_id
			AND con.codigo = m.Consumible_Codigo
		INNER JOIN WHERE_EN_EL_DELETE_FROM.habitaciones h ON
			h.habitacion_id = co.habitacion_id
			AND h.numero = m.Habitacion_Numero
/* +++ END +++ Fill data */
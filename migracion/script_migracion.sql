
---- E J E C U T A  E L  B A T  Q U E  G E N E R A  L A  TABLA  MAESTRA
-- EXEC master..xp_CMDShell 'D:\Mis Documentos\_UTN\Base de Datos\EjecutarScriptTablaMaestra.bat'

--- inserta 528444 registros

/**** C R E A C I O N  T A B L A S  D E S T I N O  ****/
DROP TABLE gd_esquema.Hotel
CREATE TABLE gd_esquema.Hotel (id int IDENTITY(1,1) PRIMARY KEY, nombre nvarchar(255) not null,
				 mail varchar(255), telefono varchar(255), direccion nvarchar(255), ciudad nvarchar(255),
				 Pais nvarchar(255), 
				estrellas_cant smallint, estrellas_recargo smallint, fecha_creacion datetime)


INSERT INTO		
		gd_esquema.Hotel (nombre, mail, telefono
		, direccion , ciudad, Pais , 
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

 --select distinct Regimen_Descripcion from gd_esquema.Maestra

DROP TABLE gd_esquema.Regimen
CREATE TABLE gd_esquema.Regimen (id int IDENTITY(1,1) PRIMARY KEY, Codigo nvarchar(255), Descripcion nvarchar(255),
			Precio numeric(18,2), Habilitado bit DEFAULT 1)
INSERT INTO gd_esquema.Regimen (codigo, descripcion, precio, habilitado)
SELECT distinct
	--'REGIMEN_' + convert(varchar(255), ROW_NUMBER() OVER (ORDER BY (select Regimen_Descripcion))), -- Podemos pensar en hacer codigos tipo RMP: Regimen media pension, RAI: Regimen all inclusive. 
	'REGIMEN_' +  convert(varchar(255), RANK() OVER(order by (Select Regimen_Descripcion))), -- Ver esto para que tire un row_number sin repetir
	Regimen_Descripcion,
	Regimen_Precio,
	1
FROM
	gd_esquema.Maestra
	
	
	--select * from gd_Esquema.Regimen

-- Chequeo si hay reservas sin hotel asociado -> NO HAY
/* select * FROM gd_esquema.Maestra where isnull(gd_esquema.Maestra.Hotel_Nro_Calle, 0) = 0
		OR isnull(gd_esquema.Maestra.Hotel_Calle, '') = ''
 select * FROM gd_esquema.Maestra where isnull(gd_esquema.Maestra.Regimen_Descripcion, '') = ''
	*/

DROP TABLE gd_esquema.Regimen_Hotel
CREATE TABLE gd_esquema.Regimen_Hotel (Hotel_id int NOT NULL,
										Regimen_id int NOT NULL,
									   CONSTRAINT FK_Hotel FOREIGN KEY (Hotel_id) 
									   REFERENCES gd_esquema.Hotel (id),
									   CONSTRAINT FK_Regimen FOREIGN KEY (Regimen_id)
									   REFERENCES gd_esquema.Regimen (id))

INSERT INTO gd_esquema.Regimen_Hotel (Hotel_id, Regimen_id)
SELECT distinct
	gd_esquema.Hotel.id,
	gd_esquema.Regimen.id
FROM
	gd_esquema.Maestra
inner join
	gd_esquema.Regimen on gd_esquema.Regimen.Descripcion = gd_esquema.Maestra.Regimen_Descripcion
inner join
	gd_esquema.Hotel on gd_esquema.Hotel.nombre = 'Hotel ' + gd_esquema.Maestra.Hotel_calle + ' ' + convert(varchar(255), gd_esquema.Maestra.Hotel_Nro_Calle)



DROP TABLE gd_esquema.Tipos_Habitaciones
CREATE TABLE gd_esquema.Tipos_Habitaciones (	id int IDENTITY(1,1) PRIMARY KEY,
										Codigo int,
										Descripcion nvarchar(255) NOT NULL,
										Porcentual numeric(18, 2),
										Max_Huespedes smallint
								)
INSERT INTO gd_esquema.Tipos_Habitaciones (Codigo, Descripcion, Porcentual, Max_Huespedes)
SELECT distinct Habitacion_Tipo_Codigo,  Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual, null 
FROM
	gd_esquema.Maestra
		



DROP TABLE gd_esquema.Habitaciones
CREATE TABLE gd_esquema.Habitaciones (	id int IDENTITY(1,1) PRIMARY KEY,
										Hoteles_id int NOT NULL,
										Numero numeric(18,0) NOT NULL,
										Piso smallint,
										Frente bit,
										Descripcion nvarchar(255),
										Habilitado bit,
										Tipos_id int NOT NULL,
									   CONSTRAINT FK_Habitaciones_Hotel FOREIGN KEY (Hoteles_id) 
									   REFERENCES gd_esquema.Hotel (id),
									   CONSTRAINT FK_Habitaciones_Tipos FOREIGN KEY (Tipos_id)
									   REFERENCES gd_esquema.Tipos_Habitaciones (id))

INSERT INTO gd_esquema.Habitaciones (Hoteles_id, Numero, Piso, Frente, Descripcion, Habilitado, Tipos_id)
SELECT distinct
	gd_esquema.Hotel.id,
	gd_esquema.Maestra.Habitacion_Numero,
	gd_esquema.Maestra.Habitacion_Piso,
	CASE WHEN gd_esquema.Maestra.Habitacion_Frente = 'N' THEN 0 ELSE 1 END,
	'',
	1,
	gd_esquema.Tipos_Habitaciones.id
FROM
	gd_esquema.Maestra
INNER JOIN
	gd_esquema.Hotel ON
	gd_esquema.Hotel.Nombre =  'Hotel ' + gd_esquema.Maestra.Hotel_calle + ' ' + convert(varchar(255), gd_esquema.Maestra.Hotel_Nro_Calle)
INNER JOIN
	gd_esquema.Tipos_Habitaciones ON
	gd_esquema.Tipos_Habitaciones.Codigo = gd_esquema.Maestra.Habitacion_Tipo_Codigo

	
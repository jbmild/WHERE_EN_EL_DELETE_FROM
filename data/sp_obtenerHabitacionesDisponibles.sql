USE [GD1C2018]
GO
/****** Object:  StoredProcedure [WHERE_EN_EL_DELETE_FROM].[obtenerHabitacionesDisponibles]    Script Date: 07/06/2018 08:48:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		brenda stolarz
-- Create date: 01-06-2018
-- Description:	Obtiene las habitaciones disponibles en cierta fecha
-- =============================================

-- WHERE_EN_EL_DELETE_FROM.obtenerHabitacionesDisponibles '02/06/2018 03:27', '29/07/2016 02:59', 1, null, null
--select * from WHERE_EN_EL_DELETE_FROM.reservas_habitaciones where habitacion_id=255 and reserva_id = 2
--select * from WHERE_EN_EL_DELETE_FROM.reservas where reserva_id = 2

-- WHERE_EN_EL_DELETE_FROM.obtenerHabitacionesDisponibles @fdesde='02/06/2018 03:31:02 p.m.',@fhasta='02/06/2018 03:31:02 p.m.',@hotel_id=1,@regimen_id=1,@tipoHabitacion_id=1

/*
ALTER PROCEDURE [WHERE_EN_EL_DELETE_FROM].[obtenerHabitacionesDisponibles]
	@fdesde varchar(30),
	@fhasta varchar(30),
	@hotel_id int,
	@regimen_id int,
	@tipoHabitacion_id int

AS
*/
BEGIN
		
		DECLARE @fdesde varchar(30),
		@fhasta varchar(30),
		@hotel_id int,
		@regimen_id int,
		@tipoHabitacion_id int,
		@reserva_id int


		SELECT @fdesde = '19/08/2018 12:00:00 a.m.',
		@fhasta = '20/08/2018 12:00:00 a.m.',
		@hotel_id = 1,
		@regimen_id = -1,
		@tipoHabitacion_id = 4,
		@reserva_id = 0
	
	
	
	DECLARE @FechaDesde datetime
	                                DECLARE @FechaHasta datetime
	
	                                SELECT @FechaDesde = convert(datetime, SUBSTRING(@fdesde, 0, 11), 103)
	                                SELECT @FechaHasta = convert(datetime, SUBSTRING(@fhasta, 0, 11), 103)
									SELECT distinct
		                hab.numero AS [Nro Habitacion],
		                hot.direccion AS Hotel,
		                hot.hotel_id,
		                hab.habitacion_id,
		                habTipos.max_huespedes AS [Max Huespedes],
                        habTipos.descripcion AS [Tipo],
		                habTipos.max_huespedes,
                        hot.estrellas_recargo AS [% recargo]
		                /*reg.descripcion AS TipoRegimen,
		                reg.codigo AS CodigoRegimen*/
	                FROM
		                WHERE_EN_EL_DELETE_FROM.habitaciones hab
	                INNER JOIN
		                WHERE_EN_EL_DELETE_FROM.hoteles hot on
		                hot.hotel_id = hab.hotel_id
		                and (hab.hotel_id = @hotel_id or @hotel_id is null)
		                and (hab.tipos_id = @tipoHabitacion_id or @tipoHabitacion_id is null or @tipoHabitacion_id = -1)
	                INNER JOIN
		                WHERE_EN_EL_DELETE_FROM.habitaciones_tipos habTipos on
		                habTipos.tipo_id = hab.tipos_id
	                LEFT JOIN(
		                SELECT
			                res.reserva_id,
			                resHab.habitacion_id
		                FROM
			                WHERE_EN_EL_DELETE_FROM.reservas_habitaciones resHab
		                INNER JOIN
			                WHERE_EN_EL_DELETE_FROM.reservas res on
			                res.reserva_id = resHab.reserva_id
			                and res.estado not in ('cancelada_recepcion', 'cancelada_cliente', 'cancelada_noshow', 'efectivizada')
			                and (
					                @FechaDesde is null 
					                OR 
					                @FechaHasta is null
					                OR
					                @FechaDesde between res.fecha_desde and res.fecha_hasta
					                OR
					                @FechaHasta between res.fecha_desde and res.fecha_hasta
					                OR
					                (@FechaDesde < res.fecha_desde and @FechaHasta > res.fecha_hasta)
				                )
		                ) res on res.habitacion_id = hab.habitacion_id
	                WHERE
		                (res.reserva_id is null or res.reserva_id = @reserva_id )
						-- or isNull(res.reserva_id, 0) <> @reserva_id)
                        AND hab.habilitado = 1
                        AND hot.hotel_id not in (SELECT hotel_id FROM [WHERE_EN_EL_DELETE_FROM].cese_actividades WHERE 
                                    @FechaDesde between fecha_inicio and fecha_fin
					                OR
					                @FechaHasta between fecha_inicio and fecha_fin
					                OR
					                (@FechaDesde < fecha_inicio and @FechaHasta > fecha_fin) )

	
	
END
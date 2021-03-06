﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;
using System.Configuration;

namespace FrbaHotel.Modelo
{
    public class TipoRegimen
    {
        private int _id;
        private string _descripcion;

        public TipoRegimen()
        { 
        }

        public int id {
            get { return _id; }
            set { _id = value; }
        }

        public string descripcion {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public string getDescripcionById(int id) {
            ConexionSQL conexion = new ConexionSQL();

            DataTable dt = conexion.cargarTablaSQL("select isNull(descripcion, '') from WHERE_EN_EL_DELETE_FROM.regimenes where regimen_id =" + id);

            return dt.Rows[0].ItemArray[0].ToString();

        }

        public DataTable getRegimenesByHotel(int hotelId) {
            ConexionSQL conexion = new ConexionSQL();
            DataTable dt = conexion.cargarTablaSQL(@"SELECT reg.regimen_id AS ID, reg.descripcion, reg.precio FROM WHERE_EN_EL_DELETE_FROM.regimenes reg 
                                                    INNER JOIN WHERE_EN_EL_DELETE_FROM.regimenes_hoteles reghot
                                                    on reghot.regimen_id = reg.regimen_id
                                                    WHERE reg.habilitado = 1 AND reghot.hotel_id=" + hotelId
                                                    + " ORDER BY reg.precio" );
            return dt;
        }

        public decimal getPrecioById(int tipoRegimenId) {
            ConexionSQL conexion = new ConexionSQL();
            DataTable dt = conexion.cargarTablaSQL(@"SELECT regimen_id AS ID, precio FROM WHERE_EN_EL_DELETE_FROM.regimenes
                                                    WHERE regimen_id=" + tipoRegimenId.ToString());
            
            return Convert.ToDecimal(dt.Rows[0].ItemArray[1]);
        }
    }
}

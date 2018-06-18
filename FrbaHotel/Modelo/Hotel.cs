using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FrbaHotel.Modelo
{
    public class Hotel
    {
        private int _id;
        private string _nombre;

        public Hotel() { 
        }

        public int id {
            get { return _id; }
            set { _id = value; }
        }

        public string nombre {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string getNombreById(int id) {
            ConexionSQL conexion = new ConexionSQL();

            DataTable dt = conexion.cargarTablaSQL("select CASE WHEN isNull(nombre, '') = '' THEN 'Hotel ' + direccion ELSE nombre END as nombre from WHERE_EN_EL_DELETE_FROM.hoteles where hotel_id =" + id);

            return dt.Rows[0].ItemArray[0].ToString();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
    }
}

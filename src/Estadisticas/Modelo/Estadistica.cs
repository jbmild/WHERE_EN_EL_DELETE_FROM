using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Estadisticas.Modelo
{
    public class Estadistica
    {
        public List<DataGridViewTextBoxColumn> columnas = null;
        public DataTable data = null;

        public Estadistica()
        {
            columnas = new List<DataGridViewTextBoxColumn>();
        }
    }
}

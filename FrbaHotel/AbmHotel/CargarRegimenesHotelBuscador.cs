using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmHotel
{
    class CargarRegimenesHotelBuscador
    {
        internal void Cargar(int hotel, System.Windows.Forms.ListBox listBox)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable regimenesHotel = c.cargarTablaSQL("select r.descripcion" +
                " from WHERE_EN_EL_DELETE_FROM.regimenes r join WHERE_EN_EL_DELETE_FROM.regimenes_hoteles rh on r.regimen_id=rh.regimen_id" +
                 " and rh.hotel_id=" + hotel);
            int total = regimenesHotel.Rows.Count;
            int i;
            for (i = 0; i < total; i++) 
            {
                listBox.Items.Add(regimenesHotel.Rows[i].ItemArray[0].ToString());
            }
        }
    }
}

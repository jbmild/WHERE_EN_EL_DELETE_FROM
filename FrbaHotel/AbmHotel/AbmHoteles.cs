using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel
{
   public  class AbmHoteles
    {
        private int ventanaModificacionAbierta = 0;
        public void SetVentanaAbierta()
        {

            this.ventanaModificacionAbierta = 1;
        }
        public int GetVentanaAbierta()
        {
            return this.ventanaModificacionAbierta;
        }
    }
}

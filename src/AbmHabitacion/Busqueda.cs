using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmHabitacion
{
    class Busqueda
    {
        private bool hayHotel;
        private bool hayPiso;
        private bool hayHabitacion;
        public bool GetHotel()
        {
            return this.hayHotel;
        }
        public bool GetPiso() {
            return this.hayPiso;
        }
        public bool GetHabitacion() {
            return this.hayHabitacion;
        }
        public void SetHotel(bool v)
        {
            this.hayHotel=v;
        }
        public void SetPiso(bool v)
        {
            this.hayPiso=v;
        }
        public void SetHabitacion(bool v)
        {
            this.hayHabitacion=v;
        }
    }
    

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Modelo
{
    class Reserva
    {
        private int _id;
        private DateTime _fecha_desde;
        private DateTime _fecha_hasta;
        private DateTime _fecha_creacion;
        private int _cliente_id;
        private string _codigo;
        private string _estado;
        //completar atributos

        public Reserva(int id) {
            _id = id;
        }

        
    }
}

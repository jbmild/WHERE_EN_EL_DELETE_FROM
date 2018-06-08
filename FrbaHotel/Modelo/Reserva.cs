using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FrbaHotel.Modelo
{
    public class Reserva
    {
        private int _id;
        private DateTime _fecha_desde;
        private DateTime _fecha_hasta;
        //private DateTime _fecha_creacion;
        private int _cliente_id;
        //private string _codigo;
        //private string _estado;
        private decimal _total;
        private int _regimen_id;
        private int _hotel_id;
        private List<Habitacion> _habitaciones;
        //completar atributos

        //nueva reserva
        public Reserva(DateTime fd, DateTime fh, decimal total, int regimen_id, int hotel_id, List<Habitacion> habitaciones) {
            _fecha_desde = fd;
            _fecha_hasta = fh;
            _total = total;
            _regimen_id = regimen_id;
            _hotel_id = hotel_id;
            _habitaciones = habitaciones;
        }

        //Getters y setters
        public int id {
            get { return _id; }
            set { _id = value;  }
        }


        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Modelo
{
    public class Habitacion
    {
        private int _id;
        private int _hotel_id;
        private int _numero;
        private int _piso;
        private int _frente;
        private string _descripcion;
        private bool _habilitado;
        private int _tipo;

        public Habitacion(int id, int hotel_id, int numero){
            _id = id;
            _hotel_id = hotel_id;
            _numero = numero;

        }

        public int id {
            get { return _id; }
            set { _id = value; }
        }

        public int numero {
            get { return _numero; }
            set { _numero = value; }
        }

        public int hotel_id {
            get { return _hotel_id;  }
            set { _hotel_id = value; }
        }
    }

    
}

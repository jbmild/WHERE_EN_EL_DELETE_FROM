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
        private decimal _max_huespedes;
        private decimal _porcentual;
        private decimal _precio;

        public Habitacion(int id, int hotel_id, int numero, decimal precio){
            _id = id;
            _hotel_id = hotel_id;
            _numero = numero;
            _precio = precio;
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

        public decimal max_huespedes {
            get { return _max_huespedes; }
            set { _max_huespedes = value; }
        }

        public decimal porcentual {
            get { return _porcentual; }
            set { _porcentual = value; }
        }

        public decimal precio {
            get { return _precio; }
            set { _precio = value; }
        }
    }

    
}

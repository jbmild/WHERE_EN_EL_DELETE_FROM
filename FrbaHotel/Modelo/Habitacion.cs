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

        public Habitacion(int id, int hotel_id){
            _id = id;
            _hotel_id = hotel_id;

        }

        public int id {
            get { return _id; }
            set { _id = value; }
        }
    }

    
}

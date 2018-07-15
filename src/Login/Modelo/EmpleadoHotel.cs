using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaHotel.Hoteles.Modelo;

namespace FrbaHotel.Login.Modelo
{
    public class EmpleadoHotel
    {
        private int empleado_id = 0;
        private int hotel_id = 0;
        private Empleado empleado = null;
        private Hotel hotel = null;

        public int EmpleadoId
        {
            get { return empleado_id; }
            set { empleado_id = value; }
        }
        public int HotelId
        {
            get { return hotel_id; }
            set { hotel_id = value; }
        }
        public Empleado Empleado
        {
            get {
                if (this.empleado == null && this.empleado_id != 0)
                {
                    this.empleado = new Empleado(this.empleado_id);
                }
                return empleado; 
            }
        }
        public Hotel Hotel
        {
            get {
                if (this.hotel == null && this.hotel_id != 0)
                {
                    this.hotel = new Hotel(this.hotel_id);
                }
                return hotel; 
            }
        }

        public EmpleadoHotel(int empleadoId, int hotelId)
        {
            this.empleado_id = empleadoId;
            this.hotel_id = hotelId;
        }
    }
}

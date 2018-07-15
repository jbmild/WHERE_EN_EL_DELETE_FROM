using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.RegistrarConsumible
{
    class Consumo
    {
        private int habitacion;
        private string precio;
        private int consumible;
        private int cantidad;
        private int estadia;


        public void SetEstadia(int e) { this.estadia = e; }
        public void SetHabitacion(int h) { this.habitacion = h; }
        public void SetPrecio(string p) { this.precio = p; }
        public void SetConsumible(int id) { this.consumible = id; }
        public void SetCantidad(int c) { this.cantidad = c; }
        public int GetHabitacion() { return this.habitacion; }
        public string GetPrecio() { return this.precio; }
        public int GetConsumible() { return this.consumible; }
        public int GetCantidad() { return this.cantidad; }
        public int GetEstadia() { return this.estadia; }

        internal bool EstadiaAllInclusive()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmHabitacion
{
    public class ModificacionHabitacion
    {
        private string hotel;
        private int piso;
        private int numero;
        private string descripcion;
        private bool vista;
        private bool habilitado;

        public void SetHotel(string hotel) { this.hotel=hotel;}
        public void SetPiso(int piso) { this.piso=piso;}
        public void SetNumero(int numero) { this.numero=numero;}
        public void SetDescripcion(string descripcion) { this.descripcion=descripcion;}
        public void SetVista(bool vista) { this.vista=vista;}
        public void SetHabilitado(bool habilitado) { this.habilitado = habilitado; }
        public void SetValues(string p1, int p2, int p3, string p4)
        {
            this.hotel = p1;
            this.piso = p2;
            this.numero = p3;
            this.descripcion = p4;
            //this.vista = bool.Parse(p5);
            //this.habilitado = bool.Parse(p6);

        }
        internal string GetHotel()
        {
            return this.hotel;
        }
        internal int GetPiso()
        {
            return this.piso;
        }
        internal int GetNumero()
        {
            return this.numero;
        }
        internal string GetDescripcion()
        {
            return this.descripcion;
        }
        internal bool GetVista()
        {
            return this.vista;
        }
        internal bool GetHabilitado()
        {
            return this.habilitado;
        }

    }
}


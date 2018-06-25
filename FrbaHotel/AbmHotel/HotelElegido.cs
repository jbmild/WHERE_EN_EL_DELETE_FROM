using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmHotel
{
    class HotelElegido
    {
        string nombre;
        string pais;
        string ciudad;
        int estrellas_cant;
        int estrellas_recargo;
        string direccion;
        string mail;

        public int telefono { get; set; }
        internal void SetNombre(string p)
        {
            this.nombre = p;
        }

        internal void SetMail(string p)
        {
            this.mail = p;
        }
        internal void SetPais(string p) {
            this.pais = p;
        }
        internal void SetCiudad(string p) 
        {
            this.ciudad = p;
        }
        internal void SetEstrellas_Cant(int p) {
            this.estrellas_cant = p;
        }
        internal void SetEstrellas_Recargo(int p) {
            this.estrellas_recargo = p;
        }
        internal void SetDireccion(string p) {
            this.direccion = p;
        }

        internal void SetTelefono(int p)
        {
            this.telefono = p;
        }



        internal void SetFechaCreacion(DateTime p)
        {
            this.fechaCreacion = p;
        }

        public DateTime fechaCreacion { get; set; }
    }
}

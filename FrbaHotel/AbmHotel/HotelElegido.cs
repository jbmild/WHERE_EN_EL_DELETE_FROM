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
        internal string GetNombre() {
            return this.nombre;
        }
        internal void SetMail(string p)
        {
            this.mail = p;
        }
        internal string GetMail() {
            return this.mail;
        }
        internal void SetPais(string p) {
            this.pais = p;
        }
        internal string GetPais() {
            return this.pais;
        }
        internal void SetCiudad(string p) 
        {
            this.ciudad = p;
        }
        internal string GetCiudad() {
            return this.ciudad;
        }
        internal void SetEstrellas_Cant(int p) {
            this.estrellas_cant = p;
        }
        internal int GetEstrellas_cant() {
            return this.estrellas_cant;
        }
        internal void SetEstrellas_Recargo(int p) {
            this.estrellas_recargo = p;
        }
        internal int GetEstrellas_Recargo() {
            return this.estrellas_recargo;
        }
        internal void SetDireccion(string p) {
            this.direccion = p;
        }
        internal string GetDireccion() {
            return this.direccion;
        }
        internal void SetTelefono(int p)
        {
            this.telefono = p;
        }

        internal int GetTelefono() {
            return this.telefono;
        }

        internal void SetFechaCreacion(DateTime p)
        {
            this.fechaCreacion = p;
        }
        internal DateTime GetFechaCreacion() {
            return this.fechaCreacion;
        }
        public DateTime fechaCreacion { get; set; }
    }
}

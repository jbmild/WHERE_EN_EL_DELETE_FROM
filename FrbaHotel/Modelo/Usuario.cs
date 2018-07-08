using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Modelo
{
    public  class Usuario
    {
        private int usuario_ID;
        private string nombre;
        private string nombreUsuario;
        private string rolActual;
        private bool habilitado;
        private FrbaHotel.Modelo.Hotel hotel;

        public string GetNombre() { return this.nombre; }
        public string GetRol() { return this.rolActual; }
        public bool GetHabilitado() { return this.habilitado; }
        public void SetNombre(string nom) { this.nombre = nom; }
        public void SetRol(string rol) { this.rolActual = rol; }
        public void SetHabilitado(bool hab) { this.habilitado = hab; }
        public int GetID() { return this.usuario_ID;  }
        public void SetID(int ID) { this.usuario_ID = ID; }
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
    }
}

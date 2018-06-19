using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmHabitacion
{
   public class HabitacionElegida
    {
        private string direccion;
        private int vista_exterior;
        private int habilitado;
        private int numero;
        private string descripcion;
        private int piso;
        private string tipo_text;
        private int tipo_clave;

        public void SetTipo(String nuevoTipo)
        {
            this.tipo_text = nuevoTipo;
        }
        public string GetTipo()
        {
            return this.tipo_text;
        }
        public void SetDescripcion(String nuevaDesc)
        {
            this.descripcion = nuevaDesc;
        }
        public string GetDescripcion()
        {
            return this.descripcion;
        }

        public void SetDireccion(String nuevaDir) 
        {
            this.direccion = nuevaDir;
        }
        public void SetVista(int nuevaVista) 
        {
            this.vista_exterior = nuevaVista;
        }
        public void SetHabilitado(int nuevoHabil) {
            this.habilitado = nuevoHabil;
        }
        public void SetNumero(int nuevoNum) 
        {
            this.numero = nuevoNum;
        }
        public void SetPiso(int nuevoPiso) 
        {
            this.piso = nuevoPiso;
        }


        public string GetDireccion()
        {
            return this.direccion;
        }
        public int GetVista()
        {
            return this.vista_exterior;
        }
        public int GetHabilitado()
        {
            return this.habilitado; 
        }
        public int GetNumero()
        {
            return this.numero;
        }
        public int GetPiso()
        {
            return this.piso;
        }
    }
}

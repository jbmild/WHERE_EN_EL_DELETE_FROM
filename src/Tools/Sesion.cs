using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaHotel.Login.Modelo;
using FrbaHotel.Modelo;
using FrbaHotel.Roles.Modelo;

namespace FrbaHotel.Tools
{
    public static class Sesion
    {
        public static FrbaHotel.Login.Modelo.Usuario usuario = null;
        public static Rol rol = null;
        public static Hoteles.Modelo.Hotel hotel = null;

        public static DateTime obtenerFechaSistema()
        {
            try
            {
                return DateTime.ParseExact(ConfigurationManager.AppSettings["fechaSistema"], ConfigurationManager.AppSettings["formatoFechaSistema"], CultureInfo.InvariantCulture);
            }   
            catch (Exception)
            {
                throw new Exception("La fecha ingresada en la configuracion no corresponde a su formato o esta incompleto.");
            }
        }
    }
}

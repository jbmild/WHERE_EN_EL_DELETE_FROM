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
        public static FrbaHotel.Login.Modelo.Hotel hotel = null;

        public static DateTime obtenerFechaSistema()
        {
            try
            {
                CultureInfo culture = new CultureInfo(ConfigurationManager.AppSettings["formatoFechaSistema"]);
                return Convert.ToDateTime(ConfigurationManager.AppSettings["fechaSistema"], culture);
            }
            catch (Exception)
            {
                throw new Exception("La fecha ingresada en la configuracion no corresponde a su formato o esta incompleto.");
            }
        }
    }
}

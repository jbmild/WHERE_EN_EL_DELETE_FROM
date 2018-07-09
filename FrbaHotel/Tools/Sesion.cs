using System;
using System.Collections.Generic;
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
    }
}

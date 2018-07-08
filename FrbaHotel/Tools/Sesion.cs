using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaHotel.Modelo;
using FrbaHotel.Roles.Modelo;

namespace FrbaHotel.Tools
{
    public static class Sesion
    {
        public static Usuario usuario = null;
        public static Rol rol = null;
        public static Hotel hotel = null;
    }
}

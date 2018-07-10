using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaHotel.Tools;

namespace FrbaHotel.Estadisticas.Modelo
{
    public static class Estadisticas
    {
        public static Estadistica obtener(int anio, int trimestre, string tipo)
        {
            Estadistica estadistica = null;
            switch (tipo)
            {
                case "cantReservasCanceladas":
                    estadistica = Estadisticas.obtenerTop5CantReservasCanceladas(anio, trimestre);
                    break;
                case "cantConsumiblesFacturados":
                    estadistica = Estadisticas.obtenerTop5CantConsumiblesFacturados(anio, trimestre);
                    break;
                case "cantDiasFueraServicio":
                    estadistica = Estadisticas.obtenerTop5CantDiasFueraServicio(anio, trimestre);
                    break;
                case "habitacionMayorOcupacion":
                    estadistica = Estadisticas.obtenerTop5HabitacionMayorOcupacion(anio, trimestre);
                    break;
                case "clienteMasPuntos":
                    estadistica = Estadisticas.obtenerTop5ClienteMasPuntos(anio, trimestre);
                    break;
            }

            return estadistica;
        }

        public static Estadistica obtenerTop5CantReservasCanceladas(int anio, int trimestre)
        {
            return null;
        }

        public static Estadistica obtenerTop5CantConsumiblesFacturados(int anio, int trimestre)
        {
            return null;
        }

        public static Estadistica obtenerTop5CantDiasFueraServicio(int anio, int trimestre)
        {
            return null;
        }

        public static Estadistica obtenerTop5HabitacionMayorOcupacion(int anio, int trimestre)
        {
            return null;
        }

        public static Estadistica obtenerTop5ClienteMasPuntos(int anio, int trimestre)
        {
            return null;
        }
    }
}

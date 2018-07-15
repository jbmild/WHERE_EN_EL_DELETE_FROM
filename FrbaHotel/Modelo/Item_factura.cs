using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Modelo
{
    public class Item_factura
    {
        string _codigo;
        int _cantidad;
        string _detalle;
        decimal _precioUnitario;


        public Item_factura(string codigo, int cant, string detalle, decimal precioUnitario) {
            _codigo = codigo;
            _cantidad = cant;
            _detalle = detalle;
            _precioUnitario = precioUnitario;
        }
    }
}

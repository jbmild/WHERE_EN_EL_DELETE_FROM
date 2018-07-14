using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Modelo
{
    class Factura
    {
        private int _estadia_id;
        private int _cliente_id;
        private int _numero;
        private DateTime _fecha;
        private decimal _total;
        /*private string _documento_tipo;
        private string _documento_nro;
        private string _nacionalidad;*/
        string _cuit;
        bool _responsableInscripto;
        private string _domicilio;
        private string _razonSocial;
        private int _formpago_id;
        private List<Item_factura> _items;

        public Factura(int estadia_id, int cliente_id, int numero, DateTime fecha, decimal total,
            string cuit, bool responsableInscripto, string razonSocial, int formapago_id, List<Item_factura> items) {
            _estadia_id = estadia_id;
            _cliente_id = cliente_id;
            _numero = numero;
            _fecha = fecha;
            _total = total;
            _cuit = cuit;
            _responsableInscripto = responsableInscripto;
            _razonSocial = razonSocial;
            _formpago_id = formapago_id;
            _items = items;
        }

    }
}

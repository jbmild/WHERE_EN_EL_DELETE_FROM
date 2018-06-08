using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FrbaHotel.Modelo
{
    public class Cliente
    {
        private int _idCliente;

        public idCliente {
            get {return _idCliente;}
            set { _idCliente = value;}
        }

        public Cliente(int id) { 
            _idCliente = id;
        }

        public Cliente() { 
        }

        public Cliente getClienteByTipoNroDocEmail(int tipoDoc, string nroDoc, string email){
            ConexionSQL conn = new ConexionSQL();

            DataTable dt = conn.cargarTablaSQL(@"select * from WHERE_EN_EL_DELETE_FROM.Clientes cli 
                                        WHERE tipo pasaporte='" + nroDoc + "' AND mail='" + email + "'");


            return new Cliente(1);
        }
    }
}

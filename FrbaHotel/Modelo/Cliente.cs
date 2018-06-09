using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FrbaHotel.Modelo
{
    public class Cliente
    {
        private int _idCliente;
        private string _email;
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _nrodocumento;
        private string _direccion_calle;
        private string _direccion_numero;
        private string _direccion_piso;
        private string _direccion_depto;
        private string _direccion_localidad;
        private string _direccion_pais;
        private string _nacionalidad;


        //Getters y setters
        public int idCliente {
            get {return _idCliente;}
            set { _idCliente = value;}
        }
        public string email {
            get { return _email;  }
            set { _email = value; }
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string nrodocumento
        {
            get { return _nrodocumento; }
            set { _nrodocumento = value; }
        }

        public string direccion_calle
        {
            get { return _direccion_calle; }
            set { _direccion_calle = value; }
        }
        public string direccion_numero
        {
            get { return _direccion_numero; }
            set { _direccion_numero = value; }
        }
        public string direccion_piso
        {
            get { return _direccion_piso; }
            set { _direccion_piso = value; }
        }

        public string direccion_depto
        {
            get { return _direccion_depto; }
            set { _direccion_depto = value; }
        }
        public string direccion_localidad
        {
            get { return _direccion_localidad; }
            set { _direccion_localidad = value; }
        }
        public string direccion_pais
        {
            get { return _direccion_pais; }
            set { _direccion_pais = value; }
        }
        public string nacionalidad
        {
            get { return _nacionalidad; }
            set { _nacionalidad = value; }
        }


        //Constructores
        public Cliente(int id) { 
            _idCliente = id;
        }

        public Cliente(int id, string email, string nombre, string apellido, string telefono, string pasaporte, 
                string direccion_calle, string direccion_numero, string direccion_piso, string direccion_depto, 
            string direccion_localidad, string direccion_pais, string nacionalidad)
        {
            _idCliente = id;
            _email = email;
            _nombre = nombre;
            _apellido = apellido;
            _telefono = telefono;
            _nrodocumento = pasaporte;
            _direccion_calle = direccion_calle;
            _direccion_numero = direccion_numero;
            _direccion_piso = direccion_piso;
            _direccion_depto = direccion_depto;
            _direccion_localidad = direccion_localidad;
            _direccion_pais = direccion_piso;
            _nacionalidad = nacionalidad;
        }

        public Cliente() { 
        }


        public Cliente getClienteByTipoNroDocEmail(int tipoDoc, string nroDoc, string email){
            ConexionSQL conn = new ConexionSQL();

            string sqlQuery = "select * from WHERE_EN_EL_DELETE_FROM.Clientes cli WHERE ";
            
            //if(tipoDoc != null){
            //    sqlQuery+= "tipoDocumento='" + tipoDoc + "' "
            //}

            if(nroDoc != null || nroDoc.Length > 0){
                sqlQuery+= "pasaporte='" + nroDoc + "' ";
            }

            if(email != null || email.Length > 0){
                sqlQuery += " AND mail='" + email + "' ";
            }
            
            DataTable dt = conn.cargarTablaSQL(sqlQuery);            

            if (dt.Rows.Count > 0)
            {
                //armar objeto cliente
                object[] row = dt.Rows[0].ItemArray;
                return new Cliente(Convert.ToInt32(row[0]), // cliente_id
                                                    row[3].ToString(), // mail
                                                    row[4].ToString(), // nombre
                                                    row[5].ToString(), // apellido
                                                    row[6].ToString(), // telefono
                                                    row[7].ToString(), // pasaporte
                                                    row[8].ToString(), // direccion_calle
                                                    row[9].ToString(), // direccion_nro
                                                    row[10].ToString(), // direccion_piso
                                                    row[11].ToString(), // direccion_depto
                                                    row[12].ToString(), // direccion_localidad
                                                    row[13].ToString(), // direccion_pais
                                                    row[14].ToString()); // nacionalidad

            }
            else {
                return new Cliente(0);
            }
            
        }

        public int guardarCliente(Cliente cli) {


            ConexionSQL conex = new ConexionSQL();
            int exito;
            SqlCommand command = new SqlCommand(@"UPDATE WHERE_EN_EL_DELETE_FROM.Clientes SET 
                                                mail=@mail,nombre=nombre,apellido=@apellido,telefono=@telefono,
                                                pasaporte=@nrodocumento,direccion_calle=@direccion_calle,
                                                direccion_nro=@direccion_nro,direccion_piso=@direccion_piso,
                                                
                                                ");

            if (cli.idCliente != 0)
            {
                exito = conex.actualizarDatos(@"UPDATE WHERE_EN_EL_DELETE_FROM.Clientes SET 
                                                    mail='" + cli.email + "'," +
                                                        "nombre='" + cli.nombre + "'," +
                                                        "apellido='" + cli.apellido + "'," +
                                            
            "telefono='" + cli.telefono + "'," +
                                                        "pasaporte='" + cli.nrodocumento + "'," +
                                                        "direccion_calle='" + cli.direccion_calle + "'," +
                                                        "direccion_nro='" + cli.direccion_numero + "'," +
                                                        "direccion_piso='" + cli.direccion_piso + "'," +
                                                        "direccion_depto='" + cli.direccion_depto + "'," +
                                                        "direccion_localidad='" + cli.direccion_localidad + "'," +
                                                        "direccion_pais='" + cli.direccion_pais + "'," +
                                                        "nacionalidad='" + cli.nacionalidad + "'," +
                                                        "consistente=1 WHERE cliente_id=" + cli.idCliente);

                
            }
            else {
                exito = conex.actualizarDatos(@"INSERT INTO WHERE_EN_EL_DELETE_FROM.Clientes 
                                                      (usuarios_id, mail, nombre, apellido, telefono, pasaporte, direccion_calle, direccion_nro, direccion_piso, direccion_depto, direccion_localidad, direccion_pais, nacionalidad, consistente)
                                                    VALUES(1, '"+
                                                      cli.email + "', '"+cli.nombre+"','"+cli.apellido+"','"+cli.telefono
                                                      +"','"+cli.nrodocumento+"','"+cli.direccion_calle+"','"+
                                                      cli.direccion_numero + "','" + cli._direccion_piso+"',"
                                                    );
            }

            return exito; //devuelvo cant rows afectadas
        }

    }
}

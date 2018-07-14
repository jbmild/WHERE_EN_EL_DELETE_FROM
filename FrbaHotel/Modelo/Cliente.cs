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
        private bool _habilitado;
        private string _email;
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _tipoDocumento;
        private string _nrodocumento;
        private string _direccion_calle;
        private string _direccion_numero;
        private string _direccion_piso;
        private string _direccion_depto;
        private string _direccion_localidad;
        private string _direccion_pais;
        private string _nacionalidad;
        private string _fecha_nacimiento;



        //Getters y setters
        public int idCliente {
            get {return _idCliente;}
            set { _idCliente = value;}
        }

        public bool habilitado {
            get { return _habilitado; }
            set { _habilitado = value; }
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

        public string tipoDocumento {
            get { return _tipoDocumento; }
            set { _tipoDocumento = value; }
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
        public string fecha_nacimiento
        {
            get { return _fecha_nacimiento; }
            set { _fecha_nacimiento = value; }
        }


        //Constructores
        public Cliente(int id) {
            if (id != 0)
            {
                ConexionSQL conn = new ConexionSQL();

                string sqlQuery = @"SELECT * FROM WHERE_EN_EL_DELETE_FROM.Clientes WHERE cliente_id=" + id;

                DataTable dt = conn.cargarTablaSQL(sqlQuery);

                if (dt.Rows.Count > 0)
                {
                    object[] row = dt.Rows[0].ItemArray;
                     _idCliente = Convert.ToInt32(row[0]);
                    _habilitado = Convert.ToBoolean(row[2]);  //habilitado
                    _email = row[3].ToString();
                    _nombre = row[4].ToString();
                    _apellido = row[5].ToString();
                    _telefono = row[6].ToString();
                    _tipoDocumento = row[7].ToString();
                    _nrodocumento = row[8].ToString();
                    _direccion_calle = row[9].ToString();
                    _direccion_numero = row[10].ToString();
                    _direccion_piso = row[11].ToString();
                    _direccion_depto = row[12].ToString();
                    _direccion_localidad = row[13].ToString();
                    _direccion_pais = row[14].ToString();
                    _nacionalidad = row[15].ToString();
                    _fecha_nacimiento = row[16].ToString();
                }
            }
            else {
                _idCliente = 0;
                _habilitado = true;
                _email = "";
                _nombre = "";
                _apellido = "";
                _telefono = "";
                _tipoDocumento = "";
                _nrodocumento = "";
                _direccion_calle = "";
                _direccion_numero = "";
                _direccion_piso = "";
                _direccion_depto = "";
                _direccion_localidad = "";
                _direccion_pais = "";
                _nacionalidad = "";
                _fecha_nacimiento = "";
            }
            
        }

        public Cliente(int id, bool habilitado, string email, string nombre, string apellido, string telefono, string tipoDoc, string nro_documento, 
                string direccion_calle, string direccion_numero, string direccion_piso, string direccion_depto, 
            string direccion_localidad, string direccion_pais, string nacionalidad, string fecha_nacimiento)
        {
            _idCliente = id;
            _habilitado = habilitado;
            _email = email;
            _nombre = nombre;
            _apellido = apellido;
            _telefono = telefono;
            _tipoDocumento = tipoDoc;
            _nrodocumento = nro_documento;
            _direccion_calle = direccion_calle;
            _direccion_numero = direccion_numero;
            _direccion_piso = direccion_piso;
            _direccion_depto = direccion_depto;
            _direccion_localidad = direccion_localidad;
            _direccion_pais = direccion_pais;
            _nacionalidad = nacionalidad;
            _fecha_nacimiento = fecha_nacimiento;
        }

        public Cliente() { 
        }
        public Cliente getClienteById(int cliente_id) { 
            ConexionSQL conn = new ConexionSQL();

            string sqlQuery = @"SELECT * FROM WHERE_EN_EL_DELETE_FROM.Clientes WHERE cliente_id="
                + cliente_id;

            DataTable dt = conn.cargarTablaSQL(sqlQuery);

            if (dt.Rows.Count > 0)
            {
                object[] row = dt.Rows[0].ItemArray;
                return new Cliente(Convert.ToInt32(row[0]),
                                                    Convert.ToBoolean(row[2]), //habilitado
                                                    row[3].ToString(), // mail
                                                    row[4].ToString(), // nombre
                                                    row[5].ToString(), // apellido
                                                    row[6].ToString(), // telefono
                                                    row[7].ToString(), // tipoDoc
                                                    row[8].ToString(), // documento_nro
                                                    row[9].ToString(), // direccion_calle
                                                    row[10].ToString(), // direccion_nro
                                                    row[11].ToString(), // direccion_piso
                                                    row[12].ToString(), // direccion_depto
                                                    row[13].ToString(), // direccion_localidad
                                                    row[14].ToString(), // direccion_pais
                                                    row[15].ToString(), // nacionalidad
                                                    row[16].ToString());//fecha de nacimiento
            }
            else
            {
                return new Cliente(0);
            }
        
        }

        public Cliente getClienteByTipoNroDocEmail(string tipoDoc, string nroDoc, string email, string nombre, string apellido)
        {
            ConexionSQL conn = new ConexionSQL();

            string sqlQuery = "select * from WHERE_EN_EL_DELETE_FROM.Clientes cli WHERE 1=1 ";
            
            if(tipoDoc.Length > 0){
                sqlQuery += "AND documento_tipo='" + tipoDoc + "' ";
            }

            if(nroDoc.Length > 0){
                sqlQuery+= " AND documento_nro like '" + nroDoc + "%' ";
            }

            if(email.Length > 0){
                sqlQuery += " AND mail like '" + email + "%' ";
            }

            if (nombre.Length > 0) {
                sqlQuery += " AND nombre like '" + nombre + "%' ";
            }

            if (apellido.Length > 0) {
                sqlQuery += " AND apellido like '" + apellido + "%' ";
            }
            
            DataTable dt = conn.cargarTablaSQL(sqlQuery);            

            if (dt.Rows.Count > 0)
            {
                object[] row = dt.Rows[0].ItemArray;
                return new Cliente(Convert.ToInt32(row[0]),
                                                    Convert.ToBoolean(row[2]), //habilitado
                                                    row[3].ToString(), // mail
                                                    row[4].ToString(), // nombre
                                                    row[5].ToString(), // apellido
                                                    row[6].ToString(), // telefono
                                                    row[7].ToString(), // tipoDoc
                                                    row[8].ToString(), // documento_nro
                                                    row[9].ToString(), // direccion_calle
                                                    row[10].ToString(), // direccion_nro
                                                    row[11].ToString(), // direccion_piso
                                                    row[12].ToString(), // direccion_depto
                                                    row[13].ToString(), // direccion_localidad
                                                    row[14].ToString(), // direccion_pais
                                                    row[15].ToString(), // nacionalidad
                                                    row[16].ToString());

            }
            else {
                return new Cliente(0);
            }
            
        }

        public DataTable getClientes(string tipoDoc, string nroDoc, string email, string nombre, string apellido)
        {
            ConexionSQL conn = new ConexionSQL();

            string sqlQuery = "select cliente_id, CASE WHEN habilitado = 1 THEN 'SI' ELSE 'NO' END As EstaHabilitado, habilitado, nombre, apellido, documento_tipo, documento_nro, mail from WHERE_EN_EL_DELETE_FROM.Clientes cli WHERE 1=1 ";

            if (tipoDoc.Length > 0)
            {
                sqlQuery += "AND documento_tipo='" + tipoDoc + "' ";
            }

            if (nroDoc.Length > 0)
            {
                sqlQuery += " AND documento_nro like '" + nroDoc + "%' ";
            }

            if (email.Length > 0)
            {
                sqlQuery += " AND mail like '" + email + "%' ";
            }

            if (nombre.Length > 0)
            {
                sqlQuery += " AND nombre like '" + nombre + "%' ";
            }

            if (apellido.Length > 0)
            {
                sqlQuery += " AND apellido like '" + apellido + "%' ";
            }

            DataTable dt = conn.cargarTablaSQL(sqlQuery);
            //dt.Rows.InsertAt(dt.NewRow(), 0);
            return dt;

        }


        public int guardarCliente(Cliente cli) {

            SqlCommand command;
            
            int usuario_id = 1; //TODO: Leerlo del usuario logueado.

            if (cli.idCliente != 0)
            {
                command = new SqlCommand(@"UPDATE WHERE_EN_EL_DELETE_FROM.Clientes SET
                                                habilitado=@habilitado, 
                                                mail=@mail,nombre=@nombre,apellido=@apellido,telefono=@telefono,
                                                documento_tipo=@tipoDoc,
                                                documento_nro=@nrodocumento,direccion_calle=@direccion_calle,
                                                direccion_nro=@direccion_nro,direccion_piso=@direccion_piso,
                                                direccion_depto=@direccion_depto,direccion_localidad=@direccion_localidad,
                                                direccion_pais=@direccion_pais,nacionalidad=@nacionalidad,fecha_nacimiento=@fecha_nacimiento,consistente=1
                                                WHERE cliente_id=@cliente_id
                                                SELECT @@ROWCOUNT ");
            }
            else
            {
                command = new SqlCommand(@"INSERT INTO WHERE_EN_EL_DELETE_FROM.Clientes 
                                        (usuarios_id, mail, nombre, apellido, telefono, documento_tipo, documento_nro, direccion_calle, direccion_nro, direccion_piso, direccion_depto, direccion_localidad, direccion_pais, nacionalidad, fecha_nacimiento, consistente)
                                        VALUES(@usuario_id, @mail, @nombre, @apellido, @telefono, @tipoDoc, @nrodocumento, @direccion_calle, @direccion_nro, @direccion_piso, @direccion_depto, @direccion_localidad, @direccion_pais, @nacionalidad, @fecha_nacimiento, 1)
                                        SELECT SCOPE_IDENTITY() ");
            }

            command.Connection = ConexionSQL.obtenerConexion();
            command.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuario_id;
            command.Parameters.Add("@habilitado", SqlDbType.Bit).Value = cli.habilitado;
            command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = cli.email;
            command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = cli.nombre;
            command.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = cli.apellido;
            command.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = cli.telefono;
            command.Parameters.Add("@tipoDoc", SqlDbType.NVarChar).Value = cli._tipoDocumento;
            command.Parameters.Add("@nrodocumento", SqlDbType.NVarChar).Value = cli.nrodocumento;
            command.Parameters.Add("@direccion_calle", SqlDbType.NVarChar).Value = cli.direccion_calle;
            command.Parameters.Add("@direccion_nro", SqlDbType.NVarChar).Value = cli.direccion_numero;
            command.Parameters.Add("@direccion_piso", SqlDbType.NVarChar).Value = cli.direccion_piso;
            command.Parameters.Add("@direccion_depto", SqlDbType.NVarChar).Value = cli.direccion_depto;
            command.Parameters.Add("@direccion_localidad", SqlDbType.NVarChar).Value = cli.direccion_localidad;
            command.Parameters.Add("@direccion_pais", SqlDbType.NVarChar).Value = cli.direccion_pais;
            command.Parameters.Add("@nacionalidad", SqlDbType.NVarChar).Value = cli.nacionalidad;
            command.Parameters.Add("@cliente_id", SqlDbType.NVarChar).Value = cli.idCliente;
            command.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = cli.fecha_nacimiento;
            _idCliente = Convert.ToInt32(command.ExecuteScalar());

            return _idCliente; 
        }

        public bool existeClientePorDatosUnicos() {

            ConexionSQL conn = new ConexionSQL();
            string query = @"SELECT 1 FROM WHERE_EN_EL_DELETE_FROM.Clientes WHERE (mail='"+_email+
                                "' OR (documento_tipo='"+_tipoDocumento+"' AND documento_nro='"+_nrodocumento+"'))";
            if (_idCliente != 0)
            {
                query += " AND cliente_id != " + _idCliente.ToString();
            }
            
            DataTable dt = conn.cargarTablaSQL(query);
            return (dt.Rows.Count > 0);

        }

        public List<KeyValuePair<string, string>> eliminar() {

            ConexionSQL conn = new ConexionSQL();
            List<KeyValuePair<string, string>> errores = new List<KeyValuePair<string, string>>();

            string query = @"UPDATE WHERE_EN_EL_DELETE_FROM.Clientes SET habilitado = 0 WHERE cliente_id=" + _idCliente;
            DataTable dt = conn.cargarTablaSQL(query);
            try
            {
                conn.actualizarDatos(query);
            }
            catch (Exception e)
            {
                errores.Add(new KeyValuePair<string, string>("general", e.Message));
            }

            return errores;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FrbaHotel.Tools
{
    public static class DBInterface
    {
        private static SqlConnection conexion = null;
        private static SqlTransaction transaccion = null;

        public static bool conectar()
        {
            try
            {
                if (conexion == null)
                {
                    conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["FrbaHotel.Properties.Settings.Setting"].ConnectionString);
                    conexion.Open();
                    if (conexion.State.ToString() == "Open")
                    {
                        return true;
                    }

                    return false;
                }
                else
                {
                    return true;
                }
            }catch(Exception){
                throw new Exception("No fue posible establecer la conexion con la base de datos.");
            }
        }
        public static bool desconectar()
        {
            if (conexion.State.Equals("Open"))
            {
                conexion.Close();
                conexion.Dispose();
                conexion = null;

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool transaccionIniciar()
        {
            if (transaccion != null)
            {
                throw new Exception("Ya hay una transaccion en progreso.");
            }

            try
            {
                if (!conectar() || conexion.State.Equals("Close"))
                {
                    throw new Exception("No es posible iniciar la transaccion en este momento.");
                }

                transaccion = conexion.BeginTransaction();

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al iniciar la transaccion.");
            }
        }
        public static bool transaccionComitear()
        {
            if (transaccion == null)
            {
                throw new Exception("No hay una transaccion en progreso.");
            }

            try
            {
                if (conexion.State.Equals("Close"))
                {
                    throw new Exception("La conexion no esta disponible en este momento.");
                }

                transaccion.Commit();
                transaccion = null;

                return true;
            }
            catch (Exception)
            {
                try
                {
                    transaccion.Rollback();
                }
                catch
                {
                    throw new Exception("Ocurrio un error al comitear la transaccion y no pudo ser revertida.");
                }

                throw new Exception("Ocurrio un error al comitear la transaccion");
            }
        }
        public static bool transaccionRevertir()
        {
            if (transaccion == null)
            {
                throw new Exception("No hay una transaccion en progreso.");
            }

            try
            {
                if (conexion.State.Equals("Close"))
                {
                    throw new Exception("La conexion no esta disponible en este momento.");
                }

                transaccion.Rollback();
                transaccion = null;

                return true;
            }
            catch (Exception)
            {
                throw new Exception("La transaccion no pudo ser revertida.");
            }
        }

        public static int insertar(string sql, bool getId = false)
        {
            try
            {
                if (!conectar() || conexion.State.Equals("Close"))
                {
                    throw new Exception("No es posible insertar el registro en este momento.");
                }

                SqlCommand comando = new SqlCommand(string.Format(sql), conexion);
                comando.CommandType = CommandType.Text;
                if (getId)
                {
                    return Convert.ToInt32(comando.ExecuteScalar());
                }
                else
                {
                    return comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al insertar el registro.");
            }
        }
        public static int insertar(string sql, List<SqlParameter> parametros, bool getId = false)
        {
            try
            {
                if (!conectar() || conexion.State.Equals("Close"))
                {
                    throw new Exception("No es posible insertar el registro en este momento.");
                }

                if (getId)
                {
                    sql = sql + "SELECT SCOPE_IDENTITY()";
                }

                SqlCommand comando = new SqlCommand(string.Format(sql), conexion);
                comando.CommandType = CommandType.Text;
                foreach (SqlParameter parametro in parametros)
                {
                    comando.Parameters.Add(parametro);
                }

                if (getId)
                {
                    return Convert.ToInt32(comando.ExecuteScalar());
                }
                else
                {
                    return comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al insertar el registro.");
            }
        }

        public static int actualizar(string sql)
        {
            try
            {
                if (!conectar() || conexion.State.Equals("Close"))
                {
                    throw new Exception("No es posible actualizar el registro en este momento.");
                }


                SqlCommand comando = new SqlCommand(string.Format(sql), conexion);
                comando.CommandType = CommandType.Text;

                return comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("No puede actualizarse el registro en este momento.");
            }
        }
        public static int actualizar(string sql, List<SqlParameter> parametros)
        {
            try
            {
                if (!conectar() || conexion.State.Equals("Close"))
                {
                    throw new Exception("No es posible actualizar el registro en este momento.");
                }

                SqlCommand comando = new SqlCommand(string.Format(sql), conexion);
                comando.CommandType = CommandType.Text;
                foreach (SqlParameter parametro in parametros)
                {
                    comando.Parameters.Add(parametro);
                }

                return comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("No puede actualizarse el registro en este momento.");
            }
        }

        public static int borrar(string sql)
        {
            try
            {
                if (!conectar() || conexion.State.Equals("Close"))
                {
                    throw new Exception("No es posible borrar el registro en este momento.");
                }


                SqlCommand comando = new SqlCommand(string.Format(sql), conexion);
                comando.CommandType = CommandType.Text;

                return comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("No puede borrarse el registro en este momento.");
            }
        }
        public static int borrar(string sql, List<SqlParameter> parametros)
        {
            try
            {
                if (!conectar() || conexion.State.Equals("Close"))
                {
                    throw new Exception("No es posible borrar el registro en este momento.");
                }

                SqlCommand comando = new SqlCommand(string.Format(sql), conexion);
                comando.CommandType = CommandType.Text;
                foreach (SqlParameter parametro in parametros)
                {
                    comando.Parameters.Add(parametro);
                }

                return comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("No puede borrarse el registro en este momento.");
            }
        }

        public static DataTable seleccionar(string sql){
            try
            {
                if (!conectar() || conexion.State.Equals("Close"))
                {
                    throw new Exception("No es posible obtener la informacion solicitada en este momento.");
                }

                SqlCommand comando = new SqlCommand(string.Format(sql), conexion);
                comando.CommandType = CommandType.Text;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);

                DataTable data = new DataTable();
                dataAdapter.Fill(data);
                return data;
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al recuperar la informacion solicitada.");
            }
        }
        public static DataTable seleccionar(string sql, List<SqlParameter> parametros)
        {
            try
            {
                if (!conectar() || conexion.State.Equals("Close"))
                {
                    throw new Exception("No es posible obtener la informacion solicitada en este momento.");
                }

                SqlCommand comando = new SqlCommand(string.Format(sql), conexion);
                comando.CommandType = CommandType.Text;
                foreach (SqlParameter parametro in parametros)
                {
                    comando.Parameters.Add(parametro);
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);

                DataTable data = new DataTable();
                dataAdapter.Fill(data);
                return data;
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al recuperar la informacion solicitada.");
            }
        }
    }
}

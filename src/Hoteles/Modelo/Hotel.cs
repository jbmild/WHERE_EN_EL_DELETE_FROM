using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaHotel.Tools;

namespace FrbaHotel.Hoteles.Modelo
{
    public class Hotel
    {
        private int hotel_id;
        private string nombre;
        private string email;
        private string telefono;
        private string direccion;
        private string ciudad;
        private string pais;
        private int estrellas_cant;
        private int estrellas_recargo;
        private DateTime fecha_creacion;

        public int HotelId
        {
            get { return hotel_id; }
            set { hotel_id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }
        public int EstrellasCant
        {
            get { return estrellas_cant; }
            set { estrellas_cant = value; }
        }
        public int EstrellasRecargo
        {
            get { return estrellas_recargo; }
            set { estrellas_recargo = value; }
        }
        public DateTime FechaCreacion
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }
        }

        public Hotel(int hotelId)
        {
            if (hotelId > 0)
            {
                List<SqlParameter> parametros = new List<SqlParameter>();

                SqlParameter parametro = new SqlParameter("@hotelId", hotelId);
                parametro.DbType = DbType.Int32;
                parametros.Add(parametro);

                string sql = "SELECT hotel_id, nombre, mail, telefono, direccion, ciudad, pais, estrellas_cant, estrellas_recargo, fecha_creacion FROM WHERE_EN_EL_DELETE_FROM.hoteles WHERE hotel_id=@hotelId";
                DataTable data = DBInterface.seleccionar(sql, parametros);

                if (data.Rows.Count == 1)
                {
                    this.hotel_id = Convert.ToInt32(data.Rows[0][0]);
                    this.nombre = data.Rows[0][1].ToString();
                    this.email = data.Rows[0][2].ToString();
                    this.telefono = data.Rows[0][3].ToString();
                    this.direccion = data.Rows[0][4].ToString();
                    this.ciudad = data.Rows[0][5].ToString();
                    this.pais = data.Rows[0][6].ToString();
                    this.estrellas_cant = Convert.ToInt32(data.Rows[0][7]);
                   
                    this.estrellas_recargo = Convert.ToInt32(data.Rows[0][8]);
                   
                    this.fecha_creacion = Convert.ToDateTime(data.Rows[0][9]);
                }
            }
            else
            {
                this.hotel_id = 0;
                this.nombre = "";
                this.email = "";
                this.telefono = "";
                this.direccion = "";
                this.ciudad = "";
                this.pais = "";
                this.estrellas_cant = 0;
                this.estrellas_recargo = 0;
            }
        }

        public Hotel()
        {
            this.hotel_id = 0;
            this.nombre = "";
            this.email = "";
            this.telefono = "";
            this.direccion = "";
            this.ciudad = "";
            this.pais = "";
            this.estrellas_cant = 0;
            this.estrellas_recargo = 0;
        }
    }
}

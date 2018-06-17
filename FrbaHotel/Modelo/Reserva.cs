﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FrbaHotel.Modelo
{
    public class Reserva
    {
        private int _id;
        private DateTime _fecha_desde;
        private DateTime _fecha_hasta;
        //private DateTime _fecha_creacion;
        private int _cliente_id;
        //private string _codigo;
        //private string _estado;
        private decimal _total;
        private int _regimen_id;
        private int _hotel_id;
        private List<Habitacion> _habitaciones;
        //completar atributos

        //nueva reserva
        public Reserva(DateTime fd, DateTime fh, int cliente_id, decimal total, int regimen_id, int hotel_id, List<Habitacion> habitaciones) {
            _fecha_desde = fd;
            _fecha_hasta = fh;
            _cliente_id = cliente_id;
            _total = total;
            _regimen_id = regimen_id;
            _hotel_id = hotel_id;
            _habitaciones = habitaciones;
        }

        //Getters y setters
        public int id {
            get { return _id; }
            set { _id = value;  }
        }

        public DateTime fecha_desde {
            get { return _fecha_desde; }
            set { _fecha_desde = value; }
        }

        public DateTime fecha_hasta
        {
            get { return _fecha_hasta; }
            set { _fecha_hasta = value; }
        }

        public int cliente_id {
            get { return _cliente_id; }
            set { _cliente_id = value; }
        }

        public decimal total {
            get { return _total; }
            set { _total = value; }
        }

        public int regimen_id {
            get { return _regimen_id; }
            set { _regimen_id = value; }
        }

        public int hotel_id
        {
            get { return _hotel_id; }
            set { _hotel_id = value; }
        }

        private List<Habitacion> habitaciones {
            get { return _habitaciones; }
            set { _habitaciones = value; }
        }
    }
}

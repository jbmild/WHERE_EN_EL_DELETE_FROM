using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmHabitacion
{
    class Consulta
    {
        private string query="";

        public string GetQuery() {
            return this.query;
        }
        public void ConcatToQuery(string text) {
            this.query = this.query + text;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDS
{
    class Receta
    {
       public string medicamento { get; set; }
        public string desc { get; set; }
        public DateTime fecha { get; set; }
        public int iddoc { get; set; }
        public int idaf { get; set; }

        public Receta()
        {

        }
        public Receta(string medi, string des, DateTime date, int idd, int idaf)
        {
            this.medicamento = medi;
            this.desc = des;
            this.fecha = date;
            this.iddoc = idd;
            this.idaf = idaf;
        }

    }
}

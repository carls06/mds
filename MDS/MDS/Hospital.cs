using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDS
{
    class Hospital
    {
        public int id_hospital { get; set; }
        public string nombre_hospital { get; set; }

        public Hospital()
        {

        }

        public Hospital(int id, string nombre) {
            this.id_hospital = id;
            this.nombre_hospital = nombre;

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDS
{
    class Afiliador:Usuario
    {
        public int id_afiliador { get; set; }
        public string contraseña { get; set; }

        public Afiliador()
        {

        }
        public Afiliador(int id, string contraseña, string nom, string apellido, int edad, string dui, string direc, string sexo, string tel, string email
            , string laboral, string sangre, string alergico, string civil) :base( id,nom, apellido, edad, dui, direc, sexo, tel, email, laboral, sangre, alergico, civil)
        {
            this.id_afiliador = id;
            this.nombre = nom;
            this.apellido = apellido;
            this.edad = edad;
            this.dui = dui;
            this.direccion = direc;
            
            this.contraseña = contraseña;
        }



    }
}

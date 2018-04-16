using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDS
{
    class Doctor:Usuario
    {
        public int id_doctor { get; set; }
        public string especialidad { get; set; }
        public string contraseña { get; set; }


        public Doctor()
        {

        }
        public Doctor(int id,string especialidad, string contraseña, string nom, string apellido, int edad, string dui, string direc, string sexo, string tel, string email
          , string laboral, string sangre, string alergico, string civil) : base(id, nom, apellido, edad, dui, direc, sexo, tel, email, laboral, sangre, alergico, civil)
        {
            this.id_doctor = id;
            this.especialidad = especialidad;
            this.contraseña = contraseña;
            this.nombre = nom;
            this.apellido = apellido;
            this.edad = edad;
            this.dui = dui;
            this.direccion = direc;
        }






    }
}

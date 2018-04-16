using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDS
{
    class Usuario
    {
        public int id_afiliado { get; set; }
        public string nombre {get; set;}
        public string apellido { get; set; }
        public int edad { get; set; }
        public string dui { get; set; }
        public string direccion { get; set; }
        public string sexo { get; set; }
        public string telefono { get; set; }
        public string emai { get; set; }
        public string estado_laboral { get; set; }
        public string Tipo_de_sangre { get; set; }
        public string alergico { get; set; }
        public string estado_civil { get; set; }



         public Usuario() { }

        public Usuario(int id,string nom, string apellido, int edad,string dui, string direc, string sexo,string tel,string email
            ,string laboral, string sangre, string alergico, string civil)
        {
            this.id_afiliado = id;
            this.nombre = nom;
            this.apellido = apellido;
            this.edad = edad;
            this.dui = dui;
            this.direccion = direc;
            this.sexo = sexo;
            this.telefono = tel;
            this.emai = emai;
            this.estado_laboral = laboral;
            this.Tipo_de_sangre = sangre;
            this.alergico = alergico;
            this.estado_civil = civil;
        }














        public string usuario { get; set; }
        public string pass { get; set; }


       

        public Usuario(string user, string pass)
        {
            this.usuario = user;
            this.pass = pass;
        }
    }
}

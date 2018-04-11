using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDS
{
    class Usuario
    {
        public string usuario {get; set;}
        public string pass { get; set; }

        public Usuario() { }

        public Usuario(string user, string pass)
        {
            this.usuario = user;
            this.pass = pass;
        }
    }
}

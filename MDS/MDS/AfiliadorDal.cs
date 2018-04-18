using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MDS
{
    class AfiliadorDal
    {

        public static int Agregar_Afiliador(Afiliador afili)
        {
            int retorno = 0;

            ///INSERT INTO `afiliador`(`id_afiliador`, ) VALUES ([value-1],[value-2],[value-3],[value-4],[value-5],[value-6],[value-7])

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into afiliador (`nombre`, `apellido`, `edad`, `direccion`, `dui`, `contraseña`) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                afili.nombre,afili.apellido,afili.edad,afili.direccion,afili.dui,afili.contraseña), BdComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }



    }
}

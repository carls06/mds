using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Reflection;

namespace MDS
{
    class UserDal

    {


        public static int Agregar_prueba(Usuario pCliente)
        {
            int retorno = 0;



            MySqlCommand comando = new MySqlCommand(string.Format("Insert into ingreso (Nombre, pass) values ('{0}','{1}')",
                pCliente.usuario, pCliente.pass), BdComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        //public void ListarProveedor(ComboBox cb)
        //{
        //    List<Usuario> Lista = new List<Usuario>();
        //    using (MySqlConnection conexion = BdComun.ObtenerConexion())
        //    {

        //        MySqlCommand comando = new MySqlCommand(string.Format("Select  nombre from ingreso"), conexion);

        //        MySqlDataReader reader = comando.ExecuteReader();

        //        while (reader.Read())
        //        {

        //            Proveedor proveedor = new Proveedor();

        //            cb.Items.Add(reader.GetString(0));
        //        }
        //        conexion.Close();


        //    }
        //}






    }
}

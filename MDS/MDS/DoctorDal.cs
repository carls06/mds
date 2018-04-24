using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MDS
{
    class DoctorDal
    {
        public static int Agregar_Doc(Doctor doc)
        {
            int retorno = 0;
            try
            {


                // INSERT INTO `doctores`( `nombre`, `apellido`, `edad`, `direccion`, `especialidad`, `dui`, `contraseña`) VALUES ([value-1],[value-2],[value-3],[value-4],[value-5],[value-6],[value-7],[value-8])

                MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO `doctores`( `nombre`, `apellido`, `edad`, `direccion`, `especialidad`, `dui`, `contraseña`) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                    doc.nombre, doc.apellido, doc.edad, doc.direccion, doc.especialidad, doc.dui, doc.contraseña), BdComun.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();

                return retorno;
            }
            catch
            {

                return retorno;
            }

        }



        public void ListarDocGeneral(ComboBox cb)
        {
            List<Doctor> Lista = new List<Doctor>();
            using (MySqlConnection conexion = BdComun.ObtenerConexion())
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Select  nombre  from doctores where especialidad like 'General'"), conexion);

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    // Proveedor proveedor = new Proveedor();

                    cb.Items.Add(reader.GetString(0));
                }
                conexion.Close();


            }
        }

        public void ListarDocespecialidad(ComboBox cb)
        {
            List<Doctor> Lista = new List<Doctor>();
            using (MySqlConnection conexion = BdComun.ObtenerConexion())
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Select  nombre  from doctores where especialidad like '%gia'"), conexion);

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    // Proveedor proveedor = new Proveedor();

                    cb.Items.Add(reader.GetString(0));
                }
                conexion.Close();


            }
        }


    }
}

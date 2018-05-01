using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

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



        public void ListarDocGeneral(ComboBox cb, List<int> id_doc)
        {
            
            using (MySqlConnection conexion = BdComun.ObtenerConexion())
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Select  nombre, apellido, id_doctor  from doctores where especialidad like 'General'"), conexion);

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    if (num_consulta(reader.GetString(2)) <= 10)
                    {
                        cb.Items.Add(reader.GetString(0) + " " + reader.GetString(1));
                        id_doc.Add((int)reader.GetValue(2));
                    }
                }
                conexion.Close();               
            }
        }

        public void ListarDocespecialidad(ComboBox cb)
        {      
            using (MySqlConnection conexion = BdComun.ObtenerConexion())
            {
                MySqlCommand comando2 = new MySqlCommand(string.Format("select nombre, apellido from doctores where especialidad like '%gia'"), conexion);
                MySqlDataReader reader = comando2.ExecuteReader();

                while (reader.Read())
                {                   
                    cb.Items.Add(reader.GetString(0)+ " "+ reader.GetString(1));
                }                
                conexion.Close();                
            }
        }

        public int num_consulta(string id_doc)
        {
            int cantidad = 0;
            using (MySqlConnection conexion = BdComun.ObtenerConexion())
            {
                MySqlCommand comando2 = new MySqlCommand("select count(id_doctor) as 'N_Consultas' from cita where id_doctor ='"+ id_doc + "'", conexion);
                MySqlDataReader dato = comando2.ExecuteReader();
                while (dato.Read())
                {
                    cantidad = dato.GetInt32(0);
                }
                conexion.Close();
            }
            
            return cantidad;
        }

    }
}

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

        public void ListarDocespecialidad(ComboBox cb, List<int> id_doc)
        {
            using (MySqlConnection conexion = BdComun.ObtenerConexion())
            {
                MySqlCommand comando2 = new MySqlCommand(string.Format("select nombre, apellido, id_doctor, especialidad from doctores where especialidad like '%gia'"), conexion);
                MySqlDataReader reader = comando2.ExecuteReader();
                while (reader.Read())
                {
                    if (num_consulta(reader.GetString(2)) <= 10)
                    {
                        cb.Items.Add(reader.GetString(0) + " " + reader.GetString(1) + " -> " + reader.GetString(3));
                        id_doc.Add((int)reader.GetValue(2));
                    }
                }
                conexion.Close();
            }
        }

        public void ListaDoc_por_cita(ComboBox cb, List<int> id_doc)
        {
            using (MySqlConnection conexion = BdComun.ObtenerConexion())
            {
                MySqlCommand comando2 = new MySqlCommand(string.Format("select nombre, apellido, id_doctor, especialidad from doctores where especialidad like '%.'"), conexion);
                MySqlDataReader reader = comando2.ExecuteReader();

                while (reader.Read())
                {
                    if (num_consulta(reader.GetString(2)) <= 10)
                    {
                        cb.Items.Add(reader.GetString(0) + " " + reader.GetString(1) + " -> " + reader.GetString(3));
                        id_doc.Add((int)reader.GetValue(2));
                    }
                }
                conexion.Close();
            }
        }

        public void ListaDoc_por_cita(ComboBox cb, List<int> id_doc)
        {
            using (MySqlConnection conexion = BdComun.ObtenerConexion())
            {
                MySqlCommand comando2 = new MySqlCommand(string.Format("select nombre, apellido, id_doctor, especialidad from doctores where especialidad like '%.'"), conexion);
                MySqlDataReader reader = comando2.ExecuteReader();

                while (reader.Read())
                {
                    if (num_consulta(reader.GetString(2)) <= 10)
                    {
                        cb.Items.Add(reader.GetString(0) + " " + reader.GetString(1) + " -> " + reader.GetString(3));
                        id_doc.Add((int)reader.GetValue(2));
                    }
                }
                conexion.Close();
            }
        }

        public int num_consulta(string id_doc)
        {
            int cantidad = 0;
            using (MySqlConnection conexion = BdComun.ObtenerConexion())
            {
                MySqlCommand comando2 = new MySqlCommand("select count(id_doctor) as 'N_Consultas' from cita where id_doctor ='" + id_doc + "'", conexion);
                MySqlDataReader dato = comando2.ExecuteReader();
                while (dato.Read())
                {
                    cantidad = dato.GetInt32(0);
                }
                conexion.Close();
            }

            return cantidad;
        }

        public string Nombre_doc(int id_doc)
        {
            string nombre = "";
            string c = "select nombre, apellido, id_doctor from doctores where id_doctor ='" + id_doc + "'";
            using (MySqlConnection conexion = BdComun.ObtenerConexion())
            {
                MySqlCommand comando2 = new MySqlCommand(string.Format(c), conexion);
                MySqlDataReader dato = comando2.ExecuteReader();
                while (dato.Read())
                {
                    nombre = dato.GetString(0) + " " + dato.GetString(1);
                }
                conexion.Close();
                return nombre;
            }
        }

        public static int Agregar_recetas(Receta afili)
        {
            int retorno = 0;
            try
            {
                // insert into receta (id_afiliado, id_doctor, nombre_de_medicamento, descripcion, fecha_de_receta)values (505,5,'salbutamol', 'tomar cada 8 horas', sysdate()) (505,5,'salbutamol', 'tomar cada 8 horas', sysdate())

                MySqlCommand comando = new MySqlCommand(string.Format("insert into receta (id_afiliado, id_doctor, nombre_de_medicamento, descripcion, fecha_de_receta)values ('{0}','{1}','{2}','{3}','{4}')",
                  afili.idaf, afili.iddoc, afili.medicamento, afili.desc, afili.fecha), BdComun.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();

                return retorno;
            }
            catch
            {

                return retorno;
            }

        }

    }
}

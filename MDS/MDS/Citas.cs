using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace MDS
{
    class Citas
    {
        bool estado { get; set; }
        DateTime prox_cita { get; set; }
        DateTime hora_cita { get; set; }

        public void consulta_general(string prox_cita, string hora_cita, int id_afiliado, int id_doctor)
        {
            using (MySqlConnection cn = BdComun.ObtenerConexion())
            {
                try
                {
                    MySqlCommand comando = cn.CreateCommand();
                    comando.CommandText = "INSERT INTO cita(Prox_cita,hora_cita,id_afiliado,id_doctor) VALUES(?Prox_cita,?hora_cita,?id_afiliado,?id_doctor)";
                    comando.Prepare();
                    comando.Parameters.AddWithValue("?Prox_cita", Convert.ToDateTime(prox_cita));
                    comando.Parameters.AddWithValue("?hora_cita", hora_cita);
                    comando.Parameters.AddWithValue("?id_afiliado", id_afiliado);
                    comando.Parameters.AddWithValue("?id_doctor", id_doctor);
                    comando.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Consulta ingresada");
                }
                catch
                {
                    MessageBox.Show("Error ");
                }

            }
        }

        public void consulta_cita(string prox_cita, string hora_cita, int id_afiliado, int id_doctor)
        {
            using (MySqlConnection cn = BdComun.ObtenerConexion())
            {
                try
                {
                    MySqlCommand comando = cn.CreateCommand();
                    comando.CommandText = "INSERT INTO cita(Prox_cita,hora_cita,id_afiliado,id_doctor) VALUES(?Prox_cita,?hora_cita,?id_afiliado,?id_doctor)";
                    comando.Prepare();
                    comando.Parameters.AddWithValue("?Prox_cita", Convert.ToDateTime(prox_cita));
                    comando.Parameters.AddWithValue("?hora_cita", hora_cita);
                    comando.Parameters.AddWithValue("?id_afiliado", id_afiliado);
                    comando.Parameters.AddWithValue("?id_doctor", id_doctor);
                    comando.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Consulta ingresada");
                }
                catch
                {
                    MessageBox.Show("Error ");
                }

            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MDS
{
    class HospitalDal
    {


        public void ListarHospitales(ComboBox cb)
        {
            List<Hospital> Lista = new List<Hospital>();
            using (MySqlConnection conexion = BdComun.ObtenerConexion())
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Select  nombreh  from hospital"), conexion);

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

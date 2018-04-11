using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MDS
{
    public class Conexion
    {
        private static string conex;
        private static MySqlConnection conectar;
        private DataSet dst;
        private MySqlDataAdapter adaptador;

        public void Conec()
        {
            try
            {
                conex = @"Server=205.134.252.210;Database=mdsxyz_mdsbd; Uid=mdsxyz_user; Pwd=carmando6; port=3306; ";
                conectar = new MySqlConnection(conex);
                conectar.Open();

                MessageBox.Show("conexion exitosa");
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        
    }
}

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
    public partial class Login : Form
    {
        string usu,pas ,id;
      
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Usuario pCliente = new Usuario();
            //pCliente.usuario = usuariotxt.Text.Trim();
            //pCliente.pass = passtxt.Text.Trim();


            //int resultado = UserDal.Agregar_prueba(pCliente);
            //if (resultado > 0)
            //{
            //    MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}


            inicio();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }



        public void inicio()
        {
            using (MySqlConnection cn = BdComun.ObtenerConexion())
            {
                try
                {
                    string idsesion = usuariotxt.Text;
                    string pass = passtxt.Text;

                    if (idsesion != null)
                    {
                        if (pass != null)
                        {
                            MySqlCommand comando = new MySqlCommand("SELECT usuario, contraseña, id_doctor,id_afiliador FROM `usuario` WHERE usuario= '" + idsesion + "'and contraseña = '" + pass + "' ", cn);
                            //cn.Open();
                            comando.ExecuteNonQuery();
                            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
                            DataTable prueba = new DataTable();
                            adapt.Fill(prueba);

                           
                               id = (prueba.Rows[0][2].ToString());
                            usu = prueba.Rows[0][3].ToString();
                            


                            if ((idsesion == prueba.Rows[0][0].ToString()) || (pass == prueba.Rows[0][1].ToString()))
                            {
                                
                                if (id == "" && usu != "")
                                {
                                    Menu_administrativo adm = new Menu_administrativo();
                                    adm.Show();
                                    this.Hide();
                                }
                                else if (usu == "" && id != "") 
                                {
                                    Menu_doc lol = new Menu_doc();
                                    lol.Show();
                                    this.Hide();
                                }
                            }
                           

                        }
                    }
                }
                catch
                {
                  
                    MessageBox.Show("Error! Su contraseña y/o usuario son invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

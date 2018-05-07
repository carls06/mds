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
        public string usu, id, doc;

        public Login()
        {
            InitializeComponent();
            usuariotxt.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            inicio2();
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

                            MySqlCommand comando = new MySqlCommand("SELECT usuario, contraseña, id_doctor, id_afiliador FROM `usuario`  WHERE usuario.usuario = '" + idsesion + "'and usuario.contraseña = '" + pass + "' ", cn);
                            //cn.Open();

                            comando.ExecuteNonQuery();
                            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
                            DataTable prueba = new DataTable();
                            adapt.Fill(prueba);


                            id = prueba.Rows[0][2].ToString();
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

                                    //Menu_doc lol = new Menu_doc();
                                    //lol.nomdoc(idsesion);
                                    //lol.Show();

                                    //this.Hide();
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

        private void passtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.inicio2();
        }

        public void inicio2()
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
                            //Comando afiliador
                            MySqlCommand comando = new MySqlCommand("select exists(select * from afiliador where dui = '" + idsesion + "' and contraseña = '" + pass + "')", cn);
                            comando.ExecuteNonQuery();
                            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
                            DataTable prueba = new DataTable();
                            adapt.Fill(prueba);
                            //Comando Doctor
                            MySqlCommand comando2 = new MySqlCommand("select exists(select * from doctores where dui = '" + idsesion + "' and contraseña = '" + pass + "')", cn);
                            comando.ExecuteNonQuery();
                            MySqlDataAdapter adapt2 = new MySqlDataAdapter(comando2);
                            DataTable prueba2 = new DataTable();
                            adapt2.Fill(prueba2);
                            //Comando Ingreso (menu administrativo)
                            MySqlCommand comando3 = new MySqlCommand("select exists(select * from usuario where usuario = '" + idsesion + "' and contraseña = '" + pass + "')", cn);
                            comando.ExecuteNonQuery();
                            MySqlDataAdapter adapt3 = new MySqlDataAdapter(comando3);
                            DataTable prueba3 = new DataTable();
                            adapt3.Fill(prueba3);

                            //Condicional para ingresar al Menu Afiliador
                            if (Convert.ToInt32(prueba.Rows[0][0]) == 1)
                            {
                                Menu_administrativo adm = new Menu_administrativo();
                                adm.Show();
                                this.Hide();
                            }
                            //Condicional para ingresar al Menu Doctor
                            else if(Convert.ToInt32(prueba2.Rows[0][0]) == 1)
                            {
                                Menu_doc lol = new Menu_doc();
                                lol.nomdoc(idsesion);
                                lol.Show();
                                this.Hide();
                            }
                            //Condicional para ingresar al Menu Administrativo
                            else if (Convert.ToInt32(prueba3.Rows[0][0]) == 1)
                            {
                                Menu_administrativo adm = new Menu_administrativo();
                                adm.Show();
                                this.Hide();
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

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
    public partial class Ver : Form
    {
        public Ver()
        {
            InitializeComponent();
        }


        int dato = 0;

        public int data(int dat)
        {
            dato = dat;
            return dato;
        }
        private void Afiliados_ver_Load(object sender, EventArgs e)
        {
           
            
            if (dato == 1)
            {
                using (MySqlConnection cn = BdComun.ObtenerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("Select `nombre`, `apellido`, `edad`, `estado_civil`, `telefono`, `dui`, `email`, `direccion`, `tipo_de_sagre`, `alergico_a`, `Estado_laboral` FROM `afiliados`", cn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    cn.Close();
                }
            }else if (dato == 2)
            {
                using (MySqlConnection cn = BdComun.ObtenerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("Select `nombre`, `apellido`, `edad`, `direccion`, `especialidad`, `dui` FROM `doctores`", cn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    cn.Close();
                }
            }else if (dato == 3)
            {
                using (MySqlConnection cn = BdComun.ObtenerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("Select  `nombre`, `apellido`, `edad`, `direccion`, `dui` FROM `afiliador`", cn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    cn.Close();
                }

            }

            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_administrativo adm = new Menu_administrativo();
            adm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


            if (dato == 1)
            {
                using (MySqlConnection cn = BdComun.ObtenerConexion())
                {

                        MySqlCommand cmd = new MySqlCommand("Select `nombre`, `apellido`, `edad`, `estado_civil`, `telefono`, `dui`, `email`, `direccion`, `tipo_de_sagre`, `alergico_a`, `Estado_laboral` FROM `afiliados` where dui = '" + duitxt.Text + "'", cn);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];

                    if (ds.Tables[0].ToString() == null)
                    {
                        MessageBox.Show("No se encontro afiliado, ingrese otro dui");
                    }

                        cn.Close();



                   

                }
                
            }
            else if (dato == 2)
            {
                using (MySqlConnection cn = BdComun.ObtenerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("Select `nombre`, `apellido`, `edad`, `direccion`, `especialidad`, `dui` FROM `doctores` where dui = '" + duitxt.Text +"'", cn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    cn.Close();
                }
            }
            else if (dato == 3)
            {
                using (MySqlConnection cn = BdComun.ObtenerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("Select  `nombre`, `apellido`, `edad`, `direccion`, `dui` FROM `afiliador` where dui = '" + duitxt.Text + "'", cn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    cn.Close();
                }

            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}

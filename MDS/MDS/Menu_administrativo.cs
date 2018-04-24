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
    public partial class Menu_administrativo : Form
    {
        public Menu_administrativo()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
            radioButton1.Checked = true;
        }
        int refe = 0;

        private void afiliadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refe = 1;

            Ver afiliado = new Ver();
            afiliado.data(refe);
            afiliado.Show();
            this.Hide();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administrativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refe = 2;
            Ver afiliado = new Ver();
            afiliado.data(refe);
            afiliado.Show();
            this.Hide();
        }

             DoctorDal lis = new DoctorDal();
        private void Menu_administrativo_Load(object sender, EventArgs e)
        {
            if(radioButton1.Checked== true)
            {
                
                lis.ListarDocGeneral(comboBox1);
            }else if (radioButton2.Checked == true)
            {
                
                lis.ListarDocespecialidad(comboBox1);
            }
        }

        private void afiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Afiliado_form afil = new Afiliado_form();
            afil.Show();
            this.Hide();
        }

        private void doctorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            refe = 3;
            Ver afiliado = new Ver();
            afiliado.data(refe);
            afiliado.Show();
            this.Hide();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void afiliadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor_formulario doc = new Doctor_formulario();
            doc.Show();
            this.Hide();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrativo_Formulario adm = new Administrativo_Formulario();
            adm.Show();
            this.Hide();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        string nom, ape, eda;

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cn = BdComun.ObtenerConexion())
            {

                string dui = duitxt.Text;
                try
                {
                    MessageBox.Show("conexion realizada" + dui);
                    MySqlCommand comando = new MySqlCommand("SELECT nombre, apellido, edad FROM afiliados  WHERE dui = '" + dui + "'", cn);
                    //cn.Open();
                    comando.ExecuteNonQuery();
                    MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
                    DataTable prueba = new DataTable();
                    adapt.Fill(prueba);


                    


                    nom = prueba.Rows[0][0].ToString();
                    ape = prueba.Rows[0][1].ToString();
                    eda = prueba.Rows[0][2].ToString();


                lblnom.Text = nom;
                lblape.Text = ape;
                lbledad.Text = eda;


                    groupBox2.Enabled = true;





                }
                catch
                {


                    MessageBox.Show("Error! Dui  invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
    }
}

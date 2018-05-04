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
        public List<int> id_doc = new List<int>();
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

            
        private void Menu_administrativo_Load(object sender, EventArgs e)
        {
           
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
        int id_afiliado;
        public string id_doctor = "";
        int indice;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DoctorDal lis = new DoctorDal();            
            lis.ListarDocGeneral(comboBox1, id_doc);
            cmbDoctor.Items.Clear();
            //id_doc.Clear();
            comboBox1.Visible = true;
            comboBox1.SelectedIndex = 0;
            cmbDoctor.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DoctorDal lis2 = new DoctorDal();
            lis2.ListarDocespecialidad(cmbDoctor);
            comboBox1.Items.Clear();
            cmbDoctor.Visible = true;
            comboBox1.Visible = false;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            string daate = fecha.Date.ToString("yyyy-MM-dd");
            string hora = fecha.ToLocalTime().ToString("HH:mm");
            indice = comboBox1.SelectedIndex;

            //MessageBox.Show(id_doc[indice].ToString());
            try
            {
                Citas inserta_cita = new Citas();
                inserta_cita.consulta_general(daate, hora, id_afiliado, id_doc[indice]);
                //limpiar();
            }
            catch
            {

            }
          
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cn = BdComun.ObtenerConexion())
            {

                string dui = duitxt.Text;
                try
                {
                    //MessageBox.Show("conexion realizada" + dui);
                    MySqlCommand comando = new MySqlCommand("SELECT nombre, apellido, edad, id_afiliado FROM afiliados  WHERE dui = '" + dui + "'", cn);
                    //cn.Open();
                    comando.ExecuteNonQuery();
                    MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
                    DataTable prueba = new DataTable();
                    adapt.Fill(prueba);                   

                    nom = prueba.Rows[0][0].ToString();
                    ape = prueba.Rows[0][1].ToString();
                    eda = prueba.Rows[0][2].ToString();
                    id_afiliado = (int)prueba.Rows[0][3];


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

        public void limpiar()
        {
            lblnom.Text = "";
            lblape.Text = "";
            lbledad.Text = "";
            duitxt.Text = "";
        }
    }
}

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
    public partial class Menu_doc : Form
    {
        public Menu_doc()
        {
            InitializeComponent();
              
        }
        
        

        public void nomdoc(string dui)
        {
            string name;
            using (MySqlConnection cn = BdComun.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("Select `nombre` FROM `doctores` where dui = " +dui , cn);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);
                name = ds.Rows[0][0].ToString();
                cn.Close();
            }

            label1.Text = name;
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nuevoPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            duitxt.Text = "";
            dataGrid_paciente.Rows.Clear();
            dataGrid_recetaPaciente.Rows.Clear();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //SELECT afiliados.nombre, afiliados.apellido, afiliados.dui, cita.Prox_cita, examenes.nombre_de_exam FROM afiliados INNER JOIN cita ON afiliados.id_afiliado=cita.id_afiliado INNER JOIN examenes ON  afiliados.id_afiliado = examenes.id_afiliado WHERE afiliados.dui like '" +duitxt.text+'");

        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Citas_formulario citas = new Citas_formulario();
            citas.Show();
            citas.label11.Text = label1.Text;
            
        }

        private void recetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recetas_formulario recetas = new Recetas_formulario();
            recetas.Show();
            recetas.label10.Text = label1.Text;
            
        }

        private void examenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Examenes_formulario exam = new Examenes_formulario();
            exam.Show();
            exam.label20.Text = label1.Text;
            
        }

        private void referenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Referencias_formulario referencias = new Referencias_formulario();
            referencias.Show();
            referencias.label10.Text = label1.Text;
            
        }

        private void menu_doc_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }
    }
}

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
        string name, apellido, especialidad, id_doctor;
        string name2, apellido2;
        Queue<string> Id_Afi = new Queue<string>();
        public Menu_doc()
        {
            InitializeComponent();

        }
        //este metodo ya es funcinal para este formulario para los datos del doctor
        public void nomdoc(string dui)
        {            
            using (MySqlConnection cn = BdComun.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("select nombre, apellido, especialidad, id_doctor from doctores where dui = '"+dui+"'", cn);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);
                name = ds.Rows[0][0].ToString();
                apellido = ds.Rows[0][1].ToString();
                especialidad = ds.Rows[0][2].ToString();
                id_doctor = ds.Rows[0][3].ToString();
                cn.Close();
            }

            label1.Text = name + " " + apellido + "           Especialidad: " + especialidad;            
        }

        //Este metodo esta en un 75% de estar funcional (solo falta una condicion para evitar redundancia), pero para hacer pruebas esta bueno
        public void Llenar_Cola()
        {
            using (MySqlConnection cn = BdComun.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("select id_afiliado from cita where id_doctor = '" + id_doctor + "'", cn);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);
                for(int i = 0; i < ds.Rows.Count; i++)
                {
                    Id_Afi.Enqueue(ds.Rows[i][0].ToString());
                }
                cn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nuevoPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            duitxt.Text = "";
            dataGrid_paciente.Rows.Clear();
            dataGrid_recetaPaciente.Rows.Clear();
            Id_Afi.Clear();
            Llenar_Cola();
            if (Id_Afi.Count == 0)
            {
                
            }
            else
            {                
                //Llena la cola de los pacientes que el doctor tiene que atender
                using (MySqlConnection cn = BdComun.ObtenerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("select nombre, apellido from afiliados where id_afiliado = '" + Id_Afi.Peek() + "'", cn);
                    cmd.ExecuteNonQuery();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    name2 = ds.Rows[0][0].ToString();
                    apellido2 = ds.Rows[0][1].ToString();
                    cn.Close();
                }
                lblNombre.Text = name2;
                lblApellido.Text = apellido2;
            }
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

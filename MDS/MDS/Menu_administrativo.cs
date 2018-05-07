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
using System.Globalization;

namespace MDS
{
    public partial class Menu_administrativo : Form
    {
        string[] horas = new string[] { "06:00", "08:00", "10:00", "12:00", "14:00", "16:00", "18:00" };
        public List<int> id_doc = new List<int>();
        public List<int> id_doc_esp = new List<int>();
        public List<int> id_doc_cita = new List<int>();
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
            comboBox1.Visible = true;
            comboBox1.SelectedIndex = 0;
            cmbDoctor.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DoctorDal lis2 = new DoctorDal();
            lis2.ListarDocespecialidad(cmbDoctor, id_doc_esp);
            comboBox1.Items.Clear();
            cmbDoctor.Visible = true;
            cmbDoctor.SelectedIndex = 0;
            comboBox1.Visible = false;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            string daate = fecha.Date.ToString("yyyy-MM-dd");
            string hora = fecha.ToLocalTime().ToString("HH:mm");
            try
            {
                Citas inserta_cita = new Citas();
                if (radioButton1.Checked == true)
                {
                    indice = comboBox1.SelectedIndex;
                    inserta_cita.consulta_general(daate, hora, id_afiliado, id_doc[indice]);
                }
                if (radioButton2.Checked == true)
                {
                    indice = cmbDoctor.SelectedIndex;
                    inserta_cita.consulta_general(daate, hora, id_afiliado, id_doc_esp[indice]);
                }
                limpiar();
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
                    tabControl1.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Error! Dui  invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnReservarTP3_Click(object sender, EventArgs e)
        {
            string fecha_tp3 = Citas_Calendario.SelectionRange.End.ToString("yyyy-MM-dd");
            string hora_tp3 = dtpHora_tp3.Value.Hour.ToString() + ":" + dtpHora_tp3.Value.Minute.ToString();
            try
            {
                Citas inserta_cita = new Citas();
                DoctorDal exist = new DoctorDal();
                indice = cmbDoctor_Cita.SelectedIndex;
                //MessageBox.Show(id_doc_cita[indice].ToString());
                ListViewItem busca_h = listView1.FindItemWithText(hora_tp3);
                ListViewItem busca_d = listView1.FindItemWithText(exist.Nombre_doc(id_doc_cita[indice]));
                if (busca_d != null && busca_h != null)
                    MessageBox.Show("Hora reservada, elija otra fecha");
                else
                {
                    inserta_cita.consulta_cita(fecha_tp3, hora_tp3, id_afiliado, id_doc_cita[indice]);
                }
                listView1.Items.Clear();
                fill_data_list();
                limpiar();
            }
            
            catch
            {

            }
        }
    
        private void Citas_Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;
            string fecha_ci = "";
            fecha_ci += dtinfo.GetDayName(Citas_Calendario.SelectionEnd.DayOfWeek) + " ";
            fecha_ci += Citas_Calendario.SelectionRange.End.Day.ToString() + " ";
            fecha_ci += dtinfo.GetMonthName(Citas_Calendario.SelectionRange.End.Month);
            fecha_ci += " de " + Citas_Calendario.SelectionRange.End.Year;
            Dia.Text = fecha_ci;
            listView1.Items.Clear();
            fill_data_list();
        }

        private void Citas_Calendario_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

            if (tabControl1.SelectedIndex == 1)
            {
                cmbDoctor_Cita.Items.Clear();
                DoctorDal lis3 = new DoctorDal();
                lis3.ListaDoc_por_cita(cmbDoctor_Cita, id_doc_cita);
                cmbDoctor_Cita.SelectedIndex = 0;
            }
        }

        private void btnCancelar_TP3_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            lblnom.Text = "";
            lblape.Text = "";
            lbledad.Text = "";
            duitxt.Text = "";
            tabControl1.Enabled = false;
            tabControl1.SelectedIndex = 0;
        }
        
        public void fill_data_list()
        {
            using (MySqlConnection conexion = BdComun.ObtenerConexion())
            {
                string fecha_ = Citas_Calendario.SelectionRange.End.ToString("yyyy-MM-dd");
                string c = "select hora_cita, concat(doctores.nombre,' ', doctores.apellido) as 'Doctor' from cita inner join doctores on cita.id_doctor = doctores.id_doctor ";
                c += "where prox_cita like '" + fecha_ + "' and doctores.especialidad like '%.'";
                MySqlCommand comando = new MySqlCommand(string.Format(c), conexion);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader.GetString(0));
                    lv.SubItems.Add(reader.GetString(1));
                    listView1.Items.Add(lv);
                }
                reader.Close();
                conexion.Close();
            }
        }
    }
}

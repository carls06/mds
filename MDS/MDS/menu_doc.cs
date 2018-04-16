﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDS
{
    public partial class Menu_doc : Form
    {
        
        public Menu_doc()
        {
            InitializeComponent();
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
            
            
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Citas_formulario citas = new Citas_formulario();
            citas.Show();
            this.Hide();
        }

        private void recetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recetas_formulario recetas = new Recetas_formulario();
            recetas.Show();
            this.Hide();
        }

        private void examenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Examenes_formulario exam = new Examenes_formulario();
            exam.Show();
            this.Hide();
        }

        private void referenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Referencias_formulario referencias = new Referencias_formulario();
            referencias.Show();
            this.Hide();
        }

        private void menu_doc_Load(object sender, EventArgs e)
        {
            //UserDal user = new UserDal();
            //user.ListarProveedor(comboBox1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

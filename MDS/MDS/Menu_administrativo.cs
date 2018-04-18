using System;
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
    public partial class Menu_administrativo : Form
    {
        public Menu_administrativo()
        {
            InitializeComponent();
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
    }
}

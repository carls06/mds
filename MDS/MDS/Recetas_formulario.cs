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
    public partial class Recetas_formulario : Form
    {
        Menu_doc doc = new Menu_doc();
        public Recetas_formulario()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
            this.Close();

        }

        private void Recetas_formulario_Load(object sender, EventArgs e)
        {

        }
    }
}

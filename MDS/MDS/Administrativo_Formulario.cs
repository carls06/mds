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
    public partial class Administrativo_Formulario : Form
    {
        public Administrativo_Formulario()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Afiliador afili = new Afiliador();
            afili.nombre = txtNombre.Text.Trim();
            afili.apellido = txtApellido.Text.Trim();
            afili.edad = Convert.ToInt32(txtEdad.Text.Trim());
            afili.dui = duitxt.Text.Trim();
            afili.direccion = txtDireccion.Text.Trim();
            afili.contraseña = txtpass.Text.Trim();


            int resultado = AfiliadorDal.Agregar_Afiliador(afili);
            if (resultado > 0)
            {
                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

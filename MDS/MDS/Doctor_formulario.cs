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
    public partial class Doctor_formulario : Form
    {
        public Doctor_formulario()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Doctor doc = new Doctor();
            doc.nombre = txtNombre.Text.Trim();
            doc.apellido = txtApellido.Text.Trim();
            doc.edad = Convert.ToInt32(txtEdad.Text.Trim());
            doc.especialidad = cbespecialidad.Text.Trim();
            doc.direccion = txtDireccion.Text.Trim();
            doc.dui = duitxt.Text.Trim();
            doc.contraseña = txtpass.Text.Trim();
            


            int resultado = DoctorDal.Agregar_Doc(doc);

            if (resultado > 0)
            {
                MessageBox.Show("Doctor Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar ", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_administrativo adm = new Menu_administrativo();
            adm.Show();
            this.Close();
        }
    }
}

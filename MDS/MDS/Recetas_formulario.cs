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
    public partial class Recetas : Form
    {
        Menu_doc doc = new Menu_doc();
        public Recetas()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_doc doc = new Menu_doc();
            doc.Show();
            
            this.Close();

        }

        private void Recetas_formulario_Load(object sender, EventArgs e)
        {

        }
        int resultado;
        private void button3_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            string daate = fecha.Date.ToString("yyyy-MM-dd");
            string hora = fecha.ToLocalTime().ToString("HH:mm");


            Receta rec = new Receta();
            string linea;//Renglon a enviar
            string texto1 = textBox2.Text + " " + Convert.ToString(Convert.ToChar(10));//valor del textbox + un enter
            int jojojito = 0;//numero de linea

            for (int j = 0; j < texto1.Length; j++)
            {
                if (texto1[j] == Convert.ToChar(10))//compara donde esta el Enter
                {
                    jojojito = jojojito + 1;//linea =0+1,1+2,2+1,3+1,etc+1
                    linea = texto1.Substring(0, j - 1);
                    //toma el primer renglon antes del primer enter

                    texto1 = texto1.Remove(0, j + 1);//Elimina el renglon usado del texto
                    j = 0;//reiniciamos el FOR para poder encotrar mas enters
                    rec.idaf = Convert.ToInt32(label12.Text);
                    rec.iddoc = Convert.ToInt32(label13.Text);

                   rec.medicamento = linea.TrimEnd();
                   rec.desc = textBox1.Text.Trim();
                   rec.fecha = Convert.ToDateTime( dateTimePicker1.Text.Trim());
                   resultado = DoctorDal.Agregar_recetas(rec);
                    MessageBox.Show(""+linea);
                }
            }
           

            if (resultado > 0)
            {
                MessageBox.Show("Receta Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar ", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
    }
}

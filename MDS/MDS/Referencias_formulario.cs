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
    public partial class Referencias_formulario : Form
    {
        public Referencias_formulario()
        {
            InitializeComponent();
        }

        private void Referencias_formulario_Load(object sender, EventArgs e)
        {
            HospitalDal hospi = new HospitalDal();
            hospi.ListarHospitales(cblistHospi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_doc doc = new Menu_doc();
            
            this.Close();
        }

        private void cblistHospi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

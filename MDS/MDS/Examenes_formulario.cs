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
    public partial class Examenes_formulario : Form
    {
        public Examenes_formulario()
        {
            InitializeComponent();
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                dateTimePicker1.Enabled = true;
            else
                dateTimePicker1.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                dateTimePicker2.Enabled = true;
            else
                dateTimePicker2.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                dateTimePicker3.Enabled = true;
            else
                dateTimePicker3.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                dateTimePicker4.Enabled = true;
            else
                dateTimePicker4.Enabled = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
                dateTimePicker5.Enabled = true;
            else
                dateTimePicker5.Enabled = false;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
                dateTimePicker6.Enabled = true;
            else
                dateTimePicker6.Enabled = false;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
                dateTimePicker7.Enabled = true;
            else
                dateTimePicker7.Enabled = false;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
                dateTimePicker8.Enabled = true;
            else
                dateTimePicker8.Enabled = false;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
                dateTimePicker9.Enabled = true;
            else
                dateTimePicker9.Enabled = false;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
                dateTimePicker10.Enabled = true;
            else
                dateTimePicker10.Enabled = false;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
                dateTimePicker11.Enabled = true;
            else
                dateTimePicker11.Enabled = false;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
                dateTimePicker12.Enabled = true;
            else
                dateTimePicker12.Enabled = false;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
                dateTimePicker13.Enabled = true;
            else
                dateTimePicker13.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_doc doc = new Menu_doc();
            
            this.Close();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Examenes_formulario_Load(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

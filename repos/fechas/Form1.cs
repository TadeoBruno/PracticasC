using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fechas
{
    public partial class OperacionesFecha1 : Form
    {
        public OperacionesFecha1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            DateTime Fecha = this.dateTimePicker1.Value;
            textBox1.Text = Convert.ToString(Fecha);
            //Fecha Corta
            textBox2.Text = string.Format("{0:d}", Fecha);
            //Fecha Larga + tiempo
            textBox3.Text = string.Format("{0:D}", Fecha);
            //Fecha larga + tiempocorto
            textBox4.Text = string.Format("{0:f}", Fecha);
            //Fecha corta + tiempo corto
            textBox5.Text = string.Format("{0:g}", Fecha);
            //Fecha corta + tiempo largo
            textBox6.Text = string.Format("{0:G}", Fecha);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.Hide();
            OperacionesFecha2 v1 = new OperacionesFecha2();
            v1.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

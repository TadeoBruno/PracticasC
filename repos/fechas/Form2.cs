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
    public partial class OperacionesFecha2 : Form
    {
        public OperacionesFecha2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = this.dateTimePicker1.Value;
            DateTime fecha2 = this.dateTimePicker2.Value;
            textBox1.Text = fecha1.Subtract(fecha2).ToString();
        }

        private void btnSalir1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.Hide();
            OperacionesFecha1 v0 = new OperacionesFecha1();
            v0.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OperacionesFecha3 v2 = new OperacionesFecha3();
            v2.Show();
        }
    }
}

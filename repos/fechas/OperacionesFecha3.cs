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
    public partial class OperacionesFecha3 : Form
    {
        public OperacionesFecha3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            txtResultado.Text = (fecha1.AddDays(Convert.ToInt32(txtDias.Text)).ToString("dd/MM/yyyy")).ToString();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.Hide();
            OperacionesFecha2 v1 = new OperacionesFecha2();
            v1.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day); txtResultado.Text = (fecha1.AddDays(-1 *Convert.ToInt32(txtDias.Text)).ToString("dd/MM/yyyy")).ToString();
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

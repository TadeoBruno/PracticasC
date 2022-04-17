using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimaClase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTPNacimiento_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan tS = new TimeSpan();
            tS = DateTime.Now.Subtract(dateTPNacimiento.Value);
            txtEdad.Text = (tS.TotalDays / 365).ToString();
            //DateTime nacimiento = new DateTime(dateTPNacimiento);
            //int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
            //lblEdad.Text = edad.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

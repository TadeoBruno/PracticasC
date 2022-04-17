using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borrador
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNum1.Text);
            double b = Convert.ToDouble(txtNum2.Text);
            double c = a * b;
            lblResultado.Text = c.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNum1.Text);
            double b = Convert.ToDouble(txtNum2.Text);
            double c = a + b;
            lblResultado.Text = c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNum1.Text);
            double b = Convert.ToDouble(txtNum2.Text);
            double c = a - b;
            lblResultado.Text = c.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNum1.Text);
            double b = Convert.ToDouble(txtNum2.Text);
            double c = a / b;
            lblResultado.Text = c.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
            MessageBox.Show("Nos vimos rey");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblResultado.Text = "";
            this.txtNum2.Focus(); //esto hace que cuando ejecutemos la accion se autoseleccione el textbox que elijamos.
        }
    }
}
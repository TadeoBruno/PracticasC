using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double r = a + b;
            lblResultado.Text = "Resultado de la suma:\n\t"+r.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double r = a - b;
            lblResultado.Text = "El resultado de la resta:\n\t" + r.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double r = a * b;
            lblResultado.Text = "El resultado de la multiplicación:\n\t" + r.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtA.Text = "0";
            txtB.Text = "0";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(txtA.Text);
            float b = Convert.ToSingle(txtB.Text);

            float r = a / b;
            lblResultado.Text = "El resultado de la división es de:\n\t" + r.ToString();
        }
    }
}

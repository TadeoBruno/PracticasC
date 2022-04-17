using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bruno_Tadeo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        } //Nulo
        
        private void txtBoxColaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void chlbComidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chlbComidas.SelectedItem.ToString() == "Colaciones")
            {
                txtBoxColaciones.Visible = true;
                lblCantColaciones.Visible = true;
            }
            else
            {
                txtBoxColaciones.Visible = false;
                lblCantColaciones.Visible = false;
            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            chlbComidas.Items.Add("Desayuno");
            chlbComidas.Items.Add("Almuerzo");
            chlbComidas.Items.Add("Merienda");
            chlbComidas.Items.Add("Cena");
            chlbComidas.Items.Add("Colaciones");
        }

        private void buttonListo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disculpe profe, es todo lo que pude hacer", "Registro");
            return;
        }
    }
}

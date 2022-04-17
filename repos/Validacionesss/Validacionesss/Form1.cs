using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validacionesss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboxGenero.Items.Add("Hombre");
            cboxGenero.Items.Add("Mujer");
            cboxGenero.Items.Add("Otro");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btbConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void txtbxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validacion de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

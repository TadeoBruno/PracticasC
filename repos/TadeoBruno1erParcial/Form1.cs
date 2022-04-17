using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TadeoBruno1erParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cargar datos del combo
            cmbSexo.Items.Add("Seleccione");
            cmbSexo.Items.Add("Hombre");
            cmbSexo.Items.Add("Mujer");
            cmbSexo.SelectedItem = "Seleccione";
            checklbComidas.Items.Add("Desayuno");
            checklbComidas.Items.Add("Almuerzo");
            checklbComidas.Items.Add("Merienda");
            checklbComidas.Items.Add("Cena");
            checklbComidas.Items.Add("Colaciones");
            numlistCantComidas.Visible = false;
            lblCantComidas.Visible = false;
        }

        private bool validar()
        {
            bool rta = false;
            if (cmbSexo.SelectedItem.ToString() == "Hombre")
            {
                rta = true;
            }
            else if (cmbSexo.SelectedItem.ToString() == "Mujer")
            {
                rta = true;
            }
            else if (string.IsNullOrEmpty(txtbNombre.Text))
            {
                rta = false;
            }
            return rta;


        }
        private void txtbNombre_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo se admiten letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtbApellido_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo se admiten letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private Boolean email_correcto(String email)
        {
            {
                String expresion;
                expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                if (Regex.IsMatch(email, expresion))
                {
                    if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool valido = false;
            valido = validar();
            if (valido)
                MessageBox.Show("Gracias por registrarse " + txtbNombre.Text+ " " + txtbApellido.Text);
            else
                MessageBox.Show("Hubo un error en el registro");
        }

        private void txtbPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checklbComidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checklbComidas.SelectedItems.ToString() == "Colaciones")
            {
                numlistCantComidas.Visible = true;
                lblCantComidas.Visible = true;
            }
            else
            {
                numlistCantComidas.Visible = false;
                lblCantComidas.Visible = false;
            }

        }

        private void txtbApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_Leave(object sender, EventArgs e)
        {
            numericUpDown1.DecimalPlaces = 2;
        }

        private void checklbComidas_SelectedValueChanged(object sender, EventArgs e)
        {
        }
    }
}

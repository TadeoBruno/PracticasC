using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace TadeoBruno2doParcial
{
    public partial class FormRegistroDatos : Form
    {
        public FormRegistroDatos()
        {
            InitializeComponent();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (e.KeyChar == (char)Keys.Back)
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (e.KeyChar == (char)Keys.Back)
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FormRegistroDatos_Load(object sender, EventArgs e)
        {
            cmboxTipoauto.Items.Add("Tipo de auto");
            cmboxTipoauto.Items.Add("Rural");
            cmboxTipoauto.Items.Add("Deportivo");
            cmboxTipoauto.Items.Add("Standard");
            cmboxTipoauto.Items.Add("Eco");
            cmboxAñomodelo.Items.Add("Año modelo");
            cmboxAñomodelo.Items.Add("Anterior a 2000");
            cmboxAñomodelo.Items.Add("Entre 2001 y 2010");
            cmboxAñomodelo.Items.Add("Entre 2011 y 2020");
            cmboxMarcapref.Items.Add("Marca preferida");
            cmboxMarcapref.Items.Add("Ford");
            cmboxMarcapref.Items.Add("Chevrolet");
            cmboxMarcapref.Items.Add("Fiat");
            cmboxMarcapref.Items.Add("Ranault");
            cmboxMarcapref.Items.Add("Otra");
            cmboxTipoauto.SelectedIndex = 0;
            cmboxAñomodelo.SelectedIndex = 0;
            cmboxMarcapref.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtTipoUso.Text = "";
            txtDomicilio.Text = "";
            cmboxAñomodelo.Text = "Año modelo";
            cmboxMarcapref.Text = "Marca preferida";
            cmboxTipoauto.Text = "Tipo de auto";
            this.txtNombre.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool valido;
            valido = validar();

            if (!valido)
            {
                MessageBox.Show("Faltan completar algunos datos");
                return;
            }
            else
            {
                this.Hide();
                Form1 v1 = new Form1();
                v1.Nombre = txtNombre.Text;
                v1.Apellido = txtApellido.Text;
                v1.Dni = Convert.ToInt32(txtDni.Text);
                v1.Show();
            }
        }
        private bool validar()
        {
            bool validardatos = true;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                validardatos = false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                validardatos = false;
            }
            if (string.IsNullOrEmpty(txtDomicilio.Text))
            {
                validardatos = false;
            }
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                validardatos = false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                validardatos = false;
            }
            if (cmboxTipoauto.SelectedIndex == 0)
            {
                validardatos = false;
            }
            if (cmboxMarcapref.SelectedIndex == 0)
            {
                validardatos = false;
            }
            if (cmboxAñomodelo.SelectedIndex == 0)
            {
                validardatos = false;
            }
            return validardatos;
        }

        public void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Javier_Ramirez
{
    public partial class Form2 : Form
    {
        int precioglobal = 0;
        string errores = "";
        public Form2(int precio)
        {
            InitializeComponent();
            precioglobal = precio;
            lblTOTAL.Text = "Total a pagar: $" + precio.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            grpPago.Enabled = false;
            grpInformacion.Enabled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloLetras(e, "");
        }

        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloNumeros(e);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            errores = "";
            bool nombre = Verificar(txtNombre);
            bool apellido = Verificar(txtApellido);
            bool razonsocial = Verificar(txtRazonsocial);
            bool direccion = Verificar(txtDireccion);
            bool cuit = Verificar(txtCUIT);
            if (nombre & apellido & razonsocial & direccion & cuit)
            {
                if (COMUN.MetodosComunes.ValidaCuit(txtCUIT.Text))
                {
                    grpPago.Enabled = true;
                    grpInformacion.Enabled = false;
                }else
                {
                    buscarerror(txtCUIT, false);
                    Logerrores(errores);
                }
            }else
            {
                MessageBox.Show("Completar los campos faltantes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logerrores(errores);
            }
        }
        private bool Verificar(TextBox textbox)
        {
            if (!string.IsNullOrEmpty(textbox.Text))
            {
                buscarerror(textbox, true); //BLANCO//
                return true;
            }
            else
            {
                buscarerror(textbox, false); //ROJO//
                errores = errores + textbox.Name + ", ";
                return false;
            }
        }

        //FUNCION CAMBIO DE COLORES//
        private void buscarerror(TextBox textbox,bool errorono)//True color en blanco y False color Rojo error//
        {
            if (errorono)
            {
                textbox.BackColor = Color.White;
            }else
            {
                textbox.BackColor = Color.Red;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            grpPago.Enabled = false;
            grpInformacion.Enabled = true;
        }
        private void Logerrores(string error)
        {
            StreamWriter sw;
            string Direccion = @"C:\Registro";
            string Direccioncompleta = @"C:\Registro\LogError.txt";
            var dirinfo = new DirectoryInfo(Direccion);
            if (!dirinfo.Exists)
            {
                Directory.CreateDirectory(Direccion);
            }
            if (File.Exists(Direccioncompleta))
            {
                sw = File.AppendText(Direccioncompleta);
            }
            else
            {
                sw = File.CreateText(Direccioncompleta);
            }
            sw.WriteLine("//////////ERROR/////////");
            sw.WriteLine("");
            sw.WriteLine("No se completo las siguientes cosas "+error);
            sw.WriteLine("Log creado a las: " + DateTime.Now);
            sw.WriteLine("//////////////////////////////////////");
            sw.Close();
        }
        private void Logexito()
        {
            StreamWriter sw;
            string Direccion = @"C:\Registro";
            string Direccioncompleta = @"C:\Registro\LogExito.txt";
            var dirinfo = new DirectoryInfo(Direccion);
            if (!dirinfo.Exists)
            {
                Directory.CreateDirectory(Direccion);
            }
            if (File.Exists(Direccioncompleta))
            {
                sw = File.AppendText(Direccioncompleta);
            }
            else
            {
                sw = File.CreateText(Direccioncompleta);
            }
            sw.WriteLine("//////////¡Registro Exitoso!/////////");
            sw.WriteLine("");
            sw.WriteLine("Se registro con exito la persona con nombre: " + txtNombre.Text + " " + txtApellido.Text + "\nCUIT: " + txtCUIT.Text+ "\nMetodo de pago: "+lstMetodo.SelectedItem);
            sw.WriteLine("Costo total: $" + precioglobal.ToString());
            sw.WriteLine("Realizado a las: " + DateTime.Now);
            sw.WriteLine("////////////////////////////////////////");
            sw.Close();

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            TextBox textboxrecibido = (TextBox)sender;
            buscarerror(textboxrecibido, true);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (lstMetodo.SelectedIndex != -1)
            {
                MessageBox.Show("Muchisimas gracias, se logro realizar con exito todo los procedimientos.", "Aviso", MessageBoxButtons.OK);
                Logexito();
            }
            else
            {
                MessageBox.Show("Por favor, seleccionar un metodo de pago.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string errorlistbox = "No se selecciono un metodo de pago...";
                Logerrores(errorlistbox);
            }
        }
    }
}
        


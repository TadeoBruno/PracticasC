using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_Integrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            double altamoto = 100, altaauto = 0, altacamion = 300;
            double bajamoto = 0, bajaauto = 150, bajacamion = 200;
            double resultado = 0;
            double pasajeros = Convert.ToDouble(txtPasajeros.Text);

            //if de moto
            if (rbMoto.Checked == true)
                if (rbAlta.Checked == true)
                    MessageBox.Show("DATOS INGRESADOS."+ "\n" + "\nVehiculo:" + rbMoto.Text + "\nHorario:" + rbAlta.Text + "\nCantidad de pasajeros:" + pasajeros+ "\n" +"\nCOSTE: $"+ resultado, "Boleta Peaje");
                    resultado = altamoto;
                if(rbBaja.Checked==true)
                    MessageBox.Show("DATOS INGRESADOS." + "\n" + "\nVehiculo:" + rbMoto.Text + "\nHorario:" + rbBaja.Text + "\nCantidad de pasajeros:" + pasajeros + "\n" + "\nCOSTE: $" + resultado, "Boleta Peaje");
                    resultado = bajamoto;






            //if de auto
            if (rbAuto.Checked == true)
               if (rbAlta.Checked == true)
                    MessageBox.Show("DATOS INGRESADOS." + "\n" + "\nVehiculo:" + rbAuto.Text + "\nHorario:" + rbAlta.Text + "\nCantidad de pasajeros:" + pasajeros + "\n" + "\nCOSTE: $" + resultado, "Boleta Peaje");
            if (pasajeros > 2)
                        resultado = altaauto;
            
            
                if (rbBaja.Checked == true)
                MessageBox.Show("DATOS INGRESADOS." + "\n" + "\nVehiculo:" + rbAuto.Text + "\nHorario:" + rbBaja.Text + "\nCantidad de pasajeros:" + pasajeros + "\n" + "\nCOSTE: $" + resultado, "Boleta Peaje");
                resultado = bajaauto;

                    
                    
            //if de camion
            if (rbCamion.Checked == true)
                if (rbAlta.Checked == true)
                    MessageBox.Show("DATOS INGRESADOS." + "\n" + "\nVehiculo:" + rbCamion.Text + "\nHorario:" + rbAlta.Text + "\nCantidad de pasajeros:" + pasajeros + "\n" + "\nCOSTE: $" + resultado, "Boleta Peaje");
            resultado = altacamion;
            
            
               if(rbBaja.Checked==true)
               MessageBox.Show("DATOS INGRESADOS." + "\n" + "\nVehiculo:" + rbCamion.Text + "\nHorario:" + rbBaja.Text + "\nCantidad de pasajeros:" + pasajeros + "\n" + "\nCOSTE: $" + resultado, "Boleta Peaje");
               resultado = bajacamion;

            //if limite de pasajeros
           
            if (pasajeros > 5)
                MessageBox.Show("Se paso el limite de pasajeros.","Error cant Pasajeros",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
                



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //limpiar el formulario
            txtPasajeros.Clear();
            rbMoto.Checked = false;
            rbCamion.Checked = false;
            rbAuto.Checked = false;
            rbBaja.Checked = false;
            rbAlta.Checked = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

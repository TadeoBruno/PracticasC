using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesValidaciones
{
    public partial class FormDatos : Form

    {
       // bool valido = false;
        public FormDatos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDatos_Load(object sender, EventArgs e)
        {
            
            //carga combo
            cmbGenero.Items.Add("Seleccione un valor");
            cmbGenero.Items.Add("Femenino");
            cmbGenero.Items.Add("Masculino");
            cmbGenero.Items.Add("Otros");
            cmbGenero.SelectedItem = "Seleccione un valor"; //Selección por defecto

          
            
        }

        private bool validar()
        {
            bool rta = false;
            if (cmbGenero.SelectedItem.ToString() == "Femenino")
                { rta = true; }
            if (cmbGenero.SelectedItem.ToString() == "Masculino")
                { rta = true; }

            return rta;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool valido = false;
            valido = validar();

            if (valido)
            {
                MessageBox.Show("Correcto");
            }
            else
            { MessageBox.Show("Incorrecto"); }
        }
    }
}

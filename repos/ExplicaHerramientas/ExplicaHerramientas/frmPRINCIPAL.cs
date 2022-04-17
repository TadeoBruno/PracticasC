using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExplicaHerramientas
{
    public partial class frmPRINCIPAL : Form
    {
        public frmPRINCIPAL()
        {
            InitializeComponent();
        }

        private void btnGET_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La sintaxis para guardar en una variable el valor obtenido de un textBox es: \n string Valor = txtTEXTBOX.Text;", "INFORMACION");
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La sintaxis para asignarle un valor a un textBox es: \n txtTEXTBOX.Text = Valor;", "INFORMACION");
        }

        private void btnRADIO_Click(object sender, EventArgs e)
        {
            if (radROMINA.Checked == true)
            {
                MessageBox.Show("Romina es la afortunada.");
            }
            if (radCARO.Checked == true)
            {
                MessageBox.Show("Caro es la afortunada.");
            }
            if (radJuan.Checked == true)
            {
                MessageBox.Show("Juan es el afortunado.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje = "";
                        
            if (chkROMINA.Checked == true)
            {
                mensaje = " - Romina\n";
            }
            if (chkCARO.Checked == true)
            {
                mensaje += " - Caro\n";
            }
            if (chkJuan.Checked == true)
            {
                mensaje += " - Juan";
            }

            MessageBox.Show("Los seleccionados son: \n" + mensaje, "INFORMACION");
        }

        private void chkJuan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJuan.Checked == true)
            {
                MessageBox.Show("Llegó Juan");
            }
            else
            {
                MessageBox.Show("Se fue Juan");
            }
        }

        private void frmPRINCIPAL_Load(object sender, EventArgs e)
        {

        }

      
    }
}

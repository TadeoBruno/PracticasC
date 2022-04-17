using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Javier_Ramirez
{
    public partial class Form1 : Form
    {

        //Variables Globales, Precios de Componentes//
        int MotherMSI= 14000;
        int MotherAsRock = 8000;
        int RAMcuatrogb = 5000;
        int RAMochogb = 7050;
        int Microprocesadorintel = 2400;
        int MicroprocesadorAMD = 1800;
        int HDDquinientogb = 900;
        int HDDuntb = 1200;
        int Monitordiecinueve = 29000;
        int Monitorveintidos = 35000;
        //Variables Globales para guardar datos//
        //Mother seleccionada//
        bool Motherelegida = false;
        string Motherselect = "";
        int Motherselectprecio = 0;
        //RAM seleccionada//
        bool RAMelegida = false;
        string RAMselect = "";
        int RAMselectprecio = 0;
        //Microprocesador seleccionado//
        bool Microprocesadorelegido = false;
        string Microprocesadorselect = "";
        int Microprocesadorselectprecio = 0;
        //Disco Duro seleccionado//
        bool Discoduroelegido = false;
        string Discoduroselect = "";
        int Discoduroselectprecio = 0;
        //Monitor Seleccionado//
        bool Monitorelegido = false;
        string Monitorselect = "";
        int Monitorselectprecio = 0;
        // // // // // // // // // //

        
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoMothermsi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMothermsi.Checked)
            {
                Motherelegida = true;
                Motherselect = rdoMothermsi.Text;
                Motherselectprecio = MotherMSI;
            }
            if (rdoMotherasrock.Checked)
            {
                Motherelegida = true;
                Motherselect = rdoMotherasrock.Text;
                Motherselectprecio = MotherAsRock;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblObliMadre.Visible = false;
            lblObliDisco.Visible = false;
            lblObliMicro.Visible = false;
            lblObliMonitor.Visible = false;
            lblObliRam.Visible = false;
        }

        private void rdoRamcuatrogb_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRamcuatrogb.Checked)
            {
                RAMelegida = true;
                RAMselect = rdoRamcuatrogb.Text;
                RAMselectprecio = RAMcuatrogb;
            }
            if (rdoRamochogb.Checked)
            {
                RAMelegida = true;
                RAMselect = rdoRamochogb.Text;
                RAMselectprecio = RAMochogb;
            }
        }

        private void rdoMicroIntel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMicroIntel.Checked)
            {
                Microprocesadorelegido = true;
                Microprocesadorselect = rdoMicroIntel.Text;
                Microprocesadorselectprecio = Microprocesadorintel;
            }
            if (rdoMicroAMD.Checked)
            {
                Microprocesadorelegido = true;
                Microprocesadorselect = rdoMicroAMD.Text;
                Microprocesadorselectprecio = MicroprocesadorAMD;
            }
        }

        private void rdoHDDquinientoGB_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHDDquinientoGB.Checked)
            {
                Discoduroelegido = true;
                Discoduroselect = rdoHDDquinientoGB.Text;
                Discoduroselectprecio = HDDquinientogb;
            }
            if (rdoHDDunTB.Checked)
            {
                Discoduroelegido = true;
                Discoduroselect = rdoHDDunTB.Text;
                Discoduroselectprecio = HDDuntb;
            }
        }

        private void rdoSinMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSinMonitor.Checked)
            {
                Monitorelegido = true;
                Monitorselect = rdoSinMonitor.Text;
                Monitorselectprecio = 0;
            }
            if (rdoMonitorDiecinueve.Checked)
            {
                Monitorelegido = true;
                Monitorselect = rdoMonitorDiecinueve.Text;
                Monitorselectprecio = Monitordiecinueve;
            }
            if (rdoMonitorveintidos.Checked)
            {
                Monitorelegido = true;
                Monitorselect = rdoMonitorveintidos.Text;
                Monitorselectprecio = Monitorveintidos;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Motherelegida & RAMelegida & Microprocesadorelegido & Discoduroelegido & Monitorelegido)
            {
                lblObliMadre.Visible = false;
                lblObliDisco.Visible = false;
                lblObliMicro.Visible = false;
                lblObliMonitor.Visible = false;
                lblObliRam.Visible = false;
                // // // // // // // // // // // //
                int calcular = 0;
                calcular = Motherselectprecio + RAMselectprecio + Microprocesadorselectprecio + Discoduroselectprecio + Monitorselectprecio;
                // // // // // //
                DialogResult r = MessageBox.Show("El precio de total de lo seleccionado es de: $" + calcular.ToString() + "\nSe abrira un segundo formulario para rellenar sus datos.", "Aviso",MessageBoxButtons.OKCancel);
                if(r == DialogResult.OK)
                {
                    Form2 formulario2 = new Form2(calcular);
                    formulario2.ShowDialog();

                }else
                {
                    MessageBox.Show("Se cancelo la compra, puede seguir seleccionando el producto que usted quiera.", "Aviso", MessageBoxButtons.OK);
                }

            }
            else
            {
                if (!Motherelegida)
                {
                    lblObliMadre.Visible = true;
                }
                else
                {
                    lblObliMadre.Visible = false;
                }
                if (!RAMelegida)
                {
                    lblObliRam.Visible = true;
                }
                else
                {
                    lblObliRam.Visible = false;
                }
                if (!Microprocesadorelegido)
                {
                    lblObliMicro.Visible = true;
                }else
                {
                    lblObliMicro.Visible = false;
                }
                if (!Monitorelegido)
                {
                    lblObliMonitor.Visible = true;
                }
                else
                {
                    lblObliMonitor.Visible = false;
                }
                if (!Discoduroelegido)
                {
                    lblObliDisco.Visible = true;
                }else
                {
                    lblObliDisco.Visible = false;
                }

            }
        }
    }
}

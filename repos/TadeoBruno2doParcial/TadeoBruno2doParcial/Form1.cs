using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace TadeoBruno2doParcial
{
    public partial class Form1 : Form
    {
        public string Nombre;
        public string Apellido;
        public int Dni;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMailRemitente_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHost_Click(object sender, EventArgs e)
        {

        }

        private void lblAsunto_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void ClearControls()
        {
            txtAsunto.Text = "";
            txtCuerpo.Text = "";
            txtMailEmisor.Text = "";
            txtHost.Text = "";
            txtPuerto.Text = "";
            txtContraseña.Text = "";
        }

        public void btnEnviar_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(txtMailEmisor.Text);
            msg.Subject = txtAsunto.Text;
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = txtCuerpo.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new MailAddress(txtMailRemitente.Text);

            SmtpClient cliente = new SmtpClient();
            //SmtpClient cliente = SmtpClient(lblHost.Text);
            cliente.Credentials = new System.Net.NetworkCredential(txtMailEmisor.Text, txtContraseña.Text);

            cliente.Port = Convert.ToInt32(txtPuerto.Text);
            cliente.EnableSsl = true;

            cliente.Host = txtHost.Text;

            try
            {
                cliente.Send(msg);
                MessageBox.Show("Se envio el corre correctamente");
            }
            catch (Exception a)
            {
                string mensaje = a.ToString();
                MessageBox.Show(mensaje);
            }

            {
                StringBuilder mensaje = new StringBuilder("Log de éxito", 50);
                int CantOp = 0;
                LogExito(mensaje, CantOp, Dni);
            }
            {
                MessageBox.Show("Estimado/a " + Nombre + " " + Apellido + " " + Dni + "\n Gracias por elegirnos, hemos enviado su pedido de alquiler de auto, en breve se comunicarán con usted", "Proceso finalizado");
                //No pude conectar los datos del otro form
            }
            Application.Exit();
        }

        public static void LogExito(StringBuilder mensaje, int CantOperaciones, int Dni)
            {
                string PATHLOG = @"C:\Log";
                string ARCHIVOLOG = "ArchivoDatos" + ".text";
                StreamWriter sw;
                string pathCompleto = PATHLOG + @"\" + ARCHIVOLOG;
                var dirInfo = new DirectoryInfo(PATHLOG);
                if (!dirInfo.Exists)
                {
                    Directory.CreateDirectory(PATHLOG);
                }
                if (File.Exists(pathCompleto))
                {
                    sw = File.AppendText(pathCompleto);
                }
                else
                {
                    sw = File.CreateText(pathCompleto);
                }
                string empresa = "Agencia RentCards";

                sw.WriteLine("---------------------" + empresa + "---------------------");
                sw.WriteLine("Se ha ejecutado el servicio a las " + DateTime.Now.ToString());
                sw.WriteLine(Dni);
                sw.WriteLine("---------------" + mensaje.ToString() + "----------------");

                sw.Close();
            }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
        }
    }
    }

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

namespace EnvioCorreo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnEnviar_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(txtboxPara.Text);
            msg.Subject = txtboxAsunto.Text;
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = txtboxCuerpo.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new MailAddress(txtboxPara.Text);

            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential(txtboxDe.Text, txtboxPass.Text);

            cliente.Port = Convert.ToInt32(txtboxPuerto);
            cliente.EnableSsl = true;

            cliente.Host = txtboxHost.Text;

            try
            {
                cliente.Send(msg);
                MessageBox.Show("Se envio el corre correctamente");
            }
            catch(Exception a)
            {
                string mensaje = a.ToString();
                MessageBox.Show(mensaje);
            }
        }
    }
}

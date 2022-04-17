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

namespace EnvioMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
           MailMessage msg = new MailMessage(); //Clase instanciada //     System.Net.Mail

            msg.To.Add(txtPara.Text);
            msg.Subject = txtAsunto.Text;
            msg.SubjectEncoding = Encoding.UTF8; //SystemText
            //Por una cuestión de servidores debe encodearse, 
            //es un estándar de códificación utilzado en internet, 
            //en particular para envío de mails o pag web
            //para agregar copia msg.Bcc.add(txt.text);
            msg.Body = txtCuerpo.Text;
            msg.BodyEncoding = Encoding.UTF8; //System.Text.
            msg.IsBodyHtml = true; //Si está códificado en HTML
            msg.From = new MailAddress(txtMailEmisor.Text); //System.Net.Mail.

            SmtpClient cliente = new SmtpClient(); //Clase instanciada System.Net.Mail
            //SmtpClient cliente = SmtpClient(lblHost.Text, )
            cliente.Credentials = new System.Net.NetworkCredential(txtMailEmisor.Text, txtContrasenia.Text);

            cliente.Port = Convert.ToInt32(txtPuerto.Text); //Para gmail 587
            cliente.EnableSsl = true;

            cliente.Host = txtHost.Text; //Para gmail smtp.gmail.com sino puede ser mail.dominio.com

            try
            {
                cliente.Send(msg); //Método que envía el mail
                MessageBox.Show("Se envió el mail correctamente");
            }
            catch(Exception a)
            {
                string mensaje = a.ToString();
                MessageBox.Show(mensaje); //("Error al enviar");
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtContrasenia.UseSystemPasswordChar = false;
        }
    }
}

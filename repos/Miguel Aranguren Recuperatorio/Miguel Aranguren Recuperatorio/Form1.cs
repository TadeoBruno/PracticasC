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
using System.Net.Mail;
using System.Net;

namespace Miguel_Aranguren_Recuperatorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPromo.Items.Add("Ninguna – 0% descuento");
            cmbPromo.Items.Add("Promo Cyber Monday – 15% descuento ");
            cmbPromo.Items.Add("Promo Navideña – 20% descuento");
            cmbPromo.Items.Add("Promo Cliente Nuevo – 25% descuento ");
           
            cmbPromo.SelectedIndex = 0;
            RBno.Checked = true;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double Precio_final;
            
            
            if (cmbPromo.SelectedIndex == 0)
            {
               if(RBsi.Checked== true)
                {
                    
                }
                else
                {

                }
            }
            if (cmbPromo.SelectedIndex == 1)//15 % de descuento
            {
                if (RBsi.Checked == true)
                {
                    
                }
                else
                {

                }
            }
            if (cmbPromo.SelectedIndex == 2)//20 % de descuento
            {
                if (RBsi.Checked == true)
                {

                }
                else
                {

                }
            }
            if (cmbPromo.SelectedIndex == 3)//25 % de descuento
            {
                if (RBsi.Checked == true)
                {

                }
                else
                {

                }
            }
            StreamWriter sw;
            if ((!string.IsNullOrEmpty(txtProducto.Text)) && (!string.IsNullOrEmpty(txtCosto.Text))) // este campo es para que en el momento que falte algun dato va a saltar el mensaje
            {
                MailMessage msg = new MailMessage(); // basicamente todo el reglon de aca vendrian siendo todo lo del correo

                msg.To.Add("tadeobruno912@gmail.com"); //el correo a donde se enviara
                msg.Subject = "Nuevo calculo de precio"; // el Asunto
                msg.SubjectEncoding = Encoding.UTF8;
                msg.Body = ("La Fecha de hoy es: " + DateTime.Now.ToString() + " y el Producto " + txtProducto.Text + " y el precio final es:  "); // lo que dira el correo
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.From = new MailAddress("tadeobruno912@gmail.com"); // el correo desde donde se mandara
                NetworkCredential loginInfo = new NetworkCredential("tadeobruno912@gmail.com", "riverplate1@"); // correo y contrase;a para poder enviarlo

                SmtpClient cliente = new SmtpClient();
                cliente.Credentials = loginInfo;
                cliente.Port = 587; // el port de gmail
                cliente.EnableSsl = true;
                cliente.Host = "smtp.gmail.com"; 
                try
                {
                    cliente.Send(msg);
                    MessageBox.Show("El mail ha sido enviado con exito!  " + txtProducto.Text + " " +   txtProducto.Text); // mensaje de confirmacion del mismo
                }
                catch (Exception a)
                {
                    string mensaje = a.ToString();
                    MessageBox.Show(mensaje);
                }
                string path = @"C:\Log";
                string log = "ArchivoLog" + ".txt";
                string pathCompleto = path + @"\" + log;
                var dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                {
                    Directory.CreateDirectory(path);
                }
                if (File.Exists(pathCompleto))
                {
                    sw = File.AppendText(pathCompleto);
                }
                else
                {
                    sw = File.CreateText(pathCompleto);
                }
                sw.WriteLine("----------------------------------------------------------------");
                sw.WriteLine("La hora y el tiempo es: " + DateTime.Now.ToString());
                sw.WriteLine("El Producto es" + txtProducto.Text + "  " + txtCosto.Text );
                sw.WriteLine("----------------------------------------------------------------");
                sw.Close();
            }
            else
            { 
                MessageBox.Show("Por favor rellene los campos faltantes.", "Error");
            }
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e) // esto es para que no se pueda colocar nuemros en el producto //
        {
            if ((e.KeyChar >= 32 && e.KeyChar < 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 125 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo letras por favor", "Siga las normas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e) // esto es para que no se pueda colocar letras en el precio //
        {
            if ((e.KeyChar >= 32 && e.KeyChar < 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo numeros por favor", "Sigas las normas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
    }
}

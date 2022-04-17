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

namespace ReNombrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            StringBuilder mensaje = new StringBuilder("Log de éxito", 50);
            int CantOp = 0;
            LogExito(mensaje, CantOp);
        }
        public static void LogExito(StringBuilder mensaje, int CantOperaciones)
        {
            string PATHLOG = @"C:\Log";
            string ARCHIVOLOG = "ArchivoLog" + ".text";
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
            string empresa = "ROSARIO";

            sw.WriteLine("----------" + empresa + "----------");
            sw.WriteLine("Se ha ejecutado el servicio a las " + DateTime.Now.ToString());
            sw.WriteLine("Se procesaron " + CantOperaciones.ToString() + " operaciones");
            sw.WriteLine("---------------" + mensaje.ToString() + "----------------");

            sw.Close();
        }
    }
}

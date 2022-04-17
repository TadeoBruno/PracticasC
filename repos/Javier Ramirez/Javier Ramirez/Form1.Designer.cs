namespace Javier_Ramirez
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoMothermsi = new System.Windows.Forms.RadioButton();
            this.rdoMotherasrock = new System.Windows.Forms.RadioButton();
            this.lblObliMadre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblObliRam = new System.Windows.Forms.Label();
            this.rdoRamochogb = new System.Windows.Forms.RadioButton();
            this.rdoRamcuatrogb = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblObliMicro = new System.Windows.Forms.Label();
            this.rdoMicroAMD = new System.Windows.Forms.RadioButton();
            this.rdoMicroIntel = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoHDDunTB = new System.Windows.Forms.RadioButton();
            this.rdoHDDquinientoGB = new System.Windows.Forms.RadioButton();
            this.lblObliDisco = new System.Windows.Forms.Label();
            this.grpmonitor = new System.Windows.Forms.GroupBox();
            this.lblObliMonitor = new System.Windows.Forms.Label();
            this.rdoMonitorDiecinueve = new System.Windows.Forms.RadioButton();
            this.rdoSinMonitor = new System.Windows.Forms.RadioButton();
            this.rdoMonitorveintidos = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpmonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblObliMadre);
            this.groupBox1.Controls.Add(this.rdoMotherasrock);
            this.groupBox1.Controls.Add(this.rdoMothermsi);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarjeta Madres";
            // 
            // rdoMothermsi
            // 
            this.rdoMothermsi.AutoSize = true;
            this.rdoMothermsi.Location = new System.Drawing.Point(7, 20);
            this.rdoMothermsi.Name = "rdoMothermsi";
            this.rdoMothermsi.Size = new System.Drawing.Size(80, 17);
            this.rdoMothermsi.TabIndex = 0;
            this.rdoMothermsi.TabStop = true;
            this.rdoMothermsi.Text = "Mother MSI";
            this.rdoMothermsi.UseVisualStyleBackColor = true;
            this.rdoMothermsi.CheckedChanged += new System.EventHandler(this.rdoMothermsi_CheckedChanged);
            // 
            // rdoMotherasrock
            // 
            this.rdoMotherasrock.AutoSize = true;
            this.rdoMotherasrock.Location = new System.Drawing.Point(7, 43);
            this.rdoMotherasrock.Name = "rdoMotherasrock";
            this.rdoMotherasrock.Size = new System.Drawing.Size(99, 17);
            this.rdoMotherasrock.TabIndex = 0;
            this.rdoMotherasrock.TabStop = true;
            this.rdoMotherasrock.Text = "Mother AsRock";
            this.rdoMotherasrock.UseVisualStyleBackColor = true;
            this.rdoMotherasrock.CheckedChanged += new System.EventHandler(this.rdoMothermsi_CheckedChanged);
            // 
            // lblObliMadre
            // 
            this.lblObliMadre.AutoSize = true;
            this.lblObliMadre.ForeColor = System.Drawing.Color.Red;
            this.lblObliMadre.Location = new System.Drawing.Point(6, 63);
            this.lblObliMadre.Name = "lblObliMadre";
            this.lblObliMadre.Size = new System.Drawing.Size(61, 13);
            this.lblObliMadre.TabIndex = 2;
            this.lblObliMadre.Text = "*Obligatorio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblObliRam);
            this.groupBox2.Controls.Add(this.rdoRamochogb);
            this.groupBox2.Controls.Add(this.rdoRamcuatrogb);
            this.groupBox2.Location = new System.Drawing.Point(147, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 88);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAM";
            // 
            // lblObliRam
            // 
            this.lblObliRam.AutoSize = true;
            this.lblObliRam.ForeColor = System.Drawing.Color.Red;
            this.lblObliRam.Location = new System.Drawing.Point(6, 63);
            this.lblObliRam.Name = "lblObliRam";
            this.lblObliRam.Size = new System.Drawing.Size(61, 13);
            this.lblObliRam.TabIndex = 2;
            this.lblObliRam.Text = "*Obligatorio";
            // 
            // rdoRamochogb
            // 
            this.rdoRamochogb.AutoSize = true;
            this.rdoRamochogb.Location = new System.Drawing.Point(7, 43);
            this.rdoRamochogb.Name = "rdoRamochogb";
            this.rdoRamochogb.Size = new System.Drawing.Size(73, 17);
            this.rdoRamochogb.TabIndex = 0;
            this.rdoRamochogb.TabStop = true;
            this.rdoRamochogb.Text = "RAM 8GB";
            this.rdoRamochogb.UseVisualStyleBackColor = true;
            this.rdoRamochogb.CheckedChanged += new System.EventHandler(this.rdoRamcuatrogb_CheckedChanged);
            // 
            // rdoRamcuatrogb
            // 
            this.rdoRamcuatrogb.AutoSize = true;
            this.rdoRamcuatrogb.Location = new System.Drawing.Point(7, 20);
            this.rdoRamcuatrogb.Name = "rdoRamcuatrogb";
            this.rdoRamcuatrogb.Size = new System.Drawing.Size(73, 17);
            this.rdoRamcuatrogb.TabIndex = 0;
            this.rdoRamcuatrogb.TabStop = true;
            this.rdoRamcuatrogb.Text = "RAM 4GB";
            this.rdoRamcuatrogb.UseVisualStyleBackColor = true;
            this.rdoRamcuatrogb.CheckedChanged += new System.EventHandler(this.rdoRamcuatrogb_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblObliMicro);
            this.groupBox3.Controls.Add(this.rdoMicroAMD);
            this.groupBox3.Controls.Add(this.rdoMicroIntel);
            this.groupBox3.Location = new System.Drawing.Point(3, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 88);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Microprocesadores";
            // 
            // lblObliMicro
            // 
            this.lblObliMicro.AutoSize = true;
            this.lblObliMicro.ForeColor = System.Drawing.Color.Red;
            this.lblObliMicro.Location = new System.Drawing.Point(6, 63);
            this.lblObliMicro.Name = "lblObliMicro";
            this.lblObliMicro.Size = new System.Drawing.Size(61, 13);
            this.lblObliMicro.TabIndex = 2;
            this.lblObliMicro.Text = "*Obligatorio";
            // 
            // rdoMicroAMD
            // 
            this.rdoMicroAMD.AutoSize = true;
            this.rdoMicroAMD.Location = new System.Drawing.Point(7, 43);
            this.rdoMicroAMD.Name = "rdoMicroAMD";
            this.rdoMicroAMD.Size = new System.Drawing.Size(131, 17);
            this.rdoMicroAMD.TabIndex = 0;
            this.rdoMicroAMD.TabStop = true;
            this.rdoMicroAMD.Text = "Microprocesador AMD";
            this.rdoMicroAMD.UseVisualStyleBackColor = true;
            this.rdoMicroAMD.CheckedChanged += new System.EventHandler(this.rdoMicroIntel_CheckedChanged);
            // 
            // rdoMicroIntel
            // 
            this.rdoMicroIntel.AutoSize = true;
            this.rdoMicroIntel.Location = new System.Drawing.Point(7, 20);
            this.rdoMicroIntel.Name = "rdoMicroIntel";
            this.rdoMicroIntel.Size = new System.Drawing.Size(127, 17);
            this.rdoMicroIntel.TabIndex = 0;
            this.rdoMicroIntel.TabStop = true;
            this.rdoMicroIntel.Text = "Microprocesador Intel";
            this.rdoMicroIntel.UseVisualStyleBackColor = true;
            this.rdoMicroIntel.CheckedChanged += new System.EventHandler(this.rdoMicroIntel_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblObliDisco);
            this.groupBox4.Controls.Add(this.rdoHDDunTB);
            this.groupBox4.Controls.Add(this.rdoHDDquinientoGB);
            this.groupBox4.Location = new System.Drawing.Point(147, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(110, 87);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Disco Duro";
            // 
            // rdoHDDunTB
            // 
            this.rdoHDDunTB.AutoSize = true;
            this.rdoHDDunTB.Location = new System.Drawing.Point(9, 42);
            this.rdoHDDunTB.Name = "rdoHDDunTB";
            this.rdoHDDunTB.Size = new System.Drawing.Size(72, 17);
            this.rdoHDDunTB.TabIndex = 4;
            this.rdoHDDunTB.TabStop = true;
            this.rdoHDDunTB.Text = "HDD 1TB";
            this.rdoHDDunTB.UseVisualStyleBackColor = true;
            this.rdoHDDunTB.CheckedChanged += new System.EventHandler(this.rdoHDDquinientoGB_CheckedChanged);
            // 
            // rdoHDDquinientoGB
            // 
            this.rdoHDDquinientoGB.AutoSize = true;
            this.rdoHDDquinientoGB.Location = new System.Drawing.Point(9, 19);
            this.rdoHDDquinientoGB.Name = "rdoHDDquinientoGB";
            this.rdoHDDquinientoGB.Size = new System.Drawing.Size(85, 17);
            this.rdoHDDquinientoGB.TabIndex = 0;
            this.rdoHDDquinientoGB.TabStop = true;
            this.rdoHDDquinientoGB.Text = "HDD 500GB";
            this.rdoHDDquinientoGB.UseVisualStyleBackColor = true;
            this.rdoHDDquinientoGB.CheckedChanged += new System.EventHandler(this.rdoHDDquinientoGB_CheckedChanged);
            // 
            // lblObliDisco
            // 
            this.lblObliDisco.AutoSize = true;
            this.lblObliDisco.ForeColor = System.Drawing.Color.Red;
            this.lblObliDisco.Location = new System.Drawing.Point(6, 62);
            this.lblObliDisco.Name = "lblObliDisco";
            this.lblObliDisco.Size = new System.Drawing.Size(61, 13);
            this.lblObliDisco.TabIndex = 3;
            this.lblObliDisco.Text = "*Obligatorio";
            // 
            // grpmonitor
            // 
            this.grpmonitor.Controls.Add(this.rdoMonitorveintidos);
            this.grpmonitor.Controls.Add(this.lblObliMonitor);
            this.grpmonitor.Controls.Add(this.rdoMonitorDiecinueve);
            this.grpmonitor.Controls.Add(this.rdoSinMonitor);
            this.grpmonitor.Location = new System.Drawing.Point(13, 201);
            this.grpmonitor.Name = "grpmonitor";
            this.grpmonitor.Size = new System.Drawing.Size(110, 106);
            this.grpmonitor.TabIndex = 6;
            this.grpmonitor.TabStop = false;
            this.grpmonitor.Text = "Monitor";
            // 
            // lblObliMonitor
            // 
            this.lblObliMonitor.AutoSize = true;
            this.lblObliMonitor.ForeColor = System.Drawing.Color.Red;
            this.lblObliMonitor.Location = new System.Drawing.Point(4, 85);
            this.lblObliMonitor.Name = "lblObliMonitor";
            this.lblObliMonitor.Size = new System.Drawing.Size(61, 13);
            this.lblObliMonitor.TabIndex = 3;
            this.lblObliMonitor.Text = "*Obligatorio";
            // 
            // rdoMonitorDiecinueve
            // 
            this.rdoMonitorDiecinueve.AutoSize = true;
            this.rdoMonitorDiecinueve.Location = new System.Drawing.Point(9, 42);
            this.rdoMonitorDiecinueve.Name = "rdoMonitorDiecinueve";
            this.rdoMonitorDiecinueve.Size = new System.Drawing.Size(79, 17);
            this.rdoMonitorDiecinueve.TabIndex = 0;
            this.rdoMonitorDiecinueve.TabStop = true;
            this.rdoMonitorDiecinueve.Text = "Monitor 10\'\'";
            this.rdoMonitorDiecinueve.UseVisualStyleBackColor = true;
            this.rdoMonitorDiecinueve.CheckedChanged += new System.EventHandler(this.rdoSinMonitor_CheckedChanged);
            // 
            // rdoSinMonitor
            // 
            this.rdoSinMonitor.AutoSize = true;
            this.rdoSinMonitor.Location = new System.Drawing.Point(9, 19);
            this.rdoSinMonitor.Name = "rdoSinMonitor";
            this.rdoSinMonitor.Size = new System.Drawing.Size(78, 17);
            this.rdoSinMonitor.TabIndex = 0;
            this.rdoSinMonitor.TabStop = true;
            this.rdoSinMonitor.Text = "Sin Monitor";
            this.rdoSinMonitor.UseVisualStyleBackColor = true;
            this.rdoSinMonitor.CheckedChanged += new System.EventHandler(this.rdoSinMonitor_CheckedChanged);
            // 
            // rdoMonitorveintidos
            // 
            this.rdoMonitorveintidos.AutoSize = true;
            this.rdoMonitorveintidos.Location = new System.Drawing.Point(9, 65);
            this.rdoMonitorveintidos.Name = "rdoMonitorveintidos";
            this.rdoMonitorveintidos.Size = new System.Drawing.Size(79, 17);
            this.rdoMonitorveintidos.TabIndex = 0;
            this.rdoMonitorveintidos.TabStop = true;
            this.rdoMonitorveintidos.Text = "Monitor 22\'\'";
            this.rdoMonitorveintidos.UseVisualStyleBackColor = true;
            this.rdoMonitorveintidos.CheckedChanged += new System.EventHandler(this.rdoSinMonitor_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(147, 208);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 99);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 328);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grpmonitor);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Armado de Computadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpmonitor.ResumeLayout(false);
            this.grpmonitor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblObliMadre;
        private System.Windows.Forms.RadioButton rdoMotherasrock;
        private System.Windows.Forms.RadioButton rdoMothermsi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblObliRam;
        private System.Windows.Forms.RadioButton rdoRamochogb;
        private System.Windows.Forms.RadioButton rdoRamcuatrogb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblObliMicro;
        private System.Windows.Forms.RadioButton rdoMicroAMD;
        private System.Windows.Forms.RadioButton rdoMicroIntel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblObliDisco;
        private System.Windows.Forms.RadioButton rdoHDDunTB;
        private System.Windows.Forms.RadioButton rdoHDDquinientoGB;
        private System.Windows.Forms.GroupBox grpmonitor;
        private System.Windows.Forms.RadioButton rdoMonitorveintidos;
        private System.Windows.Forms.Label lblObliMonitor;
        private System.Windows.Forms.RadioButton rdoMonitorDiecinueve;
        private System.Windows.Forms.RadioButton rdoSinMonitor;
        private System.Windows.Forms.Button btnCalcular;
    }
}


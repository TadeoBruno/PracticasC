namespace EnvioCorreo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxDe = new System.Windows.Forms.TextBox();
            this.txtboxPass = new System.Windows.Forms.TextBox();
            this.txtboxPuerto = new System.Windows.Forms.TextBox();
            this.txtboxHost = new System.Windows.Forms.TextBox();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxPara = new System.Windows.Forms.TextBox();
            this.txtboxAsunto = new System.Windows.Forms.TextBox();
            this.txtboxCuerpo = new System.Windows.Forms.TextBox();
            this.bttnSalir = new System.Windows.Forms.Button();
            this.bttnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Emisor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "De:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puerto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Host:";
            // 
            // txtboxDe
            // 
            this.txtboxDe.Location = new System.Drawing.Point(126, 53);
            this.txtboxDe.Name = "txtboxDe";
            this.txtboxDe.Size = new System.Drawing.Size(100, 20);
            this.txtboxDe.TabIndex = 5;
            this.txtboxDe.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtboxPass
            // 
            this.txtboxPass.Location = new System.Drawing.Point(126, 82);
            this.txtboxPass.Name = "txtboxPass";
            this.txtboxPass.Size = new System.Drawing.Size(100, 20);
            this.txtboxPass.TabIndex = 6;
            this.txtboxPass.UseSystemPasswordChar = true;
            // 
            // txtboxPuerto
            // 
            this.txtboxPuerto.AcceptsReturn = true;
            this.txtboxPuerto.Location = new System.Drawing.Point(126, 113);
            this.txtboxPuerto.Name = "txtboxPuerto";
            this.txtboxPuerto.Size = new System.Drawing.Size(100, 20);
            this.txtboxPuerto.TabIndex = 7;
            // 
            // txtboxHost
            // 
            this.txtboxHost.Location = new System.Drawing.Point(126, 143);
            this.txtboxHost.Name = "txtboxHost";
            this.txtboxHost.Size = new System.Drawing.Size(100, 20);
            this.txtboxHost.TabIndex = 8;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(33, 197);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(94, 13);
            this.lblDestinatario.TabIndex = 9;
            this.lblDestinatario.Text = "Datos Destinatario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Para:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Asunto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cuerpo:";
            // 
            // txtboxPara
            // 
            this.txtboxPara.Location = new System.Drawing.Point(126, 231);
            this.txtboxPara.Name = "txtboxPara";
            this.txtboxPara.Size = new System.Drawing.Size(100, 20);
            this.txtboxPara.TabIndex = 13;
            // 
            // txtboxAsunto
            // 
            this.txtboxAsunto.Location = new System.Drawing.Point(126, 265);
            this.txtboxAsunto.Name = "txtboxAsunto";
            this.txtboxAsunto.Size = new System.Drawing.Size(100, 20);
            this.txtboxAsunto.TabIndex = 14;
            // 
            // txtboxCuerpo
            // 
            this.txtboxCuerpo.Location = new System.Drawing.Point(126, 299);
            this.txtboxCuerpo.Multiline = true;
            this.txtboxCuerpo.Name = "txtboxCuerpo";
            this.txtboxCuerpo.Size = new System.Drawing.Size(152, 102);
            this.txtboxCuerpo.TabIndex = 15;
            // 
            // bttnSalir
            // 
            this.bttnSalir.Location = new System.Drawing.Point(74, 415);
            this.bttnSalir.Name = "bttnSalir";
            this.bttnSalir.Size = new System.Drawing.Size(75, 23);
            this.bttnSalir.TabIndex = 16;
            this.bttnSalir.Text = "Salir";
            this.bttnSalir.UseVisualStyleBackColor = true;
            this.bttnSalir.Click += new System.EventHandler(this.bttnSalir_Click);
            // 
            // bttnEnviar
            // 
            this.bttnEnviar.Location = new System.Drawing.Point(291, 415);
            this.bttnEnviar.Name = "bttnEnviar";
            this.bttnEnviar.Size = new System.Drawing.Size(75, 23);
            this.bttnEnviar.TabIndex = 17;
            this.bttnEnviar.Text = "Enviar";
            this.bttnEnviar.UseVisualStyleBackColor = true;
            this.bttnEnviar.Click += new System.EventHandler(this.bttnEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.bttnEnviar);
            this.Controls.Add(this.bttnSalir);
            this.Controls.Add(this.txtboxCuerpo);
            this.Controls.Add(this.txtboxAsunto);
            this.Controls.Add(this.txtboxPara);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.txtboxHost);
            this.Controls.Add(this.txtboxPuerto);
            this.Controls.Add(this.txtboxPass);
            this.Controls.Add(this.txtboxDe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxDe;
        private System.Windows.Forms.TextBox txtboxPass;
        private System.Windows.Forms.TextBox txtboxPuerto;
        private System.Windows.Forms.TextBox txtboxHost;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxPara;
        private System.Windows.Forms.TextBox txtboxAsunto;
        private System.Windows.Forms.TextBox txtboxCuerpo;
        private System.Windows.Forms.Button bttnSalir;
        private System.Windows.Forms.Button bttnEnviar;
    }
}


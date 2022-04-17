namespace ExplicaHerramientas
{
    partial class frmPRINCIPAL
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPRINCIPAL));
            this.groTEXTBOX = new System.Windows.Forms.GroupBox();
            this.btnPROPIEDADESTEXTBOX = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnGET = new System.Windows.Forms.Button();
            this.txtTEXTBOX = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groCUADRODEMENSAJE = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRADIO = new System.Windows.Forms.Button();
            this.radJuan = new System.Windows.Forms.RadioButton();
            this.radCARO = new System.Windows.Forms.RadioButton();
            this.radROMINA = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkJuan = new System.Windows.Forms.CheckBox();
            this.chkCARO = new System.Windows.Forms.CheckBox();
            this.chkROMINA = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groTEXTBOX.SuspendLayout();
            this.groCUADRODEMENSAJE.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groTEXTBOX
            // 
            this.groTEXTBOX.Controls.Add(this.btnPROPIEDADESTEXTBOX);
            this.groTEXTBOX.Controls.Add(this.btnSet);
            this.groTEXTBOX.Controls.Add(this.btnGET);
            this.groTEXTBOX.Controls.Add(this.txtTEXTBOX);
            this.groTEXTBOX.Location = new System.Drawing.Point(13, 13);
            this.groTEXTBOX.Name = "groTEXTBOX";
            this.groTEXTBOX.Size = new System.Drawing.Size(453, 62);
            this.groTEXTBOX.TabIndex = 0;
            this.groTEXTBOX.TabStop = false;
            this.groTEXTBOX.Text = "Text Box";
            // 
            // btnPROPIEDADESTEXTBOX
            // 
            this.btnPROPIEDADESTEXTBOX.Location = new System.Drawing.Point(343, 16);
            this.btnPROPIEDADESTEXTBOX.Name = "btnPROPIEDADESTEXTBOX";
            this.btnPROPIEDADESTEXTBOX.Size = new System.Drawing.Size(75, 23);
            this.btnPROPIEDADESTEXTBOX.TabIndex = 3;
            this.btnPROPIEDADESTEXTBOX.Text = "Propiedades";
            this.btnPROPIEDADESTEXTBOX.UseVisualStyleBackColor = true;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(262, 16);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnGET
            // 
            this.btnGET.Location = new System.Drawing.Point(181, 16);
            this.btnGET.Name = "btnGET";
            this.btnGET.Size = new System.Drawing.Size(75, 23);
            this.btnGET.TabIndex = 1;
            this.btnGET.Text = "Get";
            this.btnGET.UseVisualStyleBackColor = true;
            this.btnGET.Click += new System.EventHandler(this.btnGET_Click);
            // 
            // txtTEXTBOX
            // 
            this.txtTEXTBOX.Location = new System.Drawing.Point(7, 20);
            this.txtTEXTBOX.Name = "txtTEXTBOX";
            this.txtTEXTBOX.Size = new System.Drawing.Size(167, 20);
            this.txtTEXTBOX.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 27);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.uai.edu.ar/";
            // 
            // groCUADRODEMENSAJE
            // 
            this.groCUADRODEMENSAJE.Controls.Add(this.linkLabel1);
            this.groCUADRODEMENSAJE.Location = new System.Drawing.Point(13, 251);
            this.groCUADRODEMENSAJE.Name = "groCUADRODEMENSAJE";
            this.groCUADRODEMENSAJE.Size = new System.Drawing.Size(400, 65);
            this.groCUADRODEMENSAJE.TabIndex = 2;
            this.groCUADRODEMENSAJE.TabStop = false;
            this.groCUADRODEMENSAJE.Text = "Cuadro de Mensaje";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRADIO);
            this.groupBox1.Controls.Add(this.radJuan);
            this.groupBox1.Controls.Add(this.radCARO);
            this.groupBox1.Controls.Add(this.radROMINA);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 78);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RadioButton";
            // 
            // btnRADIO
            // 
            this.btnRADIO.Location = new System.Drawing.Point(295, 37);
            this.btnRADIO.Name = "btnRADIO";
            this.btnRADIO.Size = new System.Drawing.Size(139, 23);
            this.btnRADIO.TabIndex = 3;
            this.btnRADIO.Text = "Dime a quien le toca...";
            this.btnRADIO.UseVisualStyleBackColor = true;
            this.btnRADIO.Click += new System.EventHandler(this.btnRADIO_Click);
            // 
            // radJuan
            // 
            this.radJuan.AutoSize = true;
            this.radJuan.Location = new System.Drawing.Point(217, 37);
            this.radJuan.Name = "radJuan";
            this.radJuan.Size = new System.Drawing.Size(48, 17);
            this.radJuan.TabIndex = 2;
            this.radJuan.TabStop = true;
            this.radJuan.Text = "Juan";
            this.radJuan.UseVisualStyleBackColor = true;
            // 
            // radCARO
            // 
            this.radCARO.AutoSize = true;
            this.radCARO.Location = new System.Drawing.Point(137, 37);
            this.radCARO.Name = "radCARO";
            this.radCARO.Size = new System.Drawing.Size(47, 17);
            this.radCARO.TabIndex = 1;
            this.radCARO.TabStop = true;
            this.radCARO.Text = "Caro";
            this.radCARO.UseVisualStyleBackColor = true;
            // 
            // radROMINA
            // 
            this.radROMINA.AutoSize = true;
            this.radROMINA.Location = new System.Drawing.Point(43, 37);
            this.radROMINA.Name = "radROMINA";
            this.radROMINA.Size = new System.Drawing.Size(61, 17);
            this.radROMINA.TabIndex = 0;
            this.radROMINA.TabStop = true;
            this.radROMINA.Text = "Romina";
            this.radROMINA.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkJuan);
            this.groupBox2.Controls.Add(this.chkCARO);
            this.groupBox2.Controls.Add(this.chkROMINA);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(13, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 78);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RadioButton";
            // 
            // chkJuan
            // 
            this.chkJuan.AutoSize = true;
            this.chkJuan.Location = new System.Drawing.Point(216, 37);
            this.chkJuan.Name = "chkJuan";
            this.chkJuan.Size = new System.Drawing.Size(49, 17);
            this.chkJuan.TabIndex = 6;
            this.chkJuan.Text = "Juan";
            this.chkJuan.UseVisualStyleBackColor = true;
            this.chkJuan.CheckedChanged += new System.EventHandler(this.chkJuan_CheckedChanged);
            // 
            // chkCARO
            // 
            this.chkCARO.AutoSize = true;
            this.chkCARO.Location = new System.Drawing.Point(105, 37);
            this.chkCARO.Name = "chkCARO";
            this.chkCARO.Size = new System.Drawing.Size(48, 17);
            this.chkCARO.TabIndex = 5;
            this.chkCARO.Text = "Caro";
            this.chkCARO.UseVisualStyleBackColor = true;
            // 
            // chkROMINA
            // 
            this.chkROMINA.AutoSize = true;
            this.chkROMINA.Location = new System.Drawing.Point(18, 37);
            this.chkROMINA.Name = "chkROMINA";
            this.chkROMINA.Size = new System.Drawing.Size(62, 17);
            this.chkROMINA.TabIndex = 4;
            this.chkROMINA.Text = "Romina";
            this.chkROMINA.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dime a quien le toca...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 328);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groCUADRODEMENSAJE);
            this.Controls.Add(this.groTEXTBOX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPRINCIPAL";
            this.Text = "FORMULARIO PRINCIPAL";
            this.Load += new System.EventHandler(this.frmPRINCIPAL_Load);
            this.groTEXTBOX.ResumeLayout(false);
            this.groTEXTBOX.PerformLayout();
            this.groCUADRODEMENSAJE.ResumeLayout(false);
            this.groCUADRODEMENSAJE.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groTEXTBOX;
        private System.Windows.Forms.TextBox txtTEXTBOX;
        private System.Windows.Forms.Button btnGET;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groCUADRODEMENSAJE;
        private System.Windows.Forms.Button btnPROPIEDADESTEXTBOX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRADIO;
        private System.Windows.Forms.RadioButton radJuan;
        private System.Windows.Forms.RadioButton radCARO;
        private System.Windows.Forms.RadioButton radROMINA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkJuan;
        private System.Windows.Forms.CheckBox chkCARO;
        private System.Windows.Forms.CheckBox chkROMINA;
        private System.Windows.Forms.Button button1;
    }
}


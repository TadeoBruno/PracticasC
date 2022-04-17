namespace Bruno_Tadeo
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
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.dateTimePickerFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txetBoxApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbBoxSexo = new System.Windows.Forms.ComboBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtBoxPeso = new System.Windows.Forms.TextBox();
            this.lblComidas = new System.Windows.Forms.Label();
            this.lblCantColaciones = new System.Windows.Forms.Label();
            this.txtBoxColaciones = new System.Windows.Forms.TextBox();
            this.lblAgua = new System.Windows.Forms.Label();
            this.rdoButtonSi = new System.Windows.Forms.RadioButton();
            this.rdoButtonNo = new System.Windows.Forms.RadioButton();
            this.buttonListo = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.lblObligatorioApellido = new System.Windows.Forms.Label();
            this.lblObligatorioNombre = new System.Windows.Forms.Label();
            this.chlbComidas = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(12, 48);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(92, 13);
            this.lblFechaRegistro.TabIndex = 0;
            this.lblFechaRegistro.Text = "Fecha de registro:";
            // 
            // dateTimePickerFechaRegistro
            // 
            this.dateTimePickerFechaRegistro.Location = new System.Drawing.Point(152, 41);
            this.dateTimePickerFechaRegistro.Name = "dateTimePickerFechaRegistro";
            this.dateTimePickerFechaRegistro.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaRegistro.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 79);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // txetBoxApellido
            // 
            this.txetBoxApellido.Location = new System.Drawing.Point(152, 72);
            this.txetBoxApellido.Name = "txetBoxApellido";
            this.txetBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.txetBoxApellido.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 112);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(152, 105);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 5;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(12, 145);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(109, 13);
            this.lblFechaNacimiento.TabIndex = 6;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(152, 138);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaNacimiento.TabIndex = 7;
            this.dateTimePickerFechaNacimiento.Value = new System.DateTime(2020, 9, 24, 23, 59, 59, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Correo Electronico:";
            // 
            // textBoxCorreoElectronico
            // 
            this.textBoxCorreoElectronico.Location = new System.Drawing.Point(152, 170);
            this.textBoxCorreoElectronico.Name = "textBoxCorreoElectronico";
            this.textBoxCorreoElectronico.Size = new System.Drawing.Size(100, 20);
            this.textBoxCorreoElectronico.TabIndex = 9;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(12, 206);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo:";
            // 
            // cmbBoxSexo
            // 
            this.cmbBoxSexo.FormattingEnabled = true;
            this.cmbBoxSexo.Items.AddRange(new object[] {
            "Seleccione",
            "Femenino",
            "Masculino"});
            this.cmbBoxSexo.Location = new System.Drawing.Point(152, 198);
            this.cmbBoxSexo.Name = "cmbBoxSexo";
            this.cmbBoxSexo.Size = new System.Drawing.Size(79, 21);
            this.cmbBoxSexo.TabIndex = 11;
            this.cmbBoxSexo.Text = "Seleccione";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(12, 236);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 12;
            this.lblPeso.Text = "Peso:";
            // 
            // txtBoxPeso
            // 
            this.txtBoxPeso.Location = new System.Drawing.Point(152, 229);
            this.txtBoxPeso.Name = "txtBoxPeso";
            this.txtBoxPeso.Size = new System.Drawing.Size(37, 20);
            this.txtBoxPeso.TabIndex = 13;
            // 
            // lblComidas
            // 
            this.lblComidas.AutoSize = true;
            this.lblComidas.Location = new System.Drawing.Point(12, 267);
            this.lblComidas.Name = "lblComidas";
            this.lblComidas.Size = new System.Drawing.Size(134, 13);
            this.lblComidas.TabIndex = 14;
            this.lblComidas.Text = "Comidas que realiza al día:";
            // 
            // lblCantColaciones
            // 
            this.lblCantColaciones.AutoSize = true;
            this.lblCantColaciones.Location = new System.Drawing.Point(278, 267);
            this.lblCantColaciones.Name = "lblCantColaciones";
            this.lblCantColaciones.Size = new System.Drawing.Size(121, 13);
            this.lblCantColaciones.TabIndex = 16;
            this.lblCantColaciones.Text = "Cantidad de colaciones:";
            this.lblCantColaciones.Visible = false;
            // 
            // txtBoxColaciones
            // 
            this.txtBoxColaciones.Location = new System.Drawing.Point(405, 260);
            this.txtBoxColaciones.Name = "txtBoxColaciones";
            this.txtBoxColaciones.Size = new System.Drawing.Size(31, 20);
            this.txtBoxColaciones.TabIndex = 17;
            this.txtBoxColaciones.Visible = false;
            this.txtBoxColaciones.TextChanged += new System.EventHandler(this.txtBoxColaciones_TextChanged);
            // 
            // lblAgua
            // 
            this.lblAgua.AutoSize = true;
            this.lblAgua.Location = new System.Drawing.Point(12, 359);
            this.lblAgua.Name = "lblAgua";
            this.lblAgua.Size = new System.Drawing.Size(170, 13);
            this.lblAgua.TabIndex = 18;
            this.lblAgua.Text = "Bebe 2 litros de agua diariamente?";
            // 
            // rdoButtonSi
            // 
            this.rdoButtonSi.AutoSize = true;
            this.rdoButtonSi.Location = new System.Drawing.Point(189, 355);
            this.rdoButtonSi.Name = "rdoButtonSi";
            this.rdoButtonSi.Size = new System.Drawing.Size(34, 17);
            this.rdoButtonSi.TabIndex = 19;
            this.rdoButtonSi.TabStop = true;
            this.rdoButtonSi.Text = "Si";
            this.rdoButtonSi.UseVisualStyleBackColor = true;
            // 
            // rdoButtonNo
            // 
            this.rdoButtonNo.AutoSize = true;
            this.rdoButtonNo.Location = new System.Drawing.Point(229, 355);
            this.rdoButtonNo.Name = "rdoButtonNo";
            this.rdoButtonNo.Size = new System.Drawing.Size(39, 17);
            this.rdoButtonNo.TabIndex = 20;
            this.rdoButtonNo.TabStop = true;
            this.rdoButtonNo.Text = "No";
            this.rdoButtonNo.UseVisualStyleBackColor = true;
            // 
            // buttonListo
            // 
            this.buttonListo.Location = new System.Drawing.Point(324, 398);
            this.buttonListo.Name = "buttonListo";
            this.buttonListo.Size = new System.Drawing.Size(85, 31);
            this.buttonListo.TabIndex = 21;
            this.buttonListo.Text = "Listo";
            this.buttonListo.UseVisualStyleBackColor = true;
            this.buttonListo.Click += new System.EventHandler(this.buttonListo_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(64, 398);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(82, 31);
            this.buttonCancelar.TabIndex = 22;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // lblObligatorioApellido
            // 
            this.lblObligatorioApellido.AutoSize = true;
            this.lblObligatorioApellido.ForeColor = System.Drawing.Color.Red;
            this.lblObligatorioApellido.Location = new System.Drawing.Point(258, 72);
            this.lblObligatorioApellido.Name = "lblObligatorioApellido";
            this.lblObligatorioApellido.Size = new System.Drawing.Size(59, 13);
            this.lblObligatorioApellido.TabIndex = 23;
            this.lblObligatorioApellido.Text = "*obligatorio";
            // 
            // lblObligatorioNombre
            // 
            this.lblObligatorioNombre.AutoSize = true;
            this.lblObligatorioNombre.ForeColor = System.Drawing.Color.Red;
            this.lblObligatorioNombre.Location = new System.Drawing.Point(258, 105);
            this.lblObligatorioNombre.Name = "lblObligatorioNombre";
            this.lblObligatorioNombre.Size = new System.Drawing.Size(59, 13);
            this.lblObligatorioNombre.TabIndex = 24;
            this.lblObligatorioNombre.Text = "*obligatorio";
            // 
            // chlbComidas
            // 
            this.chlbComidas.CheckOnClick = true;
            this.chlbComidas.FormattingEnabled = true;
            this.chlbComidas.Location = new System.Drawing.Point(153, 267);
            this.chlbComidas.Name = "chlbComidas";
            this.chlbComidas.Size = new System.Drawing.Size(115, 79);
            this.chlbComidas.TabIndex = 25;
            this.chlbComidas.SelectedIndexChanged += new System.EventHandler(this.chlbComidas_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.chlbComidas);
            this.Controls.Add(this.lblObligatorioNombre);
            this.Controls.Add(this.lblObligatorioApellido);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonListo);
            this.Controls.Add(this.rdoButtonNo);
            this.Controls.Add(this.rdoButtonSi);
            this.Controls.Add(this.lblAgua);
            this.Controls.Add(this.txtBoxColaciones);
            this.Controls.Add(this.lblCantColaciones);
            this.Controls.Add(this.lblComidas);
            this.Controls.Add(this.txtBoxPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.cmbBoxSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.textBoxCorreoElectronico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txetBoxApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.dateTimePickerFechaRegistro);
            this.Controls.Add(this.lblFechaRegistro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaRegistro;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txetBoxApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCorreoElectronico;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbBoxSexo;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtBoxPeso;
        private System.Windows.Forms.Label lblComidas;
        private System.Windows.Forms.Label lblCantColaciones;
        private System.Windows.Forms.TextBox txtBoxColaciones;
        private System.Windows.Forms.Label lblAgua;
        private System.Windows.Forms.RadioButton rdoButtonSi;
        private System.Windows.Forms.RadioButton rdoButtonNo;
        private System.Windows.Forms.Button buttonListo;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label lblObligatorioApellido;
        private System.Windows.Forms.Label lblObligatorioNombre;
        private System.Windows.Forms.CheckedListBox chlbComidas;
    }
}


namespace TadeoBruno1erParcial
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.txtbMail = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblComidas = new System.Windows.Forms.Label();
            this.checklbComidas = new System.Windows.Forms.CheckedListBox();
            this.lblCantComidas = new System.Windows.Forms.Label();
            this.numlistCantComidas = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.radbtnSi = new System.Windows.Forms.RadioButton();
            this.radbtnNo = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numlistCantComidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 80);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione fecha del registro:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(12, 114);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(109, 13);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(12, 145);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(96, 13);
            this.lblMail.TabIndex = 5;
            this.lblMail.Text = "Correo electrónico:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(12, 181);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(52, 178);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(93, 21);
            this.cmbSexo.TabIndex = 7;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(65, 45);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(123, 20);
            this.txtbNombre.TabIndex = 8;
            this.txtbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNombre_KeyPress);
            // 
            // txtbApellido
            // 
            this.txtbApellido.Location = new System.Drawing.Point(65, 77);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Size = new System.Drawing.Size(123, 20);
            this.txtbApellido.TabIndex = 9;
            this.txtbApellido.TextChanged += new System.EventHandler(this.txtbApellido_TextChanged);
            this.txtbApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbApellido_KeyPress);
            // 
            // txtbMail
            // 
            this.txtbMail.Location = new System.Drawing.Point(114, 142);
            this.txtbMail.Name = "txtbMail";
            this.txtbMail.Size = new System.Drawing.Size(158, 20);
            this.txtbMail.TabIndex = 10;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(12, 219);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 11;
            this.lblPeso.Text = "Peso:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(308, 442);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(390, 442);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(127, 108);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // lblComidas
            // 
            this.lblComidas.AutoSize = true;
            this.lblComidas.Location = new System.Drawing.Point(12, 253);
            this.lblComidas.Name = "lblComidas";
            this.lblComidas.Size = new System.Drawing.Size(173, 13);
            this.lblComidas.TabIndex = 16;
            this.lblComidas.Text = "Comidas que realiza durante el día:";
            // 
            // checklbComidas
            // 
            this.checklbComidas.CheckOnClick = true;
            this.checklbComidas.FormattingEnabled = true;
            this.checklbComidas.Location = new System.Drawing.Point(191, 253);
            this.checklbComidas.Name = "checklbComidas";
            this.checklbComidas.Size = new System.Drawing.Size(108, 94);
            this.checklbComidas.TabIndex = 17;
            this.checklbComidas.SelectedIndexChanged += new System.EventHandler(this.checklbComidas_SelectedIndexChanged);
            this.checklbComidas.SelectedValueChanged += new System.EventHandler(this.checklbComidas_SelectedValueChanged);
            // 
            // lblCantComidas
            // 
            this.lblCantComidas.AutoSize = true;
            this.lblCantComidas.Location = new System.Drawing.Point(305, 253);
            this.lblCantComidas.Name = "lblCantComidas";
            this.lblCantComidas.Size = new System.Drawing.Size(121, 13);
            this.lblCantComidas.TabIndex = 18;
            this.lblCantComidas.Text = "Cantidad de colaciones:";
            this.lblCantComidas.Click += new System.EventHandler(this.label2_Click);
            // 
            // numlistCantComidas
            // 
            this.numlistCantComidas.Location = new System.Drawing.Point(432, 251);
            this.numlistCantComidas.Name = "numlistCantComidas";
            this.numlistCantComidas.Size = new System.Drawing.Size(38, 20);
            this.numlistCantComidas.TabIndex = 19;
            this.numlistCantComidas.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Location = new System.Drawing.Point(12, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Bebes 2 litros de agua diariamente?";
            // 
            // radbtnSi
            // 
            this.radbtnSi.AutoSize = true;
            this.radbtnSi.Location = new System.Drawing.Point(191, 365);
            this.radbtnSi.Name = "radbtnSi";
            this.radbtnSi.Size = new System.Drawing.Size(34, 17);
            this.radbtnSi.TabIndex = 21;
            this.radbtnSi.TabStop = true;
            this.radbtnSi.Text = "Si";
            this.radbtnSi.UseVisualStyleBackColor = true;
            // 
            // radbtnNo
            // 
            this.radbtnNo.AutoSize = true;
            this.radbtnNo.Location = new System.Drawing.Point(191, 388);
            this.radbtnNo.Name = "radbtnNo";
            this.radbtnNo.Size = new System.Drawing.Size(39, 17);
            this.radbtnNo.TabIndex = 22;
            this.radbtnNo.TabStop = true;
            this.radbtnNo.Text = "No";
            this.radbtnNo.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(52, 217);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown1.TabIndex = 23;
            this.numericUpDown1.Leave += new System.EventHandler(this.numericUpDown1_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 477);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.radbtnNo);
            this.Controls.Add(this.radbtnSi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numlistCantComidas);
            this.Controls.Add(this.lblCantComidas);
            this.Controls.Add(this.checklbComidas);
            this.Controls.Add(this.lblComidas);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtbMail);
            this.Controls.Add(this.txtbApellido);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Bruno Tadeo - Registro Clientes 1er Parcial";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numlistCantComidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.TextBox txtbMail;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblComidas;
        private System.Windows.Forms.CheckedListBox checklbComidas;
        private System.Windows.Forms.Label lblCantComidas;
        private System.Windows.Forms.NumericUpDown numlistCantComidas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radbtnSi;
        private System.Windows.Forms.RadioButton radbtnNo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}


namespace Validacionesss
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
            this.cboxGenero = new System.Windows.Forms.ComboBox();
            this.txtbxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btbConfirmar = new System.Windows.Forms.Button();
            this.btbCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboxGenero
            // 
            this.cboxGenero.FormattingEnabled = true;
            this.cboxGenero.Location = new System.Drawing.Point(133, 118);
            this.cboxGenero.Name = "cboxGenero";
            this.cboxGenero.Size = new System.Drawing.Size(121, 21);
            this.cboxGenero.TabIndex = 1;
            this.cboxGenero.Text = "Seleccione genero";
            this.cboxGenero.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtbxNombre
            // 
            this.txtbxNombre.Location = new System.Drawing.Point(115, 57);
            this.txtbxNombre.Name = "txtbxNombre";
            this.txtbxNombre.Size = new System.Drawing.Size(157, 20);
            this.txtbxNombre.TabIndex = 2;
            this.txtbxNombre.TextChanged += new System.EventHandler(this.txtbxNombre_TextChanged);
            this.txtbxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de nacimiento :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btbConfirmar
            // 
            this.btbConfirmar.Location = new System.Drawing.Point(73, 251);
            this.btbConfirmar.Name = "btbConfirmar";
            this.btbConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btbConfirmar.TabIndex = 5;
            this.btbConfirmar.Text = "Confirmar";
            this.btbConfirmar.UseVisualStyleBackColor = true;
            this.btbConfirmar.Click += new System.EventHandler(this.btbConfirmar_Click);
            // 
            // btbCerrar
            // 
            this.btbCerrar.Location = new System.Drawing.Point(274, 251);
            this.btbCerrar.Name = "btbCerrar";
            this.btbCerrar.Size = new System.Drawing.Size(75, 23);
            this.btbCerrar.TabIndex = 6;
            this.btbCerrar.Text = "Cerrar";
            this.btbCerrar.UseVisualStyleBackColor = true;
            this.btbCerrar.Click += new System.EventHandler(this.btbCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 313);
            this.Controls.Add(this.btbCerrar);
            this.Controls.Add(this.btbConfirmar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxNombre);
            this.Controls.Add(this.cboxGenero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxGenero;
        private System.Windows.Forms.TextBox txtbxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btbConfirmar;
        private System.Windows.Forms.Button btbCerrar;
    }
}


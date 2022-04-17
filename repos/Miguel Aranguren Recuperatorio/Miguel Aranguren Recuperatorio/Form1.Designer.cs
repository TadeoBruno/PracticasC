
namespace Miguel_Aranguren_Recuperatorio
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblcosto = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.GBIVA = new System.Windows.Forms.GroupBox();
            this.RBsi = new System.Windows.Forms.RadioButton();
            this.RBno = new System.Windows.Forms.RadioButton();
            this.cmbPromo = new System.Windows.Forms.ComboBox();
            this.lblPromo = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.GBIVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(14, 38);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(40, 13);
            this.lblfecha.TabIndex = 1;
            this.lblfecha.Text = "Fecha:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(15, 74);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(56, 13);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto :";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(77, 71);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(150, 20);
            this.txtProducto.TabIndex = 3;
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducto_KeyPress);
            // 
            // lblcosto
            // 
            this.lblcosto.AutoSize = true;
            this.lblcosto.Location = new System.Drawing.Point(17, 114);
            this.lblcosto.Name = "lblcosto";
            this.lblcosto.Size = new System.Drawing.Size(37, 13);
            this.lblcosto.TabIndex = 4;
            this.lblcosto.Text = "Costo:";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(61, 114);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 5;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // GBIVA
            // 
            this.GBIVA.Controls.Add(this.RBno);
            this.GBIVA.Controls.Add(this.RBsi);
            this.GBIVA.Location = new System.Drawing.Point(20, 150);
            this.GBIVA.Name = "GBIVA";
            this.GBIVA.Size = new System.Drawing.Size(141, 75);
            this.GBIVA.TabIndex = 6;
            this.GBIVA.TabStop = false;
            this.GBIVA.Text = "IVA";
            // 
            // RBsi
            // 
            this.RBsi.AutoSize = true;
            this.RBsi.Location = new System.Drawing.Point(17, 33);
            this.RBsi.Name = "RBsi";
            this.RBsi.Size = new System.Drawing.Size(35, 17);
            this.RBsi.TabIndex = 0;
            this.RBsi.TabStop = true;
            this.RBsi.Text = "SI";
            this.RBsi.UseVisualStyleBackColor = true;
            // 
            // RBno
            // 
            this.RBno.AutoSize = true;
            this.RBno.Location = new System.Drawing.Point(84, 33);
            this.RBno.Name = "RBno";
            this.RBno.Size = new System.Drawing.Size(39, 17);
            this.RBno.TabIndex = 1;
            this.RBno.TabStop = true;
            this.RBno.Text = "No";
            this.RBno.UseVisualStyleBackColor = true;
            // 
            // cmbPromo
            // 
            this.cmbPromo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPromo.FormattingEnabled = true;
            this.cmbPromo.Location = new System.Drawing.Point(23, 279);
            this.cmbPromo.Name = "cmbPromo";
            this.cmbPromo.Size = new System.Drawing.Size(225, 21);
            this.cmbPromo.TabIndex = 7;
            // 
            // lblPromo
            // 
            this.lblPromo.AutoSize = true;
            this.lblPromo.Location = new System.Drawing.Point(18, 260);
            this.lblPromo.Name = "lblPromo";
            this.lblPromo.Size = new System.Drawing.Size(68, 13);
            this.lblPromo.TabIndex = 8;
            this.lblPromo.Text = "Promociones";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(223, 380);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblPromo);
            this.Controls.Add(this.cmbPromo);
            this.Controls.Add(this.GBIVA);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblcosto);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Recuperatorio Miguel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBIVA.ResumeLayout(false);
            this.GBIVA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblcosto;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.GroupBox GBIVA;
        private System.Windows.Forms.RadioButton RBno;
        private System.Windows.Forms.RadioButton RBsi;
        private System.Windows.Forms.ComboBox cmbPromo;
        private System.Windows.Forms.Label lblPromo;
        private System.Windows.Forms.Button btnConfirmar;
    }
}


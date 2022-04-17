namespace Peaje2
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
            this.btnNewPeaje = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblprecio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewPeaje
            // 
            this.btnNewPeaje.Location = new System.Drawing.Point(52, 96);
            this.btnNewPeaje.Name = "btnNewPeaje";
            this.btnNewPeaje.Size = new System.Drawing.Size(79, 23);
            this.btnNewPeaje.TabIndex = 0;
            this.btnNewPeaje.Text = "Nuevo Peaje";
            this.btnNewPeaje.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(233, 96);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(52, 38);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(73, 13);
            this.lblprecio.TabIndex = 2;
            this.lblprecio.Text = "Total a pagar:";
            this.lblprecio.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Enabled = false;
            this.lblTotalPagar.Location = new System.Drawing.Point(131, 38);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(35, 13);
            this.lblTotalPagar.TabIndex = 4;
            this.lblTotalPagar.Text = "label2";
            this.lblTotalPagar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 157);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNewPeaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewPeaje;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPagar;
    }
}


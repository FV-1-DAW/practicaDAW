namespace ProyectoControlVersiones
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
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tApellidos = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.lApellidos = new System.Windows.Forms.Label();
            this.tTelefono = new System.Windows.Forms.TextBox();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lListaSocios = new System.Windows.Forms.Label();
            this.tListaSocios = new System.Windows.Forms.TextBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(182, 54);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(137, 20);
            this.tNombre.TabIndex = 0;
            // 
            // tApellidos
            // 
            this.tApellidos.Location = new System.Drawing.Point(471, 54);
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(139, 20);
            this.tApellidos.TabIndex = 1;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(112, 54);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 2;
            this.lNombre.Text = "Nombre:";
            // 
            // lApellidos
            // 
            this.lApellidos.AutoSize = true;
            this.lApellidos.Location = new System.Drawing.Point(383, 54);
            this.lApellidos.Name = "lApellidos";
            this.lApellidos.Size = new System.Drawing.Size(52, 13);
            this.lApellidos.TabIndex = 3;
            this.lApellidos.Text = "Apellidos:";
            // 
            // tTelefono
            // 
            this.tTelefono.Location = new System.Drawing.Point(757, 54);
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(142, 20);
            this.tTelefono.TabIndex = 4;
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Location = new System.Drawing.Point(681, 54);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(55, 13);
            this.lTelefono.TabIndex = 5;
            this.lTelefono.Text = "Teléfono: ";
            // 
            // lListaSocios
            // 
            this.lListaSocios.AutoSize = true;
            this.lListaSocios.Location = new System.Drawing.Point(112, 162);
            this.lListaSocios.Name = "lListaSocios";
            this.lListaSocios.Size = new System.Drawing.Size(67, 13);
            this.lListaSocios.TabIndex = 6;
            this.lListaSocios.Text = "Lista Socios:";
            // 
            // tListaSocios
            // 
            this.tListaSocios.Location = new System.Drawing.Point(182, 223);
            this.tListaSocios.Multiline = true;
            this.tListaSocios.Name = "tListaSocios";
            this.tListaSocios.ReadOnly = true;
            this.tListaSocios.Size = new System.Drawing.Size(717, 327);
            this.tListaSocios.TabIndex = 7;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(795, 141);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(104, 44);
            this.bGuardar.TabIndex = 8;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 621);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.tListaSocios);
            this.Controls.Add(this.lListaSocios);
            this.Controls.Add(this.lTelefono);
            this.Controls.Add(this.tTelefono);
            this.Controls.Add(this.lApellidos);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.tApellidos);
            this.Controls.Add(this.tNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tApellidos;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lApellidos;
        private System.Windows.Forms.TextBox tTelefono;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label lListaSocios;
        private System.Windows.Forms.TextBox tListaSocios;
        private System.Windows.Forms.Button bGuardar;
    }
}


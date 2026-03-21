namespace practica_2_IPC2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.btonRegistrar = new System.Windows.Forms.Button();
            this.btonAtender = new System.Windows.Forms.Button();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.btonGrafica = new System.Windows.Forms.Button();
            this.txtTiempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(488, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "SISTEMA DE TURNOS MEDICOS";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(281, 148);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(343, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(96, 148);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 16);
            this.label.TabIndex = 6;
            this.label.Text = "Nombre:";
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(281, 202);
            this.numEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(191, 22);
            this.numEdad.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Especialidad:";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(281, 258);
            this.cmbEspecialidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(191, 24);
            this.cmbEspecialidad.TabIndex = 9;
            // 
            // btonRegistrar
            // 
            this.btonRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonRegistrar.Location = new System.Drawing.Point(128, 345);
            this.btonRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btonRegistrar.Name = "btonRegistrar";
            this.btonRegistrar.Size = new System.Drawing.Size(152, 49);
            this.btonRegistrar.TabIndex = 10;
            this.btonRegistrar.Text = "Registrar";
            this.btonRegistrar.UseVisualStyleBackColor = true;
            this.btonRegistrar.Click += new System.EventHandler(this.btonRegistrar_Click);
            // 
            // btonAtender
            // 
            this.btonAtender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonAtender.Location = new System.Drawing.Point(379, 345);
            this.btonAtender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btonAtender.Name = "btonAtender";
            this.btonAtender.Size = new System.Drawing.Size(148, 49);
            this.btonAtender.TabIndex = 11;
            this.btonAtender.Text = "Atender";
            this.btonAtender.UseVisualStyleBackColor = true;
            this.btonAtender.Click += new System.EventHandler(this.btonAtender_Click);
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 16;
            this.lstPacientes.Location = new System.Drawing.Point(66, 439);
            this.lstPacientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(487, 180);
            this.lstPacientes.TabIndex = 12;
            this.lstPacientes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btonGrafica
            // 
            this.btonGrafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonGrafica.Location = new System.Drawing.Point(689, 297);
            this.btonGrafica.Margin = new System.Windows.Forms.Padding(4);
            this.btonGrafica.Name = "btonGrafica";
            this.btonGrafica.Size = new System.Drawing.Size(292, 209);
            this.btonGrafica.TabIndex = 13;
            this.btonGrafica.Text = "Generar Grafica";
            this.btonGrafica.UseVisualStyleBackColor = true;
            this.btonGrafica.Click += new System.EventHandler(this.btonGrafica_Click);
            // 
            // txtTiempo
            // 
            this.txtTiempo.AutoSize = true;
            this.txtTiempo.Location = new System.Drawing.Point(143, 625);
            this.txtTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(0, 16);
            this.txtTiempo.TabIndex = 15;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 665);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.btonGrafica);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.btonAtender);
            this.Controls.Add(this.btonRegistrar);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numEdad);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Button btonRegistrar;
        private System.Windows.Forms.Button btonAtender;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.Button btonGrafica;
        private System.Windows.Forms.Label txtTiempo;
    }
}


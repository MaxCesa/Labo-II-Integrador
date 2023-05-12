namespace PrimerParcialLabo_Intento2
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnCrear = new Button();
            btnInformacion = new Button();
            btnJugar = new Button();
            btnExportar = new Button();
            btnUsuarios = new Button();
            lblUsuario = new Label();
            campañaBindingSource = new BindingSource(components);
            btnSeleccionarPersonaje = new Button();
            lstPersonajes = new ListBox();
            lblTextoPersonaje = new Label();
            lblPersonajeSeleccionado = new Label();
            ((System.ComponentModel.ISupportInitialize)campañaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(12, 12);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(251, 46);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear personaje";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnInformacion
            // 
            btnInformacion.Enabled = false;
            btnInformacion.Location = new Point(12, 170);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Size = new Size(251, 46);
            btnInformacion.TabIndex = 2;
            btnInformacion.Text = "Informacion";
            btnInformacion.UseVisualStyleBackColor = true;
            // 
            // btnJugar
            // 
            btnJugar.Enabled = false;
            btnJugar.Location = new Point(12, 91);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(251, 46);
            btnJugar.TabIndex = 3;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Enabled = false;
            btnExportar.Location = new Point(12, 254);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(251, 46);
            btnExportar.TabIndex = 4;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(12, 334);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(251, 46);
            btnUsuarios.TabIndex = 5;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Visible = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 393);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(66, 20);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario: ";
            // 
            // btnSeleccionarPersonaje
            // 
            btnSeleccionarPersonaje.Location = new Point(535, 351);
            btnSeleccionarPersonaje.Name = "btnSeleccionarPersonaje";
            btnSeleccionarPersonaje.Size = new Size(94, 29);
            btnSeleccionarPersonaje.TabIndex = 10;
            btnSeleccionarPersonaje.Text = "Seleccionar";
            btnSeleccionarPersonaje.UseVisualStyleBackColor = true;
            btnSeleccionarPersonaje.Click += btnSeleccionarPersonaje_Click;
            // 
            // lstPersonajes
            // 
            lstPersonajes.FormattingEnabled = true;
            lstPersonajes.ItemHeight = 20;
            lstPersonajes.Location = new Point(316, 12);
            lstPersonajes.Name = "lstPersonajes";
            lstPersonajes.Size = new Size(313, 324);
            lstPersonajes.TabIndex = 11;
            // 
            // lblTextoPersonaje
            // 
            lblTextoPersonaje.AutoSize = true;
            lblTextoPersonaje.Location = new Point(316, 355);
            lblTextoPersonaje.Name = "lblTextoPersonaje";
            lblTextoPersonaje.Size = new Size(166, 20);
            lblTextoPersonaje.TabIndex = 12;
            lblTextoPersonaje.Text = "Personaje seleccionado:";
            // 
            // lblPersonajeSeleccionado
            // 
            lblPersonajeSeleccionado.AutoSize = true;
            lblPersonajeSeleccionado.Location = new Point(316, 375);
            lblPersonajeSeleccionado.Name = "lblPersonajeSeleccionado";
            lblPersonajeSeleccionado.Size = new Size(0, 20);
            lblPersonajeSeleccionado.TabIndex = 13;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 450);
            Controls.Add(lblPersonajeSeleccionado);
            Controls.Add(lblTextoPersonaje);
            Controls.Add(lstPersonajes);
            Controls.Add(btnExportar);
            Controls.Add(btnInformacion);
            Controls.Add(btnCrear);
            Controls.Add(btnJugar);
            Controls.Add(btnSeleccionarPersonaje);
            Controls.Add(lblUsuario);
            Controls.Add(btnUsuarios);
            Name = "frmMainMenu";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)campañaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCrear;
        private Button btnInformacion;
        private Button btnJugar;
        private Button btnExportar;
        private Button btnUsuarios;
        private Label lblUsuario;
        private BindingSource campañaBindingSource;
        private Button btnSeleccionarPersonaje;
        private ListBox lstPersonajes;
        private Label lblTextoPersonaje;
        private Label lblPersonajeSeleccionado;
    }
}
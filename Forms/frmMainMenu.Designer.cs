﻿namespace PrimerParcialLabo_Intento2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            btnCrear = new Button();
            btnInformacion = new Button();
            btnJugar = new Button();
            btnExportar = new Button();
            btnUsuarios = new Button();
            lblUsuario = new Label();
            campañaBindingSource = new BindingSource(components);
            btnSeleccionarPersonaje = new Button();
            lstPersonajes = new ListBox();
            lblPersonajeSeleccionado = new Label();
            panelMenu = new Panel();
            btnImportarDB = new Button();
            panelContenedor = new Panel();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)campañaBindingSource).BeginInit();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Transparent;
            btnCrear.BackgroundImage = Properties.Resources.pngegg;
            btnCrear.BackgroundImageLayout = ImageLayout.Stretch;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrear.Location = new Point(6, 29);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(175, 46);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear personaje";
            toolTip1.SetToolTip(btnCrear, "Crear un nuevo personaje.");
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnInformacion
            // 
            btnInformacion.BackColor = Color.Transparent;
            btnInformacion.BackgroundImage = Properties.Resources.pngegg;
            btnInformacion.BackgroundImageLayout = ImageLayout.Stretch;
            btnInformacion.Enabled = false;
            btnInformacion.FlatAppearance.BorderSize = 0;
            btnInformacion.FlatStyle = FlatStyle.Flat;
            btnInformacion.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnInformacion.Location = new Point(6, 81);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Size = new Size(175, 46);
            btnInformacion.TabIndex = 2;
            btnInformacion.Text = "Informacion";
            toolTip1.SetToolTip(btnInformacion, "Informacion sobre personaje seleccionado.\r\n(Debe tener un personaje seleccionado para entrar)");
            btnInformacion.UseVisualStyleBackColor = false;
            btnInformacion.Click += btnInformacion_Click;
            // 
            // btnJugar
            // 
            btnJugar.BackColor = Color.Transparent;
            btnJugar.BackgroundImage = Properties.Resources.pngegg;
            btnJugar.BackgroundImageLayout = ImageLayout.Stretch;
            btnJugar.Enabled = false;
            btnJugar.FlatAppearance.BorderSize = 0;
            btnJugar.FlatStyle = FlatStyle.Flat;
            btnJugar.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnJugar.Location = new Point(6, 133);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(175, 46);
            btnJugar.TabIndex = 3;
            btnJugar.Text = "Jugar";
            toolTip1.SetToolTip(btnJugar, "Tirar dados con el personaje seleccionado.\r\n(Debe tener un personaje seleccionado para entrar)\r\n");
            btnJugar.UseVisualStyleBackColor = false;
            btnJugar.Click += btnJugar_Click;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.Transparent;
            btnExportar.BackgroundImage = Properties.Resources.pngegg;
            btnExportar.BackgroundImageLayout = ImageLayout.Stretch;
            btnExportar.Enabled = false;
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExportar.Location = new Point(6, 185);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(175, 46);
            btnExportar.TabIndex = 4;
            btnExportar.Text = "Exportar";
            toolTip1.SetToolTip(btnExportar, "Exportar personaje/s.\r\n(Debe tener un personaje seleccionado para entrar)\r\n");
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.Transparent;
            btnUsuarios.BackgroundImage = Properties.Resources.pngegg;
            btnUsuarios.BackgroundImageLayout = ImageLayout.Stretch;
            btnUsuarios.Enabled = false;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.Location = new Point(3, 652);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(175, 42);
            btnUsuarios.TabIndex = 5;
            btnUsuarios.Text = "Admin";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Visible = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(6, 626);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(82, 23);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario: ";
            // 
            // btnSeleccionarPersonaje
            // 
            btnSeleccionarPersonaje.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeleccionarPersonaje.Location = new Point(12, 466);
            btnSeleccionarPersonaje.Name = "btnSeleccionarPersonaje";
            btnSeleccionarPersonaje.Size = new Size(110, 29);
            btnSeleccionarPersonaje.TabIndex = 10;
            btnSeleccionarPersonaje.Text = "Seleccionar";
            btnSeleccionarPersonaje.UseVisualStyleBackColor = true;
            btnSeleccionarPersonaje.Click += btnSeleccionarPersonaje_Click;
            // 
            // lstPersonajes
            // 
            lstPersonajes.BackColor = Color.PapayaWhip;
            lstPersonajes.Font = new Font("Segoe Script", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lstPersonajes.FormattingEnabled = true;
            lstPersonajes.ItemHeight = 20;
            lstPersonajes.Location = new Point(12, 240);
            lstPersonajes.Name = "lstPersonajes";
            lstPersonajes.Size = new Size(158, 204);
            lstPersonajes.TabIndex = 11;
            // 
            // lblPersonajeSeleccionado
            // 
            lblPersonajeSeleccionado.AutoSize = true;
            lblPersonajeSeleccionado.Location = new Point(316, 375);
            lblPersonajeSeleccionado.Name = "lblPersonajeSeleccionado";
            lblPersonajeSeleccionado.Size = new Size(0, 20);
            lblPersonajeSeleccionado.TabIndex = 13;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.NavajoWhite;
            panelMenu.Controls.Add(btnImportarDB);
            panelMenu.Controls.Add(lblUsuario);
            panelMenu.Controls.Add(btnCrear);
            panelMenu.Controls.Add(btnSeleccionarPersonaje);
            panelMenu.Controls.Add(btnInformacion);
            panelMenu.Controls.Add(lstPersonajes);
            panelMenu.Controls.Add(btnJugar);
            panelMenu.Controls.Add(btnExportar);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(184, 706);
            panelMenu.TabIndex = 14;
            // 
            // btnImportarDB
            // 
            btnImportarDB.BackColor = Color.Transparent;
            btnImportarDB.BackgroundImage = Properties.Resources.pngegg;
            btnImportarDB.BackgroundImageLayout = ImageLayout.Stretch;
            btnImportarDB.FlatAppearance.BorderSize = 0;
            btnImportarDB.FlatStyle = FlatStyle.Flat;
            btnImportarDB.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnImportarDB.Location = new Point(6, 519);
            btnImportarDB.Name = "btnImportarDB";
            btnImportarDB.Size = new Size(175, 46);
            btnImportarDB.TabIndex = 12;
            btnImportarDB.Text = "Importar DB";
            btnImportarDB.UseVisualStyleBackColor = false;
            btnImportarDB.Click += btnImportar_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.BlanchedAlmond;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(184, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1143, 706);
            panelContenedor.TabIndex = 15;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 706);
            Controls.Add(panelContenedor);
            Controls.Add(panelMenu);
            Controls.Add(lblPersonajeSeleccionado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMainMenu";
            Text = "Emporio de Personajes";
            FormClosed += frmMainMenu_FormClosed;
            ((System.ComponentModel.ISupportInitialize)campañaBindingSource).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
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
        private Panel panelMenu;
        private Panel panelContenedor;
        private ToolTip toolTip1;
        private Button btnImportarDB;
    }
}
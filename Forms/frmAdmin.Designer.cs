namespace PrimerParcialLabo_Intento2
{
    partial class frmAdmin
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
            lblUsuarios = new Label();
            lstUsuarios = new ListView();
            Tipos = new ColumnHeader();
            Usuarios = new ColumnHeader();
            Contraseñas = new ColumnHeader();
            cboTipo = new ComboBox();
            txtUsername = new TextBox();
            txtContraseña = new TextBox();
            btnCrear = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            rdoOrdenAlfabetico = new RadioButton();
            rdoOrdenPorNivel = new RadioButton();
            lblOrdenamientoPersonajes = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.Location = new Point(31, 28);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(65, 20);
            lblUsuarios.TabIndex = 0;
            lblUsuarios.Text = "Usuarios";
            // 
            // lstUsuarios
            // 
            lstUsuarios.BackColor = Color.Tan;
            lstUsuarios.Columns.AddRange(new ColumnHeader[] { Tipos, Usuarios, Contraseñas });
            lstUsuarios.FullRowSelect = true;
            lstUsuarios.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstUsuarios.Location = new Point(31, 65);
            lstUsuarios.MultiSelect = false;
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.ShowGroups = false;
            lstUsuarios.Size = new Size(479, 306);
            lstUsuarios.TabIndex = 1;
            lstUsuarios.UseCompatibleStateImageBehavior = false;
            lstUsuarios.View = View.Details;
            lstUsuarios.SelectedIndexChanged += cambioIndiceLista;
            // 
            // Tipos
            // 
            Tipos.Text = "Tipo";
            Tipos.Width = 100;
            // 
            // Usuarios
            // 
            Usuarios.Text = "Usuario";
            Usuarios.Width = 200;
            // 
            // Contraseñas
            // 
            Contraseñas.Text = "Contraseña";
            Contraseñas.Width = 200;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Jugador", "SuperAdmin" });
            cboTipo.Location = new Point(568, 65);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(151, 28);
            cboTipo.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(568, 153);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(279, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(568, 250);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(279, 27);
            txtContraseña.TabIndex = 4;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(568, 310);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 5;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(670, 310);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(770, 310);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(645, 574);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 29);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar y Salir";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(770, 574);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(568, 42);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 11;
            label1.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(568, 130);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 12;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(568, 227);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 13;
            label3.Text = "Contraseña";
            // 
            // rdoOrdenAlfabetico
            // 
            rdoOrdenAlfabetico.AutoSize = true;
            rdoOrdenAlfabetico.Location = new Point(3, 3);
            rdoOrdenAlfabetico.Name = "rdoOrdenAlfabetico";
            rdoOrdenAlfabetico.Size = new Size(142, 24);
            rdoOrdenAlfabetico.TabIndex = 14;
            rdoOrdenAlfabetico.TabStop = true;
            rdoOrdenAlfabetico.Text = "Orden alfabetico";
            rdoOrdenAlfabetico.UseVisualStyleBackColor = true;
            rdoOrdenAlfabetico.CheckedChanged += rdoOrdenAlfabetico_CheckedChanged;
            // 
            // rdoOrdenPorNivel
            // 
            rdoOrdenPorNivel.AutoSize = true;
            rdoOrdenPorNivel.Location = new Point(151, 3);
            rdoOrdenPorNivel.Name = "rdoOrdenPorNivel";
            rdoOrdenPorNivel.Size = new Size(133, 24);
            rdoOrdenPorNivel.TabIndex = 15;
            rdoOrdenPorNivel.TabStop = true;
            rdoOrdenPorNivel.Text = "Orden por nivel";
            rdoOrdenPorNivel.UseVisualStyleBackColor = true;
            rdoOrdenPorNivel.CheckedChanged += rdoOrdenPorNivel_CheckedChanged;
            // 
            // lblOrdenamientoPersonajes
            // 
            lblOrdenamientoPersonajes.AutoSize = true;
            lblOrdenamientoPersonajes.Location = new Point(31, 395);
            lblOrdenamientoPersonajes.Name = "lblOrdenamientoPersonajes";
            lblOrdenamientoPersonajes.Size = new Size(201, 20);
            lblOrdenamientoPersonajes.TabIndex = 16;
            lblOrdenamientoPersonajes.Text = "Ordenamiento de personajes";
            // 
            // panel1
            // 
            panel1.Controls.Add(rdoOrdenAlfabetico);
            panel1.Controls.Add(rdoOrdenPorNivel);
            panel1.Location = new Point(31, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 38);
            panel1.TabIndex = 17;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(919, 395);
            Controls.Add(panel1);
            Controls.Add(lblOrdenamientoPersonajes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnCrear);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsername);
            Controls.Add(cboTipo);
            Controls.Add(lstUsuarios);
            Controls.Add(lblUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdmin";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuarios;
        private ListView lstUsuarios;
        private ColumnHeader Tipos;
        private ColumnHeader Usuarios;
        private ColumnHeader Contraseñas;
        private ComboBox cboTipo;
        private TextBox txtUsername;
        private TextBox txtContraseña;
        private Button btnCrear;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnSalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton rdoOrdenAlfabetico;
        private RadioButton rdoOrdenPorNivel;
        private Label lblOrdenamientoPersonajes;
        private Panel panel1;
    }
}
namespace PrimerParcialLabo_Intento2
{
    partial class frmUsuarios
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
            SuspendLayout();
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.Location = new Point(31, 28);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(50, 20);
            lblUsuarios.TabIndex = 0;
            lblUsuarios.Text = "label1";
            // 
            // lstUsuarios
            // 
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
            btnCrear.Location = new Point(568, 342);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 5;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(695, 342);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(813, 342);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnCrear);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsername);
            Controls.Add(cboTipo);
            Controls.Add(lstUsuarios);
            Controls.Add(lblUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
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
    }
}
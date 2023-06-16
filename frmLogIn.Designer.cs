namespace PrimerParcialLabo_Intento2
{
    partial class frmLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_Usuario = new TextBox();
            txt_Contraseña = new TextBox();
            button1 = new Button();
            label1 = new Label();
            lblIncorrecto = new Label();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // txt_Usuario
            // 
            txt_Usuario.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Usuario.Location = new Point(338, 173);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.PlaceholderText = "Usuario";
            txt_Usuario.Size = new Size(125, 31);
            txt_Usuario.TabIndex = 0;
            // 
            // txt_Contraseña
            // 
            txt_Contraseña.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Contraseña.Location = new Point(338, 231);
            txt_Contraseña.Name = "txt_Contraseña";
            txt_Contraseña.PasswordChar = '*';
            txt_Contraseña.PlaceholderText = "Contraseña";
            txt_Contraseña.Size = new Size(125, 31);
            txt_Contraseña.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.pngegg;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(337, 309);
            button1.Name = "button1";
            button1.Size = new Size(116, 78);
            button1.TabIndex = 2;
            button1.Text = "Iniciar Sesion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Script", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(231, 106);
            label1.Name = "label1";
            label1.Size = new Size(302, 58);
            label1.TabIndex = 3;
            label1.Text = "Iniciar Sesion";
            // 
            // lblIncorrecto
            // 
            lblIncorrecto.Anchor = AnchorStyles.None;
            lblIncorrecto.AutoSize = true;
            lblIncorrecto.BackColor = Color.Transparent;
            lblIncorrecto.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblIncorrecto.ForeColor = Color.Red;
            lblIncorrecto.Location = new Point(261, 283);
            lblIncorrecto.Name = "lblIncorrecto";
            lblIncorrecto.Size = new Size(278, 23);
            lblIncorrecto.TabIndex = 4;
            lblIncorrecto.Text = "Usuario o Contraseña incorrectos.";
            lblIncorrecto.TextAlign = ContentAlignment.MiddleCenter;
            lblIncorrecto.Visible = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe Script", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTitulo.Location = new Point(19, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(762, 99);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Emporio de Personajes";
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.wooden_floor_background2;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(lblIncorrecto);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txt_Contraseña);
            Controls.Add(txt_Usuario);
            Name = "frmLogIn";
            Text = "Emporio de Personajes";
            FormClosed += frmLogIn_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Usuario;
        private TextBox txt_Contraseña;
        private Button button1;
        private Label label1;
        private Label lblIncorrecto;
        private Label lblTitulo;
    }
}
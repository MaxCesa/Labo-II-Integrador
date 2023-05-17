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
            SuspendLayout();
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new Point(338, 173);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.PlaceholderText = "Usuario";
            txt_Usuario.Size = new Size(125, 27);
            txt_Usuario.TabIndex = 0;
            // 
            // txt_Contraseña
            // 
            txt_Contraseña.Location = new Point(338, 231);
            txt_Contraseña.Name = "txt_Contraseña";
            txt_Contraseña.PasswordChar = '*';
            txt_Contraseña.PlaceholderText = "Contraseña";
            txt_Contraseña.Size = new Size(125, 27);
            txt_Contraseña.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(354, 337);
            button1.Name = "button1";
            button1.Size = new Size(94, 66);
            button1.TabIndex = 2;
            button1.Text = "Iniciar Sesion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 40.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(128, 64);
            label1.Name = "label1";
            label1.Size = new Size(545, 106);
            label1.TabIndex = 3;
            label1.Text = "Iniciar Sesion";
            // 
            // lblIncorrecto
            // 
            lblIncorrecto.AutoSize = true;
            lblIncorrecto.ForeColor = Color.Red;
            lblIncorrecto.Location = new Point(285, 284);
            lblIncorrecto.Name = "lblIncorrecto";
            lblIncorrecto.Size = new Size(230, 20);
            lblIncorrecto.TabIndex = 4;
            lblIncorrecto.Text = "Usuario o Contraseña incorrectos.";
            lblIncorrecto.Visible = false;
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIncorrecto);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txt_Contraseña);
            Controls.Add(txt_Usuario);
            Name = "frmLogIn";
            Text = "Emporio de Personajes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Usuario;
        private TextBox txt_Contraseña;
        private Button button1;
        private Label label1;
        private Label lblIncorrecto;
    }
}
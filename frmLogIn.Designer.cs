﻿namespace PrimerParcialLabo_Intento2
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
            txt_Contraseña.Location = new Point(338, 233);
            txt_Contraseña.Name = "txt_Contraseña";
            txt_Contraseña.PasswordChar = '*';
            txt_Contraseña.PlaceholderText = "Contraseña";
            txt_Contraseña.Size = new Size(125, 27);
            txt_Contraseña.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(351, 292);
            button1.Name = "button1";
            button1.Size = new Size(94, 66);
            button1.TabIndex = 2;
            button1.Text = "Iniciar Sesion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(197, 46);
            label1.Name = "label1";
            label1.Size = new Size(424, 89);
            label1.TabIndex = 3;
            label1.Text = "Iniciar Sesion";
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txt_Contraseña);
            Controls.Add(txt_Usuario);
            Cursor = Cursors.Default;
            Name = "frmLogIn";
            Text = "Campaign Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Usuario;
        private TextBox txt_Contraseña;
        private Button button1;
        private Label label1;
    }
}
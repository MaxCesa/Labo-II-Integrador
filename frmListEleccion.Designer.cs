namespace PrimerParcialLabo_Intento2
{
    partial class frmListEleccion
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
            lblDescripcion = new Label();
            btnAceptar = new Button();
            btnVolver = new Button();
            chklOpciones = new CheckedListBox();
            lblWarning = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.Left;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(3, 24);
            lblDescripcion.MaximumSize = new Size(293, 75);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(61, 23);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.Text = "label1";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Transparent;
            btnAceptar.BackgroundImage = Properties.Resources.pngegg;
            btnAceptar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(57, 304);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(106, 42);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackgroundImage = Properties.Resources.pngegg;
            btnVolver.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(244, 304);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(106, 42);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // chklOpciones
            // 
            chklOpciones.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chklOpciones.FormattingEnabled = true;
            chklOpciones.Location = new Point(57, 96);
            chklOpciones.Name = "chklOpciones";
            chklOpciones.Size = new Size(293, 186);
            chklOpciones.TabIndex = 4;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(28, 356);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(50, 20);
            lblWarning.TabIndex = 5;
            lblWarning.Text = "label1";
            lblWarning.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDescripcion);
            panel1.Location = new Point(57, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 75);
            panel1.TabIndex = 6;
            // 
            // frmListEleccion
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(410, 389);
            Controls.Add(panel1);
            Controls.Add(lblWarning);
            Controls.Add(chklOpciones);
            Controls.Add(btnVolver);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmListEleccion";
            Text = "Eleccion...";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescripcion;
        private Button btnAceptar;
        private Button btnVolver;
        private CheckedListBox chklOpciones;
        private Label lblWarning;
        private Panel panel1;
    }
}
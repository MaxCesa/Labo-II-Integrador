namespace PrimerParcialLabo_Intento2
{
    partial class frmComboEleccion
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
            cboOpciones = new ComboBox();
            btnAceptar = new Button();
            btnVolver = new Button();
            panel1 = new Panel();
            lblDescripcion = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cboOpciones
            // 
            cboOpciones.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboOpciones.FormattingEnabled = true;
            cboOpciones.Location = new Point(57, 102);
            cboOpciones.Name = "cboOpciones";
            cboOpciones.Size = new Size(293, 31);
            cboOpciones.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.BackgroundImage = Properties.Resources.pngegg;
            btnAceptar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(57, 155);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 38);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackgroundImage = Properties.Resources.pngegg;
            btnVolver.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(256, 155);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 38);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDescripcion);
            panel1.Location = new Point(57, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 75);
            panel1.TabIndex = 7;
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
            // frmComboEleccion
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(410, 242);
            Controls.Add(panel1);
            Controls.Add(btnVolver);
            Controls.Add(btnAceptar);
            Controls.Add(cboOpciones);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmComboEleccion";
            Text = "Eleccion...";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cboOpciones;
        private Button btnAceptar;
        private Button btnVolver;
        private Panel panel1;
        private Label lblDescripcion;
    }
}
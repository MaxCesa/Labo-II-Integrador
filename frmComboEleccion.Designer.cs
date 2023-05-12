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
            lblDescripcion = new Label();
            cboOpciones = new ComboBox();
            btnAceptar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(57, 39);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(50, 20);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.Text = "label1";
            // 
            // cboOpciones
            // 
            cboOpciones.FormattingEnabled = true;
            cboOpciones.Location = new Point(57, 102);
            cboOpciones.Name = "cboOpciones";
            cboOpciones.Size = new Size(293, 28);
            cboOpciones.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(57, 164);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(256, 164);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmComboEleccion
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 242);
            Controls.Add(btnVolver);
            Controls.Add(btnAceptar);
            Controls.Add(cboOpciones);
            Controls.Add(lblDescripcion);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmComboEleccion";
            Text = "Eleccion...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescripcion;
        private ComboBox cboOpciones;
        private Button btnAceptar;
        private Button btnVolver;
    }
}
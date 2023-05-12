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
            // btnAceptar
            // 
            btnAceptar.Location = new Point(57, 317);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(256, 317);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // chklOpciones
            // 
            chklOpciones.FormattingEnabled = true;
            chklOpciones.Location = new Point(57, 96);
            chklOpciones.Name = "chklOpciones";
            chklOpciones.Size = new Size(293, 202);
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
            // frmListEleccion
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 389);
            Controls.Add(lblWarning);
            Controls.Add(chklOpciones);
            Controls.Add(btnVolver);
            Controls.Add(btnAceptar);
            Controls.Add(lblDescripcion);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmListEleccion";
            Text = "Eleccion...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescripcion;
        private Button btnAceptar;
        private Button btnVolver;
        private CheckedListBox chklOpciones;
        private Label lblWarning;
    }
}
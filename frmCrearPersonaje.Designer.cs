namespace PrimerParcialLabo_Intento2
{
    partial class frmCrearPersonaje
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
            txtNombre = new TextBox();
            lblNombre = new Label();
            cboClases = new ComboBox();
            numNivel = new NumericUpDown();
            cboRazas = new ComboBox();
            lblRaza = new Label();
            btnContinuar = new Button();
            btnContinuar2 = new Button();
            btnCrear = new Button();
            btnCancelar = new Button();
            lblClase = new Label();
            lblNivel = new Label();
            ((System.ComponentModel.ISupportInitialize)numNivel).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Silver;
            txtNombre.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(38, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 31);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(38, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(72, 23);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // cboClases
            // 
            cboClases.BackColor = Color.Silver;
            cboClases.Enabled = false;
            cboClases.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboClases.FormattingEnabled = true;
            cboClases.Location = new Point(38, 154);
            cboClases.Name = "cboClases";
            cboClases.Size = new Size(151, 31);
            cboClases.TabIndex = 2;
            // 
            // numNivel
            // 
            numNivel.BackColor = Color.Silver;
            numNivel.Enabled = false;
            numNivel.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numNivel.Location = new Point(214, 154);
            numNivel.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numNivel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numNivel.Name = "numNivel";
            numNivel.Size = new Size(52, 31);
            numNivel.TabIndex = 3;
            numNivel.TextAlign = HorizontalAlignment.Center;
            numNivel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboRazas
            // 
            cboRazas.BackColor = Color.Silver;
            cboRazas.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboRazas.FormattingEnabled = true;
            cboRazas.Location = new Point(253, 52);
            cboRazas.Name = "cboRazas";
            cboRazas.Size = new Size(151, 31);
            cboRazas.TabIndex = 4;
            // 
            // lblRaza
            // 
            lblRaza.AutoSize = true;
            lblRaza.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRaza.Location = new Point(253, 29);
            lblRaza.Name = "lblRaza";
            lblRaza.Size = new Size(50, 23);
            lblRaza.TabIndex = 5;
            lblRaza.Text = "Raza";
            // 
            // btnContinuar
            // 
            btnContinuar.BackgroundImage = Properties.Resources.pngegg;
            btnContinuar.BackgroundImageLayout = ImageLayout.Stretch;
            btnContinuar.FlatAppearance.BorderSize = 0;
            btnContinuar.FlatStyle = FlatStyle.Flat;
            btnContinuar.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnContinuar.Location = new Point(431, 42);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(145, 49);
            btnContinuar.TabIndex = 6;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // btnContinuar2
            // 
            btnContinuar2.BackgroundImage = Properties.Resources.pngegg;
            btnContinuar2.BackgroundImageLayout = ImageLayout.Stretch;
            btnContinuar2.Enabled = false;
            btnContinuar2.FlatAppearance.BorderSize = 0;
            btnContinuar2.FlatStyle = FlatStyle.Flat;
            btnContinuar2.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnContinuar2.Location = new Point(291, 144);
            btnContinuar2.Name = "btnContinuar2";
            btnContinuar2.Size = new Size(145, 49);
            btnContinuar2.TabIndex = 7;
            btnContinuar2.Text = "Continuar";
            btnContinuar2.UseVisualStyleBackColor = true;
            btnContinuar2.Click += btnContinuar2_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackgroundImage = Properties.Resources.pngegg;
            btnCrear.BackgroundImageLayout = ImageLayout.Stretch;
            btnCrear.Enabled = false;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrear.Location = new Point(514, 404);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(107, 39);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.BackgroundImage = Properties.Resources.pngegg;
            btnCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(643, 404);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 39);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblClase
            // 
            lblClase.AutoSize = true;
            lblClase.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblClase.Location = new Point(38, 131);
            lblClase.Name = "lblClase";
            lblClase.Size = new Size(52, 23);
            lblClase.TabIndex = 10;
            lblClase.Text = "Clase";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNivel.Location = new Point(214, 131);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(54, 23);
            lblNivel.TabIndex = 11;
            lblNivel.Text = "Nivel";
            // 
            // frmCrearPersonaje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNivel);
            Controls.Add(lblClase);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrear);
            Controls.Add(btnContinuar2);
            Controls.Add(btnContinuar);
            Controls.Add(lblRaza);
            Controls.Add(cboRazas);
            Controls.Add(numNivel);
            Controls.Add(cboClases);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCrearPersonaje";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numNivel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private ComboBox cboClases;
        private NumericUpDown numNivel;
        private ComboBox cboRazas;
        private Label lblRaza;
        private Button btnContinuar;
        private Button btnContinuar2;
        private Button btnCrear;
        private Button btnCancelar;
        private Label lblClase;
        private Label lblNivel;
    }
}
using DnD;

namespace PrimerParcialLabo_Intento2
{
    partial class frmNuevoItem
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
            components = new System.ComponentModel.Container();
            cboTipo = new ComboBox();
            lblIntro = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            numAC = new NumericUpDown();
            lblAC = new Label();
            lblTipo = new Label();
            cboTipoEquipo = new ComboBox();
            lblDaño = new Label();
            numCantidadDados = new NumericUpDown();
            cboCaras = new ComboBox();
            dadoBindingSource = new BindingSource(components);
            lblPropiedades = new Label();
            txtPropiedades = new TextBox();
            label6 = new Label();
            txtDescripcion = new RichTextBox();
            btnCrear = new Button();
            btnCancelar = new Button();
            lblPeso = new Label();
            numPeso = new NumericUpDown();
            lblPrecio = new Label();
            numPrecio = new NumericUpDown();
            label3 = new Label();
            lblOro = new Label();
            ((System.ComponentModel.ISupportInitialize)numAC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dadoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            SuspendLayout();
            // 
            // cboTipo
            // 
            cboTipo.Font = new Font("Marcellus SC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(43, 79);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(240, 27);
            cboTipo.TabIndex = 0;
            cboTipo.TextChanged += nuevoTipo;
            // 
            // lblIntro
            // 
            lblIntro.AutoSize = true;
            lblIntro.BackColor = Color.Transparent;
            lblIntro.Font = new Font("Marcellus SC", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblIntro.ForeColor = Color.Gold;
            lblIntro.Location = new Point(43, 48);
            lblIntro.Name = "lblIntro";
            lblIntro.Size = new Size(240, 28);
            lblIntro.TabIndex = 1;
            lblIntro.Text = "¿Que vamos a forjar?";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Marcellus SC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(43, 149);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(216, 26);
            txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Marcellus SC", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Gold;
            lblNombre.Location = new Point(43, 118);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(95, 28);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // numAC
            // 
            numAC.Font = new Font("Marcellus SC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numAC.Location = new Point(482, 150);
            numAC.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numAC.Name = "numAC";
            numAC.Size = new Size(54, 26);
            numAC.TabIndex = 4;
            numAC.TextAlign = HorizontalAlignment.Center;
            numAC.Visible = false;
            // 
            // lblAC
            // 
            lblAC.AutoSize = true;
            lblAC.BackColor = Color.Transparent;
            lblAC.Font = new Font("Marcellus SC", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblAC.ForeColor = Color.Gold;
            lblAC.Location = new Point(482, 118);
            lblAC.Name = "lblAC";
            lblAC.Size = new Size(44, 28);
            lblAC.TabIndex = 5;
            lblAC.Text = "AC";
            lblAC.Visible = false;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.Transparent;
            lblTipo.Font = new Font("Marcellus SC", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.ForeColor = Color.Gold;
            lblTipo.Location = new Point(295, 118);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(56, 28);
            lblTipo.TabIndex = 6;
            lblTipo.Text = "Tipo";
            lblTipo.Visible = false;
            // 
            // cboTipoEquipo
            // 
            cboTipoEquipo.Font = new Font("Marcellus SC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboTipoEquipo.FormattingEnabled = true;
            cboTipoEquipo.Location = new Point(295, 149);
            cboTipoEquipo.Name = "cboTipoEquipo";
            cboTipoEquipo.Size = new Size(151, 27);
            cboTipoEquipo.TabIndex = 7;
            cboTipoEquipo.Visible = false;
            // 
            // lblDaño
            // 
            lblDaño.AutoSize = true;
            lblDaño.BackColor = Color.Transparent;
            lblDaño.Font = new Font("Marcellus SC", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDaño.ForeColor = Color.Gold;
            lblDaño.Location = new Point(482, 190);
            lblDaño.Name = "lblDaño";
            lblDaño.Size = new Size(70, 28);
            lblDaño.TabIndex = 8;
            lblDaño.Text = "Daño";
            lblDaño.Visible = false;
            // 
            // numCantidadDados
            // 
            numCantidadDados.Font = new Font("Marcellus SC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numCantidadDados.Location = new Point(482, 221);
            numCantidadDados.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numCantidadDados.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidadDados.Name = "numCantidadDados";
            numCantidadDados.Size = new Size(40, 26);
            numCantidadDados.TabIndex = 9;
            numCantidadDados.TextAlign = HorizontalAlignment.Center;
            numCantidadDados.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidadDados.Visible = false;
            // 
            // cboCaras
            // 
            cboCaras.Font = new Font("Marcellus SC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboCaras.FormattingEnabled = true;
            cboCaras.Location = new Point(534, 221);
            cboCaras.Name = "cboCaras";
            cboCaras.Size = new Size(72, 27);
            cboCaras.TabIndex = 11;
            cboCaras.Visible = false;
            // 
            // dadoBindingSource
            // 
            dadoBindingSource.DataSource = typeof(Dado);
            // 
            // lblPropiedades
            // 
            lblPropiedades.AutoSize = true;
            lblPropiedades.BackColor = Color.Transparent;
            lblPropiedades.Font = new Font("Marcellus SC", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPropiedades.ForeColor = Color.Gold;
            lblPropiedades.Location = new Point(43, 190);
            lblPropiedades.Name = "lblPropiedades";
            lblPropiedades.Size = new Size(136, 28);
            lblPropiedades.TabIndex = 12;
            lblPropiedades.Text = "Propiedades";
            // 
            // txtPropiedades
            // 
            txtPropiedades.Font = new Font("Marcellus SC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPropiedades.Location = new Point(43, 223);
            txtPropiedades.Name = "txtPropiedades";
            txtPropiedades.PlaceholderText = "Escriba las propiedades separadas por comas";
            txtPropiedades.Size = new Size(403, 26);
            txtPropiedades.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Marcellus SC", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(43, 369);
            label6.Name = "label6";
            label6.Size = new Size(133, 28);
            label6.TabIndex = 14;
            label6.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.DimGray;
            txtDescripcion.Font = new Font("Marcellus SC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.White;
            txtDescripcion.Location = new Point(43, 400);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(585, 167);
            txtDescripcion.TabIndex = 15;
            txtDescripcion.Text = "";
            // 
            // btnCrear
            // 
            btnCrear.Font = new Font("Marcellus SC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrear.Location = new Point(412, 592);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 16;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Marcellus SC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(534, 592);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.BackColor = Color.Transparent;
            lblPeso.Font = new Font("Marcellus SC", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPeso.ForeColor = Color.Gold;
            lblPeso.Location = new Point(43, 272);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(58, 28);
            lblPeso.TabIndex = 18;
            lblPeso.Text = "Peso";
            // 
            // numPeso
            // 
            numPeso.DecimalPlaces = 2;
            numPeso.Font = new Font("Marcellus SC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numPeso.Location = new Point(43, 303);
            numPeso.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPeso.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(113, 26);
            numPeso.TabIndex = 19;
            numPeso.TextAlign = HorizontalAlignment.Center;
            numPeso.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Marcellus SC", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.ForeColor = Color.Gold;
            lblPrecio.Location = new Point(271, 272);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(78, 28);
            lblPrecio.TabIndex = 20;
            lblPrecio.Text = "Precio";
            // 
            // numPrecio
            // 
            numPrecio.DecimalPlaces = 2;
            numPrecio.Font = new Font("Marcellus SC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numPrecio.Location = new Point(271, 303);
            numPrecio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrecio.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(113, 26);
            numPrecio.TabIndex = 21;
            numPrecio.TextAlign = HorizontalAlignment.Center;
            numPrecio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Marcellus SC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(162, 304);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 22;
            label3.Text = "pds.";
            // 
            // lblOro
            // 
            lblOro.AutoSize = true;
            lblOro.BackColor = Color.Transparent;
            lblOro.Font = new Font("Marcellus SC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOro.Location = new Point(390, 304);
            lblOro.Name = "lblOro";
            lblOro.Size = new Size(51, 25);
            lblOro.TabIndex = 23;
            lblOro.Text = "Oro";
            // 
            // frmNuevoItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = Properties.Resources.pngegg__1_2;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(640, 633);
            Controls.Add(lblOro);
            Controls.Add(label3);
            Controls.Add(numPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(numPeso);
            Controls.Add(lblPeso);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrear);
            Controls.Add(txtDescripcion);
            Controls.Add(label6);
            Controls.Add(txtPropiedades);
            Controls.Add(lblPropiedades);
            Controls.Add(cboCaras);
            Controls.Add(numCantidadDados);
            Controls.Add(lblDaño);
            Controls.Add(cboTipoEquipo);
            Controls.Add(lblTipo);
            Controls.Add(lblAC);
            Controls.Add(numAC);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblIntro);
            Controls.Add(cboTipo);
            DoubleBuffered = true;
            Name = "frmNuevoItem";
            Text = "Forjar item";
            ((System.ComponentModel.ISupportInitialize)numAC).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dadoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboTipo;
        private Label lblIntro;
        private TextBox txtNombre;
        private Label lblNombre;
        private NumericUpDown numAC;
        private Label lblAC;
        private Label lblTipo;
        private ComboBox cboTipoEquipo;
        private Label lblDaño;
        private NumericUpDown numCantidadDados;
        private ComboBox cboCaras;
        private BindingSource dadoBindingSource;
        private Label lblPropiedades;
        private TextBox txtPropiedades;
        private Label label6;
        private RichTextBox txtDescripcion;
        private Button btnCrear;
        private Button btnCancelar;
        private Label lblPeso;
        private NumericUpDown numPeso;
        private Label lblPrecio;
        private NumericUpDown numPrecio;
        private Label label3;
        private Label lblOro;
    }
}
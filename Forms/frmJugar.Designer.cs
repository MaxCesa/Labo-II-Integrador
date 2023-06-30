namespace PrimerParcialLabo_Intento2
{
    partial class frmJugar
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
            cboAtributos = new ComboBox();
            btnTiradaAtributos = new Button();
            cboHabilidades = new ComboBox();
            btnTiradaHabilidades = new Button();
            rtbConsola = new RichTextBox();
            lblAtributos = new Label();
            lblHabilidades = new Label();
            toolTip1 = new ToolTip(components);
            btnSubirDeNivel = new Button();
            SuspendLayout();
            // 
            // cboAtributos
            // 
            cboAtributos.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboAtributos.FormattingEnabled = true;
            cboAtributos.Location = new Point(68, 62);
            cboAtributos.Margin = new Padding(4, 3, 4, 3);
            cboAtributos.Name = "cboAtributos";
            cboAtributos.Size = new Size(188, 31);
            cboAtributos.TabIndex = 0;
            // 
            // btnTiradaAtributos
            // 
            btnTiradaAtributos.BackgroundImage = Properties.Resources.pngegg;
            btnTiradaAtributos.BackgroundImageLayout = ImageLayout.Stretch;
            btnTiradaAtributos.FlatAppearance.BorderSize = 0;
            btnTiradaAtributos.FlatStyle = FlatStyle.Flat;
            btnTiradaAtributos.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTiradaAtributos.Location = new Point(305, 62);
            btnTiradaAtributos.Margin = new Padding(4, 3, 4, 3);
            btnTiradaAtributos.Name = "btnTiradaAtributos";
            btnTiradaAtributos.Size = new Size(95, 33);
            btnTiradaAtributos.TabIndex = 1;
            btnTiradaAtributos.Text = "Tirar...";
            toolTip1.SetToolTip(btnTiradaAtributos, "Tirada de un atributo:\r\n1d20 + modificador de atributo");
            btnTiradaAtributos.UseVisualStyleBackColor = true;
            btnTiradaAtributos.Click += btnTiradaAtributos_Click;
            // 
            // cboHabilidades
            // 
            cboHabilidades.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboHabilidades.FormattingEnabled = true;
            cboHabilidades.Location = new Point(68, 162);
            cboHabilidades.Margin = new Padding(4, 3, 4, 3);
            cboHabilidades.Name = "cboHabilidades";
            cboHabilidades.Size = new Size(188, 31);
            cboHabilidades.TabIndex = 2;
            // 
            // btnTiradaHabilidades
            // 
            btnTiradaHabilidades.BackgroundImage = Properties.Resources.pngegg;
            btnTiradaHabilidades.BackgroundImageLayout = ImageLayout.Stretch;
            btnTiradaHabilidades.FlatAppearance.BorderSize = 0;
            btnTiradaHabilidades.FlatStyle = FlatStyle.Flat;
            btnTiradaHabilidades.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTiradaHabilidades.Location = new Point(305, 161);
            btnTiradaHabilidades.Margin = new Padding(4, 3, 4, 3);
            btnTiradaHabilidades.Name = "btnTiradaHabilidades";
            btnTiradaHabilidades.Size = new Size(95, 33);
            btnTiradaHabilidades.TabIndex = 3;
            btnTiradaHabilidades.Text = "Tirar...";
            toolTip1.SetToolTip(btnTiradaHabilidades, "Tirada de una habilidad:\r\n1d20 + modificador de habilidad\r\nModificador de habilidad = \r\nModificador de atributos + proeficiencia (si se es proeficiente)");
            btnTiradaHabilidades.UseVisualStyleBackColor = true;
            btnTiradaHabilidades.Click += btnTiradaHabilidades_Click;
            // 
            // rtbConsola
            // 
            rtbConsola.BackColor = Color.BurlyWood;
            rtbConsola.Location = new Point(499, 56);
            rtbConsola.Margin = new Padding(4, 3, 4, 3);
            rtbConsola.Name = "rtbConsola";
            rtbConsola.ReadOnly = true;
            rtbConsola.Size = new Size(470, 421);
            rtbConsola.TabIndex = 7;
            rtbConsola.Text = "";
            // 
            // lblAtributos
            // 
            lblAtributos.AutoSize = true;
            lblAtributos.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtributos.Location = new Point(68, 36);
            lblAtributos.Margin = new Padding(4, 0, 4, 0);
            lblAtributos.Name = "lblAtributos";
            lblAtributos.Size = new Size(87, 23);
            lblAtributos.TabIndex = 8;
            lblAtributos.Text = "Atributos";
            // 
            // lblHabilidades
            // 
            lblHabilidades.AutoSize = true;
            lblHabilidades.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblHabilidades.Location = new Point(68, 136);
            lblHabilidades.Margin = new Padding(4, 0, 4, 0);
            lblHabilidades.Name = "lblHabilidades";
            lblHabilidades.Size = new Size(107, 23);
            lblHabilidades.TabIndex = 9;
            lblHabilidades.Text = "Habilidades";
            // 
            // btnSubirDeNivel
            // 
            btnSubirDeNivel.BackgroundImage = Properties.Resources.pngegg;
            btnSubirDeNivel.BackgroundImageLayout = ImageLayout.Stretch;
            btnSubirDeNivel.FlatAppearance.BorderSize = 0;
            btnSubirDeNivel.FlatStyle = FlatStyle.Flat;
            btnSubirDeNivel.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubirDeNivel.Location = new Point(68, 439);
            btnSubirDeNivel.Margin = new Padding(4, 3, 4, 3);
            btnSubirDeNivel.Name = "btnSubirDeNivel";
            btnSubirDeNivel.Size = new Size(168, 38);
            btnSubirDeNivel.TabIndex = 10;
            btnSubirDeNivel.Text = "Subir de nivel";
            btnSubirDeNivel.UseVisualStyleBackColor = true;
            btnSubirDeNivel.Click += btnSubirDeNivel_Click;
            // 
            // frmJugar
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(1000, 518);
            Controls.Add(btnSubirDeNivel);
            Controls.Add(lblHabilidades);
            Controls.Add(lblAtributos);
            Controls.Add(rtbConsola);
            Controls.Add(btnTiradaHabilidades);
            Controls.Add(cboHabilidades);
            Controls.Add(btnTiradaAtributos);
            Controls.Add(cboAtributos);
            Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmJugar";
            Text = "Jugar";
            Load += frmJugar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboAtributos;
        private Button btnTiradaAtributos;
        private ComboBox cboHabilidades;
        private Button btnTiradaHabilidades;
        private RichTextBox rtbConsola;
        private Label lblAtributos;
        private Label lblHabilidades;
        private ToolTip toolTip1;
        private Button btnSubirDeNivel;
    }
}
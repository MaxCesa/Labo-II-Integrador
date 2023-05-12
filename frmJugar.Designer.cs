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
            cboAtributos = new ComboBox();
            btnTiradaAtributos = new Button();
            cboHabilidades = new ComboBox();
            btnTiradaHabilidades = new Button();
            cboAtaques = new ComboBox();
            btnCheckHit = new Button();
            btnDaño = new Button();
            rtbConsola = new RichTextBox();
            lblAtributos = new Label();
            lblHabilidades = new Label();
            lblAtaques = new Label();
            SuspendLayout();
            // 
            // cboAtributos
            // 
            cboAtributos.FormattingEnabled = true;
            cboAtributos.Location = new Point(54, 54);
            cboAtributos.Name = "cboAtributos";
            cboAtributos.Size = new Size(151, 28);
            cboAtributos.TabIndex = 0;
            // 
            // btnTiradaAtributos
            // 
            btnTiradaAtributos.Location = new Point(244, 54);
            btnTiradaAtributos.Name = "btnTiradaAtributos";
            btnTiradaAtributos.Size = new Size(94, 29);
            btnTiradaAtributos.TabIndex = 1;
            btnTiradaAtributos.Text = "Tirar...";
            btnTiradaAtributos.UseVisualStyleBackColor = true;
            btnTiradaAtributos.Click += btnTiradaAtributos_Click;
            // 
            // cboHabilidades
            // 
            cboHabilidades.FormattingEnabled = true;
            cboHabilidades.Location = new Point(54, 141);
            cboHabilidades.Name = "cboHabilidades";
            cboHabilidades.Size = new Size(151, 28);
            cboHabilidades.TabIndex = 2;
            // 
            // btnTiradaHabilidades
            // 
            btnTiradaHabilidades.Location = new Point(244, 140);
            btnTiradaHabilidades.Name = "btnTiradaHabilidades";
            btnTiradaHabilidades.Size = new Size(94, 29);
            btnTiradaHabilidades.TabIndex = 3;
            btnTiradaHabilidades.Text = "Tirar...";
            btnTiradaHabilidades.UseVisualStyleBackColor = true;
            // 
            // cboAtaques
            // 
            cboAtaques.FormattingEnabled = true;
            cboAtaques.Location = new Point(54, 216);
            cboAtaques.Name = "cboAtaques";
            cboAtaques.Size = new Size(151, 28);
            cboAtaques.TabIndex = 4;
            // 
            // btnCheckHit
            // 
            btnCheckHit.Location = new Point(244, 216);
            btnCheckHit.Name = "btnCheckHit";
            btnCheckHit.Size = new Size(94, 29);
            btnCheckHit.TabIndex = 5;
            btnCheckHit.Text = "Check";
            btnCheckHit.UseVisualStyleBackColor = true;
            // 
            // btnDaño
            // 
            btnDaño.Location = new Point(244, 263);
            btnDaño.Name = "btnDaño";
            btnDaño.Size = new Size(94, 29);
            btnDaño.TabIndex = 6;
            btnDaño.Text = "Daño";
            btnDaño.UseVisualStyleBackColor = true;
            // 
            // rtbConsola
            // 
            rtbConsola.Location = new Point(399, 49);
            rtbConsola.Name = "rtbConsola";
            rtbConsola.ReadOnly = true;
            rtbConsola.Size = new Size(377, 367);
            rtbConsola.TabIndex = 7;
            rtbConsola.Text = "";
            // 
            // lblAtributos
            // 
            lblAtributos.AutoSize = true;
            lblAtributos.Location = new Point(54, 31);
            lblAtributos.Name = "lblAtributos";
            lblAtributos.Size = new Size(70, 20);
            lblAtributos.TabIndex = 8;
            lblAtributos.Text = "Atributos";
            // 
            // lblHabilidades
            // 
            lblHabilidades.AutoSize = true;
            lblHabilidades.Location = new Point(54, 118);
            lblHabilidades.Name = "lblHabilidades";
            lblHabilidades.Size = new Size(89, 20);
            lblHabilidades.TabIndex = 9;
            lblHabilidades.Text = "Habilidades";
            // 
            // lblAtaques
            // 
            lblAtaques.AutoSize = true;
            lblAtaques.Location = new Point(54, 193);
            lblAtaques.Name = "lblAtaques";
            lblAtaques.Size = new Size(63, 20);
            lblAtaques.TabIndex = 10;
            lblAtaques.Text = "Ataques";
            // 
            // frmJugar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAtaques);
            Controls.Add(lblHabilidades);
            Controls.Add(lblAtributos);
            Controls.Add(rtbConsola);
            Controls.Add(btnDaño);
            Controls.Add(btnCheckHit);
            Controls.Add(cboAtaques);
            Controls.Add(btnTiradaHabilidades);
            Controls.Add(cboHabilidades);
            Controls.Add(btnTiradaAtributos);
            Controls.Add(cboAtributos);
            HelpButton = true;
            Name = "frmJugar";
            Text = "Jugar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboAtributos;
        private Button btnTiradaAtributos;
        private ComboBox cboHabilidades;
        private Button btnTiradaHabilidades;
        private ComboBox cboAtaques;
        private Button btnCheckHit;
        private Button btnDaño;
        private RichTextBox rtbConsola;
        private Label lblAtributos;
        private Label lblHabilidades;
        private Label lblAtaques;
    }
}
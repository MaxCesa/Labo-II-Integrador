namespace PrimerParcialLabo_Intento2
{
    partial class frmExportar
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
            btnGuardar = new Button();
            btnExportar = new Button();
            btnImportar = new Button();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(38, 29);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(174, 57);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar personajes";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(38, 121);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(174, 53);
            btnExportar.TabIndex = 1;
            btnExportar.Text = "Exportar personaje a PDF...";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(38, 207);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(174, 54);
            btnImportar.TabIndex = 2;
            btnImportar.Text = "Importar personajes desde base de datos";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // frmExportar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 441);
            Controls.Add(btnImportar);
            Controls.Add(btnExportar);
            Controls.Add(btnGuardar);
            Name = "frmExportar";
            Text = "frmExportar";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardar;
        private Button btnExportar;
        private Button btnImportar;
    }
}
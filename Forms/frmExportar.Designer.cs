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
            btmExportarDB = new Button();
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
            btnExportar.Location = new Point(38, 105);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(174, 53);
            btnExportar.TabIndex = 1;
            btnExportar.Text = "Exportar personaje a PDF...";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btmExportarDB
            // 
            btmExportarDB.Location = new Point(38, 179);
            btmExportarDB.Name = "btmExportarDB";
            btmExportarDB.Size = new Size(174, 55);
            btmExportarDB.TabIndex = 3;
            btmExportarDB.Text = "Exportar a base de datos";
            btmExportarDB.UseVisualStyleBackColor = true;
            btmExportarDB.Click += btmExportarDB_Click;
            // 
            // frmExportar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(248, 264);
            Controls.Add(btmExportarDB);
            Controls.Add(btnExportar);
            Controls.Add(btnGuardar);
            Name = "frmExportar";
            Text = "Exportar...";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardar;
        private Button btnExportar;
        private Button btmExportarDB;
    }
}
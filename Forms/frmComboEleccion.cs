using PrimerParcialLabo_Intento2.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialLabo_Intento2
{
    public partial class frmComboEleccion : Form
    {
        public string eleccion;
        public frmComboEleccion()
        {
            InitializeComponent();
        }

        public void AplicarTema(Theme theme)
        {
            this.BackColor = theme.MainColor;
            cboOpciones.BackColor = theme.SecondaryColor;
        }

        public frmComboEleccion(List<string> listEleccion, string descripcion) : this()
        {
            this.cboOpciones.DataSource = listEleccion;
            this.lblDescripcion.Text = descripcion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            eleccion = this.cboOpciones.Text;
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; this.Hide();
        }
    }
}

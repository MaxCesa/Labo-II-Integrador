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
    public partial class frmListEleccion : Form
    {
        public List<string> eleccion = new List<string>();
        int cantidad = 0;
        public frmListEleccion()
        {
            InitializeComponent();
        }

        public frmListEleccion(List<string> listEleccion, string descripcion, int cantidad) : this()
        {
            this.chklOpciones.DataSource = listEleccion;
            this.lblDescripcion.Text = descripcion;
            this.cantidad = cantidad;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.chklOpciones.CheckedItems.Count == 0 || this.chklOpciones.CheckedItems.Count > this.cantidad)
            {

                lblWarning.Text = "Debe seleccionar " + this.cantidad + " opciones de la lista.";
                lblWarning.Visible = true;
            }
            else
            {
                foreach (object obj in this.chklOpciones.CheckedItems)
                {
                    eleccion.Add(obj.ToString());
                }
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }

        }
    }
}

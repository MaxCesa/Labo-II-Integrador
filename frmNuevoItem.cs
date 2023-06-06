using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnD;

namespace PrimerParcialLabo_Intento2
{
    public partial class frmNuevoItem : Form
    {
        public Item item;
        public frmNuevoItem()
        {
            InitializeComponent();
            List<string> tipoItems = new List<string>()
            {
                "Tesoro",
                "Arma",
                "Armadura",
                "Instrumento"
            };

            cboTipo.DataSource = tipoItems;
            cboCaras.DataSource = Enum.GetNames(typeof(Dado.Caras));

        }

        void nuevoTipo(object sender, EventArgs e)
        {
            switch (this.cboTipo.Text)
            {
                case "Arma":
                    this.cboTipoEquipo.DataSource = Enum.GetNames(typeof(Arma.tipoDeDaño));
                    this.cboTipoEquipo.Visible = true;
                    this.lblTipo.Visible = true;
                    this.lblDaño.Visible = true;
                    this.numCantidadDados.Visible = true;
                    this.cboCaras.Visible = true;
                    this.lblAC.Visible = false;
                    this.numAC.Visible = false;
                    break;
                case "Armadura":
                    this.cboTipoEquipo.DataSource = Enum.GetNames(typeof(Armadura.TipoArmadura));
                    this.cboTipoEquipo.Visible = true;
                    this.lblTipo.Visible = true;
                    this.lblDaño.Visible = false;
                    this.numCantidadDados.Visible = false;
                    this.cboCaras.Visible = false;
                    this.lblAC.Visible = true;
                    this.numAC.Visible = true;
                    break;
                default:
                    this.cboTipoEquipo.Visible = false;
                    this.lblTipo.Visible = false;
                    this.lblDaño.Visible = false;
                    this.numCantidadDados.Visible = false;
                    this.cboCaras.Visible = false;
                    this.lblAC.Visible = false;
                    this.numAC.Visible = false;
                    break;
            }
        }

        private List<string> obtenerPropiedades()
        {
            List<string> retorno = new List<string>();
            string aux = this.txtPropiedades.Text;
            string delimitador = ", ";

            string[] propiedades = aux.Split(delimitador);
            foreach (string propiedad in propiedades)
            {
                retorno.Add(propiedad);
            }
            return retorno;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            switch (this.cboTipo.Text)
            {
                case "Arma":
                    item = new Arma(this.txtNombre.Text, (float)numPrecio.Value, (float)numPrecio.Value, txtDescripcion.Text, obtenerPropiedades(), new Dado((int)numCantidadDados.Value, (int)Enum.Parse(typeof(Dado.Caras), cboCaras.Text)), cboTipoEquipo.SelectedIndex);
                    break;
                case "Armadura":
                    item = new Armadura(this.txtNombre.Text, (float)numPrecio.Value, (float)numPrecio.Value, txtDescripcion.Text, obtenerPropiedades(), (int)numAC.Value, cboTipoEquipo.SelectedIndex);
                    break;
                default:
                    item = new Item(this.txtNombre.Text, (float)numPrecio.Value, (float)numPrecio.Value, txtDescripcion.Text, obtenerPropiedades());
                    break;
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

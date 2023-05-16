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
    public partial class frmInformacion : Form
    {
        Personaje personaje;
        public frmInformacion()
        {
            InitializeComponent();
        }

        public frmInformacion(Personaje personajeSeleccionado) : this()
        {
            this.personaje = personajeSeleccionado;
            cargarDatosPrincipales();
            cargarAtributos();
        }

        private void cargarDatosPrincipales()
        {
            this.lblNombreValor.Text = personaje.nombre;
            this.lblRazaValor.Text = personaje.raza.ToString();
            this.lblClaseValor.Text = personaje.clase.ToString();
        }

        private void cargarAtributos()
        {
            this.lblFuerzaValor.Text = personaje.totalAtributo("Fuerza").ToString();
            this.lblDestrezaValor.Text = personaje.totalAtributo("Destreza").ToString();
            this.lblConstitucionValor.Text = personaje.totalAtributo("Constitucion").ToString();
            this.lblInteligenciaValor.Text = personaje.totalAtributo("Inteligencia").ToString();
            this.lblSabiduriaValor.Text = personaje.totalAtributo("Sabiduria").ToString();
            this.lblCarismaValor.Text = personaje.totalAtributo("Carisma").ToString();

            this.lblFuerzaModificador.Text = personaje.modificadorDeAtributo("Fuerza").ToString();
            this.lblDestrezaModificador.Text = personaje.modificadorDeAtributo("Destreza").ToString();
            this.lblInteligenciaModificador.Text = personaje.modificadorDeAtributo("Inteligencia").ToString();
            this.lblConstitucionModificador.Text = personaje.modificadorDeAtributo("Constitucion").ToString();
            this.lblSabiduriaModificador.Text = personaje.modificadorDeAtributo("Sabiduria").ToString();
            this.lblCarismaModificador.Text = personaje.modificadorDeAtributo("Carisma").ToString();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialLabo_Intento2
{
    public partial class frmJugar : Form
    {
        Personaje personajeActual;
        public frmJugar()
        {
            InitializeComponent();
        }

        public frmJugar(Personaje personaje) : this()
        {
            personajeActual = personaje;
            this.cboAtributos.DataSource = Atributos.atributos;
            this.cboHabilidades.DataSource = Habilidades.habilidades;
        }

        private void btnTiradaAtributos_Click(object sender, EventArgs e)
        {
            string resultado = tirarAtributo(personajeActual);
            rtbConsola.AppendText(resultado);
        }

        private string tirarAtributo(Personaje personaje)
        {
            Dado dado = new(1,20);
            string atributo = this.cboAtributos.Text;
            int resultado = 0;
            resultado = dado.tirar() + personaje.clase.abilityScoreIncreases[atributo];
            return ("Roll de " + atributo + ": " +  resultado.ToString() + "\n");
        }
    }
}

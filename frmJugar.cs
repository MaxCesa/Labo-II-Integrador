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
using DnD;

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
            this.cboHabilidades.DataSource = Habilidad.habilidades;
        }

        private void btnTiradaAtributos_Click(object sender, EventArgs e)
        {
            string resultado = tirarAtributo(personajeActual);
            rtbConsola.AppendText(resultado);
        }

        private string tirarAtributo(Personaje personaje)
        {
            Dado dado = new(1, 20);
            string atributo = this.cboAtributos.Text;
            int resultado = 0;
            resultado = dado.tirar() + personaje.modificadorDeAtributo(atributo);
            return ("Roll de " + atributo + ": " + resultado.ToString() + "\n");
        }

        private void frmJugar_Load(object sender, EventArgs e)
        {

        }

        private void btnTiradaHabilidades_Click(object sender, EventArgs e)
        {
            rtbConsola.AppendText(tirarHabilidad(personajeActual));
        }

        private string tirarHabilidad(Personaje personaje)
        {
            Dado dado = new(1, 20);
            int resultado = 0;
            string habilidad = this.cboHabilidades.Text;
            resultado = dado.tirar() + personaje.modificadorDeAtributo(Habilidad.atributoAsociado(habilidad));
            if (personajeActual.esProeficiente(habilidad))
            {
                resultado += personaje.clase.bonusProeficiencia;
            }
            return ("Roll de " + habilidad + ": " + resultado.ToString() + "\n"); ;
        }
    }
}

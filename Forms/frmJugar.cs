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
using PrimerParcialLabo_Intento2.Forms;

namespace PrimerParcialLabo_Intento2
{
    public partial class frmJugar : Form
    {
        Personaje personajeActual;
        public delegate void Callback(string s, int i);
        public event Callback diceFinished;

        public frmJugar()
        {
            InitializeComponent();
        }

        public frmJugar(Personaje personaje) : this()
        {
            personajeActual = personaje;
            this.cboAtributos.DataSource = Atributos.atributos;
            this.cboHabilidades.DataSource = Habilidad.habilidades;
            this.diceFinished += MostrarResultados;
        }

        private void btnTiradaAtributos_Click(object sender, EventArgs e)
        {
            tirarAtributo(personajeActual);
        }

        private void tirarAtributo(Personaje personaje)
        {
            Dado dado = new(1, 20);
            string atributo = this.cboAtributos.Text;
            int resultado = 0;
            resultado = dado.tirar() + personaje.modificadorDeAtributo(atributo);

            Thread diceThread = new Thread(() => this.ShowDice(resultado, atributo));
            diceThread.Start();
        }

        private void frmJugar_Load(object sender, EventArgs e)
        {

        }

        private void btnTiradaHabilidades_Click(object sender, EventArgs e)
        {
            tirarHabilidad(personajeActual);
        }

        private void tirarHabilidad(Personaje personaje)
        {
            Dado dado = new(1, 20);
            int resultado = 0;
            string habilidad = this.cboHabilidades.Text;
            resultado = dado.tirar() + personaje.modificadorDeAtributo(Habilidad.atributoAsociado(habilidad));
            if (personajeActual.esProeficiente(habilidad))
            {
                resultado += personaje.bonusProeficiencia();
            }

            Thread diceThread = new Thread(() => this.ShowDice(resultado, habilidad));
            diceThread.Start();


            //return ("Roll de " + habilidad + ": " + resultado.ToString() + "\n"); ;
        }

        private void ShowDice(int resultado, string habilidad)
        {
            Form diceBox = new frmDiceBox((int)resultado);
            diceBox.ShowDialog();
            this.diceFinished.Invoke(habilidad, resultado);
        }

        private void MostrarResultados(string s, int i)
        {
            if (this.InvokeRequired)
            {
                Callback callback = new Callback(MostrarResultados);
                this.Invoke(callback, s, i);
            }
            else
            {
                rtbConsola.AppendText("Roll de " + (string)s + ": " + i.ToString() + "\n");
            }
        }
    }
}
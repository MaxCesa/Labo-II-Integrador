﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnD;
using Exepciones;

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
            cargarHabilidades();

        }

        private void cargarDatosPrincipales()
        {
            this.lblNombreValor.Text = personaje.nombre;
            this.lblRazaValor.Text = personaje.raza;
            this.lblClaseValor.Text = personaje.clase;
            this.lblBonusProeficienciaValor.Text = personaje.bonusProeficiencia().ToString();
        }

        private void cargarAtributos()
        {
            //Sacar el hardcodeo usando feature de cargarHabilidades.
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

        private void cargarHabilidades()
        {
            for (int i = 1; i < 19; i++)
            {
                Label habilidad = (Label)tableLayoutPanel4.GetControlFromPosition(0, i);
                Label proeficiencia = (Label)tableLayoutPanel4.GetControlFromPosition(1, i);
                Label modificador = (Label)tableLayoutPanel4.GetControlFromPosition(2, i);

                if (personaje.esProeficiente(habilidad.Text))
                {
                    proeficiencia.Text = "●";
                }
                modificador.Text = personaje.modificadorDeHabilidad(habilidad.Text).ToString();

            }
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAñadirItem_Click(object sender, EventArgs e)
        {
            using (frmNuevoItem form = new frmNuevoItem())
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    personaje.equipamiento.Add(form.item);
                    recargarTabla();
                }
            }
        }

        private void recargarTabla()
        {
            lstEquipo.Clear();
            foreach (Item item in personaje.equipamiento)
            {
                lstEquipo.Items.Add(item.ToString());
            }
        }

        private void btnTirarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(lstEquipo.SelectedIndices.Count > 0)
                {
                    int posicionItemABorrar = lstEquipo.SelectedIndices[0];
                    personaje.equipamiento.RemoveAt(posicionItemABorrar);
                    this.recargarTabla();

                }
                else
                {
                    throw new ItemNoSeleccionadoExeption();
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
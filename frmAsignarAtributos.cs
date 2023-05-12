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

    public partial class frmAsignarAtributos : Form
    {
        bool _manualActivado = false;
        public Dictionary<string, int> atributosGenerados = new Dictionary<string, int>()
        { { "Fuerza", 10}, { "Destreza", 10}, { "Inteligencia", 10}, { "Constitucion", 10}, { "Sabiduria", 10}, { "Carisma", 10} };
        public frmAsignarAtributos()
        {
            InitializeComponent();
        }

        void modoTirada()
        {
            this._manualActivado = false;
            this.numCarismaValor.Enabled = false;
            this.numConstitucionValor.Enabled = false;
            this.numDestrezaValor.Enabled = false;
            this.numFuerzaValor.Enabled = false;
            this.numInteligenciaValor.Enabled = false;
            this.numSabiduriaValor.Enabled = false;
            this.panel1.Enabled = true;
            this.panel2.Enabled = true;
            this.panel3.Enabled = true;
            this.panel4.Enabled = true;
            this.panel5.Enabled = true;
            this.panel6.Enabled = true;
        }

        void modoManual()
        {
            this._manualActivado = true;
            this.numCarismaValor.Enabled = true;
            this.numConstitucionValor.Enabled = true;
            this.numDestrezaValor.Enabled = true;
            this.numFuerzaValor.Enabled = true;
            this.numInteligenciaValor.Enabled = true;
            this.numSabiduriaValor.Enabled = true;
            this.panel1.Enabled = false;
            this.panel2.Enabled = false;
            this.panel3.Enabled = false;
            this.panel4.Enabled = false;
            this.panel5.Enabled = false;
            this.panel6.Enabled = false;

        }

        void tiradaAtributos()
        {
            int[] atributos = new int[6];
            Dado dados = new Dado(3, 6);
            for (int i = 0; i < 6; i++)
            {
                atributos[i] = dados.tirar();
            }
            this.lblFuerzaValor.Text = atributos[0].ToString();
            this.lblDestrezaValor.Text = atributos[1].ToString();
            this.lblConstitucionValor.Text = atributos[2].ToString();
            this.lblInteligenciaValor.Text = atributos[3].ToString();
            this.lblSabiduriaValor.Text = (atributos[4].ToString());
            this.lblCarismaValor.Text = (atributos[5].ToString());
        }

        public void btnTirada_Click(object sender, EventArgs e)
        {
            if (_manualActivado)
            {
                modoTirada();
            }
            else
            {
                tiradaAtributos();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void alternarValores(Label a, Label b)
        {
            string aux = b.Text;
            b.Text = a.Text;
            a.Text = aux;
        }
        private void btnFuerzaDerecha_Click(object sender, EventArgs e)
        {
            alternarValores(this.lblFuerzaValor, this.lblDestrezaValor);

        }

        private void btnDestrezaIzquierda_Click(object sender, EventArgs e)
        {
            alternarValores(this.lblFuerzaValor, this.lblDestrezaValor);
        }

        private void btnDestrezaDerecha_Click(object sender, EventArgs e)
        {
            alternarValores(this.lblDestrezaValor, this.lblConstitucionValor);
        }

        private void btnConstitucionIzquierda_Click(object sender, EventArgs e)
        {
            alternarValores(this.lblDestrezaValor, this.lblConstitucionValor);
        }

        private void btnConstitucionDerecha_Click(object sender, EventArgs e)
        {
            alternarValores(this.lblConstitucionValor, this.lblInteligenciaValor);
        }

        private void btnInteligenciaIzquierda_Click(object sender, EventArgs e)
        {
            alternarValores(this.lblConstitucionValor, this.lblInteligenciaValor);
        }

        private void btnInteligenciaDerecha_Click(object sender, EventArgs e)
        {
            alternarValores(this.lblInteligenciaValor, this.lblSabiduriaValor);
        }

        private void btnSabiduriaIzquierda_Click(object sender, EventArgs e)
        {
            alternarValores(this.lblInteligenciaValor, this.lblSabiduriaValor);
        }

        private void btnSabiduriaDerecha_Click(object sender, EventArgs e)
        {
            alternarValores(this.lblSabiduriaValor, this.lblCarismaValor);
        }

        private void btnCarismaIzquierda_Click(object sender, EventArgs e)
        {
            alternarValores(this.lblSabiduriaValor, this.lblCarismaValor);
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            modoManual();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (_manualActivado)
            {
                atributosGenerados["Fuerza"] = (int)numFuerzaValor.Value;
                atributosGenerados["Destreza"] = (int)numDestrezaValor.Value;
                atributosGenerados["Constitucion"] = (int)numConstitucionValor.Value;
                atributosGenerados["Inteligencia"] = (int)numInteligenciaValor.Value;
                atributosGenerados["Sabiduria"] = (int)numSabiduriaValor.Value;
                atributosGenerados["Carisma"] = (int)numCarismaValor.Value;
            }
            else
            {
                int[] atributos = new int[6];
                int.TryParse(lblFuerzaValor.Text, out atributos[0]);
                int.TryParse(lblDestrezaValor.Text, out atributos[1]);
                int.TryParse(lblConstitucionValor.Text, out atributos[2]);
                int.TryParse(lblInteligenciaValor.Text, out atributos[3]);
                int.TryParse(lblSabiduriaValor.Text, out atributos[4]);
                int.TryParse(lblCarismaValor.Text, out atributos[5]);
                atributosGenerados["Fuerza"] = atributos[0];
                atributosGenerados["Destreza"] = atributos[1];
                atributosGenerados["Constitucion"] = atributos[2];
                atributosGenerados["Inteligencia"] = atributos[3];
                atributosGenerados["Sabiduria"] = atributos[4];
                atributosGenerados["Carisma"] = atributos[5];
            }
            DialogResult = DialogResult.OK;
        }
    }
}

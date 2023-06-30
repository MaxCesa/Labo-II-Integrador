using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using DnD;
using Exepciones;
using IronSoftware;
using PrimerParcialLabo_Intento2.Interfaces;

namespace PrimerParcialLabo_Intento2
{
    [XmlInclude(typeof(Arma))]
    [XmlInclude(typeof(Armadura))]
    public partial class frmInformacion : Form, ITema
    {
        Personaje personaje;
        Configuration config;
        public frmInformacion()
        {
            InitializeComponent();
        }

        public frmInformacion(Personaje personajeSeleccionado, Configuration config) : this()
        {
            this.personaje = personajeSeleccionado;
            cargarDatosPrincipales();
            cargarAtributos();
            cargarHabilidades();
            this.config = config;
            AplicarTema(config.Theme);

        }

        public void AplicarTema(Theme theme)
        {
            this.BackColor = theme.MainColor;
            lstEquipo.BackColor = theme.SecondaryColor;
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
                if (lstEquipo.SelectedIndices.Count > 0)
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
            catch (Exception ex)
            {
                throw Logger.LogAndThrow(ex);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<Item> list = personaje.equipamiento;
            Type[] itemTypes = new Type[] { typeof(Arma), typeof(Armadura) };
            XmlSerializer xs = new XmlSerializer(typeof(List<Item>), itemTypes);
            using (StreamWriter streamWriter = System.IO.File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Equipo de " + personaje.ToString() +".xml"))
            {
                xs.Serialize(streamWriter, list);
            };
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            using(OpenFileDialog dialog = new OpenFileDialog() )
            {
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    string path = dialog.FileName;
                    Type[] itemTypes = new Type[] { typeof(Arma), typeof(Armadura) };
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<Item>), itemTypes);
    

                    var fileReader = new StreamReader(path, true);  // true means to detect the BOM.
                    var reader = XmlReader.Create(fileReader);

                    try { personaje.equipamiento = (List<Item>)deserializer.Deserialize(reader); }
                    catch (Exception ex) { throw Logger.LogAndThrow(ex); }
                    recargarTabla();
                }

            }

        }
    }
}

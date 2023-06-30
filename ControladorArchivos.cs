using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using IronPdf;
using IronPdf.Forms;
using Newtonsoft.Json;
using System.Reflection.PortableExecutable;
using DnD;
using PrimerParcialLabo_Intento2.Forms;

namespace PrimerParcialLabo_Intento2
{
    public static class ControladorArchivos
    {
        private static readonly string _defaultAdressPersonaje = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "\\personajes.json";
        private static readonly string _projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        private static readonly string _configAddress = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\configEmporio.json";
        private static readonly string _desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static event ExportacionPDFEventHandler ExportacionCompletada;

        public static void Guardar(ListaPersonajes personajes)
        {
            File.WriteAllText(_defaultAdressPersonaje, personajes.SerializarJson());
        }
        public static bool ExisteArchivoPersonajes()
        {
            return File.Exists(_defaultAdressPersonaje);
        }

        public static bool ExisteArchivo(string address)
        {
            return File.Exists(address);
        }
        public static ListaPersonajes LeerArchivoPersonajes()
        {
            ListaPersonajes retorno = new ListaPersonajes();

            using StreamReader reader = new(_defaultAdressPersonaje);
            var json = reader.ReadToEnd();
            retorno = JsonConvert.DeserializeObject<ListaPersonajes>(json);

            return retorno;
        }

        public static ListaPersonajes LeerArchivoPersonajes(Usuario usuario)
        {
            ListaPersonajes retorno = new ListaPersonajes();

            using StreamReader reader = new(_defaultAdressPersonaje);
            var json = reader.ReadToEnd();
            retorno = JsonConvert.DeserializeObject<ListaPersonajes>(json);
            retorno = Usuario.FiltrarPersonajesPorUsuario(retorno, usuario);

            return retorno;
        }
        public static void ExportarAPDF(Personaje personaje, frmLoading loadingForm)
        {
            PdfDocument documento = PdfDocument.FromFile(_projectDirectory + "\\hoja-rellenable.pdf");
            var form = documento.Form;
            var fields = form.Fields;
            { }
            rellenarDatosBasicos(ref form, personaje);
            rellenarAtributos(ref form, personaje);
            rellenarHabilidades(ref form, personaje);
            rellenarCaracteristicas(ref form, personaje);
            rellenarInventario(ref form, personaje);
            rellenarDatosVitales(ref form, personaje);
            rellenarSavingThrows(ref form, personaje);
            documento.SaveAs(_desktop + "\\" + personaje.ToString() + ".pdf");
            ExportacionCompletada?.Invoke(null, EventArgs.Empty);
        }

        private static void rellenarSavingThrows(ref PdfForm form, Personaje personaje)
        {
            ((CheckBoxField)form.GetFieldByName("Check Box 11")).BooleanValue = personaje.savingThrows.Contains("Fuerza") ? true : false;
            ((CheckBoxField)form.GetFieldByName("Check Box 18")).BooleanValue = personaje.savingThrows.Contains("Destreza") ? true : false;
            ((CheckBoxField)form.GetFieldByName("Check Box 19")).BooleanValue = personaje.savingThrows.Contains("Constitucion") ? true : false;
            ((CheckBoxField)form.GetFieldByName("Check Box 20")).BooleanValue = personaje.savingThrows.Contains("Inteligencia") ? true : false;
            ((CheckBoxField)form.GetFieldByName("Check Box 21")).BooleanValue = personaje.savingThrows.Contains("Sabiduria") ? true : false;
            ((CheckBoxField)form.GetFieldByName("Check Box 22")).BooleanValue = personaje.savingThrows.Contains("Carisma") ? true : false;

            form.GetFieldByName("ST Strength").Value = personaje.savingThrows.Contains("Fuerza") ? (personaje.modificadorDeAtributo("Fuerza") + personaje.bonusProeficiencia()).ToString() : personaje.modificadorDeAtributo("Fuerza").ToString();
            form.GetFieldByName("ST Dexterity").Value = personaje.savingThrows.Contains("Destreza") ? (personaje.modificadorDeAtributo("Destreza") + personaje.bonusProeficiencia()).ToString() : personaje.modificadorDeAtributo("Destreza").ToString();
            form.GetFieldByName("ST Constitution").Value = personaje.savingThrows.Contains("Constitucion") ? (personaje.modificadorDeAtributo("Constitucion") + personaje.bonusProeficiencia()).ToString() : personaje.modificadorDeAtributo("Constitucion").ToString();
            form.GetFieldByName("ST Intelligence").Value = personaje.savingThrows.Contains("Inteligencia") ? (personaje.modificadorDeAtributo("Inteligencia") + personaje.bonusProeficiencia()).ToString() : personaje.modificadorDeAtributo("Inteligencia").ToString();
            form.GetFieldByName("ST Wisdom").Value = personaje.savingThrows.Contains("Sabiduria") ? (personaje.modificadorDeAtributo("Sabiduria") + personaje.bonusProeficiencia()).ToString() : personaje.modificadorDeAtributo("Sabiduria").ToString();
            form.GetFieldByName("ST Charisma").Value = personaje.savingThrows.Contains("Carisma") ? (personaje.modificadorDeAtributo("Carisma") + personaje.bonusProeficiencia()).ToString() : personaje.modificadorDeAtributo("Carisma").ToString();
        }

        private static void rellenarDatosVitales(ref PdfForm form, Personaje personaje)
        {
            form.GetFieldByName("Speed").Value = personaje.velocidad.ToString();
            form.GetFieldByName("HPMax").Value = personaje.hitPointsMaximos.ToString();
            form.GetFieldByName("HDTotal").Value = personaje.dadoHP.cantidad.ToString();
            form.GetFieldByName("HD").Value = ("d" + personaje.dadoHP.caras.ToString());
        }

        private static void rellenarInventario(ref PdfForm form, Personaje personaje)
        {
            foreach(Item item in personaje.equipamiento)
            {
                if(item is Arma || item is Armadura)
                {
                    form.GetFieldByName("Equipment").Value += (item.ToString() + Environment.NewLine);
                }
                else
                {
                    form.GetFieldByName("Treasure").Value += (item.ToString() + Environment.NewLine);
                }
            }
        }

        private static void rellenarCaracteristicas(ref PdfForm form, Personaje personaje)
        {
            foreach(string caracteristica in personaje.caracteristicas)
            {
                form.GetFieldByName("Features and Traits").Value += (caracteristica + Environment.NewLine);
            }

            foreach(string proeficiencia in personaje.proeficiencias)
            {
                form.GetFieldByName("ProficienciesLang").Value += (proeficiencia + Environment.NewLine);
            }
        }

        static void rellenarDatosBasicos(ref PdfForm hoja, Personaje personaje)
        {
            hoja.GetFieldByName("CharacterName").Value = personaje.nombre;
            hoja.GetFieldByName("ClassLevel").Value = personaje.clase + " " + personaje.nivel.ToString();
            hoja.GetFieldByName("Race").Value = personaje.raza;
            hoja.GetFieldByName("PlayerName").Value = personaje.dueño;
            hoja.GetFieldByName("ProfBonus").Value = personaje.bonusProeficiencia().ToString();
        }

        static void rellenarAtributos(ref PdfForm hoja, Personaje personaje)
        {
            hoja.GetFieldByName("STR").Value = personaje.atributos["Fuerza"].ToString();
            hoja.GetFieldByName("DEX").Value = personaje.atributos["Destreza"].ToString();
            hoja.GetFieldByName("CON").Value = personaje.atributos["Constitucion"].ToString();
            hoja.GetFieldByName("INT").Value = personaje.atributos["Inteligencia"].ToString();
            hoja.GetFieldByName("WIS").Value = personaje.atributos["Sabiduria"].ToString();
            hoja.GetFieldByName("CHA").Value = personaje.atributos["Carisma"].ToString();

            hoja.GetFieldByName("STRmod").Value = personaje.modificadorDeAtributo("Fuerza").ToString();
            hoja.GetFieldByName("DEXmod").Value = personaje.modificadorDeAtributo("Destreza").ToString();
            hoja.GetFieldByName("CONmod").Value = personaje.modificadorDeAtributo("Constitucion").ToString();
            hoja.GetFieldByName("INTmod").Value = personaje.modificadorDeAtributo("Inteligencia").ToString();
            hoja.GetFieldByName("WISmod").Value = personaje.modificadorDeAtributo("Sabiduria").ToString();
            hoja.GetFieldByName("CHAmod").Value = personaje.modificadorDeAtributo("Carisma").ToString();
        }

        static void rellenarHabilidades(ref PdfForm hoja, Personaje personaje)
        {


            //Debido a la diferencia de idioma y la distribucion de la hoja,
            //no tuve forma de hacer esto aparte de manualmente

            //Aparte de eso, los que hicieron el pdf son unos forros y pusieron espacios
            //al final de alguno de los nombres de campos.
            hoja.GetFieldByName("Acrobatics").Value = personaje.modificadorDeHabilidad("Acrobacias").ToString();
            hoja.GetFieldByName("Animal").Value = personaje.modificadorDeHabilidad("Manejo de animales").ToString();
            hoja.GetFieldByName("Arcana").Value = personaje.modificadorDeHabilidad("Arcano").ToString();
            hoja.GetFieldByName("Athletics").Value = personaje.modificadorDeHabilidad("Atletismo").ToString();
            hoja.GetFieldByName("Deception").Value = personaje.modificadorDeHabilidad("Engaño").ToString();
            hoja.GetFieldByName("History").Value = personaje.modificadorDeHabilidad("Historia").ToString();
            hoja.GetFieldByName("Insight").Value = personaje.modificadorDeHabilidad("Perspicacia").ToString();
            hoja.GetFieldByName("Intimidation").Value = personaje.modificadorDeHabilidad("Intimidacion").ToString();
            hoja.GetFieldByName("Investigation").Value = personaje.modificadorDeHabilidad("Investigacion").ToString();
            hoja.GetFieldByName("Medicine").Value = personaje.modificadorDeHabilidad("Medicina").ToString();
            hoja.GetFieldByName("Nature").Value = personaje.modificadorDeHabilidad("Naturaleza").ToString();
            hoja.GetFieldByName("Perception").Value = personaje.modificadorDeHabilidad("Percepcion").ToString();
            hoja.GetFieldByName("Performance").Value = personaje.modificadorDeHabilidad("Interpretacion").ToString();
            hoja.GetFieldByName("Persuasion").Value = personaje.modificadorDeHabilidad("Persuasion").ToString();
            hoja.GetFieldByName("Religion").Value = personaje.modificadorDeHabilidad("Religión").ToString();
            hoja.GetFieldByName("SleightofHand").Value = personaje.modificadorDeHabilidad("Juego de manos").ToString();
            hoja.GetFieldByName("Stealth").Value = personaje.modificadorDeHabilidad("Sigilo").ToString();
            hoja.GetFieldByName("Survival").Value = personaje.modificadorDeHabilidad("Supervivencia").ToString();

            ((CheckBoxField)hoja.GetFieldByName("Check Box 23")).BooleanValue = personaje.habilidades["Acrobacias"] ? true : false;
            ((CheckBoxField)hoja.GetFieldByName("Check Box 24")).BooleanValue = personaje.habilidades["Manejo de animales"] ? true : false;
            ((CheckBoxField)hoja.GetFieldByName("Check Box 25")).BooleanValue = personaje.habilidades["Arcano"] ? true : false;
            ((CheckBoxField)hoja.GetFieldByName("Check Box 26")).BooleanValue = personaje.habilidades["Atletismo"] ? true : false;
            ((CheckBoxField)hoja.GetFieldByName("Check Box 27")).BooleanValue = personaje.habilidades["Engaño"] ? true : false;
            ((CheckBoxField)hoja.GetFieldByName("Check Box 28")).BooleanValue = personaje.habilidades["Historia"] ? true : false;
            ((CheckBoxField)hoja.GetFieldByName("Check Box 29")).BooleanValue = personaje.habilidades["Perspicacia"] ? true : false;
            ((CheckBoxField)hoja.GetFieldByName("Check Box 30")).BooleanValue = personaje.habilidades["Intimidacion"] ? true : false;
            ((CheckBoxField)hoja.GetFieldByName("Check Box 31")).BooleanValue = personaje.habilidades["Investigacion"] ? true : false;
            ((CheckBoxField)hoja.GetFieldByName("Check Box 32")).BooleanValue = personaje.habilidades["Medicina"] ? true : false;
            ((CheckBoxField)hoja.GetFieldByName("Check Box 33")).BooleanValue = personaje.habilidades["Naturaleza"] ? true : false;
            ((CheckBoxField)hoja.GetFieldByName("Check Box 34")).BooleanValue = personaje.habilidades["Percepcion"] ? true : false;
            ((CheckBoxField)hoja.GetFieldByName("Check Box 35")).BooleanValue = personaje.habilidades["Interpretacion"] ? true : false;
            ((CheckBoxField)hoja.GetFieldByName("Check Box 36")).BooleanValue = personaje.habilidades["Persuasion"] ? true : false;
            ((CheckBoxField)hoja.GetFieldByName("Check Box 37")).BooleanValue = personaje.habilidades["Religión"] ? true : false;
            ((CheckBoxField)hoja.GetFieldByName("Check Box 38")).BooleanValue = personaje.habilidades["Juego de manos"] ? true : false;
            ((CheckBoxField)hoja.GetFieldByName("Check Box 39")).BooleanValue = personaje.habilidades["Sigilo"] ? true : false;
            ((CheckBoxField)hoja.GetFieldByName("Check Box 40")).BooleanValue = personaje.habilidades["Supervivencia"] ? true : false;
        }

        internal static Configuration LoadConfig()
        {
            Configuration config = new Configuration();
            if (ExisteArchivo(_configAddress))
            {
                using StreamReader reader = new(_configAddress);
                var json = reader.ReadToEnd();
                config = Configuration.DeserializarJson<Configuration>(json);
            }
            return config;
        }

        internal static void SaveConfig(Configuration config)
        {
            File.WriteAllText(_configAddress, config.SerializarJson());
        }

    }
}

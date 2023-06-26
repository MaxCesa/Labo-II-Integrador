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

namespace PrimerParcialLabo_Intento2
{
    public static class ControladorArchivos
    {
        private static readonly string _defaultAdressPersonaje = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "\\personajes.json";
        private static readonly string _projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        private static readonly string _configAddress = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\configEmporio.json";
        
        public static void Guardar(List<Personaje> personajes)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            serializer.ObjectCreationHandling = ObjectCreationHandling.Auto;
            serializer.TypeNameHandling = TypeNameHandling.All;

            using (StreamWriter sWriter = new StreamWriter(_defaultAdressPersonaje))
            using (JsonWriter jsonWriter = new JsonTextWriter(sWriter))
            {
                serializer.Serialize(jsonWriter, personajes);
            }
        }
        public static bool ExisteArchivoPersonajes()
        {
            return File.Exists(_defaultAdressPersonaje);
        }

        public static bool ExisteArchivo(string address)
        {
            return File.Exists(address);
        }
        public static List<Personaje> LeerArchivoPersonajes()
        {
            List<Personaje> retorno = new List<Personaje>();

            using StreamReader reader = new(_defaultAdressPersonaje);
            var json = reader.ReadToEnd();
            retorno = JsonConvert.DeserializeObject<List<Personaje>>(json);

            return retorno;
        }

        public static List<Personaje> LeerArchivoPersonajes(Usuario usuario)
        {
            List<Personaje> retorno = new List<Personaje>();

            using StreamReader reader = new(_defaultAdressPersonaje);
            var json = reader.ReadToEnd();
            retorno = JsonConvert.DeserializeObject<List<Personaje>>(json);
            retorno = Usuario.FiltrarPersonajesPorUsuario(retorno, usuario);

            return retorno;
        }
        public static void ExportarAPDF(Personaje personaje)
        {
            PdfDocument documento = PdfDocument.FromFile(_projectDirectory + "\\hoja-rellenable.pdf");
            var form = documento.Form;
            var fields = form.Fields;
            rellenarDatosBasicos(ref form, personaje);
            documento.SaveAs(_projectDirectory + "\\hoja-rellenada.pdf");
        }
        
        static void rellenarDatosBasicos(ref PdfForm hoja, Personaje personaje)
        {
            hoja.GetFieldByName("CharacterName").Value = personaje.nombre;
            hoja.GetFieldByName("ClassLevel").Value = personaje.clase.ToString();
            hoja.GetFieldByName("Race").Value = personaje.raza.ToString();
        }

        internal static Configuration LoadConfig()
        {
            Configuration config = new Configuration();
            if (ExisteArchivo(_configAddress))
            {
                using StreamReader reader = new(_configAddress);
                var json = reader.ReadToEnd();
                config = Serializador.DeserealizarConfiguracion(json);
            }
            return config;
        }

        internal static void SaveConfig(Configuration config)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            serializer.ObjectCreationHandling = ObjectCreationHandling.Auto;
            serializer.TypeNameHandling = TypeNameHandling.All;

            using (StreamWriter sWriter = new StreamWriter(_configAddress))
            using (JsonWriter jsonWriter = new JsonTextWriter(sWriter))
            {
                serializer.Serialize(jsonWriter, config);
            }
        }
    }
}

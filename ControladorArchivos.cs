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

namespace PrimerParcialLabo_Intento2
{
    public static class ControladorArchivos
    {
        private static readonly string _defaultAdress = Path.GetRelativePath(AppDomain.CurrentDomain.BaseDirectory, "D:\\Users\\maxic\\Documents\\Programacion 2\\PrimerParcialLabo-Intento2\\files");
        public static void Escribir(string obj)
        {
            if (obj != String.Empty)
            {
                File.WriteAllText(_defaultAdress, obj);
            }
        }

        public static void Escribir(string obj, string path)
        {
            if (obj != String.Empty && path != String.Empty)
            {
                File.WriteAllText(path, obj);
            }
        }

        public static string Leer()
        {
            string retorno = "404";
            if (File.Exists(_defaultAdress))
            {
                retorno = File.ReadAllText(_defaultAdress);
            }
            return retorno;
        }

        public static string Leer(string path)
        {
            string retorno = "";
            if (File.Exists(path))
            {
                retorno = File.ReadAllText(path);
            }
            return retorno;
        }

        public static void ExportarAPDF(Personaje personaje)
        {
            PdfDocument documento = PdfDocument.FromFile(_defaultAdress + "hoja-rellenable.pdf");
            var form = documento.Form;
            var fields = form.Fields;
            rellenarDatosBasicos(ref form, personaje);
            documento.SaveAs(_defaultAdress + "hoja-rellenada.pdf");
        }

        static void rellenarDatosBasicos(ref PdfForm hoja, Personaje personaje)
        {
            hoja.GetFieldByName("CharacterName").Value = personaje.nombre;
            hoja.GetFieldByName("ClassLevel").Value = personaje.clase.ToString();
            hoja.GetFieldByName("Race").Value = personaje.raza.ToString();
        }
    }
}

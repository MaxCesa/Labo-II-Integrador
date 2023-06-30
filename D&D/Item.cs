using Newtonsoft.Json;
using PrimerParcialLabo_Intento2;
using PrimerParcialLabo_Intento2.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DnD
{
    public class Item: ISerializador
    {
        public string nombre { get; set; }
        public float precio { get; set; }
        public float peso { get; set; }
        public string descripcion { get; set; }
        public List<string> propiedades { get; set; } = new List<string>();
        public Item()
        {
            this.nombre = string.Empty;
            this.precio = 0;
            this.peso = 0;
            this.descripcion = string.Empty;
        }

        public Item(string nombre, float precio, float peso)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.peso = peso;
            this.descripcion = string.Empty;
        }

        public Item(string nombre)
        {
            this.nombre = nombre;
            this.precio = 0;
            this.peso = 0;
            this.descripcion = string.Empty;
        }

        public Item(string nombre, float precio, float peso, string descripcion, List<string> propiedades) : this(nombre, precio, peso)
        {
            this.descripcion = descripcion;
            this.propiedades = propiedades;
        }

        public string SerializarXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Item));
            StringWriter sw = new StringWriter();
            serializer.Serialize(sw, this);

            return sw.ToString();
        }

        public string SerializarJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public static Item DeserializarXml<Item>(string xml)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Item));
            StringReader sr = new StringReader(xml);
            Item item = (Item)deserializer.Deserialize(sr);
            return item;

        }

        public override string ToString()
        {
            return this.nombre;
        }

        public static bool operator == (Item a, string b)
        {
            return (a.nombre == b);
        }

        public static bool operator == (Item a, Item b)
        {
            return (b.nombre == a.nombre && a.peso == b.peso && b.precio == a.precio && a.descripcion == b.descripcion && a.propiedades.SequenceEqual(b.propiedades));
        }

        public static bool operator != (Item a, Item b)
        {
            return !(a == b);
        }

        public static bool operator != (Item a, string b) {  return !(a == b); }

    }

    
}

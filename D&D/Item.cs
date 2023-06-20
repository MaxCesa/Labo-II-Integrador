using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public class Item
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

        public override string ToString()
        {
            return this.nombre;
        }

        public static bool operator == (Item a, string b)
        {
            return (a.nombre == b);
        }

        public static bool operator != (Item a, string b) {  return !(a == b); }

    }

    
}

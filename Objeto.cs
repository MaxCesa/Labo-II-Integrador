using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    internal class Objeto
    {
        public string nombre { get; set; }
        public int precio { get; set; }
        public float peso { get; set; }
        public string descripcion { get; set; }

        public Objeto()
        {
            this.nombre = string.Empty;
            this.precio = 0;
            this.peso = 0;
            this.descripcion = string.Empty;
        }

        public Objeto(string nombre, int precio, float peso)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.peso = peso;
            this.descripcion = string.Empty;
        }

        public Objeto(string nombre)
        {
            this.nombre = nombre;
            this.precio = 0;
            this.peso = 0;
            this.descripcion = string.Empty;
        }

        public Objeto(string nombre, int precio, float peso, string descripcion) : this(nombre, precio, peso)
        {
            this.descripcion = descripcion;
        }

        public static string GetDescriptionFromEnum(Enum value)
        {
            DescriptionAttribute attribute = value.GetType()
            .GetField(value.ToString())
            .GetCustomAttributes(typeof(DescriptionAttribute), false)
            .SingleOrDefault() as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }

    
}

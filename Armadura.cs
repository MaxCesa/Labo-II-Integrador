using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    internal class Armadura : Item
    {
        public int ArmorClass {get; set;}
        public enum TipoArmadura
        {
            Ligera,
            Mediana,
            Pesada,
            Escudo,
        }

        public TipoArmadura tipoArmadura { get; set; }

        public Armadura(string nombre, float precio, float peso, string descripcion, List<string> propiedades, int armorClass, int tipo) : base(nombre, precio, peso, descripcion, propiedades)
        {
            ArmorClass = armorClass;
            this.tipoArmadura = (TipoArmadura)tipo;
        }
    }
}

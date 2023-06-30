using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DnD
{
    [XmlInclude(typeof(Armadura))]
    public class Armadura : Item
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

        public Armadura(): base()
        {
            ArmorClass = 0;
            this.tipoArmadura = TipoArmadura.Ligera;
        }
    }
}

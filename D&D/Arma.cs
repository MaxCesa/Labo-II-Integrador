using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DnD
{
    [XmlInclude(typeof(Arma))]
    public class Arma : Item
    {
        public Dado dadoDaño;
        public enum tipoDeDaño
        {
            Cortante,
            Punzante,
            Golpeante,
            CortanteMagico,
            PunzanteMagico,
            GolpeanteMagico,
            Acido,
            Gelido,
            Fuerza,
            Electrico,
            Necrotico,
            Venenoso,
            Psiquico,
            Radiante,
            Trueno
        }
        public tipoDeDaño damageType;
        

        public Arma(string nombre, float precio, float peso, string descripcion, List<string> propiedades, Dado dado, int numeroDeTipo): base(nombre, precio, peso, descripcion, propiedades)
        {
            dadoDaño = dado;
            tipoDeDaño damageType = (tipoDeDaño)numeroDeTipo;
            propiedades = new List<string>();
        }

        public Arma(): base()
        {
            dadoDaño = new Dado(1,4);
            tipoDeDaño damageType = tipoDeDaño.Cortante;
            propiedades = new List<string>();
        }

        
    }
}

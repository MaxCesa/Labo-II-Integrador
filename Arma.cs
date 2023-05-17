using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    internal class Arma : Item
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

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    internal class Arma : Objeto
    {
        public Dado dadoDaño;
        public enum tipoDeDaño
        {
            Cortante = 1,
            Punzante = 2,
            Golpeante = 3,
            CortanteMagico = 11,
            PunzanteMagico = 12,
            GolpeanteMagico = 13,
            Acido = 101,
            Gelido = 102,
            Fuerza = 103,
            Electrico = 104,
            Necrotico = 105,
            Venenoso = 106,
            Psiquico = 108,
            Radiante = 109,
            Trueno = 110
        }
        public tipoDeDaño damageType;
        public List<string> propiedades; 
        public Arma(string nombre, int dado, int tipoDeDado, int numeroDeTipo): base(nombre)
        {
            dadoDaño = new Dado(dado, tipoDeDado);
            tipoDeDaño damageType = (tipoDeDaño)numeroDeTipo;
            propiedades = new List<string>();
        }

        public Arma(string nombre, int dado, int tipoDeDado, int numeroDeTipo, List<string> propiedades): this(nombre, dado, tipoDeDado, numeroDeTipo)
        {
            this.propiedades = propiedades;
        }

        
    }
}

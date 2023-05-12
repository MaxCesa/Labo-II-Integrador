using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    internal class Arma : Objeto
    {
        private int _cantidadDados;
        private int _tipoDado;
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
        public Arma(string nombre, int dado, int tipoDeDado, int numeroDeTipo): base(nombre)
        {
            _cantidadDados = dado;
            _tipoDado = tipoDeDado;
            tipoDeDaño damageType = (tipoDeDaño)numeroDeTipo;
        }

        
    }
}

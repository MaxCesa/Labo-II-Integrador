using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    public class Dado
    {
        public int cantidad { set; get; }
        public int caras { set; get; }

        public enum Caras 
        {
            d4 = 4,
            d6 = 6,
            d8 = 8,
            d10 = 10,
            d12 = 12,
            d20 = 20
        }
        public Dado() { }
        public Dado(int cantidad, int caras)
        {
            this.cantidad = cantidad;
            this.caras = caras;
        }

        public int tirar()
        {
            int total = 0;
            Random rnd = new Random();
            for(int i = 0; i < cantidad; i++)
            {
                total += rnd.Next(1, caras + 1);
            }
            return total;
        }

        public int tirar(int modificador)
        {
            int total = modificador; Random rnd = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                total += rnd.Next(1, caras + 1);
            }
            return total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PrimerParcialLabo_Intento2
{
    public class Personaje
    {
        public string nombre { set; get; }
        public Clase clase { set; get; }
        public Raza raza { set; get; }
        //public Background background;
        public Dictionary<string, int> atributos { set; get; } //Los atributos al ser mostrados se le deben sumar los bonus por clase
        public Personaje(string nombre, Clase clase, Raza raza)
        {
            this.nombre = nombre;
            this.clase = clase;
            this.raza = raza;


        }

        public Personaje(string nombre, Clase clase, Raza raza, Dictionary<string, int> atributos) : this(nombre, clase, raza)
        {
            this.atributos = atributos;
        }

        public override string ToString()
        {
            return this.nombre + " : " + this.clase + " nivel " + this.clase.nivel.ToString();
        }

        public bool esProeficiente(string habilidad)
        {
            return (this.clase.proeficiencias.Contains(habilidad));
        }

        public int modificadorDeAtributo(string atributo)
        {
            return (int)Math.Truncate((double)(-5 + (this.totalAtributo(atributo) / 2)));
        }

        public int totalAtributo(string atributo)
        {
            return atributos[atributo] + this.raza.abilityScoreIncreases[atributo] + this.clase.abilityScoreIncreases[atributo];
        }
    }
}

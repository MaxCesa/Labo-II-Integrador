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
        public Dictionary<string, Habilidad> habilidades { set; get; }
        public List<Item> equipamiento  { set; get; }


        public Personaje(string nombre, Clase clase, Raza raza, Dictionary<string, int> atributos)
        {
            this.nombre = nombre;
            this.clase = clase;
            this.raza = raza;
            this.atributos = atributos;
            habilidades = new Dictionary<string, Habilidad>();
            foreach (string habilidad in Habilidad.habilidades)
            {
                habilidades.Add(habilidad, new Habilidad(esProeficiente(habilidad), modificadorDeHabilidad(habilidad)));
            }
            equipamiento = new List<Item>();
        }

        public override string ToString()
        {
            return this.nombre + " : " + this.clase + " nivel " + this.clase.nivel.ToString();
        }
        /// <summary>
        /// Retorna un booleano indicando si el personaje es proeficiente en la habilidad pasada por parametro
        /// </summary>
        /// <param name="habilidad"> un string indicando el nombre de la habilidad</param>
        /// <returns></returns>
        public bool esProeficiente(string habilidad) 
        {
            return (this.clase.habilidades.Contains(habilidad));
        }
        /// <summary>
        /// Retorna el modificador que se utiliza en una tirada de dado basado en la puntuacion del atributo dado
        /// del personaje.
        /// </summary>
        /// <param name="atributo"> un string indicando el nombre del atributo a evaluar</param>
        /// <returns></returns>
        public int modificadorDeAtributo(string atributo)
        {
            return (int)Math.Truncate((double)(-5 + (this.totalAtributo(atributo) / 2)));
        }
        /// <summary>
        /// Retorna el valor total de un atributo tomando en cuenta los bonus de clase y raza.
        /// </summary>
        /// <param name="atributo">un string indicando el nombre del atributo a evaluar</param>
        /// <returns></returns>
        public int totalAtributo(string atributo)
        {
            return atributos[atributo] + this.raza.abilityScoreIncreases[atributo] + this.clase.abilityScoreIncreases[atributo];
        }
        /// <summary>
        /// Retorna el modificador que se utiliza en una tirada de dado basado en la habilidad siendo evaluada.
        /// </summary>
        /// <param name="habilidad"></param>
        /// <returns></returns>
        public int modificadorDeHabilidad(string habilidad)
        {
            int retorno = 0;
            if(esProeficiente(habilidad))
            {
                retorno += this.clase.bonusProeficiencia;
            }
            retorno += modificadorDeAtributo(Habilidad.atributoAsociado(habilidad));
            return retorno;
        }


    }
}

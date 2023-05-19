using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    enum Razas
    {
        Enano,
        Elfo,
        Mediano,
        Humano,
        Gnomo,
        MedioElfo,
        MedioOrco,
        Tiefling
    }
    public abstract class Raza
    {
        public string nombre { set; get; } = "";
        public int velocidad { set; get; } = 0;
        public string size { set; get; } = "";
        public Dictionary<string, int> abilityScoreIncreases { set; get; } = new Dictionary<string, int>()
        { { "Fuerza", 0 }, { "Destreza", 0 }, { "Constitucion", 0 }, { "Carisma", 0 }, { "Inteligencia", 0 }, { "Sabiduria", 0 } };
        public List<string> lenguajes { set; get; } = new List<string>() { "Comun" };
        public List<string> caracteristicas { set; get; } = new List<string>();
        public List<string> proeficiencias { set; get; } = new List<string>();
        public List<string> habilidades { set; get; } = new List<string>();

        public Raza() { }

        public override string ToString()
        {
            return nombre;
        }
    }

    public class Enano : Raza
    {
        public Enano()
        {
            this.nombre = "Enano";
            this.velocidad = 25;
            this.caracteristicas.Add("Darkvision");
            this.caracteristicas.Add("Resistencia enana");
            this.caracteristicas.Add("Stonecutting");
            this.lenguajes.Add("Enano");
            this.abilityScoreIncreases["Constitucion"] = 2;
            this.size = "Mediano";

        }
    }

    public class Elfo : Raza
    {
        public Elfo()
        {
            this.nombre = "Enano";
            this.velocidad = 30;
            this.caracteristicas.Add("Darkvision");
            this.caracteristicas.Add("Keen senses");
            this.caracteristicas.Add("Fey ancestry");
            this.caracteristicas.Add("Trance");
            this.lenguajes.Add("Elfico");
            this.abilityScoreIncreases["Destreza"] = 2;
            this.size = "Mediano";

        }
    }

    public class Mediano : Raza
    {
        public Mediano()
        {
            this.nombre = "Mediano";
            this.velocidad = 25;
            this.caracteristicas.Add("Suertudo");
            this.caracteristicas.Add("Valiente");
            this.caracteristicas.Add("Agilidad de Mediano");
            this.lenguajes.Add("Mediano");
            this.abilityScoreIncreases["Destreza"] = 2;
            this.size = "Pequeño";

        }
    }
    public class Humano : Raza
    {
        public Humano()
        {
            this.nombre = "Humano";
            this.velocidad = 30;
            this.lenguajes.Add(Lenguajes.elegirLenguaje());
            this.abilityScoreIncreases["Destreza"] = 1;
            this.abilityScoreIncreases["Fuerza"] = 1;
            this.abilityScoreIncreases["Inteligencia"] = 1;
            this.abilityScoreIncreases["Sabiduria"] = 1;
            this.abilityScoreIncreases["Constitucion"] = 1;
            this.abilityScoreIncreases["Carisma"] = 1;
            this.size = "Mediano";

        }
    }

    public class Gnomo : Raza
    {
        public Gnomo()
        {
            this.nombre = "Gnomo";
            this.velocidad = 25;
            this.lenguajes.Add("Gnómico");
            this.abilityScoreIncreases["Inteligencia"] = 2;
            this.size = "Pequeño";
            this.caracteristicas.Add("Darkvision");
            this.caracteristicas.Add("Astucia de Gnomo");

        }
    }
    public class MedioElfo : Raza
    {
        public MedioElfo()
        {
            this.nombre = "Medio-Elfo";
            this.velocidad = 30;
            this.caracteristicas.Add("Darkvision");
            this.caracteristicas.Add("Fey ancestry");
            this.lenguajes.Add("Elfico");
            this.lenguajes.Add(Lenguajes.elegirLenguaje());
            this.abilityScoreIncreases["Carisma"] = 2;
            this.abilityScoreIncreases[Atributos.elegirAtributo()] += 1;
            this.abilityScoreIncreases[Atributos.elegirAtributo()] += 1;
            this.habilidades.Add(Habilidad.elegirHabilidad());
            this.habilidades.Add(Habilidad.elegirHabilidad());
            this.size = "Mediano";

        }
    }
    public class MedioOrco : Raza
    {
        public MedioOrco()
        {
            this.nombre = "Medio-Orco";
            this.velocidad = 30;
            this.caracteristicas.Add("Darkvision");
            this.caracteristicas.Add("Amenazante");
            this.caracteristicas.Add("Resistencia implacable");
            this.caracteristicas.Add("Ataques salvajes");
            this.lenguajes.Add("Orco");
            this.abilityScoreIncreases["Fuerza"] = 2;
            this.abilityScoreIncreases["Constitucion"] = 1;
            this.size = "Mediano";
        }
    }
    public class Tiefling : Raza
    {
        public Tiefling()
        {
            this.nombre = "Tiefling";
            this.velocidad = 30;
            this.caracteristicas.Add("Darkvision");
            this.caracteristicas.Add("Resistencia infernal");
            this.caracteristicas.Add("Legado infernal");
            this.lenguajes.Add("Infernal");
            this.abilityScoreIncreases["Carisma"] = 2;
            this.abilityScoreIncreases["Inteligencia"] = 1;
            this.size = "Mediano";
        }
    }
}

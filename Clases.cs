using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    enum Clases
    {
        Barbaro,
        Bardo,
        Clerigo,
        Druida,
        Guerrero,
        Monje,
        Paladin,
        Explorador
    }
    public abstract class Clase
    {
        public Dado dadoHP { set; get; } = new Dado(0,0);
        public string nombre { set; get; } = "";
        public int nivel { set; get; } = 0;
        public int bonusProeficiencia { set; get; } = 0;
        public Dictionary<string, int> abilityScoreIncreases { set; get; } = new Dictionary<string, int>() 
        { { "Fuerza", 0 }, { "Destreza", 0 }, { "Constitucion", 0 }, { "Carisma", 0 }, { "Inteligencia", 0 }, { "Sabiduria", 0 } };
        public List<string> lenguajes { set; get; } = new List<string>();
        public List<string> caracteristicas { set; get; } = new List<string>();
        public List<string> proeficiencias { set; get; } = new List<string>();
        public List<string> habilidades { set; get; } = new List<string>();
        public List<string> savingThrows { set; get; } = new List<string>();
        public Dictionary<int, int> spellSlots { set; get; } = new Dictionary<int, int>(); // spellSlots {Nivel, Cantidad}
        public List<string> hechizos { set; get; } = new List<string>();
        private string _especializacion { set; get; } = "";
        public void SetEspecializacion(List<string> especializaciones)
        {
            using (var form = new frmComboEleccion(especializaciones, "Elija la especializacion de su personaje..."))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    this.caracteristicas.Add(form.eleccion);
                    _especializacion = form.eleccion;
                }
                else if (form.DialogResult == DialogResult.Cancel)
                {
                    throw new Exception("Operacion cancelada");
                }
                form.Close();
            }
        }
        public string GetEspecializacion()
        {
            return _especializacion;
        }
        public override string ToString()
        {
            return this.nombre;
        }
        public abstract void subirDeNivel(int cantidadNiveles);
        public void abilityScoreImprovement()
        {
            List<string> opciones = new List<string>()
                        {
                            "Fuerza", "Destreza","Constitucion","Carisma","Inteligencia","Sabiduria"
                        };
            using (var form = new frmListEleccion(opciones, "Elija atributos a mejorar (Maximo 2).", 2))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    List<string> eleccion = form.eleccion;
                    if (eleccion.Count == 1)
                    {
                        this.abilityScoreIncreases[eleccion[0]] += 2;
                    }
                    else
                    {
                        foreach (string ele in eleccion)
                        {
                            this.abilityScoreIncreases[ele] += 1;
                        }
                    }
                }
                else if (form.DialogResult == DialogResult.Cancel)
                {
                    throw new Exception("Operacion cancelada");
                }
                form.Close();
            }
        }


    }

    public class Barbaro : Clase
    {
        public Barbaro(int nivel)
        {
            this.dadoHP = new Dado(1, 12);
            this.nombre = "Barbaro";
            this.proeficiencias.Add("Armadura mediana");
            this.proeficiencias.Add("Armadura ligera");
            this.proeficiencias.Add("Escudos");
            this.proeficiencias.Add("Armas marciales");
            this.proeficiencias.Add("Armas simples");
            this.savingThrows.Add("Fuerza");
            this.savingThrows.Add("Constitucion");

            List<string> opciones = new List<string>()
            {
                "Manejo de animales", "Atletismo","Intimidacion","Naturaleza","Percepcion","Supervivencia"
            };
            foreach (string habilidad in Habilidad.elegirDeLista(opciones, 2))
            {
                this.habilidades.Add(habilidad);
            }
            this.subirDeNivel(nivel);
            //AÑADIR EQUIPAMIENTO
        }

        public override void subirDeNivel(int cantidadNiveles)
        {
            List<string> opciones = new List<string>();
            for (int i = this.nivel; i <= (this.nivel + cantidadNiveles); i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        this.caracteristicas.Add("Ira");
                        this.caracteristicas.Add("Defensa desarmada");
                        this.bonusProeficiencia = 2;
                        break;
                    case 2:
                        this.caracteristicas.Add("Ataque Imprudente");
                        this.caracteristicas.Add("Sentido de peligro");
                        break;
                    case 3:
                        opciones = new List<string>()
                        {
                            "Camino del Berserker", "Camino del Guerrero de Totem"
                        };
                        using (var form = new frmComboEleccion(opciones, "Elija el camino de su barbaro..."))
                        {
                            if (form.DialogResult == DialogResult.OK)
                            {
                                string eleccion = form.eleccion;
                                this.caracteristicas.Add(eleccion);
                            }
                            else if (form.DialogResult == DialogResult.Cancel)
                            {
                                throw new Exception("Operacion cancelada");
                            }
                            form.Close();
                        }
                        if (caracteristicas.Contains("Camino del Berserker"))
                        {
                            caracteristicas.Add("Frenesí");
                        }
                        else
                        {
                            caracteristicas.Add("Buscador espiritual");
                            caracteristicas.Add("Espiritu del Totem");
                        }
                        break;
                    case 4:
                        this.abilityScoreImprovement();
                        break;
                    case 5:
                        this.caracteristicas.Add("Ataque extra");
                        this.caracteristicas.Add("Movimiento rapido");
                        this.bonusProeficiencia += 1;
                        break;
                    case 6:
                        if (caracteristicas.Contains("Camino del Berserker"))
                        {
                            caracteristicas.Add("Rabia desenfrenada");
                        }
                        else
                        {
                            caracteristicas.Add("Aspecto de la bestia");
                        }
                        break;
                    case 7:
                        this.caracteristicas.Add("Instinto salvaje");
                        break;
                    case 8:
                        this.abilityScoreImprovement();
                        break;
                    case 9:
                        this.caracteristicas.Add("Critico brutal");
                        this.bonusProeficiencia += 1;
                        break;
                    case 10:
                        if (caracteristicas.Contains("Camino del Berserker"))
                        {
                            caracteristicas.Add("Presencia intimidante");
                        }
                        else
                        {
                            caracteristicas.Add("Caminante espiritual");
                        }
                        break;
                    case 11:
                        this.caracteristicas.Add("Furia implacable");
                        break;
                    case 12:
                        this.abilityScoreImprovement();
                        break;
                    case 13:
                        this.bonusProeficiencia += 1;
                        break;
                    case 14:
                        if (caracteristicas.Contains("Camino del Berserker"))
                        {
                            caracteristicas.Add("Represalia");
                        }
                        else
                        {
                            caracteristicas.Add("Subtonía Totémica");
                        }
                        break;
                    case 15:
                        this.caracteristicas.Add("Furia persistente");
                        break;
                    case 16:
                        this.abilityScoreImprovement();
                        break;
                    case 17:
                        this.bonusProeficiencia += 1;
                        break;
                    case 18:
                        this.caracteristicas.Add("Fuerza indómita");
                        break;
                    case 19:
                        this.abilityScoreImprovement();
                        break;
                    case 20:
                        this.caracteristicas.Add("Campeon primario");
                        break;
                }
            }
            this.nivel += cantidadNiveles;
        }
    }

    public class Bardo : Clase
    {
        public Bardo(int nivel)
        {
            this.dadoHP = new Dado(1, 8);
            this.nombre = "Bardo";
            this.proeficiencias.Add("Armadura ligera");
            this.proeficiencias.Add("Armas simples");
            this.proeficiencias.Add("Ballesta de mano");
            this.proeficiencias.Add("Espada larga");
            this.proeficiencias.Add("Estoque");
            this.proeficiencias.Add("Espada corta");


            foreach (string instrumento in Instrumento.elegir3DeLista())
            {
                this.proeficiencias.Add(instrumento);
            }
            this.savingThrows.Add("Destreza");
            this.savingThrows.Add("Carisma");
            foreach (string habilidad in Habilidad.elegirDeLista(Habilidad.habilidades, 3))
            {
                this.habilidades.Add(habilidad);
            }
            this.subirDeNivel(nivel);
            //AÑADIR EQUIPAMIENTO
        }

        public override void subirDeNivel(int cantidadNiveles)
        {
            List<string> opciones = new List<string>();
            for (int i = this.nivel; i <= (this.nivel + cantidadNiveles); i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        this.caracteristicas.Add("Lanzamiento de hechizos");
                        this.caracteristicas.Add("Inspiracion de Bardo");
                        this.bonusProeficiencia = 2;
                        this.spellSlots.Add(1, 2);
                        break;
                    case 2:
                        this.caracteristicas.Add("Polivalente");
                        this.caracteristicas.Add("Cancion de descanso");
                        this.spellSlots[1] = 3;
                        break;
                    case 3:
                        opciones = new List<string>()
                        {
                            "Colegio del Conocimiento", "Colegio del Valor"
                        };
                        using (var form = new frmComboEleccion(opciones, "Elija el colegio de su bardo..."))
                        {
                            if (form.DialogResult == DialogResult.OK)
                            {
                                this.caracteristicas.Add(form.eleccion);
                            }
                            else if (form.DialogResult == DialogResult.Cancel)
                            {
                                throw new Exception("Operacion cancelada");
                            }
                            form.Close();
                        }
                        if (caracteristicas.Contains("Colegio del Conocimiento"))
                        {
                            foreach (string habilidad in Habilidad.elegirDeLista(Habilidad.habilidades, 3))
                            {
                                this.habilidades.Add(habilidad);
                            }
                            this.caracteristicas.Add("Palabras hirientes");
                        }
                        else
                        {
                            this.proeficiencias.Add("Armadura media");
                            this.proeficiencias.Add("Escudos");
                            this.proeficiencias.Add("Armas marciales");
                            this.caracteristicas.Add("Inspiracion de combate");
                        }
                        this.caracteristicas.Add("Experto");
                        this.spellSlots[1] = 4;
                        this.spellSlots.Add(2, 2);
                        break;
                    case 4:
                        this.abilityScoreImprovement();
                        this.spellSlots[2] = 3;
                        break;
                    case 5:
                        this.caracteristicas.Add("Fuente de inspiracion");
                        this.bonusProeficiencia += 1;
                        this.spellSlots.Add(3, 2);
                        break;
                    case 6:
                        this.caracteristicas.Add("Contraoda");
                        if (caracteristicas.Contains("Colegio del Conocimiento"))
                        {
                            caracteristicas.Add("Secretos magicos adicionales");
                        }
                        else
                        {
                            caracteristicas.Add("Ataque adicional");
                        }
                        this.spellSlots[3] = 3;
                        break;
                    case 7:
                        this.spellSlots.Add(4, 1);
                        break;
                    case 8:
                        this.abilityScoreImprovement();
                        this.spellSlots[4] = 2;
                        break;
                    case 9:
                        this.bonusProeficiencia += 1;
                        this.spellSlots.Add(5, 1);
                        break;
                    case 10:
                        this.caracteristicas.Add("Secretos magicos");
                        this.spellSlots[5] = 2;
                        break;
                    case 11:
                        this.spellSlots.Add(6, 1);
                        break;
                    case 12:
                        this.abilityScoreImprovement();
                        break;
                    case 13:
                        this.bonusProeficiencia += 1;
                        this.spellSlots.Add(7, 1);
                        break;
                    case 14:
                        if (caracteristicas.Contains("Colegio del Conocimiento"))
                        {
                            caracteristicas.Add("Habilidad incomparable");
                        }
                        else
                        {
                            caracteristicas.Add("Magia de batalla");
                        }
                        break;
                    case 15:
                        this.spellSlots.Add(8, 1);
                        break;
                    case 16:
                        this.abilityScoreImprovement();
                        break;
                    case 17:
                        this.bonusProeficiencia += 1;
                        this.spellSlots.Add(9, 1);
                        break;
                    case 18:
                        break;
                    case 19:
                        this.abilityScoreImprovement();
                        this.spellSlots[6] = 2;
                        break;
                    case 20:
                        this.caracteristicas.Add("Inspiracion superior");
                        this.spellSlots[7] = 2;
                        break;
                }
            }
            this.nivel += cantidadNiveles;
        }


    }

    public class Clerigo : Clase
    {
        public List<string> especializacionesPosibles = new List<string>() { "Dominio del conocimiento", "Dominio de la guerra", "Dominio de la luz", "Dominio de la naturaleza", "Dominio de la tempestad", "Dominio del engaño", "Dominio de la vida" };
        public Clerigo(int nivel)
        {
            this.dadoHP = new Dado(1, 8);
            this.nombre = "Clerigo";
            this.proeficiencias.Add("Armadura ligera");
            this.proeficiencias.Add("Armadura mediana");
            this.proeficiencias.Add("Escudos");
            this.proeficiencias.Add("Armas simples");
            this.savingThrows.Add("Sabiduria");
            this.savingThrows.Add("Carisma");
            List<string> opcionesDeClerigo = new List<string>()
            { "Historia", "Perspicacia", "Medicina", "Persuasion", "Religion"};
            foreach (string habilidad in Habilidad.elegirDeLista(opcionesDeClerigo, 2))
            {
                this.habilidades.Add(habilidad);
            }
            this.subirDeNivel(nivel);
            //AÑADIR EQUIPAMIENTO
        }

        public override void subirDeNivel(int cantidadNiveles)
        {
            for (int i = this.nivel; i <= (this.nivel + cantidadNiveles); i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        this.caracteristicas.Add("Lanzamiento de hechizos");
                        this.SetEspecializacion(especializacionesPosibles);
                        this.bonusProeficiencia = 2;
                        this.spellSlots.Add(1, 2);
                        break;
                    case 2:
                        this.caracteristicas.Add("Canalizar divinidad");
                        this.caracteristicas.Add("CANALIZAR DIVINIDAD: EXPULSAR MUERTOS VIVIENTES");
                        switch (this.GetEspecializacion())
                        {
                            case "Dominio del conocimiento":
                                this.caracteristicas.Add("Bendiciones del conocimiento");
                                this.lenguajes.Add(Lenguajes.elegirLenguaje());
                                this.lenguajes.Add(Lenguajes.elegirLenguaje());
                                List<string> _opciones = new List<string>()
                                { "Arcano", "Historia", "Naturaleza", "Religion"};
                                foreach (string habilidad in Habilidad.elegirDeLista(_opciones, 2))
                                {
                                    this.habilidades.Add(habilidad);
                                }
                                this.caracteristicas.Add("CANALIZAR DIVINIDAD: Conocimiento de las edades");
                                break;

                            case "Dominio de la vida":
                                this.proeficiencias.Add("Armadura pesada");
                                this.caracteristicas.Add("Discipulo de la vida");
                                this.caracteristicas.Add("CANALIZAR DIVINIDAD: Preservar vida");
                                break;
                            case "Dominio de la luz":
                                this.caracteristicas.Add("Truco adicional");
                                this.caracteristicas.Add("Fulgor protector");
                                this.caracteristicas.Add("CANALIZAR DIVINIDAD: Resplandor del alva");
                                break;
                            case "Dominio de la naturaleza":
                                this.caracteristicas.Add("CANALIZAR DIVINIDAD: Hechizar animales y plantas");
                                break;
                            case "Dominio de la tempestad":
                                this.caracteristicas.Add("CANALIZAR DIVINIDAD: Ira destructiva");
                                break;
                            case "Dominio del engaño":
                                this.caracteristicas.Add("CANALIZAR DIVINIDAD: Invocar duplicidad");
                                break;
                            case "Dominio de la guerra ":
                                this.caracteristicas.Add("CANALIZAR DIVINIDAD: Impacto guiado");
                                break;

                        }
                        this.spellSlots[1] = 3;
                        break;
                    case 3:
                        this.spellSlots[1] = 4;
                        this.spellSlots.Add(2, 2);
                        break;
                    case 4:
                        this.abilityScoreImprovement();
                        this.spellSlots[2] = 3;
                        break;
                    case 5:
                        this.bonusProeficiencia += 1;
                        this.spellSlots.Add(3, 2);
                        break;
                    case 6:
                        this.spellSlots[3] = 3;
                        break;
                    case 7:
                        this.spellSlots.Add(4, 1);
                        break;
                    case 8:
                        this.abilityScoreImprovement();
                        this.spellSlots[4] = 2;
                        break;
                    case 9:
                        this.bonusProeficiencia += 1;
                        this.spellSlots.Add(5, 1);
                        break;
                    case 10:
                        this.caracteristicas.Add("Intervencion divina");
                        this.spellSlots[5] = 2;
                        break;
                    case 11:
                        this.spellSlots.Add(6, 1);
                        break;
                    case 12:
                        this.abilityScoreImprovement();
                        break;
                    case 13:
                        this.bonusProeficiencia += 1;
                        this.spellSlots.Add(7, 1);
                        break;
                    case 14:
                        break;
                    case 15:
                        this.spellSlots.Add(8, 1);
                        break;
                    case 16:
                        this.abilityScoreImprovement();
                        break;
                    case 17:
                        this.bonusProeficiencia += 1;
                        this.spellSlots.Add(9, 1);
                        break;
                    case 18:
                        break;
                    case 19:
                        this.abilityScoreImprovement();
                        this.spellSlots[6] = 2;
                        break;
                    case 20:
                        this.caracteristicas.Add("Intervencion divina mejorada");
                        this.spellSlots[7] = 2;
                        break;
                }
            }
            this.nivel += cantidadNiveles;
        }


    }

    public class Druida : Clase
    {
        public List<string> especializacionesPosibles = new List<string>()
    {
        "Circulo de la tierra", "Circulo de la luna"
    };
        public Druida(int nivel)
        {
            this.dadoHP = new Dado(1, 8);
            this.nombre = "Druida";
            this.proeficiencias.Add("Armadura ligera");
            this.proeficiencias.Add("Armadura mediana");
            this.proeficiencias.Add("Escudos");
            this.proeficiencias.Add("Bastones");
            this.proeficiencias.Add("Cimitarras");
            this.proeficiencias.Add("Clavas");
            this.proeficiencias.Add("Dagas");
            this.proeficiencias.Add("Dardos");
            this.proeficiencias.Add("Hoces");
            this.proeficiencias.Add("Hondas");
            this.proeficiencias.Add("Lanzas");
            this.proeficiencias.Add("Mazas");
            this.proeficiencias.Add("Kit de herboristeria");

            this.savingThrows.Add("Sabiduria");
            this.savingThrows.Add("Inteligencia");
            Console.WriteLine("Primer log");
            List<string> opcionesDeDruida = new List<string>()
            { "Arcano", "Perspicacia", "Medicina", "Naturaleza", "Percepcion", "Religion", "Supervivencia", "Manejo de animales"};
            foreach (string habilidad in Habilidad.elegirDeLista(opcionesDeDruida, 2))
            {
                this.habilidades.Add(habilidad);
            }
            Console.WriteLine("Segundo log");
            this.subirDeNivel(nivel);
            //AÑADIR EQUIPAMIENTO
        }

        public override void subirDeNivel(int cantidadNiveles)
        {
            for (int i = this.nivel; i <= (this.nivel + cantidadNiveles); i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        this.caracteristicas.Add("Lanzamiento de hechizos");
                        this.lenguajes.Add("Druidico");
                        this.bonusProeficiencia = 2;
                        this.spellSlots.Add(1, 2);
                        break;
                    case 2:
                        this.SetEspecializacion(especializacionesPosibles);
                        this.caracteristicas.Add("Forma salvaje");
                        switch (this.GetEspecializacion())
                        {
                            case "Circulo de la tierra":
                                this.caracteristicas.Add("Truco adicional");
                                this.caracteristicas.Add("Recuperacion natural");
                                break;

                            case "Circulo de la luna":
                                this.proeficiencias.Add("Forma salvaje de combate");
                                this.caracteristicas.Add("Formas del circulo");
                                break;

                        }
                        this.spellSlots[1] = 3;
                        break;
                    case 3:
                        if(this.GetEspecializacion() == "Circulo de la tierra")
                        {
                            this.caracteristicas.Add("Conjuros del circulo");
                        }
                        this.spellSlots[1] = 4;
                        this.spellSlots.Add(2, 2);
                        break;
                    case 4:
                        this.abilityScoreImprovement();
                        this.spellSlots[2] = 3;
                        break;
                    case 5:
                        this.bonusProeficiencia += 1;
                        this.spellSlots.Add(3, 2);
                        break;
                    case 6:
                        switch (this.GetEspecializacion())
                        {
                            case "Circulo de la tierra":
                                this.caracteristicas.Add("Zancada forestal");
                                break;

                            case "Circulo de la luna":
                                this.proeficiencias.Add("Golpe primitivo");
                                break;
                        }
                        this.spellSlots[3] = 3;
                        break;
                    case 7:
                        this.spellSlots.Add(4, 1);
                        break;
                    case 8:
                        this.abilityScoreImprovement();
                        this.spellSlots[4] = 2;
                        break;
                    case 9:
                        this.bonusProeficiencia += 1;
                        this.spellSlots.Add(5, 1);
                        break;
                    case 10:
                        switch (this.GetEspecializacion())
                        {
                            case "Circulo de la tierra":
                                this.caracteristicas.Add("Proteccion de la naturaleza");
                                break;

                            case "Circulo de la luna":
                                this.proeficiencias.Add("Forma salvaje elemental");
                                break;

                        }
                        this.spellSlots[5] = 2;
                        break;
                    case 11:
                        this.spellSlots.Add(6, 1);
                        break;
                    case 12:
                        this.abilityScoreImprovement();
                        break;
                    case 13:
                        this.bonusProeficiencia += 1;
                        this.spellSlots.Add(7, 1);
                        break;
                    case 14:
                        switch (this.GetEspecializacion())
                        {
                            case "Circulo de la tierra":
                                this.caracteristicas.Add("Santuario de la naturaleza");
                                break;

                            case "Circulo de la luna":
                                this.proeficiencias.Add("Mil formas");
                                break;

                        }
                        break;
                    case 15:
                        this.spellSlots.Add(8, 1);
                        break;
                    case 16:
                        this.abilityScoreImprovement();
                        break;
                    case 17:
                        this.bonusProeficiencia += 1;
                        this.spellSlots.Add(9, 1);
                        break;
                    case 18:
                        this.caracteristicas.Add("Cuerpo eterno");
                        this.caracteristicas.Add("Conjuros bestiales");
                        break;
                    case 19:
                        this.abilityScoreImprovement();
                        this.spellSlots[6] = 2;
                        break;
                    case 20:
                        this.caracteristicas.Add("Archidruida");
                        this.spellSlots[7] = 2;
                        break;
                }
                Console.WriteLine("I = " + i.ToString());
            }
            this.nivel += cantidadNiveles;
        }
    }

    public class Guerrero : Clase
    {
        public List<string> especializacionesPosibles = new List<string>()
        {
            "Caballero arcano", "Campeon", "Maestro de batalla"
        };
        public List<string> estilosDeCombate = new List<string>()
        {
            "A distancia", "Defensa", "Duelista", "Lucha con arma a dos manos", "Proteccion", "Lucha con dos armas"
        };
        public Guerrero(int nivel)
        {
            this.dadoHP = new Dado(1, 10);
            this.nombre = "Guerrero";
            this.proeficiencias.Add("Armadura ligera");
            this.proeficiencias.Add("Armadura mediana");
            this.proeficiencias.Add("Armadura pesada");
            this.proeficiencias.Add("Escudos");
            this.proeficiencias.Add("Armas simples");
            this.proeficiencias.Add("Armas marciales");

            this.savingThrows.Add("Fuerza");
            this.savingThrows.Add("Constitucion");
            List<string> opcionesDeGuerrero = new List<string>()
            { "Acrobacias", "Atletimo", "Perspicacia", "Historia", "Intimidacion", "Manejo de animales", "Percepcion", "Supervivencia"};
            foreach (string habilidad in Habilidad.elegirDeLista(opcionesDeGuerrero, 2))
            {
                this.habilidades.Add(habilidad);
            }
            this.subirDeNivel(nivel);
            //AÑADIR EQUIPAMIENTO
        }

        public void estiloDeCombate()
        {
            using (var form = new frmComboEleccion(estilosDeCombate, "Elija un estilo de combate para su guerrero..."))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    this.caracteristicas.Add("Estilo de combate: " + form.eleccion);
                }
                else if (form.DialogResult == DialogResult.Cancel)
                {
                    throw new Exception("Operacion cancelada");
                }
                form.Close();
            }
        }

        public override void subirDeNivel(int cantidadNiveles)
        {
            for (int i = this.nivel; i <= (this.nivel + cantidadNiveles); i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        this.estiloDeCombate();
                        this.caracteristicas.Add("Nuevas energias");
                        this.bonusProeficiencia = 2;
                        break;
                    case 2:
                        this.SetEspecializacion(especializacionesPosibles);
                        this.caracteristicas.Add("Oleada de accion");
                        break;
                    case 3:
                        switch (this.GetEspecializacion())
                        {
                            case "Caballero arcano":
                                this.caracteristicas.Add("Lanzamiento de hechizos");
                                this.spellSlots.Add(1, 2);
                                this.caracteristicas.Add("Ligadura de arma");
                                break;
                            case "Campeon":
                                this.caracteristicas.Add("Critico mejorado");
                                break;
                            case "Maestro de batalla":
                                this.caracteristicas.Add("Superioridad en combate");
                                this.caracteristicas.Add("Estudiante de guerra");
                                break;
                        }
                        break;
                    case 4:
                        this.abilityScoreImprovement();
                        if(this.GetEspecializacion() == "Caballero arcano")
                        {
                            this.spellSlots[1] = 3;
                        }
                        break;
                    case 5:
                        this.caracteristicas.Add("Ataque extra");
                        this.bonusProeficiencia += 1;
                        break;
                    case 6:
                        this.abilityScoreImprovement();
                        break;
                    case 7:
                        switch (this.GetEspecializacion())
                        {
                            case "Caballero arcano":
                                this.spellSlots[1] = 4;
                                this.spellSlots.Add(2, 2);
                                this.caracteristicas.Add("Magia de guerra");
                                break;
                            case "Campeon":
                                this.caracteristicas.Add("Atleta destacado");
                                break;
                            case "Maestro de batalla":
                                this.caracteristicas.Add("Conoce a tu enemigo");
                                break;
                        }
                        break;
                    case 8:
                        this.abilityScoreImprovement();
                        break;
                    case 9:
                        this.caracteristicas.Add("Indomable");
                        this.bonusProeficiencia += 1;
                        break;
                    case 10:
                        switch (this.GetEspecializacion())
                        {
                            case "Caballero arcano":
                                this.spellSlots[2] = 3;
                                this.caracteristicas.Add("Golpe sobrenatural");
                                break;
                            case "Campeon":
                                this.estiloDeCombate();
                                break;
                            case "Maestro de batalla":
                                this.caracteristicas.Add("Superioridad en combate mejorada");
                                break;
                        }
                        break;
                    case 11:
                        break;
                    case 12:
                        this.abilityScoreImprovement();
                        break;
                    case 13:
                        this.bonusProeficiencia += 1;
                        if(this.GetEspecializacion() == "Caballero arcano")
                        {
                            this.spellSlots.Add(3, 2);
                        }
                        break;
                    case 14:
                        this.abilityScoreImprovement();
                        break;
                    case 15:
                        switch (this.GetEspecializacion())
                        {
                            case "Caballero arcano":
                                this.caracteristicas.Add("Carga arcana");
                                break;
                            case "Campeon":
                                this.caracteristicas.Add("Critico superior");
                                break;
                            case "Maestro de batalla":
                                this.caracteristicas.Add("Implacable");
                                break;
                        }
                        break;
                    case 16:
                        this.abilityScoreImprovement();
                        if (this.GetEspecializacion() == "Caballero arcano")
                        {
                            this.spellSlots[3] = 3;
                        }
                        break;
                    case 17:
                        this.bonusProeficiencia += 1;
                        break;
                    case 18:
                        switch (this.GetEspecializacion())
                        {
                            case "Caballero arcano":
                                this.caracteristicas.Add("Magia de guerra mejorada");
                                break;
                            case "Campeon":
                                this.caracteristicas.Add("Superviviente");
                                break;
                            case "Maestro de batalla":
                                //Cambio de dado de superioridad
                                break;
                        }
                        break;
                    case 19:
                        this.abilityScoreImprovement();
                        if (this.GetEspecializacion() == "Caballero arcano")
                        {
                            this.spellSlots.Add(4, 1);
                        }
                        break;
                    case 20:
                        //Mejora de ataque extra
                        break;
                }
            }
            this.nivel += cantidadNiveles;
        }
    }

    public class Monje : Clase
    {
        public List<string> especializacionesPosibles = new List<string>()
        {
            "Camino de la mano abierta", "Camino de la sombra", "Camino de los cuatro elementos"
        };

        public int kiMaximo = 0;
        public int ki = 0;
        public Dado arteMarcial = new Dado(0, 0);
        public Monje(int nivel)
        {
            this.dadoHP = new Dado(1, 8);
            this.nombre = "Monje";
            this.proeficiencias.Add("Armas simples");
            this.proeficiencias.Add("Espada corta");

            this.savingThrows.Add("Fuerza");
            this.savingThrows.Add("Destreza");
            List<string> opcionesDeGuerrero = new List<string>()
            { "Acrobacias", "Atletimo", "Perspicacia", "Historia", "Religion", "Sigilo"};
            foreach (string habilidad in Habilidad.elegirDeLista(opcionesDeGuerrero, 2))
            {
                this.habilidades.Add(habilidad);
            }
            this.subirDeNivel(nivel);
            //AÑADIR EQUIPAMIENTO
        }

        public override void subirDeNivel(int cantidadNiveles)
        {
            for (int i = this.nivel; i <= (this.nivel + cantidadNiveles); i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        this.caracteristicas.Add("Defensa sin armadura");
                        this.caracteristicas.Add("Artes marciales");
                        this.arteMarcial = new Dado(1, 4);
                        this.bonusProeficiencia = 2;
                        break;
                    case 2:
                        this.caracteristicas.Add("Ki");
                        this.caracteristicas.Add("Movimiento sin armadura");
                        break;
                    case 3:
                        this.SetEspecializacion(especializacionesPosibles);
                        switch (this.GetEspecializacion())
                        {
                            case "Camino de la mano abierta":
                                this.caracteristicas.Add("Tecbuca de la mano abierta");
                                break;
                            case "Camino de la sombra":
                                this.caracteristicas.Add("Artes sombrias");
                                break;
                            case "Camino de los cuatro elementos":
                                this.caracteristicas.Add("Discipulo de los elementos");
                                break;
                        }
                        this.caracteristicas.Add("Desviar proyectiles");
                        break;
                    case 4:
                        this.abilityScoreImprovement();
                        this.caracteristicas.Add("Caida lenta");
                        break;
                    case 5:
                        this.caracteristicas.Add("Ataque extra");
                        this.caracteristicas.Add("Golpe aturdidor");
                        this.arteMarcial = new Dado(1, 6);
                        this.bonusProeficiencia += 1;
                        break;
                    case 6:
                        this.caracteristicas.Add("Golpes potenciados con ki");
                        switch (this.GetEspecializacion())
                        {
                            case "Camino de la mano abierta":
                                this.caracteristicas.Add("Integridad del cuerpo");
                                break;
                            case "Camino de la sombra":
                                this.caracteristicas.Add("Paso sombrio");
                                break;
                            case "Camino de los cuatro elementos":
                                break;
                        }
                        break;
                    case 7:
                        this.caracteristicas.Add("Evasion");
                        this.caracteristicas.Add("Quietud de la menta");
                        break;
                    case 8:
                        this.abilityScoreImprovement();
                        break;
                    case 9:
                        this.bonusProeficiencia += 1;
                        break;
                    case 10:
                        this.caracteristicas.Add("Pureza del cuerpo");
                        break;
                    case 11:
                        this.arteMarcial = new Dado (1, 8);
                        switch (this.GetEspecializacion())
                        {
                            case "Camino de la mano abierta":
                                this.caracteristicas.Add("Tranquilidad");
                                break;
                            case "Camino de la sombra":
                                this.caracteristicas.Add("Capa de sombras");
                                break;
                            case "Camino de los cuatro elementos":
                                break;
                        }
                        break;
                    case 12:
                        this.abilityScoreImprovement();
                        break;
                    case 13:
                        this.bonusProeficiencia += 1;
                        this.caracteristicas.Add("Lengua del sol y la luna");
                        break;
                    case 14:
                        this.abilityScoreImprovement();
                        this.caracteristicas.Add("Alma diamantina");
                        break;
                    case 15:
                        this.caracteristicas.Add("Cuerpo imperecedero");
                        break;
                    case 16:
                        this.abilityScoreImprovement();
                        break;
                    case 17:
                        this.bonusProeficiencia += 1;
                        this.arteMarcial = new Dado(1, 10);
                        switch (this.GetEspecializacion())
                        {
                            case "Camino de la mano abierta":
                                this.caracteristicas.Add("Palma temblorosa");
                                break;
                            case "Camino de la sombra":
                                this.caracteristicas.Add("Oportunista");
                                break;
                            case "Camino de los cuatro elementos":
                                break;
                        }
                        break;
                    case 18:
                        this.caracteristicas.Add("Cuerpo vacio");

                        break;
                    case 19:
                        this.abilityScoreImprovement();
                        break;
                    case 20:
                        this.caracteristicas.Add("Perfeccion de uno mismo");
                        break;
                }
                this.kiMaximo++;
            }
            this.nivel += cantidadNiveles;
        }
    }

    public class Paladin : Clase
    {
        public List<string> especializacionesPosibles = new List<string>()
        {
            "Juramente de devocion", "Juramento de los ancestros", "Juramento de venganza"
        };

        public Paladin(int nivel)
        {
            this.dadoHP = new Dado(1, 10);
            this.nombre = "Paladin";
            this.proeficiencias.Add("Armadura ligera");
            this.proeficiencias.Add("Armadura mediana");
            this.proeficiencias.Add("Armadura pesada");
            this.proeficiencias.Add("Escudos");
            this.proeficiencias.Add("Armas simples");
            this.proeficiencias.Add("Armas marciales");

            this.savingThrows.Add("Sabiduria");
            this.savingThrows.Add("Carisma");
            List<string> opcionesDeGuerrero = new List<string>()
            { "Atletimo", "Perspicacia", "Intimidacion", "Medicina","Persuasion","Religion"};
            foreach (string habilidad in Habilidad.elegirDeLista(opcionesDeGuerrero, 2))
            {
                this.habilidades.Add(habilidad);
            }
            this.subirDeNivel(nivel);
            //AÑADIR EQUIPAMIENTO
        }

        public List<string> estilosDeCombate = new List<string>()
        {
            "A distancia", "Defensa", "Duelista", "Lucha con arma a dos manos", "Proteccion", "Lucha con dos armas"
        };

        public void estiloDeCombate()
        {
            using (var form = new frmComboEleccion(estilosDeCombate, "Elija un estilo de combate para su guerrero..."))
            {
                if (form.DialogResult == DialogResult.OK)
                {
                    this.caracteristicas.Add("Estilo de combate: " + form.eleccion);
                }
                else if (form.DialogResult == DialogResult.Cancel)
                {
                    throw new Exception("Operacion cancelada");
                }
                form.Close();
            }
        }

        public override void subirDeNivel(int cantidadNiveles)
        {
            for (int i = this.nivel; i <= (this.nivel + cantidadNiveles); i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        this.caracteristicas.Add("Imposicion de manos");
                        this.caracteristicas.Add("Sentido divino");
                        this.bonusProeficiencia = 2;
                        break;
                    case 2:
                        this.estiloDeCombate();
                        this.caracteristicas.Add("Lanzamiento de hechizos");
                        this.caracteristicas.Add("Castigo divino");
                        this.spellSlots.Add(1, 2);
                        break;
                    case 3:
                        this.SetEspecializacion(especializacionesPosibles);
                        switch (this.GetEspecializacion())
                        {
                            case "Juramente de devocion":
                                this.caracteristicas.Add("Canalizar divinidad: Devocion");
                                break;
                            case "Juramento de los ancestros":
                                this.caracteristicas.Add("Canalizar divinidad: Ancestros");
                                break;
                            case "Juramento de venganza":
                                this.caracteristicas.Add("Canalizar divinidad: Venganza");
                                break;
                        }
                        this.caracteristicas.Add("Salud divina");
                        this.spellSlots[1] = 3;
                        break;
                    case 4:
                        this.abilityScoreImprovement();
                        break;
                    case 5:
                        this.caracteristicas.Add("Ataque extra");
                        this.spellSlots.Add(2, 2);
                        this.spellSlots[1] = 4;
                        this.bonusProeficiencia += 1;
                        break;
                    case 6:
                        this.caracteristicas.Add("Aura de proteccion");
                        break;
                    case 7:
                        switch (this.GetEspecializacion())
                        {
                            case "Juramente de devocion":
                                this.caracteristicas.Add("Aura de devocion");
                                break;
                            case "Juramento de los ancestros":
                                this.caracteristicas.Add("Aura de custodia");
                                break;
                            case "Juramento de venganza":
                                this.caracteristicas.Add("Vengador implacable");
                                break;
                        }
                        this.spellSlots[2] = 3;
                        break;
                    case 8:
                        this.abilityScoreImprovement();
                        break;
                    case 9:
                        this.bonusProeficiencia += 1;
                        this.spellSlots.Add(3, 2);
                        break;
                    case 10:
                        this.caracteristicas.Add("Aura de coraje");
                        break;
                    case 11:
                        this.caracteristicas.Add("Castigo divino mejorado");
                        this.spellSlots[3] = 3;
                        break;
                    case 12:
                        this.abilityScoreImprovement();
                        break;
                    case 13:
                        this.bonusProeficiencia += 1;
                        this.spellSlots.Add(4, 1);
                        break;
                    case 14:
                        this.caracteristicas.Add("Toque de purificacion");
                        break;
                    case 15:
                        switch (this.GetEspecializacion())
                        {
                            case "Juramente de devocion":
                                this.caracteristicas.Add("Pureza de espiritu");
                                break;
                            case "Juramento de los ancestros":
                                this.caracteristicas.Add("Centinela imperecedero");
                                break;
                            case "Juramento de venganza":
                                this.caracteristicas.Add("Alma de venganza");
                                break;
                        }
                        this.spellSlots[4] = 2;
                        break;
                    case 16:
                        this.abilityScoreImprovement();
                        break;
                    case 17:
                        this.bonusProeficiencia += 1;
                        this.spellSlots.Add(5, 1);
                        break;
                    case 18:
                        //mejora de auras
                        break;
                    case 19:
                        this.abilityScoreImprovement();
                        this.spellSlots[5] = 2;
                        break;
                    case 20:
                        switch (this.GetEspecializacion())
                        {
                            case "Juramente de devocion":
                                this.caracteristicas.Add("Aura sagrada");
                                break;
                            case "Juramento de los ancestros":
                                this.caracteristicas.Add("Campeon ancestral");
                                break;
                            case "Juramento de venganza":
                                this.caracteristicas.Add("Angel vengador");
                                break;
                        }
                        break;
                }
            }
            this.nivel += cantidadNiveles;
        }
    }

    public class Explorador : Clase
    {
        public List<string> especializacionesPosibles = new List<string>()
        {
            "Cazador", "Señor de las bestias"
        };

        public Explorador(int nivel)
        {
            this.dadoHP = new Dado(1, 10);
            this.nombre = "Explorador";
            this.proeficiencias.Add("Armadura ligera");
            this.proeficiencias.Add("Armadura mediana");
            this.proeficiencias.Add("Escudos");
            this.proeficiencias.Add("Armas simples");
            this.proeficiencias.Add("Armas marciales");

            this.savingThrows.Add("Fuerza");
            this.savingThrows.Add("Destreza");
            List<string> opcionesDeGuerrero = new List<string>()
            { "Atletimo", "Perspicacia", "Investigacion","Manejo de animales", "Naturaleza", "Percepcion", "Sigilo", "Supervivencia"};
            foreach (string habilidad in Habilidad.elegirDeLista(opcionesDeGuerrero, 3))
            {
                this.habilidades.Add(habilidad);
            }
            this.subirDeNivel(nivel);
            //AÑADIR EQUIPAMIENTO
        }

        public List<string> estilosDeCombate = new List<string>()
        {
            "A distancia", "Defensa", "Duelista", "Lucha con dos armas"
        };

        public void estiloDeCombate()
        {
            using (var form = new frmComboEleccion(estilosDeCombate, "Elija un estilo de combate para su explorador..."))
            {
                if (form.DialogResult == DialogResult.OK)
                {
                    this.caracteristicas.Add("Estilo de combate: " + form.eleccion);
                }
                else if (form.DialogResult == DialogResult.Cancel)
                {
                    throw new Exception("Operacion cancelada");
                }
                form.Close();
            }
        }

        public override void subirDeNivel(int cantidadNiveles)
        {
            for (int i = this.nivel; i <= (this.nivel + cantidadNiveles); i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        this.caracteristicas.Add("Enemigo predilecto");
                        this.caracteristicas.Add("Explorador de lo natural");
                        this.bonusProeficiencia = 2;
                        break;
                    case 2:
                        this.estiloDeCombate();
                        this.caracteristicas.Add("Lanzamiento de hechizos");
                        this.spellSlots.Add(1, 2);
                        break;
                    case 3:
                        this.SetEspecializacion(especializacionesPosibles);
                        switch (this.GetEspecializacion())
                        {
                            case "Cazador":
                                this.caracteristicas.Add("Presa del cazador");
                                break;
                            case "Señor de las bestias":
                                this.caracteristicas.Add("Compañero animal");
                                break;
                        }
                        this.caracteristicas.Add("Conciencia primitiva");
                        this.spellSlots[1] = 3;
                        break;
                    case 4:
                        this.abilityScoreImprovement();
                        break;
                    case 5:
                        this.caracteristicas.Add("Ataque extra");
                        this.spellSlots.Add(2, 2);
                        this.spellSlots[1] = 4;
                        this.bonusProeficiencia += 1;
                        break;
                    case 6:
                        break;
                    case 7:
                        switch (this.GetEspecializacion())
                        {
                            case "Cazador":
                                this.caracteristicas.Add("Tacticas defensivas");
                                break;
                            case "Señor de las bestias":
                                this.caracteristicas.Add("Entrenamiento excepcional");
                                break;
                        }
                        this.spellSlots[2] = 3;
                        break;
                    case 8:
                        this.abilityScoreImprovement();
                        this.caracteristicas.Add("Zancada forestal");
                        break;
                    case 9:
                        this.bonusProeficiencia += 1;
                        this.spellSlots.Add(3, 2);
                        break;
                    case 10:
                        this.caracteristicas.Add("Ocultarse a plena vista");
                        break;
                    case 11:
                        switch (this.GetEspecializacion())
                        {
                            case "Cazador":
                                this.caracteristicas.Add("Ataque multiple");
                                break;
                            case "Señor de las bestias":
                                this.caracteristicas.Add("Furia bestial");
                                break;
                        }
                        this.spellSlots[3] = 3;
                        break;
                    case 12:
                        this.abilityScoreImprovement();
                        break;
                    case 13:
                        this.bonusProeficiencia += 1;
                        this.spellSlots.Add(4, 1);
                        break;
                    case 14:
                        this.caracteristicas.Add("Esfumarse");
                        break;
                    case 15:
                        switch (this.GetEspecializacion())
                        {
                            case "Cazador":
                                this.caracteristicas.Add("Defensa superior del cazador");
                                break;
                            case "Señor de las bestias":
                                this.caracteristicas.Add("Compartir conjuros");
                                break;
                        }
                        this.spellSlots[4] = 2;
                        break;
                    case 16:
                        this.abilityScoreImprovement();
                        break;
                    case 17:
                        this.bonusProeficiencia += 1;
                        this.spellSlots.Add(5, 1);
                        break;
                    case 18:
                        this.caracteristicas.Add("Sentidos salvajes");
                        break;
                    case 19:
                        this.abilityScoreImprovement();
                        this.spellSlots[5] = 2;
                        break;
                    case 20:
                        this.caracteristicas.Add("Asesino de enemigos");
                        break;
                }
            }
            this.nivel += cantidadNiveles;
        }
    }
}

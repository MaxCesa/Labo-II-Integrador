namespace PrimerParcialLabo_Intento2
{
    public class Habilidad
    {
        public bool proeficiente { get; set; }
        public int valor { get; set; }
        public Habilidad() { }
        public Habilidad (bool esProeficiente, int valor)
        {
            this.proeficiente =esProeficiente; this.valor =valor;
        }
        public static List<string> habilidades = new List<string>()
        {
            "Atletismo",
            "Acrobacias",
            "Juego de manos",
            "Sigilo",
            "Arcano",
            "Historia",
            "Investigacion",
            "Naturaleza",
            "Religión",
            "Manejo de animales",
            "Medicina",
            "Percepcion",
            "Perspicacia",
            "Supervivencia",
            "Engaño",
            "Intimidacion",
            "Interpretacion",
            "Persuasion"
        };

        public static string elegirHabilidad()
        {
            string eleccion = "";
            using (var form = new frmComboEleccion(Habilidad.habilidades, "Seleccione un atributo a mejorar..."))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    eleccion = form.eleccion;

                }
                form.Close();

            }
            return eleccion;
        }

        public static List<string> elegirDeLista(List<string> lista, int cantidad)
        {
            List<string> retorno = new List<string>();
            using (var form = new frmListEleccion(lista, ("Elija habilidades para ser proeficiente (Maximo " + cantidad.ToString() + ")."), cantidad))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    retorno = form.eleccion;
                }
                else if (form.DialogResult == DialogResult.Cancel)
                {
                    throw new Exception("Operacion cancelada");
                }
                form.Close();
            }
            return retorno;
        }

        public static string atributoAsociado(string habilidad)
        {
            string retorno = "-";
            switch(habilidad)
            {
                case "Atletismo":
                    retorno = "Fuerza";
                    break;
                case "Acrobacias":
                case "Juego de manos":
                case "Sigilo":
                    retorno = "Destreza";
                    break;
                case "Arcano":
                case "Historia":
                case "Investigacion":
                case "Naturaleza":
                case "Religión":
                    retorno = "Inteligencia";
                    break;
                case "Manejo de animales":
                case "Medicina":
                case "Percepcion":
                case "Perspicacia":
                case "Supervivencia":
                    retorno = "Sabiduria";
                    break;
                case "Engaño":
                case "Intimidacion":
                case "Interpretacion":
                case "Persuasion":
                    retorno = "Carisma";
                    break;
            }
            return retorno;
        }
    }
}

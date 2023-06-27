using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    public delegate int OrdenarPersonajes(Personaje x, Personaje y);
    public delegate void actualizarDeAdmin(ListaUsuarios usuarios, Configuration config);
    public delegate void addPersonaje(Personaje personaje);
}

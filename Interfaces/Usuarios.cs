using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2.Interfaces
{
    internal interface IUsuarios
    {
        public static Task<List<Usuario>> GetUsuarios()
        {
            throw new NotImplementedException();
        }

        public static void SetUsuarios(List<Usuario> usuarios)
        {
            throw new NotImplementedException();
        }
    }
}

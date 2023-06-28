using Google.Cloud.Firestore;
using PrimerParcialLabo_Intento2.Interfaces;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2.DB
{
    internal class FirebaseHandler : IUsuarios
    {
        static string projectId = "tp-integrador-prog2";
        async public static Task<WriteResult> AgregarPersonaje(Personaje personaje)
        {
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "D:\\Downloads\\tp-integrador-prog2-firebase-adminsdk-yicqq-68208ce954.json");
            FirestoreDb db = FirestoreDb.Create(projectId);

            var docRef = db.Collection("personajes").Document(personaje.nombre + "-" + personaje.dueño);

            var personajeJson = new PersonajeFirestore(personaje);
            var rta = await docRef.SetAsync(personajeJson);
            return rta;
        }

        async public static void ExportarPersonajes(ListaPersonajes personajeList)
        {
            foreach(Personaje personaje in personajeList)
            {
                await AgregarPersonaje(personaje);
            }
        }
        async public static Task<ListaPersonajes> ImportarPersonajes(Usuario dueño)
        {
            ListaPersonajes retorno = new ListaPersonajes();
            try
            {
                System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "D:\\Downloads\\tp-integrador-prog2-firebase-adminsdk-yicqq-68208ce954.json");
                FirestoreDb db = FirestoreDb.Create(projectId);
                CollectionReference personajesRef = db.Collection("personajes");
                Query query = personajesRef.WhereEqualTo("dueño", dueño.ToString());
                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
                string valor;
                foreach (DocumentSnapshot personajeFirestore in querySnapshot.Documents)
                {
                    personajeFirestore.TryGetValue<string>("personaje", out valor);
                    retorno.Add(Personaje.DeserializarJson<Personaje>(valor));
                }
            }
            catch (Exception)
            {

                throw new Exception("Error en conexion con Firestore");
            }
            return retorno;
        }

        async public static void SetUsuarios(ListaUsuarios usuarios)
        {
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "D:\\Downloads\\tp-integrador-prog2-firebase-adminsdk-yicqq-68208ce954.json");
            FirestoreDb db = FirestoreDb.Create(projectId);

            
            foreach (Usuario usuario in usuarios)
            {
                var docRef = db.Collection("usuarios").Document(usuario.id.ToString());
                var usuarioJson = new UsuarioFirestore(usuario);
                await docRef.SetAsync(usuarioJson);
            }
        }

        async public static Task<ListaUsuarios> GetUsuarios()
        {
            ListaUsuarios retorno = new ListaUsuarios();
            try
            {
                System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "D:\\Downloads\\tp-integrador-prog2-firebase-adminsdk-yicqq-68208ce954.json");
                FirestoreDb db = FirestoreDb.Create(projectId);
                CollectionReference usuariosRef = db.Collection("usuarios");
                Query query = usuariosRef;
                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
                string usernameAux;
                string contraseñaAux;
                string tipoAux;
                int idAux;
                foreach (DocumentSnapshot personajeFirestore in querySnapshot.Documents)
                {
                    personajeFirestore.TryGetValue<string>("tipo", out tipoAux);
                    personajeFirestore.TryGetValue("username", out usernameAux);
                    personajeFirestore.TryGetValue("contraseña", out contraseñaAux);
                    int.TryParse(personajeFirestore.Id, out idAux);
                    switch (tipoAux)
                    {
                        case "SuperAdmin":
                            retorno.Add(new SuperAdmin(idAux, usernameAux, contraseñaAux));
                            break;
                        case "Jugador":
                            retorno.Add(new Jugador(idAux, usernameAux, contraseñaAux)); ;
                            break;
                        default: throw new Exception("Error de tipo de Usuario en DB");
                    }
                }
            }
            catch (Exception)
            {

                throw new Exception("Error en conexion con Firestore");
            }
            return retorno;
        }
        
    }


    [FirestoreData]
    class PersonajeFirestore
    {
        [FirestoreProperty]
        public string nombre { set; get; }
        [FirestoreProperty]
        public string dueño { set; get; }
        [FirestoreProperty]
        public string personaje { set; get; }
        public PersonajeFirestore(Personaje personaje)
        {
            this.personaje = personaje.SerializarJson();
            this.nombre = personaje.nombre;
            this.dueño = personaje.dueño;
        }

        public PersonajeFirestore()
        {
            this.personaje = string.Empty;
            this.nombre = string.Empty;
            this.dueño = string.Empty;
        }
    }

    [FirestoreData]
    class UsuarioFirestore
    {
        [FirestoreProperty]
        int id { set; get; }
        [FirestoreProperty]
        string username { set; get; }
        [FirestoreProperty]
        string contraseña { set; get; }
        [FirestoreProperty]
        string tipo { set; get; }
        public UsuarioFirestore()
        {
            this.username = string.Empty;
            this.tipo = string.Empty;
            this.contraseña = string.Empty;
        }

        public UsuarioFirestore(Usuario usuario)
        {
            this.username = usuario.username;
            this.tipo = usuario.tipo;
            this.contraseña = usuario.contraseña;
        }
    }
}

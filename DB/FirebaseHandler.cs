using Google.Cloud.Firestore;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2.DB
{
    internal class FirebaseHandler
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

        async public static void ExportarPersonajes(List<Personaje> personajeList)
        {
            foreach(Personaje personaje in personajeList)
            {
                await AgregarPersonaje(personaje);
            }
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
            this.personaje = Serializador.serializarPersonaje(personaje);
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
}

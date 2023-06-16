# Labo-II-Integrador: Emporio de personajes

# Expectativas del programa:
El programa permitira a los usuarios crear personajes del juego de mesa "Calabozos y Dragones". Podran elegir las siguientes caracteristicas del personaje:
- Nombre
- Raza
- Pasado
- Clase y nivel en la clase
- Atributos (Fuerza, Destreza, Constitucion, Inteligencia, Sabiduria y Carisma)
- Competencias en habilidades

Ademas se permitira crear armas, armaduras y otro equipamiento para el personaje. Se podran realizar tiradas de dado basadas en las estadisticas del
personaje. Los personajes seran guardados en un archivo Json para ser leido en apertura. Se utilizara un sistema de usuarios que poseeran un username
y contraseña. Los usuarios solo podran acceder a los personajes creados por su usuario. Tambien existira una clase de usuario denominada SuperAdmin que
podra crear, editar y eliminar usuarios. Similarmente a los personajes, se almacenara en memoria el listado de usuarios.
El programa permitira exportar los datos de un personaje a la hoja usada comunmente en partidas presenciales de Calabozos y Dragones en forma de PDF, para
que pueda imprimirse y utilizarse simplemente.

# Funcionalidad Actual:
## Formulario de Log-In:
El formulario verifica los datos ingresados y permite el acceso en caso de que el usuario y contraseña sean correctos. Actualmente existen 2 usuarios:
- Max - 123 (SuperAdmin).
- test - test (Jugador).
En caso de que el usuario no este registrado o la contraseña no sea la correcta, se notifica al usuario.

## Menu principal:
El strip izquiedo del menu principal muestra las pestañas del Form para su apertura, junto a la lista de personajes cargados y el usuario logueado actualmente.
Las pestañas de "Informacion", "Jugar" y "Exportar" solo estaran habilitadas en caso de que se haya seleccionado un personaje de la lista.Ademas de esto,
la pestaña del Form de Usuarios solo sera visible para aquellos usuarios designados SuperAdmin.
En los casos de "Crear Personaje", "Jugar", e "Informacion", clickear los botones causa que se añada el formulario correspondiente como subForm en el lado
derecho del programa.

## Crear personaje:
Al crear un personaje, se inserta un nombre y se decide en la raza del personaje. Una vez determinado ambos, clickea el boton de continuar. En caso de ser
necesario, una ventana emergente aparecera si se requiere determinar una caracteriztica especifica de la raza seleccionada. Ademas, se abrira una ventana
que permita asignar los atributos del personaje.
La asignacion de personaje se puede realizar por 2 metodos: por "Tirada" o manualmente. La asignacion por tirada hace una tirada de 3 dados de 6 caras (3d6)
para cada atributo. Luego, se puede mover los valores generados entre los atributos para asignarlos a preferencia del usuario. La asignacion manual le permite
al usuario ingresar un valor entre 1 y 20 a cada atributo.
Hecho esto, se elige la clase y el nivel en esta clase del personaje. Similarmente a con la raza, y dependiendo de la clase y el nivel elegido, se abriran
pequeñas cajas de dialogo para elegir especificaciones del personaje. Una vez realizadas las elecciones, se da click al boton de crear, se crea el personaje
y se cierra el formulario.

## Informacion:
El formulario de informacion muestra datos del personaje. Manteniendo el mouse sobre algunas de estos datos dara una breve descripcion sobre esta. En este
formulario tambien se encuentra la seccion para añadir, examinar y quitar equipo (o Items) del personaje.

### Forja de items
En la forja se pueden crear items para añadir al personaje. Las opciones para añadir son "Tesoro", "Arma" y "Armadura". Todo item tiene los siguientes campos:
- Nombre
- Peso
- Precio
- Propiedades
- Descripcion

Las armas tambien poseen un tipo de daño junto con los valores de daño en dados: NdC (Donde N representa la cantidad de dados y C las caras del dado). Las 
armaduras possen un valor de AC (Armor Class).

## Jugar:
En esta seccion se pueden realizar tiradas de dado basadas en las estadisticas del personaje. Se pueden realizar tiradas de atributos y de habilidades.
Las tiradas de dados se definen de la siguiente forma:
- Tirada de atributo = 1d20 + el modificador de ese atributo.
- Tirada de habilidad = 1d20 + el modificador de atributo asociado a esa habilidad + el bonus de competencia del personaje si es competente en esa habilidad.

// La funcionalidad de checkeo de ataque y daño no ha sido implementada aun.

## Exportar:
// La funcionalidad de guardar personajes no funciona correctamente. Siendo mas especifico, se pueden guardar los personajes pero no se cargan correctamente.

Al clickear el boton de exportar personaje a PDF, se genera un archivo de PDF en la carpeta del programa. Actualmente el programa solo imprime los datos
mas basicos del personaje (para mostrar funcionalidad), pero se implementara que se impriman todos los datos del personaje.

# Proximos cambios (en orden de prioridad):
- Implementar excepciones.
- Implementar uso de base de datos.
- Homogenizar interfaz de usuario a lo largo del programa.
- Implementar el uso de ataques.
- Finalizar generacion de PDF
- Implementar propiedad de "Pasado" de personajes.
- Añadir clases faltantes.
- Añadir hechizos y sus mecanicas.

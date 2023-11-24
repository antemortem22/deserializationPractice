using System.Text.Json;

namespace PracticaJson
{
    internal class Program
    {
        static void Main()
        {
            #region Carga del directorio de los JSON
            string pathEjercicioUno = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio1.json");
            string pathEjercicioDos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio2.json");
            string pathEjercicioTres = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio3.json");
            string pathEjercicioCuatro = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio4.json");
            #endregion

            string ejercicio1 = File.ReadAllText(pathEjercicioUno);

            string ejercicio2 = File.ReadAllText(pathEjercicioDos);

            string ejercicio3 = File.ReadAllText(pathEjercicioTres);

            string ejercicio4 = File.ReadAllText(pathEjercicioCuatro);

            ///////////////////////////////Ejercicio 1//////////////////////////////////
            Persona persona = JsonSerializer.Deserialize<Persona>(ejercicio1)!;
            // Acceso a los datos deserializados
            Console.WriteLine($"Nombre: {persona.nombre}");
            Console.WriteLine($"Edad: {persona.edad}");
            Console.WriteLine($"País: {persona.pais}");
            Console.WriteLine($"Activo: {persona.activo}");



            ///////////////////////////////////////////////////////////////////////////
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////");
            //////////////////////////////////////////////////////////////////////////





            ///////////////////////////////Ejercicio 2//////////////////////////////////
            Usuario usuario = JsonSerializer.Deserialize<Usuario>(ejercicio2)!;
            // Acceso a los datos deserializados
            Console.WriteLine($"Nombre: {usuario.usuario}");
            //Imprimir la lista
            Console.WriteLine("Lista de amigos:");
            foreach (var amigo in usuario.amigos_usuario)
            {
                Console.WriteLine($"   {amigo}");
            }
            /////
            Console.WriteLine($"Notificaciones: {usuario.notificaciones_usuario}");



            ///////////////////////////////////////////////////////////////////////////
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////");
            //////////////////////////////////////////////////////////////////////////

            ///////////////////////////////Ejercicio 3//////////////////////////////////
            
            Resumen estadistica = JsonSerializer.Deserialize<Resumen>(ejercicio3)!;
          

            // Imprimir estadísticas generales
            foreach (var equipo in estadistica.estadistica)
            {
                Console.WriteLine($"Equipo: {equipo.nombre}");
                Console.WriteLine($"Campeon: {equipo.campeon}");

                // Imprimir jugadores del equipo
                foreach (var jugador in equipo.jugadores)
                {
                    Console.WriteLine($"  Jugador: {jugador.nombre}");
                    Console.WriteLine($"    Kills: {jugador.kills}");
                    Console.WriteLine($"    Death: {jugador.death}");
                }

                
            }



            ///////////////////////////////////////////////////////////////////////////
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////");
            //////////////////////////////////////////////////////////////////////////

            ///////////////////////////////Ejercicio 4//////////////////////////////////
            Catalogo catalogo = JsonSerializer.Deserialize<Catalogo>(ejercicio4)!;

            //Imprimir catálogo
            Console.WriteLine("------Catalogo------");
            Console.WriteLine();
            foreach (var producto in catalogo.productos)
            {
                Console.WriteLine($"Nombre: {producto.nombre}");
                Console.WriteLine($"Precio: {producto.precio}");
                Console.WriteLine($"Existencias: {producto.existencias}");
                Console.WriteLine($"Descuento Disponible: {producto.descuento_disponible}");
                Console.Write("Etiquetas: ");
                foreach (var etiqueta in producto.etiquetas)
                {
                    Console.Write($"{etiqueta}, ");
                }
                Console.WriteLine();
                Console.WriteLine($"Detalles:");
                Console.WriteLine($" Peso: {producto.detalles.peso}");
                Console.WriteLine(" Dimensiones:");
                Console.WriteLine($"   ->Alto: { producto.detalles.dimensiones.alto}");
                Console.WriteLine($"   ->Ancho:  { producto.detalles.dimensiones.ancho}");
                Console.WriteLine($"   ->Profundidad:  {producto.detalles.dimensiones.profundidad}");
                Console.WriteLine();
            }

        }



    }
}
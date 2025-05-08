using System;
using System.ComponentModel.Design;


class NumeroAleatorio
{
    static void Main(string[] args)
    {
        // Instancia de la clase Util
        Util util = new Util();

        // Generar número aleatorio
        Random random = new Random();
        int numeroRandom = random.Next(0, 100);

        Console.WriteLine("Hola, bienvenido al programa Adivina el número!");
        Console.WriteLine("Las reglas son sencillas: solo debes adivinar el número aleatorio.");
        Console.WriteLine("El programa te dirá si el número que escribiste es mayor o menor al número real.");

        bool opcionValida = false;

        while (!opcionValida)
        {
            Console.WriteLine("\nAntes de comenzar, seleccione la dificultad que desea intentar:");
            Console.WriteLine("1. Fácil - 25 intentos");
            Console.WriteLine("2. Medio - 15 intentos");
            Console.WriteLine("3. Difícil - 10 intentos");
            Console.WriteLine("4. IMPOSIBLE - 5 intentos");
            Console.WriteLine("5. Salir");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    util.NivelFacil(numeroRandom); // Llamada al método NivelFacil
                    
                    break;
                case "2":
                    util.NivelMedio(numeroRandom); // Llamada al método NivelMedio
                   
                    break;
                case "3":
                    util.NivelDificil(numeroRandom); // Llamada al método NivelDificil
                   
                    break;
                case "4":
                    util.NivelImposible(numeroRandom); // Llamada al método NivelImposible
                  
                    break;
                case "5":
                    Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");
                   opcionValida = true; // Cambié a true para salir del bucle
                    System.Threading.Thread.Sleep(2000); // Espera 2 segundos (2000 milisegundos)
                    break;
                default:
                    Console.WriteLine("Has seleccionado una opción no válida. Por favor, inténtalo de nuevo.");

                    break;
            }
        }
    }
}

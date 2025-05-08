
using System;



/// Clase que contiene la lógica de los diferentes niveles del juego "Adivina el número"
public class Util
{

    /// Lógica para el nivel fácil del juego. El jugador tiene 25 intentos.
     public void NivelFacil(int numeroRandom)
    {
        Console.WriteLine("Has seleccionado el nivel fácil, tienes 25 intentos, ¡vamos allá!");

        for (int i = 25; i > 0; i--)
        {
            Console.WriteLine("Escriba el número:");
            string NumeroTexto = Console.ReadLine();
            int.TryParse(NumeroTexto, out int numero);

            if (numero < numeroRandom)
            {
                Console.WriteLine("\nEl número que escribiste es menor al número aleatorio.");
            }
            else if (numero > numeroRandom)
            {
                Console.WriteLine("\nEl número que escribiste es mayor al número aleatorio.");
            }
            else
            {
                Console.WriteLine($"¡Felicidades! Adivinaste el número correcto en {25 - i + 1} intentos.");
                return; // Regresa al menú principal
            }

            if (i == 1)
            {
                Console.WriteLine($"\nOh, has perdido. El número era {numeroRandom}.");
            }
        }
    }

   
    /// Lógica para el nivel medio del juego. El jugador tiene 15 intentos.
  public void NivelMedio(int numeroRandom)
    {
        Console.WriteLine("Has seleccionado el nivel medio, tienes 15 intentos, ¡vamos allá!");

        for (int i = 15; i > 0; i--)
        {
            Console.WriteLine("Escriba el número:");
            string NumeroTexto = Console.ReadLine();
            int.TryParse(NumeroTexto, out int numero);

            if (numero < numeroRandom)
            {
                Console.WriteLine("\nEl número que escribiste es menor al número aleatorio.");
            }
            else if (numero > numeroRandom)
            {
                Console.WriteLine("\nEl número que escribiste es mayor al número aleatorio.");
            }
            else
            {
                Console.WriteLine($"¡Felicidades! Adivinaste el número correcto en {15 - i + 1} intentos.");
                return; // Regresa al menú principal
            }

            if (i == 1)
            {
                Console.WriteLine($"\nOh, has perdido. El número era {numeroRandom}.");
            }
        }
    }

    /// Lógica para el nivel difícil del juego. El jugador tiene 10 intentos.
   public void NivelDificil(int numeroRandom)
    {
        Console.WriteLine("Has seleccionado el nivel difícil, tienes 10 intentos, ¡vamos allá!");

        for (int i = 10; i > 0; i--)
        {
            Console.WriteLine("Escriba el número:");
            string NumeroTexto = Console.ReadLine();
            int.TryParse(NumeroTexto, out int numero);

            if (numero < numeroRandom)
            {
                Console.WriteLine("\nEl número que escribiste es menor al número aleatorio.");
            }
            else if (numero > numeroRandom)
            {
                Console.WriteLine("\nEl número que escribiste es mayor al número aleatorio.");
            }
            else
            {
                Console.WriteLine($"¡Felicidades! Adivinaste el número correcto en {10 - i + 1} intentos.");
                return; // Regresa al menú principal
            }

            if (i == 1)
            {
                Console.WriteLine($"\nOh, has perdido. El número era {numeroRandom}.");
            }
        }
    }

    /// Lógica para el nivel imposible del juego. El jugador tiene 5 intentos.
    public void NivelImposible(int numeroRandom)
    {
        Console.WriteLine("Has seleccionado el nivel imposible, tienes 5 intentos, ¡vamos allá!");

        for (int i = 5; i > 0; i--)
        {
            Console.WriteLine("Escriba el número:");
            string NumeroTexto = Console.ReadLine();
            int.TryParse(NumeroTexto, out int numero);

            if (numero < numeroRandom)
            {
                Console.WriteLine("\nEl número que escribiste es menor al número aleatorio.");
            }
            else if (numero > numeroRandom)
            {
                Console.WriteLine("\nEl número que escribiste es mayor al número aleatorio.");
            }
            else
            {
                Console.WriteLine($"¡Felicidades! Adivinaste el número correcto en {5 - i + 1} intentos.");
                return; // Regresa al menú principal
            }

            if (i == 1)
            {
                Console.WriteLine($"\nOh, has perdido. El número era {numeroRandom}.");
            }
        }
    }
}

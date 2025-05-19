using System;

namespace MiApp // Puedes poner el nombre de tu espacio de nombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar = "s";

            while (continuar.ToLower() == "s")
            {
                try
                {
                    Console.Write("Introduce el primer número: ");
                    double numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Introduce el segundo número: ");
                    double numero2 = Convert.ToDouble(Console.ReadLine());

                    if (numero2 == 0)
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    }
                    else
                    {
                        double resultado = numero1 / numero2;
                        Console.WriteLine($"Resultado: {resultado}");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Entrada no válida. Debes introducir números.");
                }

                Console.Write("\n¿Deseas hacer otra división? (s/n): ");
                continuar = Console.ReadLine();
            }

            Console.WriteLine("\nPrograma finalizado. ¡Hasta luego!");
        }
    }
}

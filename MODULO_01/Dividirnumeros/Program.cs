using System;

namespace DivisionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Programa de División de Dos Números ===");

            try
            {
                Console.Write("Ingresa el primer número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa el segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (num2 == 0)
                {
                    Console.WriteLine("Error: No se puede dividir por cero.");
                }
                else
                {
                    double resultado = num1 / num2;
                    Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada no válida. Por favor ingresa números.");
            }

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

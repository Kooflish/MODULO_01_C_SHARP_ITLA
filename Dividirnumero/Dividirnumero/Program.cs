using System;

class ProgramaDivision
{
    static void Main()
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
                Console.WriteLine("Resultado de la división: " + resultado);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debes introducir números válidos.");
        }
    }
}

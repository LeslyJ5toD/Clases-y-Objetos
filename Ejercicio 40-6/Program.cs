using System;


namespace Ejercicio_40_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el primer número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Operaciones suma = new Suma { Numero1 = numero1, Numero2 = numero2 };
            Operaciones resta = new Resta { Numero1 = numero1, Numero2 = numero2 };
            Operaciones multiplicacion = new Multiplicacion { Numero1 = numero1, Numero2 = numero2 };
            Operaciones division = new Division { Numero1 = numero1, Numero2 = numero2 };

            Console.WriteLine($"\nResultados de las operaciones:");
            Console.WriteLine($"Suma: {suma.Calcular()}");
            Console.WriteLine($"Resta: {resta.Calcular()}");
            Console.WriteLine($"Multiplicación: {multiplicacion.Calcular()}");
            Console.WriteLine($"División: {division.Calcular()}");
        }
    }
}
   

using System;


namespace Ejercicio_42_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Papeles papel = new Papeles();
            Console.WriteLine("Ingrese los datos del producto Papeles:");

            papel.CapturarDatos();

            Console.WriteLine("\nInformación del producto Papeles:");

            papel.MostrarInformacion();

            Utensilios utensilio = new Utensilios();

            Console.WriteLine("\nIngrese los datos del producto Utensilios:");

            utensilio.CapturarDatos();

            Console.WriteLine("\nInformación del producto Utensilios:");

            utensilio.MostrarInformacion();
        }
    }
}



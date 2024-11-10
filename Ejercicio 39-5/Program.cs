using System;


namespace Ejercicio_39_5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Estudiante[] estudiantes = new Estudiante[5];

            
            for (int i = 0; i < estudiantes.Length; i++)
            {
                estudiantes[i] = new Estudiante(); // Inicializar el objeto estudiante

                Console.WriteLine($"Ingrese los datos del estudiante {i + 1}:");

                Console.Write("Nombre: ");
                estudiantes[i].Nombre = Console.ReadLine();

                Console.Write("Edad: ");
                estudiantes[i].Edad = Convert.ToInt32(Console.ReadLine());


                Console.Write("Matrícula: ");
                estudiantes[i].Matricula = Console.ReadLine();

                Console.Write("Carrera: ");
                estudiantes[i].Carrera = Console.ReadLine();

                Console.WriteLine();
            }

            
            Console.WriteLine("Datos de los estudiantes ingresados:\n");
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($"Estudiante {i + 1}:");
                Console.WriteLine($"Nombre: {estudiantes[i].Nombre}");
                Console.WriteLine($"Edad: {estudiantes[i].Edad}");
                Console.WriteLine($"Matrícula: {estudiantes[i].Matricula}");
                Console.WriteLine($"Carrera: {estudiantes[i].Carrera}");
                Console.WriteLine();
            }
        }
    }
}
   

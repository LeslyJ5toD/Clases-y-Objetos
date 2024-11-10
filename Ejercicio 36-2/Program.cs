using System;


namespace ejercicio_2_clases_y_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                //instancia de Perro
                Perro miPerro = new Perro();
                Console.WriteLine("Ingrese el nombre del perro");
                miPerro.Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el tipo de perro");
                miPerro.Tipo = Console.ReadLine();

                Console.WriteLine($"El perro se llama {miPerro.Nombre} y es un {miPerro.Tipo}.");
                miPerro.EmitirSonido(); 

                //instancia de Gato
                Gato miGato = new Gato();
                Console.WriteLine("Ingrese el nombre del gato");
                miGato.Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el tipo de gato");
                miGato.Tipo = Console.ReadLine();

                Console.WriteLine($"El gato se llama {miGato.Nombre} y es un gato {miGato.Tipo}.");
                miGato.EmitirSonido(); 
            }
        }
    }
}

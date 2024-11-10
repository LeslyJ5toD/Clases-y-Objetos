using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_clases_y_objetos_30_y_pico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Articulos articulos = new Articulos();
            Console.WriteLine("Ingrese el nombre del articulo");
            articulos.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del articulo");
            articulos.Precio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la categoria del articulo");
            articulos.Categoria = Console.ReadLine();

            Console.WriteLine($"El {articulos.Nombre} cuesta {articulos.Precio} y esta en la {articulos.Categoria}");

        }
    }
}

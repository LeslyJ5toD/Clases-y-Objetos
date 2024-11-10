using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_y_Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dispositivo dispositivo = new Dispositivo();
            Console.WriteLine("Ingrese el tipo de dispositivo");
            dispositivo.Tipo = (Console.ReadLine());

            Console.WriteLine("Ingrese el color del dispositivo");
            dispositivo.Color = (Console.ReadLine());

            Console.WriteLine("Ingrese la marca del dispositivo");
            dispositivo.Marca = (Console.ReadLine());


            dispositivo.Encender();
            dispositivo.Apagar();


            Console.WriteLine($" El/La {dispositivo.Tipo} es de color {dispositivo.Color} y es un/a {dispositivo.Marca} ");

            Console.ReadKey();  
        }
    }
}




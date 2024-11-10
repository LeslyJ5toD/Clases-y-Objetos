using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_y_Objetos
{
    internal class Dispositivo
    {
        public  string Tipo { get; set; }

        public string Color { get; set; }

        public string Marca { get; set; }

        public void Encender()
        {
            Console.WriteLine("se encendio");
        }
        public void Apagar()
        {
            Console.WriteLine("se apago");
        }
    }
}


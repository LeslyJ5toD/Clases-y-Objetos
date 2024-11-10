using System;

namespace Ejercicio_40_6
{
    internal class Operaciones
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }

        // Método que se sobrescribirá en las clases derivadas
        public virtual double Calcular()
        {
            return 0;
        }
    }

    // Clase derivada para la suma
    class Suma : Operaciones
    {
        public override double Calcular()
        {
            return Numero1 + Numero2;
        }
    }

    // Clase derivada para la resta
    class Resta : Operaciones
    {
        public override double Calcular()
        {
            return Numero1 - Numero2;
        }
    }

    // Clase derivada para la multiplicación
    class Multiplicacion : Operaciones
    {
        public override double Calcular()
        {
            return Numero1 * Numero2;
        }
    }

    // Clase derivada para la división
    class Division : Operaciones
    {
        public override double Calcular()
        {
            // Evitar la división por cero
            if (Numero2 == 0)
            {
                Console.WriteLine("Error: División por cero no permitida.");
                return 0;
            }
            return Numero1 / Numero2;
        }
    }
}


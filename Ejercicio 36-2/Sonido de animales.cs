using System;


namespace ejercicio_2_clases_y_objetos
{
    internal class Sonido_de_animales
    {
        // Clase base
        public class Animal
        {
            public string Nombre { get; set; }

            public string Tipo { get; set; }

            public virtual void EmitirSonido()
            {
                Console.WriteLine("Este animal hace un sonido.");
            }
        }

        // Clase hija: Perro
        public class Perro : Animal
        {
            public override void EmitirSonido()
            {
                Console.WriteLine("Guaf Guaf");
            }
        }

        // Clase hija: Gato
        public class Gato : Animal
        {
            public override void EmitirSonido()
            {
                Console.WriteLine("Miau Miau");
            }
        }

    }
}

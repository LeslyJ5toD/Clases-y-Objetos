using System;


class Producto

{ 
public string Nombre { get; set; }
public double Precio { get; set; }
public int Cantidad { get; set; }

public virtual void CapturarDatos()
{
    Console.WriteLine("Nombre: ");
    Nombre = Console.ReadLine();
    Console.WriteLine("Precio: ");
    Precio = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Cantidad: ");
    Cantidad = Convert.ToInt32(Console.ReadLine());
}

public virtual void MostrarInformacion()
{
    Console.WriteLine($"Nombre: {Nombre}");
    Console.WriteLine($"Precio: {Precio:C}");
    Console.WriteLine($"Cantidad: {Cantidad}");
}
}

class Papeles : Producto
{
    public string Tipo { get; set; }

    public override void CapturarDatos()
    {
        base.CapturarDatos(); // Captura los datos generales (Nombre, Precio, Cantidad)
        Console.WriteLine("Tipo de Papel: ");
        Tipo = Console.ReadLine();
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion(); 
        Console.WriteLine($"Tipo de Papel: {Tipo}");
    }
}

class Utensilios : Producto
{
    public string Material { get; set; }

    public override void CapturarDatos()
    {
        base.CapturarDatos(); 
        Console.Write("Material: ");
        Material = Console.ReadLine();
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion(); 
        Console.WriteLine($"Material: {Material}");
    }
}



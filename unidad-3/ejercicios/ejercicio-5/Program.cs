namespace mayores_100;

class Program
{
  static void Main(string[] args)
  {
    //5.Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
    int n1, n2, n3, n4;
    Console.WriteLine("Ingresa un número: ");
    n1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Ingresa un número: ");
    n2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Ingresa un número: ");
    n3 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Ingresa un número: ");
    n4 = int.Parse(Console.ReadLine()!);
    if (n1 > 100)
      Console.WriteLine("El 1° número: "+n1 + " es mayor a 100.");
    if (n2 > 100)
      Console.WriteLine("El 2° número: "+n2 + " es mayor a 100.");
    if (n3 > 100)
      Console.WriteLine("El 3° número: "+n3 + " es mayor a 100.");
    if (n4 > 100)
      Console.WriteLine("El 4° número: "+n4 + " es mayor a 100.");
    else
      Console.WriteLine("No hay números mayores a 100.");

      Console.WriteLine("Fin del programa.");
  }
}

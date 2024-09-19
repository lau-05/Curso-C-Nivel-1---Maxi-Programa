namespace decreciente;

class Program
{
  static void Main(string[] args)
  {
    //5.Hacer un programa para ingresar 4 números.Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente.
    int n1, n2, n3, n4;
    Console.WriteLine("Ingrese un número: ");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese otro número: ");
    n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese otro número: ");
    n3 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese un último número: ");
    n4 = int.Parse(Console.ReadLine());
    if (n1 > n2 && n2 > n3 && n3 > n4)
      Console.WriteLine("Los números se encuentran ordenados de forma decreciente.");
    else if (n1 < n2 && n2 < n3 && n3 < n4)
      Console.WriteLine("Los números se encuentran ordenados de forma creciente.");
    else
      Console.WriteLine("Los números no se encuentran ordenados.");
    Console.WriteLine("Fin del programa.");

  }
}

using System;

namespace calculadora
{
  class Program
  {
    static void Main(string[] args)
    {
      int n1, n2, n3, n4, r;
      Console.WriteLine("Ingrese su nota del 1° parcial: ");
      n1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese su nota del 2° parcial: ");
      n2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese su nota del 3° parcial: ");
      n3 = int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese su nota del 4° parcial: ");
      n4 = int.Parse(Console.ReadLine());
      r = (n1 + n2 + n3 + n4) / 4;
      Console.WriteLine("Su promedio es: " + r);

    }
  }
}

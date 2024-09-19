using System;

namespace calc_suma
{
  class Program
  {
    static void Main(string[] args)
    {
      //1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
      int n1, n2, r;
      Console.WriteLine("Ingrese un número: ");
      n1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese otro número: ");
      n2 = int.Parse(Console.ReadLine());
      r = n1 + n2;
      Console.WriteLine("El resultado es: " + r);

    }
  }
}

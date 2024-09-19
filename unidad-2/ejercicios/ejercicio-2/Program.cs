using System;

namespace cubo
{
  class Program
  {
    static void Main(string[] args)
    {
      //2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
      int n, cube;
      Console.WriteLine("Ingrese un número: ");
      n = int.Parse(Console.ReadLine());
      cube = n * n * n;
      Console.WriteLine("El resultado de elevar " + n + " al cubo es: " + cube);
    }
  }
}

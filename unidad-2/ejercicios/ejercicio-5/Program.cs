using System;

namespace promedio
{
  class Program
  {
    static void Main(string[] args)
    {
      //5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.
      float n1, n2, n3, prom;
      Console.WriteLine("Ingrese la nota de su examen: ");
      n1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese la nota de su examen: ");
      n2 = float.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese la nota de su examen: ");
      n3 = float.Parse(Console.ReadLine());
      prom = (n1 + n2 + n3) / 3;
      Console.WriteLine("El promedio final es: " + prom.ToString("0.00"));
    }
  }
}

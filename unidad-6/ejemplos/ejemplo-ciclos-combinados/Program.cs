namespace ejemplo_ciclos_combinados;

class Program
{
  static void Main(string[] args)
  {
    //Ciclos Combinados:
    //For con For
    float prom, acu, n;
    Console.WriteLine("Ingrese 1 para comenzar o 0 para salir del programa");
    n = float.Parse(Console.ReadLine()!);
    while (n != 0)
    {
      acu = 0;
      Console.WriteLine("Promedios de los alumnos de 1° año.");
      for (int x = 0; x < 3; x++)
      {
        Console.WriteLine("Ingrese la nota del parcial: ");
        n = float.Parse(Console.ReadLine()!);
        acu += n;
      }
      prom = acu / 3;
      Console.WriteLine("El promedio es: " + prom);
      Console.WriteLine("Fin de carga de notas del alumno.");
      Console.WriteLine("Ingrese un número para comenzar o 0 para salir del programa");
      n = float.Parse(Console.ReadLine()!);
    }
    Console.WriteLine("Fin del programa");
  }
}



namespace ejemplo_ciclo_while;

class Program
{
  static void Main(string[] args)
  {
    //WHILE
    float n, prom, acu = 0, con = 0;
    Console.WriteLine("Ingrese la nota del alumno: ");
    n = float.Parse(Console.ReadLine());
    while (n != 0)
    {
      con++;
      acu += n;
      Console.WriteLine("Ingrese la nota del alumno: ");
      n = float.Parse(Console.ReadLine());
    }
    if (con > 0)
    {
      prom = acu / con;
      Console.WriteLine("El promedio del alumno es: " + prom.ToString("0.00"));
    }
    else
    {
      Console.WriteLine("No se ingresaron notas.");
    }
    Console.WriteLine("Fin del programa");
  }
}

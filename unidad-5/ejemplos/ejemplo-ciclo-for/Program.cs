namespace ejemplo_ciclo_for;

class Program
{
  static void Main(string[] args)
  {
    //CICLO FOR
    int n;
    for (int i = 0; i < 5; i++)
    {
      Console.WriteLine("Ingresa el " + (i + 1) + "° número: ");
      n = int.Parse(Console.ReadLine()!);
      Console.WriteLine("Tu número es: " + n);
    }
    Console.WriteLine("Fin del programa");
  }
}

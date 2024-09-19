namespace ejemplo_ciclo_do_while;

class Program
{
  static void Main(string[] args)
  {
    int n;
    do
    {
      Console.WriteLine("Ingrese un número: ");
      n = int.Parse(Console.ReadLine());
      if (n > 0)
        Console.WriteLine("Ingresaste: " + n);
    } while (n != 0);
    Console.WriteLine("Fin del programa.");
  }
}

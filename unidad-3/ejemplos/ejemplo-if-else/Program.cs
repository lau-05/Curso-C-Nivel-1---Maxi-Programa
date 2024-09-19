namespace ejemplo;

class Program
{
  static void Main(string[] args)
  {
    int edad;
    Console.WriteLine("Introduce tu edad");
    edad = int.Parse(Console.ReadLine());
    if (edad >= 21)
      Console.WriteLine("21% OFF");
    else if (edad >= 18)
      Console.WriteLine("18% OFF");
    else
      Console.WriteLine("No aplica descuento");
    Console.WriteLine("Fin del programa");
  }
}

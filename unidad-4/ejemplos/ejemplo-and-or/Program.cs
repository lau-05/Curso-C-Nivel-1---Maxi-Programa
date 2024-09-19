internal class Program
{
  private static void Main(string[] args)
  {
    //AND Y OR...NOT
    //AND (y) Operador: &&
    //OR (o) Operador: ||
    int edad;
    char inicial;
    char apellido;
    Console.WriteLine("Introduce tu edad: ");
    edad = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Introduce la inicial de tu nombre: ");
    inicial = char.Parse(Console.ReadLine()!);
    Console.WriteLine("Introduce la inicial de tu apellido: ");
    apellido = char.Parse(Console.ReadLine()!);
    if ((inicial == 'A' || apellido == 'A') && !(edad < 18))
    {
      Console.WriteLine("Obtienes un 30% de descuento en el Día del ABCedario. ");
    }
    else
    {
      Console.WriteLine("Lo sentimos, no aplicas al descuento.");
    }
  }
}
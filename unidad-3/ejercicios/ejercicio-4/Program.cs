namespace menor;

class Program
{
  static void Main(string[] args)
  {
    //4.Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
    int n1, n2, n3, n4, min;
    Console.WriteLine("Ingrese un número: ");
    n1 = int.Parse(Console.ReadLine()!);
    min = n1;
    Console.WriteLine("Ingrese otro número: ");
    n2 = int.Parse(Console.ReadLine()!);
    if (n2 < min)
      min = n2;
    Console.WriteLine("Ingrese otro número: ");
    n3 = int.Parse(Console.ReadLine()!);
    if (n3 < min)
      min = n3;
    Console.WriteLine("Ingrese el último número: ");
    n4 = int.Parse(Console.ReadLine()!);
    if (n4 < min)
      min = n4;
    Console.WriteLine("El número menor es " + min + ".");
  }
}

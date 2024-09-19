namespace suma_producto;

class Program
{
  static void Main(string[] args)
  {
    //4.Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.
    int n1, n2, n3;
    Console.WriteLine("Ingrese un número: ");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese otro número: ");
    n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese un último número: ");
    n3 = int.Parse(Console.ReadLine());
    if ((n1 + n2) > (n2 * n3))
      Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo con el tercero.");
    Console.WriteLine("Programa terminado.");
  }
}

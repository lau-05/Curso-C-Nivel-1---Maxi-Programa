namespace funciones_ref;

class Program
{
  static void Main(string[] args)
  {
    //PARAMETRO POR REFERENCIA
    int n1 = 0, n2 = 0, r;
    pedirDatos(ref n1, ref n2);
    r = sumar(n1, n2);
    Console.WriteLine("El resultado es: " + r);
  }

  static void pedirDatos(ref int x, ref int y)
  {
    Console.WriteLine("Ingrese un número: ");
    x = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Ingrese otro número: ");
    y = int.Parse(Console.ReadLine()!);
  }

  static int sumar(int a, int b)
  {
    int s;
    s = a + b;
    return s;
  }

}

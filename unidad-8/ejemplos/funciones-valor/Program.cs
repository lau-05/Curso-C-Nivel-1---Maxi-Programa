namespace introduccion_funciones;

class Program
{
  static void Main(string[] args)
  {
    //FUNCIONES
    //Cabecera
    //1.Tipo de Dato
    //2.Nombre
    //3.Parametros (Opcional)
    //Cuerpo
    //1.Definición/Lógica
    //2.Return/Resultado(Opcional)

    int n1, n2, r;
    Console.WriteLine("Ingrese un número: ");
    n1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Ingrese otro número: ");
    n2 = int.Parse(Console.ReadLine()!);
    r = sumar(n1, n2);
    Console.WriteLine("El resultado es: " + r);
  }
  static int sumar(int a, int b)
  {
    int s;
    s = a + b;
    return s;
  }
}

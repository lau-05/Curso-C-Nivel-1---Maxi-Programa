namespace ejercicio_3;

class Program
{
  static void Main(string[] args)
  {
    // 3.Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es.
    //Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero.
    //Informar el promedio teniendo en cuenta sólo los números primos.
    int n, con = 0, acu = 0;
    float prom;
    Console.WriteLine("Ingrese un número: ");
    n = int.Parse(Console.ReadLine());
    while (n != 0)
    {
      if (primo(n))
      {
        Console.WriteLine("Es un número primo");
        con++;
        acu += n;
      }
      else
        Console.WriteLine("No es un número primo");
      Console.WriteLine("Ingrese otro número: ");
      n = int.Parse(Console.ReadLine());
    }
    if (con > 0)
    {
      prom = (float)acu / con;
      Console.WriteLine("El promedio de numeros primos es: " + prom);
    }
    else
      Console.WriteLine("No hay números primos");
  }
  static bool primo(int num)
  {
    int con = 0;
    for (int x = 1; x <= num; x++)
    {
      if (num % x == 0)
        con++;
    }
    if (con == 2)
      return true;
    else
      return false;
  }
}

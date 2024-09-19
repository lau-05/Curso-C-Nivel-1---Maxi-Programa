namespace ejercicio_4;

class Program
{
  static void Main(string[] args)
  {
    //4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
    int n, con = 0, d = 1;
    Console.WriteLine("Ingrese un número: ");
    n = int.Parse(Console.ReadLine());
    while (d <= n)
    {
      if ((n % d == 0))
        con++;
      d++;
    }
    if (con == 2)
      Console.WriteLine("Es un número primo.");
    else
      Console.WriteLine("No es un número primo.");
  }
}

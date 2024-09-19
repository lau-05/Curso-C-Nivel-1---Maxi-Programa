namespace ejercicio_5;

class Program
{
  static void Main(string[] args)
  {
    //5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
    int n, max_par = int.MinValue, min_impar = int.MaxValue;
    for (int i = 0; i < 20; i++)
    {
      Console.WriteLine("Ingrese un número: ");
      n = int.Parse(Console.ReadLine());
      if ((n % 2 == 0))
      {
        if (n > max_par)
          max_par = n;
      }
      else
      {
        if (n < min_impar)
          min_impar = n;
      }
    }
    Console.WriteLine("El maximo número par es: " + max_par);
    Console.WriteLine("El minimo número impar es: " + min_impar);
  }
}

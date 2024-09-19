namespace ejercicio_1;

class Program
{
  static void Main(string[] args)
  {
    //1.Hacer un programa para ingresar 10 números.El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
    int n, con, conprimo = 0;
    for (int i = 0; i < 10; i++)
    {
      con = 0;
      Console.WriteLine("Ingrese un número: ");
      n = int.Parse(Console.ReadLine());
      for (int d = 1; d <= n; d++)
      {
        if (n % d == 0)
          con++;
      }
      if (con == 2)
        conprimo++;
    }
    Console.WriteLine("La cantidad de números primos es de: " + conprimo);
  }
}





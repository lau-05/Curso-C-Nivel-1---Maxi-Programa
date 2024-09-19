namespace ejercicio_3;

class Program
{
  static void Main(string[] args)
  {
    //3. 
    //  Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
    //  El fin de la carga se notifica con un número negativo. 
    //  Luego mostrar cuántos números tiene cada lista.
    int n = 1, con, lote = 0;
    while (n >= 0)
    {
      lote++;
      con = 0;
      Console.WriteLine("Ingrese un número positivo: ");
      n = int.Parse(Console.ReadLine());
      while (n > 0)
      {
        con++;
        Console.WriteLine("Ingrese un número positivo: ");
        n = int.Parse(Console.ReadLine());
      }
      Console.WriteLine("Fin de la lista");
      Console.WriteLine("La cantidad de números de la lista N° " + lote + " es: " + con);
    }
    Console.WriteLine("Fin del programa");
  }
}

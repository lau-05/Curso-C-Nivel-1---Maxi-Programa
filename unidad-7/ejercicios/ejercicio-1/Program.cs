namespace ejercicio_1;

class Program
{
  static void Main(string[] args)
  {
    // 1.Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

    int[] vnum = new int[10];
    for (int x = 0; x < 10; x++)
    {
      Console.WriteLine("Ingrese el número: ");
      vnum[x] = int.Parse(Console.ReadLine());
    }

    int mayor = vnum[0];
    int pos = 0;
    for (int x = 1; x < 10; x++)
    {
      if (vnum[x] > mayor)
      {
        mayor = vnum[x];
        pos = x;
      }
    }

    Console.WriteLine("El valor máximo es: " + mayor);
    Console.WriteLine("Se encuentra en la posicion N°: " + (pos + 1));
  }
}

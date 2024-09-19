namespace ejercicio_2;

class Program
{
  static void Main(string[] args)
  {
    //2.Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
    //Luego recorrer ese vector para calcular el promedio. 
    //Mostrar por pantalla los valores que son mayores al promedio.

    int[] vnum = new int[10];
    for (int x = 0; x < 10; x++)
    {
      Console.WriteLine("Ingrese el número: ");
      vnum[x] = int.Parse(Console.ReadLine());
    }

    int acu = 0;
    for (int x = 0; x < 10; x++)
    {
      acu += vnum[x];
    }

    float prom = acu / 10F;
    Console.WriteLine("El promedio es: " + prom);

    for (int x = 0; x < 10; x++)
    {
      if (vnum[x] > prom)
        Console.WriteLine("El valor '" + vnum[x] + "' ingresado en la posición N°: " + (x + 1) + " es mayor al promedio.");
    }

  }
}

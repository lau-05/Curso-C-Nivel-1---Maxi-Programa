namespace ejemplo_vectores;

class Program
{
  static void Main(string[] args)
  {
    //VECTORES-ARRAY-ARREGLO

    //declaro variables
    int num;
    int[] vnum = new int[12];

    //asigno los números al vector
    for (int i = 0; i < 12; i++)
    {
      //pido y guardo valor
      Console.WriteLine("Ingrese el sueldo del mes " + (i + 1) + ": ");
      num = int.Parse(Console.ReadLine()!);
      vnum[i] = num;
    }

    //acumulo los números
    int acu = 0;
    for (int i = 0; i < 12; i++)
    {
      acu += vnum[i];
    }

    //calculo el promedio
    int prom = acu / 12;

    //mostrar
    Console.WriteLine("El sueldo promedio es de: $" + prom);
    Console.WriteLine("El sueldo anual es de: $" + acu);
  }
}

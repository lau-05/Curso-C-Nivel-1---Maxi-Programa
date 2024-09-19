namespace acu_con;

class Program
{
  static void Main(string[] args)
  {
    int con = 0, e1, e2, e3, acu = 0, prom;
    Console.WriteLine("Introduce la edad de la 1° persona: ");
    e1 = int.Parse(Console.ReadLine());
    if (e1 >= 18)
    {
      con++;
      acu += e1;
    }
    Console.WriteLine("Introduce la edad de la 2° persona: ");
    e2 = int.Parse(Console.ReadLine());
    if (e2 >= 18)
    {
      con++;
      acu += e2;
    }
    Console.WriteLine("Introduce la edad de la 3° persona: ");
    e3 = int.Parse(Console.ReadLine());
    if (e3 >= 18)
    {
      con++;
      acu += e3;
    }
    if (con >= 1)
    {
      prom = acu / con;
      Console.WriteLine("El promedio es de " + prom + " años.");
    }
    else
    {
      Console.WriteLine("No hay personas mayores de 18 años.");
    }
  }
}

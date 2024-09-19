namespace ejercicio_3;

class Program
{
  static void Main(string[] args)
  {
    //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
    int e, acu = 0, con = 0;
    float prom;
    for (int i = 0; i < 20; i++)
    {
      Console.WriteLine("Ingrese la edad: ");
      e = int.Parse(Console.ReadLine());
      if (e > 18)
      {
        acu += e;
        con++;
      }
    }
    prom = acu / con;
    Console.WriteLine("El promedio de edad de los mayores de 18 años es: " + prom);
  }
}
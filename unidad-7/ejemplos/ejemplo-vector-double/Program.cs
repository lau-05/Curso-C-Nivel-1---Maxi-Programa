namespace ejemplo_vector_double;

class Program
{
  static void Main(string[] args)
  {
    //declaro variables
    int dia;
    double[] datos = new double[31];
    double temp, prom = 0, acu = 0;

    //cargo temperatura
    for (int x = 0; x < 31; x++)
    {
      Console.WriteLine("Ingrese el día: ");
      dia = int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese temperatura registrada: ");
      temp = double.Parse(Console.ReadLine());
      datos[dia - 1] = temp;
    }

    //leer vector
    for (int x = 0; x < 31; x++)
    {
      acu += datos[x];
    }

    //calculo promedio
    prom = acu / 31;

    //muestro resultado
    Console.WriteLine("El promedio de temperatura mensual es de: " + prom + " °C");
  }
}

namespace ejemplo_vector_bool;

class Program
{
  static void Main(string[] args)
  {
    int[] legajo = new int[100];
    bool[] asistencia = new bool[100];
    for (int x = 0; x < 100; x++)
    {
      Console.WriteLine("Ingrese el legajo: ");
      legajo[x] = int.Parse(Console.ReadLine());
      Console.WriteLine("Asistencia (true/false): ");
      asistencia[x] = bool.Parse(Console.ReadLine());
    }
  }
}

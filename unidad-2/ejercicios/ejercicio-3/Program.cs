namespace km;

class Program
{
  static void Main(string[] args)
  {
    //3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
    float d, v, T;
    Console.WriteLine("Ingrese la distancia: ");
    d = float.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la velocidad promedio: ");
    v = float.Parse(Console.ReadLine());
    T = d / v;
    Console.WriteLine("El tiempo que tardará será de: " + T.ToString("0.00") + " horas/minutos");
  }
}

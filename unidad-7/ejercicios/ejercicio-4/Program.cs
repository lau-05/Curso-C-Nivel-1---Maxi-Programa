namespace ejercicio_4;

class Program
{
  static void Main(string[] args)
  {
    /*4.Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
        -Número de Artículo(1 a 15)
        -Cantidad Vendida
      Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
      Se pide determinar e informar:
        a) El número de artículo que más se vendió en total.
        b) Los números de artículos que no registraron ventas.
        c) Cuantas unidades se vendieron del número de artículo 10*/

    int nroArticulo, cantidad;
    int[] totalCantidadVendida = new int[15];
    for (int x = 0; x < 15; x++)
    {
      totalCantidadVendida[x] = 0;
    }
    Console.WriteLine("Ingrese el N° de artículo: ");
    nroArticulo = int.Parse(Console.ReadLine());
    while (nroArticulo != 0)
    {
      Console.WriteLine("Ingrese la cantidad vendida: ");
      cantidad = int.Parse(Console.ReadLine());
      totalCantidadVendida[nroArticulo - 1] += cantidad;
      Console.WriteLine("Ingrese el N° de artículo: ");
      nroArticulo = int.Parse(Console.ReadLine());
    }

    //A
    int maxCantidad = totalCantidadVendida[0];
    int nroMaximo = 1;
    for (int x = 0; x < 15; x++)
    {
      if (totalCantidadVendida[x] > maxCantidad)
      {
        maxCantidad = totalCantidadVendida[x];
        nroMaximo = x + 1;

      }
    }
    Console.WriteLine("El producto más vendido es el N° " + nroMaximo + " con la cantidad de " + maxCantidad + " ventas");

    //B
    for (int x = 0; x < 15; x++)
    {
      if (totalCantidadVendida[x] == 0)
        Console.WriteLine("El producto " + (x + 1) + " no registró ventas");
    }

    //C
    Console.WriteLine("La cantidad vendida del artículo N° 10 es: " + totalCantidadVendida[9]);
  }
}
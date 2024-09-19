using System;

namespace factura
{
  class Program
  {
    static void Main(string[] args)
    {
      //4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
      float tf, c, s;
      const float sf = 15000;
      const float pc = 0.05F;
      Console.WriteLine("Ingrese el total facturado del empleado: ");
      tf = float.Parse(Console.ReadLine());
      c = tf * pc;
      s = c + sf;
      Console.WriteLine("El sueldo del empleado es: ARS" + s);
    }
  }
}

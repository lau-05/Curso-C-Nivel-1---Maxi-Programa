﻿namespace negocio;

class Program
{
  static void Main(string[] args)
  {
    //2.Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
    //Si vende menos de 100 litros, no hay descuento.
    //Si vende entre 101 y 300 litros, el descuento es del 10 %.
    //Si vende entre 301 y 500 litros, el descuento es del 15 %.
    //Finalmente, si la venta es de más de 500 litros, el descuento es del 25 %.
    //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado.
    float imp, lts;
    Console.WriteLine("Ingrese el importe de la venta: ");
    imp = float.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad de litros: ");
    lts = float.Parse(Console.ReadLine());
    if (lts > 500)
      imp *= 0.75F;
    else if (lts > 300)
      imp *= 0.85F;
    else if (lts > 100)
      imp *= 0.90F;
    Console.WriteLine("Su importe final es de: ARS" + imp);
  }
}

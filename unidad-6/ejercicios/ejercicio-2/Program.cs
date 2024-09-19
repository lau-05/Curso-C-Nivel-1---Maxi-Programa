namespace ejercicio_2;

class Program
{
  static void Main(string[] args)
  {
    //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
    //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
    //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
    int n, con, conimpar, grupomax = 0, min, congruposord = 0;
    double porimpar, pormax = -1;
    bool bandord;
    for (int i = 0; i < 5; i++)
    {
      con = 0;
      conimpar = 0;
      bandord = true;
      Console.WriteLine("Ingrese un número: ");
      n = int.Parse(Console.ReadLine()!);
      min = n;
      while (n != 0)
      {
        //A
        con++;
        if (n % 2 != 0)
          conimpar++;

        //B
        if (n <= min)
          min = n;
        else
          bandord = false;

        Console.WriteLine("Ingrese un número: ");
        n = int.Parse(Console.ReadLine()!);
      }//END WHILE
      Console.WriteLine("Fin del grupo");
      //A
      porimpar = conimpar * 100 / con;
      if (porimpar > pormax)
      {
        pormax = porimpar;
        grupomax = i + 1;
      }

      //B
      if (bandord)
        congruposord++;

    }//END FOR
    Console.WriteLine("El grupo con mayor porcentaje de impares es el grupo: " + grupomax);
    Console.WriteLine("La cantidad de grupos con números ordenados de mayor a menor es: " + congruposord);
    Console.WriteLine("Fin del programa");
  }
}

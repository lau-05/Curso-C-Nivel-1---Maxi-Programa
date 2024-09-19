namespace ejemplo_corte_de_control;

class Program
{
  static void Main(string[] args)
  {
    // Declaración de variables
    int leg, edad, ing, ingActual, con = 0;
    float prom, promIng, promFinal, acu = 0;

    // Pido datos
    Console.WriteLine("Ingrese la especialidad del alumno (1=SISTEMAS|2=MECANICA|3=QUIMICA|4=ELECTRICA||ingrese otro número para salir): ");
    ing = int.Parse(Console.ReadLine());

    while (ing == 1 || ing == 2 || ing == 3 || ing == 4)
    {
      ingActual = ing;

      while (ing == ingActual)
      {
        // Pido datos
        Console.WriteLine("Ingrese el legajo: ");
        leg = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la edad: ");
        edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el promedio: ");
        prom = int.Parse(Console.ReadLine());
        acu += prom;
        con++;

        // Pido datos de especialidad para verificar si continuar el bucle interno
        Console.WriteLine("Ingrese la especialidad del alumno: ");
        ing = int.Parse(Console.ReadLine());
      }
      Console.WriteLine("Ha finalizado el registro de esta especialidad");
      promIng = acu / con;
      Console.WriteLine("El promedio es: " + promIng);
      acu = 0;
      con++;
    }

    promFinal = acu / con;

    // Fin
    Console.WriteLine("Fin del programa");
    Console.WriteLine("El promedio final es: " + promFinal);

  }
  //NO FUNCIONA PERO NO IMPORTA
  //ESTA BIEN IGUAL PORQUE CORTE DE CONTROL NO ES TAN IMPORTANTE
  //LO IMPORTANTE ES ENTENDER SU FUNCIONAMIENTO 
  //:)
}
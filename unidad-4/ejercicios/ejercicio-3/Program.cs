namespace computadora;

class Program
{
  static void Main(string[] args)
  {
    //3.Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:

    //i5(1)  i7(2)  i9(3)
    //8 RAM(1)   USD 800 USD 900 USD 1200
    //16 RAM(2)  USD 900 USD 1000  USD 1400
    //32 RAM(3)  USD 1000  USD 1400  USD 2000
    //Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo adicional de USD 300.Hacer un programa que solicite la opción de procesador, la opción de memoria RAM, y si extiende el disco o no(ingresa 1 para extender o un 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.

    int cpu, ram, disc;
    float price = 0;

    Console.WriteLine("Seleccione su procesador: [i5(1), i7(2), i9 (3)]");
    cpu = int.Parse(Console.ReadLine());
    Console.WriteLine("Seleccione el tamaño de su memoria RAM: [8GB(1), 16GB(2), 32GB(3)]");
    ram = int.Parse(Console.ReadLine());
    Console.WriteLine("¿Desea ampliar su disco de 500GB a 1TB? [SI(1), NO(0)]");
    disc = int.Parse(Console.ReadLine());

    switch (cpu)
    {
      case 1:
        switch (ram)
        {
          case 1:
            price = 800;
            break;
          case 2:
            price = 900;
            break;
          case 3:
            price = 1000;
            break;
          default:
            Console.WriteLine("Ingrese una opción válida."); Environment.Exit(0);
            break;
        }
        break;
      case 2:
        switch (ram)
        {
          case 1:
            price = 900;
            break;
          case 2:
            price = 1000;
            break;
          case 3:
            price = 1400;
            break;
          default:
            Console.WriteLine("Ingrese una opción válida."); Environment.Exit(0);
            break;
        }
        break;
      case 3:
        switch (ram)
        {
          case 1:
            price = 1200;
            break;
          case 2:
            price = 1400;
            break;
          case 3:
            price = 2000;
            break;
          default:
            Console.WriteLine("Ingrese una opción válida."); Environment.Exit(0);
            break;
        }
        break;
      default:
        Console.WriteLine("Ingrese una opción válida."); Environment.Exit(0);
        break;
    }

    if (disc == 1)
      price += 300;
    Console.WriteLine("El precio final de su computadora es de: ARS" + price);
  }
}


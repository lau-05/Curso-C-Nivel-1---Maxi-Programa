namespace ejemplo_switch;

class Program
{
  static void Main(string[] args)
  {
    //SWITCH
    char letra;
    Console.WriteLine("Bienvenido a Springfield");
    Console.WriteLine("Elija su combo (1, 2, 3 o 4).");
    letra = char.Parse(Console.ReadLine());
    switch (letra)
    {
      case '1':
        Console.WriteLine("Homero Doble con Papas Simples y Coca Cola.");
        break;
      case '2':
        Console.WriteLine("Milhouse Doble con Papas y Pepsi.");
        break;
      case '3':
        Console.WriteLine("Bart Doble con Papas Bacon y Fanta.");
        break;
      case '4':
        Console.WriteLine("Krusty Doble con Papas Cheddar y Sprite.");
        break;
      default:
        Console.WriteLine("Lo siento, elija una opcion de combo válida (1, 2, 3 o 4).");
        break;
    }
  }
}

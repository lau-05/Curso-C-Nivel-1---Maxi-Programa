namespace ejemplo_cadenas_de_caracteres;

class Program
{
  static void Main(string[] args)
  {
    //NO SON LO MISMO (dif. conceptual)
    //STRING-CADENA DE CARACTERES-VECTOR DE CHAR

    //VECTOR DE CHAR
    // char[] asistencia = new char[10];
    // asistencia[0] = 'P';
    // asistencia[1] = 'A';

    //CADENA DE CARACTERES
    // char[] nombre = new char[40];
    // char letra;
    // int indice = 0;
    // Console.WriteLine("Ingrese su nombre: ");
    // letra = char.Parse(Console.ReadLine());
    // while (letra != '.' && indice < 40)
    // {
    //   nombre[indice] = letra;
    //   letra = char.Parse(Console.ReadLine());
    //   indice++;
    // }
    // nombre[indice] = '\0';
    // Console.Write("Hola");
    // indice = 0;
    // while (nombre[indice] != '\0')
    // {
    //   Console.Write(nombre[indice]);
    //   indice++;

    //STRING
    string nombre;
    Console.WriteLine("Ingrese su nombre: ");
    nombre = Console.ReadLine();
    Console.WriteLine("Hola " + nombre);
  }
}


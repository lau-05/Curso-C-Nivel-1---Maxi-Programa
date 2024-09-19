namespace ejercicio_3;

class Program
{
  static void Main(string[] args)
  {
    /*3.Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos. El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla.
     Ejemplo:CADENA FUENTE: “La mar estaba serena"
     CARÁCTER 1: ‘a’ 
     CARÁCTER 2: ‘i’
     CADENA RESULTADO: “Li mir estibi sereni"*/

    // PROGRAMA CON CADENA DE CARACTERES

    /*
    char[] frase = new char[140];
    char letraActual, letraNueva, letra;
    int indice = 0;

    Console.WriteLine("Ingrese una letra para la frase: ");
    letra = char.Parse(Console.ReadLine());
    while (letra != '0' && indice < 140)
    {
      frase[indice] = letra;
      Console.WriteLine("Ingrese otra letra para la frase: ");
      letra = char.Parse(Console.ReadLine());
      indice++;
    }
    frase[indice] = '\0';
    Console.WriteLine("La frase completa es: ");
    indice = 0;
    while (frase[indice] != '\0')
    {
      Console.Write(frase[indice]);
      indice++;
    }

    Console.WriteLine("Ingrese letra a reemplazar: ");
    letraActual = char.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la letra nueva: ");
    letraNueva = char.Parse(Console.ReadLine());

    indice = 0;
    while (frase[indice] != '\0')
    {
      if (frase[indice] == letraActual)
        frase[indice] = letraNueva;
      indice++;
    }
    Console.WriteLine("La frase nueva es: ");
    indice = 0;
    while (frase[indice] != '\0')
    {
      Console.Write(frase[indice]);
      indice++;
     */

    //PROGRAMA CON STRING
    string frase;
    char letraActual, letraNueva;
    Console.WriteLine("Ingrese la frase: ");
    frase = Console.ReadLine();
    Console.WriteLine("Ingrese la letra a reemplazar: ");
    letraActual = char.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la letra nueva: ");
    letraNueva = char.Parse(Console.ReadLine());
    frase = frase.Replace(letraActual, letraNueva);
    Console.WriteLine("La frase nueva es: ");
    Console.WriteLine(frase);
  }
}

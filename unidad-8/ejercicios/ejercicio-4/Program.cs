namespace ejercicio_4;

class Program
{
  static void Main(string[] args)
  {
    // 4.Hacer una función de tipo void(porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia.Que analice el número y escriba la variable recibida por referencia con:
    // a. 1 si el número es positivo.
    // b. - 1 si el número es negativo.
    // c. 0 si el número es cero.
    int num, status = 0;
    Console.WriteLine("Ingrese un número: ");
    num = int.Parse(Console.ReadLine());
    positivoNegativoCero(num, ref status);
    Console.WriteLine("El estado del valor " + num + " es: " + status);
  }
  static void positivoNegativoCero(int n, ref int estado)
  {
    if (n > 0)
      estado = 1;
    else if (n == 0)
      estado = 0;
    else
      estado = -1;
  }
}


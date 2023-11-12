using System;

namespace Presentacion4
{
  class Program
  {
    static void Main(string[] args)
    {
       int valor1 = 0, valor2 = 0;
       string cadena;
       Console.WriteLine("Dame el primer Valor: ");
       cadena = Console.ReadLine();
       valor1 = Convert.ToInt32(cadena);
       Console.WriteLine("Dame el segundo Valor: ");
       cadena = Console.ReadLine();
       valor2 = Convert.ToInt32(cadena);   
       if (valor1 <= valor2)
       {
          if (valor1 == valor2)
              Console.WriteLine("El valor 1 es igual al valor 2");
          else 
              Console.WriteLine("El valor 2 es igual o mayor que el valor 1");
       }
       else
       Console.WriteLine("El valor 1 es mayor que valor 2");
       Console.ReadKey();
    }
  }
}

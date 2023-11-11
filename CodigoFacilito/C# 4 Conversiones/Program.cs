
using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 10;
      decimal x = 12.2m; 
      bool bandera = false;
      string cadena = "12344";
      DateTime fecha = DateTime.MinValue;
      i = Convert.ToInt32(cadena);
      Console.WriteLine("El valor de i es: {0}", i);
      Console.WriteLine("El valor de x es: {0:C} ", x);
      Console.WriteLine("El valor de bandera es: " + bandera.ToString());
      Console.WriteLine("El valor de cadena es: " + cadena);
      Console.WriteLine("El valor de fecha es: " + fecha.ToShortDateString()); 
      Console.ReadKey();  
    }
  }
}

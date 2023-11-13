using System;
using presentacion6;

namespace Presentacion6
{
  class Program
  {
    static void Main(string[] args)
    {
       clsEmpleados empleado;
       empleado = new clsEmpleados();
       empleado.Edad = 15;
       empleado.Nombre = "Marcos Hernadez";
       empleado.SueldoDiario = 12.5m;
       decimal total;
       total = empleado.CalculaSalario(30);
       Console.WriteLine("El saladio mensual del empleado " + empleado.Nombre);
       Console.WriteLine("es :" + total.ToString("C"));
       Console.ReadKey();
    }
  }
}


using System;
using System.Runtime.InteropServices;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
        ClsEnteros A = new ClsEnteros(5);
        A.ArrayEnteros[0] = 1;
        A.ArrayEnteros[1] = 2;
        A.ArrayEnteros[2] = 3;
        A.ArrayEnteros[3] = 4;
        A.ArrayEnteros[4] = 5;
        A.MostrarEnteros();

        ClsEnteros B = new ClsEnteros(4);
        B.ArrayEnteros[0] = 6;
        B.ArrayEnteros[1] = 7;
        B.ArrayEnteros[2] = 8;
        B.ArrayEnteros[3] = 9;
        B.MostrarEnteros();
        Console.WriteLine("----------------");
        A.SumarEnterosArray();
        B.SumarEnterosArray();
        A.MostrarMayor();
        B.MostrarMayor();
        Console.ReadKey();
        

    


         
    }
  }
}

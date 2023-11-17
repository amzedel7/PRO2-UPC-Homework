using System;

namespace presentacion6
{
  class Program
  {
    static void Main(string[] args)
    {
          clsClientesVentas Cliente;
          Cliente = new clsClientesVentas();
          Cliente.IdCliente = 123;
          Cliente.Apellidos = "Hernandez";
          Cliente.Nombres = "Marcos";
          Cliente.Direccion = "Av Tigre 119";
          Cliente.RFC = "HEHM";
          Cliente.Colonia = "La cueva del Jaguar";
          Cliente.Municipio = "Tuxtla Gutierrez";
          Cliente.EsCredito = true;
          Console.WriteLine(Cliente.Apellidos + " " + Cliente.Nombres);
          Console.WriteLine(Cliente.Direccion + " " + Cliente.Colonia + " " + Cliente.Municipio);
          Console.WriteLine(Cliente.RFC);
          if(Cliente.EsCredito)
                Console.WriteLine("El cliente tiene credito");
            else
                Console.WriteLine("El cliente no tiene credito");
          Console.ReadKey();
          
    }
  }
}

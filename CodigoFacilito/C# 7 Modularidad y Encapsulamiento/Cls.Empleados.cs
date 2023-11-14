using System;

namespace presentacion6
{
  public class clsEmpleados
  {
    public clsEmpleados()
    {
        Nombre = " ";
        SueldoDiario = 0.0m;
        Edad = 0;
    }
    private string _Nombre;
     public string Nombre { get => _Nombre; set => _Nombre = value; }
    

        
    public decimal SueldoDiario { get; set; }
    public int Edad { get; set; }
        
        public decimal CalculaSalario(int NumeroDias)
    {
        return SueldoDiario * NumeroDias;
    }
    
           
    
  }
}
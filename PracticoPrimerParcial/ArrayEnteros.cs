using System.Diagnostics.Contracts;

public class ClaseEnteros
{   
    public int[] ArrayEnteros;
       
    public ClaseEnteros(int cantidad)
    {
        ArrayEnteros = new int[cantidad];
    }
    public void MostrarArray()
    {
        string resp = "[";
        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            resp += ArrayEnteros[i] + ", ";
        }
        Console.WriteLine(resp + "]");
    }
    public void MostrarMayor()
    {
        int mayor = ArrayEnteros[0];
        for (int i = 1; i < ArrayEnteros.Length; i++)
        {
            if (ArrayEnteros[i] > mayor)
            {
                mayor = ArrayEnteros[i];
            }
        }
        Console.WriteLine("El numero mayor es: " + mayor);
    }
    public void SumaArrayEnteros()
    {
        int suma = 0;
        
        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            suma = suma + ArrayEnteros[i];
        }
        Console.WriteLine("La suma es: " + suma);
    }
    
    public int PromedioArrayEnteros()
    {
        int suma = 0;

        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            suma += ArrayEnteros[i];
        }
        int promedio = suma / ArrayEnteros.Length;
        return promedio;
    
    }
    public static int  FrecuenciaArrayEnteros(int elemento, int[] ArrayEnteros)
   
    {
        int frecuencia = 0;

        for (int i = 0; i < ArrayEnteros.Length; i++)
         {
            if (ArrayEnteros[i] == elemento)
            {
                frecuencia++;
            }
        }
        return frecuencia;
    }
    public string[] ArrayEnterosToArrayCadenas()
{
        string[] arrayCadenas = new string[ArrayEnteros.Length];
        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            arrayCadenas[i] = Convert.ToChar(ArrayEnteros[i]).ToString();
        }
        return arrayCadenas;
}
    public void DiferenciaArrayEnterosByA()
    {
        
       int resta = 0;
        int n = ArrayEnteros.Length;
        for (int i = 0; i < n; i++)
        {
            resta = resta - ArrayEnteros[i];
        }
        Console.WriteLine(resta);
    }

}
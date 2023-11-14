public class ClsEnteros
{
    public int[]ArrayEnteros;

    public ClsEnteros(int cantidad)
    {
        ArrayEnteros = new int[cantidad];
    }
    

    public void MostrarEnteros()
    {
        string resp = "[";
        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            resp += ArrayEnteros[i] + ", ";
        }
        Console.WriteLine(resp.TrimEnd(',', ' ') + "]");
    }
    public void SumarEnterosArray()
    {
        int suma = 0;
        
        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            suma = suma + ArrayEnteros[i];
        }
        Console.WriteLine("La suma es: " + suma);
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
    
}
 
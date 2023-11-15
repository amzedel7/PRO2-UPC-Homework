using System.Reflection.Metadata.Ecma335;

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

    public void MostrarMenor()
    {
        int menor = ArrayEnteros[0];
        for (int i = 1; i > ArrayEnteros.Length; i++)
        {
            if(ArrayEnteros[i] < menor)
            {
                menor = ArrayEnteros[i];
            }
        }
        Console.WriteLine("El numero menor es: " + menor);
    }
    
    public void FibonaciMenor()
    {
        int n = ArrayEnteros.Length;
        int a = 0;
        int b = 1;

        if (n == 0)
        {
            Console.WriteLine(a);
        }
        else if (n == 1)
        {
            Console.WriteLine(b);
        }
        else
        {int menor = ArrayEnteros[0];
            for (int i = 1; i < ArrayEnteros.Length; i++)
            {
                if (ArrayEnteros[i] < menor)
                {
                    menor = ArrayEnteros[i];
                }
            }
            for (int i = 2; i <= menor; i++)
            {
                int c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine("El número de Fibonacci menor es: " + b);
        }
    }
    public void UnirArray(ClsEnteros B)
    {
        int n1 = ArrayEnteros.Length;
        int n2 = B.ArrayEnteros.Length;
        int newN = n1 + n2;
        ClsEnteros C = new ClsEnteros(newN);
        for (int i = 0; i <= n1 - 1; i++)
        {
            C.ArrayEnteros[i] = ArrayEnteros[i];
        }
        for (int j = 0; j <= n2 - 1; j++)
        {
            C.ArrayEnteros[n1 + j] = B.ArrayEnteros[j];
        }
        ArrayEnteros = C.ArrayEnteros;

    }
    
    
}

    

    
        
    
    
    

    


 
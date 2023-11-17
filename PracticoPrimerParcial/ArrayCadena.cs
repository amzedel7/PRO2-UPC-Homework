using System;
using System.Text;
using System.Linq;

public class ClaseCadena
{
    public string[] ArrayCadenas;

    public ClaseCadena()
    {
        ArrayCadenas = new string[0];
    }

    public ClaseCadena(int cant)
    {
        ArrayCadenas = new string[cant];
    }

    public void MostrarArray()
    {
        string resp = "[";
        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            resp += ArrayCadenas[i] + ", ";
        }
        Console.WriteLine(resp + "]");
    }
    public string BuscarElementoArrayCadenas(string elemento)
    {
        bool encontrado = Array.Exists(ArrayCadenas, e => e == elemento);
        return encontrado ? "TRUE" : "FALSE";
    }
    public static int  FrecuenciaArrayCadenas(string elemento, string[] ArrayCadenas)
    
    {
        int frecuencia = 0;

        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            if (ArrayCadenas[i] == elemento)
            {
                frecuencia++;
            }
        }
        return frecuencia;
    }
    public void Interseccion(string[] A, string[] B)
    {
        int k = 0;
        for (int i = 0; i <= A.Length - 1; i++)
        {
            string dato = A[i];
            //Console.WriteLine("------------: " + dato);
            for (int d = 0; d <= B.Length - 1; d++)
            {
                string dato1 = B[d];
                if (dato == dato1)
                {
                    ArrayCadenas[k] = dato1;
                    k = k + 2;
                    //Console.WriteLine(dato3);
                }
            }
        }
    }
    public int[] ArrayCadenasToArrayEnteros()
    {
        int[] resultado = new int[ArrayCadenas.Length];
        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(ArrayCadenas[i]);
            resultado[i] = asciiBytes[0];
        }
        return resultado;
    }
    public static string[] DiferenciaArrayCadenasAyB(ClaseCadena A, ClaseCadena B)
    {
        string[] resultado = A.ArrayCadenas.Except(B.ArrayCadenas).ToArray();
        return resultado;
    }
    public void InvertirArrayCadenas()
    {
        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            Console.WriteLine(ArrayCadenas[i]);
        }
    }

}
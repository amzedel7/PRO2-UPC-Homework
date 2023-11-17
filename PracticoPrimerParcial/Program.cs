﻿namespace Clase8
{
    public class Program{
        public static void Main(string[] args)
        {   /*
            ClaseEnteros A = new ClaseEnteros(5);
            A.ArrayEnteros[0] = 65;
            A.ArrayEnteros[1] = 7;
            A.ArrayEnteros[2] = 10;
            A.ArrayEnteros[3] = 5;
            A.ArrayEnteros[4] = 7;
            A.MostrarArray();
                     
            ClaseEnteros B = new ClaseEnteros(3);
            B.ArrayEnteros[0] = 18;
            B.ArrayEnteros[1] = 66;
            B.ArrayEnteros[2] = 8;
            B.MostrarArray();

            Console.WriteLine("Ejercicio 1: ");
            A.MostrarMayor();
            B.MostrarMayor();

            Console.WriteLine("Ejercicio 2: ");
            A.SumaArrayEnteros();
            B.SumaArrayEnteros();

            Console.WriteLine("Ejercicio 3: ");
            int promedioA = A.PromedioArrayEnteros();
            int promedioB = B.PromedioArrayEnteros();
            Console.WriteLine("El promedio de A es: " + promedioA);
            Console.WriteLine("El promedio de B es: " + promedioB); 
                       
            Console.WriteLine("Ejercicio 5: ");
            
            int elemento = 7;
            int frecuencia = ClaseEnteros.FrecuenciaArrayEnteros(elemento, A.ArrayEnteros);
            Console.WriteLine("La frecuencia del elemento {0} es {1}", elemento, frecuencia); 

            Console.WriteLine("Ejercicio 10: ");
            //int[] arrayEnteros = A.ArrayEnteros;
            string[] arrayCadenas = A.ArrayEnterosToArrayCadenas();
            Console.WriteLine("el nuevo valor es : " + string.Join("", arrayCadenas));

            Console.WriteLine("Ejercicio 12: ");
            A.DiferenciaArrayEnterosByA();
            B.DiferenciaArrayEnterosByA();
            
             */      
            
            ClaseCadena A = new ClaseCadena(4);           
            A.ArrayCadenas[0] = "Joel";
            A.ArrayCadenas[1] = "Daniela";
            A.ArrayCadenas[2] = "Joel";
            A.ArrayCadenas[3] = "Elias";
            A.MostrarArray();
                        
            ClaseCadena B = new ClaseCadena(5);           
            B.ArrayCadenas[0] = "Douglas";
            B.ArrayCadenas[1] = "Ereli";
            B.ArrayCadenas[2] = "Suarez";
            B.ArrayCadenas[3] = "Maria";
            B.ArrayCadenas[4] = "Joel";
            B.MostrarArray();

            Console.WriteLine("Ejercicio 4: ");
            string elementoBuscado = "Ereli";
            string resultado = B.BuscarElementoArrayCadenas(elementoBuscado);
            Console.WriteLine(resultado);

            Console.WriteLine("Ejercicio 6: ");
            string elemento = "Joel";
            int frecuencia = ClaseCadena.FrecuenciaArrayCadenas(elemento, A.ArrayCadenas);
            Console.WriteLine("La frecuencia del elemento {0} es {1}", elemento, frecuencia);

            Console.WriteLine("Ejercicio 7: ");
            ClaseCadena C = new ClaseCadena(5);   
            C.Interseccion(A.ArrayCadenas, B.ArrayCadenas);
            C.MostrarArray();

            Console.WriteLine("Ejercicio 8: ");
            int[] enterosA = A.ArrayCadenasToArrayEnteros();
        
            Console.WriteLine("El arreglo de enteros para A es:");
            foreach (int entero in enterosA)
            {
            Console.WriteLine(entero + " ");
            }
        
            Console.WriteLine("Ejercicio 9: ");
            string[] D = ClaseCadena.DiferenciaArrayCadenasAyB(A, B);
            Console.WriteLine("El arreglo de diferencia es:");
            foreach (string cadena in D)
            {
            Console.WriteLine(cadena);
            }
        
            Console.WriteLine("Ejercicio 11: ");
            Array.Reverse(B.ArrayCadenas);
            Console.WriteLine("Invertir cadena: ");
            B.InvertirArrayCadenas();
        
                        
        }
        
    }
}
namespace Programcion2
{
public class Program 
    {
        static void Main(string[]args){
            GenerarSerieRecursivo(6); // metodo para los numeros de a y b
        }
        static int a = 0;
        static int b = 7;                                
        public static void GenerarSerieRecursivo(int N){
            
            if(N == 0){ // N = 0 no genera nada
                return;
            }else{
                GenerarSerieRecursivo(N - 1); // se llama a si mismo con el argumento de N -1
                int seriea = a + 1; // calcular la seriaa
                int serieb = b - 1; // calcular la serieb
                a = seriea; // la seriaa se asigna a "a"
                b = serieb; // la seriab se asigna a "b"
                Console.Write(" " + seriea);
                Console.Write(" " + serieb);        
            }                         
        }   
    }   
}


    

    

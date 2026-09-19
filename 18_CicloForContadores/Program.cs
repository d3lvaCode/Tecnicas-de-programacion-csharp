using System.Diagnostics.CodeAnalysis;

namespace CicloFOR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Ingresar 10 números enteros. Calcular e informar la cantidad de positivos, la cantidad de negativos y la cantidad de ceros.*/

            int contadorPositivos = 0, contadorNegativos = 0, cantidadCeros = 0,  suma = 0, numero, num;

            for(int n = 0; n < 5; n++)
            {
                Console.WriteLine("Ingresa numero: ");
                numero = int.Parse(Console.ReadLine());
                
                if (numero > 0)
                {
                   contadorPositivos++;
                }
                else if (numero < 0)
                {
                   contadorNegativos++; 
                }
                else
                {
                   cantidadCeros++;
                }
            }//cierra for

            //Informes

            Console.WriteLine("Cantidad de positivos:" + contadorPositivos);
            Console.WriteLine("Cantidad de Negativos:" + contadorNegativos);
            Console.WriteLine("Cantidad de Ceros:" + cantidadCeros);  
        }
    }
}

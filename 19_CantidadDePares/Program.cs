using System;

namespace _20_CantidadDePares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar el diagrama y codificación de un programa que ingrese 5 números y calcule e informe la cantidad de
                pares y el promedio de los impares. */

            double numero, contadorPar = 0, contadorImpar = 0, promImpar = 0, sumaImpares= 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = double.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    contadorPar++;
                }
                else 
                {
                    contadorImpar++;
                    sumaImpares += numero;
                }


                

            }//cierra for
        

            if (contadorImpar > 0)
            {
                promImpar = sumaImpares / contadorImpar;
            }
            //INFORMES

            Console.WriteLine($"La cantidad de pares: {contadorPar}");
            Console.WriteLine($"Promedio de los impares: {promImpar}");
        }
    }
}

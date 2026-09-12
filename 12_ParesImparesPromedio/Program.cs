namespace _12_ParesImparesPromedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Realizar el diagrama y codificación de un programa que ingrese 5 números y calcule e informe la cantidad de 
                pares y el promedio de los impares. */

            double numero, numeroPar = 0, numeroImpar = 0, promedioImpares = 0;




            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el numero: ");
                numero = double.Parse(Console.ReadLine());

                if( numero % 2 == 0 )
                {
                    numeroPar++;
                    Console.WriteLine("el numero es par.");

                }
                else
                {
                    numeroImpar++;
                    Console.WriteLine("el numero es impar.");
                    promedioImpares = 5 / numeroImpar;

                }


            }//cierra if

            

            //INFORMES
            Console.WriteLine("Cantidad de numeros pares: " + numeroPar);
            Console.WriteLine("Cantidad de numeros impares: " + numeroImpar);
            Console.WriteLine("El promedio de los impares: " + promedioImpares);


        }
    }
}

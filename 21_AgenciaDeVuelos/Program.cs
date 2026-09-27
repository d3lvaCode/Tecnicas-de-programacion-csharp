namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Realizar el algoritmo y codificar en lenguaje C, un programa que ingrese número de vuelo, cantidad de pasajes disponibles y precio del pasaje, de un conjunto de vuelos y que finalice al ingresar número de vuelo 0 (inexistente).
                Dicho programa debe calcular e informar:
                a) ¿Cuántos pasajes cuestan menos de $4000?
                b) ¿Cuántos vuelos tienen más de 250 pasajes disponibles?
                c) Suma total de pasajes disponibles.
                d) Número de vuelo, cantidad de pasajes disponibles y precio del pasaje, del vuelo de menor número.
            */

            int numeroDeVuelo, cantidadDePasajes, pasajesMenosDe4mil = 0, pasajesMasDe250 = 0, sumaTotalPasajes = 0;
            float precioPasaje;

            int menorVuelo = 0, menorPasaje = 0, band = 0;
            float menorPrecio = 0;

            Console.WriteLine("Presione 0 para salir...");
            Console.WriteLine("Ingrese numero de vuelo:");
            numeroDeVuelo = int.Parse(Console.ReadLine());
            

            while (numeroDeVuelo != 0)
            {

                Console.WriteLine("Ingrese cantidad de pasajes:");
                cantidadDePasajes = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese precio del pasaje:");
                precioPasaje = float.Parse(Console.ReadLine());

                if(precioPasaje < 4000)
                {
                    pasajesMenosDe4mil++; //Punto A
                }

                if (cantidadDePasajes > 250)
                {
                    pasajesMasDe250++; //Punto B
                }

                sumaTotalPasajes += cantidadDePasajes; //Punto C

                //Algoritmo Max Min

                if (band == 0)
                {
                    
                    band = 1;
                    menorVuelo = numeroDeVuelo;
                    menorPasaje = cantidadDePasajes;
                    menorPrecio = precioPasaje;

                }
                else
                {
                    if (numeroDeVuelo < menorVuelo)
                    {
                        menorVuelo = numeroDeVuelo;
                        menorPasaje = cantidadDePasajes;
                        menorPrecio = precioPasaje;
                    }
                }

                Console.WriteLine("Presione 0 para salir...");
                Console.WriteLine("Ingrese numero de vuelo:");
                numeroDeVuelo = int.Parse(Console.ReadLine());
                




            }

            //Informes



            Console.WriteLine("Los pasajes menores de $4000 son: " + pasajesMenosDe4mil);
            Console.WriteLine("La cantidad de vuelos que tienen mas de 250 pasajes son: " + pasajesMasDe250);
            Console.WriteLine("La suma total de pasajes disponibles: " + sumaTotalPasajes);

            Console.WriteLine("El vuelo de menor numero es: " + menorVuelo);
            Console.WriteLine("El vuelo de menor pasaje es: " + menorPasaje);
            Console.WriteLine("El vuelo de menor precio: " + menorPrecio);






        }
    }
}

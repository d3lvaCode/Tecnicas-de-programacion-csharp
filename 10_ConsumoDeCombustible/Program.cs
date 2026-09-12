namespace _10_ConsumoDeCombustible
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * 
             * Un vehículo consume 12 litros de combustible cada 100 km a 130 km/h. 
             * Se desea realizar un programa que calcule el total consumido en un viaje de 500 km. 
             * Para esto el programa debe pedir la velocidad medida en 3 puntos del viaje. 
             * Con el promedio de las velocidades, calcular el total de combustible consumido.

             */

            double primeraVelocidad, segundaVelocidad, terceraVelocidad;
            double promedioVelocidad, consumo;

            Console.WriteLine("Ingrese primer check de velocidad: ");
            primeraVelocidad = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese primer check de velocidad: ");
            segundaVelocidad = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese primer check de velocidad: ");
            terceraVelocidad = double.Parse(Console.ReadLine());

            //Averiguamos la velocidad promedio
            promedioVelocidad = (primeraVelocidad + segundaVelocidad + terceraVelocidad) / 3;
            //Aplicamos regla de consumo 12litros cada 100km dividido 130km/h
            consumo = (promedioVelocidad * 12 / 130) * 5;

            Console.WriteLine($"La velocidad promedio es de: {promedioVelocidad:F0}km/h");
            Console.WriteLine($"El consumo de combustible a tu velocidad promedio sería de: {consumo:F0}Litros");


        }
    }
}

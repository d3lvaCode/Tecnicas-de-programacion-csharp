using System;

namespace PerimetrosDeTriangulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Elaborar un algoritmo que lea los 3 lados de un triángulo cualquiera (A, B y C)
                 * y calcule su perímetro.
                 * Según el valor del perímetro obtenido, informar si el triángulo es:
                 * - Pequeño: perímetro hasta 10
                 * - Mediano: perímetro mayor a 10 y hasta 30
                 * - Grande: perímetro mayor a 30
            */

            Console.WriteLine("ESTE PROGRAMA CALCULA EL PERIMETRO DE UN TRINGULO Y TE DIGO SI ES PEQUEÑO, MEDIANO O GRANDE.");

            double ladoA, ladoB, ladoC, perimetroTotal;

            Console.WriteLine("Ingrese el Lado A: ");
            ladoA = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Lado B: ");
            ladoB = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Lado C: ");
            ladoC = double.Parse(Console.ReadLine());

            perimetroTotal = ladoA + ladoB + ladoC;

            Console.WriteLine("El perimetro total del triangulo es de:" + perimetroTotal);

            if (perimetroTotal <= 10)// Perimetro mayor igual a 10
            {
                Console.WriteLine("El triangulo es pequeño.");
            }
            else if (perimetroTotal >= 10 && perimetroTotal <= 30)// Perimetro mayor igual a 10 Y Perimetro menor igual a 30
            {
                Console.WriteLine("El triangulo es mediano.");
            }
            else
            {
                Console.WriteLine("El triangulo es grande.");// si ninguna de sus condiciones se cumplen entonces es grande.
            }


        }
    }
}

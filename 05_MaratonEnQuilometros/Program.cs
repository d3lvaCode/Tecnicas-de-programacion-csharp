namespace _05_MaratonEnQuilometros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Una maratón tiene 26 millas y 385 yardas. Sabiendo que una milla tiene 1760 yardas, calcular la
                distancia de la maratón en kilómetros. 
            */
            double milla, yardas, maraton, totalYardas, yardasAKilometros;

            Console.WriteLine("Ingresa la cantidad de millas de la maraton: ");
            milla = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la cantidad de yardas de la maraton: ");
            yardas = int.Parse(Console.ReadLine());


            totalYardas = milla * 1760 + yardas;

            yardasAKilometros = totalYardas / 1093.61;

            Console.WriteLine("La distancia de la maraton en kilometros es: " + yardasAKilometros);
        }
    }
}

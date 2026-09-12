namespace _11_ContadorPositivoyNegativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ingresá 5 números y contá cuántos son positivos y cuántos son negativos (asumí que no vas a ingresar ningún 0) */

            int contadorPositivos = 0; // acumulador de positivos, arranca en 0
            int contadorNegativos = 0; // acumulador de negativos, arranca en 0

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresa un numero: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0) //si es positivo, sumo 1 a ese contador
                {
                    contadorPositivos++; // si es positivo, sumo 1 a ese contados
                }
                else
                {
                    contadorNegativos++; // si no, sumo 1 al negativo
                }


            }// cierra for

            Console.WriteLine("Cantidad de positivos: " + contadorPositivos);
            Console.WriteLine("Cantidad de negativos: " + contadorNegativos);
        }
    }
}

namespace _09_MesSegunNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Indicar el mes al que corresponde el número ingresado. En caso de no ser correcto, informar un mensaje de error. 
            Console.WriteLine("DIME UN NUMERO Y TE DIRÉ A QUE MES CORRESPONDE.");

            int mes;

            Console.WriteLine("Ingrese numero del mes");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine($"El mes {mes} corresponde al mes de ENERO.");
                    break;
                case 2:
                    Console.WriteLine($"El mes {mes} corresponde al mes de FEBRERO.");
                    break;
                case 3:
                    Console.WriteLine($"El mes {mes} corresponde al mes de MARZO.");
                    break;
                case 4:
                    Console.WriteLine($"El mes {mes} corresponde al mes de ABRIL.");
                    break;
                case 5:
                    Console.WriteLine($"El mes {mes} corresponde al mes de MAYO.");
                    break;
                case 6:
                    Console.WriteLine($"El mes {mes} corresponde al mes de JUNIO.");
                    break;
                case 7:
                    Console.WriteLine($"El mes {mes} corresponde al mes de JULIO.");
                    break;
                case 8:
                    Console.WriteLine($"El mes {mes} corresponde al mes de AGOSTO.");
                    break;
                case 9:
                    Console.WriteLine($"El mes {mes} corresponde al mes de SEPTIEMBRE.");
                    break;
                case 10:
                    Console.WriteLine($"El mes {mes} corresponde al mes de OCTUBRE.");
                    break;
                case 11:
                    Console.WriteLine($"El mes {mes} corresponde al mes de NOVIEMBRE.");
                    break;
                case 12:
                    Console.WriteLine($"El mes {mes} corresponde al mes de DICIEMBRE.");
                    break;
                default:
                    Console.WriteLine($"El {mes} es un número inválido, no corresponde a ningún mes.");
                    break;
            }


        }
    }
}

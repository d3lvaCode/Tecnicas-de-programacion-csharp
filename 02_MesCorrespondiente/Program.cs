namespace _02_MesCorrespondiente
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Elaborar un algoritmo que permita indicar si el mes ingresado pertenece a la primera o segunda mitad del año:*/


            Console.Write("Ingrese el mes: ");
            int mes = int.Parse(Console.ReadLine());

            switch (mes){
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("El mes es correspondiente a la primera mitad del año.");
                    break;
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("El mes es correspondiente a la segunda mitad del año.");
                    break;

                default:
                    Console.WriteLine("El mes NO es correpondiente a ningun mes del año.");
                    break;
            }

        }
    }
}

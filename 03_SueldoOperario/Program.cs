namespace _03_SueldoOperario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Calcular el sueldo de un operario, ingresando la cantidad de horas trabajadas y el valor que gana por hora.
             * Si trabaja más de 40 hs, las horas extras se pagan a razón de $1,50 el valor de la hora.*/


            //int horasTrabajadas;
            //double ValorHoraTrabajadas,HorasExtra, PagoExtra;

            double sueldo;

            Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");
            int HorasTrabajada = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la hora trabajada: ");
            double ValorHoraTrabajadas = double.Parse(Console.ReadLine());


            if (HorasTrabajada <= 40)
            {
                Console.WriteLine("El empleado trabajo menos de 40 horas.");
                sueldo = HorasTrabajada * ValorHoraTrabajadas;
                Console.WriteLine("Sueldo correspondiente: " + sueldo);


            }
            else if ( HorasTrabajada > 40)
            {
                
                Console.WriteLine("El empleado trabajo mas de 40 horas tendra un plus de $1.50 su hora extra.");
                int HoraExtra = HorasTrabajada - 40;//Saco cuantas horas hizo extra.
                Console.WriteLine("Horas extra que realizo el empleado: " + HoraExtra ); //informo cuantas horas extra trabajó 

                //A las horas extras debo sumarle el cargo de $1.50           
                double PagoExtra = HoraExtra * ValorHoraTrabajadas * 1.5; // a su sueldo le sumno el cargo extra por sus horas extras
                Console.WriteLine("Su pago por hora extra: " + PagoExtra);
                sueldo = 40 * ValorHoraTrabajadas;
                // Saco el sueldo total que sumo su sueldo normal mas el pago extra.
                double sueldoTotal = sueldo + PagoExtra;
                Console.WriteLine("Su sueldo en total correspondiente: " + sueldoTotal);



            }





        }
    }
}

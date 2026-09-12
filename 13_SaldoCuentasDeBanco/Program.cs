namespace _13_SaldoCuentasDeBanco
{

    class Program
    {
        static void Main(string[] args)
        {
            /* Se ingresan 5 saldos de cuentas de un banco. 
            Calcular e informar: 
                    a. Cantidad de saldos superiores a $1000. 
                    b. Promedio de los restantes. 
            */

            double saldoMayores = 0, saldosRestantes = 0, sumaRestantes = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el saldo: ");
                double saldo = double.Parse(Console.ReadLine());

                if (saldo > 1000)
                {
                    saldoMayores++;
                    //Console.WriteLine("");
                }
                else
                {
                    saldosRestantes++; // Cuenta cuantos saldos van
                    sumaRestantes += saldo; // acumula el valor de esos saldos
                }

               

            }//cierra for

            double promedioRestantes = sumaRestantes / saldosRestantes;

            //INFORMES
            Console.WriteLine("La cantidad de sueldos con saldo mayor a $1000 son: " + saldoMayores);
            Console.WriteLine("La cantidad de sueldos con saldo Menor a $1000 son: " + saldosRestantes);
            Console.WriteLine("El promedio de todos los saldos es: " + promedioRestantes);


        }//cierra static
    }
}
    

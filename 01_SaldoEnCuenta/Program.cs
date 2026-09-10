namespace _01_SaldoEnCuenta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
                Ingresar el saldo de una cuenta bancaria y el importe que desea extraer el propietario de la misma. Si el saldo es suficiente, calcular e informar el nuevo saldo. En caso contrario escribir el mensaje: “Saldo Insuficiente”
            */


            Console.WriteLine("Ingrese el saldo de la cuenta: ");
            float saldo = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el importe que desea extraer: ");
            float importe = float.Parse(Console.ReadLine());

            if (importe <= saldo)
            {
                double nuevoSaldo = saldo - importe;
                Console.WriteLine($"Nuevo saldo: {nuevoSaldo}");
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }


        }
    }
}

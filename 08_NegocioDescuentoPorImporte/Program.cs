using System;

namespace _08_NegocioDescuentoPorImporte
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Un negocio efectúa descuentos según el importe. 
                *Menor a $100 se aplica un descuento del 5%.
                *Entre $100 y $500 un descuento del 10%
                *Mayor a $500 un 20%. 
            Informar el precio original, el descuento y el precio neto.
             */


            double importeDelUsuario, descuento, porcentaje;

            Console.WriteLine("DISTRIBUIDORA HALCON S.A DE ACUERDO A SU IMPORTE SE LE HARÁ UN DESCUENTO.");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("| Compras Menor de $100: 5%;         |");
            Console.WriteLine("| Compras entre $100 y $500: 10%     |");
            Console.WriteLine("| Compras Mayor $500: 20%            | ");
            Console.WriteLine("|------------------------------------|");


            Console.WriteLine("Ingrese el importe: ");
            importeDelUsuario = double.Parse(Console.ReadLine());

            if (importeDelUsuario <= 100)
            {
                porcentaje = 5;

            }
            else if  ( importeDelUsuario <= 500)
            {
                porcentaje = 10;

            }
            else
            {
                porcentaje = 20;

            }

            descuento = (importeDelUsuario * porcentaje) / 100;


            //  INFORMES
            Console.WriteLine($"El importe del usuario es: {importeDelUsuario} te corresponde un {porcentaje} de descuento.\n");
            Console.WriteLine("----------------------------------------------------------------------------------\n");
            Console.Write($"Importe bruto: {importeDelUsuario}\n");
            Console.Write($"Tu descuento fue de {descuento}\n");
            Console.Write($"Importe Neto: {importeDelUsuario - descuento}.\n");
            Console.Write("Muchas gracias.");

        }
    }
}

namespace _17_SumarYcontar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                 SumarYContar: Escribir un programa que:
                    a) Pida por teclado un nuumero.
                    b) Pregunte al usuario si desea introducir otro numero o no.
                    c) Repita los pasos a y b, mientras que, el usuario no responda ’n’ de (no).
                    d) Muestre por pantalla cuantos numeros han sido introducidos por el usuario como
                    tambien la suma de todos ellos.
                    Nota: Utilizar un bucle while (mientras).
             */

            double numero, contador = 0, suma = 0;
            char siOno;

            Console.WriteLine("Quieres ingresar un numero? (S/N): ");
            siOno = char.Parse(Console.ReadLine());




            while(siOno != 'n' && siOno != 'N')
            {
                Console.WriteLine("Ingrese el numero: ");
                numero = double.Parse(Console.ReadLine());
                contador++;

                suma += numero;

                Console.WriteLine("Quieres ingresar otro numero? (S/N): ");
                siOno = char.Parse(Console.ReadLine());

            }

            Console.WriteLine($"Se ingresaron {contador} veces y la suma de los numeros son {suma}");

        }
    }
}

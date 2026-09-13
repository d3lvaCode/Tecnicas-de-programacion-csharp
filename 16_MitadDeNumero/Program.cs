namespace MitadDeNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             *MitadDeNumero: Escribir un programa que:
                a) Pida por teclado un nuumero.
                b) En el caso de que el nuumero sea distinto de cero, muestre por pantalla el mensaje:
                ’La mitad de < numero > es: < mitad >’.
                c) Repita los pasos a y b, mientras que, el n´umero sea distinto de cero.
                d) Muestre por pantalla cuantos nuumeros distintos de cero han sido introducidos por el usuario.
                        
             */

            double numero, mitad, contador = 0;

            Console.WriteLine("########## INGRESE UN NUMERO Y TE DARE SU MITAD. ##########\n");
            
                
            Console.WriteLine("Ingrese un numero: ");
            numero = double.Parse(Console.ReadLine());


            while (numero != 0)
            {

                if (numero > 0)//Si el numero es mayor de cero...
                {
                    contador = contador + 1; //va sumando cada vuelta que pide el numero cumpliendo la condicion que sea mayor a cero
                    mitad = numero / 2;
                    Console.WriteLine($"La mitad de {numero} es: {mitad}\n");
                    Console.WriteLine("Ingrese otro numero: ");
                    numero = double.Parse(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("ERROR: ingrese un numero mayor a cero.");
                    Console.WriteLine("Ingrese un numero: ");
                    numero = double.Parse(Console.ReadLine());
                }
                

            }

            Console.WriteLine("Se ingresaron " + contador + " números.");







        }
    }
}

namespace _15_CalificacionSegunNota
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
             * 
             * 1. CalificacionSegunNota: Escribir un programa que:
                    a) Pida por teclado la nota de una asignatura.
                    b) En el caso de que la nota sea incorrecta, muestre por pantalla el mensaje:
                    ’ERROR: Nota incorrecta, debe ser >= 0 y <= 10’.
                    c) Repetir los pasos a y b, mientras que, la nota introducida sea incorrecta.
                    d) Mostrar por pantalla:
                    ’APROBADO’, si la nota es mayor o igual que 4. ’DESAPROBADO’, en el caso
                    de que la nota sea menor que 4.
                    Nota: Utilizar un bucle while (mientras).
            */

            int nota;

            Console.WriteLine("Ingrese la nota: ");
            nota = int.Parse(Console.ReadLine());


            while (nota < 0 || nota > 10) //Valido primero que la nota exista que sea MAYOR DE CERO Y NO MAYOR A 10, si no se vuelvo a pedir la nota.
            {
                Console.WriteLine("ERROR: Nota incorrecta, debe ser mayor a cero y menor a diez, intente de nuevo.");
                Console.WriteLine("Ingrese la nota: ");
                nota = int.Parse(Console.ReadLine());
            }//cierra while 

            if( nota >= 4) //La nota es mayor a 4?
            {
                Console.WriteLine("APROBADO.");
            }
            else
            {
                Console.WriteLine("DESAPROBASTE.");
            }






        }
    }
}

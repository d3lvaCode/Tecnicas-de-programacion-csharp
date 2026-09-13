namespace _14_EstadisticaPersonas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Se ingresan Número de documento, edad, y sexo (F o M) de un conjunto de personas.
             * 
             * Este conjunto de datos finaliza al ingresar el Número de documento 0 (inexistente). 
             * Se pide: 
                a. ¿Cuántas personas tienen más de 40 años? 
                b. Cantidad de hombres y cantidad de mujeres. 
                c. Promedio de edades.  
             */
            Console.WriteLine("###### PROGRAMA PARA SACAR ESTADISTICA DE LAS PERSONAS ######\n");

            // Declaramos todas las variables numéricas juntas: documento (DNI), edad, y los
            // contadores/acumuladores que vamos a ir sumando dentro del bucle.
            // "documento" arranca en 0 nada más como valor inicial de la variable (se pisa enseguida con el dato real).
            double documento = 0, edad, mayoresDe40 = 0, masculino = 0, femenino = 0, sumaEdades = 0, cantidadDePersonas = 0;
            char genero;
            // Variable para el género: un solo carácter ('F' o 'M')

            Console.WriteLine("Ingresa el Nro de DNI de la persona: ");
            // Leemos el texto tipiado por el usuario y lo convertimos a double
            documento = double.Parse(Console.ReadLine());

            // Mientras el último DNI cargado no sea 0, seguimos pidiendo personas
            while (documento != 0)
            {
                Console.WriteLine("Ingresa la edad: ");
                edad = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el genero (F o M): ");
                // char.Parse convierte el texto a un char (exige que sea un solo carácter)
                genero = char.Parse(Console.ReadLine());


                // Recordatorio de cómo cortar la carga
                Console.WriteLine("### Presione '0' para finalizar. ###");
                // Pedimos el DNI de la SIGUIENTE persona (o el 0 para terminar)
                Console.WriteLine("Ingresa el Nro de DNI de la persona: ");
                // Guardamos ese nuevo DNI: es el valor que el "while" va a chequear en la próxima vuelta
                documento = double.Parse(Console.ReadLine());


                // Si la persona que acabamos de cargar tiene más de 40 años, sumamos uno al contador
                if (edad > 40)
                {
                    mayoresDe40++;
                }
                // Si el género cargado fue 'm' o 'M', es hombre: sumamos uno a masculino
                if (genero == 'm' || genero == 'M')
                {
                    masculino++;
                }
                else // Si no cayó en el if anterior, la contamos como mujer

                {
                    femenino++;
                }

                // Sumamos la edad de esta persona al acumulador total (lo vamos a usar para el promedio)
                sumaEdades += edad;
                cantidadDePersonas++;  // Sumamos uno a la cantidad total de personas cargadas


            }//cierra while

            //INFORMES 
            // A partir de acá el bucle ya terminó (se cargó el 0): mostramos los resultados finales
            Console.WriteLine("#################### INFORMES ####################\n");
            Console.WriteLine("Cantidad mayores de 40 son:" + mayoresDe40);
            Console.WriteLine("Cantidad de masculinos:" + masculino);
            Console.WriteLine("Cantidad de femeninos:" + femenino + "\n");
            double promedioEdades = sumaEdades / cantidadDePersonas;
            // Mostramos el promedio usando interpolación de strings ($"...")
            Console.WriteLine($"Promedio de edad: {promedioEdades}");


            
        }
    }
}

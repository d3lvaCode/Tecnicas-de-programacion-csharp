namespace _22_LiquidacionDeSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Desarrollar un programa (diagrama y codificación) para realizar el cálculo del salario del mes de
                diciembre de los empleados de una institución.
                Para ello se deberá pedir el ingreso de la siguiente información, siempre y cuando el número de
                empleado sea distinto de cero:
                - Número de empleado
                - Sueldo a pagar
                - Bonificación (si/no)

              A.-  En caso de que reciba bonificación, la misma será de un 20% del sueldo a pagar.
              B.- Por otro lado, deberá calcularse el aguinaldo correspondiente al empleado sabiendo que el mismo es medio sueldo a pagar, sin aplicar la bonificación.
              C.- Por cada empleado se debe realizar la siguiente salida en pantalla respetando la distribución de la
                información y principalmente la cantidad de decimales, si corresponde:
              D.- Finalmente, se desea conocer número de empleado y sueldo total a pagar de quien recibe el mayor
                sueldo total.             
             */

            int numeroEmpleado;
            float sueldo = 0, bonificacion20 = 0, sueldoBonificado = 0, aguinaldo = 0, aguinaldoTotal = 0, sueldoTotal = 0, band = 0, sueldoMayor = 0, empleadoMayorsueldo = 0;
            string bonificacion;
            //string sinBono = "Sin Bonificacion";



            Console.WriteLine("Ingrese numero de empleado: ");
            numeroEmpleado = int.Parse(Console.ReadLine());

            while (numeroEmpleado != 0)
            {


                Console.WriteLine("Ingrese el sueldo: ");
                sueldo = float.Parse(Console.ReadLine());

                Console.WriteLine("Tienen bonificacion (Si / No): ");
                bonificacion = Console.ReadLine();

                if (bonificacion == "si") // Punto A
                {
                    bonificacion20 = sueldo * 20 / 100; // primero sacamos el 20% de su sueldo
                    sueldoBonificado = sueldo + bonificacion20; // Luego sumamos el 20% a su sueldo
                }
                else
                {
                    bonificacion20 = 0;
                    

                }

                aguinaldo = sueldo / 2; // Calculamos su aguinado
                aguinaldoTotal = sueldo + aguinaldo; // Sumamos su aguinaldo mas su sueldo


                sueldoTotal = sueldo + aguinaldo + bonificacion20;


                // informes por cada empleado

                Console.WriteLine("##############################################################"); // Punto C

                Console.WriteLine("Numero de empleado: " + numeroEmpleado + "\n");
               
                Console.WriteLine($"Sueldo a pagar: {sueldo:F2}");
                Console.WriteLine($"Bonificacion: {bonificacion20:F2}");
                Console.WriteLine($"Aguinaldo: {aguinaldo:F2} \n");

                Console.WriteLine($"Sueldo total a pagar: {sueldoTotal:F2}");

                Console.WriteLine("##############################################################");

                //Algoritmo de mayor sueldo

                if (band == 0) //Entramos al algortimo para capturar el primer valor ingresado.
                {
                    sueldoMayor = sueldoTotal; //Capturamos el primer sueldo ingresado
                    empleadoMayorsueldo = numeroEmpleado; //capturamos el empleado con mayor sueldo hasta el momento
                    band = 1; // Levantamos la bandera ya que tenemos nuestro primer valor de referencia 
                }
                else
                {
                    if(sueldoTotal > sueldoMayor) // Volvemos a preguntar si el nuevo valor de referencia es mayor al que teniamos antes.
                    {

                        empleadoMayorsueldo = numeroEmpleado;
                        sueldoMayor = sueldoTotal; //Si se cumple la condicion pisamos el viejo valor por el nuevo 



                    }
                }


                Console.WriteLine("Ingrese numero de empleado: ", "/n");
                numeroEmpleado = int.Parse(Console.ReadLine());





            }//cierra while

            //INFORMES DEL MAYO EMPLEADO ENCONTRADO

            Console.WriteLine("############################################################## \n"); //Punto D
            Console.WriteLine("El numero del empleado de mayor sueldo es: " + empleadoMayorsueldo);
            Console.WriteLine("Sueldo total a pagar del mayor: " + sueldoMayor + "\n");
            Console.WriteLine("##############################################################");


        }
    }
}

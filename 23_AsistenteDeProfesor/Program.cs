
namespace _23_AsistenteDeProfesor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Realizar el algoritmo y codificar en lenguaje C#, un programa para la organización de profesor de matemática
                de un establecimiento educativo, que registra de cada uno de sus 30 alumnos los siguientes datos:
                Número de legajo.
                Promedio de notas.
                .
                Según el promedio se necesita saber e informar por pantalla:
                a.- Cuántos alumnos aprobaron (promedio mayor o igual a 7) y el promedio de notas que representa (los
                aprobados).
                b.- Cuántos rinden examen en diciembre (promedio menor a 7 y mayor o igual a 4).
                c.-Cuántos rinden examen en marzo (promedio menor a 4).
                d.- Total de alumnos que deben rendir examen.
                e.- Número de legajo del alumno y promedio general, del alumno con mejor promedio. 
            */
            double legajo, cantAprobados = 0, sumaAprobados = 0, cantDesaprobados = 0, promedioAprobados = 0, cantDiciembre = 0, cantMarzo = 0;
            float promedioDeNotas;
            double band = 0, mejorAlumno = 0, mejorPromedio = 0;


            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Ingresa el numero de legajo: ");
                legajo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el promedio de notas: ");
                promedioDeNotas = float.Parse(Console.ReadLine());

                if (promedioDeNotas >= 7)
                {
                    cantAprobados++; //contador de los aprobados
                    sumaAprobados += promedioDeNotas; //acumulador
                }
                if(promedioDeNotas >= 4 && promedioDeNotas < 7) //punto b
                {
                    cantDiciembre++;
                }
                if (promedioDeNotas < 4 ) //punto c
                {
                    cantMarzo++;
                }

                if (band == 0)
                {
                    mejorAlumno = legajo;
                    mejorPromedio = promedioDeNotas;
                    band = 1;
                }
                else
                {
                    if (promedioDeNotas > mejorPromedio)
                    {
                        mejorAlumno = legajo;
                        mejorPromedio = promedioDeNotas;
                    }

                }


            }//cierra for
            
            // Punto a: DESPUÉS del for, cuando ya cargaste todos
            if (cantAprobados > 0)
            {
                promedioAprobados = sumaAprobados / cantAprobados;
            }
            cantDesaprobados = cantDiciembre + cantMarzo;// Punto d, suma de alumnos que rinden examen
            
            //INFORMES 
            Console.WriteLine("#########################################################################");
            Console.WriteLine("########################### I N F O R M E S #############################\n");
            Console.WriteLine($"Cantidad de aprobados: {cantAprobados}");
            Console.WriteLine($"Promedio de los aprobados: {promedioAprobados:F2}");
            Console.WriteLine($"Cantidad de alumnos que rinden en Diciembre: {cantDiciembre}");
            Console.WriteLine($"Cantidad de alumnos que rinden en Marzo: {cantMarzo}");
            Console.WriteLine($"Total alumnos que rinden examen: {cantDesaprobados} \n");
            Console.WriteLine("######################## ALUMNO MEJOR PROMEDIO ########################\n");
            Console.WriteLine($"Legajo mejor promedio: {mejorAlumno}");
            Console.WriteLine($"Mejor promedio: {mejorPromedio:F2}");

        }
    }
}

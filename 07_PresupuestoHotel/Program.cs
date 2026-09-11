namespace _07_PresupuestoHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Una familia de 4 personas desea irse de viaje. Para esto deben tener en cuenta lo siguiente: 
                a) Precio de pasajes aéreos. 
                b) Precio de un hotel por noche. 
                c) Cantidad de noches. 
                d) Alquiler de un auto (precio por día). 

            El programa debe calcular el total que saldrá el viaje, teniendo en cuenta que el alquiler del auto será por la mitad de la estadía
             */

            double PrecioPasajes, PrecioPorNoche, PrecioPorDiaAuto, TotalBrutoDelViaje, PrecioTotalDelAuto, TotalNetoDelViaje;
            int CantidadDeNoche;


            Console.WriteLine("SACARE EL PRECIO DE LO QUE TE COSTARÁ TUS VACACIONES");
            // PEDIMOS LOS DATOS
            Console.WriteLine("Ingresa el precio de tus pasajes aereos: ");
            PrecioPasajes = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el precio de la noche de hotel: ");
            PrecioPorNoche = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la cantidad de noches de estadia: ");
            CantidadDeNoche = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el precio del alquiler del auto por dia: ");
            PrecioPorDiaAuto = double.Parse(Console.ReadLine());

            // CALCULAMOS EL VIAJE
            TotalBrutoDelViaje = (PrecioPorNoche * CantidadDeNoche) + PrecioPasajes;
            PrecioTotalDelAuto = (PrecioPorDiaAuto * CantidadDeNoche) / 2;
            TotalNetoDelViaje = TotalBrutoDelViaje + PrecioTotalDelAuto;

            // INFORMES
            Console.WriteLine("################ TU PRESUPUESTO ################");
            Console.WriteLine($"El costo total bruto de tu estadia es: {TotalBrutoDelViaje}. ");
            Console.WriteLine($"El costo total neto de tu estadia con el auto es: {TotalNetoDelViaje}. ");

            Console.WriteLine("Muchas gracias.");


        }
    }
}

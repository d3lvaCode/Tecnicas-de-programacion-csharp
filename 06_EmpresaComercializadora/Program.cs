namespace EmpresaComercializadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Una empresa comercializa 3 productos y desea saber cuál es el que le da mayor porcentaje de ventas. 
                * Para esto debe ingresar el total recaudado por cada producto y el valor de cada uno. 
                * Tener en cuenta que el programa debe informar la cantidad vendida de cada producto, y su total de ventas y el porcentaje que dicha cantidad de ventas significa del total.
             */

            string ProductoUno, ProductoDos, ProductoTres;
            double PrecioUnitarioUno, PrecioUnitarioDos, PrecioUnitarioTres;
            double RecaudoProductoUno, RecaudoProductoDos, RecaudoProductoTres;
            double CantidadVendidaUno, CantidadVendidaDos, CantidadVendidaTres;
            double totalRecaudado;
            double porcentajeUno, porcentajeDos, porcentajeTres;
            
            //Nombre > Recaudo > PrecioUnitario

            // INGRESO PRODUCTO UNO Y ALMACENO DATOS
            Console.WriteLine("Ingrese el nombre del producto 1: ");
            ProductoUno = Console.ReadLine();
            Console.WriteLine($"Ingrese el precio de {ProductoUno}: ");
            PrecioUnitarioUno = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ingrese el total recaudado: ");
            RecaudoProductoUno = double.Parse(Console.ReadLine());

            // INGRESO PRODUCTO DOS Y ALMACENO DATOS
            Console.WriteLine("Ingrese el nombre del producto 2: ");
            ProductoDos = Console.ReadLine();
            Console.WriteLine($"Ingrese el precio de {ProductoDos}: ");
            PrecioUnitarioDos = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ingrese el total recaudado: ");
            RecaudoProductoDos = double.Parse(Console.ReadLine());

            // INGRESO PRODUCTO TRES Y ALMACENO DATOS
            Console.WriteLine("Ingrese el nombre del producto 3: ");
            ProductoTres = Console.ReadLine();
            Console.WriteLine($"Ingrese el precio de {ProductoTres}: ");
            PrecioUnitarioTres = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ingrese el total recaudado: ");
            RecaudoProductoTres = double.Parse(Console.ReadLine());


            //SACAMOS LAS CANTIDADES VENDIDAS
            CantidadVendidaUno = RecaudoProductoUno / PrecioUnitarioUno;
            CantidadVendidaDos = RecaudoProductoDos / PrecioUnitarioDos;
            CantidadVendidaTres = RecaudoProductoTres / PrecioUnitarioTres;

            //SUMAMOS TODA LA RECAUDACION
            totalRecaudado = RecaudoProductoUno + RecaudoProductoDos + RecaudoProductoTres;

            //PORCENTAJES RESPECTO A VENTAS
            porcentajeUno = (RecaudoProductoUno / totalRecaudado) * 100;
            porcentajeDos = (RecaudoProductoDos / totalRecaudado) * 100;
            porcentajeTres = (RecaudoProductoTres / totalRecaudado) * 100;



            Console.WriteLine("######################## RECAUDACION POR PRODUCTO ###########################");
            Console.WriteLine($"Se vendienron {CantidadVendidaUno} unidades de {ProductoUno}. ");
            Console.WriteLine($"Se vendienron {CantidadVendidaDos} unidades de {ProductoDos}. ");
            Console.WriteLine($"Se vendienron {CantidadVendidaTres} unidades de {ProductoTres}. ");
            Console.WriteLine("####################### T O T A L ######################");
            Console.WriteLine("Total de dinero recaudado: $" + totalRecaudado);
            Console.WriteLine("################## PORCENTAJES RESPECTO A VENTAS ############################");
            Console.WriteLine($"El articulo {ProductoUno:F2} corresponde {porcentajeUno} al total recaudado. ");
            Console.WriteLine($"El articulo {ProductoDos:F2} corresponde {porcentajeDos} al total recaudado. ");
            Console.WriteLine($"El articulo {ProductoTres:F2} corresponde {porcentajeTres} al total recaudado. ");






        }
    }
}

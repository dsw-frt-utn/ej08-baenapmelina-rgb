namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            ProductHelper helper = new ProductHelper();

            string etiqueta = helper.ObtenerEtiquetaProducto(123, "Coca-Cola", 1500);

            Console.WriteLine("== Prueba problema 1 ==");
            Console.WriteLine(etiqueta);
            Console.WriteLine();


            Console.WriteLine("== Prueba problema 2 ==");
            Problema2 productoDescripcion = new Problema2();
            string mensaje = productoDescripcion.CrearResumenVenta(111, "Papas Fritas", 2, 3500);
            Console.WriteLine(mensaje);
            Console.WriteLine();

            Product producto = new Product(100, "Pepsi", "bebida gasificada");

            Problema3 problema = new Problema3();
            string resultado = problema.CompararCopias(10, producto);

            Console.WriteLine("== Prueba problema 3 ==");
            Console.WriteLine(resultado);
            Console.WriteLine();

            Problema4 notas = new Problema4();
            double promedio1 = notas.CalcularPromedio(8, 7, null);
            double promedio2 = notas.CalcularPromedio(8, null, -7);
            Console.WriteLine("== Prueba problema 4 ==");
            Console.WriteLine(promedio1);
            Console.WriteLine(promedio2);
            Console.WriteLine();

            Problema5 p = new Problema5();

            Sale venta1 = new RetailSale("Agua Mineral 1L", 10, 1000);
            Sale venta2 = new WholeSale("Agua Mineral 1L", 10, 1000);

            Console.WriteLine("== Prueba problema 5 ==");
            Console.WriteLine($"Precio sin descuento: {p.ObtenerImporteFinal(venta1)}");
            Console.WriteLine($"Precio con descuento: {p.ObtenerImporteFinal(venta2)}");
            Console.WriteLine();

            Problema6 problema6 = new Problema6();
            string resultado1 = problema6.NormalizarCodigoProducto("    ab 123 x    ");
            string resultado2 = problema6.NormalizarCodigoProducto(null);

            Console.WriteLine("== Prueba problema 6 ==");
            Console.WriteLine(resultado1); 
            Console.WriteLine(resultado2);
        }
    }
}

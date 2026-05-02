namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            ProductHelper helper = new ProductHelper();

            string etiqueta = helper.ObtenerEtiquetaProducto(123, "Coca-Cola", 1500);

            Console.WriteLine("Prueba problema 1");
            Console.WriteLine(etiqueta);
            Console.WriteLine();

            Product producto = new Product(100, "Pepsi", "bebida gasificada");

            Problema3 problema = new Problema3();
            string resultado = problema.CompararCopias(10, producto);

            Console.WriteLine("Prueba problema 3");
            Console.WriteLine(resultado);
            Console.WriteLine();

            Problema5 p = new Problema5();

            Sale venta1 = new RetailSale("Agua Mineral 1L", 10, 1000);
            Sale venta2 = new WholeSale("Agua Mineral 1L", 10, 1000);

            Console.WriteLine("Prueba problema 5");
            Console.WriteLine($"Precio sin descuento: {p.ObtenerImporteFinal(venta1)}");
            Console.WriteLine($"Precio con descuento: {p.ObtenerImporteFinal(venta2)}");
        }
    }
}

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            ProductHelper helper = new ProductHelper();

            string etiqueta= helper.ObtenerEtiquetaProducto(123, "Coca-Cola", 1500);

            Console.WriteLine(etiqueta);

            Product producto = new Product(100, "Pepsi", "bebida gasificada");

            Problema3 problema = new Problema3();
            string resultado = problema.CompararCopias(10, producto);

            Console.WriteLine(resultado);
        }
    }
}

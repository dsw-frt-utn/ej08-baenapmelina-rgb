namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ProductHelper helper = new ProductHelper();

            string resultado = helper.ObtenerEtiquetaProducto(123, "Mouse", 1500);

            Console.WriteLine(resultado);
        }
    }
}

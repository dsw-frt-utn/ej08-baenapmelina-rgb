using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Sale
    {
        int cantidadProd;
        string descripcionVenta;
        decimal price;
        public Sale (string descripcion, int cantidad, decimal precio)
        {
            this.cantidadProd = cantidad;
            this.descripcionVenta = descripcion;
            this.price = precio;
        }
        public virtual decimal CalculateTotal()
        {
            return cantidadProd * price;
        }
    }
}
